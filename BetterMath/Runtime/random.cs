using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Unity.IL2CPP.CompilerServices;

using static CGTK.Utilities.BetterMath.Maths;

using F32 = System.Single;
using F64 = System.Double;

using I32 = System.Int32;
using I64 = System.Int64;

using U32 = System.UInt32;
using U64 = System.UInt64;

namespace CGTK.Utilities.BetterMath
{
    /// <summary>
    /// Random Number Generator based on xorshift.
    /// Designed for minimal state (32bits) to be easily embeddable into components.
    /// Core functionality is integer multiplication free to improve vectorization
    /// on less capable SIMD instruction sets.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    [Serializable]
    public partial struct Random
    {
        /// <summary>
        /// The random number generator state. It should not be zero.
        /// </summary>
        public U32 state;

        /// <summary>
        /// Constructs a Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        /// <param name="seed">The seed to initialize with.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random(U32 seed)
        {
            state = seed;
            CheckInitState();
            NextState();
        }

        /// <summary>
        /// Constructs a <see cref="Random"/> instance with an index that gets hashed.  The index must not be uint.MaxValue.
        /// </summary>
        /// <remarks>
        /// Use this function when you expect to create several Random instances in a loop.
        /// </remarks>
        /// <example>
        /// <code>
        /// for (uint i = 0; i &lt; 4096; ++i)
        /// {
        ///     Random rand = Random.CreateFromIndex(i);
        ///
        ///     // Random numbers drawn from loop iteration j will be very different
        ///     // from every other loop iteration k.
        ///     rand.NextUInt();
        /// }
        /// </code>
        /// </example>
        /// <param name="index">An index that will be hashed for Random creation.  Must not be uint.MaxValue.</param>
        /// <returns><see cref="Random"/> created from an index.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Random CreateFromIndex(U32 index)
        {
            CheckIndexForHash(index);

            // Wang hash will hash 61 to zero but we want uint.MaxValue to hash to zero.  To make this happen
            // we must offset by 62.
            return new Random(seed: WangHash(n: index + 62u));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static U32 WangHash(U32 n)
        {
            // https://gist.github.com/badboy/6267743#hash-function-construction-principles
            // Wang hash: this has the property that none of the outputs will
            // collide with each other, which is important for the purposes of
            // seeding a random number generator.  This was verified empirically
            // by checking all 2^32 uints.
            n = (n ^ 61u) ^ (n >> 16);
            n *= 9u;
            n = n ^ (n >> 4);
            n *= 0x27d4eb2du;
            n = n ^ (n >> 15);

            return n;
        }

        /// <summary>
        /// Initialized the state of the Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        /// <param name="seed">The seed to initialize with.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InitState(U32 seed = 0x6E624EB7u)
        {
            state = seed;
            NextState();
        }

        /// <summary>Returns a uniformly random bool value.</summary>
        /// <returns>A uniformly random boolean value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean NextBool()
        {
            return (NextState() & 1) == 1;
        }

        /// <summary>Returns a uniformly random Boolx2 value.</summary>
        /// <returns>A uniformly random Boolx2 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolx2 NextBool2()
        {
            U32 v = NextState();
            return (new U32x2(v) & new U32x2(1, 2)) == 0;
        }

        //TODO: replace "& new U32xN" with readonly's?

        /// <summary>Returns a uniformly random Boolx3 value.</summary>
        /// <returns>A uniformly random Boolx3 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolx3 NextBool3()
        {
            U32 v = NextState();
            return (new U32x3(v) & new U32x3(1, 2, 4)) == 0;
        }

        /// <summary>Returns a uniformly random Boolx4 value.</summary>
        /// <returns>A uniformly random Boolx4 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolx4 NextBool4()
        {
            U32 v = NextState();
            return (new U32x4(v) & new U32x4(1, 2, 4, 8)) == 0;
        }


        /// <summary>Returns a uniformly random int value in the interval [-2147483647, 2147483647].</summary>
        /// <returns>A uniformly random integer value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32 NextI32()
        {
            return (I32)NextState() ^ -2147483648;
        }

        /// <summary>Returns a uniformly random I32x2 value with all components in the interval [-2147483647, 2147483647].</summary>
        /// <returns>A uniformly random I32x2 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x2 NextI32x2()
        {
            return new I32x2(x: (I32)NextState(), y: (I32)NextState()) ^ -2147483648;
        }

        /// <summary>Returns a uniformly random I32x3 value with all components in the interval [-2147483647, 2147483647].</summary>
        /// <returns>A uniformly random I32x3 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x3 NextI32x3()
        {
            return new I32x3(x: (I32)NextState(), y: (I32)NextState(), z: (I32)NextState()) ^ -2147483648;
        }

        /// <summary>Returns a uniformly random I32x4 value with all components in the interval [-2147483647, 2147483647].</summary>
        /// <returns>A uniformly random I32x4 value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x4 NextI32x4()
        {
            return new I32x4(x: (I32)NextState(), y: (I32)NextState(), z: (I32)NextState(), w: (I32)NextState()) ^ -2147483648;
        }

        /// <summary>Returns a uniformly random int value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random int value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32 NextI32(I32 max)
        {
            CheckNextIntMax(max);
            return (I32)((NextState() * (U64)max) >> 32);
        }

        /// <summary>Returns a uniformly random I32x2 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x2 value with all components in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x2 NextI32x2(I32x2 max)
        {
            CheckNextIntMax(max.x);
            CheckNextIntMax(max.y);
            return new I32x2(x: (I32)(NextState() * (U64)max.x >> 32),
                             y: (I32)(NextState() * (U64)max.y >> 32));
        }

        /// <summary>Returns a uniformly random I32x3 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x3 value with all components in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x3 NextI32x3(I32x3 max)
        {
            CheckNextIntMax(max.x);
            CheckNextIntMax(max.y);
            CheckNextIntMax(max.z);
            return new I32x3(x: (I32)(NextState() * (U64)max.x >> 32),
                             y: (I32)(NextState() * (U64)max.y >> 32),
                             z: (I32)(NextState() * (U64)max.z >> 32));
        }

        /// <summary>Returns a uniformly random I32x4 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x4 value with all components in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x4 NextI32x4(I32x4 max)
        {
            CheckNextIntMax(max.x);
            CheckNextIntMax(max.y);
            CheckNextIntMax(max.z);
            CheckNextIntMax(max.w);
            return new I32x4(x: (I32)(NextState() * (U64)max.x >> 32),
                             y: (I32)(NextState() * (U64)max.y >> 32),
                             z: (I32)(NextState() * (U64)max.z >> 32),
                             w: (I32)(NextState() * (U64)max.w >> 32));
        }

        /// <summary>Returns a uniformly random int value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random integer between [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32 NextI32(I32 min, I32 max)
        {
            CheckNextIntMinMax(min, max);
            U32 range = (U32)(max - min);
            return (I32)(NextState() * (U64)range >> 32) + min;
        }

        /// <summary>Returns a uniformly random I32x2 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x2 between [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x2 NextI32x2(I32x2 min, I32x2 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            U32x2 range = (U32x2)(max - min);
            return new I32x2(x: (I32)(NextState() * (U64)range.x >> 32),
                        y: (I32)(NextState() * (U64)range.y >> 32)) + min;
        }

        /// <summary>Returns a uniformly random I32x3 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x3 between [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x3 NextI32x3(I32x3 min, I32x3 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            CheckNextIntMinMax(min.z, max.z);
            U32x3 range = (U32x3)(max - min);
            return new I32x3(x: (I32)(NextState() * (U64)range.x >> 32),
                        y: (I32)(NextState() * (U64)range.y >> 32),
                        z: (I32)(NextState() * (U64)range.z >> 32)) + min;
        }

        /// <summary>Returns a uniformly random I32x4 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random I32x4 between [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32x4 NextI32x4(I32x4 min, I32x4 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            CheckNextIntMinMax(min.z, max.z);
            CheckNextIntMinMax(min.w, max.w);
            U32x4 range = (U32x4)(max - min);
            return new I32x4(
                        x: (I32)(NextState() * (U64)range.x >> 32),
                        y: (I32)(NextState() * (U64)range.y >> 32),
                        z: (I32)(NextState() * (U64)range.z >> 32),
                        w: (I32)(NextState() * (U64)range.w >> 32)) + min;
        }

        /// <summary>Returns a uniformly random uint value in the interval [0, 4294967294].</summary>
        /// <returns>A uniformly random unsigned integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32 NextUInt()
        {
            return NextState() - 1u;
        }

        /// <summary>Returns a uniformly random U32x2 value with all components in the interval [0, 4294967294].</summary>
        /// <returns>A uniformly random U32x2.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x2 NextU32x2()
        {
            return new U32x2(x: NextState(), y: NextState()) - 1u;
        }

        /// <summary>Returns a uniformly random U32x3 value with all components in the interval [0, 4294967294].</summary>
        /// <returns>A uniformly random U32x3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x3 NextU32x3()
        {
            return new U32x3(x: NextState(), y: NextState(), z: NextState()) - 1u;
        }

        /// <summary>Returns a uniformly random U32x4 value with all components in the interval [0, 4294967294].</summary>
        /// <returns>A uniformly random U32x4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x4 NextU32x4()
        {
            return new U32x4(x: NextState(), y: NextState(), z: NextState(), w: NextState()) - 1u;
        }


        /// <summary>Returns a uniformly random uint value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random unsigned integer in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32 NextUInt(U32 max)
        {
            return (U32)((NextState() * (U64)max) >> 32);
        }

        /// <summary>Returns a uniformly random U32x2 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x2 in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x2 NextU32x2(U32x2 max)
        {
            return new U32x2(
                x: (U32) (NextState() * (U64) max.x >> 32),
                y: (U32)(NextState() * (U64)max.y >> 32));
        }

        /// <summary>Returns a uniformly random U32x3 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x3 in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x3 NextU32x3(U32x3 max)
        {
            return new U32x3(
                x: (U32)(NextState() * (U64)max.x >> 32),
                y: (U32)(NextState() * (U64)max.y >> 32),
                z: (U32)(NextState() * (U64)max.z >> 32));
        }

        /// <summary>Returns a uniformly random U32x4 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x4 in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x4 NextU32x4(U32x4 max)
        {
            return new U32x4(
                x: (U32)(NextState() * (U64)max.x >> 32),
                y: (U32)(NextState() * (U64)max.y >> 32),
                z: (U32)(NextState() * (U64)max.z >> 32),
                w: (U32)(NextState() * (U64)max.w >> 32));
        }

        /// <summary>Returns a uniformly random uint value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random unsigned integer in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32 NextUInt(U32 min, U32 max)
        {
            CheckNextUIntMinMax(min, max);
            U32 range = max - min;
            return (U32)(NextState() * (U64)range >> 32) + min;
        }

        /// <summary>Returns a uniformly random U32x2 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x2 in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x2 NextU32x2(U32x2 min, U32x2 max)
        {
            CheckNextUIntMinMax(min.x, max.x);
            CheckNextUIntMinMax(min.y, max.y);
            U32x2 range = max - min;
            return new U32x2(
                x: (U32)(NextState() * (U64)range.x >> 32),
                y: (U32)(NextState() * (U64)range.y >> 32)) + min;
        }

        /// <summary>Returns a uniformly random U32x3 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x3 in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x3 NextU32x3(U32x3 min, U32x3 max)
        {
            CheckNextUIntMinMax(min.x, max.x);
            CheckNextUIntMinMax(min.y, max.y);
            CheckNextUIntMinMax(min.z, max.z);
            U32x3 range = max - min;
            return new U32x3(
                x: (U32)(NextState() * (U64)range.x >> 32),
                y: (U32)(NextState() * (U64)range.y >> 32),
                z: (U32)(NextState() * (U64)range.z >> 32)) + min;
        }

        /// <summary>Returns a uniformly random U32x4 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random U32x4 in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32x4 NextU32x4(U32x4 min, U32x4 max)
        {
            CheckNextUIntMinMax(min.x, max.x);
            CheckNextUIntMinMax(min.y, max.y);
            CheckNextUIntMinMax(min.z, max.z);
            CheckNextUIntMinMax(min.w, max.w);
            U32x4 range = max - min;
            return new U32x4(
                        x: (U32)(NextState() * (U64)range.x >> 32),
                        y: (U32)(NextState() * (U64)range.y >> 32),
                        z: (U32)(NextState() * (U64)range.z >> 32),
                        w: (U32)(NextState() * (U64)range.w >> 32)) + min;
        }

        /// <summary>Returns a uniformly random F32 value in the interval [0, 1).</summary>
        /// <returns>A uniformly random F32 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32 NextF32()
        {

            var t = (0x3f800000 | (NextState() >> 9));
            return AsF32( x: (0x3f800000 | (NextState() >> 9)) ) - 1.0f;
        }

        /// <summary>Returns a uniformly random F32x2 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F32x2 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x2 NextF32x2()
        {
            return AsF32(x: 0x3f800000 | (new U32x2(x: NextState(), y: NextState()) >> 9)) - 1.0f;
        }

        /// <summary>Returns a uniformly random F32x3 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F32x3 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x3 NextF32x3()
        {
            return AsF32(x: 0x3f800000 | (new U32x3(x: NextState(), y: NextState(), z: NextState()) >> 9)) - 1.0f;
        }

        /// <summary>Returns a uniformly random F32x4 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F32x4 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x4 NextF32x4()
        {
            return AsF32(x: 0x3f800000 | (new U32x4(x: NextState(), y: NextState(), z: NextState(), w: NextState()) >> 9)) - 1.0f;
        }


        /// <summary>Returns a uniformly random F32 value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32 NextF32(F32 max) { return NextF32() * max; }

        /// <summary>Returns a uniformly random F32x2 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x2 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x2 NextF32x2(F32x2 max) { return NextF32x2() * max; }

        /// <summary>Returns a uniformly random F32x3 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x3 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x3 NextF32x3(F32x3 max) { return NextF32x3() * max; }

        /// <summary>Returns a uniformly random F32x4 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x4 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x4 NextF32x4(F32x4 max) { return NextF32x4() * max; }


        /// <summary>Returns a uniformly random F32 value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32 NextF32(F32 min, F32 max) { return NextF32() * (max - min) + min; }

        /// <summary>Returns a uniformly random F32x2 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x2 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x2 NextF32x2(F32x2 min, F32x2 max) { return NextF32x2() * (max - min) + min; }

        /// <summary>Returns a uniformly random F32x3 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x3 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x3 NextF32x3(F32x3 min, F32x3 max) { return NextF32x3() * (max - min) + min; }

        /// <summary>Returns a uniformly random F32x4 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F32x4 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x4 NextF32x4(F32x4 min, F32x4 max) { return NextF32x4() * (max - min) + min; }



        /// <summary>Returns a uniformly random F64 value in the interval [0, 1).</summary>
        /// <returns>A uniformly random F64 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64 NextF64()
        {
            U64 sx = ((U64)NextState() << 20) ^ NextState();
            return AsF64(x: 0x3ff0000000000000 | sx) - 1.0;
        }

        /// <summary>Returns a uniformly random F64x2 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F64x2 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x2 NextF64x2()
        {
            U64 sx = ((U64)NextState() << 20) ^ NextState();
            U64 sy = ((U64)NextState() << 20) ^ NextState();
            return new F64x2(
                x: AsF64(x: 0x3ff0000000000000 | sx),
                y: AsF64(x: 0x3ff0000000000000 | sy)) - 1.0;
        }

        /// <summary>Returns a uniformly random F64x3 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F64x3 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x3 NextF64x3()
        {
            U64 sx = ((U64)NextState() << 20) ^ NextState();
            U64 sy = ((U64)NextState() << 20) ^ NextState();
            U64 sz = ((U64)NextState() << 20) ^ NextState();
            return new F64x3(
                x: AsF64(x: 0x3ff0000000000000 | sx),
                y: AsF64(x: 0x3ff0000000000000 | sy),
                z: AsF64(x: 0x3ff0000000000000 | sz)) - 1.0;
        }

        /// <summary>Returns a uniformly random F64x4 value with all components in the interval [0, 1).</summary>
        /// <returns>A uniformly random F64x4 value in the range [0, 1).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x4 NextF64x4()
        {
            U64 sx = ((U64)NextState() << 20) ^ NextState();
            U64 sy = ((U64)NextState() << 20) ^ NextState();
            U64 sz = ((U64)NextState() << 20) ^ NextState();
            U64 sw = ((U64)NextState() << 20) ^ NextState();
            return new F64x4(
                x: AsF64(x: 0x3ff0000000000000 | sx),
                y: AsF64(x: 0x3ff0000000000000 | sy),
                z: AsF64(x: 0x3ff0000000000000 | sz),
                w: AsF64(x: 0x3ff0000000000000 | sw)) - 1.0;
        }


        /// <summary>Returns a uniformly random F64 value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64 NextF64(F64 max) { return NextF64() * max; }

        /// <summary>Returns a uniformly random F64x2 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x2 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x2 NextF64x2(F64x2 max) { return NextF64x2() * max; }

        /// <summary>Returns a uniformly random F64x3 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x3 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x3 NextF64x3(F64x3 max) { return NextF64x3() * max; }

        /// <summary>Returns a uniformly random F64x4 value with all components in the interval [0, max).</summary>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x4 value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x4 NextF64x4(F64x4 max) { return NextF64x4() * max; }


        /// <summary>Returns a uniformly random F64 value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64 NextF64(F64 min, F64 max) { return NextF64() * (max - min) + min; }

        /// <summary>Returns a uniformly random F64x2 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x2 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x2 NextF64x2(F64x2 min, F64x2 max) { return NextF64x2() * (max - min) + min; }

        /// <summary>Returns a uniformly random F64x3 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x3 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x3 NextF64x3(F64x3 min, F64x3 max) { return NextF64x3() * (max - min) + min; }

        /// <summary>Returns a uniformly random F64x4 value with all components in the interval [min, max).</summary>
        /// <param name="min">The componentwise minimum value to generate, inclusive.</param>
        /// <param name="max">The componentwise maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random F64x4 value in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x4 NextF64x4(F64x4 min, F64x4 max) { return NextF64x4() * (max - min) + min; }

        /// <summary>Returns a unit length F32x2 vector representing a uniformly random 2D direction.</summary>
        /// <returns>A uniformly random unit length F32x2 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x2 NextF32x2Direction()
        {
            F32 angle = NextF32() * PI * 2.0f;
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x2(c, s);
        }

        /// <summary>Returns a unit length F64x2 vector representing a uniformly random 2D direction.</summary>
        /// <returns>A uniformly random unit length F64x2 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x2 NextF64x2Direction()
        {
            F64 angle = NextF64() * PI_DBL * 2.0;
            F64 s, c;
            sincos(angle, out s, out c);
            return new F64x2(c, s);
        }

        /// <summary>Returns a unit length F32x3 vector representing a uniformly random 3D direction.</summary>
        /// <returns>A uniformly random unit length F32x3 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F32x3 NextF32x3Direction()
        {
            F32x2 rnd = NextF32x2();
            F32 z = rnd.x * 2.0f - 1.0f;
            F32 r = sqrt(x: max(x: 1.0f - z * z, 0.0f));
            F32 angle = rnd.y * PI * 2.0f;
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x3(x: c*r, y: s*r, z);
        }

        /// <summary>Returns a unit length F64x3 vector representing a uniformly random 3D direction.</summary>
        /// <returns>A uniformly random unit length F64x3 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F64x3 NextF643Direction()
        {
            F64x2 rnd = NextF64x2();
            F64 z = rnd.x * 2.0 - 1.0;
            F64 r = sqrt(x: max(x: 1.0 - z * z, 0.0));
            F64 angle = rnd.y * PI_DBL * 2.0;
            F64 s, c;
            sincos(angle, out s, out c);
            return new F64x3(x: c * r, y: s * r, z);
        }

        /// <summary>Returns a unit length Quaternion representing a uniformly 3D rotation.</summary>
        /// <returns>A uniformly random unit length Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion NextQuaternionRotation()
        {
            F32x3 rnd = NextF32x3(max: new F32x3(x: 2.0f * PI, y: 2.0f * PI, 1.0f));
            F32 u1 = rnd.z;
            F32x2 theta_rho = rnd.xy;

            F32 i = sqrt(x: 1.0f - u1);
            F32 j = sqrt(u1);

            sincos(theta_rho, s: out F32x2 sin_theta_rho, c: out F32x2 cos_theta_rho);

            Quaternion q = new Quaternion(x: i * sin_theta_rho.x, y: i * cos_theta_rho.x, z: j * sin_theta_rho.y, w: j * cos_theta_rho.y);
            return new Quaternion(value: select(q.value, -q.value, c: q.value.w < 0.0f));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private U32 NextState()
        {
            CheckState();
            U32 t = state;
            state ^= state << 13;
            state ^= state >> 17;
            state ^= state << 5;
            return t;
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckInitState()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (state == 0)
                throw new System.ArgumentException(message: "Seed must be non-zero");
#endif
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        static void CheckIndexForHash(U32 index)
        {
            if (index == uint.MaxValue)
                throw new System.ArgumentException(message: "Index must not be uint.MaxValue");
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckState()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if(state == 0)
                throw new System.ArgumentException(message: "Invalid state 0. Random object has not been properly initialized");
#endif
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextIntMax(I32 max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (max < 0)
                throw new System.ArgumentException(message: "max must be positive");
#endif
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextIntMinMax(I32 min, I32 max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (min > max)
                throw new System.ArgumentException(message: "min must be less than or equal to max");
#endif
        }

        [Conditional(conditionString: "ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextUIntMinMax(U32 min, U32 max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (min > max)
                throw new System.ArgumentException(message: "min must be less than or equal to max");
#endif
        }

    }
}
