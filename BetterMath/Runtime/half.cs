using System;
using System.Runtime.CompilerServices;

using F32 = System.Single;
using F64 = System.Double;

namespace CGTK.Utilities.BetterMath
{
    [Serializable]
    public struct F16 : IEquatable<F16>, IFormattable
    {
        #region Fields

        public UInt16 value;

        /// <summary>half zero value.</summary>
        public static readonly F16 zero = new F16();

        public static Single MaxValue =>  65504.0f;
        public static Single MinValue => -65504.0f;

        public static F16 MaxValueAsHalf => new F16(MaxValue);
        public static F16 MinValueAsHalf => new F16(MinValue);

        #endregion

        #region Structors

        /// <summary>Constructs a <see cref="F16"/> value from another <see cref="F16"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F16(F16 other)
        {
            value = other.value;
        }

        /// <summary>Constructs a <see cref="F16"/> value from a <see cref="F32"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F16(F32 v)
        {
            value = (UInt16)Maths.f32tof16(v);
        }

        /// <summary>Constructs a <see cref="F16"/> value from a <see cref="F64"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public F16(F64 v)
        {
            value = (UInt16)Maths.f32tof16((Single)v);
        }

        #endregion

        #region Operators

        #region Casting

        /// <summary>Explicitly converts a float value to a half value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator F16 (Single v) => new F16(v);

        /// <summary>Explicitly converts a <see cref="F64"/> value to a <see cref="F16"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator F16 (F64 v) => new F16(v);

        /// <summary>Implicitly converts a <see cref="F16"/> value to a <see cref="F32"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator F32 (F16 d) => Maths.f16tof32(d.value);

        /// <summary>Implicitly converts a <see cref="F16"/> value to a <see cref="F64"/> value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator F64 (F16 d) => Maths.f16tof32(d.value);


        /// <summary>Returns whether two <see cref="F16"/> values are equal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator == (F16 lhs, F16 rhs) => (lhs.value == rhs.value);

        /// <summary>Returns whether two <see cref="F16"/> values are different.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator != (F16 lhs, F16 rhs) => (lhs.value != rhs.value);

        #endregion

        #endregion

        #region Methods

        /// <summary>Returns true if the <see cref="F16"/> is equal to a given <see cref="F16"/>, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean Equals(F16 rhs) => (this.value == rhs.value);

        /// <summary>Returns true if the <see cref="F16"/> is equal to a given <see cref="F16"/>, false otherwise.</summary>
        public override Boolean Equals(Object o) => Equals((F16)o);

        /// <summary>Returns a hash code for the <see cref="F16"/>.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Int32 GetHashCode() => value;

        /// <summary>Returns a string representation of the <see cref="F16"/>.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override String ToString() => Maths.f16tof32(value).ToString();

        /// <summary>Returns a string representation of the <see cref="F16"/> using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ToString(String format, IFormatProvider formatProvider)
        {
            return Maths.f16tof32(value).ToString(format, formatProvider);
        }

        #endregion
    }

    public static partial class Maths
    {
        ///// <summary>Returns a half value constructed from a half values.</summary>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static F16 half(F16 x) { return new F16(x); }

        /// <summary>Returns a half value constructed from a float value.</summary>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static F16 half(float v) { return new F16(v); }

        /// <summary>Returns a half value constructed from a double value.</summary>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static F16 half(double v) { return new F16(v); }

        /// <summary>Returns a uint hash code of a half value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Hash(F16 v)
        {
            return v.value * 0x745ED837u + 0x816EFB5Du;
        }
    }
}
