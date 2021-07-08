using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

using static CGTK.Utilities.BetterMath.Maths;

using F32 = System.Single;

using I32 = System.Int32;
using U32 = System.UInt32;

namespace CGTK.Utilities.BetterMath
{
    /// <summary>
    /// A rigid transformation type.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    [Serializable]
    public struct RigidTransform
    {
        /// <summary>
        /// The rotation part of the rigid transformation.
        /// </summary>
        public Quaternion rot;

        /// <summary>
        /// The translation part of the rigid transformation.
        /// </summary>
        public F32x3 pos;

        /// <summary>A RigidTransform representing the identity transform.</summary>
        public static readonly RigidTransform identity = new RigidTransform(rotation: new Quaternion(0.0f, 0.0f, 0.0f, 1.0f), translation: new F32x3(0.0f, 0.0f, 0.0f));

        /// <summary>Constructs a RigidTransform from a rotation represented by a unit Quaternion and a translation represented by a F32x3 vector.</summary>
        /// <param name="rotation">The Quaternion rotation.</param>
        /// <param name="translation">The translation vector.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(Quaternion rotation, F32x3 translation)
        {
            this.rot = rotation;
            this.pos = translation;
        }

        /// <summary>Constructs a RigidTransform from a rotation represented by a F32x3x3 matrix and a translation represented by a F32x3 vector.</summary>
        /// <param name="rotation">The F32x3x3 rotation matrix.</param>
        /// <param name="translation">The translation vector.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(F32x3x3 rotation, F32x3 translation)
        {
            this.rot = new Quaternion(rotation);
            this.pos = translation;
        }

        /// <summary>Constructs a RigidTransform from a F32x4x4. Assumes the matrix is orthonormal.</summary>
        /// <param name="transform">The F32x4x4 transformation matrix, must be orthonormal.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(F32x4x4 transform)
        {
            this.rot = new Quaternion(transform);
            this.pos = transform.c3.xyz;
        }

        /// <summary>Constructs a RigidTransform from another RigidTransform.</
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(RigidTransform other)
        {
            this.rot = other.rot;
            this.pos = other.pos;
        }

        /// <summary>
        /// Returns a RigidTransform representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="axis">The axis of rotation.</param>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The RigidTransform from a rotation axis and angle of rotation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform AxisAngle(F32x3 axis, F32 angle) { return new RigidTransform(rotation: Quaternion.AxisAngle(axis, angle), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXYZ(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerXYZ(xyz), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXZY(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerXZY(xyz), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYXZ(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerYXZ(xyz), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYZX(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerYZX(xyz), translation: F32x3.zero); }


        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZXY(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerZXY(xyz), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZYX(F32x3 xyz) { return new RigidTransform(rotation: Quaternion.EulerZYX(xyz), translation: F32x3.zero); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXYZ(F32 x, F32 y, F32 z) { return EulerXYZ(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXZY(F32 x, F32 y, F32 z) { return EulerXZY(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYXZ(F32 x, F32 y, F32 z) { return EulerYXZ(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYZX(F32 x, F32 y, F32 z) { return EulerYZX(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZXY(F32 x, F32 y, F32 z) { return EulerZXY(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZYX(F32 x, F32 y, F32 z) { return EulerZYX(xyz: new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        ///
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in the given rotation order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Euler(F32x3 xyz, RotationOrder order = RotationOrder.ZXY)
        {
            switch (order)
            {
                case RotationOrder.XYZ:
                    return EulerXYZ(xyz);
                case RotationOrder.XZY:
                    return EulerXZY(xyz);
                case RotationOrder.YXZ:
                    return EulerYXZ(xyz);
                case RotationOrder.YZX:
                    return EulerYZX(xyz);
                case RotationOrder.ZXY:
                    return EulerZXY(xyz);
                case RotationOrder.ZYX:
                    return EulerZYX(xyz);
                default:
                    return identity;
            }
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The RigidTransform of the Euler angle transformation in the given rotation order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Euler(F32 x, F32 y, F32 z, RotationOrder order = RotationOrder.Default)
        {
            return Euler(xyz: new F32x3(x, y, z), order);
        }

        /// <summary>Returns a RigidTransform that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        /// <returns>The RigidTransform of rotating around the x-axis by the given angle.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateX(F32 angle)
        {
            return new RigidTransform(rotation: Quaternion.RotateX(angle), translation: F32x3.zero);
        }

        /// <summary>Returns a RigidTransform that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        /// <returns>The RigidTransform of rotating around the y-axis by the given angle.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateY(F32 angle)
        {
            return new RigidTransform(rotation: Quaternion.RotateY(angle), translation: F32x3.zero);
        }

        /// <summary>Returns a RigidTransform that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        /// <returns>The RigidTransform of rotating around the z-axis by the given angle.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateZ(F32 angle)
        {
            return new RigidTransform(rotation: Quaternion.RotateZ(angle), translation: F32x3.zero);
        }

        /// <summary>Returns a RigidTransform that translates by an amount specified by a F32x3 vector.</summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The RigidTransform that translates by the given translation vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Translate(F32x3 vector)
        {
            return new RigidTransform(Quaternion.identity, vector);
        }


        /// <summary>Returns true if the RigidTransform is equal to a given RigidTransform, false otherwise.</summary>
        /// <param name="x">The RigidTransform to compare with.</param>
        /// <returns>True if the RigidTransform is equal to the input, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean Equals(RigidTransform x) { return rot.Equals(x.rot) && pos.Equals(x.pos); }

        /// <summary>Returns true if the RigidTransform is equal to a given RigidTransform, false otherwise.</summary>
        /// <param name="x">The object to compare with.</param>
        /// <returns>True if the RigidTransform is equal to the input, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Boolean Equals(Object x) { return x is RigidTransform converted && Equals(converted); }

        /// <summary>Returns a hash code for the RigidTransform.</summary>
        /// <returns>The hash code of the RigidTransform.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override I32 GetHashCode() { return (I32)Maths.hash(t: this); }

        /// <summary>Returns a string representation of the RigidTransform.</summary>
        /// <returns>The string representation of the RigidTransform.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override String ToString()
        {
            return string.Format(format: "RigidTransform(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                rot.value.x, rot.value.y, rot.value.z, rot.value.w, pos.x, pos.y, pos.z);
        }

        /// <summary>Returns a string representation of the RigidTransform using a specified format and culture-specific format information.</summary>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use during formatting.</param>
        /// <returns>The formatted string representation of the RigidTransform.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ToString(String format, IFormatProvider formatProvider)
        {
            return string.Format(format: "F32x4x4(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                rot.value.x.ToString(format, formatProvider),
                rot.value.y.ToString(format, formatProvider),
                rot.value.z.ToString(format, formatProvider),
                rot.value.w.ToString(format, formatProvider),
                pos.x.ToString(format, formatProvider),
                pos.y.ToString(format, formatProvider),
                pos.z.ToString(format, formatProvider));
        }
    }

    public static partial class Maths
    {
        /// <summary>Returns a RigidTransform constructed from a rotation represented by a unit Quaternion and a translation represented by a F32x3 vector.</summary>
        /// <param name="rot">The Quaternion rotation.</param>
        /// <param name="pos">The translation vector.</param>
        /// <returns>The RigidTransform of the given rotation Quaternion and translation vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(Quaternion rot, F32x3 pos) { return new RigidTransform(rot, pos); }

        /// <summary>Returns a RigidTransform constructed from a rotation represented by a F32x3x3 rotation matrix and a translation represented by a F32x3 vector.</summary>
        /// <param name="rotation">The F32x3x3 rotation matrix.</param>
        /// <param name="translation">The translation vector.</param>
        /// <returns>The RigidTransform of the given rotation matrix and translation vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(F32x3x3 rotation, F32x3 translation) { return new RigidTransform(rotation, translation); }

        /// <summary>Returns a RigidTransform constructed from a rotation represented by a F32x3x3 matrix and a translation represented by a F32x3 vector.</summary>
        /// <param name="transform">The F32x4x4 transformation matrix.</param>
        /// <returns>The RigidTransform of the given F32x4x4 transformation matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(F32x4x4 transform) { return new RigidTransform(transform); }

        /// <summary>Returns the inverse of a RigidTransform.</summary>
        /// <param name="t">The RigidTransform to invert.</param>
        /// <returns>The inverse RigidTransform.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform inverse(RigidTransform t)
        {
            Quaternion invRotation = inverse(t.rot);
            F32x3 invTranslation = mul(invRotation, -t.pos);
            return new RigidTransform(invRotation, invTranslation);
        }

        /// <summary>Returns the result of transforming the RigidTransform b by the RigidTransform a.</summary>
        /// <param name="a">The RigidTransform on the left.</param>
        /// <param name="b">The RigidTransform on the right.</param>
        /// <returns>The RigidTransform of a transforming b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform mul(RigidTransform a, RigidTransform b)
        {
            return new RigidTransform(rotation: mul(a.rot, b.rot), translation: mul(a.rot, b.pos) + a.pos);
        }

        /// <summary>Returns the result of transforming a F32x4 homogeneous coordinate by a RigidTransform.</summary>
        /// <param name="a">The RigidTransform.</param>
        /// <param name="pos">The position to be transformed.</param>
        /// <returns>The transformed position.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4 mul(RigidTransform a, F32x4 pos)
        {
            return new F32x4(xyz: mul(a.rot, pos.xyz) + a.pos * pos.w, w: pos.w);
        }

        /// <summary>Returns the result of rotating a F32x3 vector by a RigidTransform.</summary>
        /// <param name="a">The RigidTransform.</param>
        /// <param name="dir">The direction vector to rotate.</param>
        /// <returns>The rotated direction vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 rotate(RigidTransform a, F32x3 dir)
        {
            return mul(a.rot, dir);
        }

        /// <summary>Returns the result of transforming a F32x3 point by a RigidTransform.</summary>
        /// <param name="a">The RigidTransform.</param>
        /// <param name="pos">The position to transform.</param>
        /// <returns>The transformed position.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 transform(RigidTransform a, F32x3 pos)
        {
            return mul(a.rot, pos) + a.pos;
        }

        /// <summary>Returns a uint hash code of a RigidTransform.</summary>
        /// <param name="t">The RigidTransform to hash.</param>
        /// <returns>The hash code of the input RigidTransform</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 hash(RigidTransform t)
        {
            return hash(t.rot) + 0xC5C5394Bu * hash(t.pos);
        }

        /// <summary>
        /// Returns a U32x4 vector hash code of a RigidTransform.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="t">The RigidTransform to hash.</param>
        /// <returns>The U32x4 wide hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 hashwide(RigidTransform t)
        {
            return hashwide(t.rot) + 0xC5C5394Bu * hashwide(t.pos).xyzz;
        }
    }
}
