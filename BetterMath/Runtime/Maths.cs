using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using Unity.IL2CPP.CompilerServices;

using Bool = System.Boolean;

using F32 = System.Single;
using F64 = System.Double;

using I08 = System.SByte;
using I16 = System.Int16;
using I32 = System.Int32;
using I64 = System.Int64;

using U08 = System.Byte;
using U16 = System.UInt16;
using U32 = System.UInt32;
using U64 = System.UInt64;

namespace CGTK.Utilities.BetterMath
{
    /// <summary>
    /// A static class to contain various math functions and constants.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    public static partial class Maths
    {
        /// <summary>Extrinsic rotation order. Specifies in which order rotations around the principal axes (x, y and z) are to be applied.</summary>
        public enum RotationOrder : U08
        {
            /// <summary>Extrinsic rotation around the x axis, then around the y axis and finally around the z axis.</summary>
            XYZ,
            /// <summary>Extrinsic rotation around the x axis, then around the z axis and finally around the y axis.</summary>
            XZY,
            /// <summary>Extrinsic rotation around the y axis, then around the x axis and finally around the z axis.</summary>
            YXZ,
            /// <summary>Extrinsic rotation around the y axis, then around the z axis and finally around the x axis.</summary>
            YZX,
            /// <summary>Extrinsic rotation around the z axis, then around the x axis and finally around the y axis.</summary>
            ZXY,
            /// <summary>Extrinsic rotation around the z axis, then around the y axis and finally around the x axis.</summary>
            ZYX,
            /// <summary>Unity default rotation order. Extrinsic Rotation around the z axis, then around the x axis and finally around the y axis.</summary>
            Default = ZXY
        };

        /// <summary>Specifies a shuffle component.</summary>
        public enum ShuffleComponent : U08
        {
            /// <summary>Specified the x component of the left vector.</summary>
            LeftX,
            /// <summary>Specified the y component of the left vector.</summary>
            LeftY,
            /// <summary>Specified the z component of the left vector.</summary>
            LeftZ,
            /// <summary>Specified the w component of the left vector.</summary>
            LeftW,

            /// <summary>Specified the x component of the right vector.</summary>
            RightX,
            /// <summary>Specified the y component of the right vector.</summary>
            RightY,
            /// <summary>Specified the z component of the right vector.</summary>
            RightZ,
            /// <summary>Specified the w component of the right vector.</summary>
            RightW
        };

        /// <summary>The mathematical constant e also known as Euler's number. Approximately 2.72. This is a f64/double precision constant.</summary>
        public const F64 E_DBL        = 2.71828182845904523536;

        /// <summary>The base 2 logarithm of e. Approximately 1.44. This is a f64/double precision constant.</summary>
        public const F64 LOG2E_DBL    = 1.44269504088896340736;

        /// <summary>The base 10 logarithm of e. Approximately 0.43. This is a f64/double precision constant.</summary>
        public const F64 LOG10E_DBL   = 0.434294481903251827651;

        /// <summary>The natural logarithm of 2. Approximately 0.69. This is a f64/double precision constant.</summary>
        public const F64 LN2_DBL      = 0.693147180559945309417;

        /// <summary>The natural logarithm of 10. Approximately 2.30. This is a f64/double precision constant.</summary>
        public const F64 LN10_DBL     = 2.30258509299404568402;

        /// <summary>The mathematical constant TAU. Approximately 6.28. This is a f64/double precision constant.</summary>
        public const F64 TAU_DBL      = 6.28318530717958647692;

        /// <summary>The mathematical constant PI. Approximately 3.14 (TAU/2). This is a f64/double precision constant.</summary>
        public const F64 PI_DBL       = TAU_DBL / 2;

        /// <summary>The square root 2. Approximately 1.41. This is a f64/double precision constant.</summary>
        public const F64 SQRT2_DBL    = 1.41421356237309504880;

        /// <summary>
        /// The difference between 1.0 and the next representable f64/double precision number.
        ///
        /// Beware:
        /// This value is different from System.Double.Epsilon, which is the smallest, positive, denormalized f64/double.
        /// </summary>
        public const F64 EPSILON_DBL  = 2.22044604925031308085e-16;

        /// <summary>
        /// F64 precision constant for positive infinity.
        /// </summary>
        public const F64 INFINITY_DBL = F64.PositiveInfinity;

        /// <summary>
        /// F64 precision constant for Not a Number.
        ///
        /// NAN_DBL is considered unordered, which means all comparisons involving it are false except for not equal (operator !=).
        /// As a consequence, NAN_DBL == NAN_DBL is false but NAN_DBL != NAN_DBL is true.
        ///
        /// Additionally, there are multiple bit representations for Not a Number, so if you must test if your value
        /// is NAN_DBL, use isnan().
        /// </summary>
        public const F64 NAN_DBL = F64.NaN;

        /// <summary>The smallest positive normal number representable in a F32.</summary>
        public const F32 FLT_MIN_NORMAL = 1.175494351e-38F;

        /// <summary>The smallest positive normal number representable in a F64. This is a f64/double precision constant.</summary>
        public const F64 DBL_MIN_NORMAL = 2.2250738585072014e-308;

        /// <summary>The mathematical constant e also known as Euler's number. Approximately 2.72.</summary>
        public const F32 E      = (F32)E_DBL;

        /// <summary>The base 2 logarithm of e. Approximately 1.44.</summary>
        public const F32 LOG2E  = (F32)LOG2E_DBL;

        /// <summary>The base 10 logarithm of e. Approximately 0.43.</summary>
        public const F32 LOG10E = (F32)LOG10E_DBL;

        /// <summary>The natural logarithm of 2. Approximately 0.69.</summary>
        public const F32 LN2    = (F32)LN2_DBL;

        /// <summary>The natural logarithm of 10. Approximately 2.30.</summary>
        public const F32 LN10   = (F32)LN10_DBL;

        /// <summary>The mathematical constant pi. Approximately 3.14.</summary>
        public const F32 PI     = (F32)PI_DBL;

        /// <summary>The mathematical constant pi. Approximately 3.14.</summary>
        public const F32 TAU    = (F32)PI_DBL;

        /// <summary>The square root 2. Approximately 1.41.</summary>
        public const F32 SQRT2  = (F32)SQRT2_DBL;

        /// <summary>
        /// The difference between 1.0f and the next representable f32/single precision number.
        ///
        /// Beware:
        /// This value is different from System.Single.Epsilon, which is the smallest, positive, denormalized f32/single.
        /// </summary>
        public const F32 EPSILON = 1.1920928955078125e-7f;

        /// <summary>
        /// Single precision constant for positive infinity.
        /// </summary>
        public const F32 INFINITY = Single.PositiveInfinity;

        /// <summary>
        /// Single precision constant for Not a Number.
        ///
        /// NAN is considered unordered, which means all comparisons involving it are false except for not equal (operator !=).
        /// As a consequence, NAN == NAN is false but NAN != NAN is true.
        ///
        /// Additionally, there are multiple bit representations for Not a Number, so if you must test if your value
        /// is NAN, use isnan().
        /// </summary>
        public const F32 NAN = Single.NaN;

        /// <summary>Returns the bit pattern of a U32 as an I32.</summary>
        /// <param name="x">The U32 bits to copy.</param>
        /// <returns>The I32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 AsI32(U32 x) =>(I32)x;

        /// <summary>Returns the bit pattern of a U32x2 as an I32x2.</summary>
        /// <param name="x">The U32x2 bits to copy.</param>
        /// <returns>The I32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 AsI32(U32x2 x) => new I32x2((I32)x.x, (I32)x.y);

        /// <summary>Returns the bit pattern of a U32x3 as an I32x3.</summary>
        /// <param name="x">The U32x3 bits to copy.</param>
        /// <returns>The I32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 AsI32(U32x3 x) => new I32x3((I32)x.x, (I32)x.y, (I32)x.z);

        /// <summary>Returns the bit pattern of a <see cref="U32x4"/> as an I32x4.</summary>
        /// <param name="x">The U32x4 bits to copy.</param>
        /// <returns>The I32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 AsI32(U32x4 x) => new I32x4((I32)x.x, (I32)x.y, (I32)x.z, (I32)x.w);


        /// <summary>Returns the bit pattern of a F32 as an I32.</summary>
        /// <param name="x">The F32 bits to copy.</param>
        /// <returns>The I32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 AsI32(F32 x)
        {
            I32_F32_Union u;
            u.I32Value = 0;
            u.F32Value = x;
            return u.I32Value;
        }

        /// <summary>Returns the bit pattern of a F32x2 as an I32x2.</summary>
        /// <param name="x">The F32x2 bits to copy.</param>
        /// <returns>The I32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 AsI32(F32x2 x) => new I32x2(AsI32(x.x), AsI32(x.y));

        /// <summary>Returns the bit pattern of a F32x3 as an I32x3.</summary>
        /// <param name="x">The F32x3 bits to copy.</param>
        /// <returns>The I32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 AsI32(F32x3 x) => new I32x3(AsI32(x.x), AsI32(x.y), AsI32(x.z));

        /// <summary>Returns the bit pattern of a F32x4 as an I32x4.</summary>
        /// <param name="x">The F32x4 bits to copy.</param>
        /// <returns>The I32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 AsI32(F32x4 x) => new I32x4(AsI32(x.x), AsI32(x.y), AsI32(x.z), AsI32(x.w));


        /// <summary>Returns the bit pattern of an I32 as a U32.</summary>
        /// <param name="x">The I32 bits to copy.</param>
        /// <returns>The U32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 AsU32(I32 x) => (U32)x;

        /// <summary>Returns the bit pattern of an I32x2 as a U32x2.</summary>
        /// <param name="x">The I32x2 bits to copy.</param>
        /// <returns>The U32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 AsU32(I32x2 x) => new U32x2((U32)x.x, (U32)x.y);

        /// <summary>Returns the bit pattern of an I32x3 as a U32x3.</summary>
        /// <param name="x">The I32x3 bits to copy.</param>
        /// <returns>The U32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 AsU32(I32x3 x) => new U32x3((U32)x.x, (U32)x.y, (U32)x.z);

        /// <summary>Returns the bit pattern of an I32x4 as a U32x4.</summary>
        /// <param name="x">The I32x4 bits to copy.</param>
        /// <returns>The U32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 AsU32(I32x4 x) => new U32x4((U32)x.x, (U32)x.y, (U32)x.z, (U32)x.w);


        /// <summary>Returns the bit pattern of a F32 as a U32.</summary>
        /// <param name="x">The F32 bits to copy.</param>
        /// <returns>The U32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 AsU32(F32 x) => (U32)AsI32(x);

        /// <summary>Returns the bit pattern of a F32x2 as a U32x2.</summary>
        /// <param name="x">The F32x2 bits to copy.</param>
        /// <returns>The U32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 AsU32(F32x2 x) => new U32x2(AsU32(x.x), AsU32(x.y));

        /// <summary>Returns the bit pattern of a F32x3 as a U32x3.</summary>
        /// <param name="x">The F32x3 bits to copy.</param>
        /// <returns>The U32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 AsU32(F32x3 x) => new U32x3(AsU32(x.x), AsU32(x.y), AsU32(x.z));

        /// <summary>Returns the bit pattern of a F32x4 as a U32x4.</summary>
        /// <param name="x">The F32x4 bits to copy.</param>
        /// <returns>The U32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 AsU32(F32x4 x) => new U32x4(AsU32(x.x), AsU32(x.y), AsU32(x.z), AsU32(x.w));


        /// <summary>Returns the bit pattern of a ulong as a long.</summary>
        /// <param name="x">The ulong bits to copy.</param>
        /// <returns>The long with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AsI64(ulong x) { return (long)x; }

        /// <summary>Returns the bit pattern of a F64 as a long.</summary>
        /// <param name="x">The F64 bits to copy.</param>
        /// <returns>The long with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AsI64(F64 x)
        {
            I64_F64_Union u;
            u.I64Value = 0;
            u.F64Value = x;
            return u.I64Value;
        }


        /// <summary>Returns the bit pattern of a long as a ulong.</summary>
        /// <param name="x">The long bits to copy.</param>
        /// <returns>The ulong with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AsU64(long x) { return (ulong)x; }

        /// <summary>Returns the bit pattern of a F64 as a ulong.</summary>
        /// <param name="x">The F64 bits to copy.</param>
        /// <returns>The ulong with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AsU64(F64 x) { return (ulong) AsI64(x); }


        /// <summary>Returns the bit pattern of an I32 as a F32.</summary>
        /// <param name="x">The I32 bits to copy.</param>
        /// <returns>The F32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 AsF32(I32 x)
        {
            I32_F32_Union u;
            u.F32Value = 0;
            u.I32Value = x;

            return u.F32Value;
        }

        /// <summary>Returns the bit pattern of an I32x2 as a F32x2.</summary>
        /// <param name="x">The I32x2 bits to copy.</param>
        /// <returns>The F32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 AsF32(I32x2 x) { return new F32x2(AsF32(x.x), AsF32(x.y)); }

        /// <summary>Returns the bit pattern of an I32x3 as a F32x3.</summary>
        /// <param name="x">The I32x3 bits to copy.</param>
        /// <returns>The F32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 AsF32(I32x3 x) { return new F32x3(AsF32(x.x), AsF32(x.y), AsF32(x.z)); }

        /// <summary>Returns the bit pattern of an I32x4 as a F32x4.</summary>
        /// <param name="x">The I32x4 bits to copy.</param>
        /// <returns>The F32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 AsF32(I32x4 x) { return new F32x4(AsF32(x.x), AsF32(x.y), AsF32(x.z), AsF32(x.w)); }


        /// <summary>Returns the bit pattern of a U32 as a F32.</summary>
        /// <param name="x">The U32 bits to copy.</param>
        /// <returns>The F32 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 AsF32(U32 x) { return AsF32((I32)x); }

        /// <summary>Returns the bit pattern of a U32x2 as a F32x2.</summary>
        /// <param name="x">The U32x2 bits to copy.</param>
        /// <returns>The F32x2 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 AsF32(U32x2 x) { return new F32x2(AsF32(x.x), AsF32(x.y)); }

        /// <summary>Returns the bit pattern of a U32x3 as a F32x3.</summary>
        /// <param name="x">The U32x3 bits to copy.</param>
        /// <returns>The F32x3 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 AsF32(U32x3 x) { return new F32x3(AsF32(x.x), AsF32(x.y), AsF32(x.z)); }

        /// <summary>Returns the bit pattern of a U32x4 as a F32x4.</summary>
        /// <param name="x">The U32x4 bits to copy.</param>
        /// <returns>The F32x4 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 AsF32(U32x4 x) { return new F32x4(AsF32(x.x), AsF32(x.y), AsF32(x.z), AsF32(x.w)); }

        /// <summary>
        /// Returns a bitmask representation of a Boolx4. Storing one 1 bit per component
        /// in LSB order, from lower to higher bits (so 4 bits in total).
        /// The component x is stored at bit 0,
        /// The component y is stored at bit 1,
        /// The component z is stored at bit 2,
        /// The component w is stored at bit 3
        /// The Boolx4(x = true, y = true, z = false, w = true) would produce the value 1011 = 0xB
        /// </summary>
        /// <param name="value">The input Boolx4 to calculate the bitmask for</param>
        /// <returns>A bitmask representation of the Boolx4, in LSB order</returns>
        public static I32 bitmask(Boolx4 value)
        {
            I32 mask = 0;
            if (value.x) mask |= 0x01;
            if (value.y) mask |= 0x02;
            if (value.z) mask |= 0x04;
            if (value.w) mask |= 0x08;
            return mask;
        }

        /// <summary>Returns the bit pattern of a long as a F64.</summary>
        /// <param name="x">The long bits to copy.</param>
        /// <returns>The F64 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 AsF64(long x)
        {
            I64_F64_Union u;
            u.F64Value = 0;
            u.I64Value = x;
            return u.F64Value;
        }


        /// <summary>Returns the bit pattern of a ulong as a F64.</summary>
        /// <param name="x">The ulong bits to copy.</param>
        /// <returns>The F64 with the same bit pattern as the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 AsF64(ulong x) { return AsF64((long)x); }


        /// <summary>Returns true if the input F32 is a finite F32ing poI32 value, false otherwise.</summary>
        /// <param name="x">The F32 value to test.</param>
        /// <returns>True if the F32 is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isfinite(F32 x) { return abs(x) < F32.PositiveInfinity; }

        /// <summary>Returns a Boolx2 indicating for each component of a F32x2 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The F32x2 value to test.</param>
        /// <returns>A Boolx2 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isfinite(F32x2 x) { return abs(x) < F32.PositiveInfinity; }

        /// <summary>Returns a Boolx3 indicating for each component of a F32x3 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The F32x3 value to test.</param>
        /// <returns>A Boolx3 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isfinite(F32x3 x) { return abs(x) < F32.PositiveInfinity; }

        /// <summary>Returns a Boolx4 indicating for each component of a F32x4 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The F32x4 value to test.</param>
        /// <returns>A Boolx4 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isfinite(F32x4 x) { return abs(x) < F32.PositiveInfinity; }


        /// <summary>Returns true if the input F64 is a finite F32ing poI32 value, false otherwise.</summary>
        /// <param name="x">The F64 value to test.</param>
        /// <returns>True if the F64 is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isfinite(F64 x) { return abs(x) < F64.PositiveInfinity; }

        /// <summary>Returns a Boolx2 indicating for each component of a  F64x2 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The  F64x2 value to test.</param>
        /// <returns>A Boolx2 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isfinite(F64x2 x) { return abs(x) < F64.PositiveInfinity; }

        /// <summary>Returns a Boolx3 indicating for each component of a  F64x3 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The  F64x3 value to test.</param>
        /// <returns>A Boolx3 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isfinite(F64x3 x) { return abs(x) < F64.PositiveInfinity; }

        /// <summary>Returns a Boolx4 indicating for each component of a  F64x4 whether it is a finite F32ing poI32 value.</summary>
        /// <param name="x">The  F64x4 value to test.</param>
        /// <returns>A Boolx4 where it is true in a component if that component is finite, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isfinite(F64x4 x) { return abs(x) < F64.PositiveInfinity; }


        /// <summary>Returns true if the input F32 is an infinite F32ing poI32 value, false otherwise.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the input was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isinf(F32 x) { return abs(x) == F32.PositiveInfinity; }

        /// <summary>Returns a Boolx2 indicating for each component of a F32x2 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isinf(F32x2 x) { return abs(x) == F32.PositiveInfinity; }

        /// <summary>Returns a Boolx3 indicating for each component of a F32x3 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isinf(F32x3 x) { return abs(x) == F32.PositiveInfinity; }

        /// <summary>Returns a Boolx4 indicating for each component of a F32x4 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isinf(F32x4 x) { return abs(x) == F32.PositiveInfinity; }

        /// <summary>Returns true if the input F64 is an infinite F32ing poI32 value, false otherwise.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the input was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isinf(F64 x) { return abs(x) == F64.PositiveInfinity; }

        /// <summary>Returns a Boolx2 indicating for each component of a  F64x2 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isinf(F64x2 x) { return abs(x) == F64.PositiveInfinity; }

        /// <summary>Returns a Boolx3 indicating for each component of a  F64x3 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isinf(F64x3 x) { return abs(x) == F64.PositiveInfinity; }

        /// <summary>Returns a Boolx4 indicating for each component of a  F64x4 whether it is an infinite F32ing poI32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was an infinite value; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isinf(F64x4 x) { return abs(x) == F64.PositiveInfinity; }


        /// <summary>Returns true if the input F32 is a NaN (not a number) F32ing poI32 value, false otherwise.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the value was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isnan(F32 x) { return (AsU32(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a Boolx2 indicating for each component of a F32x2 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isnan(F32x2 x) { return (AsU32(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a Boolx3 indicating for each component of a F32x3 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isnan(F32x3 x) { return (AsU32(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a Boolx4 indicating for each component of a F32x4 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isnan(F32x4 x) { return (AsU32(x) & 0x7FFFFFFF) > 0x7F800000; }


        /// <summary>Returns true if the input F64 is a NaN (not a number) F32ing poI32 value, false otherwise.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the value was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool isnan(F64 x) { return (AsU64(x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000; }

        /// <summary>Returns a Boolx2 indicating for each component of a  F64x2 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 isnan(F64x2 x)
        {
            return new Boolx2(
                x: (AsU64(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                y: (AsU64(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        /// <summary>Returns a Boolx3 indicating for each component of a  F64x3 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 isnan(F64x3 x)
        {
            return new Boolx3(
                x: (AsU64(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                y: (AsU64(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                z: (AsU64(x.z) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        /// <summary>Returns a Boolx4 indicating for each component of a  F64x4 whether it is a NaN (not a number) F32ing poI32 value.</summary>
        /// <remarks>
        /// NaN has several representations and may vary across architectures. Use this function to check if you have a NaN.
        /// </remarks>
        /// <param name="x">Input value.</param>
        /// <returns>True if the component was NaN; false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 isnan(F64x4 x)
        {
            return new Boolx4(
                x: (AsU64(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                y: (AsU64(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                z: (AsU64(x.z) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                w: (AsU64(x.w) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        /// <summary>
        /// Checks if the input is a power of two.
        /// </summary>
        /// <remarks>If x is less than or equal to zero, then this function returns false.</remarks>
        /// <param name="x">Integer input.</param>
        /// <returns>Bool where true indicates that input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool ispow2(I32 x)
        {
            return x > 0 && ((x & (x - 1)) == 0);
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">I32x2 input</param>
        /// <returns>Boolx2 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 ispow2(I32x2 x)
        {
            return new Boolx2(ispow2(x.x), ispow2(x.y));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">I32x3 input</param>
        /// <returns>Boolx3 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 ispow2(I32x3 x)
        {
            return new Boolx3(ispow2(x.x), ispow2(x.y), ispow2(x.z));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">I32x4 input</param>
        /// <returns>Boolx4 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 ispow2(I32x4 x)
        {
            return new Boolx4(ispow2(x.x), ispow2(x.y), ispow2(x.z), ispow2(x.w));
        }

        /// <summary>
        /// Checks if the input is a power of two.
        /// </summary>
        /// <remarks>If x is less than or equal to zero, then this function returns false.</remarks>
        /// <param name="x">Unsigned I32eger input.</param>
        /// <returns>Bool where true indicates that input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool ispow2(U32 x)
        {
            return x > 0 && ((x & (x - 1)) == 0);
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">U32x2 input</param>
        /// <returns>Boolx2 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx2 ispow2(U32x2 x)
        {
            return new Boolx2(ispow2(x.x), ispow2(x.y));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">U32x3 input</param>
        /// <returns>Boolx3 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx3 ispow2(U32x3 x)
        {
            return new Boolx3(ispow2(x.x), ispow2(x.y), ispow2(x.z));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x">U32x4 input</param>
        /// <returns>Boolx4 where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolx4 ispow2(U32x4 x)
        {
            return new Boolx4(ispow2(x.x), ispow2(x.y), ispow2(x.z), ispow2(x.w));
        }

        /// <summary>Returns the minimum of two I32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 min(I32 x, I32 y) { return x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two I32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 min(I32x2 x, I32x2 y) { return new I32x2(min(x.x, y.x), min(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two I32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 min(I32x3 x, I32x3 y) { return new I32x3(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two I32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 min(I32x4 x, I32x4 y) { return new I32x4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w)); }


        /// <summary>Returns the minimum of two U32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 min(U32 x, U32 y) { return x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two U32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 min(U32x2 x, U32x2 y) { return new U32x2(min(x.x, y.x), min(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two U32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 min(U32x3 x, U32x3 y) { return new U32x3(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two U32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 min(U32x4 x, U32x4 y) { return new U32x4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w)); }


        /// <summary>Returns the minimum of two long values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long min(long x, long y) { return x < y ? x : y; }


        /// <summary>Returns the minimum of two ulong values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong min(ulong x, ulong y) { return x < y ? x : y; }


        /// <summary>Returns the minimum of two F32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 min(F32 x, F32 y) { return F32.IsNaN(y) || x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two F32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 min(F32x2 x, F32x2 y) { return new F32x2(min(x.x, y.x), min(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two F32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 min(F32x3 x, F32x3 y) { return new F32x3(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two F32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 min(F32x4 x, F32x4 y) { return new F32x4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w)); }


        /// <summary>Returns the minimum of two F64 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 min(F64 x, F64 y) { return F64.IsNaN(y) || x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two  F64x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 min(F64x2 x, F64x2 y) { return new F64x2(min(x.x, y.x), min(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two  F64x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 min(F64x3 x, F64x3 y) { return new F64x3(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two  F64x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise minimum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 min(F64x4 x, F64x4 y) { return new F64x4(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w)); }


        /// <summary>Returns the maximum of two I32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 max(I32 x, I32 y) { return x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two I32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 max(I32x2 x, I32x2 y) { return new I32x2(max(x.x, y.x), max(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two I32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 max(I32x3 x, I32x3 y) { return new I32x3(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two I32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 max(I32x4 x, I32x4 y) { return new I32x4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w)); }


        /// <summary>Returns the maximum of two U32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 max(U32 x, U32 y) { return x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two U32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 max(U32x2 x, U32x2 y) { return new U32x2(max(x.x, y.x), max(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two U32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 max(U32x3 x, U32x3 y) { return new U32x3(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two U32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 max(U32x4 x, U32x4 y) { return new U32x4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w)); }


        /// <summary>Returns the maximum of two long values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long max(long x, long y) { return x > y ? x : y; }


        /// <summary>Returns the maximum of two ulong values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong max(ulong x, ulong y) { return x > y ? x : y; }


        /// <summary>Returns the maximum of two F32 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 max(F32 x, F32 y) { return F32.IsNaN(y) || x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two F32x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 max(F32x2 x, F32x2 y) { return new F32x2(max(x.x, y.x), max(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two F32x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 max(F32x3 x, F32x3 y) { return new F32x3(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two F32x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 max(F32x4 x, F32x4 y) { return new F32x4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w)); }


        /// <summary>Returns the maximum of two F64 values.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 max(F64 x, F64 y) { return F64.IsNaN(y) || x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two  F64x2 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 max(F64x2 x, F64x2 y) { return new F64x2(max(x.x, y.x), max(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two  F64x3 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 max(F64x3 x, F64x3 y) { return new F64x3(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two  F64x4 vectors.</summary>
        /// <param name="x">The first input value.</param>
        /// <param name="y">The second input value.</param>
        /// <returns>The componentwise maximum of the two input values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 max(F64x4 x, F64x4 y) { return new F64x4(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w)); }


        /// <summary>Returns the result of linearly I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 lerp(F32 x, F32 y, F32 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 lerp(F32x2 x, F32x2 y, F32 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 lerp(F32x3 x, F32x3 y, F32 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 lerp(F32x4 x, F32x4 y, F32 s) { return x + s * (y - x); }


        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 lerp(F32x2 x, F32x2 y, F32x2 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 lerp(F32x3 x, F32x3 y, F32x3 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 lerp(F32x4 x, F32x4 y, F32x4 s) { return x + s * (y - x); }


        /// <summary>Returns the result of linearly I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 lerp(F64 x, F64 y, F64 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 lerp(F64x2 x, F64x2 y, F64 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 lerp(F64x3 x, F64x3 y, F64 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 lerp(F64x4 x, F64x4 y, F64 s) { return x + s * (y - x); }


        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 lerp(F64x2 x, F64x2 y, F64x2 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 lerp(F64x3 x, F64x3 y, F64x3 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear I32erpolating from x to y using the corresponding components of the I32erpolation parameter s.</summary>
        /// <remarks>
        /// If the I32erpolation parameter is not in the range [0, 1], then this function extrapolates.
        /// </remarks>
        /// <param name="x">The first endpoI32, corresponding to the I32erpolation parameter value of 0.</param>
        /// <param name="y">The second endpoI32, corresponding to the I32erpolation parameter value of 1.</param>
        /// <param name="s">The I32erpolation parameter. May be a value outside the I32erval [0, 1].</param>
        /// <returns>The componentwise I32erpolation from x to y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 lerp(F64x4 x, F64x4 y, F64x4 s) { return x + s * (y - x); }


        /// <summary>Returns the result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 unlerp(F32 a, F32 b, F32 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 unlerp(F32x2 a, F32x2 b, F32x2 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 unlerp(F32x3 a, F32x3 b, F32x3 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 unlerp(F32x4 a, F32x4 b, F32x4 x) { return (x - a) / (b - a); }


        /// <summary>Returns the result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 unlerp(F64 a, F64 b, F64 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 unlerp(F64x2 a, F64x2 b, F64x2 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 unlerp(F64x3 a, F64x3 b, F64x3 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a F32ing poI32 value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        /// <param name="a">The first endpoI32 of the range.</param>
        /// <param name="b">The second endpoI32 of the range.</param>
        /// <param name="x">The value to Normalize to the range.</param>
        /// <returns>The componentwise I32erpolation parameter of x with respect to the input range [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 unlerp(F64x4 a, F64x4 b, F64x4 x) { return (x - a) / (b - a); }


        /// <summary>Returns the result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 remap(F32 a, F32 b, F32 c, F32 d, F32 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 remap(F32x2 a, F32x2 b, F32x2 c, F32x2 d, F32x2 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 remap(F32x3 a, F32x3 b, F32x3 c, F32x3 d, F32x3 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 remap(F32x4 a, F32x4 b, F32x4 c, F32x4 d, F32x4 x) { return lerp(c, d, unlerp(a, b, x)); }


        /// <summary>Returns the result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 remap(F64 a, F64 b, F64 c, F64 d, F64 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 remap(F64x2 a, F64x2 b, F64x2 c, F64x2 d, F64x2 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 remap(F64x3 a, F64x3 b, F64x3 c, F64x3 d, F64x3 x) { return lerp(c, d, unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].</summary>
        /// <param name="a">The first endpoI32 of the source range [a,b].</param>
        /// <param name="b">The second endpoI32 of the source range [a, b].</param>
        /// <param name="c">The first endpoI32 of the destination range [c, d].</param>
        /// <param name="d">The second endpoI32 of the destination range [c, d].</param>
        /// <param name="x">The value to remap from the source to destination range.</param>
        /// <returns>The componentwise remap of input x from the source range to the destination range.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 remap(F64x4 a, F64x4 b, F64x4 c, F64x4 d, F64x4 x) { return lerp(c, d, unlerp(a, b, x)); }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 I32 values.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 mad(I32 a, I32 b, I32 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 I32x2 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 mad(I32x2 a, I32x2 b, I32x2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 I32x3 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 mad(I32x3 a, I32x3 b, I32x3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 I32x4 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 mad(I32x4 a, I32x4 b, I32x4 c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 U32 values.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 mad(U32 a, U32 b, U32 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 U32x2 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 mad(U32x2 a, U32x2 b, U32x2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 U32x3 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 mad(U32x3 a, U32x3 b, U32x3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 U32x4 vectors.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 mad(U32x4 a, U32x4 b, U32x4 c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 long values.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long mad(long a, long b, long c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 ulong values.</summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong mad(ulong a, ulong b, ulong c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 F32 values.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 mad(F32 a, F32 b, F32 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 F32x2 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 mad(F32x2 a, F32x2 b, F32x2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 F32x3 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 mad(F32x3 a, F32x3 b, F32x3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 F32x4 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 mad(F32x4 a, F32x4 b, F32x4 c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 F64 values.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 mad(F64 a, F64 b, F64 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3  F64x2 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 mad(F64x2 a, F64x2 b, F64x2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3  F64x3 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 mad(F64x3 a, F64x3 b, F64x3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3  F64x4 vectors.</summary>
        /// <remarks>
        /// When Burst compiled with fast math enabled on some architectures, this could be converted to a fused multiply add (FMA).
        /// FMA is more accurate due to rounding once at the end of the computation rather than twice that is required when
        /// this computation is not fused.
        /// </remarks>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <param name="c">Third value to add to the product of a and b.</param>
        /// <returns>The componentwise multiply-add of the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 mad(F64x4 a, F64x4 b, F64x4 c) { return a * b + c; }


        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are I32 values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 clamp(I32 x, I32 a, I32 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the I32x2 x I32o the I32erval [a, b], where a and b are I32x2 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 clamp(I32x2 x, I32x2 a, I32x2 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the I32x3 x I32o the I32erval [a, b], where x, a and b are I32x3 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 clamp(I32x3 x, I32x3 a, I32x3 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are I32x4 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 clamp(I32x4 x, I32x4 a, I32x4 b) { return max(a, min(b, x)); }


        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are U32 values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 clamp(U32 x, U32 a, U32 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are U32x2 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 clamp(U32x2 x, U32x2 a, U32x2 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are U32x3 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 clamp(U32x3 x, U32x3 a, U32x3 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are U32x4 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 clamp(U32x4 x, U32x4 a, U32x4 b) { return max(a, min(b, x)); }


        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are long values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long clamp(long x, long a, long b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are ulong values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong clamp(ulong x, ulong a, ulong b) { return max(a, min(b, x)); }


        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are F32 values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 clamp(F32 x, F32 a, F32 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are F32x2 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 clamp(F32x2 x, F32x2 a, F32x2 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are F32x3 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 clamp(F32x3 x, F32x3 a, F32x3 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are F32x4 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 clamp(F32x4 x, F32x4 a, F32x4 b) { return max(a, min(b, x)); }


        /// <summary>Returns the result of clamping the value x I32o the I32erval [a, b], where x, a and b are F64 values.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 clamp(F64 x, F64 a, F64 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are  F64x2 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 clamp(F64x2 x, F64x2 a, F64x2 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are  F64x3 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 clamp(F64x3 x, F64x3 a, F64x3 b) { return max(a, min(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x I32o the I32erval [a, b], where x, a and b are  F64x4 vectors.</summary>
        /// <param name="x">Input value to be clamped.</param>
        /// <param name="a">Lower bound of the I32erval.</param>
        /// <param name="b">Upper bound of the I32erval.</param>
        /// <returns>The componentwise clamping of the input x I32o the I32erval [a, b].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 clamp(F64x4 x, F64x4 a, F64x4 b) { return max(a, min(b, x)); }


        /// <summary>Returns the result of clamping the F32 value x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 saturate(F32 x) { return clamp(x, 0.0f, 1.0f); }

        /// <summary>Returns the result of a componentwise clamping of the F32x2 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 saturate(F32x2 x) { return clamp(x, new F32x2(0.0f), new F32x2(1.0f)); }

        /// <summary>Returns the result of a componentwise clamping of the F32x3 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 saturate(F32x3 x) { return clamp(x, new F32x3(0.0f), new F32x3(1.0f)); }

        /// <summary>Returns the result of a componentwise clamping of the F32x4 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 saturate(F32x4 x) { return clamp(x, new F32x4(0.0f), new F32x4(1.0f)); }


        /// <summary>Returns the result of clamping the F64 value x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 saturate(F64 x) { return clamp(x, 0.0, 1.0); }

        /// <summary>Returns the result of a componentwise clamping of the  F64x2 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 saturate(F64x2 x) { return clamp(x, new F64x2(0.0), new F64x2(1.0)); }

        /// <summary>Returns the result of a componentwise clamping of the  F64x3 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 saturate(F64x3 x) { return clamp(x, new F64x3(0.0), new F64x3(1.0)); }

        /// <summary>Returns the result of a componentwise clamping of the  F64x4 vector x I32o the I32erval [0, 1].</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise clamping of the input I32o the I32erval [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 saturate(F64x4 x) { return clamp(x, new F64x4(0.0), new F64x4(1.0)); }


        /// <summary>Returns the absolute value of a I32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 abs(I32 x) { return max(-x, x); }

        /// <summary>Returns the componentwise absolute value of a I32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 abs(I32x2 x) { return max(-x, x); }

        /// <summary>Returns the componentwise absolute value of a I32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 abs(I32x3 x) { return max(-x, x); }

        /// <summary>Returns the componentwise absolute value of a I32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 abs(I32x4 x) { return max(-x, x); }

        /// <summary>Returns the absolute value of a long value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long abs(long x) { return max(-x, x); }


        /// <summary>Returns the absolute value of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 abs(F32 x) { return AsF32(AsU32(x) & 0x7FFFFFFF); }

        /// <summary>Returns the componentwise absolute value of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 abs(F32x2 x) { return AsF32(AsU32(x) & 0x7FFFFFFF); }

        /// <summary>Returns the componentwise absolute value of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 abs(F32x3 x) { return AsF32(AsU32(x) & 0x7FFFFFFF); }

        /// <summary>Returns the componentwise absolute value of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 abs(F32x4 x) { return AsF32(AsU32(x) & 0x7FFFFFFF); }


        /// <summary>Returns the absolute value of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 abs(F64 x) { return AsF64(AsU64(x) & 0x7FFFFFFFFFFFFFFF); }

        /// <summary>Returns the componentwise absolute value of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 abs(F64x2 x) { return new F64x2(AsF64(AsU64(x.x) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.y) & 0x7FFFFFFFFFFFFFFF)); }

        /// <summary>Returns the componentwise absolute value of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 abs(F64x3 x) { return new F64x3(AsF64(AsU64(x.x) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.y) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.z) & 0x7FFFFFFFFFFFFFFF)); }

        /// <summary>Returns the componentwise absolute value of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise absolute value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 abs(F64x4 x) { return new F64x4(AsF64(AsU64(x.x) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.y) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.z) & 0x7FFFFFFFFFFFFFFF), AsF64(AsU64(x.w) & 0x7FFFFFFFFFFFFFFF)); }


        /// <summary>Returns the dot product of two I32 values. Equivalent to multiplication.</summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <returns>The dot product of two values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 dot(I32 x, I32 y) { return x * y; }

        /// <summary>Returns the dot product of two I32x2 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 dot(I32x2 x, I32x2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two I32x3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 dot(I32x3 x, I32x3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two I32x4 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 dot(I32x4 x, I32x4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the dot product of two U32 values. Equivalent to multiplication.</summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <returns>The dot product of two values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 dot(U32 x, U32 y) { return x * y; }

        /// <summary>Returns the dot product of two U32x2 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 dot(U32x2 x, U32x2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two U32x3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 dot(U32x3 x, U32x3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two U32x4 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 dot(U32x4 x, U32x4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the dot product of two F32 values. Equivalent to multiplication.</summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <returns>The dot product of two values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 dot(F32 x, F32 y) { return x * y; }

        /// <summary>Returns the dot product of two F32x2 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 dot(F32x2 x, F32x2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two F32x3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 dot(F32x3 x, F32x3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two F32x4 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 dot(F32x4 x, F32x4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the dot product of two  values. Equivalent to multiplication.</summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <returns>The dot product of two values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 dot(F64 x, F64 y) { return x * y; }

        /// <summary>Returns the dot product of two  F64x2 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 dot(F64x2 x, F64x2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two  F64x3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 dot(F64x3 x, F64x3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two  F64x4 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 dot(F64x4 x, F64x4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the tangent of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 tan(F32 x) { return (F32)System.Math.Tan(x); }

        /// <summary>Returns the componentwise tangent of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 tan(F32x2 x) { return new F32x2(tan(x.x), tan(x.y)); }

        /// <summary>Returns the componentwise tangent of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 tan(F32x3 x) { return new F32x3(tan(x.x), tan(x.y), tan(x.z)); }

        /// <summary>Returns the componentwise tangent of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 tan(F32x4 x) { return new F32x4(tan(x.x), tan(x.y), tan(x.z), tan(x.w)); }


        /// <summary>Returns the tangent of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 tan(F64 x) { return System.Math.Tan(x); }

        /// <summary>Returns the componentwise tangent of a F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 tan(F64x2 x) { return new F64x2(tan(x.x), tan(x.y)); }

        /// <summary>Returns the componentwise tangent of a F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 tan(F64x3 x) { return new F64x3(tan(x.x), tan(x.y), tan(x.z)); }

        /// <summary>Returns the componentwise tangent of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 tan(F64x4 x) { return new F64x4(tan(x.x), tan(x.y), tan(x.z), tan(x.w)); }


        /// <summary>Returns the hyperbolic tangent of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 tanh(F32 x) { return (F32)System.Math.Tanh(x); }

        /// <summary>Returns the componentwise hyperbolic tangent of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 tanh(F32x2 x) { return new F32x2(tanh(x.x), tanh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic tangent of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 tanh(F32x3 x) { return new F32x3(tanh(x.x), tanh(x.y), tanh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic tangent of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 tanh(F32x4 x) { return new F32x4(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w)); }


        /// <summary>Returns the hyperbolic tangent of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 tanh(F64 x) { return System.Math.Tanh(x); }

        /// <summary>Returns the componentwise hyperbolic tangent of a F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 tanh(F64x2 x) { return new F64x2(tanh(x.x), tanh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic tangent of a F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 tanh(F64x3 x) { return new F64x3(tanh(x.x), tanh(x.y), tanh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic tangent of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic tangent of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 tanh(F64x4 x) { return new F64x4(tanh(x.x), tanh(x.y), tanh(x.z), tanh(x.w)); }


        /// <summary>Returns the arctangent of a F32 value.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 atan(F32 x) { return (F32)System.Math.Atan(x); }

        /// <summary>Returns the componentwise arctangent of a F32x2 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 atan(F32x2 x) { return new F32x2(atan(x.x), atan(x.y)); }

        /// <summary>Returns the componentwise arctangent of a F32x3 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 atan(F32x3 x) { return new F32x3(atan(x.x), atan(x.y), atan(x.z)); }

        /// <summary>Returns the componentwise arctangent of a F32x4 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 atan(F32x4 x) { return new F32x4(atan(x.x), atan(x.y), atan(x.z), atan(x.w)); }


        /// <summary>Returns the arctangent of a F64 value.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 atan(F64 x) { return System.Math.Atan(x); }

        /// <summary>Returns the componentwise arctangent of a  F64x2 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 atan(F64x2 x) { return new F64x2(atan(x.x), atan(x.y)); }

        /// <summary>Returns the componentwise arctangent of a  F64x3 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 atan(F64x3 x) { return new F64x3(atan(x.x), atan(x.y), atan(x.z)); }

        /// <summary>Returns the componentwise arctangent of a  F64x4 vector.</summary>
        /// <param name="x">A tangent value, usually the ratio y/x on the unit circle.</param>
        /// <returns>The componentwise arctangent of the input, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 atan(F64x4 x) { return new F64x4(atan(x.x), atan(x.y), atan(x.z), atan(x.w)); }


        /// <summary>Returns the 2-argument arctangent of a pair of F32 values.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 atan2(F32 y, F32 x) { return (F32)System.Math.Atan2(y, x); }

        /// <summary>Returns the 2-argument arctangent of a pair of F32 values.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 atan2(F32x2 xy) { return (F32)System.Math.Atan2(xy.y, xy.x); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of F32s2 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 atan2(F32x2 y, F32x2 x) { return new F32x2(atan2(y.x, x.x), atan2(y.y, x.y)); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of F32s3 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 atan2(F32x3 y, F32x3 x) { return new F32x3(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z)); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of F32s4 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 atan2(F32x4 y, F32x4 x) { return new F32x4(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z), atan2(y.w, x.w)); }


        /// <summary>Returns the 2-argument arctangent of a pair of F64 values.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 atan2(F64 y, F64 x) { return System.Math.Atan2(y, x); }

        /// <summary>Returns the 2-argument arctangent of a pair of F64x2 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 atan2(F64x2 y, F64x2 x) { return new F64x2(atan2(y.x, x.x), atan2(y.y, x.y)); }

        /// <summary>Returns the 2-argument arctangent of a pair of  F64x3 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 atan2(F64x3 y, F64x3 x) { return new F64x3(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z)); }

        /// <summary>Returns the 2-argument arctangent of a pair of  F64x4 vectors.</summary>
        /// <param name="y">Numerator of the ratio y/x, usually the y component on the unit circle.</param>
        /// <param name="x">Denominator of the ratio y/x, usually the x component on the unit circle.</param>
        /// <returns>The componentwise arctangent of the ratio y/x, in radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 atan2(F64x4 y, F64x4 x) { return new F64x4(atan2(y.x, x.x), atan2(y.y, x.y), atan2(y.z, x.z), atan2(y.w, x.w)); }


        /// <summary>Returns the cosine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cos(F32 x) { return (F32)System.Math.Cos(x); }

        /// <summary>Returns the componentwise cosine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 cos(F32x2 x) { return new F32x2(cos(x.x), cos(x.y)); }

        /// <summary>Returns the componentwise cosine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 cos(F32x3 x) { return new F32x3(cos(x.x), cos(x.y), cos(x.z)); }

        /// <summary>Returns the componentwise cosine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 cos(F32x4 x) { return new F32x4(cos(x.x), cos(x.y), cos(x.z), cos(x.w)); }


        /// <summary>Returns the cosine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cos(F64 x) { return System.Math.Cos(x); }

        /// <summary>Returns the componentwise cosine of a F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 cos(F64x2 x) { return new F64x2(cos(x.x), cos(x.y)); }

        /// <summary>Returns the componentwise cosine of a F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 cos(F64x3 x) { return new F64x3(cos(x.x), cos(x.y), cos(x.z)); }

        /// <summary>Returns the componentwise cosine of a F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise cosine cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 cos(F64x4 x) { return new F64x4(cos(x.x), cos(x.y), cos(x.z), cos(x.w)); }


        /// <summary>Returns the hyperbolic cosine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cosh(F32 x) { return (F32)System.Math.Cosh(x); }

        /// <summary>Returns the componentwise hyperbolic cosine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 cosh(F32x2 x) { return new F32x2(cosh(x.x), cosh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic cosine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 cosh(F32x3 x) { return new F32x3(cosh(x.x), cosh(x.y), cosh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic cosine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 cosh(F32x4 x) { return new F32x4(cosh(x.x), cosh(x.y), cosh(x.z), cosh(x.w)); }


        /// <summary>Returns the hyperbolic cosine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cosh(F64 x) { return System.Math.Cosh(x); }

        /// <summary>Returns the componentwise hyperbolic cosine of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 cosh(F64x2 x) { return new F64x2(cosh(x.x), cosh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic cosine of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 cosh(F64x3 x) { return new F64x3(cosh(x.x), cosh(x.y), cosh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic cosine of a F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic cosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 cosh(F64x4 x) { return new F64x4(cosh(x.x), cosh(x.y), cosh(x.z), cosh(x.w)); }


        /// <summary>Returns the arccosine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 acos(F32 x) { return (F32)System.Math.Acos((F32)x); }

        /// <summary>Returns the componentwise arccosine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 acos(F32x2 x) { return new F32x2(acos(x.x), acos(x.y)); }

        /// <summary>Returns the componentwise arccosine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 acos(F32x3 x) { return new F32x3(acos(x.x), acos(x.y), acos(x.z)); }

        /// <summary>Returns the componentwise arccosine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 acos(F32x4 x) { return new F32x4(acos(x.x), acos(x.y), acos(x.z), acos(x.w)); }


        /// <summary>Returns the arccosine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 acos(F64 x) { return System.Math.Acos(x); }

        /// <summary>Returns the componentwise arccosine of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 acos(F64x2 x) { return new F64x2(acos(x.x), acos(x.y)); }

        /// <summary>Returns the componentwise arccosine of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 acos(F64x3 x) { return new F64x3(acos(x.x), acos(x.y), acos(x.z)); }

        /// <summary>Returns the componentwise arccosine of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arccosine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 acos(F64x4 x) { return new F64x4(acos(x.x), acos(x.y), acos(x.z), acos(x.w)); }


        /// <summary>Returns the sine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 sin(F32 x) { return (F32)System.Math.Sin((F32)x); }

        /// <summary>Returns the componentwise sine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 sin(F32x2 x) { return new F32x2(sin(x.x), sin(x.y)); }

        /// <summary>Returns the componentwise sine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 sin(F32x3 x) { return new F32x3(sin(x.x), sin(x.y), sin(x.z)); }

        /// <summary>Returns the componentwise sine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 sin(F32x4 x) { return new F32x4(sin(x.x), sin(x.y), sin(x.z), sin(x.w)); }


        /// <summary>Returns the sine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 sin(F64 x) { return System.Math.Sin(x); }

        /// <summary>Returns the componentwise sine of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 sin(F64x2 x) { return new F64x2(sin(x.x), sin(x.y)); }

        /// <summary>Returns the componentwise sine of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 sin(F64x3 x) { return new F64x3(sin(x.x), sin(x.y), sin(x.z)); }

        /// <summary>Returns the componentwise sine of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 sin(F64x4 x) { return new F64x4(sin(x.x), sin(x.y), sin(x.z), sin(x.w)); }


        /// <summary>Returns the hyperbolic sine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 sinh(F32 x) { return (F32)System.Math.Sinh((F32)x); }

        /// <summary>Returns the componentwise hyperbolic sine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 sinh(F32x2 x) { return new F32x2(sinh(x.x), sinh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic sine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 sinh(F32x3 x) { return new F32x3(sinh(x.x), sinh(x.y), sinh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic sine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 sinh(F32x4 x) { return new F32x4(sinh(x.x), sinh(x.y), sinh(x.z), sinh(x.w)); }


        /// <summary>Returns the hyperbolic sine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 sinh(F64 x) { return System.Math.Sinh(x); }

        /// <summary>Returns the componentwise hyperbolic sine of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 sinh(F64x2 x) { return new F64x2(sinh(x.x), sinh(x.y)); }

        /// <summary>Returns the componentwise hyperbolic sine of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 sinh(F64x3 x) { return new F64x3(sinh(x.x), sinh(x.y), sinh(x.z)); }

        /// <summary>Returns the componentwise hyperbolic sine of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise hyperbolic sine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 sinh(F64x4 x) { return new F64x4(sinh(x.x), sinh(x.y), sinh(x.z), sinh(x.w)); }


        /// <summary>Returns the arcsine of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 asin(F32 x) { return (F32)System.Math.Asin((F32)x); }

        /// <summary>Returns the componentwise arcsine of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 asin(F32x2 x) { return new F32x2(asin(x.x), asin(x.y)); }

        /// <summary>Returns the componentwise arcsine of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 asin(F32x3 x) { return new F32x3(asin(x.x), asin(x.y), asin(x.z)); }

        /// <summary>Returns the componentwise arcsine of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 asin(F32x4 x) { return new F32x4(asin(x.x), asin(x.y), asin(x.z), asin(x.w)); }


        /// <summary>Returns the arcsine of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 asin(F64 x) { return System.Math.Asin(x); }

        /// <summary>Returns the componentwise arcsine of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 asin(F64x2 x) { return new F64x2(asin(x.x), asin(x.y)); }

        /// <summary>Returns the componentwise arcsine of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 asin(F64x3 x) { return new F64x3(asin(x.x), asin(x.y), asin(x.z)); }

        /// <summary>Returns the componentwise arcsine of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise arcsine of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 asin(F64x4 x) { return new F64x4(asin(x.x), asin(x.y), asin(x.z), asin(x.w)); }


        /// <summary>Returns the result of rounding a F32 value up to the nearest I32egral value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 floor(F32 x) { return (F32)System.Math.Floor((F32)x); }

        /// <summary>Returns the result of rounding each component of a F32x2 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 floor(F32x2 x) { return new F32x2(floor(x.x), floor(x.y)); }

        /// <summary>Returns the result of rounding each component of a F32x3 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 floor(F32x3 x) { return new F32x3(floor(x.x), floor(x.y), floor(x.z)); }

        /// <summary>Returns the result of rounding each component of a F32x4 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 floor(F32x4 x) { return new F32x4(floor(x.x), floor(x.y), floor(x.z), floor(x.w)); }


        /// <summary>Returns the result of rounding a F64 value up to the nearest I32egral value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 floor(F64 x) { return System.Math.Floor(x); }

        /// <summary>Returns the result of rounding each component of a  F64x2 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 floor(F64x2 x) { return new F64x2(floor(x.x), floor(x.y)); }

        /// <summary>Returns the result of rounding each component of a  F64x3 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 floor(F64x3 x) { return new F64x3(floor(x.x), floor(x.y), floor(x.z)); }

        /// <summary>Returns the result of rounding each component of a  F64x4 vector value down to the nearest value less or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round down to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 floor(F64x4 x) { return new F64x4(floor(x.x), floor(x.y), floor(x.z), floor(x.w)); }


        /// <summary>Returns the result of rounding a F32 value up to the nearest I32egral value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 ceil(F32 x) { return (F32)System.Math.Ceiling((F32)x); }

        /// <summary>Returns the result of rounding each component of a F32x2 vector value up to the nearest value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 ceil(F32x2 x) { return new F32x2(ceil(x.x), ceil(x.y)); }

        /// <summary>Returns the result of rounding each component of a F32x3 vector value up to the nearest value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 ceil(F32x3 x) { return new F32x3(ceil(x.x), ceil(x.y), ceil(x.z)); }

        /// <summary>Returns the result of rounding each component of a F32x4 vector value up to the nearest value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 ceil(F32x4 x) { return new F32x4(ceil(x.x), ceil(x.y), ceil(x.z), ceil(x.w)); }


        /// <summary>Returns the result of rounding a F64 value up to the nearest greater I32egral value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 ceil(F64 x) { return System.Math.Ceiling(x); }

        /// <summary>Returns the result of rounding each component of a  F64x2 vector value up to the nearest I32egral value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 ceil(F64x2 x) { return new F64x2(ceil(x.x), ceil(x.y)); }

        /// <summary>Returns the result of rounding each component of a  F64x3 vector value up to the nearest I32egral value greater or equal to the original value..</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 ceil(F64x3 x) { return new F64x3(ceil(x.x), ceil(x.y), ceil(x.z)); }

        /// <summary>Returns the result of rounding each component of a  F64x4 vector value up to the nearest I32egral value greater or equal to the original value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round up to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 ceil(F64x4 x) { return new F64x4(ceil(x.x), ceil(x.y), ceil(x.z), ceil(x.w)); }


        /// <summary>Returns the result of rounding a F32 value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 round(F32 x) { return (F32)System.Math.Round((F32)x); }

        /// <summary>Returns the result of rounding each component of a F32x2 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 round(F32x2 x) { return new F32x2(round(x.x), round(x.y)); }

        /// <summary>Returns the result of rounding each component of a F32x3 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 round(F32x3 x) { return new F32x3(round(x.x), round(x.y), round(x.z)); }

        /// <summary>Returns the result of rounding each component of a F32x4 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 round(F32x4 x) { return new F32x4(round(x.x), round(x.y), round(x.z), round(x.w)); }


        /// <summary>Returns the result of rounding a F64 value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 round(F64 x) { return System.Math.Round(x); }

        /// <summary>Returns the result of rounding each component of a  F64x2 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 round(F64x2 x) { return new F64x2(round(x.x), round(x.y)); }

        /// <summary>Returns the result of rounding each component of a  F64x3 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 round(F64x3 x) { return new F64x3(round(x.x), round(x.y), round(x.z)); }

        /// <summary>Returns the result of rounding each component of a  F64x4 vector value to the nearest I32egral value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise round to nearest I32egral value of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 round(F64x4 x) { return new F64x4(round(x.x), round(x.y), round(x.z), round(x.w)); }


        /// <summary>Returns the result of truncating a F32 value to an I32egral F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 trunc(F32 x) { return (F32)System.Math.Truncate((F32)x); }

        /// <summary>Returns the result of a componentwise truncation of a F32x2 value to an I32egral F32x2 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 trunc(F32x2 x) { return new F32x2(trunc(x.x), trunc(x.y)); }

        /// <summary>Returns the result of a componentwise truncation of a F32x3 value to an I32egral F32x3 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 trunc(F32x3 x) { return new F32x3(trunc(x.x), trunc(x.y), trunc(x.z)); }

        /// <summary>Returns the result of a componentwise truncation of a F32x4 value to an I32egral F32x4 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 trunc(F32x4 x) { return new F32x4(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w)); }


        /// <summary>Returns the result of truncating a F64 value to an I32egral F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 trunc(F64 x) { return System.Math.Truncate(x); }

        /// <summary>Returns the result of a componentwise truncation of a  F64x2 value to an I32egral  F64x2 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 trunc(F64x2 x) { return new F64x2(trunc(x.x), trunc(x.y)); }

        /// <summary>Returns the result of a componentwise truncation of a  F64x3 value to an I32egral  F64x3 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 trunc(F64x3 x) { return new F64x3(trunc(x.x), trunc(x.y), trunc(x.z)); }

        /// <summary>Returns the result of a componentwise truncation of a  F64x4 value to an I32egral  F64x4 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise truncation of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 trunc(F64x4 x) { return new F64x4(trunc(x.x), trunc(x.y), trunc(x.z), trunc(x.w)); }


        /// <summary>Returns the fractional part of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 frac(F32 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 frac(F32x2 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 frac(F32x3 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 frac(F32x4 x) { return x - floor(x); }


        /// <summary>Returns the fractional part of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 frac(F64 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 frac(F64x2 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 frac(F64x3 x) { return x - floor(x); }

        /// <summary>Returns the componentwise fractional parts of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise fractional part of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 frac(F64x4 x) { return x - floor(x); }


        /// <summary>Returns the reciprocal a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 rcp(F32 x) { return 1.0f / x; }

        /// <summary>Returns the componentwise reciprocal a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 rcp(F32x2 x) { return 1.0f / x; }

        /// <summary>Returns the componentwise reciprocal a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 rcp(F32x3 x) { return 1.0f / x; }

        /// <summary>Returns the componentwise reciprocal a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 rcp(F32x4 x) { return 1.0f / x; }


        /// <summary>Returns the reciprocal a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 rcp(F64 x) { return 1.0 / x; }

        /// <summary>Returns the componentwise reciprocal a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 rcp(F64x2 x) { return 1.0 / x; }

        /// <summary>Returns the componentwise reciprocal a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 rcp(F64x3 x) { return 1.0 / x; }

        /// <summary>Returns the componentwise reciprocal a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise reciprocal of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 rcp(F64x4 x) { return 1.0 / x; }

        /// <summary>Returns the sign of a F32 value. -1.0f if it is less than zero, 0.0f if it is zero and 1.0f if it greater than zero.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 sign(F32 x) { return (x > 0.0f ? 1.0f : 0.0f) - (x < 0.0f ? 1.0f : 0.0f); }

        /// <summary>Returns the componentwise sign of a F32x2 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 sign(F32x2 x) { return new F32x2(sign(x.x), sign(x.y)); }

        /// <summary>Returns the componentwise sign of a F32x3 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 sign(F32x3 x) { return new F32x3(sign(x.x), sign(x.y), sign(x.z)); }

        /// <summary>Returns the componentwise sign of a F32x4 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 sign(F32x4 x) { return new F32x4(sign(x.x), sign(x.y), sign(x.z), sign(x.w)); }


        /// <summary>Returns the sign of a F64 value. -1.0 if it is less than zero, 0.0 if it is zero and 1.0 if it greater than zero.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 sign(F64 x) { return x == 0 ? 0 : (x > 0.0 ? 1.0 : 0.0) - (x < 0.0 ? 1.0 : 0.0); }

        /// <summary>Returns the componentwise sign of a  F64x2 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 sign(F64x2 x) { return new F64x2(sign(x.x), sign(x.y)); }

        /// <summary>Returns the componentwise sign of a  F64x3 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 sign(F64x3 x) { return new F64x3(sign(x.x), sign(x.y), sign(x.z)); }

        /// <summary>Returns the componentwise sign of a  F64x4 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise sign of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 sign(F64x4 x) { return new F64x4(sign(x.x), sign(x.y), sign(x.z), sign(x.w)); }


        /// <summary>Returns x raised to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 pow(F32 x, F32 y) { return (F32)System.Math.Pow((F32)x, (F32)y); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 pow(F32x2 x, F32x2 y) { return new F32x2(pow(x.x, y.x), pow(x.y, y.y)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 pow(F32x3 x, F32x3 y) { return new F32x3(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 pow(F32x4 x, F32x4 y) { return new F32x4(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z), pow(x.w, y.w)); }


        /// <summary>Returns x raised to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 pow(F64 x, F64 y) { return System.Math.Pow(x, y); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 pow(F64x2 x, F64x2 y) { return new F64x2(pow(x.x, y.x), pow(x.y, y.y)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 pow(F64x3 x, F64x3 y) { return new F64x3(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        /// <param name="x">The exponent base.</param>
        /// <param name="y">The exponent power.</param>
        /// <returns>The componentwise result of raising x to the power y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 pow(F64x4 x, F64x4 y) { return new F64x4(pow(x.x, y.x), pow(x.y, y.y), pow(x.z, y.z), pow(x.w, y.w)); }


        /// <summary>Returns the base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 exp(F32 x) { return (F32)System.Math.Exp((F32)x); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 exp(F32x2 x) { return new F32x2(exp(x.x), exp(x.y)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 exp(F32x3 x) { return new F32x3(exp(x.x), exp(x.y), exp(x.z)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 exp(F32x4 x) { return new F32x4(exp(x.x), exp(x.y), exp(x.z), exp(x.w)); }


        /// <summary>Returns the base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 exp(F64 x) { return System.Math.Exp(x); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 exp(F64x2 x) { return new F64x2(exp(x.x), exp(x.y)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 exp(F64x3 x) { return new F64x3(exp(x.x), exp(x.y), exp(x.z)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-e exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 exp(F64x4 x) { return new F64x4(exp(x.x), exp(x.y), exp(x.z), exp(x.w)); }


        /// <summary>Returns the base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 exp2(F32 x) { return (F32)System.Math.Exp((F32)x * 0.69314718f); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 exp2(F32x2 x) { return new F32x2(exp2(x.x), exp2(x.y)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 exp2(F32x3 x) { return new F32x3(exp2(x.x), exp2(x.y), exp2(x.z)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 exp2(F32x4 x) { return new F32x4(exp2(x.x), exp2(x.y), exp2(x.z), exp2(x.w)); }


        /// <summary>Returns the base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 exp2(F64 x) { return System.Math.Exp(x * 0.693147180559945309); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 exp2(F64x2 x) { return new F64x2(exp2(x.x), exp2(x.y)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 exp2(F64x3 x) { return new F64x3(exp2(x.x), exp2(x.y), exp2(x.z)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 exp2(F64x4 x) { return new F64x4(exp2(x.x), exp2(x.y), exp2(x.z), exp2(x.w)); }


        /// <summary>Returns the base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 exp10(F32 x) { return (F32)System.Math.Exp((F32)x * 2.30258509f); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 exp10(F32x2 x) { return new F32x2(exp10(x.x), exp10(x.y)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 exp10(F32x3 x) { return new F32x3(exp10(x.x), exp10(x.y), exp10(x.z)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 exp10(F32x4 x) { return new F32x4(exp10(x.x), exp10(x.y), exp10(x.z), exp10(x.w)); }


        /// <summary>Returns the base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 exp10(F64 x) { return System.Math.Exp(x * 2.302585092994045684); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 exp10(F64x2 x) { return new F64x2(exp10(x.x), exp10(x.y)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 exp10(F64x3 x) { return new F64x3(exp10(x.x), exp10(x.y), exp10(x.z)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 exponential of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 exp10(F64x4 x) { return new F64x4(exp10(x.x), exp10(x.y), exp10(x.z), exp10(x.w)); }


        /// <summary>Returns the natural logarithm of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 log(F32 x) { return (F32)System.Math.Log((F32)x); }

        /// <summary>Returns the componentwise natural logarithm of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 log(F32x2 x) { return new F32x2(log(x.x), log(x.y)); }

        /// <summary>Returns the componentwise natural logarithm of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 log(F32x3 x) { return new F32x3(log(x.x), log(x.y), log(x.z)); }

        /// <summary>Returns the componentwise natural logarithm of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 log(F32x4 x) { return new F32x4(log(x.x), log(x.y), log(x.z), log(x.w)); }


        /// <summary>Returns the natural logarithm of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 log(F64 x) { return System.Math.Log(x); }

        /// <summary>Returns the componentwise natural logarithm of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 log(F64x2 x) { return new F64x2(log(x.x), log(x.y)); }

        /// <summary>Returns the componentwise natural logarithm of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 log(F64x3 x) { return new F64x3(log(x.x), log(x.y), log(x.z)); }

        /// <summary>Returns the componentwise natural logarithm of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise natural logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 log(F64x4 x) { return new F64x4(log(x.x), log(x.y), log(x.z), log(x.w)); }


        /// <summary>Returns the base-2 logarithm of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 log2(F32 x) { return (F32)System.Math.Log((F32)x, 2.0f); }

        /// <summary>Returns the componentwise base-2 logarithm of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 log2(F32x2 x) { return new F32x2(log2(x.x), log2(x.y)); }

        /// <summary>Returns the componentwise base-2 logarithm of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 log2(F32x3 x) { return new F32x3(log2(x.x), log2(x.y), log2(x.z)); }

        /// <summary>Returns the componentwise base-2 logarithm of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 log2(F32x4 x) { return new F32x4(log2(x.x), log2(x.y), log2(x.z), log2(x.w)); }


        /// <summary>Returns the base-2 logarithm of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 log2(F64 x) { return System.Math.Log(x, 2.0); }

        /// <summary>Returns the componentwise base-2 logarithm of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 log2(F64x2 x) { return new F64x2(log2(x.x), log2(x.y)); }

        /// <summary>Returns the componentwise base-2 logarithm of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 log2(F64x3 x) { return new F64x3(log2(x.x), log2(x.y), log2(x.z)); }

        /// <summary>Returns the componentwise base-2 logarithm of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-2 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 log2(F64x4 x) { return new F64x4(log2(x.x), log2(x.y), log2(x.z), log2(x.w)); }

        /// <summary>Returns the base-10 logarithm of a F32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 log10(F32 x) { return (F32)System.Math.Log10((F32)x); }

        /// <summary>Returns the componentwise base-10 logarithm of a F32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 log10(F32x2 x) { return new F32x2(log10(x.x), log10(x.y)); }

        /// <summary>Returns the componentwise base-10 logarithm of a F32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 log10(F32x3 x) { return new F32x3(log10(x.x), log10(x.y), log10(x.z)); }

        /// <summary>Returns the componentwise base-10 logarithm of a F32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 log10(F32x4 x) { return new F32x4(log10(x.x), log10(x.y), log10(x.z), log10(x.w)); }


        /// <summary>Returns the base-10 logarithm of a F64 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 log10(F64 x) { return System.Math.Log10(x); }

        /// <summary>Returns the componentwise base-10 logarithm of a  F64x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 log10(F64x2 x) { return new F64x2(log10(x.x), log10(x.y)); }

        /// <summary>Returns the componentwise base-10 logarithm of a  F64x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 log10(F64x3 x) { return new F64x3(log10(x.x), log10(x.y), log10(x.z)); }

        /// <summary>Returns the componentwise base-10 logarithm of a  F64x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise base-10 logarithm of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 log10(F64x4 x) { return new F64x4(log10(x.x), log10(x.y), log10(x.z), log10(x.w)); }


        /// <summary>Returns the F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 fmod(F32 x, F32 y) { return x % y; }

        /// <summary>Returns the componentwise F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 fmod(F32x2 x, F32x2 y) { return new F32x2(x.x % y.x, x.y % y.y); }

        /// <summary>Returns the componentwise F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 fmod(F32x3 x, F32x3 y) { return new F32x3(x.x % y.x, x.y % y.y, x.z % y.z); }

        /// <summary>Returns the componentwise F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 fmod(F32x4 x, F32x4 y) { return new F32x4(x.x % y.x, x.y % y.y, x.z % y.z, x.w % y.w); }


        /// <summary>Returns the F64 precision F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 fmod(F64 x, F64 y) { return x % y; }

        /// <summary>Returns the componentwise F64 precision F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 fmod(F64x2 x, F64x2 y) { return new F64x2(x.x % y.x, x.y % y.y); }

        /// <summary>Returns the componentwise F64 precision F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 fmod(F64x3 x, F64x3 y) { return new F64x3(x.x % y.x, x.y % y.y, x.z % y.z); }

        /// <summary>Returns the componentwise F64 precision F32ing poI32 remainder of x/y.</summary>
        /// <param name="x">The dividend in x/y.</param>
        /// <param name="y">The divisor in x/y.</param>
        /// <returns>The componentwise remainder of x/y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 fmod(F64x4 x, F64x4 y) { return new F64x4(x.x % y.x, x.y % y.y, x.z % y.z, x.w % y.w); }


        /// <summary>Splits a F32 value I32o an I32egral part i and a fractional part that gets returned. Both parts take the sign of the input.</summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 modf(F32 x, out F32 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a F32x2 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 modf(F32x2 x, out F32x2 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a F32x3 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 modf(F32x3 x, out F32x3 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a F32x4 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 modf(F32x4 x, out F32x4 i) { i = trunc(x); return x - i; }


        /// <summary>Splits a F64 value I32o an I32egral part i and a fractional part that gets returned. Both parts take the sign of the input.</summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 modf(F64 x, out F64 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a  F64x2 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 modf(F64x2 x, out  F64x2 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a  F64x3 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 modf(F64x3 x, out  F64x3 i) { i = trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a  F64x4 vector I32o an I32egral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        /// <param name="x">Value to split I32o I32egral and fractional part.</param>
        /// <param name="i">Output value containing I32egral part of x.</param>
        /// <returns>The componentwise fractional part of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 modf(F64x4 x, out  F64x4 i) { i = trunc(x); return x - i; }


        /// <summary>Returns the square root of a F32 value.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 sqrt(F32 x) { return (F32)System.Math.Sqrt((F32)x); }

        /// <summary>Returns the componentwise square root of a F32x2 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 sqrt(F32x2 x) { return new F32x2(sqrt(x.x), sqrt(x.y)); }

        /// <summary>Returns the componentwise square root of a F32x3 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 sqrt(F32x3 x) { return new F32x3(sqrt(x.x), sqrt(x.y), sqrt(x.z)); }

        /// <summary>Returns the componentwise square root of a F32x4 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 sqrt(F32x4 x) { return new F32x4(sqrt(x.x), sqrt(x.y), sqrt(x.z), sqrt(x.w)); }


        /// <summary>Returns the square root of a F64 value.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 sqrt(F64 x) { return System.Math.Sqrt(x); }

        /// <summary>Returns the componentwise square root of a  F64x2 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 sqrt(F64x2 x) { return new F64x2(sqrt(x.x), sqrt(x.y)); }

        /// <summary>Returns the componentwise square root of a  F64x3 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 sqrt(F64x3 x) { return new F64x3(sqrt(x.x), sqrt(x.y), sqrt(x.z)); }

        /// <summary>Returns the componentwise square root of a  F64x4 vector.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The componentwise square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 sqrt(F64x4 x) { return new F64x4(sqrt(x.x), sqrt(x.y), sqrt(x.z), sqrt(x.w)); }


        /// <summary>Returns the reciprocal square root of a F32 value.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 rsqrt(F32 x) { return 1.0f / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a F32x2 vector.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 rsqrt(F32x2 x) { return 1.0f / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a F32x3 vector.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 rsqrt(F32x3 x) { return 1.0f / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a F32x4 vector</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 rsqrt(F32x4 x) { return 1.0f / sqrt(x); }


        /// <summary>Returns the reciprocal square root of a F64 value.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 rsqrt(F64 x) { return 1.0 / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a  F64x2 vector.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 rsqrt(F64x2 x) { return 1.0 / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a  F64x3 vector.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 rsqrt(F64x3 x) { return 1.0 / sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a  F64x4 vector.</summary>
        /// <param name="x">Value to use when computing reciprocal square root.</param>
        /// <returns>The componentwise reciprocal square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 rsqrt(F64x4 x) { return 1.0 / sqrt(x); }


        /// <summary>Returns a normalized version of the F32x2 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 Normalize(this F32x2 x) { return rsqrt(dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the F32x3 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 Normalize(this F32x3 x) { return rsqrt(dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the F32x4 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 Normalize(this F32x4 x) { return rsqrt(dot(x, x)) * x; }


        /// <summary>Returns a normalized version of the  F64x2 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 Normalize(this F64x2 x) { return rsqrt(dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the  F64x3 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 Normalize(this F64x3 x) { return rsqrt(dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the  F64x4 vector x by scaling it by 1 / length(x).</summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 Normalize(this F64x4 x) { return rsqrt(dot(x, x)) * x; }


        /// <summary>
        /// Returns a safe normalized version of the F32x2 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public F32x2 NormalizeSafe(this F32x2 x, F32x2 defaultvalue = new F32x2())
        {
            F32 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }

        /// <summary>
        /// Returns a safe normalized version of the F32x3 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public F32x3 NormalizeSafe(this F32x3 x, F32x3 defaultvalue = new F32x3())
        {
            F32 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }

        /// <summary>
        /// Returns a safe normalized version of the F32x4 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public F32x4 NormalizeSafe(this F32x4 x, F32x4 defaultvalue = new F32x4())
        {
            F32 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }


        /// <summary>
        /// Returns a safe normalized version of the  F64x4 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public  F64x2 NormalizeSafe(this F64x2 x, F64x2 defaultvalue = new F64x2())
        {
            F64 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }

        /// <summary>
        /// Returns a safe normalized version of the  F64x4 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public  F64x3 NormalizeSafe(this F64x3 x, F64x3 defaultvalue = new F64x3())
        {
            F64 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }

        /// <summary>
        /// Returns a safe normalized version of the  F64x4 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        /// <param name="x">Vector to Normalize.</param>
        /// <param name="defaultvalue">Vector to return if normalized vector is not finite.</param>
        /// <returns>The normalized vector or the default value if the normalized vector is not finite.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public  F64x4 NormalizeSafe(this F64x4 x, F64x4 defaultvalue = new F64x4())
        {
            F64 len = Maths.dot(x, x);
            return Maths.select(defaultvalue, x * Maths.rsqrt(len), len > FLT_MIN_NORMAL);
        }


        /// <summary>Returns the length of a F32 value. Equivalent to the absolute value.</summary>
        /// <param name="x">Value to use when computing length.</param>
        /// <returns>Length of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Length(this F32 x) { return abs(x); }

        /// <summary>Returns the length of a F32x2 vector.</summary>
        /// <param name="x">Vector to use when computing length.</param>
        /// <returns>Length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Length(this F32x2 x) { return sqrt(dot(x, x)); }

        /// <summary>Returns the length of a F32x3 vector.</summary>
        /// <param name="x">Vector to use when computing length.</param>
        /// <returns>Length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Length(this F32x3 x) { return sqrt(dot(x, x)); }

        /// <summary>Returns the length of a F32x4 vector.</summary>
        /// <param name="x">Vector to use when computing length.</param>
        /// <returns>Length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Length(this F32x4 x) { return sqrt(dot(x, x)); }


        /// <summary>Returns the length of a F64 value. Equivalent to the absolute value.</summary>
        /// <param name="x">Value to use when computing squared length.</param>
        /// <returns>Squared length of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Length(this F64 x) { return abs(x); }

        /// <summary>Returns the length of a  F64x2 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Length(this F64x2 x) { return sqrt(dot(x, x)); }

        /// <summary>Returns the length of a  F64x3 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Length(this F64x3 x) { return sqrt(dot(x, x)); }

        /// <summary>Returns the length of a  F64x4 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Length(this F64x4 x) { return sqrt(dot(x, x)); }


        /// <summary>Returns the squared length of a F32 value. Equivalent to squaring the value.</summary>
        /// <param name="x">Value to use when computing squared length.</param>
        /// <returns>Squared length of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 LengthSqr(this F32 x) { return x*x; }

        /// <summary>Returns the squared length of a F32x2 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 LengthSqr(this F32x2 x) { return dot(x, x); }

        /// <summary>Returns the squared length of a F32x3 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 LengthSqr(this F32x3 x) { return dot(x, x); }

        /// <summary>Returns the squared length of a F32x4 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 LengthSqr(this F32x4 x) { return dot(x, x); }


        /// <summary>Returns the squared length of a F64 value. Equivalent to squaring the value.</summary>
        /// <param name="x">Value to use when computing squared length.</param>
        /// <returns>Squared length of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 LengthSqr(this F64 x) { return x * x; }

        /// <summary>Returns the squared length of a  F64x2 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 LengthSqr(this F64x2 x) { return dot(x, x); }

        /// <summary>Returns the squared length of a  F64x3 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 LengthSqr(this F64x3 x) { return dot(x, x); }

        /// <summary>Returns the squared length of a  F64x4 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 LengthSqr(this F64x4 x) { return dot(x, x); }


        /// <summary>Returns the distance between two F32 values.</summary>
        /// <param name="x">First value to use in distance computation.</param>
        /// <param name="y">Second value to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Distance(this F32 origin, F32 to) => abs(to - origin);

        /// <summary>Returns the distance between two F32x2 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Distance(this F32x2 x, F32x2 to) => Length(to - x);

        /// <summary>Returns the distance between two F32x3 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Distance(this F32x3 x, F32x3 to) => Length(to - x);

        /// <summary>Returns the distance between two F32x4 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Distance(this F32x4 x, F32x4 to) => Length(to - x);


        /// <summary>Returns the distance between two F64 values.</summary>
        /// <param name="x">First value to use in distance computation.</param>
        /// <param name="y">Second value to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Distance(this F64 x, F64 to) => abs(to - x);

        /// <summary>Returns the distance between two  F64x2 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Distance(this F64x2 x, F64x2 to) => Length(to - x);

        /// <summary>Returns the distance between two  F64x3 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Distance(this F64x3 x, F64x3 to) => Length(to - x);

        /// <summary>Returns the distance between two  F64x4 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 Distance(this F64x4 x, F64x4 to) => Length(to - x);


        /// <summary>Returns the squared distance between two F32 values.</summary>
        /// <param name="x">First value to use in distance computation.</param>
        /// <param name="y">Second value to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 DistanceSqr(this F32 x, F32 to) => (to - x) * (to - x);

        /// <summary>Returns the squared distance between two F32x2 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 DistanceSqr(this F32x2 x, F32x2 to) => LengthSqr(to - x);

        /// <summary>Returns the squared distance between two F32x3 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 DistanceSqr(this F32x3 x, F32x3 to) => LengthSqr(to - x);

        /// <summary>Returns the squared distance between two F32x4 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 DistanceSqr(this F32x4 x, F32x4 to) => LengthSqr(to - x);


        /// <summary>Returns the squared distance between two F64 values.</summary>
        /// <param name="x">First value to use in distance computation.</param>
        /// <param name="y">Second value to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 DistanceSqr(this F64 x, F64 to) => (to - x) * (to - x);

        /// <summary>Returns the squared distance between two  F64x2 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 DistanceSqr(this F64x2 x, F64x2 y) => LengthSqr(y - x);

        /// <summary>Returns the squared distance between two  F64x3 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 DistanceSqr(this F64x3 x, F64x3 y) => LengthSqr(y - x);

        /// <summary>Returns the squared distance between two  F64x4 vectors.</summary>
        /// <param name="x">First vector to use in distance computation.</param>
        /// <param name="y">Second vector to use in distance computation.</param>
        /// <returns>The squared distance between x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 DistanceSqr(this F64x4 x, F64x4 y) => LengthSqr(y - x);


        /// <summary>Returns the cross product of two F32x3 vectors.</summary>
        /// <param name="x">First vector to use in cross product.</param>
        /// <param name="y">Second vector to use in cross product.</param>
        /// <returns>The cross product of x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 cross(F32x3 x, F32x3 y) { return (x * y.yzx - x.yzx * y).yzx; }

        /// <summary>Returns the cross product of two  F64x3 vectors.</summary>
        /// <param name="x">First vector to use in cross product.</param>
        /// <param name="y">Second vector to use in cross product.</param>
        /// <returns>The cross product of x and y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 cross(F64x3 x, F64x3 y) { return (x * y.yzx - x.yzx * y).yzx; }


        /// <summary>Returns a smooth Hermite I32erpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns a value camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 smoothstep(F32 a, F32 b, F32 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 smoothstep(F32x2 a, F32x2 b, F32x2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 smoothstep(F32x3 a, F32x3 b, F32x3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 smoothstep(F32x4 a, F32x4 b, F32x4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }


        /// <summary>Returns a smooth Hermite I32erpolation between 0.0 and 1.0 when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns a value camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 smoothstep(F64 a, F64 b, F64 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0 and 1.0 when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 smoothstep(F64x2 a, F64x2 b, F64x2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0 and 1.0 when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 smoothstep(F64x3 a, F64x3 b, F64x3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        /// <summary>Returns a componentwise smooth Hermite I32erpolation between 0.0 and 1.0 when x is in [a, b].</summary>
        /// <param name="a">The minimum range of the x parameter.</param>
        /// <param name="b">The maximum range of the x parameter.</param>
        /// <param name="x">The value to be I32erpolated.</param>
        /// <returns>Returns component values camped to the range [0, 1].</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 smoothstep(F64x4 a, F64x4 b, F64x4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }


        /// <summary>Returns true if any component of the input Boolx2 vector is true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(Boolx2 x) { return x.x || x.y; }

        /// <summary>Returns true if any component of the input Boolx3 vector is true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(Boolx3 x) { return x.x || x.y || x.z; }

        /// <summary>Returns true if any components of the input Boolx4 vector is true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(Boolx4 x) { return x.x || x.y || x.z || x.w; }


        /// <summary>Returns true if any component of the input I32x2 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(I32x2 x) { return x.x != 0 || x.y != 0; }

        /// <summary>Returns true if any component of the input I32x3 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(I32x3 x) { return x.x != 0 || x.y != 0 || x.z != 0; }

        /// <summary>Returns true if any components of the input I32x4 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(I32x4 x) { return x.x != 0 || x.y != 0 || x.z != 0 || x.w != 0; }


        /// <summary>Returns true if any component of the input U32x2 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(U32x2 x) { return x.x != 0 || x.y != 0; }

        /// <summary>Returns true if any component of the input U32x3 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(U32x3 x) { return x.x != 0 || x.y != 0 || x.z != 0; }

        /// <summary>Returns true if any components of the input U32x4 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(U32x4 x) { return x.x != 0 || x.y != 0 || x.z != 0 || x.w != 0; }


        /// <summary>Returns true if any component of the input F32x2 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F32x2 x) { return x.x != 0.0f || x.y != 0.0f; }

        /// <summary>Returns true if any component of the input F32x3 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F32x3 x) { return x.x != 0.0f || x.y != 0.0f || x.z != 0.0f; }

        /// <summary>Returns true if any component of the input F32x4 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F32x4 x) { return x.x != 0.0f || x.y != 0.0f || x.z != 0.0f || x.w != 0.0f; }


        /// <summary>Returns true if any component of the input  F64x2 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F64x2 x) { return x.x != 0.0 || x.y != 0.0; }

        /// <summary>Returns true if any component of the input  F64x3 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F64x3 x) { return x.x != 0.0 || x.y != 0.0 || x.z != 0.0; }

        /// <summary>Returns true if any component of the input  F64x4 vector is non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if any the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool any(F64x4 x) { return x.x != 0.0 || x.y != 0.0 || x.z != 0.0 || x.w != 0.0; }


        /// <summary>Returns true if all components of the input Boolx2 vector are true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(Boolx2 x) { return x.x && x.y; }

        /// <summary>Returns true if all components of the input Boolx3 vector are true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(Boolx3 x) { return x.x && x.y && x.z; }

        /// <summary>Returns true if all components of the input Boolx4 vector are true, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are true, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(Boolx4 x) { return x.x && x.y && x.z && x.w; }


        /// <summary>Returns true if all components of the input I32x2 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(I32x2 x) { return x.x != 0 && x.y != 0; }

        /// <summary>Returns true if all components of the input I32x3 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(I32x3 x) { return x.x != 0 && x.y != 0 && x.z != 0; }

        /// <summary>Returns true if all components of the input I32x4 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(I32x4 x) { return x.x != 0 && x.y != 0 && x.z != 0 && x.w != 0; }


        /// <summary>Returns true if all components of the input U32x2 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(U32x2 x) { return x.x != 0 && x.y != 0; }

        /// <summary>Returns true if all components of the input U32x3 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(U32x3 x) { return x.x != 0 && x.y != 0 && x.z != 0; }

        /// <summary>Returns true if all components of the input U32x4 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(U32x4 x) { return x.x != 0 && x.y != 0 && x.z != 0 && x.w != 0; }


        /// <summary>Returns true if all components of the input F32x2 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F32x2 x) { return x.x != 0.0f && x.y != 0.0f; }

        /// <summary>Returns true if all components of the input F32x3 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F32x3 x) { return x.x != 0.0f && x.y != 0.0f && x.z != 0.0f; }

        /// <summary>Returns true if all components of the input F32x4 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F32x4 x) { return x.x != 0.0f && x.y != 0.0f && x.z != 0.0f && x.w != 0.0f; }


        /// <summary>Returns true if all components of the input  F64x2 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F64x2 x) { return x.x != 0.0 && x.y != 0.0; }

        /// <summary>Returns true if all components of the input  F64x3 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F64x3 x) { return x.x != 0.0 && x.y != 0.0 && x.z != 0.0; }

        /// <summary>Returns true if all components of the input  F64x4 vector are non-zero, false otherwise.</summary>
        /// <param name="x">Vector of values to compare.</param>
        /// <returns>True if all the components of x are non-zero, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool all(F64x4 x) { return x.x != 0.0 && x.y != 0.0 && x.z != 0.0 && x.w != 0.0; }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 select(I32 a, I32 b, Bool c)    { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 select(I32x2 a, I32x2 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 select(I32x3 a, I32x3 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 select(I32x4 a, I32x4 b, Bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 select(I32x2 a, I32x2 b, Boolx2 c) { return new I32x2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 select(I32x3 a, I32x3 b, Boolx3 c) { return new I32x3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 select(I32x4 a, I32x4 b, Boolx4 c) { return new I32x4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 select(U32 a, U32 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 select(U32x2 a, U32x2 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 select(U32x3 a, U32x3 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 select(U32x4 a, U32x4 b, Bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 select(U32x2 a, U32x2 b, Boolx2 c) { return new U32x2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 select(U32x3 a, U32x3 b, Boolx3 c) { return new U32x3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 select(U32x4 a, U32x4 b, Boolx4 c) { return new U32x4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long select(long a, long b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong select(ulong a, ulong b, Bool c) { return c ? b : a; }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 select(F32 a, F32 b, Bool c)    { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 select(F32x2 a, F32x2 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 select(F32x3 a, F32x3 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 select(F32x4 a, F32x4 b, Bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 select(F32x2 a, F32x2 b, Boolx2 c) { return new F32x2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 select(F32x3 a, F32x3 b, Boolx3 c) { return new F32x3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 select(F32x4 a, F32x4 b, Boolx4 c) { return new F32x4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 select(F64 a, F64 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 select(F64x2 a, F64x2 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 select(F64x3 a, F64x3 b, Bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        /// <param name="a">Value to use if c is false.</param>
        /// <param name="b">Value to use if c is true.</param>
        /// <param name="c">Bool value to choose between a and b.</param>
        /// <returns>The selection between a and b according to Bool c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 select(F64x4 a, F64x4 b, Bool c) { return c ? b : a; }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 select(F64x2 a, F64x2 b, Boolx2 c) { return new F64x2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 select(F64x3 a, F64x3 b, Boolx3 c) { return new F64x3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two  F64x4 vectors a and b based on a Boolx4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        /// <param name="a">Values to use if c is false.</param>
        /// <param name="b">Values to use if c is true.</param>
        /// <param name="c">Selection mask to choose between a and b.</param>
        /// <returns>The componentwise selection between a and b according to selection mask c.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 select(F64x4 a, F64x4 b, Boolx4 c) { return new F64x4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns the result of a step function where the result is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Value to be used as a threshold for returning 1.</param>
        /// <param name="x">Value to compare against threshold y.</param>
        /// <returns>1 if the comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 step(F32 y, F32 x) { return select(0.0f, 1.0f, x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 step(F32x2 y, F32x2 x) { return select(new F32x2(0.0f), new F32x2(1.0f), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 step(F32x3 y, F32x3 x) { return select(new F32x3(0.0f), new F32x3(1.0f), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 step(F32x4 y, F32x4 x) { return select(new F32x4(0.0f), new F32x4(1.0f), x >= y); }


        /// <summary>Returns the result of a step function where the result is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Values to be used as a threshold for returning 1.</param>
        /// <param name="x">Values to compare against threshold y.</param>
        /// <returns>1 if the comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 step(F64 y, F64 x) { return select(0.0, 1.0, x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 step(F64x2 y, F64x2 x) { return select(new F64x2(0.0), new F64x2(1.0), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 step(F64x3 y, F64x3 x) { return select(new F64x3(0.0), new F64x3(1.0), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x &gt;= y and 0.0f otherwise.</summary>
        /// <param name="y">Vector of values to be used as a threshold for returning 1.</param>
        /// <param name="x">Vector of values to compare against threshold y.</param>
        /// <returns>1 if the componentwise comparison x &gt;= y is true, otherwise 0.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 step(F64x4 y, F64x4 x) { return select(new F64x4(0.0), new F64x4(1.0), x >= y); }


        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 reflect(F32x2 i, F32x2 n) { return i - 2f * n * dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 reflect(F32x3 i, F32x3 n) { return i - 2f * n * dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 reflect(F32x4 i, F32x4 n) { return i - 2f * n * dot(i, n); }


        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 reflect(F64x2 i, F64x2 n) { return i - 2 * n * dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 reflect(F64x3 i, F64x3 n) { return i - 2 * n * dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <returns>Reflection vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 reflect(F64x4 i, F64x4 n) { return i - 2 * n * dot(i, n); }


        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 refract(F32x2 i, F32x2 n, F32 eta)
        {
            F32 ni = dot(n, i);
            F32 k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 refract(F32x3 i, F32x3 n, F32 eta)
        {
            F32 ni = dot(n, i);
            F32 k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 refract(F32x4 i, F32x4 n, F32 eta)
        {
            F32 ni = dot(n, i);
            F32 k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }


        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 refract(F64x2 i, F64x2 n, F64 eta)
        {
            F64 ni = dot(n, i);
            F64 k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 refract(F64x3 i, F64x3 n, F64 eta)
        {
            F64 ni = dot(n, i);
            F64 k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        /// <param name="i">Incident vector.</param>
        /// <param name="n">Normal vector.</param>
        /// <param name="eta">Index of refraction.</param>
        /// <returns>Refraction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 refract(F64x4 i, F64x4 n, F64 eta)
        {
            F64 ni = dot(n, i);
            F64 k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F32x2,F32x2,F32x2)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 project(F32x2 a, F32x2 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F32x3,F32x3,F32x3)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 project(F32x3 a, F32x3 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F32x4,F32x4,F32x4)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 project(F32x4 a, F32x4 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F32x2,F32x2)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 projectsafe(F32x2 a, F32x2 b, F32x2 defaultValue = new F32x2())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F32x3,F32x3)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 projectsafe(F32x3 a, F32x3 b, F32x3 defaultValue = new F32x3())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F32x4,F32x4)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 projectsafe(F32x4 a, F32x4 b, F32x4 defaultValue = new F32x4())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to F64.MaxValue) or when b's components are very small (close to DBL_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F64x2, F64x2, F64x2)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 project(F64x2 a, F64x2 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to F64.MaxValue) or when b's components are very small (close to DBL_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F64x3, F64x3, F64x3)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 project(F64x3 a, F64x3 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to F64.MaxValue) or when b's components are very small (close to DBL_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(F64x4, F64x4, F64x4)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 project(F64x4 a, F64x4 b)
        {
            return (dot(a, b) / dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F64x2, F64x2)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 projectsafe(F64x2 a, F64x2 b, F64x2 defaultValue = new F64x2())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F64x3, F64x3)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 projectsafe(F64x3 a, F64x3 b, F64x3 defaultValue = new F64x3())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(F64x4, F64x4)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 projectsafe(F64x4 a, F64x4 b, F64x4 defaultValue = new F64x4())
        {
            var proj = project(a, b);

            return select(defaultValue, proj, all(isfinite(proj)));
        }

        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 faceforward(F32x2 n, F32x2 i, F32x2 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 faceforward(F32x3 n, F32x3 i, F32x3 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 faceforward(F32x4 n, F32x4 i, F32x4 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }


        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 faceforward(F64x2 n, F64x2 i, F64x2 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 faceforward(F64x3 n, F64x3 i, F64x3 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        /// <summary>Conditionally flips a vector n if two vectors i and ng are poI32ing in the same direction. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        /// <param name="n">Vector to conditionally flip.</param>
        /// <param name="i">First vector in direction comparison.</param>
        /// <param name="ng">Second vector in direction comparison.</param>
        /// <returns>-n if i and ng poI32 in the same direction; otherwise return n unchanged.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 faceforward(F64x4 n, F64x4 i, F64x4 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }


        /// <summary>Returns the sine and cosine of the input F32 value x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input angle in radians.</param>
        /// <param name="s">Output sine of the input.</param>
        /// <param name="c">Output cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F32 x, out F32 s, out F32 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input F32x2 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F32x2 x, out F32x2 s, out F32x2 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input F32x3 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F32x3 x, out F32x3 s, out F32x3 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input F32x4 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F32x4 x, out F32x4 s, out F32x4 c) { s = sin(x); c = cos(x); }


        /// <summary>Returns the sine and cosine of the input F64 value x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input angle in radians.</param>
        /// <param name="s">Output sine of the input.</param>
        /// <param name="c">Output cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F64 x, out F64 s, out F64 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input  F64x2 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F64x2 x, out F64x2 s, out F64x2 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input  F64x3 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F64x3 x, out F64x3 s, out F64x3 c) { s = sin(x); c = cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input  F64x4 vector x through the out parameters s and c.</summary>
        /// <remarks>When Burst compiled, his method is faster than calling sin() and cos() separately.</remarks>
        /// <param name="x">Input vector containing angles in radians.</param>
        /// <param name="s">Output vector containing the componentwise sine of the input.</param>
        /// <param name="c">Output vector containing the componentwise cosine of the input.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(F64x4 x, out F64x4 s, out F64x4 c) { s = sin(x); c = cos(x); }


        /// <summary>Returns number of 1-bits in the binary representation of an I32 value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">I32 value in which to count bits set to 1.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 countbits(I32 x) { return countbits((U32)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an I32x2 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">I32x2 value in which to count bits for each component.</param>
        /// <returns>I32x2 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 countbits(I32x2 x) { return countbits((U32x2)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an I32x3 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>I32x3 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 countbits(I32x3 x) { return countbits((U32x3)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an I32x4 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>I32x4 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 countbits(I32x4 x) { return countbits((U32x4)x); }


        /// <summary>Returns number of 1-bits in the binary representation of a U32 value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 countbits(U32 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return (I32)((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a U32x2 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>I32x2 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 countbits(U32x2 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return new I32x2((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a U32x3 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>I32x3 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 countbits(U32x3 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return new I32x3((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a U32x4 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>I32x4 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 countbits(U32x4 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return new I32x4((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns number of 1-bits in the binary representation of a ulong value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 countbits(ulong x)
        {
            x = x - ((x >> 1) & 0x5555555555555555);
            x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333);
            return (I32)((((x + (x >> 4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 56);
        }

        /// <summary>Returns number of 1-bits in the binary representation of a long value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 countbits(long x) { return countbits((ulong)x); }


        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an I32 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 lzcnt(I32 x) { return lzcnt((U32)x); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an I32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 lzcnt(I32x2 x) { return new I32x2(lzcnt(x.x), lzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an I32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 lzcnt(I32x3 x) { return new I32x3(lzcnt(x.x), lzcnt(x.y), lzcnt(x.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an I32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 lzcnt(I32x4 x) { return new I32x4(lzcnt(x.x), lzcnt(x.y), lzcnt(x.z), lzcnt(x.w)); }


        /// <summary>Returns number of leading zeros in the binary representations of a U32 value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 lzcnt(U32 x)
        {
            if (x == 0)
                return 32;
            I64_F64_Union u;
            u.F64Value = 0.0;
            u.I64Value = 0x4330000000000000L + x;
            u.F64Value -= 4503599627370496.0;
            return 0x41E - (I32)(u.I64Value >> 52);
        }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a U32x2 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 lzcnt(U32x2 x) { return new I32x2(lzcnt(x.x), lzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a U32x3 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 lzcnt(U32x3 x) { return new I32x3(lzcnt(x.x), lzcnt(x.y), lzcnt(x.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a U32x4 vector.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 lzcnt(U32x4 x) { return new I32x4(lzcnt(x.x), lzcnt(x.y), lzcnt(x.z), lzcnt(x.w)); }


        /// <summary>Returns number of leading zeros in the binary representations of a long value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 lzcnt(long x) { return lzcnt((ulong)x); }


        /// <summary>Returns number of leading zeros in the binary representations of a ulong value.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The number of leading zeros of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 lzcnt(ulong x)
        {
            if (x == 0)
                return 64;

            U32 xh = (U32)(x >> 32);
            U32 bits = xh != 0 ? xh : (U32)x;
            I32 offset = xh != 0 ? 0x41E : 0x43E;

            I64_F64_Union u;
            u.F64Value = 0.0;
            u.I64Value = 0x4330000000000000L + bits;
            u.F64Value -= 4503599627370496.0;
            return offset - (I32)(u.I64Value >> 52);
        }

        /// <summary>
        /// Computes the trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 tzcnt(I32 x) { return tzcnt((U32)x); }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 tzcnt(I32x2 x) { return new I32x2(tzcnt(x.x), tzcnt(x.y)); }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 tzcnt(I32x3 x) { return new I32x3(tzcnt(x.x), tzcnt(x.y), tzcnt(x.z)); }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 tzcnt(I32x4 x) { return new I32x4(tzcnt(x.x), tzcnt(x.y), tzcnt(x.z), tzcnt(x.w)); }


        /// <summary>
        /// Computes the trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 tzcnt(U32 x)
        {
            if (x == 0) return 32;

            x &= (U32)(-x);
            I64_F64_Union u;
            u.F64Value = 0.0;
            u.I64Value = 0x4330000000000000L + x;
            u.F64Value -= 4503599627370496.0;
            return (I32)(u.I64Value >> 52) - 0x3FF;
        }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 tzcnt(U32x2 x) { return new I32x2(tzcnt(x.x), tzcnt(x.y)); }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 tzcnt(U32x3 x) { return new I32x3(tzcnt(x.x), tzcnt(x.y), tzcnt(x.z)); }

        /// <summary>
        /// Computes the component-wise trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the component-wise trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 tzcnt(U32x4 x) { return new I32x4(tzcnt(x.x), tzcnt(x.y), tzcnt(x.z), tzcnt(x.w)); }

        /// <summary>
        /// Computes the trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 tzcnt(long x) { return tzcnt((ulong)x); }

        /// <summary>
        /// Computes the trailing zero count in the binary representation of the input value.
        /// </summary>
        /// <remarks>
        /// Assuming that the least significant bit is on the right, the I32eger value 4 has a binary representation
        /// 0100 and the trailing zero count is two. The I32eger value 1 has a binary representation 0001 and the
        /// trailing zero count is zero.
        /// </remarks>
        /// <param name="x">Input to use when computing the trailing zero count.</param>
        /// <returns>Returns the trailing zero count of the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 tzcnt(ulong x)
        {
            if (x == 0) return 64;

            x = x & (ulong)-(long)x;
            U32 xl = (U32)x;

            U32 bits = xl != 0 ? xl : (U32)(x >> 32);
            I32 offset = xl != 0 ? 0x3FF : 0x3DF;

            I64_F64_Union u;
            u.F64Value = 0.0;
            u.I64Value = 0x4330000000000000L + bits;
            u.F64Value -= 4503599627370496.0;
            return (I32)(u.I64Value >> 52) - offset;
        }



        /// <summary>Returns the result of performing a reversal of the bit pattern of an I32 value.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 reversebits(I32 x) { return (I32)reversebits((U32)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an I32x2 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 reversebits(I32x2 x) { return (I32x2)reversebits((U32x2)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an I32x3 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 reversebits(I32x3 x) { return (I32x3)reversebits((U32x3)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an I32x4 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 reversebits(I32x4 x) { return (I32x4)reversebits((U32x4)x); }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a U32 value.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 reversebits(U32 x) {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an U32x2 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 reversebits(U32x2 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an U32x3 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 reversebits(U32x3 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an U32x4 vector.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with componentwise reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 reversebits(U32x4 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a long value.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long reversebits(long x) { return (long)reversebits((ulong)x); }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a ulong value.</summary>
        /// <param name="x">Value to reverse.</param>
        /// <returns>Value with reversed bits.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong reversebits(ulong x)
        {
            x = ((x >> 1) & 0x5555555555555555ul) | ((x & 0x5555555555555555ul) << 1);
            x = ((x >> 2) & 0x3333333333333333ul) | ((x & 0x3333333333333333ul) << 2);
            x = ((x >> 4) & 0x0F0F0F0F0F0F0F0Ful) | ((x & 0x0F0F0F0F0F0F0F0Ful) << 4);
            x = ((x >> 8) & 0x00FF00FF00FF00FFul) | ((x & 0x00FF00FF00FF00FFul) << 8);
            x = ((x >> 16) & 0x0000FFFF0000FFFFul) | ((x & 0x0000FFFF0000FFFFul) << 16);
            return (x >> 32) | (x << 32);
        }


        /// <summary>Returns the result of rotating the bits of an I32 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 rol(I32 x, I32 n) { return (I32)rol((U32)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x2 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 rol(I32x2 x, I32 n) { return (I32x2)rol((U32x2)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x3 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 rol(I32x3 x, I32 n) { return (I32x3)rol((U32x3)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x4 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 rol(I32x4 x, I32 n) { return (I32x4)rol((U32x4)x, n); }


        /// <summary>Returns the result of rotating the bits of a U32 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 rol(U32 x, I32 n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x2 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 rol(U32x2 x, I32 n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x3 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 rol(U32x3 x, I32 n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x4 left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 rol(U32x4 x, I32 n) { return (x << n) | (x >> (32 - n)); }


        /// <summary>Returns the result of rotating the bits of a long left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long rol(long x, I32 n) { return (long)rol((ulong)x, n); }


        /// <summary>Returns the result of rotating the bits of a ulong left by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong rol(ulong x, I32 n) { return (x << n) | (x >> (64 - n)); }


        /// <summary>Returns the result of rotating the bits of an I32 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 ror(I32 x, I32 n) { return (I32)ror((U32)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x2 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 ror(I32x2 x, I32 n) { return (I32x2)ror((U32x2)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x3 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 ror(I32x3 x, I32 n) { return (I32x3)ror((U32x3)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an I32x4 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 ror(I32x4 x, I32 n) { return (I32x4)ror((U32x4)x, n); }


        /// <summary>Returns the result of rotating the bits of a U32 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 ror(U32 x, I32 n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x2 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 ror(U32x2 x, I32 n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x3 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 ror(U32x3 x, I32 n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a U32x4 right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The componentwise rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 ror(U32x4 x, I32 n) { return (x >> n) | (x << (32 - n)); }


        /// <summary>Returns the result of rotating the bits of a long right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ror(long x, I32 n) { return (long)ror((ulong)x, n); }


        /// <summary>Returns the result of rotating the bits of a ulong right by bits n.</summary>
        /// <param name="x">Value to rotate.</param>
        /// <param name="n">Number of bits to rotate.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ror(ulong x, I32 n) { return (x >> n) | (x << (64 - n)); }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 ceilpow2(I32 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 ceilpow2(I32x2 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 ceilpow2(I32x3 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 ceilpow2(I32x4 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 ceilpow2(U32 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 ceilpow2(U32x2 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 ceilpow2(U32x3 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The componentwise smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 ceilpow2(U32x4 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ceilpow2(long x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        /// <param name="x">Input value.</param>
        /// <returns>The smallest power of two greater than or equal to the input.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ceilpow2(ulong x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            return x + 1;
        }

        /// <summary>
        /// Computes the ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// x must be greater than 0, otherwise the result is undefined.
        /// </remarks>
        /// <param name="x">Integer to be used as input.</param>
        /// <returns>Ceiling of the base-2 logarithm of x, as an I32eger.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 ceillog2(I32 x)
        {
            return 32 - lzcnt((U32)x - 1);
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">I32x2 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 ceillog2(I32x2 x)
        {
            return new I32x2(ceillog2(x.x), ceillog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">I32x3 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 ceillog2(I32x3 x)
        {
            return new I32x3(ceillog2(x.x), ceillog2(x.y), ceillog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">I32x4 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 ceillog2(I32x4 x)
        {
            return new I32x4(ceillog2(x.x), ceillog2(x.y), ceillog2(x.z), ceillog2(x.w));
        }

        /// <summary>
        /// Computes the ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// x must be greater than 0, otherwise the result is undefined.
        /// </remarks>
        /// <param name="x">Unsigned I32eger to be used as input.</param>
        /// <returns>Ceiling of the base-2 logarithm of x, as an I32eger.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 ceillog2(U32 x)
        {
            return 32 - lzcnt(x - 1);
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">U32x2 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 ceillog2(U32x2 x)
        {
            return new I32x2(ceillog2(x.x), ceillog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">U32x3 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 ceillog2(U32x3 x)
        {
            return new I32x3(ceillog2(x.x), ceillog2(x.y), ceillog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x">U32x4 to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 ceillog2(U32x4 x)
        {
            return new I32x4(ceillog2(x.x), ceillog2(x.y), ceillog2(x.z), ceillog2(x.w));
        }

        /// <summary>
        /// Computes the floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>x must be greater than zero, otherwise the result is undefined.</remarks>
        /// <param name="x">Integer to be used as input.</param>
        /// <returns>Floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 floorlog2(I32 x)
        {
            return 31 - lzcnt((U32)x);
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">I32x2 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 floorlog2(I32x2 x)
        {
            return new I32x2(floorlog2(x.x), floorlog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">I32x3 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 floorlog2(I32x3 x)
        {
            return new I32x3(floorlog2(x.x), floorlog2(x.y), floorlog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">I32x4 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 floorlog2(I32x4 x)
        {
            return new I32x4(floorlog2(x.x), floorlog2(x.y), floorlog2(x.z), floorlog2(x.w));
        }

        /// <summary>
        /// Computes the floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>x must be greater than zero, otherwise the result is undefined.</remarks>
        /// <param name="x">Unsigned I32eger to be used as input.</param>
        /// <returns>Floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 floorlog2(U32 x)
        {
            return 31 - lzcnt(x);
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">U32x2 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x2 floorlog2(U32x2 x)
        {
            return new I32x2(floorlog2(x.x), floorlog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">U32x3 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x3 floorlog2(U32x3 x)
        {
            return new I32x3(floorlog2(x.x), floorlog2(x.y), floorlog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x">U32x4 to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32x4 floorlog2(U32x4 x)
        {
            return new I32x4(floorlog2(x.x), floorlog2(x.y), floorlog2(x.z), floorlog2(x.w));
        }

        /*
        /// <summary>Returns the result of converting a F32 value from degrees to radians.</summary>
        /// <param name="x">Angle in degrees.</param>
        /// <returns>Angle converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 ToRadians(this float x) { return x * 0.0174532925f; }
        */

        /// <summary>Returns the result of converting a F32 value from degrees to radians.</summary>
        /// <param name="x">Angle in degrees.</param>
        /// <returns>Angle converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 ToRadians(this F32 x) { return x * 0.0174532925f; }

        /// <summary>Returns the result of a componentwise conversion of a F32x2 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 ToRadians(this F32x2 x) { return x * 0.0174532925f; }

        /// <summary>Returns the result of a componentwise conversion of a F32x3 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 ToRadians(this F32x3 x) { return x * 0.0174532925f; }

        /// <summary>Returns the result of a componentwise conversion of a F32x4 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 ToRadians(this F32x4 x) { return x * 0.0174532925f; }


        /// <summary>Returns the result of converting a F32 value from degrees to radians.</summary>
        /// <param name="x">Angle in degrees.</param>
        /// <returns>Angle converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 ToRadians(this F64 x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a F32x2 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 ToRadians(this F64x2 x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a F32x3 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 ToRadians(this F64x3 x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a F32x4 vector from degrees to radians.</summary>
        /// <param name="x">Vector containing angles in degrees.</param>
        /// <returns>Vector containing angles converted to radians.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 ToRadians(this F64x4 x) { return x * 0.017453292519943296; }


        /// <summary>Returns the result of converting a F64 value from radians to degrees.</summary>
        /// <param name="x">Angle in radians.</param>
        /// <returns>Angle converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 ToDegrees(this F32 x) { return x * 57.295779513f; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x2 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing angles converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 ToDegrees(this F32x2 x) { return x * 57.295779513f; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x3 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing angles converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 ToDegrees(this F32x3 x) { return x * 57.295779513f; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x4 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing angles converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 ToDegrees(this F32x4 x) { return x * 57.295779513f; }


        /// <summary>Returns the result of converting a F64 value from radians to degrees.</summary>
        /// <param name="x">Angle in radians.</param>
        /// <returns>Angle converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 ToDegrees(this F64 x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x2 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing angles converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x2 ToDegrees(this F64x2 x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x3 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing values converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x3 ToDegrees(this F64x3 x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a  F64x4 vector from radians to degrees.</summary>
        /// <param name="x">Vector containing angles in radians.</param>
        /// <returns>Vector containing angles converted to degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64x4 ToDegrees(this F64x4 x) { return x * 57.29577951308232; }


        /// <summary>Returns the minimum component of an I32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmin(I32x2 x) { return min(x.x, x.y); }

        /// <summary>Returns the minimum component of an I32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmin(I32x3 x) { return min(min(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of an I32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmin(I32x4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


        /// <summary>Returns the minimum component of a U32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmin(U32x2 x) { return min(x.x, x.y); }

        /// <summary>Returns the minimum component of a U32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmin(U32x3 x) { return min(min(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of a U32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmin(U32x4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


        /// <summary>Returns the minimum component of a F32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmin(F32x2 x) { return min(x.x, x.y); }

        /// <summary>Returns the minimum component of a F32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmin(F32x3 x) { return min(min(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of a F32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmin(F32x4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


        /// <summary>Returns the minimum component of a  F64x2 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmin(F64x2 x) { return min(x.x, x.y); }

        /// <summary>Returns the minimum component of a  F64x3 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmin(F64x3 x) { return min(min(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of a  F64x4 vector.</summary>
        /// <param name="x">The vector to use when computing the minimum component.</param>
        /// <returns>The value of the minimum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmin(F64x4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


        /// <summary>Returns the maximum component of an I32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmax(I32x2 x) { return max(x.x, x.y); }

        /// <summary>Returns the maximum component of an I32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmax(I32x3 x) { return max(max(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of an I32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 cmax(I32x4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


        /// <summary>Returns the maximum component of a U32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmax(U32x2 x) { return max(x.x, x.y); }

        /// <summary>Returns the maximum component of a U32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmax(U32x3 x) { return max(max(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a U32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 cmax(U32x4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


        /// <summary>Returns the maximum component of a F32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmax(F32x2 x) { return max(x.x, x.y); }

        /// <summary>Returns the maximum component of a F32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmax(F32x3 x) { return max(max(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a F32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 cmax(F32x4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


        /// <summary>Returns the maximum component of a  F64x2 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmax(F64x2 x) { return max(x.x, x.y); }

        /// <summary>Returns the maximum component of a  F64x3 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmax(F64x3 x) { return max(max(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a  F64x4 vector.</summary>
        /// <param name="x">The vector to use when computing the maximum component.</param>
        /// <returns>The value of the maximum component of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 cmax(F64x4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


        /// <summary>Returns the horizontal sum of components of an I32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 csum(I32x2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of an I32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 csum(I32x3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of an I32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I32 csum(I32x4 x) { return x.x + x.y + x.z + x.w; }


        /// <summary>Returns the horizontal sum of components of a U32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 csum(U32x2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of a U32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 csum(U32x3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of a U32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 csum(U32x4 x) { return x.x + x.y + x.z + x.w; }


        /// <summary>Returns the horizontal sum of components of a F32x2 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 csum(F32x2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of a F32x3 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 csum(F32x3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of a F32x4 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 csum(F32x4 x) { return (x.x + x.y) + (x.z + x.w); }


        /// <summary>Returns the horizontal sum of components of a  F64x2 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 csum(F64x2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of a  F64x3 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 csum(F64x3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of a  F64x4 vector.</summary>
        /// <param name="x">The vector to use when computing the horizontal sum.</param>
        /// <returns>The horizontal sum of of components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F64 csum(F64x4 x) { return (x.x + x.y) + (x.z + x.w); }

        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform I32ersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that I32ersected.
        /// </remarks>
        /// <param name="output">PoI32er to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index I32o output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe I32 compress(I32* output, I32 index, I32x4 val, Boolx4 mask)
        {
            if (mask.x)
                output[index++] = val.x;
            if (mask.y)
                output[index++] = val.y;
            if (mask.z)
                output[index++] = val.z;
            if (mask.w)
                output[index++] = val.w;

            return index;
        }

        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform I32ersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that I32ersected.
        /// </remarks>
        /// <param name="output">PoI32er to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index I32o output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe I32 compress(U32* output, I32 index, U32x4 val, Boolx4 mask)
        {
            return compress((I32*)output, index, *(I32x4*)&val, mask);
        }

        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform I32ersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that I32ersected.
        /// </remarks>
        /// <param name="output">PoI32er to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index I32o output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe I32 compress(F32* output, I32 index, F32x4 val, Boolx4 mask)
        {
            return compress((I32*)output, index, *(I32x4*)&val, mask);
        }

        /// <summary>Returns the F32ing poI32 representation of a F16-precision F32ing poI32 value.</summary>
        /// <param name="x">The F16 precision F32.</param>
        /// <returns>The single precision F32 representation of the F16 precision F32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 f16tof32(U32 x)
        {
            const U32 shifted_exp = (0x7c00 << 13);
            U32 uf = (x & 0x7fff) << 13;
            U32 e = uf & shifted_exp;
            uf += (127 - 15) << 23;
            uf += select(0, (128u - 16u) << 23, e == shifted_exp);
            uf = select(uf, AsU32(AsF32(uf + (1 << 23)) - 6.10351563e-05f), e == 0);
            uf |= (x & 0x8000) << 16;
            return AsF32(uf);
        }

        /// <summary>Returns the F32ing poI32 representation of a F16-precision F32ing poI32 vector.</summary>
        /// <param name="x">The F16 precision F32 vector.</param>
        /// <returns>The single precision F32 vector representation of the F16 precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2 f16tof32(U32x2 x)
        {
            const U32 shifted_exp = (0x7c00 << 13);
            U32x2 uf = (x & 0x7fff) << 13;
            U32x2 e = uf & shifted_exp;
            uf += (127 - 15) << 23;
            uf += select(0, (128u - 16u) << 23, e == shifted_exp);
            uf = select(uf, AsU32(AsF32(uf + (1 << 23)) - 6.10351563e-05f), e == 0);
            uf |= (x & 0x8000) << 16;
            return AsF32(uf);
        }

        /// <summary>Returns the F32ing poI32 representation of a F16-precision F32ing poI32 vector.</summary>
        /// <param name="x">The F16 precision F32 vector.</param>
        /// <returns>The single precision F32 vector representation of the F16 precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 f16tof32(U32x3 x)
        {
            const U32 shifted_exp = (0x7c00 << 13);
            U32x3 uf = (x & 0x7fff) << 13;
            U32x3 e = uf & shifted_exp;
            uf += (127 - 15) << 23;
            uf += select(0, (128u - 16u) << 23, e == shifted_exp);
            uf = select(uf, AsU32(AsF32(uf + (1 << 23)) - 6.10351563e-05f), e == 0);
            uf |= (x & 0x8000) << 16;
            return AsF32(uf);
        }

        /// <summary>Returns the F32ing poI32 representation of a F16-precision F32ing poI32 vector.</summary>
        /// <param name="x">The F16 precision F32 vector.</param>
        /// <returns>The single precision F32 vector representation of the F16 precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 f16tof32(U32x4 x)
        {
            const U32 shifted_exp = (0x7c00 << 13);
            U32x4 uf = (x & 0x7fff) << 13;
            U32x4 e = uf & shifted_exp;
            uf += (127 - 15) << 23;
            uf += select(0, (128u - 16u) << 23, e == shifted_exp);
            uf = select(uf, AsU32(AsF32(uf + (1 << 23)) - 6.10351563e-05f), e == 0);
            uf |= (x & 0x8000) << 16;
            return AsF32(uf);
        }

        /// <summary>Returns the result converting a F32 value to its nearest F16-precision F32ing poI32 representation.</summary>
        /// <param name="x">The single precision F32.</param>
        /// <returns>The F16 precision F32 representation of the single precision F32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 f32tof16(F32 x)
        {
            const I32 infinity_32 = 255 << 23;
            const U32 msk = 0x7FFFF000u;

            U32 ux = AsU32(x);
            U32 uux = ux & msk;
            U32 h = (U32)(AsU32(min(AsF32(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;   // Clamp to signed infinity if overflowed
            h = select(h, select(0x7c00u, 0x7e00u, (I32)uux > infinity_32), (I32)uux >= infinity_32);   // NaN->qNaN and Inf->Inf
            return h | (ux & ~msk) >> 16;
        }

        /// <summary>Returns the result of a componentwise conversion of a F32x2 vector to its nearest F16-precision F32ing poI32 representation.</summary>
        /// <param name="x">The single precision F32 vector.</param>
        /// <returns>The F16 precision F32 vector representation of the single precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x2 f32tof16(F32x2 x)
        {
            const I32 infinity_32 = 255 << 23;
            const U32 msk = 0x7FFFF000u;

            U32x2 ux = AsU32(x);
            U32x2 uux = ux & msk;
            U32x2 h = (U32x2)(AsI32(min(AsF32(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;   // Clamp to signed infinity if overflowed
            h = select(h, select(0x7c00u, 0x7e00u, (I32x2)uux > infinity_32), (I32x2)uux >= infinity_32);   // NaN->qNaN and Inf->Inf
            return h | (ux & ~msk) >> 16;
        }

        /// <summary>Returns the result of a componentwise conversion of a F32x3 vector to its nearest F16-precision F32ing poI32 representation.</summary>
        /// <param name="x">The single precision F32 vector.</param>
        /// <returns>The F16 precision F32 vector representation of the single precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x3 f32tof16(F32x3 x)
        {
            const I32 infinity_32 = 255 << 23;
            const U32 msk = 0x7FFFF000u;

            U32x3 ux = AsU32(x);
            U32x3 uux = ux & msk;
            U32x3 h = (U32x3)(AsI32(min(AsF32(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;   // Clamp to signed infinity if overflowed
            h = select(h, select(0x7c00u, 0x7e00u, (I32x3)uux > infinity_32), (I32x3)uux >= infinity_32);   // NaN->qNaN and Inf->Inf
            return h | (ux & ~msk) >> 16;
        }

        /// <summary>Returns the result of a componentwise conversion of a F32x4 vector to its nearest F16-precision F32ing poI32 representation.</summary>
        /// <param name="x">The single precision F32 vector.</param>
        /// <returns>The F16 precision F32 vector representation of the single precision F32 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 f32tof16(F32x4 x)
        {
            const I32 infinity_32 = 255 << 23;
            const U32 msk = 0x7FFFF000u;

            U32x4 ux = AsU32(x);
            U32x4 uux = ux & msk;
            U32x4 h = (U32x4)(AsI32(min(AsF32(uux) * 1.92592994e-34f, 260042752.0f)) + 0x1000) >> 13;   // Clamp to signed infinity if overflowed
            h = select(h, select(0x7c00u, 0x7e00u, (I32x4)uux > infinity_32), (I32x4)uux >= infinity_32);   // NaN->qNaN and Inf->Inf
            return h | (ux & ~msk) >> 16;
        }


        /// <summary>Returns a U32 hash from a block of memory using the xxhash32 algorithm. Can only be used in an unsafe context.</summary>
        /// <param name="pBuffer">A poI32er to the beginning of the data.</param>
        /// <param name="numBytes">Number of bytes to hash.</param>
        /// <param name="seed">Starting seed value.</param>
        /// <returns>The 32 bit hash of the input data buffer.</returns>
        public static unsafe U32 hash(void* pBuffer, I32 numBytes, U32 seed = 0)
        {
            unchecked
            {
                const U32 Prime1 = 2654435761;
                const U32 Prime2 = 2246822519;
                const U32 Prime3 = 3266489917;
                const U32 Prime4 = 668265263;
                const U32 Prime5 = 374761393;

                U32x4* p = (U32x4*)pBuffer;
                U32 hash = seed + Prime5;
                if (numBytes >= 16)
                {
                    U32x4 state = new U32x4(Prime1 + Prime2, Prime2, 0, (U32)(-Prime1)) + seed;

                    I32 count = numBytes >> 4;
                    for (I32 i = 0; i < count; ++i)
                    {
                        state += *p++ * Prime2;
                        state = (state << 13) | (state >> 19);
                        state *= Prime1;
                    }

                    hash = rol(state.x, 1) + rol(state.y, 7) + rol(state.z, 12) + rol(state.w, 18);
                }

                hash += (U32)numBytes;

                U32* pU32 = (U32*)p;
                for (I32 i = 0; i < ((numBytes >> 2) & 3); ++i)
                {
                    hash += *pU32++ * Prime3;
                    hash = rol(hash, 17) * Prime4;
                }

                byte* pbyte = (byte*)pU32;
                for (I32 i = 0; i < ((numBytes) & 3); ++i)
                {
                    hash += (*pbyte++) * Prime5;
                    hash = rol(hash, 11) * Prime1;
                }

                hash ^= hash >> 15;
                hash *= Prime2;
                hash ^= hash >> 13;
                hash *= Prime3;
                hash ^= hash >> 16;

                return hash;
            }
        }

        /// <summary>
        /// Unity's up axis (0, 1, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-up.html](https://docs.unity3d.com/ScriptReference/Vector3-up.html)</remarks>
        /// <returns>The up axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 up() { return new F32x3(0.0f, 1.0f, 0.0f); }  // for compatibility

        /// <summary>
        /// Unity's down axis (0, -1, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-down.html](https://docs.unity3d.com/ScriptReference/Vector3-down.html)</remarks>
        /// <returns>The down axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 down() { return new F32x3(0.0f, -1.0f, 0.0f); }

        /// <summary>
        /// Unity's forward axis (0, 0, 1).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-forward.html](https://docs.unity3d.com/ScriptReference/Vector3-forward.html)</remarks>
        /// <returns>The forward axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 forward() { return new F32x3(0.0f, 0.0f, 1.0f); }

        /// <summary>
        /// Unity's back axis (0, 0, -1).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-back.html](https://docs.unity3d.com/ScriptReference/Vector3-back.html)</remarks>
        /// <returns>The back axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 back() { return new F32x3(0.0f, 0.0f, -1.0f); }

        /// <summary>
        /// Unity's left axis (-1, 0, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-left.html](https://docs.unity3d.com/ScriptReference/Vector3-left.html)</remarks>
        /// <returns>The left axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 left() { return new F32x3(-1.0f, 0.0f, 0.0f); }

        /// <summary>
        /// Unity's right axis (1, 0, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-right.html](https://docs.unity3d.com/ScriptReference/Vector3-right.html)</remarks>
        /// <returns>The right axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 right() { return new F32x3(1.0f, 0.0f, 0.0f); }


        // Internal

        // SSE shuffles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F32x4 unpacklo(F32x4 a, F32x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F64x4 unpacklo(F64x4 a, F64x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F32x4 unpackhi(F32x4 a, F32x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F64x4 unpackhi(F64x4 a, F64x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F32x4 movelh(F32x4 a, F32x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F64x4 movelh(F64x4 a, F64x4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.RightY);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F32x4 movehl(F32x4 a, F32x4 b)
        {
            return shuffle(b, a, ShuffleComponent.LeftZ, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static F64x4 movehl(F64x4 a, F64x4 b)
        {
            return shuffle(b, a, ShuffleComponent.LeftZ, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static U32 FoldToU32(F64 x)  // utility for F64 hashing
        {
            I64_F64_Union u;
            u.I64Value = 0;
            u.F64Value = x;
            return (U32)(u.I64Value >> 32) ^ (U32)u.I64Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static U32x2 FoldToU32(F64x2 x) { return new U32x2(FoldToU32(x.x), FoldToU32(x.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static U32x3 FoldToU32(F64x3 x) { return new U32x3(FoldToU32(x.x), FoldToU32(x.y), FoldToU32(x.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static U32x4 FoldToU32(F64x4 x) { return new U32x4(FoldToU32(x.x), FoldToU32(x.y), FoldToU32(x.z), FoldToU32(x.w)); }

        [StructLayout(LayoutKind.Explicit)]
        internal struct I32_F32_Union
        {
            [FieldOffset(0)]
            public I32 I32Value;
            [FieldOffset(0)]
            public F32 F32Value;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct I64_F64_Union
        {
            [FieldOffset(0)]
            public I64 I64Value;
            [FieldOffset(0)]
            public F64 F64Value;
        }
    }
}
