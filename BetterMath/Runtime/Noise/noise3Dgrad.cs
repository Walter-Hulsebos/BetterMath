//
// Description : Array and textureless GLSL 2D/3D/4D simplex
//               noise functions.
//      Author : Ian McEwan, Ashima Arts.
//  Maintainer : stegu
//     Lastmath.mod : 20110822 (ijm)
//     License : Copyright (C) 2011 Ashima Arts. All rights reserved.
//               Distributed under the MIT License. See LICENSE file.
//               https://github.com/ashima/webgl-noise
//               https://github.com/stegu/webgl-noise
//

using static CGTK.Utilities.BetterMath.Maths;

namespace CGTK.Utilities.BetterMath
{
    public static partial class noise
    {
        /// <summary>
        /// Simplex noise.
        /// </summary>
        /// <param name="v">Input coordinate.</param>
        /// <param name="gradient">Output 3D noise gradient.</param>
        /// <returns>Noise value.</returns>
        public static float snoise(F32x3 v, out F32x3 gradient)
        {
            F32x2 C = new F32x2(1.0f / 6.0f, 1.0f / 3.0f);
            F32x4 D = new F32x4(0.0f, 0.5f, 1.0f, 2.0f);

            // First corner
            F32x3 i = floor(v + dot(v, C.yyy));
            F32x3 x0 = v - i + dot(i, C.xxx);

            // Other corners
            F32x3 g = step(x0.yzx, x0.xyz);
            F32x3 l = 1.0f - g;
            F32x3 i1 = min(g.xyz, l.zxy);
            F32x3 i2 = max(g.xyz, l.zxy);

            //   x0 = x0 - 0.0 + 0.0 * C.xxx;
            //   x1 = x0 - i1  + 1.0 * C.xxx;
            //   x2 = x0 - i2  + 2.0 * C.xxx;
            //   x3 = x0 - 1.0 + 3.0 * C.xxx;
            F32x3 x1 = x0 - i1 + C.xxx;
            F32x3 x2 = x0 - i2 + C.yyy; // 2.0*C.x = 1/3 = C.y
            F32x3 x3 = x0 - D.yyy; // -1.0+3.0*C.x = -0.5 = -D.y

            // Permutations
            i = mod289(i);
            F32x4 p = permute(permute(permute(
                                           i.z + new F32x4(0.0f, i1.z, i2.z, 1.0f))
                                       + i.y + new F32x4(0.0f, i1.y, i2.y, 1.0f))
                               + i.x + new F32x4(0.0f, i1.x, i2.x, 1.0f));

            // Gradients: 7x7 points over a square, mapped onto an octahedron.
            // The ring size 17*17 = 289 is close to a multiple of 49 (49*6 = 294)
            float n_ = 0.142857142857f; // 1.0/7.0
            F32x3 ns = n_ * D.wyz - D.xzx;

            F32x4 j = p - 49.0f * floor(p * ns.z * ns.z); //  math.mod(p,7*7)

            F32x4 x_ = floor(j * ns.z);
            F32x4 y_ = floor(j - 7.0f * x_); // math.mod(j,N)

            F32x4 x = x_ * ns.x + ns.yyyy;
            F32x4 y = y_ * ns.x + ns.yyyy;
            F32x4 h = 1.0f - abs(x) - abs(y);

            F32x4 b0 = new F32x4(x.xy, y.xy);
            F32x4 b1 = new F32x4(x.zw, y.zw);

            //F32x4 s0 = F32x4(math.lessThan(b0,0.0))*2.0 - 1.0;
            //F32x4 s1 = F32x4(math.lessThan(b1,0.0))*2.0 - 1.0;
            F32x4 s0 = floor(b0) * 2.0f + 1.0f;
            F32x4 s1 = floor(b1) * 2.0f + 1.0f;
            F32x4 sh = -step(h, new F32x4(0.0f));

            F32x4 a0 = b0.xzyw + s0.xzyw * sh.xxyy;
            F32x4 a1 = b1.xzyw + s1.xzyw * sh.zzww;

            F32x3 p0 = new F32x3(a0.xy, h.x);
            F32x3 p1 = new F32x3(a0.zw, h.y);
            F32x3 p2 = new F32x3(a1.xy, h.z);
            F32x3 p3 = new F32x3(a1.zw, h.w);

            //Normalise gradients
            F32x4 norm = taylorInvSqrt(new F32x4(dot(p0, p0), dot(p1, p1), dot(p2, p2), dot(p3, p3)));
            p0 *= norm.x;
            p1 *= norm.y;
            p2 *= norm.z;
            p3 *= norm.w;

            // Mix final noise value
            F32x4 m = max(0.6f - new F32x4(dot(x0, x0), dot(x1, x1), dot(x2, x2), dot(x3, x3)), 0.0f);
            F32x4 m2 = m * m;
            F32x4 m4 = m2 * m2;
            F32x4 pdotx = new F32x4(dot(p0, x0), dot(p1, x1), dot(p2, x2), dot(p3, x3));

            // Determath.mine noise gradient
            F32x4 temp = m2 * m * pdotx;
            gradient = -8.0f * (temp.x * x0 + temp.y * x1 + temp.z * x2 + temp.w * x3);
            gradient += m4.x * p0 + m4.y * p1 + m4.z * p2 + m4.w * p3;
            gradient *= 42.0f;

            return 42.0f * dot(m4, pdotx);
        }
    }
}
