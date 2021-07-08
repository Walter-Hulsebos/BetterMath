//
// GLSL textureless classic 2D noise "cnoise",
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
        /// <param name="P">Point on a 2D grid of gradient vectors.</param>
        /// <returns>Noise value.</returns>
        public static float cnoise(F32x2 P)
        {
            F32x4 Pi = floor(P.xyxy) + new F32x4(0.0f, 0.0f, 1.0f, 1.0f);
            F32x4 Pf = frac(P.xyxy) - new F32x4(0.0f, 0.0f, 1.0f, 1.0f);
            Pi = mod289(Pi); // To avoid truncation effects in permutation
            F32x4 ix = Pi.xzxz;
            F32x4 iy = Pi.yyww;
            F32x4 fx = Pf.xzxz;
            F32x4 fy = Pf.yyww;

            F32x4 i = permute(permute(ix) + iy);

            F32x4 gx = frac(i * (1.0f / 41.0f)) * 2.0f - 1.0f;
            F32x4 gy = abs(gx) - 0.5f;
            F32x4 tx = floor(gx + 0.5f);
            gx = gx - tx;

            F32x2 g00 = new F32x2(gx.x, gy.x);
            F32x2 g10 = new F32x2(gx.y, gy.y);
            F32x2 g01 = new F32x2(gx.z, gy.z);
            F32x2 g11 = new F32x2(gx.w, gy.w);

            F32x4 norm = taylorInvSqrt(new F32x4(dot(g00, g00), dot(g01, g01), dot(g10, g10), dot(g11, g11)));
            g00 *= norm.x;
            g01 *= norm.y;
            g10 *= norm.z;
            g11 *= norm.w;

            float n00 = dot(g00, new F32x2(fx.x, fy.x));
            float n10 = dot(g10, new F32x2(fx.y, fy.y));
            float n01 = dot(g01, new F32x2(fx.z, fy.z));
            float n11 = dot(g11, new F32x2(fx.w, fy.w));

            F32x2 fade_xy = fade(Pf.xy);
            F32x2 n_x = lerp(new F32x2(n00, n01), new F32x2(n10, n11), fade_xy.x);
            float n_xy = lerp(n_x.x, n_x.y, fade_xy.y);
            return 2.3f * n_xy;
        }

        /// <summary>
        /// Classic Perlin noise, periodic variant
        /// </summary>
        /// <param name="P">Point on a 2D grid of gradient vectors.</param>
        /// <param name="rep">Period of repetition.</param>
        /// <returns>Noise value.</returns>
        public static float pnoise(F32x2 P, F32x2 rep)
        {
            F32x4 Pi = floor(P.xyxy) + new F32x4(0.0f, 0.0f, 1.0f, 1.0f);
            F32x4 Pf = frac(P.xyxy) - new F32x4(0.0f, 0.0f, 1.0f, 1.0f);
            Pi = fmod(Pi, rep.xyxy); // To create noise with explicit period
            Pi = mod289(Pi); // To avoid truncation effects in permutation
            F32x4 ix = Pi.xzxz;
            F32x4 iy = Pi.yyww;
            F32x4 fx = Pf.xzxz;
            F32x4 fy = Pf.yyww;

            F32x4 i = permute(permute(ix) + iy);

            F32x4 gx = frac(i * (1.0f / 41.0f)) * 2.0f - 1.0f;
            F32x4 gy = abs(gx) - 0.5f;
            F32x4 tx = floor(gx + 0.5f);
            gx = gx - tx;

            F32x2 g00 = new F32x2(gx.x, gy.x);
            F32x2 g10 = new F32x2(gx.y, gy.y);
            F32x2 g01 = new F32x2(gx.z, gy.z);
            F32x2 g11 = new F32x2(gx.w, gy.w);

            F32x4 norm = taylorInvSqrt(new F32x4(dot(g00, g00), dot(g01, g01), dot(g10, g10), dot(g11, g11)));
            g00 *= norm.x;
            g01 *= norm.y;
            g10 *= norm.z;
            g11 *= norm.w;

            float n00 = dot(g00, new F32x2(fx.x, fy.x));
            float n10 = dot(g10, new F32x2(fx.y, fy.y));
            float n01 = dot(g01, new F32x2(fx.z, fy.z));
            float n11 = dot(g11, new F32x2(fx.w, fy.w));

            F32x2 fade_xy = fade(Pf.xy);
            F32x2 n_x = lerp(new F32x2(n00, n01), new F32x2(n10, n11), fade_xy.x);
            float n_xy = lerp(n_x.x, n_x.y, fade_xy.y);
            return 2.3f * n_xy;
        }
    }
}
