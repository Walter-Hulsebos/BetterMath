//
// GLSL textureless classic 4D noise "cnoise",
// with an RSL-style periodic variant "pnoise".
// Author:  Stefan Gustavson (stefan.gustavson@liu.se)
// Version: 2011-08-22
//
// Many thanks to Ian McEwan of Ashima Arts for the
// ideas for permutation and gradient selection.
//
// Copyright (c) 2011 Stefan Gustavson. All rights reserved.
// Distributed under the MIT license. See LICENSE file.
// https://github.com/stegu/webgl-noise
//

using static CGTK.Utilities.BetterMath.Maths;

namespace CGTK.Utilities.BetterMath
{
    public static partial class noise
    {
        /// <summary>
        /// Classic Perlin noise
        /// </summary>
        /// <param name="P">Point on a 4D grid of gradient vectors.</param>
        /// <returns>Noise value.</returns>
        public static float cnoise(F32x4 P)
        {
            F32x4 Pi0 = floor(P); // Integer part for indexing
            F32x4 Pi1 = Pi0 + 1.0f; // Integer part + 1
            Pi0 = mod289(Pi0);
            Pi1 = mod289(Pi1);
            F32x4 Pf0 = frac(P); // Fractional part for interpolation
            F32x4 Pf1 = Pf0 - 1.0f; // Fractional part - 1.0
            F32x4 ix = new F32x4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
            F32x4 iy = new F32x4(Pi0.yy, Pi1.yy);
            F32x4 iz0 = new F32x4(Pi0.zzzz);
            F32x4 iz1 = new F32x4(Pi1.zzzz);
            F32x4 iw0 = new F32x4(Pi0.wwww);
            F32x4 iw1 = new F32x4(Pi1.wwww);

            F32x4 ixy = permute(permute(ix) + iy);
            F32x4 ixy0 = permute(ixy + iz0);
            F32x4 ixy1 = permute(ixy + iz1);
            F32x4 ixy00 = permute(ixy0 + iw0);
            F32x4 ixy01 = permute(ixy0 + iw1);
            F32x4 ixy10 = permute(ixy1 + iw0);
            F32x4 ixy11 = permute(ixy1 + iw1);

            F32x4 gx00 = ixy00 * (1.0f / 7.0f);
            F32x4 gy00 = floor(gx00) * (1.0f / 7.0f);
            F32x4 gz00 = floor(gy00) * (1.0f / 6.0f);
            gx00 = frac(gx00) - 0.5f;
            gy00 = frac(gy00) - 0.5f;
            gz00 = frac(gz00) - 0.5f;
            F32x4 gw00 = new F32x4(0.75f) - abs(gx00) - abs(gy00) - abs(gz00);
            F32x4 sw00 = step(gw00, new F32x4(0.0f));
            gx00 -= sw00 * (step(0.0f, gx00) - 0.5f);
            gy00 -= sw00 * (step(0.0f, gy00) - 0.5f);

            F32x4 gx01 = ixy01 * (1.0f / 7.0f);
            F32x4 gy01 = floor(gx01) * (1.0f / 7.0f);
            F32x4 gz01 = floor(gy01) * (1.0f / 6.0f);
            gx01 = frac(gx01) - 0.5f;
            gy01 = frac(gy01) - 0.5f;
            gz01 = frac(gz01) - 0.5f;
            F32x4 gw01 = new F32x4(0.75f) - abs(gx01) - abs(gy01) - abs(gz01);
            F32x4 sw01 = step(gw01, new F32x4(0.0f));
            gx01 -= sw01 * (step(0.0f, gx01) - 0.5f);
            gy01 -= sw01 * (step(0.0f, gy01) - 0.5f);

            F32x4 gx10 = ixy10 * (1.0f / 7.0f);
            F32x4 gy10 = floor(gx10) * (1.0f / 7.0f);
            F32x4 gz10 = floor(gy10) * (1.0f / 6.0f);
            gx10 = frac(gx10) - 0.5f;
            gy10 = frac(gy10) - 0.5f;
            gz10 = frac(gz10) - 0.5f;
            F32x4 gw10 = new F32x4(0.75f) - abs(gx10) - abs(gy10) - abs(gz10);
            F32x4 sw10 = step(gw10, new F32x4(0.0f));
            gx10 -= sw10 * (step(0.0f, gx10) - 0.5f);
            gy10 -= sw10 * (step(0.0f, gy10) - 0.5f);

            F32x4 gx11 = ixy11 * (1.0f / 7.0f);
            F32x4 gy11 = floor(gx11) * (1.0f / 7.0f);
            F32x4 gz11 = floor(gy11) * (1.0f / 6.0f);
            gx11 = frac(gx11) - 0.5f;
            gy11 = frac(gy11) - 0.5f;
            gz11 = frac(gz11) - 0.5f;
            F32x4 gw11 = new F32x4(0.75f) - abs(gx11) - abs(gy11) - abs(gz11);
            F32x4 sw11 = step(gw11, new F32x4(0.0f));
            gx11 -= sw11 * (step(0.0f, gx11) - 0.5f);
            gy11 -= sw11 * (step(0.0f, gy11) - 0.5f);

            F32x4 g0000 = new F32x4(gx00.x, gy00.x, gz00.x, gw00.x);
            F32x4 g1000 = new F32x4(gx00.y, gy00.y, gz00.y, gw00.y);
            F32x4 g0100 = new F32x4(gx00.z, gy00.z, gz00.z, gw00.z);
            F32x4 g1100 = new F32x4(gx00.w, gy00.w, gz00.w, gw00.w);
            F32x4 g0010 = new F32x4(gx10.x, gy10.x, gz10.x, gw10.x);
            F32x4 g1010 = new F32x4(gx10.y, gy10.y, gz10.y, gw10.y);
            F32x4 g0110 = new F32x4(gx10.z, gy10.z, gz10.z, gw10.z);
            F32x4 g1110 = new F32x4(gx10.w, gy10.w, gz10.w, gw10.w);
            F32x4 g0001 = new F32x4(gx01.x, gy01.x, gz01.x, gw01.x);
            F32x4 g1001 = new F32x4(gx01.y, gy01.y, gz01.y, gw01.y);
            F32x4 g0101 = new F32x4(gx01.z, gy01.z, gz01.z, gw01.z);
            F32x4 g1101 = new F32x4(gx01.w, gy01.w, gz01.w, gw01.w);
            F32x4 g0011 = new F32x4(gx11.x, gy11.x, gz11.x, gw11.x);
            F32x4 g1011 = new F32x4(gx11.y, gy11.y, gz11.y, gw11.y);
            F32x4 g0111 = new F32x4(gx11.z, gy11.z, gz11.z, gw11.z);
            F32x4 g1111 = new F32x4(gx11.w, gy11.w, gz11.w, gw11.w);

            F32x4 norm00 = taylorInvSqrt(new F32x4(dot(g0000, g0000), dot(g0100, g0100), dot(g1000, g1000), dot(g1100, g1100)));
            g0000 *= norm00.x;
            g0100 *= norm00.y;
            g1000 *= norm00.z;
            g1100 *= norm00.w;

            F32x4 norm01 = taylorInvSqrt(new F32x4(dot(g0001, g0001), dot(g0101, g0101), dot(g1001, g1001), dot(g1101, g1101)));
            g0001 *= norm01.x;
            g0101 *= norm01.y;
            g1001 *= norm01.z;
            g1101 *= norm01.w;

            F32x4 norm10 = taylorInvSqrt(new F32x4(dot(g0010, g0010), dot(g0110, g0110), dot(g1010, g1010), dot(g1110, g1110)));
            g0010 *= norm10.x;
            g0110 *= norm10.y;
            g1010 *= norm10.z;
            g1110 *= norm10.w;

            F32x4 norm11 = taylorInvSqrt(new F32x4(dot(g0011, g0011), dot(g0111, g0111), dot(g1011, g1011), dot(g1111, g1111)));
            g0011 *= norm11.x;
            g0111 *= norm11.y;
            g1011 *= norm11.z;
            g1111 *= norm11.w;

            float n0000 = dot(g0000, Pf0);
            float n1000 = dot(g1000, new F32x4(Pf1.x, Pf0.yzw));
            float n0100 = dot(g0100, new F32x4(Pf0.x, Pf1.y, Pf0.zw));
            float n1100 = dot(g1100, new F32x4(Pf1.xy, Pf0.zw));
            float n0010 = dot(g0010, new F32x4(Pf0.xy, Pf1.z, Pf0.w));
            float n1010 = dot(g1010, new F32x4(Pf1.x, Pf0.y, Pf1.z, Pf0.w));
            float n0110 = dot(g0110, new F32x4(Pf0.x, Pf1.yz, Pf0.w));
            float n1110 = dot(g1110, new F32x4(Pf1.xyz, Pf0.w));
            float n0001 = dot(g0001, new F32x4(Pf0.xyz, Pf1.w));
            float n1001 = dot(g1001, new F32x4(Pf1.x, Pf0.yz, Pf1.w));
            float n0101 = dot(g0101, new F32x4(Pf0.x, Pf1.y, Pf0.z, Pf1.w));
            float n1101 = dot(g1101, new F32x4(Pf1.xy, Pf0.z, Pf1.w));
            float n0011 = dot(g0011, new F32x4(Pf0.xy, Pf1.zw));
            float n1011 = dot(g1011, new F32x4(Pf1.x, Pf0.y, Pf1.zw));
            float n0111 = dot(g0111, new F32x4(Pf0.x, Pf1.yzw));
            float n1111 = dot(g1111, Pf1);

            F32x4 fade_xyzw = fade(Pf0);
            F32x4 n_0w = lerp(new F32x4(n0000, n1000, n0100, n1100), new F32x4(n0001, n1001, n0101, n1101), fade_xyzw.w);
            F32x4 n_1w = lerp(new F32x4(n0010, n1010, n0110, n1110), new F32x4(n0011, n1011, n0111, n1111), fade_xyzw.w);
            F32x4 n_zw = lerp(n_0w, n_1w, fade_xyzw.z);
            F32x2 n_yzw = lerp(n_zw.xy, n_zw.zw, fade_xyzw.y);
            float n_xyzw = lerp(n_yzw.x, n_yzw.y, fade_xyzw.x);
            return 2.2f * n_xyzw;
        }

        /// <summary>
        /// Classic Perlin noise, periodic variant
        /// </summary>
        /// <param name="P">Point on a 4D grid of gradient vectors.</param>
        /// <param name="rep">Period of repetition.</param>
        /// <returns>Noise value.</returns>
        public static float pnoise(F32x4 P, F32x4 rep)
        {
            F32x4 Pi0 = fmod(floor(P), rep); // Integer part math.modulo rep
            F32x4 Pi1 = fmod(Pi0 + 1.0f, rep); // Integer part + 1 math.mod rep
            Pi0 = mod289(Pi0);
            Pi1 = mod289(Pi1);
            F32x4 Pf0 = frac(P); // Fractional part for interpolation
            F32x4 Pf1 = Pf0 - 1.0f; // Fractional part - 1.0
            F32x4 ix = new F32x4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
            F32x4 iy = new F32x4(Pi0.yy, Pi1.yy);
            F32x4 iz0 = new F32x4(Pi0.zzzz);
            F32x4 iz1 = new F32x4(Pi1.zzzz);
            F32x4 iw0 = new F32x4(Pi0.wwww);
            F32x4 iw1 = new F32x4(Pi1.wwww);

            F32x4 ixy = permute(permute(ix) + iy);
            F32x4 ixy0 = permute(ixy + iz0);
            F32x4 ixy1 = permute(ixy + iz1);
            F32x4 ixy00 = permute(ixy0 + iw0);
            F32x4 ixy01 = permute(ixy0 + iw1);
            F32x4 ixy10 = permute(ixy1 + iw0);
            F32x4 ixy11 = permute(ixy1 + iw1);

            F32x4 gx00 = ixy00 * (1.0f / 7.0f);
            F32x4 gy00 = floor(gx00) * (1.0f / 7.0f);
            F32x4 gz00 = floor(gy00) * (1.0f / 6.0f);
            gx00 = frac(gx00) - 0.5f;
            gy00 = frac(gy00) - 0.5f;
            gz00 = frac(gz00) - 0.5f;
            F32x4 gw00 = new F32x4(0.75f) - abs(gx00) - abs(gy00) - abs(gz00);
            F32x4 sw00 = step(gw00, new F32x4(0.0f));
            gx00 -= sw00 * (step(0.0f, gx00) - 0.5f);
            gy00 -= sw00 * (step(0.0f, gy00) - 0.5f);

            F32x4 gx01 = ixy01 * (1.0f / 7.0f);
            F32x4 gy01 = floor(gx01) * (1.0f / 7.0f);
            F32x4 gz01 = floor(gy01) * (1.0f / 6.0f);
            gx01 = frac(gx01) - 0.5f;
            gy01 = frac(gy01) - 0.5f;
            gz01 = frac(gz01) - 0.5f;
            F32x4 gw01 = new F32x4(0.75f) - abs(gx01) - abs(gy01) - abs(gz01);
            F32x4 sw01 = step(gw01, new F32x4(0.0f));
            gx01 -= sw01 * (step(0.0f, gx01) - 0.5f);
            gy01 -= sw01 * (step(0.0f, gy01) - 0.5f);

            F32x4 gx10 = ixy10 * (1.0f / 7.0f);
            F32x4 gy10 = floor(gx10) * (1.0f / 7.0f);
            F32x4 gz10 = floor(gy10) * (1.0f / 6.0f);
            gx10 = frac(gx10) - 0.5f;
            gy10 = frac(gy10) - 0.5f;
            gz10 = frac(gz10) - 0.5f;
            F32x4 gw10 = new F32x4(0.75f) - abs(gx10) - abs(gy10) - abs(gz10);
            F32x4 sw10 = step(gw10, new F32x4(0.0f));
            gx10 -= sw10 * (step(0.0f, gx10) - 0.5f);
            gy10 -= sw10 * (step(0.0f, gy10) - 0.5f);

            F32x4 gx11 = ixy11 * (1.0f / 7.0f);
            F32x4 gy11 = floor(gx11) * (1.0f / 7.0f);
            F32x4 gz11 = floor(gy11) * (1.0f / 6.0f);
            gx11 = frac(gx11) - 0.5f;
            gy11 = frac(gy11) - 0.5f;
            gz11 = frac(gz11) - 0.5f;
            F32x4 gw11 = new F32x4(0.75f) - abs(gx11) - abs(gy11) - abs(gz11);
            F32x4 sw11 = step(gw11, new F32x4(0.0f));
            gx11 -= sw11 * (step(0.0f, gx11) - 0.5f);
            gy11 -= sw11 * (step(0.0f, gy11) - 0.5f);

            F32x4 g0000 = new F32x4(gx00.x, gy00.x, gz00.x, gw00.x);
            F32x4 g1000 = new F32x4(gx00.y, gy00.y, gz00.y, gw00.y);
            F32x4 g0100 = new F32x4(gx00.z, gy00.z, gz00.z, gw00.z);
            F32x4 g1100 = new F32x4(gx00.w, gy00.w, gz00.w, gw00.w);
            F32x4 g0010 = new F32x4(gx10.x, gy10.x, gz10.x, gw10.x);
            F32x4 g1010 = new F32x4(gx10.y, gy10.y, gz10.y, gw10.y);
            F32x4 g0110 = new F32x4(gx10.z, gy10.z, gz10.z, gw10.z);
            F32x4 g1110 = new F32x4(gx10.w, gy10.w, gz10.w, gw10.w);
            F32x4 g0001 = new F32x4(gx01.x, gy01.x, gz01.x, gw01.x);
            F32x4 g1001 = new F32x4(gx01.y, gy01.y, gz01.y, gw01.y);
            F32x4 g0101 = new F32x4(gx01.z, gy01.z, gz01.z, gw01.z);
            F32x4 g1101 = new F32x4(gx01.w, gy01.w, gz01.w, gw01.w);
            F32x4 g0011 = new F32x4(gx11.x, gy11.x, gz11.x, gw11.x);
            F32x4 g1011 = new F32x4(gx11.y, gy11.y, gz11.y, gw11.y);
            F32x4 g0111 = new F32x4(gx11.z, gy11.z, gz11.z, gw11.z);
            F32x4 g1111 = new F32x4(gx11.w, gy11.w, gz11.w, gw11.w);

            F32x4 norm00 = taylorInvSqrt(new F32x4(dot(g0000, g0000), dot(g0100, g0100), dot(g1000, g1000), dot(g1100, g1100)));
            g0000 *= norm00.x;
            g0100 *= norm00.y;
            g1000 *= norm00.z;
            g1100 *= norm00.w;

            F32x4 norm01 = taylorInvSqrt(new F32x4(dot(g0001, g0001), dot(g0101, g0101), dot(g1001, g1001), dot(g1101, g1101)));
            g0001 *= norm01.x;
            g0101 *= norm01.y;
            g1001 *= norm01.z;
            g1101 *= norm01.w;

            F32x4 norm10 = taylorInvSqrt(new F32x4(dot(g0010, g0010), dot(g0110, g0110), dot(g1010, g1010), dot(g1110, g1110)));
            g0010 *= norm10.x;
            g0110 *= norm10.y;
            g1010 *= norm10.z;
            g1110 *= norm10.w;

            F32x4 norm11 = taylorInvSqrt(new F32x4(dot(g0011, g0011), dot(g0111, g0111), dot(g1011, g1011), dot(g1111, g1111)));
            g0011 *= norm11.x;
            g0111 *= norm11.y;
            g1011 *= norm11.z;
            g1111 *= norm11.w;

            float n0000 = dot(g0000, Pf0);
            float n1000 = dot(g1000, new F32x4(Pf1.x, Pf0.yzw));
            float n0100 = dot(g0100, new F32x4(Pf0.x, Pf1.y, Pf0.zw));
            float n1100 = dot(g1100, new F32x4(Pf1.xy, Pf0.zw));
            float n0010 = dot(g0010, new F32x4(Pf0.xy, Pf1.z, Pf0.w));
            float n1010 = dot(g1010, new F32x4(Pf1.x, Pf0.y, Pf1.z, Pf0.w));
            float n0110 = dot(g0110, new F32x4(Pf0.x, Pf1.yz, Pf0.w));
            float n1110 = dot(g1110, new F32x4(Pf1.xyz, Pf0.w));
            float n0001 = dot(g0001, new F32x4(Pf0.xyz, Pf1.w));
            float n1001 = dot(g1001, new F32x4(Pf1.x, Pf0.yz, Pf1.w));
            float n0101 = dot(g0101, new F32x4(Pf0.x, Pf1.y, Pf0.z, Pf1.w));
            float n1101 = dot(g1101, new F32x4(Pf1.xy, Pf0.z, Pf1.w));
            float n0011 = dot(g0011, new F32x4(Pf0.xy, Pf1.zw));
            float n1011 = dot(g1011, new F32x4(Pf1.x, Pf0.y, Pf1.zw));
            float n0111 = dot(g0111, new F32x4(Pf0.x, Pf1.yzw));
            float n1111 = dot(g1111, Pf1);

            F32x4 fade_xyzw = fade(Pf0);
            F32x4 n_0w = lerp(new F32x4(n0000, n1000, n0100, n1100), new F32x4(n0001, n1001, n0101, n1101), fade_xyzw.w);
            F32x4 n_1w = lerp(new F32x4(n0010, n1010, n0110, n1110), new F32x4(n0011, n1011, n0111, n1111), fade_xyzw.w);
            F32x4 n_zw = lerp(n_0w, n_1w, fade_xyzw.z);
            F32x2 n_yzw = lerp(n_zw.xy, n_zw.zw, fade_xyzw.y);
            float n_xyzw = lerp(n_yzw.x, n_yzw.y, fade_xyzw.x);
            return 2.2f * n_xyzw;
        }
    }
}
