using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

using static CGTK.Utilities.BetterMath.Maths;

using Bool = System.Boolean;

using F32 = System.Single;
using F64 = System.Double;

using I16 = System.Int16;
using I32 = System.Int32;
using I64 = System.Int64;

using U16 = System.UInt16;
using U32 = System.UInt32;
using U64 = System.UInt64;

namespace CGTK.Utilities.BetterMath
{
    /// <summary>
    /// A Quaternion type for representing rotations.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    [Serializable]
    public partial struct Quaternion : IEquatable<Quaternion>, IFormattable
    {
        /// <summary>
        /// The Quaternion component values.
        /// </summary>
        public F32x4 value;

        /// <summary>A Quaternion representing the identity transform.</summary>
        public static readonly Quaternion identity = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);

        /// <summary>Constructs a Quaternion from four F32 values.</summary>
        /// <param name="x">The Quaternion x component.</param>
        /// <param name="y">The Quaternion y component.</param>
        /// <param name="z">The Quaternion z component.</param>
        /// <param name="w">The Quaternion w component.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion(F32 x, F32 y, F32 z, F32 w) { value.x = x; value.y = y; value.z = z; value.w = w; }

        /// <summary>Constructs a Quaternion from F32x4 vector.</summary>
        /// <param name="value">The Quaternion xyzw component values.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion(F32x4 value) { this.value = value; }

        /// <summary>Implicitly converts a F32x4 vector to a Quaternion.</summary>
        /// <param name="v">The Quaternion xyzw component values.</param>
        /// <returns>The Quaternion constructed from a F32x4 vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Quaternion(F32x4 v) { return new Quaternion(v); }

        /// <summary>Constructs a unit Quaternion from a F32x3x3 rotation matrix. The matrix must be orthonormal.</summary>
        /// <param name="m">The F32x3x3 orthonormal rotation matrix.</param>
        public Quaternion(F32x3x3 m)
        {
            F32x3 u = m.c0;
            F32x3 v = m.c1;
            F32x3 w = m.c2;

            U32 u_sign = (AsU32(u.x) & 0x80000000);
            F32 t = v.y + AsF32(AsU32(w.z) ^ u_sign);
            U32x4 u_mask = new U32x4((I32)u_sign >> 31);
            U32x4 t_mask = new U32x4(AsI32(t) >> 31);

            F32 tr = 1.0f + abs(u.x);

            U32x4 sign_flips = new U32x4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (u_mask & new U32x4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (t_mask & new U32x4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            value = new F32x4(tr, u.y, w.x, v.z) + AsF32(AsU32(new F32x4(t, v.x, u.z, w.y)) ^ sign_flips);   // +---, +++-, ++-+, +-++

            value = AsF32((AsU32(value) & ~u_mask) | (AsU32(value.zwxy) & u_mask));
            value = AsF32((AsU32(value.wzyx) & ~t_mask) | (AsU32(value) & t_mask));
            value = value.Normalize();
        }

        /// <summary>Constructs a unit Quaternion from an orthonormal F32x4x4 matrix.</summary>
        /// <param name="m">The F32x4x4 orthonormal rotation matrix.</param>
        public Quaternion(F32x4x4 m)
        {
            F32x4 u = m.c0;
            F32x4 v = m.c1;
            F32x4 w = m.c2;

            U32 u_sign = (AsU32(u.x) & 0x80000000);
            F32 t = v.y + AsF32(AsU32(w.z) ^ u_sign);
            U32x4 u_mask = new U32x4((I32)u_sign >> 31);
            U32x4 t_mask = new U32x4(AsI32(t) >> 31);

            F32 tr = 1.0f + abs(u.x);

            U32x4 sign_flips = new U32x4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (u_mask & new U32x4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (t_mask & new U32x4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            value = new F32x4(tr, u.y, w.x, v.z) + AsF32(AsU32(new F32x4(t, v.x, u.z, w.y)) ^ sign_flips);   // +---, +++-, ++-+, +-++

            value = AsF32((AsU32(value) & ~u_mask) | (AsU32(value.zwxy) & u_mask));
            value = AsF32((AsU32(value.wzyx) & ~t_mask) | (AsU32(value) & t_mask));

            value = value.Normalize();
        }

        /// <summary>
        /// Returns a Quaternion representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="axis">The axis of rotation.</param>
        /// <param name="angle">The angle of rotation in radians.</param>
        /// <returns>The Quaternion representing a rotation around an axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion AxisAngle(F32x3 axis, F32 angle)
        {
            sincos(0.5f * angle, out Single sina, out Single cosa);
            return new Quaternion(new F32x4(axis * sina, cosa));
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXYZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(-1.0f, 1.0f, -1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXZY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(1.0f, 1.0f, -1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYXZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(-1.0f, 1.0f, 1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYZX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(-1.0f, -1.0f, 1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZXY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(1.0f, -1.0f, -1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZYX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            sincos(0.5f * xyz, out F32x3 s, out F32x3 c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.x * s.z
                new F32x4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new F32x4(c.xyz, s.x) * new F32x4(1.0f, -1.0f, 1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXYZ(F32 x, F32 y, F32 z) { return EulerXYZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXZY(F32 x, F32 y, F32 z) { return EulerXZY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYXZ(F32 x, F32 y, F32 z) { return EulerYXZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYZX(F32 x, F32 y, F32 z) { return EulerYZX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZXY(F32 x, F32 y, F32 z) { return EulerZXY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZYX(F32 x, F32 y, F32 z) { return EulerZYX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a Quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in the specified order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(F32x3 xyz, RotationOrder order = RotationOrder.ZXY)
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
        /// Returns a Quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The Quaternion representing the Euler angle rotation in the specified order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(F32 x = 0, F32 y = 0, F32 z = 0, RotationOrder order = RotationOrder.Default)
        {
            return Euler(xyz: new F32x3(x, y, z), order);
        }

        /// <summary>Returns a Quaternion that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        /// <returns>The Quaternion representing a rotation around the x-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateX(F32 angle)
        {
            sincos(0.5f * angle, out Single sina, out Single cosa);
            return new Quaternion(sina, 0.0f, 0.0f, cosa);
        }

        /// <summary>Returns a Quaternion that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        /// <returns>The Quaternion representing a rotation around the y-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateY(F32 angle)
        {
            sincos(0.5f * angle, out Single sina, out Single cosa);
            return new Quaternion(0.0f, sina, 0.0f, cosa);
        }

        /// <summary>Returns a Quaternion that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        /// <returns>The Quaternion representing a rotation around the z-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateZ(F32 angle)
        {
            sincos(0.5f * angle, out Single sina, out Single cosa);
            return new Quaternion(0.0f, 0.0f, sina, cosa);
        }

        /// <summary>
        /// Returns a Quaternion view rotation given a unit length forward vector and a unit length up vector.
        /// The two input vectors are assumed to be unit length and not collinear.
        /// If these assumptions are not met use F32x3x3.LookRotationSafe instead.
        /// </summary>
        /// <param name="forward">The view forward direction.</param>
        /// <param name="up">The view up direction.</param>
        /// <returns>The Quaternion view rotation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion LookRotation(F32x3 forward, F32x3 up)
        {
            F32x3 t = cross(up, forward).Normalize();
            return new Quaternion(new F32x3x3(t, cross(forward, t), forward));
        }

        /// <summary>
        /// Returns a Quaternion view rotation given a forward vector and an up vector.
        /// The two input vectors are not assumed to be unit length.
        /// If the magnitude of either of the vectors is so extreme that the calculation cannot be carried out reliably or the vectors are collinear,
        /// the identity will be returned instead.
        /// </summary>
        /// <param name="forward">The view forward direction.</param>
        /// <param name="up">The view up direction.</param>
        /// <returns>The Quaternion view rotation or the identity Quaternion.</returns>
        public static Quaternion LookRotationSafe(F32x3 forward, F32x3 up)
        {
            F32 forwardLengthSq = dot(forward, forward);
            F32 upLengthSq = dot(up, up);

            forward *= rsqrt(forwardLengthSq);
            up *= rsqrt(upLengthSq);

            F32x3 t = cross(up, forward);
            F32 tLengthSq = dot(t, t);
            t *= rsqrt(tLengthSq);

            F32 mn = min(min(forwardLengthSq, upLengthSq), tLengthSq);
            F32 mx = max(max(forwardLengthSq, upLengthSq), tLengthSq);

            Bool accept = mn > 1e-35f && mx < 1e35f && isfinite(forwardLengthSq) && isfinite(upLengthSq) && isfinite(tLengthSq);
            return new Quaternion(select(new F32x4(0.0f, 0.0f, 0.0f, 1.0f), new Quaternion(new F32x3x3(t, cross(forward, t),forward)).value, accept));
        }

        /// <summary>Returns true if the Quaternion is equal to a given Quaternion, false otherwise.</summary>
        /// <param name="x">The Quaternion to compare with.</param>
        /// <returns>True if the Quaternion is equal to the input, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool Equals(Quaternion x) { return value.x == x.value.x && value.y == x.value.y && value.z == x.value.z && value.w == x.value.w; }

        /// <summary>Returns whether true if the Quaternion is equal to a given Quaternion, false otherwise.</summary>
        /// <param name="x">The object to compare with.</param>
        /// <returns>True if the Quaternion is equal to the input, false otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Bool Equals(object x) { return x is Quaternion converted && Equals(converted); }

        /// <summary>Returns a hash code for the Quaternion.</summary>
        /// <returns>The hash code of the Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override I32 GetHashCode() { return (I32)hash(this); }

        /// <summary>Returns a string representation of the Quaternion.</summary>
        /// <returns>The string representation of the Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override String ToString()
        {
            return $"Quaternion({value.x}f, {value.y}f, {value.z}f, {value.w}f)";
        }

        /// <summary>Returns a string representation of the Quaternion using a specified format and culture-specific format information.</summary>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use during string formatting.</param>
        /// <returns>The formatted string representation of the Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ToString(string format, IFormatProvider formatProvider)
        {
            return $"Quaternion({value.x.ToString(format, formatProvider)}f, {value.y.ToString(format, formatProvider)}f, {value.z.ToString(format, formatProvider)}f, {value.w.ToString(format, formatProvider)}f)";
        }
    }

    public static partial class Maths
    {

        /*
        /// <summary>Returns a Quaternion constructed from four F32 values.</summary>
        /// <param name="x">The x component of the Quaternion.</param>
        /// <param name="y">The y component of the Quaternion.</param>
        /// <param name="z">The z component of the Quaternion.</param>
        /// <param name="w">The w component of the Quaternion.</param>
        /// <returns>The Quaternion constructed from individual components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(F32 x, F32 y, F32 z, F32 w) { return new Quaternion(x, y, z, w); }

        /// <summary>Returns a Quaternion constructed from a F32x4 vector.</summary>
        /// <param name="value">The F32x4 containing the components of the Quaternion.</param>
        /// <returns>The Quaternion constructed from a F32x4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(F32x4 value) { return new Quaternion(value); }

        /// <summary>Returns a unit Quaternion constructed from a F32x3x3 rotation matrix. The matrix must be orthonormal.</summary>
        /// <param name="m">The F32x3x3 rotation matrix.</param>
        /// <returns>The Quaternion constructed from a F32x3x3 matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(F32x3x3 m) { return new Quaternion(m); }

        /// <summary>Returns a unit Quaternion constructed from a F32x4x4 matrix. The matrix must be orthonormal.</summary>
        /// <param name="m">The F32x4x4 matrix (must be orthonormal).</param>
        /// <returns>The Quaternion constructed from a F32x4x4 matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(F32x4x4 m) { return new Quaternion(m); }
        */

        /// <summary>Returns the conjugate of a Quaternion value.</summary>
       /// <param name="q">The Quaternion to conjugate.</param>
       /// <returns>The conjugate of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion conjugate(Quaternion q)
        {
            return new Quaternion(q.value * new F32x4(-1.0f, -1.0f, -1.0f, 1.0f));
        }

       /// <summary>Returns the inverse of a Quaternion value.</summary>
       /// <param name="q">The Quaternion to invert.</param>
       /// <returns>The Quaternion inverse of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion inverse(Quaternion q)
        {
            F32x4 x = q.value;
            return new Quaternion(rcp(dot(x, x)) * x * new F32x4(-1.0f, -1.0f, -1.0f, 1.0f));
        }

        /// <summary>Returns the dot product of two new Quaternions.</summary>
        /// <param name="a">The first Quaternion.</param>
        /// <param name="b">The second Quaternion.</param>
        /// <returns>The dot product of two new Quaternions.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 dot(Quaternion a, Quaternion b)
        {
            return dot(a.value, b.value);
        }

        /// <summary>Returns the length of a Quaternion.</summary>
        /// <param name="q">The input Quaternion.</param>
        /// <returns>The length of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 Length(Quaternion q)
        {
            return sqrt(dot(q.value, q.value));
        }

        /// <summary>Returns the squared length of a Quaternion.</summary>
        /// <param name="q">The input Quaternion.</param>
        /// <returns>The length squared of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32 LengthSqr(Quaternion q)
        {
            return dot(q.value, q.value);
        }

        /// <summary>Returns a normalized version of a Quaternion q by scaling it by 1 / length(q).</summary>
        /// <param name="q">The Quaternion to normalize.</param>
        /// <returns>The normalized Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion normalize(Quaternion q)
        {
            F32x4 x = q.value;
            return new Quaternion(rsqrt(dot(x, x)) * x);
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the identity when 1 / length(q) does not produce a finite number.
        /// </summary>
        /// <param name="q">The Quaternion to normalize.</param>
        /// <returns>The normalized Quaternion or the identity Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion normalizesafe(Quaternion q)
        {
            F32x4 x = q.value;
            F32 len = dot(x, x);
            return new Quaternion(select(Quaternion.identity.value, x * rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the given default value when 1 / length(q) does not produce a finite number.
        /// </summary>
        /// <param name="q">The Quaternion to normalize.</param>
        /// <param name="defaultvalue">The default value.</param>
        /// <returns>The normalized Quaternion or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion normalizesafe(Quaternion q, Quaternion defaultvalue)
        {
            F32x4 x = q.value;
            F32 len = dot(x, x);
            return new Quaternion(select(defaultvalue.value, x * rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>Returns the natural exponent of a Quaternion. Assumes w is zero.</summary>
        /// <param name="q">The Quaternion with w component equal to zero.</param>
        /// <returns>The natural exponent of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion unitexp(Quaternion q)
        {
            F32 v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            F32 v_len = rcp(v_rcp_len);
            sincos(v_len, out Single sin_v_len, out Single cos_v_len);

            return new Quaternion(new F32x4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len));
        }

        /// <summary>Returns the natural exponent of a Quaternion.</summary>
        /// <param name="q">The Quaternion.</param>
        /// <returns>The natural exponent of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion exp(Quaternion q)
        {
            F32 v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            F32 v_len = rcp(v_rcp_len);
            sincos(v_len, out Single sin_v_len, out Single cos_v_len);

            return new Quaternion(new F32x4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len) * exp(q.value.w));
        }

        /// <summary>Returns the natural logarithm of a unit length Quaternion.</summary>
        /// <param name="q">The unit length Quaternion.</param>
        /// <returns>The natural logarithm of the unit length Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion unitlog(Quaternion q)
        {
            F32 w = clamp(q.value.w, -1.0f, 1.0f);
            F32 s = acos(w) * rsqrt(1.0f - w*w);

            return new Quaternion(new F32x4(q.value.xyz * s, 0.0f));
        }

        /// <summary>Returns the natural logarithm of a Quaternion.</summary>
        /// <param name="q">The Quaternion.</param>
        /// <returns>The natural logarithm of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion log(Quaternion q)
        {
            F32 v_len_sq = dot(q.value.xyz, q.value.xyz);
            F32 q_len_sq = v_len_sq + q.value.w*q.value.w;

            F32 s = acos(clamp(q.value.w * rsqrt(q_len_sq), -1.0f, 1.0f)) * rsqrt(v_len_sq);

            return new Quaternion(new F32x4(q.value.xyz * s, 0.5f * log(q_len_sq)));
        }

        /// <summary>Returns the result of transforming the Quaternion b by the Quaternion a.</summary>
        /// <param name="a">The Quaternion on the left.</param>
        /// <param name="b">The Quaternion on the right.</param>
        /// <returns>The result of transforming Quaternion b by the Quaternion a.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion mul(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * new F32x4(1.0f, 1.0f, 1.0f, -1.0f) - a.value.zxyz * b.value.yzxz);
        }

        /// <summary>Returns the result of transforming a vector by a Quaternion.</summary>
        /// <param name="q">The Quaternion transformation.</param>
        /// <param name="v">The vector to transform.</param>
        /// <returns>The transformation of vector v by Quaternion q.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 mul(Quaternion q, F32x3 v)
        {
            F32x3 t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of rotating a vector by a unit Quaternion.</summary>
        /// <param name="q">The Quaternion rotation.</param>
        /// <param name="v">The vector to rotate.</param>
        /// <returns>The rotation of vector v by Quaternion q.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 rotate(Quaternion q, F32x3 v)
        {
            F32x3 t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of a normalized linear I32erpolation between two new Quaternions q1 and a2 using an I32erpolation parameter t.</summary>
        /// <remarks>
        /// Prefer to use this over slerp() when you know the distance between q1 and q2 is small. This can be much
        /// higher performance due to avoiding trigonometric function evaluations that occur in slerp().
        /// </remarks>
        /// <param name="q1">The first Quaternion.</param>
        /// <param name="q2">The second Quaternion.</param>
        /// <param name="t">The I32erpolation parameter.</param>
        /// <returns>The normalized linear I32erpolation of two new Quaternions.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion nlerp(Quaternion q1, Quaternion q2, F32 t)
        {
            F32 dt = dot(q1, q2);
            if(dt < 0.0f)
            {
                q2.value = -q2.value;
            }

            return normalize(new Quaternion(lerp(q1.value, q2.value, t)));
        }

        /// <summary>Returns the result of a spherical I32erpolation between two new Quaternions q1 and a2 using an I32erpolation parameter t.</summary>
        /// <param name="q1">The first Quaternion.</param>
        /// <param name="q2">The second Quaternion.</param>
        /// <param name="t">The I32erpolation parameter.</param>
        /// <returns>The spherical linear I32erpolation of two new Quaternions.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion slerp(Quaternion q1, Quaternion q2, F32 t)
        {
            F32 dt = dot(q1, q2);
            if (dt < 0.0f)
            {
                dt = -dt;
                q2.value = -q2.value;
            }

            if (dt < 0.9995f)
            {
                F32 angle = acos(dt);
                F32 s = rsqrt(1.0f - dt * dt);    // 1.0f / sin(angle)
                F32 w1 = sin(angle * (1.0f - t)) * s;
                F32 w2 = sin(angle * t) * s;
                return new Quaternion(q1.value * w1 + q2.value * w2);
            }
            else
            {
                // if the angle is small, use linear I32erpolation
                return nlerp(q1, q2, t);
            }
        }

        /// <summary>Returns a U32 hash code of a Quaternion.</summary>
        /// <param name="q">The Quaternion to hash.</param>
        /// <returns>The hash code for the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32 hash(Quaternion q)
        {
            return hash(q.value);
        }

        /// <summary>
        /// Returns a U32x4 vector hash code of a Quaternion.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow U32 hash at the very end instead of at every step.
        /// </summary>
        /// <param name="q">The Quaternion to hash.</param>
        /// <returns>The U32x4 vector hash code of the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U32x4 hashwide(Quaternion q)
        {
            return hashwide(q.value);
        }


        /// <summary>
        /// Transforms the forward vector by a Quaternion.
        /// </summary>
        /// <param name="q">The Quaternion transformation.</param>
        /// <returns>The forward vector transformed by the input Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3 forward(Quaternion q) { return mul(q, new F32x3(0, 0, 1)); }  // for compatibility
    }
}
