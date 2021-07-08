using System.Runtime.CompilerServices;
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
    public partial struct F32x2x2
    {
        /// <summary>
        /// Computes a F322xx2 matrix representing a counter-clockwise rotation by an angle in radians.
        /// </summary>
        /// <remarks>
        /// A positive rotation angle will produce a counter-clockwise rotation and a negative rotation angle will
        /// produce a clockwise rotation.
        /// </remarks>
        /// <param name="angle">Rotation angle in radians.</param>
        /// <returns>Returns the 2x2 rotation matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2x2 Rotate(F32 angle)
        {
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x2x2(c, -s,
                            s,  c);
        }

        /// <summary>Returns a F322x2 matrix representing a uniform scaling of both axes by s.</summary>
        /// <param name="s">The scaling factor.</param>
        /// <returns>The F322x2 matrix representing uniform scale by s.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2x2 Scale(F32 s)
        {
            return new F32x2x2(s,    0.0f,
                            0.0f, s);
        }

        /// <summary>Returns a F322x2 matrix representing a non-uniform axis scaling by x and y.</summary>
        /// <param name="x">The x-axis scaling factor.</param>
        /// <param name="y">The y-axis scaling factor.</param>
        /// <returns>The F322x2 matrix representing a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2x2 Scale(F32 x, F32 y)
        {
            return new F32x2x2(x,    0.0f,
                            0.0f, y);
        }

        /// <summary>Returns a F322x2 matrix representing a non-uniform axis scaling by the components of the F32x2 vector v.</summary>
        /// <param name="v">The F32x2 containing the x and y axis scaling factors.</param>
        /// <returns>The F322x2 matrix representing a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x2x2 Scale(F32x2 v)
        {
            return Scale(v.x, v.y);
        }
    }

    public partial struct F32x3x3
    {
        /// <summary>
        /// Constructs a F32x3x3 from the upper left 3x3 of a F32x4x4.
        /// </summary>
        /// <param name="f4X4"><see cref="F32x4x4"/> to extract a F32x3x3 from.</param>
        public F32x3x3(F32x4x4 f4X4)
        {
            c0 = f4X4.c0.xyz;
            c1 = f4X4.c1.xyz;
            c2 = f4X4.c2.xyz;
        }

        /// <summary>Constructs a F32x3x3 matrix from a unit Quaternion.</summary>
        /// <param name="q">The Quaternion rotation.</param>
        public F32x3x3(Quaternion q)
        {
            F32x4 v = q.value;
            F32x4 v2 = v + v;

            U32x3 npn = new U32x3(0x80000000, 0x00000000, 0x80000000);
            U32x3 nnp = new U32x3(0x80000000, 0x80000000, 0x00000000);
            U32x3 pnn = new U32x3(0x00000000, 0x80000000, 0x80000000);
            c0 = v2.y * AsF32(AsU32(v.yxw) ^ npn) - v2.z * AsF32(AsU32(v.zwx) ^ pnn) + new F32x3(1, 0, 0);
            c1 = v2.z * AsF32(AsU32(v.wzy) ^ nnp) - v2.x * AsF32(AsU32(v.yxw) ^ npn) + new F32x3(0, 1, 0);
            c2 = v2.x * AsF32(AsU32(v.zwx) ^ pnn) - v2.y * AsF32(AsU32(v.wzy) ^ nnp) + new F32x3(0, 0, 1);
        }

        /// <summary>
        /// Returns a F32x3x3 matrix representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="axis">The rotation axis.</param>
        /// <param name="angle">The angle of rotation in radians.</param>
        /// <returns>The F32x3x3 matrix representing the rotation around an axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 AxisAngle(F32x3 axis, F32 angle)
        {
            F32 sina, cosa;
            Maths.sincos(angle, out sina, out cosa);

            F32x3 u = axis;
            F32x3 u_yzx = u.yzx;
            F32x3 u_zxy = u.zxy;
            F32x3 u_inv_cosa = u - u * cosa;  // u * (1.0f - cosa);
            F32x4 t = new F32x4(u * sina, cosa);

            U32x3 ppn = new U32x3(0x00000000, 0x00000000, 0x80000000);
            U32x3 npp = new U32x3(0x80000000, 0x00000000, 0x00000000);
            U32x3 pnp = new U32x3(0x00000000, 0x80000000, 0x00000000);

            return new F32x3x3(
                u.x * u_inv_cosa + AsF32(AsU32(t.wzy) ^ ppn),
                u.y * u_inv_cosa + AsF32(AsU32(t.zwx) ^ npp),
                u.z * u_inv_cosa + AsF32(AsU32(t.yxw) ^ pnp)
                );
            /*
            return F32x3x3(
                cosa + u.x * u.x * (1.0f - cosa),       u.y * u.x * (1.0f - cosa) - u.z * sina, u.z * u.x * (1.0f - cosa) + u.y * sina,
                u.x * u.y * (1.0f - cosa) + u.z * sina, cosa + u.y * u.y * (1.0f - cosa),       u.y * u.z * (1.0f - cosa) - u.x * sina,
                u.x * u.z * (1.0f - cosa) - u.y * sina, u.y * u.z * (1.0f - cosa) + u.x * sina, cosa + u.z * u.z * (1.0f - cosa)
                );
                */
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerXYZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z,  c.z * s.x * s.y - c.x * s.z,    c.x * c.z * s.y + s.x * s.z,
                c.y * s.z,  c.x * c.z + s.x * s.y * s.z,    c.x * s.y * s.z - c.z * s.x,
                -s.y,       c.y * s.x,                      c.x * c.y
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerXZY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z,  s.x * s.y - c.x * c.y * s.z,    c.x * s.y + c.y * s.x * s.z,
                s.z,        c.x * c.z,                      -c.z * s.x,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z,    c.x * c.y - s.x * s.y * s.z
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerYXZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z - s.x * s.y * s.z,    -c.x * s.z, c.z * s.y + c.y * s.x * s.z,
                c.z * s.x * s.y + c.y * s.z,    c.x * c.z,  s.y * s.z - c.y * c.z * s.x,
                -c.x * s.y,                     s.x,        c.x * c.y
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerYZX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z,                      -s.z,       c.z * s.y,
                s.x * s.y + c.x * c.y * s.z,    c.x * c.z,  c.x * s.y * s.z - c.y * s.x,
                c.y * s.x * s.z - c.x * s.y,    c.z * s.x,  c.x * c.y + s.x * s.y * s.z
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerZXY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z + s.x * s.y * s.z,    c.z * s.x * s.y - c.y * s.z,    c.x * s.y,
                c.x * s.z,                      c.x * c.z,                      -s.x,
                c.y * s.x * s.z - c.z * s.y,    c.y * c.z * s.x + s.y * s.z,    c.x * c.y
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerZYX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x3x3(
                c.y * c.z,                      -c.y * s.z,                     s.y,
                c.z * s.x * s.y + c.x * s.z,    c.x * c.z - s.x * s.y * s.z,    -c.y * s.x,
                s.x * s.z - c.x * c.z * s.y,    c.z * s.x + c.x * s.y * s.z,    c.x * c.y
                );
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerXYZ(F32 x, F32 y, F32 z) { return EulerXYZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerXZY(F32 x, F32 y, F32 z) { return EulerXZY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerYXZ(F32 x, F32 y, F32 z) { return EulerYXZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerYZX(F32 x, F32 y, F32 z) { return EulerYZX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerZXY(F32 x, F32 y, F32 z) { return EulerZXY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 EulerZYX(F32 x, F32 y, F32 z) { return EulerZYX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in the given order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 Euler(F32x3 xyz, RotationOrder order = RotationOrder.Default)
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
                    return F32x3x3.identity;
            }
        }

        /// <summary>
        /// Returns a F32x3x3 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The F32x3x3 rotation matrix representing the rotation by Euler angles in the given order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 Euler(F32 x, F32 y, F32 z, RotationOrder order = RotationOrder.Default)
        {
            return Euler(new F32x3(x, y, z), order);
        }

        /// <summary>Returns a F32x3x3 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing a rotation around the x-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 RotateX(F32 angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x3x3(
                    1.0f, 0.0f, 0.0f,
                    0.0f, c,    -s,
                    0.0f, s,    c);
        }

        /// <summary>Returns a F32x3x3 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing a rotation around the y-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 RotateY(F32 angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x3x3(
                    c,    0.0f, s,
                    0.0f, 1.0f, 0.0f,
                    -s,   0.0f, c);
        }

        /// <summary>Returns a F32x3x3 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        /// <returns>The F32x3x3 rotation matrix representing a rotation around the z-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 RotateZ(F32 angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x3x3(
                    c,    -s,   0.0f,
                    s,    c,    0.0f,
                    0.0f, 0.0f, 1.0f);
        }

        /// <summary>Returns a F32x3x3 matrix representing a uniform scaling of all axes by s.</summary>
        /// <param name="s">The uniform scaling factor.</param>
        /// <returns>The F32x3x3 matrix representing a uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 Scale(F32 s)
        {
            return new F32x3x3(
                    s,    0.0f, 0.0f,
                    0.0f, s,    0.0f,
                    0.0f, 0.0f, s);
        }

        /// <summary>Returns a F32x3x3 matrix representing a non-uniform axis scaling by x, y and z.</summary>
        /// <param name="x">The x-axis scaling factor.</param>
        /// <param name="y">The y-axis scaling factor.</param>
        /// <param name="z">The z-axis scaling factor.</param>
        /// <returns>The F32x3x3 rotation matrix representing a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 Scale(F32 x, F32 y, F32 z)
        {
            return new F32x3x3(
                    x,    0.0f, 0.0f,
                    0.0f, y,    0.0f,
                    0.0f, 0.0f, z);
        }

        /// <summary>Returns a F32x3x3 matrix representing a non-uniform axis scaling by the components of the F32x3 vector v.</summary>
        /// <param name="v">The vector containing non-uniform scaling factors.</param>
        /// <returns>The F32x3x3 rotation matrix representing a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 Scale(F32x3 v)
        {
            return Scale(v.x, v.y, v.z);
        }

        /// <summary>
        /// Returns a F32x3x3 view rotation matrix given a unit length forward vector and a unit length up vector.
        /// The two input vectors are assumed to be unit length and not collinear.
        /// If these assumptions are not met use F32x3x3.LookRotationSafe instead.
        /// </summary>
        /// <param name="forward">The forward vector to align the center of view with.</param>
        /// <param name="up">The up vector to point top of view toward.</param>
        /// <returns>The F32x3x3 view rotation matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 LookRotation(F32x3 forward, F32x3 up)
        {
            F32x3 t = cross(up, forward).Normalize();
            return new F32x3x3(t, cross(forward, t), forward);
        }

        /// <summary>
        /// Returns a F32x3x3 view rotation matrix given a forward vector and an up vector.
        /// The two input vectors are not assumed to be unit length.
        /// If the magnitude of either of the vectors is so extreme that the calculation cannot be carried out reliably or the vectors are collinear,
        /// the identity will be returned instead.
        /// </summary>
        /// <param name="forward">The forward vector to align the center of view with.</param>
        /// <param name="up">The up vector to point top of view toward.</param>
        /// <returns>The F32x3x3 view rotation matrix or the identity matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 LookRotationSafe(F32x3 forward, F32x3 up)
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

            bool accept = mn > 1e-35f && mx < 1e35f && isfinite(forwardLengthSq) && isfinite(upLengthSq) && isfinite(tLengthSq);
            return new F32x3x3(
                select(new F32x3(1,0,0), t, accept),
                select(new F32x3(0,1,0), cross(forward, t), accept),
                select(new F32x3(0,0,1), forward, accept));
        }

        /// <summary>
        /// Converts a F32x4x4 to a F32x3x3.
        /// </summary>
        /// <param name="f4X4">The F32x4x4 to convert to a F32x3x3.</param>
        /// <returns>The F32x3x3 constructed from the upper left 3x3 of the input F32x4x4 matrix.</returns>
        public static explicit operator F32x3x3(F32x4x4 f4X4) => new F32x3x3(f4X4);
    }

    public partial struct F32x4x4
    {
        /// <summary>Constructs a F32x4x4 from a F32x3x3 rotation matrix and a F32x3 translation vector.</summary>
        /// <param name="rotation">The F32x3x3 rotation matrix.</param>
        /// <param name="translation">The translation vector.</param>
        public F32x4x4(F32x3x3 rotation, F32x3 translation)
        {
            c0 = new F32x4(rotation.c0, 0.0f);
            c1 = new F32x4(rotation.c1, 0.0f);
            c2 = new F32x4(rotation.c2, 0.0f);
            c3 = new F32x4(translation, 1.0f);
        }

        /// <summary>Constructs a F32x4x4 from a Quaternion and a F32x3 translation vector.</summary>
        /// <param name="rotation">The Quaternion rotation.</param>
        /// <param name="translation">The translation vector.</param>
        public F32x4x4(Quaternion rotation, F32x3 translation)
        {
            F32x3x3 rot = new F32x3x3(rotation);
            c0 = new F32x4(rot.c0, w: 0.0f);
            c1 = new F32x4(rot.c1, w: 0.0f);
            c2 = new F32x4(rot.c2, w: 0.0f);
            c3 = new F32x4(translation, w: 1.0f);
        }

        /// <summary>Constructs a F32x4x4 from a RigidTransform.</summary>
        /// <param name="transform">The RigidTransform.</param>
        public F32x4x4(RigidTransform transform)
        {
            F32x3x3 rot = new F32x3x3(transform.rot);
            c0 = new F32x4(xyz: rot.c0, w: 0.0f);
            c1 = new F32x4(rot.c1, 0.0f);
            c2 = new F32x4(rot.c2, 0.0f);
            c3 = new F32x4(transform.pos, 1.0f);
        }

        /// <summary>
        /// Returns a F32x4x4 matrix representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="axis">The axis of rotation.</param>
        /// <param name="angle">The angle of rotation in radians.</param>
        /// <returns>The F32x4x4 matrix representing the rotation about an axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 AxisAngle(F32x3 axis, F32 angle)
        {
            F32 sina, cosa;
            Maths.sincos(angle, out sina, out cosa);

            F32x4 u = new F32x4(axis, 0.0f);
            F32x4 u_yzx = u.yzxx;
            F32x4 u_zxy = u.zxyx;
            F32x4 u_inv_cosa = u - u * cosa;  // u * (1.0f - cosa);
            F32x4 t = new F32x4(u.xyz * sina, cosa);

            U32x4 ppnp = new U32x4(0x00000000, 0x00000000, 0x80000000, 0x00000000);
            U32x4 nppp = new U32x4(0x80000000, 0x00000000, 0x00000000, 0x00000000);
            U32x4 pnpp = new U32x4(0x00000000, 0x80000000, 0x00000000, 0x00000000);
            U32x4 mask = new U32x4(0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000);

            return new F32x4x4(
                u.x * u_inv_cosa + AsF32((AsU32(t.wzyx) ^ ppnp) & mask),
                u.y * u_inv_cosa + AsF32((AsU32(t.zwxx) ^ nppp) & mask),
                u.z * u_inv_cosa + AsF32((AsU32(t.yxwx) ^ pnpp) & mask),
                new F32x4(0.0f, 0.0f, 0.0f, 1.0f)
                );

        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerXYZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z,  c.z * s.x * s.y - c.x * s.z,    c.x * c.z * s.y + s.x * s.z,    0.0f,
                c.y * s.z,  c.x * c.z + s.x * s.y * s.z,    c.x * s.y * s.z - c.z * s.x,    0.0f,
                -s.y,       c.y * s.x,                      c.x * c.y,                      0.0f,
                0.0f,       0.0f,                           0.0f,                           1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerXZY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z,  s.x * s.y - c.x * c.y * s.z,    c.x * s.y + c.y * s.x * s.z,    0.0f,
                s.z,        c.x * c.z,                      -c.z * s.x,                     0.0f,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z,    c.x * c.y - s.x * s.y * s.z,    0.0f,
                0.0f,       0.0f,                           0.0f,                           1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerYXZ(F32x3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z - s.x * s.y * s.z,    -c.x * s.z, c.z * s.y + c.y * s.x * s.z,    0.0f,
                c.z * s.x * s.y + c.y * s.z,    c.x * c.z,  s.y * s.z - c.y * c.z * s.x,    0.0f,
                -c.x * s.y,                     s.x,        c.x * c.y,                      0.0f,
                0.0f,                           0.0f,       0.0f,                           1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerYZX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z,                      -s.z,       c.z * s.y,                      0.0f,
                s.x * s.y + c.x * c.y * s.z,    c.x * c.z,  c.x * s.y * s.z - c.y * s.x,    0.0f,
                c.y * s.x * s.z - c.x * s.y,    c.z * s.x,  c.x * c.y + s.x * s.y * s.z,    0.0f,
                0.0f,                           0.0f,       0.0f,                           1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerZXY(F32x3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z + s.x * s.y * s.z,    c.z * s.x * s.y - c.y * s.z,    c.x * s.y,  0.0f,
                c.x * s.z,                      c.x * c.z,                      -s.x,       0.0f,
                c.y * s.x * s.z - c.z * s.y,    c.y * c.z * s.x + s.y * s.z,    c.x * c.y,  0.0f,
                0.0f,                           0.0f,                           0.0f,       1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerZYX(F32x3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            F32x3 s, c;
            sincos(xyz, out s, out c);
            return new F32x4x4(
                c.y * c.z,                      -c.y * s.z,                     s.y,        0.0f,
                c.z * s.x * s.y + c.x * s.z,    c.x * c.z - s.x * s.y * s.z,    -c.y * s.x, 0.0f,
                s.x * s.z - c.x * c.z * s.y,    c.z * s.x + c.x * s.y * s.z,    c.x * c.y,  0.0f,
                0.0f,                           0.0f,                           0.0f,       1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in x-y-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerXYZ(F32 x, F32 y, F32 z) { return EulerXYZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in x-z-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerXZY(F32 x, F32 y, F32 z) { return EulerXZY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in y-x-z order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerYXZ(F32 x, F32 y, F32 z) { return EulerYXZ(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in y-z-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerYZX(F32 x, F32 y, F32 z) { return EulerYZX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in z-x-y order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerZXY(F32 x, F32 y, F32 z) { return EulerZXY(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in z-y-x order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 EulerZYX(F32 x, F32 y, F32 z) { return EulerZYX(new F32x3(x, y, z)); }

        /// <summary>
        /// Returns a F32x4x4 constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A F32x3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in given order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Euler(F32x3 xyz, RotationOrder order = RotationOrder.Default)
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
                    return F32x4x4.identity;
            }
        }

        /// <summary>
        /// Returns a F32x4x4 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The F32x4x4 rotation matrix of the Euler angle rotation in given order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Euler(F32 x, F32 y, F32 z, RotationOrder order = RotationOrder.Default)
        {
            return Euler(new F32x3(x, y, z), order);
        }

        /// <summary>Returns a F32x4x4 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        /// <returns>The F32x4x4 rotation matrix that rotates around the x-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 RotateX(F32 angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x4x4(1.0f, 0.0f, 0.0f, 0.0f,
                            0.0f, c,    -s,   0.0f,
                            0.0f, s,    c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        /// <summary>Returns a F32x4x4 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        /// <returns>The F32x4x4 rotation matrix that rotates around the y-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 RotateY(F32 angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x4x4(c,    0.0f, s,    0.0f,
                            0.0f, 1.0f, 0.0f, 0.0f,
                            -s,   0.0f, c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        /// <summary>Returns a F32x4x4 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        /// <returns>The F32x4x4 rotation matrix that rotates around the z-axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 RotateZ(F32 angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            F32 s, c;
            sincos(angle, out s, out c);
            return new F32x4x4(c,    -s,   0.0f, 0.0f,
                            s,    c,    0.0f, 0.0f,
                            0.0f, 0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        /// <summary>Returns a F32x4x4 scale matrix given 3 axis scales.</summary>
        /// <param name="s">The uniform scaling factor.</param>
        /// <returns>The F32x4x4 matrix that represents a uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Scale(F32 s)
        {
            return new F32x4x4(s,    0.0f, 0.0f, 0.0f,
                            0.0f, s,    0.0f, 0.0f,
                            0.0f, 0.0f, s,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        /// <summary>Returns a F32x4x4 scale matrix given a F32x3 vector containing the 3 axis scales.</summary>
        /// <param name="x">The x-axis scaling factor.</param>
        /// <param name="y">The y-axis scaling factor.</param>
        /// <param name="z">The z-axis scaling factor.</param>
        /// <returns>The F32x4x4 matrix that represents a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Scale(F32 x, F32 y, F32 z)
        {
            return new F32x4x4(x,    0.0f, 0.0f, 0.0f,
                            0.0f, y,    0.0f, 0.0f,
                            0.0f, 0.0f, z,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        /// <summary>Returns a F32x4x4 scale matrix given a F32x3 vector containing the 3 axis scales.</summary>
        /// <param name="scales">The vector containing scale factors for each axis.</param>
        /// <returns>The F32x4x4 matrix that represents a non-uniform scale.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Scale(F32x3 scales)
        {
            return Scale(scales.x, scales.y, scales.z);
        }

        /// <summary>Returns a F32x4x4 translation matrix given a F32x3 translation vector.</summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The F32x4x4 translation matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Translate(F32x3 vector)
        {
            return new F32x4x4(
                    new F32x4(1.0f, 0.0f, 0.0f, 0.0f),
                    new F32x4(0.0f, 1.0f, 0.0f, 0.0f),
                    new F32x4(0.0f, 0.0f, 1.0f, 0.0f),
                    new F32x4(vector.x, vector.y, vector.z, 1.0f));
        }

        /// <summary>
        /// Returns a F32x4x4 view matrix given an eye position, a target point and a unit length up vector.
        /// The up vector is assumed to be unit length, the eye and target points are assumed to be distinct and
        /// the vector between them is assumes to be collinear with the up vector.
        /// If these assumptions are not met use F32x4x4.LookRotationSafe instead.
        /// </summary>
        /// <param name="eye">The eye position.</param>
        /// <param name="target">The view target position.</param>
        /// <param name="up">The eye up direction.</param>
        /// <returns>The F32x4x4 view matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 LookAt(F32x3 eye, F32x3 target, F32x3 up)
        {
            F32x3x3 rot = F32x3x3.LookRotation(forward: (target - eye).Normalize(), up);

            F32x4x4 matrix;
            matrix.c0 = new F32x4(rot.c0, 0.0F);
            matrix.c1 = new F32x4(rot.c1, 0.0F);
            matrix.c2 = new F32x4(rot.c2, 0.0F);
            matrix.c3 = new F32x4(eye, 1.0F);
            return matrix;
        }

        /// <summary>
        /// Returns a F32x4x4 centered orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the view volume.</param>
        /// <param name="height">The height of the view volume.</param>
        /// <param name="near">The distance to the near plane.</param>
        /// <param name="far">The distance to the far plane.</param>
        /// <returns>The F32x4x4 centered orthographic projection matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 Ortho(F32 width, F32 height, F32 near, F32 far)
        {
            F32 rcpdx = 1.0f / width;
            F32 rcpdy = 1.0f / height;
            F32 rcpdz = 1.0f / (far - near);

            return new F32x4x4(
                2.0f * rcpdx,   0.0f,            0.0f,           0.0f,
                0.0f,           2.0f * rcpdy,    0.0f,           0.0f,
                0.0f,           0.0f,           -2.0f * rcpdz,  -(far + near) * rcpdz,
                0.0f,           0.0f,            0.0f,           1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 off-center orthographic projection matrix.
        /// </summary>
        /// <param name="left">The minimum x-coordinate of the view volume.</param>
        /// <param name="right">The maximum x-coordinate of the view volume.</param>
        /// <param name="bottom">The minimum y-coordinate of the view volume.</param>
        /// <param name="top">The minimum y-coordinate of the view volume.</param>
        /// <param name="near">The distance to the near plane.</param>
        /// <param name="far">The distance to the far plane.</param>
        /// <returns>The F32x4x4 off-center orthographic projection matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 OrthoOffCenter(F32 left, F32 right, F32 bottom, F32 top, F32 near, F32 far)
        {
            F32 rcpdx = 1.0f / (right - left);
            F32 rcpdy = 1.0f / (top - bottom);
            F32 rcpdz = 1.0f / (far - near);

            return new F32x4x4(
                2.0f * rcpdx,   0.0f,           0.0f,               -(right + left) * rcpdx,
                0.0f,           2.0f * rcpdy,   0.0f,               -(top + bottom) * rcpdy,
                0.0f,           0.0f,          -2.0f * rcpdz,       -(far + near) * rcpdz,
                0.0f,           0.0f,           0.0f,                1.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 perspective projection matrix based on field of view.
        /// </summary>
        /// <param name="verticalFov">Vertical Field of view in radians.</param>
        /// <param name="aspect">X:Y aspect ratio.</param>
        /// <param name="near">Distance to near plane. Must be greater than zero.</param>
        /// <param name="far">Distance to far plane. Must be greater than zero.</param>
        /// <returns>The F32x4x4 perspective projection matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 PerspectiveFov(F32 verticalFov, F32 aspect, F32 near, F32 far)
        {
            F32 cotangent = 1.0f / tan(verticalFov * 0.5f);
            F32 rcpdz = 1.0f / (near - far);

            return new F32x4x4(
                cotangent / aspect, 0.0f,       0.0f,                   0.0f,
                0.0f,               cotangent,  0.0f,                   0.0f,
                0.0f,               0.0f,       (far + near) * rcpdz,   2.0f * near * far * rcpdz,
                0.0f,               0.0f,      -1.0f,                   0.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 off-center perspective projection matrix.
        /// </summary>
        /// <param name="left">The x-coordinate of the left side of the clipping frustum at the near plane.</param>
        /// <param name="right">The x-coordinate of the right side of the clipping frustum at the near plane.</param>
        /// <param name="bottom">The y-coordinate of the bottom side of the clipping frustum at the near plane.</param>
        /// <param name="top">The y-coordinate of the top side of the clipping frustum at the near plane.</param>
        /// <param name="near">Distance to the near plane. Must be greater than zero.</param>
        /// <param name="far">Distance to the far plane. Must be greater than zero.</param>
        /// <returns>The F32x4x4 off-center perspective projection matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 PerspectiveOffCenter(F32 left, F32 right, F32 bottom, F32 top, F32 near, F32 far)
        {
            F32 rcpdz = 1.0f / (near - far);
            F32 rcpWidth = 1.0f / (right - left);
            F32 rcpHeight = 1.0f / (top - bottom);

            return new F32x4x4(
                2.0f * near * rcpWidth,     0.0f,                       (left + right) * rcpWidth,     0.0f,
                0.0f,                       2.0f * near * rcpHeight,    (bottom + top) * rcpHeight,    0.0f,
                0.0f,                       0.0f,                        (far + near) * rcpdz,          2.0f * near * far * rcpdz,
                0.0f,                       0.0f,                       -1.0f,                          0.0f
                );
        }

        /// <summary>
        /// Returns a F32x4x4 matrix representing a combined scale-, rotation- and translation transform.
        /// Equivalent to mul(translationTransform, mul(rotationTransform, scaleTransform)).
        /// </summary>
        /// <param name="translation">The translation vector.</param>
        /// <param name="rotation">The Quaternion rotation.</param>
        /// <param name="scale">The scaling factors of each axis.</param>
        /// <returns>The F32x4x4 matrix representing the translation, rotation, and scale by the inputs.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 TRS(F32x3 translation, Quaternion rotation, F32x3 scale)
        {
            F32x3x3 r = new F32x3x3(rotation);
            return new F32x4x4(  new F32x4(r.c0 * scale.x, 0.0f),
                              new F32x4(r.c1 * scale.y, 0.0f),
                              new F32x4(r.c2 * scale.z, 0.0f),
                              new F32x4(translation, 1.0f));
        }
    }

    partial class Maths
    {
        /*
        /// <summary>
        /// Extracts a F32x3x3 from the upper left 3x3 of a F32x4x4.
        /// </summary>
        /// <param name="f4X4"><see cref="new F32x4x4"/> to extract a F32x3x3 from.</param>
        /// <returns>Upper left 3x3 matrix as F32x3x3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 new F32x3x3(F32x4x4 f4X4)
        {
            return new F32x3x3(f4X4);
        }

        /// <summary>Returns a F32x3x3 matrix constructed from a Quaternion.</summary>
        /// <param name="rotation">The Quaternion representing a rotation.</param>
        /// <returns>The F32x3x3 constructed from a Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 new F32x3x3(Quaternion rotation)
        {
            return new F32x3x3(rotation);
        }

        /// <summary>Returns a F32x4x4 constructed from a F32x3x3 rotation matrix and a F32x3 translation vector.</summary>
        /// <param name="rotation">The F32x3x3 rotation matrix.</param>
        /// <param name="translation">The translation vector.</param>
        /// <returns>The F32x4x4 constructed from a rotation and translation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 new F32x4x4(F32x3x3 rotation, F32x3 translation)
        {
            return new F32x4x4(rotation, translation);
        }

        /// <summary>Returns a F32x4x4 constructed from a Quaternion and a F32x3 translation vector.</summary>
        /// <param name="rotation">The Quaternion rotation.</param>
        /// <param name="translation">The translation vector.</param>
        /// <returns>The F32x4x4 constructed from a rotation and translation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 new F32x4x4(Quaternion rotation, F32x3 translation)
        {
            return new F32x4x4(rotation, translation);
        }

        /// <summary>Returns a F32x4x4 constructed from a RigidTransform.</summary>
        /// <param name="transform">The rigid transformation.</param>
        /// <returns>The F32x4x4 constructed from a RigidTransform.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x4x4 new F32x4x4(RigidTransform transform)
        {
            return new F32x4x4(transform);
        }
        */

        /// <summary>Returns an orthonormalized version of a F32x3x3 matrix.</summary>
        /// <param name="i">The F32x3x3 to be orthonormalized.</param>
        /// <returns>The orthonormalized F32x3x3 matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static F32x3x3 orthonormalize(F32x3x3 i)
        {
            F32x3x3 o;

            F32x3 u = i.c0;
            F32x3 v = i.c1 - i.c0 * Maths.dot(i.c1, i.c0);

            F32 lenU = Maths.Length(u);
            F32 lenV = Maths.Length(v);

            bool c = lenU > 1e-30f && lenV > 1e-30f;

            o.c0 = Maths.select(new F32x3(1, 0, 0), u / lenU, c);
            o.c1 = Maths.select(new F32x3(0, 1, 0), v / lenV, c);
            o.c2 = Maths.cross(o.c0, o.c1);

            return o;
        }
    }
}
