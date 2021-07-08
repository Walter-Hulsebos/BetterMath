#if !UNITY_DOTSPLAYER
using UnityEngine;

#pragma warning disable 0660, 0661

namespace CGTK.Utilities.BetterMath
{
    public partial struct F32x2
    {
        /// <summary>
        /// Converts a F32x2 to Vector2.
        /// </summary>
        /// <param name="v">F32x2 to convert.</param>
        /// <returns>The converted Vector2.</returns>
        public static implicit operator Vector2(F32x2 v)     { return new Vector2(v.x, v.y); }

        /// <summary>
        /// Converts a Vector2 to F32x2.
        /// </summary>
        /// <param name="v">Vector2 to convert.</param>
        /// <returns>The converted F32x2.</returns>
        public static implicit operator F32x2(Vector2 v)     { return new F32x2(v.x, v.y); }
    }

    public partial struct F32x3
    {
        /// <summary>
        /// Converts a F32x3 to Vector3.
        /// </summary>
        /// <param name="v">F32x3 to convert.</param>
        /// <returns>The converted Vector3.</returns>
        public static implicit operator Vector3(F32x3 v)     { return new Vector3(v.x, v.y, v.z); }

        /// <summary>
        /// Converts a Vector3 to F32x3.
        /// </summary>
        /// <param name="v">Vector3 to convert.</param>
        /// <returns>The converted F32x3.</returns>
        public static implicit operator F32x3(Vector3 v)     { return new F32x3(v.x, v.y, v.z); }
    }

    public partial struct F32x4
    {
        /// <summary>
        /// Converts a Vector4 to F32x4.
        /// </summary>
        /// <param name="v">Vector4 to convert.</param>
        /// <returns>The converted F32x4.</returns>
        public static implicit operator F32x4(Vector4 v)     { return new F32x4(v.x, v.y, v.z, v.w); }

        /// <summary>
        /// Converts a F32x4 to Vector4.
        /// </summary>
        /// <param name="v">F32x4 to convert.</param>
        /// <returns>The converted Vector4.</returns>
        public static implicit operator Vector4(F32x4 v)     { return new Vector4(v.x, v.y, v.z, v.w); }
    }

    public partial struct Quaternion
    {
        /// <summary>
        /// Converts a Quaternion to Quaternion.
        /// </summary>
        /// <param name="q">Quaternion to convert.</param>
        /// <returns>The converted Quaternion.</returns>
        public static implicit operator UnityEngine.Quaternion(Quaternion q)  { return new UnityEngine.Quaternion(q.value.x, q.value.y, q.value.z, q.value.w); }

        /// <summary>
        /// Converts a Quaternion to Quaternion.
        /// </summary>
        /// <param name="q">Quaternion to convert.</param>
        /// <returns>The converted Quaternion.</returns>
        public static implicit operator Quaternion(UnityEngine.Quaternion q)  { return new Quaternion(q.x, q.y, q.z, q.w); }
    }

    public partial struct F32x4x4
    {
        /// <summary>
        /// Converts a Matrix4x4 to F32x4x4.
        /// </summary>
        /// <param name="m">Matrix4x4 to convert.</param>
        /// <returns>The converted F32x4x4.</returns>
        public static implicit operator F32x4x4(Matrix4x4 m) { return new F32x4x4(m.GetColumn(0), m.GetColumn(1), m.GetColumn(2), m.GetColumn(3)); }

        /// <summary>
        /// Converts a F32x4x4 to Matrix4x4.
        /// </summary>
        /// <param name="m">F32x4x4 to convert.</param>
        /// <returns>The converted Matrix4x4.</returns>
        public static implicit operator Matrix4x4(F32x4x4 m) { return new Matrix4x4(m.c0, m.c1, m.c2, m.c3); }
    }
}
#endif
