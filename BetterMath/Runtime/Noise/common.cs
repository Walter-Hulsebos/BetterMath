using Unity.IL2CPP.CompilerServices;
using static CGTK.Utilities.BetterMath.Maths;

namespace CGTK.Utilities.BetterMath
{
    /// <summary>
    /// A static class containing noise functions.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    public static partial class noise
    {
        // Modulo 289 without a division (only multiplications)
        static float  mod289(float x)  { return x - floor(x * (1.0f / 289.0f)) * 289.0f; }
        static F32x2 mod289(F32x2 x) { return x - floor(x * (1.0f / 289.0f)) * 289.0f; }
        static F32x3 mod289(F32x3 x) { return x - floor(x * (1.0f / 289.0f)) * 289.0f; }
        static F32x4 mod289(F32x4 x) { return x - floor(x * (1.0f / 289.0f)) * 289.0f; }

        // Modulo 7 without a division
        static F32x3 mod7(F32x3 x) { return x - floor(x * (1.0f / 7.0f)) * 7.0f; }
        static F32x4 mod7(F32x4 x) { return x - floor(x * (1.0f / 7.0f)) * 7.0f; }

        // Permutation polynomial: (34x^2 + x) math.mod 289
        static float  permute(float x)  { return mod289((34.0f * x + 1.0f) * x); }
        static F32x3 permute(F32x3 x) { return mod289((34.0f * x + 1.0f) * x); }
        static F32x4 permute(F32x4 x) { return mod289((34.0f * x + 1.0f) * x); }

        static float  taylorInvSqrt(float r)  { return 1.79284291400159f - 0.85373472095314f * r; }
        static F32x4 taylorInvSqrt(F32x4 r) { return 1.79284291400159f - 0.85373472095314f * r; }

        static F32x2 fade(F32x2 t) { return t*t*t*(t*(t*6.0f-15.0f)+10.0f); }
        static F32x3 fade(F32x3 t) { return t*t*t*(t*(t*6.0f-15.0f)+10.0f); }
        static F32x4 fade(F32x4 t) { return t*t*t*(t*(t*6.0f-15.0f)+10.0f); }

        static F32x4 grad4(float j, F32x4 ip)
        {
            F32x4 ones = new F32x4(1.0f, 1.0f, 1.0f, -1.0f);
            F32x3 pxyz = floor(frac(new F32x3(j) * ip.xyz) * 7.0f) * ip.z - 1.0f;
            float  pw   = 1.5f - dot(abs(pxyz), ones.xyz);
            F32x4 p = new F32x4(pxyz, pw);
            F32x4 s = new F32x4(p < 0.0f);
            p.xyz = p.xyz + (s.xyz*2.0f - 1.0f) * s.www;
            return p;
        }

        // Hashed 2-D gradients with an extra rotation.
        // (The constant 0.0243902439 is 1/41)
        static F32x2 rgrad2(F32x2 p, float rot)
        {
            // For more isotropic gradients, math.sin/math.cos can be used instead.
            float u = permute(permute(p.x) + p.y) * 0.0243902439f + rot; // Rotate by shift
            u = frac(u) * 6.28318530718f; // 2*pi
            return new F32x2(cos(u), sin(u));
        }
    }
}
