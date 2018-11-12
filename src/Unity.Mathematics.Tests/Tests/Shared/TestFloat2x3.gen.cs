// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2x3
    {
        [TestCompiler]
        public void float2x3_zero()
        {
            TestUtils.AreEqual(float2x3.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c2.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c2.y, 0.0f);
        }

        [TestCompiler]
        public void float2x3_operator_equal_wide_wide()
        {
            float2x3 a0 = float2x3(492.1576f, -495.206329f, 227.457642f, -147.374054f, -222.682f, 64.09375f);
            float2x3 b0 = float2x3(192.568787f, -235.611023f, -254.043121f, -412.624725f, 471.9048f, -6.47277832f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x3 a1 = float2x3(-23.8904114f, -16.8197327f, 163.232117f, -165.271f, 470.8777f, -423.942566f);
            float2x3 b1 = float2x3(-339.102356f, 488.187561f, -379.5966f, -308.417f, -82.333374f, -102.921082f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x3 a2 = float2x3(109.6344f, 462.6903f, -335.38147f, 357.2345f, 1.54559326f, -347.388245f);
            float2x3 b2 = float2x3(226.515747f, -356.9013f, -362.912781f, -427.898438f, 466.650146f, -102.799042f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x3 a3 = float2x3(-114.472168f, 435.848633f, 194.2381f, 138.765564f, -467.349152f, 370.43335f);
            float2x3 b3 = float2x3(-43.355957f, 85.0456543f, -91.1270447f, 422.192078f, -477.4313f, 1.87701416f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(-303.230072f, 451.5263f, -253.655884f, -105.203644f, -500.6911f, -426.192474f);
            float b0 = (123.544556f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x3 a1 = float2x3(159.8761f, -57.4773865f, -182.049744f, 406.513733f, 370.886f, -172.035309f);
            float b1 = (-59.55838f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x3 a2 = float2x3(455.400024f, 363.938232f, -27.1505737f, -325.976074f, -290.359039f, 180.196838f);
            float b2 = (-11.3389893f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x3 a3 = float2x3(-374.128326f, -126.546082f, -197.26178f, -227.159332f, -479.8992f, -439.777679f);
            float b3 = (-439.358948f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float2x3 b0 = float2x3(19.95221f, -185.791992f, 407.8136f, -87.2767f, -206.274689f, 160.503113f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-274.7708f);
            float2x3 b1 = float2x3(-2.63153076f, 448.354553f, -410.035248f, 247.329041f, 355.539124f, -298.0667f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (414.1015f);
            float2x3 b2 = float2x3(-481.3026f, 196.55072f, 34.6010132f, 113.7616f, -386.453369f, -124.49176f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (243.886658f);
            float2x3 b3 = float2x3(-492.6182f, 145.424438f, 421.55072f, -95.40997f, 336.809265f, 209.5838f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_not_equal_wide_wide()
        {
            float2x3 a0 = float2x3(430.842529f, 104.69f, 225.802429f, -310.5702f, -418.619446f, 304.128174f);
            float2x3 b0 = float2x3(210.024719f, -55.20334f, -269.925354f, -234.546722f, 25.91742f, -63.72699f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x3 a1 = float2x3(-509.3268f, -160.538086f, -203.301971f, -505.763245f, 162.17218f, 1.156189f);
            float2x3 b1 = float2x3(-484.5537f, -425.3336f, -53.2743835f, 328.1944f, 15.9631348f, 461.7141f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x3 a2 = float2x3(65.66205f, 102.787781f, 172.930054f, 26.6210327f, 235.125977f, 128.541992f);
            float2x3 b2 = float2x3(-113.363037f, -240.072968f, 495.119141f, 203.55835f, 340.493469f, -241.9072f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x3 a3 = float2x3(-354.996979f, 334.3595f, -495.832f, 468.307373f, 458.370972f, 299.937317f);
            float2x3 b3 = float2x3(459.569824f, 213.07373f, -384.782837f, -255.072327f, 477.663452f, -248.036621f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_not_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(-16.9145813f, 168.8341f, -462.713531f, 130.307739f, 214.501587f, -440.263275f);
            float b0 = (-145.372772f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x3 a1 = float2x3(-197.12796f, -386.611176f, -281.021f, -270.26886f, -403.9637f, -269.805725f);
            float b1 = (-169.099854f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x3 a2 = float2x3(299.654236f, -432.755737f, -457.363129f, -13.5195923f, 273.873047f, 185.04248f);
            float b2 = (-71.7509155f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x3 a3 = float2x3(-482.5307f, 511.735f, 230.5075f, 100.27478f, 129.682434f, 321.178772f);
            float b3 = (116.395142f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float2x3 b0 = float2x3(-57.1969f, -382.432526f, 97.82037f, -161.463654f, -458.39563f, -499.617859f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (327.92218f);
            float2x3 b1 = float2x3(367.571228f, 59.786377f, -209.580688f, -62.5804443f, -479.974976f, -49.4945068f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-114.685211f);
            float2x3 b2 = float2x3(109.93927f, -176.284821f, -347.4853f, 85.5409546f, -356.659546f, -104.243561f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-133.5492f);
            float2x3 b3 = float2x3(243.539734f, 13.1412964f, -379.985962f, -41.28122f, 87.91168f, -339.077271f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_wide_wide()
        {
            float2x3 a0 = float2x3(196.84259f, 336.4098f, 251.963745f, 257.655945f, 430.0459f, -62.4196472f);
            float2x3 b0 = float2x3(-465.345032f, -256.1524f, -314.814026f, 364.5667f, 100.21051f, 182.560974f);
            bool2x3 r0 = bool2x3(false, false, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x3 a1 = float2x3(8.839233f, -333.8167f, 164.678833f, -350.9449f, 3.84143066f, 125.409729f);
            float2x3 b1 = float2x3(3.11700439f, -259.430481f, -437.3349f, -456.043732f, -394.255981f, 401.9137f);
            bool2x3 r1 = bool2x3(false, true, false, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x3 a2 = float2x3(-111.129944f, 70.00549f, 448.1983f, -419.987122f, -258.301666f, -34.8322144f);
            float2x3 b2 = float2x3(313.439148f, 121.286682f, -28.0122986f, -282.965881f, 330.0644f, 124.099365f);
            bool2x3 r2 = bool2x3(true, true, false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x3 a3 = float2x3(-69.8594055f, 67.76721f, -139.777283f, 385.434631f, 133.7074f, 506.188354f);
            float2x3 b3 = float2x3(-183.6903f, 373.0608f, 109.750916f, -203.57135f, 45.64868f, -360.952271f);
            bool2x3 r3 = bool2x3(false, true, true, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_wide_scalar()
        {
            float2x3 a0 = float2x3(-132.057312f, -192.465f, -66.8345947f, -379.017517f, -360.2824f, 20.9278564f);
            float b0 = (-156.010223f);
            bool2x3 r0 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x3 a1 = float2x3(-158.240753f, -20.4526062f, 225.2915f, 307.4842f, 274.015259f, 373.549683f);
            float b1 = (437.3459f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x3 a2 = float2x3(398.523682f, -58.0108948f, 109.670105f, -108.85318f, -44.9712524f, 140.426086f);
            float b2 = (105.030151f);
            bool2x3 r2 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x3 a3 = float2x3(-500.0883f, -197.500732f, -7.271515f, -432.9905f, 62.1583252f, -72.25473f);
            float b3 = (172.103333f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float2x3 b0 = float2x3(385.094849f, -123.933472f, 86.37659f, 133.4422f, 161.457947f, 229.754272f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (222.5716f);
            float2x3 b1 = float2x3(315.5312f, -447.203522f, 271.833862f, -393.605316f, 317.486877f, -164.6051f);
            bool2x3 r1 = bool2x3(true, false, true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-282.876038f);
            float2x3 b2 = float2x3(296.979553f, -254.401154f, 365.6156f, -441.984253f, -131.42865f, 442.628967f);
            bool2x3 r2 = bool2x3(true, true, true, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-29.7928467f);
            float2x3 b3 = float2x3(-138.37381f, 9.21698f, -226.73056f, 171.029419f, 376.625244f, -462.5887f);
            bool2x3 r3 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_wide_wide()
        {
            float2x3 a0 = float2x3(483.5014f, 310.8156f, 106.966187f, 295.7353f, 116.957581f, -478.299774f);
            float2x3 b0 = float2x3(-471.398f, -371.9853f, 36.9006958f, -316.7636f, 19.6830444f, 207.309143f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x3 a1 = float2x3(-14.8974f, -33.8174438f, -24.74054f, 319.782654f, -120.158569f, -289.008575f);
            float2x3 b1 = float2x3(362.7975f, 324.95343f, 340.948059f, 25.9860229f, -114.211121f, 240.803467f);
            bool2x3 r1 = bool2x3(false, false, false, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x3 a2 = float2x3(455.85144f, 144.706909f, 63.9320068f, -285.683044f, -502.090729f, -337.194458f);
            float2x3 b2 = float2x3(273.422424f, 325.515747f, 27.3410645f, 64.47955f, 200.948364f, 100.122681f);
            bool2x3 r2 = bool2x3(true, false, true, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x3 a3 = float2x3(474.317322f, -507.1451f, -133.565582f, -443.109131f, -464.34137f, -68.36154f);
            float2x3 b3 = float2x3(-79.00711f, -315.137939f, -122.985443f, -163.7792f, -492.566f, -90.79727f);
            bool2x3 r3 = bool2x3(true, false, false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_wide_scalar()
        {
            float2x3 a0 = float2x3(64.31793f, -397.703461f, 431.8769f, 85.703f, 246.263062f, 197.491577f);
            float b0 = (305.859924f);
            bool2x3 r0 = bool2x3(false, false, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x3 a1 = float2x3(286.199463f, -405.7846f, 171.565369f, -241.807281f, 333.5782f, 370.279175f);
            float b1 = (280.813354f);
            bool2x3 r1 = bool2x3(true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x3 a2 = float2x3(-413.7014f, -353.0313f, 396.645325f, 467.222046f, -240.013428f, 502.915039f);
            float b2 = (-356.592346f);
            bool2x3 r2 = bool2x3(false, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x3 a3 = float2x3(315.4676f, 281.230652f, 428.792175f, 245.153076f, -279.1754f, -453.8631f);
            float b3 = (-259.2897f);
            bool2x3 r3 = bool2x3(true, true, true, true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float2x3 b0 = float2x3(358.099976f, -72.596405f, -232.163788f, -60.7067261f, 75.15662f, 150.883484f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (339.539185f);
            float2x3 b1 = float2x3(-498.196045f, 459.7461f, -227.968719f, 335.862122f, 76.17883f, 296.859924f);
            bool2x3 r1 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (177.48999f);
            float2x3 b2 = float2x3(-281.2012f, 244.722839f, 137.328552f, -385.338257f, 443.163452f, -353.562561f);
            bool2x3 r2 = bool2x3(true, false, true, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (26.04065f);
            float2x3 b3 = float2x3(-331.793945f, -43.6919556f, 20.9494019f, -211.17984f, 227.421692f, -84.7797852f);
            bool2x3 r3 = bool2x3(true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_equal_wide_wide()
        {
            float2x3 a0 = float2x3(-438.523132f, 210.489441f, 4.87731934f, -137.297943f, 156.094116f, -363.924133f);
            float2x3 b0 = float2x3(-474.814148f, 304.371033f, 234.824158f, -390.485443f, -297.175354f, -326.2924f);
            bool2x3 r0 = bool2x3(false, true, true, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x3 a1 = float2x3(-97.94849f, 437.2954f, 458.530273f, -294.064758f, 23.62262f, -34.2840576f);
            float2x3 b1 = float2x3(107.253906f, -413.131073f, 67.09442f, 470.075256f, -84.499115f, 392.784241f);
            bool2x3 r1 = bool2x3(true, false, false, true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x3 a2 = float2x3(149.736511f, -418.8867f, -197.502533f, -88.2055054f, -376.71814f, 341.627136f);
            float2x3 b2 = float2x3(-263.531738f, 369.3009f, -333.3253f, 238.413452f, 486.2426f, 279.6502f);
            bool2x3 r2 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x3 a3 = float2x3(-83.30917f, -107.490723f, 319.466858f, 205.357361f, 345.563721f, 395.3219f);
            float2x3 b3 = float2x3(236.052f, 132.758972f, 66.29474f, 183.002136f, 200.130554f, 339.043823f);
            bool2x3 r3 = bool2x3(true, true, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(193.49585f, 168.915527f, -313.993073f, 81.8269653f, 18.5036011f, -0.3581848f);
            float b0 = (443.850525f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x3 a1 = float2x3(241.361145f, -1.35775757f, -268.899475f, 398.991943f, -471.253082f, -264.9378f);
            float b1 = (-463.8164f);
            bool2x3 r1 = bool2x3(false, false, false, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x3 a2 = float2x3(82.2583f, 424.704041f, 426.482239f, 56.3200073f, -196.2879f, 31.9011841f);
            float b2 = (11.2460327f);
            bool2x3 r2 = bool2x3(false, false, false, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x3 a3 = float2x3(-152.257568f, -37.1048279f, -47.1442261f, 333.623047f, -274.8039f, 358.67627f);
            float b3 = (-437.926453f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float2x3 b0 = float2x3(-75.6883545f, -44.2638855f, 125.864929f, 191.9649f, 13.54303f, -197.051941f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-423.9451f);
            float2x3 b1 = float2x3(-330.0486f, 420.165527f, 105.5473f, 174.821289f, 296.7176f, -469.7004f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (123.267212f);
            float2x3 b2 = float2x3(112.996948f, 495.143372f, -488.6579f, 388.539429f, -493.240784f, 16.45105f);
            bool2x3 r2 = bool2x3(false, true, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-387.651642f);
            float2x3 b3 = float2x3(-229.1773f, -373.01532f, -391.142151f, 90.99414f, -178.396149f, -69.62106f);
            bool2x3 r3 = bool2x3(true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_equal_wide_wide()
        {
            float2x3 a0 = float2x3(-507.9286f, 504.4975f, -385.4345f, -262.323425f, -37.5509338f, -111.595276f);
            float2x3 b0 = float2x3(-81.3465f, 297.666138f, 171.06543f, -431.038055f, -6.85907f, 319.7257f);
            bool2x3 r0 = bool2x3(false, true, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x3 a1 = float2x3(-463.702026f, 387.448853f, 456.9688f, -211.010162f, 182.411377f, -53.59604f);
            float2x3 b1 = float2x3(254.079163f, 396.5724f, 178.8393f, -447.063354f, 288.492676f, 474.889282f);
            bool2x3 r1 = bool2x3(false, false, true, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x3 a2 = float2x3(-309.570221f, -136.022491f, 280.736267f, -96.99588f, -174.059509f, 88.90192f);
            float2x3 b2 = float2x3(-321.750244f, -395.977234f, -158.692474f, 391.4887f, -368.109253f, 89.12378f);
            bool2x3 r2 = bool2x3(true, true, true, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x3 a3 = float2x3(43.81604f, -446.07843f, 16.6455688f, 409.83252f, -191.329865f, 222.9978f);
            float2x3 b3 = float2x3(-510.279327f, -486.9298f, -81.2155457f, 274.2188f, -212.881561f, 288.9953f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(465.152161f, -424.886078f, -209.2211f, 58.7798462f, -302.2691f, 140.12561f);
            float b0 = (-5.599884f);
            bool2x3 r0 = bool2x3(true, false, false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x3 a1 = float2x3(16.3533936f, 393.278076f, -315.701538f, 441.011536f, -509.781555f, -36.9942932f);
            float b1 = (-344.559967f);
            bool2x3 r1 = bool2x3(true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x3 a2 = float2x3(494.8203f, -466.1201f, -123.813751f, 215.651245f, 104.995728f, 314.346f);
            float b2 = (-164.973938f);
            bool2x3 r2 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x3 a3 = float2x3(190.516113f, -23.8364258f, 143.049377f, -264.919983f, -169.702209f, 329.70752f);
            float b3 = (-83.11142f);
            bool2x3 r3 = bool2x3(true, true, true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float2x3 b0 = float2x3(-1.60977173f, 338.615234f, -116.1814f, -332.157318f, -355.97937f, -468.901428f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (38.579895f);
            float2x3 b1 = float2x3(-332.347534f, 2.89013672f, 467.777771f, 121.406372f, -305.023376f, -58.4288025f);
            bool2x3 r1 = bool2x3(true, true, false, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-226.519562f);
            float2x3 b2 = float2x3(-47.0209961f, 305.302673f, -427.401245f, 92.26367f, -497.178528f, -408.625641f);
            bool2x3 r2 = bool2x3(false, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-455.2305f);
            float2x3 b3 = float2x3(396.4261f, -469.2949f, -485.754028f, -182.346191f, -291.545349f, 278.740784f);
            bool2x3 r3 = bool2x3(false, true, true, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_add_wide_wide()
        {
            float2x3 a0 = float2x3(506.129028f, -501.779816f, 420.084778f, -186.032074f, -9.312408f, 328.51178f);
            float2x3 b0 = float2x3(-28.7579956f, -337.135132f, -340.676819f, 152.312012f, 423.66748f, 90.3740845f);
            float2x3 r0 = float2x3(477.371033f, -838.9149f, 79.40796f, -33.7200623f, 414.355072f, 418.885864f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x3 a1 = float2x3(424.344055f, 87.79108f, 462.4137f, -46.17871f, 401.170044f, -454.124146f);
            float2x3 b1 = float2x3(376.18866f, 1.76721191f, -120.185852f, -279.629364f, -344.6671f, 242.839172f);
            float2x3 r1 = float2x3(800.5327f, 89.55829f, 342.227844f, -325.808075f, 56.50293f, -211.284973f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x3 a2 = float2x3(69.19568f, -177.957336f, 299.604126f, 340.704834f, 219.916016f, -321.9084f);
            float2x3 b2 = float2x3(418.593079f, -23.3128052f, -95.0999451f, 147.9281f, 331.0329f, -82.50256f);
            float2x3 r2 = float2x3(487.788757f, -201.270142f, 204.504181f, 488.632935f, 550.9489f, -404.41095f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x3 a3 = float2x3(286.355347f, -333.4195f, -118.932159f, 68.60748f, 23.190918f, -205.577881f);
            float2x3 b3 = float2x3(279.4496f, 342.622742f, -300.358521f, -209.694092f, 446.559448f, -351.9892f);
            float2x3 r3 = float2x3(565.804932f, 9.203247f, -419.29068f, -141.086609f, 469.750366f, -557.5671f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_add_wide_scalar()
        {
            float2x3 a0 = float2x3(-194.514191f, 338.5484f, 246.971375f, 100.510925f, -45.72467f, -478.1113f);
            float b0 = (124.121704f);
            float2x3 r0 = float2x3(-70.39249f, 462.6701f, 371.093079f, 224.632629f, 78.39703f, -353.9896f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x3 a1 = float2x3(30.9161377f, -242.118744f, 82.50134f, 6.79937744f, -484.6998f, -188.265015f);
            float b1 = (60.37433f);
            float2x3 r1 = float2x3(91.29047f, -181.744415f, 142.875671f, 67.1737061f, -424.32547f, -127.890686f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x3 a2 = float2x3(-213.526733f, 189.259949f, 198.533569f, 187.536072f, -424.925659f, 302.102356f);
            float b2 = (-267.7843f);
            float2x3 r2 = float2x3(-481.311035f, -78.52435f, -69.25073f, -80.24823f, -692.709961f, 34.3180542f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x3 a3 = float2x3(300.3991f, -200.161346f, 31.3782349f, 362.522156f, -423.988861f, 432.41333f);
            float b3 = (124.021606f);
            float2x3 r3 = float2x3(424.420715f, -76.13974f, 155.399841f, 486.543762f, -299.967255f, 556.434937f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float2x3 b0 = float2x3(511.362244f, -146.216644f, -106.210419f, -363.450256f, 199.0896f, -27.1083984f);
            float2x3 r0 = float2x3(171.007568f, -486.57132f, -446.5651f, -703.804932f, -141.265076f, -367.463074f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (419.849f);
            float2x3 b1 = float2x3(284.955017f, -164.9242f, -249.190338f, 150.928162f, 298.1751f, -457.1534f);
            float2x3 r1 = float2x3(704.804f, 254.9248f, 170.658661f, 570.777161f, 718.0241f, -37.3044128f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (424.718079f);
            float2x3 b2 = float2x3(-301.857483f, 230.288879f, -423.5876f, -67.06003f, 68.72412f, -164.02243f);
            float2x3 r2 = float2x3(122.860596f, 655.006958f, 1.13049316f, 357.658051f, 493.4422f, 260.695648f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (318.935181f);
            float2x3 b3 = float2x3(7.80456543f, 187.698364f, -3.656952f, -446.083069f, -209.287231f, -38.21289f);
            float2x3 r3 = float2x3(326.739746f, 506.633545f, 315.278229f, -127.147888f, 109.647949f, 280.7223f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_sub_wide_wide()
        {
            float2x3 a0 = float2x3(160.492249f, 11.223938f, 359.200134f, -498.2283f, -355.253632f, -94.53485f);
            float2x3 b0 = float2x3(115.46875f, -130.9823f, 241.540833f, 9.987061f, 419.895142f, 59.12445f);
            float2x3 r0 = float2x3(45.0235f, 142.206238f, 117.6593f, -508.215363f, -775.1488f, -153.6593f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x3 a1 = float2x3(-410.46405f, -401.384644f, 317.706848f, 447.060425f, -489.074158f, -230.008392f);
            float2x3 b1 = float2x3(-402.381653f, -75.37015f, 320.9796f, -73.90875f, -31.4447327f, -389.251953f);
            float2x3 r1 = float2x3(-8.082397f, -326.0145f, -3.272766f, 520.9692f, -457.629425f, 159.243561f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x3 a2 = float2x3(24.8754272f, 366.614441f, -107.374146f, -219.008148f, 473.9076f, 259.63623f);
            float2x3 b2 = float2x3(-375.028839f, 259.182739f, 276.648682f, -453.0692f, -272.576538f, -191.148041f);
            float2x3 r2 = float2x3(399.904266f, 107.4317f, -384.022827f, 234.061066f, 746.484131f, 450.784271f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x3 a3 = float2x3(-360.119629f, 7.80963135f, 437.428467f, -59.1991577f, 418.744324f, 183.142151f);
            float2x3 b3 = float2x3(87.1369f, 430.02478f, 343.6571f, 121.029419f, -354.188171f, 249.052f);
            float2x3 r3 = float2x3(-447.256531f, -422.215149f, 93.77136f, -180.228577f, 772.9325f, -65.90985f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_sub_wide_scalar()
        {
            float2x3 a0 = float2x3(207.389587f, 248.457764f, -384.8239f, -205.344757f, -374.811554f, 191.642029f);
            float b0 = (-36.1124878f);
            float2x3 r0 = float2x3(243.502075f, 284.570251f, -348.711426f, -169.232269f, -338.699066f, 227.754517f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x3 a1 = float2x3(18.8562622f, 480.857971f, 16.3381958f, -366.865448f, -35.5231f, 349.397766f);
            float b1 = (-44.96161f);
            float2x3 r1 = float2x3(63.81787f, 525.8196f, 61.2998047f, -321.903839f, 9.438507f, 394.359375f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x3 a2 = float2x3(439.077271f, 195.024048f, -384.849426f, 189.05188f, 55.6027832f, -54.931488f);
            float b2 = (490.2223f);
            float2x3 r2 = float2x3(-51.14502f, -295.198242f, -875.0717f, -301.1704f, -434.6195f, -545.1538f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x3 a3 = float2x3(53.0880737f, -273.8067f, 256.8872f, 297.173645f, 101.829041f, 136.607971f);
            float b3 = (316.8025f);
            float2x3 r3 = float2x3(-263.714417f, -590.6092f, -59.9152832f, -19.6288452f, -214.97345f, -180.194519f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float2x3 b0 = float2x3(466.4251f, 298.486938f, -300.9501f, 315.38f, -381.092163f, -125.008362f);
            float2x3 r0 = float2x3(-552.43335f, -384.495178f, 214.941864f, -401.388245f, 295.083923f, 39.0001221f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (58.4661865f);
            float2x3 b1 = float2x3(214.7461f, -257.549438f, 480.2246f, -443.355072f, 260.795044f, 29.6819458f);
            float2x3 r1 = float2x3(-156.2799f, 316.015625f, -421.758423f, 501.821259f, -202.328857f, 28.78424f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (139.857727f);
            float2x3 b2 = float2x3(-247.789948f, -248.466217f, 91.44513f, 86.3841553f, 373.8183f, 260.411926f);
            float2x3 r2 = float2x3(387.647675f, 388.323944f, 48.4125977f, 53.47357f, -233.960571f, -120.5542f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (114.353943f);
            float2x3 b3 = float2x3(-464.405457f, -109.741455f, -311.675354f, 107.864014f, -258.795166f, 14.0975342f);
            float2x3 r3 = float2x3(578.7594f, 224.0954f, 426.0293f, 6.489929f, 373.1491f, 100.256409f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mul_wide_wide()
        {
            float2x3 a0 = float2x3(-482.7138f, -407.2935f, 137.700562f, 208.541138f, 194.29657f, -484.242432f);
            float2x3 b0 = float2x3(-236.367889f, 260.7276f, -416.3863f, -364.4956f, -253.147522f, -369.202881f);
            float2x3 r0 = float2x3(114098.047f, -106192.656f, -57336.625f, -76012.33f, -49185.6953f, 178783.7f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x3 a1 = float2x3(183.9873f, -241.33548f, 45.8687744f, 363.3261f, -328.118958f, -471.023071f);
            float2x3 b1 = float2x3(193.547913f, 169.0849f, 201.969666f, 249.456055f, -308.193176f, -385.579651f);
            float2x3 r1 = float2x3(35610.36f, -40806.1836f, 9264.101f, 90633.9f, 101124.023f, 181616.9f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x3 a2 = float2x3(-262.682556f, -379.262756f, -374.090576f, 481.4474f, 104.628052f, 412.935425f);
            float2x3 b2 = float2x3(-183.2796f, 22.2756348f, -265.521423f, -95.67746f, 133.2544f, 148.311462f);
            float2x3 r2 = float2x3(48144.3555f, -8448.318f, 99329.06f, -46063.6641f, 13942.1475f, 61243.06f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x3 a3 = float2x3(477.877258f, 20.3778076f, 291.995972f, -138.488312f, -393.464966f, 9.363098f);
            float2x3 b3 = float2x3(249.284119f, 500.0055f, -19.3315735f, -36.69107f, 30.5238037f, -401.367f);
            float2x3 r3 = float2x3(119127.211f, 10189.0156f, -5644.7417f, 5081.284f, -12010.0479f, -3758.03857f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mul_wide_scalar()
        {
            float2x3 a0 = float2x3(-96.31882f, -277.142273f, -239.93689f, 509.531433f, 255.8581f, 215.7315f);
            float b0 = (-301.2072f);
            float2x3 r0 = float2x3(29011.9219f, 83477.25f, 72270.72f, -153474.547f, -77066.3047f, -64979.8867f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x3 a1 = float2x3(-455.50827f, -338.29248f, 53.7962646f, 243.757324f, 135.354675f, -207.3501f);
            float b1 = (-389.2433f);
            float2x3 r1 = float2x3(177303.531f, 131678.078f, -20939.834f, -94880.9f, -52685.9f, 80709.63f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x3 a2 = float2x3(-383.9396f, 42.6761475f, 260.38385f, 176.867554f, 25.67212f, -290.5006f);
            float b2 = (-31.4252319f);
            float2x3 r2 = float2x3(12065.3916f, -1341.10779f, -8182.623f, -5558.104f, -806.7523f, 9129.049f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x3 a3 = float2x3(207.091f, -208.402008f, 370.945068f, -341.59845f, 10.2703247f, -176.888763f);
            float b3 = (-156.523315f);
            float2x3 r3 = float2x3(-32414.57f, 32619.7734f, -58061.55f, 53468.12f, -1607.54529f, 27687.2148f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float2x3 b0 = float2x3(96.74756f, 492.185364f, -274.054565f, -452.870972f, 420.853333f, 102.182922f);
            float2x3 r0 = float2x3(3621.473f, 18423.5762f, -10258.4629f, -16951.9531f, 15753.4619f, 3824.93066f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-114.948883f);
            float2x3 b1 = float2x3(-351.120056f, -464.664978f, 444.084839f, 447.1053f, 130.829346f, -321.41333f);
            float2x3 r1 = float2x3(40360.86f, 53412.72f, -51047.0547f, -51394.2539f, -15038.6875f, 36946.1f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (445.301331f);
            float2x3 b2 = float2x3(478.2436f, 358.571716f, -144.8901f, -438.893829f, -3.536438f, -471.807556f);
            float2x3 r2 = float2x3(212962.5f, 159672.469f, -64519.7578f, -195440f, -1574.78052f, -210096.531f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-42.5603943f);
            float2x3 b3 = float2x3(119.911072f, 271.900024f, 239.684021f, 487.4414f, -79.18829f, -112.925659f);
            float2x3 r3 = float2x3(-5103.4624f, -11572.1719f, -10201.0469f, -20745.7f, 3370.285f, 4806.16064f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_div_wide_wide()
        {
            float2x3 a0 = float2x3(-353.131439f, -102.799866f, 51.3191528f, -191.871674f, 8.041809f, -128.73764f);
            float2x3 b0 = float2x3(-178.739563f, -302.096283f, -199.405823f, 278.850769f, 502.3376f, -361.484833f);
            float2x3 r0 = float2x3(1.97567582f, 0.34028843f, -0.257360339f, -0.688080132f, 0.0160087738f, 0.356135666f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x3 a1 = float2x3(-136.0596f, -370.471f, -237.69455f, -432.546875f, 200.2655f, 361.4416f);
            float2x3 b1 = float2x3(353.121033f, -38.894928f, -75.76474f, -195.217834f, -405.034f, -394.23f);
            float2x3 r1 = float2x3(-0.385305852f, 9.524919f, 3.1372714f, 2.215714f, -0.4944412f, -0.9168292f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x3 a2 = float2x3(-416.226135f, -450.0192f, -273.497437f, -286.908173f, -314.256042f, 177.762085f);
            float2x3 b2 = float2x3(-375.8277f, -121.245483f, 447.623352f, 338.286255f, -405.5442f, -431.168945f);
            float2x3 r2 = float2x3(1.107492f, 3.71163678f, -0.610999048f, -0.8481225f, 0.7748996f, -0.412279427f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x3 a3 = float2x3(97.6270142f, -68.10727f, -386.450745f, 263.699341f, -297.0271f, -501.777039f);
            float2x3 b3 = float2x3(296.205139f, 437.939819f, 39.2106323f, 331.289734f, -310.619568f, 207.26947f);
            float2x3 r3 = float2x3(0.3295926f, -0.155517414f, -9.855764f, 0.795978f, 0.9562408f, -2.42089224f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_div_wide_scalar()
        {
            float2x3 a0 = float2x3(171.3424f, 0.103393555f, 57.8882446f, -256.130737f, 95.66968f, -290.3869f);
            float b0 = (171.796814f);
            float2x3 r0 = float2x3(0.997355f, 0.000601836247f, 0.3369576f, -1.49089336f, 0.5568769f, -1.69029272f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x3 a1 = float2x3(-127.4487f, 146.466858f, -499.843567f, 58.68634f, -453.2058f, -205.033813f);
            float b1 = (-79.7449f);
            float2x3 r1 = float2x3(1.598205f, -1.83669245f, 6.2680316f, -0.7359259f, 5.68319464f, 2.57112122f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x3 a2 = float2x3(481.738159f, -293.4635f, -158.505585f, -289.5822f, 494.1286f, 203.583435f);
            float b2 = (464.479065f);
            float2x3 r2 = float2x3(1.037158f, -0.6318121f, -0.341254532f, -0.6234559f, 1.063834f, 0.438304871f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x3 a3 = float2x3(180.9704f, 460.844727f, 490.956238f, -280.478058f, -320.243866f, 192.41449f);
            float b3 = (259.1192f);
            float2x3 r3 = float2x3(0.698406f, 1.77850473f, 1.89471185f, -1.08242869f, -1.235894f, 0.742571354f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float2x3 b0 = float2x3(105.589111f, -142.349091f, -288.9489f, 39.644104f, -363.9914f, -149.718231f);
            float2x3 r0 = float2x3(-2.50444865f, 1.85770416f, 0.9151877f, -6.670412f, 0.7265076f, 1.7662679f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-395.729126f);
            float2x3 b1 = float2x3(258.7187f, -9.66626f, 117.725525f, -331.386536f, -509.986023f, 427.896484f);
            float2x3 r1 = float2x3(-1.529573f, 40.93922f, -3.36145568f, 1.19416177f, 0.775960743f, -0.9248244f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (467.617126f);
            float2x3 b2 = float2x3(-407.124634f, 252.690735f, 444.599365f, -88.31329f, 199.955017f, -218.346924f);
            float2x3 r2 = float2x3(-1.14858472f, 1.85055113f, 1.05177188f, -5.29498f, 2.3386116f, -2.14162445f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-13.4171753f);
            float2x3 b3 = float2x3(-296.131073f, 0.561340332f, -289.299316f, 196.218323f, 334.733459f, -282.392731f);
            float2x3 r3 = float2x3(0.0453082323f, -23.9020329f, 0.0463781767f, -0.0683788061f, -0.0400831625f, 0.047512468f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mod_wide_wide()
        {
            float2x3 a0 = float2x3(-388.8125f, 181.681213f, -167.078735f, 432.820129f, -258.438965f, -170.110809f);
            float2x3 b0 = float2x3(436.944153f, 58.9400635f, -201.116241f, 279.289368f, -397.079773f, 377.899963f);
            float2x3 r0 = float2x3(-388.8125f, 4.861023f, -167.078735f, 153.530762f, -258.438965f, -170.110809f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x3 a1 = float2x3(283.3183f, 122.716492f, 335.271f, -503.608521f, 191.022522f, 289.742676f);
            float2x3 b1 = float2x3(174.693848f, -228.176514f, -317.060181f, -417.4801f, -249.975952f, -397.571564f);
            float2x3 r1 = float2x3(108.624451f, 122.716492f, 18.2108154f, -86.12842f, 191.022522f, 289.742676f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x3 a2 = float2x3(-124.033722f, 259.274f, -274.358459f, -140.030792f, 324.577576f, -200.513092f);
            float2x3 b2 = float2x3(-358.745453f, -198.15921f, 208.737122f, -12.1194153f, 25.2714233f, -194.1207f);
            float2x3 r2 = float2x3(-124.033722f, 61.1147766f, -65.62134f, -6.717224f, 21.3204956f, -6.392395f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x3 a3 = float2x3(211.423157f, -51.2722168f, -230.633911f, 99.98938f, 399.18988f, 24.90326f);
            float2x3 b3 = float2x3(-493.8718f, -312.3017f, -216.980591f, 413.570984f, -436.3944f, 3.491272f);
            float2x3 r3 = float2x3(211.423157f, -51.2722168f, -13.65332f, 99.98938f, 399.18988f, 0.464355469f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mod_wide_scalar()
        {
            float2x3 a0 = float2x3(-244.499634f, -211.8193f, -145.926788f, -304.9182f, 155.479492f, -133.907776f);
            float b0 = (39.63495f);
            float2x3 r0 = float2x3(-6.68994141f, -13.6445618f, -27.0219421f, -27.4735718f, 36.574646f, -15.00293f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x3 a1 = float2x3(281.309631f, 335.166138f, 101.706482f, 319.4715f, -285.4023f, -355.846863f);
            float b1 = (-226.535767f);
            float2x3 r1 = float2x3(54.7738647f, 108.630371f, 101.706482f, 92.93573f, -58.8665466f, -129.3111f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x3 a2 = float2x3(259.378f, -284.343567f, -102.683441f, -172.141754f, 206.41687f, -416.713654f);
            float b2 = (-330.871948f);
            float2x3 r2 = float2x3(259.378f, -284.343567f, -102.683441f, -172.141754f, 206.41687f, -85.8417053f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x3 a3 = float2x3(-339.256653f, 132.552917f, 226.944092f, -306.1183f, 115.438477f, 281.882935f);
            float b3 = (435.2975f);
            float2x3 r3 = float2x3(-339.256653f, 132.552917f, 226.944092f, -306.1183f, 115.438477f, 281.882935f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float2x3 b0 = float2x3(-249.7761f, -396.073761f, 386.492065f, 168.939453f, -199.418243f, 261.7517f);
            float2x3 r0 = float2x3(-66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (16.1274414f);
            float2x3 b1 = float2x3(257.668152f, -75.78845f, 170.9563f, -242.858276f, 425.9453f, 303.2724f);
            float2x3 r1 = float2x3(16.1274414f, 16.1274414f, 16.1274414f, 16.1274414f, 16.1274414f, 16.1274414f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (3.033081f);
            float2x3 b2 = float2x3(-505.74353f, 461.957031f, 205.972778f, 270.040649f, -47.4807129f, -150.254486f);
            float2x3 r2 = float2x3(3.033081f, 3.033081f, 3.033081f, 3.033081f, 3.033081f, 3.033081f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (149.499512f);
            float2x3 b3 = float2x3(-220.298035f, 31.1188354f, 400.635681f, 6.23144531f, -39.05075f, -71.9411f);
            float2x3 r3 = float2x3(149.499512f, 25.02417f, 149.499512f, 6.17626953f, 32.34726f, 5.61730957f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_plus()
        {
            float2x3 a0 = float2x3(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f);
            float2x3 r0 = float2x3(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f);
            TestUtils.AreEqual(+a0, r0);

            float2x3 a1 = float2x3(293.742f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f, -170.746521f);
            float2x3 r1 = float2x3(293.742f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f, -170.746521f);
            TestUtils.AreEqual(+a1, r1);

            float2x3 a2 = float2x3(439.5594f, 116.400757f, 421.409668f, -258.596069f, 447.8661f, 124.164368f);
            float2x3 r2 = float2x3(439.5594f, 116.400757f, 421.409668f, -258.596069f, 447.8661f, 124.164368f);
            TestUtils.AreEqual(+a2, r2);

            float2x3 a3 = float2x3(222.172546f, 239.041809f, 498.449524f, -139.382538f, 279.072937f, 108.775818f);
            float2x3 r3 = float2x3(222.172546f, 239.041809f, 498.449524f, -139.382538f, 279.072937f, 108.775818f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_neg()
        {
            float2x3 a0 = float2x3(148.461731f, -467.122681f, 132.04718f, 183.522644f, 473.701f, -407.9911f);
            float2x3 r0 = float2x3(-148.461731f, 467.122681f, -132.04718f, -183.522644f, -473.701f, 407.9911f);
            TestUtils.AreEqual(-a0, r0);

            float2x3 a1 = float2x3(-54.95877f, -299.093384f, -383.014069f, 407.709778f, 168.735474f, 466.441528f);
            float2x3 r1 = float2x3(54.95877f, 299.093384f, 383.014069f, -407.709778f, -168.735474f, -466.441528f);
            TestUtils.AreEqual(-a1, r1);

            float2x3 a2 = float2x3(171.902466f, -78.857605f, 318.69635f, -39.9154053f, 140.340027f, 132.195618f);
            float2x3 r2 = float2x3(-171.902466f, 78.857605f, -318.69635f, 39.9154053f, -140.340027f, -132.195618f);
            TestUtils.AreEqual(-a2, r2);

            float2x3 a3 = float2x3(-505.895264f, -237.056946f, -137.617828f, -245.349976f, 422.521362f, -434.57135f);
            float2x3 r3 = float2x3(505.895264f, 237.056946f, 137.617828f, 245.349976f, -422.521362f, 434.57135f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_prefix_inc()
        {
            float2x3 a0 = float2x3(-139.842072f, -56.7436523f, -381.955322f, 509.796326f, -222.896332f, 210.319885f);
            float2x3 r0 = float2x3(-138.842072f, -55.7436523f, -380.955322f, 510.796326f, -221.896332f, 211.319885f);
            TestUtils.AreEqual(++a0, r0);

            float2x3 a1 = float2x3(-392.7315f, 362.212769f, 401.6148f, 130.90918f, -450.230164f, 243.546936f);
            float2x3 r1 = float2x3(-391.7315f, 363.212769f, 402.6148f, 131.90918f, -449.230164f, 244.546936f);
            TestUtils.AreEqual(++a1, r1);

            float2x3 a2 = float2x3(46.1920166f, 299.1855f, 154.356567f, -281.233276f, 200.706f, 92.95776f);
            float2x3 r2 = float2x3(47.1920166f, 300.1855f, 155.356567f, -280.233276f, 201.706f, 93.95776f);
            TestUtils.AreEqual(++a2, r2);

            float2x3 a3 = float2x3(448.602173f, 18.4990845f, -215.711121f, 471.947266f, 257.0766f, 41.6259155f);
            float2x3 r3 = float2x3(449.602173f, 19.4990845f, -214.711121f, 472.947266f, 258.0766f, 42.6259155f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_postfix_inc()
        {
            float2x3 a0 = float2x3(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f);
            float2x3 r0 = float2x3(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f);
            TestUtils.AreEqual(a0++, r0);

            float2x3 a1 = float2x3(-81.39343f, 167.852112f, 147.94397f, -326.1076f, 41.03357f, 128.5304f);
            float2x3 r1 = float2x3(-81.39343f, 167.852112f, 147.94397f, -326.1076f, 41.03357f, 128.5304f);
            TestUtils.AreEqual(a1++, r1);

            float2x3 a2 = float2x3(73.15558f, -446.229767f, -296.937836f, 267.293823f, 446.2293f, 49.2001953f);
            float2x3 r2 = float2x3(73.15558f, -446.229767f, -296.937836f, 267.293823f, 446.2293f, 49.2001953f);
            TestUtils.AreEqual(a2++, r2);

            float2x3 a3 = float2x3(-326.643127f, 471.647461f, -171.013092f, 310.727356f, -298.917175f, 489.985f);
            float2x3 r3 = float2x3(-326.643127f, 471.647461f, -171.013092f, 310.727356f, -298.917175f, 489.985f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void float2x3_operator_prefix_dec()
        {
            float2x3 a0 = float2x3(123.128723f, 256.84375f, 156.330811f, 461.737427f, 325.867981f, 392.015625f);
            float2x3 r0 = float2x3(122.128723f, 255.84375f, 155.330811f, 460.737427f, 324.867981f, 391.015625f);
            TestUtils.AreEqual(--a0, r0);

            float2x3 a1 = float2x3(187.874146f, 125.109619f, 469.844727f, 45.5366821f, 376.046875f, -363.0755f);
            float2x3 r1 = float2x3(186.874146f, 124.109619f, 468.844727f, 44.5366821f, 375.046875f, -364.0755f);
            TestUtils.AreEqual(--a1, r1);

            float2x3 a2 = float2x3(-22.0289612f, 168.095032f, 168.265625f, -190.284729f, 166.945557f, 183.957947f);
            float2x3 r2 = float2x3(-23.0289612f, 167.095032f, 167.265625f, -191.284729f, 165.945557f, 182.957947f);
            TestUtils.AreEqual(--a2, r2);

            float2x3 a3 = float2x3(485.6947f, 89.5698853f, -267.4298f, 201.756226f, -141.216888f, -217.4841f);
            float2x3 r3 = float2x3(484.6947f, 88.5698853f, -268.4298f, 200.756226f, -142.216888f, -218.4841f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void float2x3_operator_postfix_dec()
        {
            float2x3 a0 = float2x3(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f);
            float2x3 r0 = float2x3(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f);
            TestUtils.AreEqual(a0--, r0);

            float2x3 a1 = float2x3(-63.65515f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f, -200.304291f);
            float2x3 r1 = float2x3(-63.65515f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f, -200.304291f);
            TestUtils.AreEqual(a1--, r1);

            float2x3 a2 = float2x3(-445.026947f, 327.670349f, 48.06018f, -209.667969f, -38.43506f, 283.9416f);
            float2x3 r2 = float2x3(-445.026947f, 327.670349f, 48.06018f, -209.667969f, -38.43506f, 283.9416f);
            TestUtils.AreEqual(a2--, r2);

            float2x3 a3 = float2x3(-94.80209f, -287.2625f, -215.948029f, -407.046356f, 159.233582f, -359.456482f);
            float2x3 r3 = float2x3(-94.80209f, -287.2625f, -215.948029f, -407.046356f, 159.233582f, -359.456482f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
