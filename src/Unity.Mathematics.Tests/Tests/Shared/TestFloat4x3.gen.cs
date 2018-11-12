// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4x3
    {
        [TestCompiler]
        public void float4x3_zero()
        {
            TestUtils.AreEqual(float4x3.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c0.z, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c0.w, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c1.z, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c1.w, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c2.x, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c2.y, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c2.z, 0.0f);
            TestUtils.AreEqual(float4x3.zero.c2.w, 0.0f);
        }

        [TestCompiler]
        public void float4x3_operator_equal_wide_wide()
        {
            float4x3 a0 = float4x3(492.1576f, -495.206329f, 227.457642f, -147.374054f, -222.682f, 64.09375f, -23.8904114f, -16.8197327f, 163.232117f, -165.271f, 470.8777f, -423.942566f);
            float4x3 b0 = float4x3(192.568787f, -235.611023f, -254.043121f, -412.624725f, 471.9048f, -6.47277832f, -339.102356f, 488.187561f, -379.5966f, -308.417f, -82.333374f, -102.921082f);
            bool4x3 r0 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x3 a1 = float4x3(109.6344f, 462.6903f, -335.38147f, 357.2345f, 1.54559326f, -347.388245f, -114.472168f, 435.848633f, 194.2381f, 138.765564f, -467.349152f, 370.43335f);
            float4x3 b1 = float4x3(226.515747f, -356.9013f, -362.912781f, -427.898438f, 466.650146f, -102.799042f, -43.355957f, 85.0456543f, -91.1270447f, 422.192078f, -477.4313f, 1.87701416f);
            bool4x3 r1 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x3 a2 = float4x3(476.708252f, 320.552673f, -498.59198f, 92.41693f, 104.511353f, 166.754578f, -204.733429f, 434.756775f, -397.329651f, 503.981628f, -503.7141f, 90.65973f);
            float4x3 b2 = float4x3(312.580078f, 254.599365f, 352.72583f, 62.4909668f, 119.714783f, -511.058075f, -302.472717f, -371.769226f, -20.007843f, 21.4594727f, -426.0207f, -305.411926f);
            bool4x3 r2 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x3 a3 = float4x3(-303.445251f, 9.34491f, 290.901062f, -147.57193f, 368.082336f, -321.6096f, -171.465424f, -441.306458f, -137.766815f, 304.689575f, 301.889465f, -222.220917f);
            float4x3 b3 = float4x3(261.68335f, 50.00476f, -334.134644f, 75.0656738f, -51.186676f, -135.961548f, -409.364868f, 160.819763f, 102.120789f, 277.813049f, 434.906738f, -15.2891846f);
            bool4x3 r3 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_equal_wide_scalar()
        {
            float4x3 a0 = float4x3(-303.230072f, 451.5263f, -253.655884f, -105.203644f, -500.6911f, -426.192474f, 159.8761f, -59.55838f, -57.4773865f, -182.049744f, 406.513733f, 370.886f);
            float b0 = (123.544556f);
            bool4x3 r0 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x3 a1 = float4x3(-172.035309f, -11.3389893f, 363.938232f, -27.1505737f, -325.976074f, -290.359039f, 180.196838f, -374.128326f, -439.358948f, -126.546082f, -197.26178f, -227.159332f);
            float b1 = (455.400024f);
            bool4x3 r1 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x3 a2 = float4x3(-479.8992f, -495.237335f, -224.517059f, -422.833221f, -450.196259f, -20.10672f, 297.38f, 185.966553f, -102.975983f, -220.597046f, -228.686859f, -333.001282f);
            float b2 = (-439.777679f);
            bool4x3 r2 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x3 a3 = float4x3(434.213f, -239.869781f, 380.93927f, 90.34949f, -361.327942f, -453.599945f, 157.732483f, -491.0462f, 296.614258f, 482.265137f, -305.876984f, -290.1021f);
            float b3 = (406.248718f);
            bool4x3 r3 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float4x3 b0 = float4x3(19.95221f, -185.791992f, 407.8136f, -87.2767f, -206.274689f, 160.503113f, -274.7708f, -2.63153076f, 448.354553f, -410.035248f, 247.329041f, 355.539124f);
            bool4x3 r0 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-298.0667f);
            float4x3 b1 = float4x3(414.1015f, -481.3026f, 196.55072f, 34.6010132f, 113.7616f, -386.453369f, -124.49176f, 243.886658f, -492.6182f, 145.424438f, 421.55072f, -95.40997f);
            bool4x3 r1 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (336.809265f);
            float4x3 b2 = float4x3(209.5838f, 487.4414f, 161.806519f, 149.842468f, 225.724f, -71.21881f, 85.78027f, 192.547241f, -49.88748f, -229.801971f, -103.407349f, 19.21576f);
            bool4x3 r2 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (492.8811f);
            float4x3 b3 = float4x3(140.403137f, -267.536438f, 125.972717f, 478.0005f, 116.144592f, -368.957764f, -225.028656f, 2.723755f, -452.2632f, 87.45654f, 401.306519f, -18.6455383f);
            bool4x3 r3 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_not_equal_wide_wide()
        {
            float4x3 a0 = float4x3(430.842529f, 104.69f, 225.802429f, -310.5702f, -418.619446f, 304.128174f, -509.3268f, -160.538086f, -203.301971f, -505.763245f, 162.17218f, 1.156189f);
            float4x3 b0 = float4x3(210.024719f, -55.20334f, -269.925354f, -234.546722f, 25.91742f, -63.72699f, -484.5537f, -425.3336f, -53.2743835f, 328.1944f, 15.9631348f, 461.7141f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x3 a1 = float4x3(65.66205f, 102.787781f, 172.930054f, 26.6210327f, 235.125977f, 128.541992f, -354.996979f, 334.3595f, -495.832f, 468.307373f, 458.370972f, 299.937317f);
            float4x3 b1 = float4x3(-113.363037f, -240.072968f, 495.119141f, 203.55835f, 340.493469f, -241.9072f, 459.569824f, 213.07373f, -384.782837f, -255.072327f, 477.663452f, -248.036621f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x3 a2 = float4x3(43.1271973f, -354.7135f, -145.2872f, 390.80188f, -303.13147f, 391.134583f, 139.286865f, 104.523193f, 511.2964f, 213.147034f, -101.0957f, 441.6634f);
            float4x3 b2 = float4x3(-407.923462f, -199.788879f, 151.843262f, -97.1206055f, 154.975891f, -172.834534f, 441.5028f, -401.738617f, -411.430176f, -337.820282f, -430.6309f, -150.8718f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x3 a3 = float4x3(124.36615f, 312.026428f, 59.65576f, -508.65683f, 98.699646f, 228.799866f, 337.832642f, -163.154449f, 461.6916f, -450.7757f, -443.564758f, -438.213135f);
            float4x3 b3 = float4x3(-206.837f, 34.95508f, -255.771454f, 99.99866f, -161.175568f, 68.8535156f, -285.590118f, -428.717316f, -286.3374f, 2.02709961f, -4.80599976f, -425.3348f);
            bool4x3 r3 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_not_equal_wide_scalar()
        {
            float4x3 a0 = float4x3(-16.9145813f, 168.8341f, -462.713531f, 130.307739f, 214.501587f, -440.263275f, -197.12796f, -169.099854f, -386.611176f, -281.021f, -270.26886f, -403.9637f);
            float b0 = (-145.372772f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x3 a1 = float4x3(-269.805725f, -71.7509155f, -432.755737f, -457.363129f, -13.5195923f, 273.873047f, 185.04248f, -482.5307f, 116.395142f, 511.735f, 230.5075f, 100.27478f);
            float b1 = (299.654236f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x3 a2 = float4x3(129.682434f, -220.639f, 140.3352f, 369.212341f, 453.811218f, -333.66626f, -373.937744f, 150.204285f, -442.164764f, 372.32f, -95.83798f, 495.5667f);
            float b2 = (321.178772f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x3 a3 = float4x3(-5.3855896f, -459.612732f, 243.309082f, 314.102173f, 96.7449951f, -168.161926f, -71.90546f, 216.608459f, -377.3738f, 142.35498f, -432.272552f, 94.29083f);
            float b3 = (-210.502991f);
            bool4x3 r3 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float4x3 b0 = float4x3(-57.1969f, -382.432526f, 97.82037f, -161.463654f, -458.39563f, -499.617859f, 327.92218f, 367.571228f, 59.786377f, -209.580688f, -62.5804443f, -479.974976f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-49.4945068f);
            float4x3 b1 = float4x3(-114.685211f, 109.93927f, -176.284821f, -347.4853f, 85.5409546f, -356.659546f, -104.243561f, -133.5492f, 243.539734f, 13.1412964f, -379.985962f, -41.28122f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (87.91168f);
            float4x3 b2 = float4x3(-339.077271f, -371.820343f, 333.1443f, 294.811951f, -187.14566f, 220.192261f, -228.182068f, -499.723724f, 97.40588f, 501.60437f, 459.6754f, 158.098145f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (358.4886f);
            float4x3 b3 = float4x3(243.512573f, 336.702942f, 89.953125f, -65.57837f, -159.260162f, 410.588562f, 123.963013f, -239.625122f, -299.42984f, -491.2919f, 207.71167f, 271.5655f);
            bool4x3 r3 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_wide_wide()
        {
            float4x3 a0 = float4x3(196.84259f, 336.4098f, 251.963745f, 257.655945f, 430.0459f, -62.4196472f, 8.839233f, -333.8167f, 164.678833f, -350.9449f, 3.84143066f, 125.409729f);
            float4x3 b0 = float4x3(-465.345032f, -256.1524f, -314.814026f, 364.5667f, 100.21051f, 182.560974f, 3.11700439f, -259.430481f, -437.3349f, -456.043732f, -394.255981f, 401.9137f);
            bool4x3 r0 = bool4x3(false, false, false, true, false, true, false, true, false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x3 a1 = float4x3(-111.129944f, 70.00549f, 448.1983f, -419.987122f, -258.301666f, -34.8322144f, -69.8594055f, 67.76721f, -139.777283f, 385.434631f, 133.7074f, 506.188354f);
            float4x3 b1 = float4x3(313.439148f, 121.286682f, -28.0122986f, -282.965881f, 330.0644f, 124.099365f, -183.6903f, 373.0608f, 109.750916f, -203.57135f, 45.64868f, -360.952271f);
            bool4x3 r1 = bool4x3(true, true, false, true, true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x3 a2 = float4x3(34.44287f, 412.1137f, -84.8097839f, 444.785339f, -78.75473f, 366.977539f, 127.180481f, 428.368469f, 8.197632f, -71.13736f, -474.0508f, 322.4289f);
            float4x3 b2 = float4x3(211.913086f, -313.286377f, -259.661072f, 79.09851f, 446.4961f, 450.524536f, -375.630768f, -53.9418335f, -291.453735f, 190.774841f, 54.0839233f, -163.63089f);
            bool4x3 r2 = bool4x3(true, false, false, false, true, true, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x3 a3 = float4x3(6.897888f, 195.733582f, -267.6906f, -243.7937f, 319.2508f, -425.1562f, 71.87396f, 313.843872f, 397.279053f, -309.145874f, -38.6678467f, -266.1197f);
            float4x3 b3 = float4x3(-212.005646f, 406.0905f, -183.018951f, 355.221375f, -81.0422058f, -275.7148f, 405.299255f, -510.6406f, 398.069275f, -4.35549927f, 129.242676f, -276.146545f);
            bool4x3 r3 = bool4x3(false, true, true, true, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_wide_scalar()
        {
            float4x3 a0 = float4x3(-132.057312f, -192.465f, -66.8345947f, -379.017517f, -360.2824f, 20.9278564f, -158.240753f, 437.3459f, -20.4526062f, 225.2915f, 307.4842f, 274.015259f);
            float b0 = (-156.010223f);
            bool4x3 r0 = bool4x3(false, true, false, true, true, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x3 a1 = float4x3(373.549683f, 105.030151f, -58.0108948f, 109.670105f, -108.85318f, -44.9712524f, 140.426086f, -500.0883f, 172.103333f, -197.500732f, -7.271515f, -432.9905f);
            float b1 = (398.523682f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x3 a2 = float4x3(62.1583252f, -377.852325f, -500.255737f, 149.11499f, 119.880615f, 202.63916f, 274.950684f, 66.41205f, 274.999451f, -149.6358f, 223.758728f, 73.2668457f);
            float b2 = (-72.25473f);
            bool4x3 r2 = bool4x3(false, true, true, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x3 a3 = float4x3(213.094971f, 418.3772f, 421.103577f, -187.16684f, 389.109436f, 401.335449f, -106.285065f, 380.607971f, 385.652832f, 120.659851f, -13.8308716f, -500.1271f);
            float b3 = (322.8595f);
            bool4x3 r3 = bool4x3(true, false, false, true, false, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float4x3 b0 = float4x3(385.094849f, -123.933472f, 86.37659f, 133.4422f, 161.457947f, 229.754272f, 222.5716f, 315.5312f, -447.203522f, 271.833862f, -393.605316f, 317.486877f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-164.6051f);
            float4x3 b1 = float4x3(-282.876038f, 296.979553f, -254.401154f, 365.6156f, -441.984253f, -131.42865f, 442.628967f, -29.7928467f, -138.37381f, 9.21698f, -226.73056f, 171.029419f);
            bool4x3 r1 = bool4x3(false, true, false, true, false, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (376.625244f);
            float4x3 b2 = float4x3(-462.5887f, -142.36731f, -456.253784f, 66.61023f, 169.378784f, 327.4444f, 64.08795f, -153.5039f, 199.380127f, -244.969055f, 472.743835f, -363.7801f);
            bool4x3 r2 = bool4x3(false, false, false, false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-179.487518f);
            float4x3 b3 = float4x3(-83.42514f, 178.886475f, 62.15576f, 409.746765f, -117.163666f, 316.601685f, 285.5163f, 18.6745f, 282.5293f, 132.923767f, -318.215332f, 314.8399f);
            bool4x3 r3 = bool4x3(true, true, true, true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_wide_wide()
        {
            float4x3 a0 = float4x3(483.5014f, 310.8156f, 106.966187f, 295.7353f, 116.957581f, -478.299774f, -14.8974f, -33.8174438f, -24.74054f, 319.782654f, -120.158569f, -289.008575f);
            float4x3 b0 = float4x3(-471.398f, -371.9853f, 36.9006958f, -316.7636f, 19.6830444f, 207.309143f, 362.7975f, 324.95343f, 340.948059f, 25.9860229f, -114.211121f, 240.803467f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x3 a1 = float4x3(455.85144f, 144.706909f, 63.9320068f, -285.683044f, -502.090729f, -337.194458f, 474.317322f, -507.1451f, -133.565582f, -443.109131f, -464.34137f, -68.36154f);
            float4x3 b1 = float4x3(273.422424f, 325.515747f, 27.3410645f, 64.47955f, 200.948364f, 100.122681f, -79.00711f, -315.137939f, -122.985443f, -163.7792f, -492.566f, -90.79727f);
            bool4x3 r1 = bool4x3(true, false, true, false, false, false, true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x3 a2 = float4x3(-185.993011f, -157.8039f, -74.12424f, -94.47116f, 329.610535f, -315.836731f, 404.1938f, 131.304382f, -206.633911f, 197.399841f, 187.991943f, 362.636047f);
            float4x3 b2 = float4x3(-284.901245f, -23.6536865f, 174.93f, 85.7125244f, -441.987823f, 345.543762f, 482.219482f, -422.383484f, -30.7792969f, 296.154236f, 378.059875f, -457.733429f);
            bool4x3 r2 = bool4x3(true, false, false, false, true, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x3 a3 = float4x3(336.0932f, -352.448364f, -183.10199f, 193.144836f, -170.216f, -0.491241455f, -326.855042f, -373.39624f, -216.580475f, 282.5121f, -275.170349f, -207.331757f);
            float4x3 b3 = float4x3(122.920593f, -509.173126f, 386.77063f, 436.41748f, -276.495819f, -163.166779f, 249.970642f, -165.020752f, 89.09302f, 404.305176f, -340.688843f, -103.785095f);
            bool4x3 r3 = bool4x3(true, true, false, false, true, true, false, false, false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_wide_scalar()
        {
            float4x3 a0 = float4x3(64.31793f, -397.703461f, 431.8769f, 85.703f, 246.263062f, 197.491577f, 286.199463f, 280.813354f, -405.7846f, 171.565369f, -241.807281f, 333.5782f);
            float b0 = (305.859924f);
            bool4x3 r0 = bool4x3(false, false, true, false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x3 a1 = float4x3(370.279175f, -356.592346f, -353.0313f, 396.645325f, 467.222046f, -240.013428f, 502.915039f, 315.4676f, -259.2897f, 281.230652f, 428.792175f, 245.153076f);
            float b1 = (-413.7014f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x3 a2 = float4x3(-279.1754f, -124.771545f, -425.652924f, 99.13287f, 355.060547f, -456.439423f, 154.489014f, 405.529724f, -157.7338f, 186.0863f, 249.999084f, -110.096924f);
            float b2 = (-453.8631f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x3 a3 = float4x3(-435.3045f, -254.346558f, -428.987946f, 255.373657f, -309.1123f, 185.501587f, -201.334167f, 23.321167f, -143.9761f, -111.77951f, -356.656616f, -318.313568f);
            float b3 = (72.7520142f);
            bool4x3 r3 = bool4x3(false, false, false, true, false, true, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float4x3 b0 = float4x3(358.099976f, -72.596405f, -232.163788f, -60.7067261f, 75.15662f, 150.883484f, 339.539185f, -498.196045f, 459.7461f, -227.968719f, 335.862122f, 76.17883f);
            bool4x3 r0 = bool4x3(false, false, false, false, false, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (296.859924f);
            float4x3 b1 = float4x3(177.48999f, -281.2012f, 244.722839f, 137.328552f, -385.338257f, 443.163452f, -353.562561f, 26.04065f, -331.793945f, -43.6919556f, 20.9494019f, -211.17984f);
            bool4x3 r1 = bool4x3(true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (227.421692f);
            float4x3 b2 = float4x3(-84.7797852f, -375.1355f, -205.178131f, -197.04715f, -219.634033f, -210.015625f, -266.7737f, 144.7785f, -471.7112f, -155.913177f, 99.72473f, -230.944855f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-338.8689f);
            float4x3 b3 = float4x3(334.068237f, -158.660858f, -315.018219f, -177.19281f, 171.95929f, 198.38916f, 303.678345f, 400.6996f, 351.878662f, -31.7696533f, 386.0733f, -360.348877f);
            bool4x3 r3 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_equal_wide_wide()
        {
            float4x3 a0 = float4x3(-438.523132f, 210.489441f, 4.87731934f, -137.297943f, 156.094116f, -363.924133f, -97.94849f, 437.2954f, 458.530273f, -294.064758f, 23.62262f, -34.2840576f);
            float4x3 b0 = float4x3(-474.814148f, 304.371033f, 234.824158f, -390.485443f, -297.175354f, -326.2924f, 107.253906f, -413.131073f, 67.09442f, 470.075256f, -84.499115f, 392.784241f);
            bool4x3 r0 = bool4x3(false, true, true, false, false, true, true, false, false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x3 a1 = float4x3(149.736511f, -418.8867f, -197.502533f, -88.2055054f, -376.71814f, 341.627136f, -83.30917f, -107.490723f, 319.466858f, 205.357361f, 345.563721f, 395.3219f);
            float4x3 b1 = float4x3(-263.531738f, 369.3009f, -333.3253f, 238.413452f, 486.2426f, 279.6502f, 236.052f, 132.758972f, 66.29474f, 183.002136f, 200.130554f, 339.043823f);
            bool4x3 r1 = bool4x3(false, true, false, true, true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x3 a2 = float4x3(-222.874146f, 439.022034f, -368.075562f, -200.0386f, 71.46991f, -357.365417f, 141.710876f, 319.0171f, 303.030151f, -461.574249f, 277.62677f, 182.1781f);
            float4x3 b2 = float4x3(438.5379f, 145.401855f, 178.163086f, 157.975952f, 329.7052f, -243.590912f, 5.401184f, -22.5805969f, -90.3375854f, -72.19107f, -354.354828f, -289.521729f);
            bool4x3 r2 = bool4x3(true, false, true, true, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x3 a3 = float4x3(-337.414856f, -361.391663f, 222.1435f, -464.7795f, -146.853668f, 80.17505f, -260.3473f, 94.48901f, 174.281189f, -303.8197f, 81.41742f, 503.048157f);
            float4x3 b3 = float4x3(85.17627f, 469.327881f, 294.7138f, 461.605957f, -245.930481f, -124.040436f, 278.392639f, -42.8812561f, -328.348816f, 98.9855957f, -375.899841f, -197.934265f);
            bool4x3 r3 = bool4x3(true, true, true, true, false, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_equal_wide_scalar()
        {
            float4x3 a0 = float4x3(193.49585f, 168.915527f, -313.993073f, 81.8269653f, 18.5036011f, -0.3581848f, 241.361145f, -463.8164f, -1.35775757f, -268.899475f, 398.991943f, -471.253082f);
            float b0 = (443.850525f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x3 a1 = float4x3(-264.9378f, 11.2460327f, 424.704041f, 426.482239f, 56.3200073f, -196.2879f, 31.9011841f, -152.257568f, -437.926453f, -37.1048279f, -47.1442261f, 333.623047f);
            float b1 = (82.2583f);
            bool4x3 r1 = bool4x3(true, true, false, false, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x3 a2 = float4x3(-274.8039f, -260.460571f, 192.309143f, 145.306091f, -466.132965f, -494.267334f, -111.570129f, -139.5412f, -146.589355f, 33.98401f, -445.704468f, -451.0422f);
            float b2 = (358.67627f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x3 a3 = float4x3(-122.039276f, -202.465515f, -76.56488f, 218.032776f, -103.53595f, -283.358429f, -374.761658f, -213.49588f, 477.491821f, -383.370056f, 23.9649658f, -5.960785f);
            float b3 = (83.3277f);
            bool4x3 r3 = bool4x3(true, true, true, false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float4x3 b0 = float4x3(-75.6883545f, -44.2638855f, 125.864929f, 191.9649f, 13.54303f, -197.051941f, -423.9451f, -330.0486f, 420.165527f, 105.5473f, 174.821289f, 296.7176f);
            bool4x3 r0 = bool4x3(false, false, false, false, false, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-469.7004f);
            float4x3 b1 = float4x3(123.267212f, 112.996948f, 495.143372f, -488.6579f, 388.539429f, -493.240784f, 16.45105f, -387.651642f, -229.1773f, -373.01532f, -391.142151f, 90.99414f);
            bool4x3 r1 = bool4x3(true, true, true, false, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-178.396149f);
            float4x3 b2 = float4x3(-69.62106f, 471.790833f, -67.46677f, 45.30536f, -154.6922f, 385.7389f, -431.652954f, -331.673035f, -349.8927f, -114.839142f, -245.217834f, -486.6955f);
            bool4x3 r2 = bool4x3(true, true, true, true, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (391.950928f);
            float4x3 b3 = float4x3(-125.770538f, -229.812286f, 289.449036f, -200.494232f, 281.5927f, 99.90106f, -146.027435f, 124.148376f, 94.3569946f, 93.920105f, -484.924133f, -270.796875f);
            bool4x3 r3 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_equal_wide_wide()
        {
            float4x3 a0 = float4x3(-507.9286f, 504.4975f, -385.4345f, -262.323425f, -37.5509338f, -111.595276f, -463.702026f, 387.448853f, 456.9688f, -211.010162f, 182.411377f, -53.59604f);
            float4x3 b0 = float4x3(-81.3465f, 297.666138f, 171.06543f, -431.038055f, -6.85907f, 319.7257f, 254.079163f, 396.5724f, 178.8393f, -447.063354f, 288.492676f, 474.889282f);
            bool4x3 r0 = bool4x3(false, true, false, true, false, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x3 a1 = float4x3(-309.570221f, -136.022491f, 280.736267f, -96.99588f, -174.059509f, 88.90192f, 43.81604f, -446.07843f, 16.6455688f, 409.83252f, -191.329865f, 222.9978f);
            float4x3 b1 = float4x3(-321.750244f, -395.977234f, -158.692474f, 391.4887f, -368.109253f, 89.12378f, -510.279327f, -486.9298f, -81.2155457f, 274.2188f, -212.881561f, 288.9953f);
            bool4x3 r1 = bool4x3(true, true, true, false, true, false, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x3 a2 = float4x3(404.2884f, 230.603271f, -441.789276f, -86.29306f, 484.249573f, 95.23639f, -204.912109f, -199.774353f, -421.8632f, -18.2147827f, -346.822754f, -159.243652f);
            float4x3 b2 = float4x3(307.73175f, 307.245178f, -199.391785f, -284.421265f, -482.3918f, 448.315735f, -378.3462f, -390.858459f, 8.916016f, 416.407227f, -213.674957f, 455.2481f);
            bool4x3 r2 = bool4x3(true, false, false, true, true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x3 a3 = float4x3(112.917725f, 48.2910156f, 390.660156f, 154.219177f, -32.7480469f, -288.265625f, 122.704285f, 321.277954f, 230.183838f, 116.874268f, -93.515686f, 229.9823f);
            float4x3 b3 = float4x3(-236.080353f, -248.373108f, 184.18512f, 415.31134f, 86.98218f, 485.004578f, 107.758911f, -486.667725f, -138.676788f, 14.2078247f, -382.394165f, -117.008209f);
            bool4x3 r3 = bool4x3(true, true, true, false, false, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_equal_wide_scalar()
        {
            float4x3 a0 = float4x3(465.152161f, -424.886078f, -209.2211f, 58.7798462f, -302.2691f, 140.12561f, 16.3533936f, -344.559967f, 393.278076f, -315.701538f, 441.011536f, -509.781555f);
            float b0 = (-5.599884f);
            bool4x3 r0 = bool4x3(true, false, false, true, false, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x3 a1 = float4x3(-36.9942932f, -164.973938f, -466.1201f, -123.813751f, 215.651245f, 104.995728f, 314.346f, 190.516113f, -83.11142f, -23.8364258f, 143.049377f, -264.919983f);
            float b1 = (494.8203f);
            bool4x3 r1 = bool4x3(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x3 a2 = float4x3(-169.702209f, 359.095825f, -260.4233f, 354.195129f, -111.845337f, 33.309082f, 355.6313f, -435.360565f, -38.3993225f, -93.2957153f, -338.8496f, 436.8958f);
            float b2 = (329.70752f);
            bool4x3 r2 = bool4x3(false, true, false, true, false, false, true, false, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x3 a3 = float4x3(511.084167f, -453.799255f, 170.919f, -182.825745f, -207.516937f, -319.5006f, -240.5086f, 436.3413f, -66.9560547f, 303.320862f, 180.196045f, 337.965149f);
            float b3 = (-277.67453f);
            bool4x3 r3 = bool4x3(true, false, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float4x3 b0 = float4x3(-1.60977173f, 338.615234f, -116.1814f, -332.157318f, -355.97937f, -468.901428f, 38.579895f, -332.347534f, 2.89013672f, 467.777771f, 121.406372f, -305.023376f);
            bool4x3 r0 = bool4x3(true, true, true, true, true, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-58.4288025f);
            float4x3 b1 = float4x3(-226.519562f, -47.0209961f, 305.302673f, -427.401245f, 92.26367f, -497.178528f, -408.625641f, -455.2305f, 396.4261f, -469.2949f, -485.754028f, -182.346191f);
            bool4x3 r1 = bool4x3(true, false, false, true, false, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-291.545349f);
            float4x3 b2 = float4x3(278.740784f, -75.8711243f, 28.9070435f, 287.720154f, 420.509766f, 473.626831f, 181.514526f, -369.202881f, 243.749756f, -244.124146f, -242.993347f, -322.115356f);
            bool4x3 r2 = bool4x3(false, false, false, false, false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (192.974976f);
            float4x3 b3 = float4x3(-54.7255554f, -166.000824f, 244.293457f, 438.2494f, -162.692841f, 37.1853638f, -506.667358f, -205.163086f, 368.389954f, -35.45996f, -20.9164429f, 9.041382f);
            bool4x3 r3 = bool4x3(true, true, false, false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_add_wide_wide()
        {
            float4x3 a0 = float4x3(506.129028f, -501.779816f, 420.084778f, -186.032074f, -9.312408f, 328.51178f, 424.344055f, 87.79108f, 462.4137f, -46.17871f, 401.170044f, -454.124146f);
            float4x3 b0 = float4x3(-28.7579956f, -337.135132f, -340.676819f, 152.312012f, 423.66748f, 90.3740845f, 376.18866f, 1.76721191f, -120.185852f, -279.629364f, -344.6671f, 242.839172f);
            float4x3 r0 = float4x3(477.371033f, -838.9149f, 79.40796f, -33.7200623f, 414.355072f, 418.885864f, 800.5327f, 89.55829f, 342.227844f, -325.808075f, 56.50293f, -211.284973f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x3 a1 = float4x3(69.19568f, -177.957336f, 299.604126f, 340.704834f, 219.916016f, -321.9084f, 286.355347f, -333.4195f, -118.932159f, 68.60748f, 23.190918f, -205.577881f);
            float4x3 b1 = float4x3(418.593079f, -23.3128052f, -95.0999451f, 147.9281f, 331.0329f, -82.50256f, 279.4496f, 342.622742f, -300.358521f, -209.694092f, 446.559448f, -351.9892f);
            float4x3 r1 = float4x3(487.788757f, -201.270142f, 204.504181f, 488.632935f, 550.9489f, -404.41095f, 565.804932f, 9.203247f, -419.29068f, -141.086609f, 469.750366f, -557.5671f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x3 a2 = float4x3(11.5214233f, -340.795074f, -68.93118f, 304.8532f, -86.63385f, 105.669128f, 349.280518f, 364.7079f, -429.0374f, 382.458069f, 186.097046f, 227.411865f);
            float4x3 b2 = float4x3(-263.12384f, -252.458557f, 289.825378f, 338.796143f, -232.619019f, -510.50824f, 349.280762f, -426.212463f, -331.416321f, -418.6888f, -341.70636f, -329.0359f);
            float4x3 r2 = float4x3(-251.602417f, -593.253662f, 220.8942f, 643.649353f, -319.252869f, -404.8391f, 698.5613f, -61.5045776f, -760.453735f, -36.2307434f, -155.609314f, -101.624023f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x3 a3 = float4x3(-298.766357f, 351.3028f, 98.7254f, -292.351685f, 112.1709f, 477.165771f, -266.304871f, -295.1407f, -485.820374f, -507.8687f, -338.2196f, 505.342163f);
            float4x3 b3 = float4x3(123.198547f, 189.528564f, 267.569946f, 134.636292f, -337.96814f, 50.7280273f, 81.16345f, 442.0907f, -148.704529f, 6.974365f, -334.911255f, 43.78711f);
            float4x3 r3 = float4x3(-175.56781f, 540.83136f, 366.295349f, -157.7154f, -225.797241f, 527.8938f, -185.141418f, 146.950012f, -634.5249f, -500.894348f, -673.130859f, 549.1293f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_add_wide_scalar()
        {
            float4x3 a0 = float4x3(-194.514191f, 338.5484f, 246.971375f, 100.510925f, -45.72467f, -478.1113f, 30.9161377f, 60.37433f, -242.118744f, 82.50134f, 6.79937744f, -484.6998f);
            float b0 = (124.121704f);
            float4x3 r0 = float4x3(-70.39249f, 462.6701f, 371.093079f, 224.632629f, 78.39703f, -353.9896f, 155.037842f, 184.496033f, -117.99704f, 206.623047f, 130.921082f, -360.5781f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x3 a1 = float4x3(-188.265015f, -267.7843f, 189.259949f, 198.533569f, 187.536072f, -424.925659f, 302.102356f, 300.3991f, 124.021606f, -200.161346f, 31.3782349f, 362.522156f);
            float b1 = (-213.526733f);
            float4x3 r1 = float4x3(-401.791748f, -481.311035f, -24.2667847f, -14.9931641f, -25.9906616f, -638.4524f, 88.57562f, 86.8723755f, -89.50513f, -413.68808f, -182.1485f, 148.995422f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x3 a2 = float4x3(-423.988861f, 374.211426f, -465.6995f, -311.04303f, 84.91901f, -432.442444f, 235.750671f, -472.637756f, -257.577759f, 186.120728f, -170.298218f, -115.272491f);
            float b2 = (432.41333f);
            float4x3 r2 = float4x3(8.424469f, 806.624756f, -33.2861633f, 121.3703f, 517.332336f, -0.02911377f, 668.164f, -40.2244263f, 174.835571f, 618.534058f, 262.1151f, 317.140839f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x3 a3 = float4x3(-101.168823f, 246.549255f, -397.5346f, -199.04837f, 20.585022f, 207.323853f, 197.935181f, -201.540558f, -106.638672f, -179.382233f, 203.817078f, -364.820953f);
            float b3 = (257.775146f);
            float4x3 r3 = float4x3(156.606323f, 504.3244f, -139.75946f, 58.7267761f, 278.360168f, 465.099f, 455.710327f, 56.23459f, 151.136475f, 78.3929138f, 461.592224f, -107.045807f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float4x3 b0 = float4x3(511.362244f, -146.216644f, -106.210419f, -363.450256f, 199.0896f, -27.1083984f, 419.849f, 284.955017f, -164.9242f, -249.190338f, 150.928162f, 298.1751f);
            float4x3 r0 = float4x3(171.007568f, -486.57132f, -446.5651f, -703.804932f, -141.265076f, -367.463074f, 79.49432f, -55.39966f, -505.27887f, -589.545044f, -189.426514f, -42.1795654f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-457.1534f);
            float4x3 b1 = float4x3(424.718079f, -301.857483f, 230.288879f, -423.5876f, -67.06003f, 68.72412f, -164.02243f, 318.935181f, 7.80456543f, 187.698364f, -3.656952f, -446.083069f);
            float4x3 r1 = float4x3(-32.4353333f, -759.010864f, -226.864532f, -880.740967f, -524.21344f, -388.4293f, -621.175842f, -138.218231f, -449.348846f, -269.455048f, -460.810364f, -903.23645f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-209.287231f);
            float4x3 b2 = float4x3(-38.21289f, -346.257172f, 465.607422f, -192.185944f, 278.6938f, 381.978455f, 481.243652f, -97.22815f, -455.513733f, 501.834961f, 358.7066f, 430.699768f);
            float4x3 r2 = float4x3(-247.500122f, -555.544434f, 256.3202f, -401.473175f, 69.4065552f, 172.691223f, 271.956421f, -306.515381f, -664.800964f, 292.547729f, 149.419373f, 221.412537f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (256.987183f);
            float4x3 b3 = float4x3(207.651672f, -376.965179f, -428.085327f, -373.49353f, -468.89328f, -467.658447f, 297.484924f, -506.89978f, -233.358459f, 434.558777f, -387.3152f, 171.590271f);
            float4x3 r3 = float4x3(464.638855f, -119.978f, -171.098145f, -116.506348f, -211.9061f, -210.671265f, 554.4721f, -249.9126f, 23.6287231f, 691.545959f, -130.328f, 428.577454f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_sub_wide_wide()
        {
            float4x3 a0 = float4x3(160.492249f, 11.223938f, 359.200134f, -498.2283f, -355.253632f, -94.53485f, -410.46405f, -401.384644f, 317.706848f, 447.060425f, -489.074158f, -230.008392f);
            float4x3 b0 = float4x3(115.46875f, -130.9823f, 241.540833f, 9.987061f, 419.895142f, 59.12445f, -402.381653f, -75.37015f, 320.9796f, -73.90875f, -31.4447327f, -389.251953f);
            float4x3 r0 = float4x3(45.0235f, 142.206238f, 117.6593f, -508.215363f, -775.1488f, -153.6593f, -8.082397f, -326.0145f, -3.272766f, 520.9692f, -457.629425f, 159.243561f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x3 a1 = float4x3(24.8754272f, 366.614441f, -107.374146f, -219.008148f, 473.9076f, 259.63623f, -360.119629f, 7.80963135f, 437.428467f, -59.1991577f, 418.744324f, 183.142151f);
            float4x3 b1 = float4x3(-375.028839f, 259.182739f, 276.648682f, -453.0692f, -272.576538f, -191.148041f, 87.1369f, 430.02478f, 343.6571f, 121.029419f, -354.188171f, 249.052f);
            float4x3 r1 = float4x3(399.904266f, 107.4317f, -384.022827f, 234.061066f, 746.484131f, 450.784271f, -447.256531f, -422.215149f, 93.77136f, -180.228577f, 772.9325f, -65.90985f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x3 a2 = float4x3(271.230347f, 496.208557f, 165.354919f, -227.403656f, -166.522858f, 356.142273f, 386.9264f, -394.638763f, 126.903259f, 97.21692f, -150.017853f, -227.250519f);
            float4x3 b2 = float4x3(-2.22543335f, 22.4472656f, 478.112976f, -320.063f, -111.524109f, 222.228943f, -245.411072f, -119.902283f, -153.465668f, 374.1125f, 301.763428f, -281.430054f);
            float4x3 r2 = float4x3(273.45578f, 473.7613f, -312.758057f, 92.65933f, -54.99875f, 133.91333f, 632.337463f, -274.736481f, 280.368927f, -276.895569f, -451.781281f, 54.1795349f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x3 a3 = float4x3(-198.830017f, 0.662780762f, -484.245575f, -295.996277f, -46.17099f, 499.9524f, 292.440125f, -106.424133f, 466.827148f, 487.374817f, 242.994629f, -468.901581f);
            float4x3 b3 = float4x3(-494.964355f, -320.731262f, 160.962219f, -132.9364f, -394.437531f, 406.851257f, 270.544617f, 507.794617f, 67.69922f, 263.40448f, 297.5807f, 170.839539f);
            float4x3 r3 = float4x3(296.134338f, 321.394043f, -645.207764f, -163.059875f, 348.266541f, 93.1011353f, 21.8955078f, -614.21875f, 399.12793f, 223.970337f, -54.58606f, -639.7411f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_sub_wide_scalar()
        {
            float4x3 a0 = float4x3(207.389587f, 248.457764f, -384.8239f, -205.344757f, -374.811554f, 191.642029f, 18.8562622f, -44.96161f, 480.857971f, 16.3381958f, -366.865448f, -35.5231f);
            float b0 = (-36.1124878f);
            float4x3 r0 = float4x3(243.502075f, 284.570251f, -348.711426f, -169.232269f, -338.699066f, 227.754517f, 54.96875f, -8.849121f, 516.970459f, 52.4506836f, -330.75296f, 0.589386f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x3 a1 = float4x3(349.397766f, 490.2223f, 195.024048f, -384.849426f, 189.05188f, 55.6027832f, -54.931488f, 53.0880737f, 316.8025f, -273.8067f, 256.8872f, 297.173645f);
            float b1 = (439.077271f);
            float4x3 r1 = float4x3(-89.6795044f, 51.14502f, -244.053223f, -823.9267f, -250.025391f, -383.4745f, -494.008759f, -385.9892f, -122.27478f, -712.884f, -182.190063f, -141.903625f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x3 a2 = float4x3(101.829041f, -19.7322083f, 336.589722f, -51.8765564f, 317.345764f, -467.055939f, -50.1670532f, 477.804565f, -60.82193f, 0.4111328f, 46.66095f, -19.241394f);
            float b2 = (136.607971f);
            float4x3 r2 = float4x3(-34.77893f, -156.340179f, 199.98175f, -188.484528f, 180.7378f, -603.66394f, -186.775024f, 341.1966f, -197.4299f, -136.196838f, -89.94702f, -155.849365f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x3 a3 = float4x3(396.809753f, -334.274231f, -198.077148f, -239.200623f, -339.6812f, -14.5144348f, 219.99707f, -180.260681f, -438.8906f, 186.35553f, -365.066772f, -478.801239f);
            float b3 = (69.5905151f);
            float4x3 r3 = float4x3(327.219238f, -403.864746f, -267.667664f, -308.791138f, -409.271729f, -84.10495f, 150.406555f, -249.8512f, -508.4811f, 116.765015f, -434.6573f, -548.3917f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float4x3 b0 = float4x3(466.4251f, 298.486938f, -300.9501f, 315.38f, -381.092163f, -125.008362f, 58.4661865f, 214.7461f, -257.549438f, 480.2246f, -443.355072f, 260.795044f);
            float4x3 r0 = float4x3(-552.43335f, -384.495178f, 214.941864f, -401.388245f, 295.083923f, 39.0001221f, -144.474426f, -300.754333f, 171.5412f, -566.232849f, 357.346832f, -346.803284f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (29.6819458f);
            float4x3 b1 = float4x3(139.857727f, -247.789948f, -248.466217f, 91.44513f, 86.3841553f, 373.8183f, 260.411926f, 114.353943f, -464.405457f, -109.741455f, -311.675354f, 107.864014f);
            float4x3 r1 = float4x3(-110.175781f, 277.4719f, 278.148163f, -61.7631836f, -56.70221f, -344.136353f, -230.72998f, -84.672f, 494.0874f, 139.4234f, 341.3573f, -78.18207f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-258.795166f);
            float4x3 b2 = float4x3(14.0975342f, -461.970184f, 30.3108521f, 63.70111f, -462.676758f, 39.75946f, 47.99817f, -177.6193f, 202.477051f, -289.3088f, -459.9254f, 248.386658f);
            float4x3 r2 = float4x3(-272.8927f, 203.175018f, -289.106018f, -322.496277f, 203.881592f, -298.554626f, -306.793335f, -81.17587f, -461.272217f, 30.5136414f, 201.130249f, -507.181824f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (85.32971f);
            float4x3 b3 = float4x3(-73.37479f, -510.652f, 426.963257f, 239.59021f, 477.852356f, 256.0136f, 338.620361f, -483.8312f, 330.3922f, -263.4182f, 123.92804f, -269.115967f);
            float4x3 r3 = float4x3(158.7045f, 595.9817f, -341.633545f, -154.2605f, -392.522644f, -170.6839f, -253.290649f, 569.1609f, -245.0625f, 348.747925f, -38.5983276f, 354.445679f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mul_wide_wide()
        {
            float4x3 a0 = float4x3(-482.7138f, -407.2935f, 137.700562f, 208.541138f, 194.29657f, -484.242432f, 183.9873f, -241.33548f, 45.8687744f, 363.3261f, -328.118958f, -471.023071f);
            float4x3 b0 = float4x3(-236.367889f, 260.7276f, -416.3863f, -364.4956f, -253.147522f, -369.202881f, 193.547913f, 169.0849f, 201.969666f, 249.456055f, -308.193176f, -385.579651f);
            float4x3 r0 = float4x3(114098.047f, -106192.656f, -57336.625f, -76012.33f, -49185.6953f, 178783.7f, 35610.36f, -40806.1836f, 9264.101f, 90633.9f, 101124.023f, 181616.9f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x3 a1 = float4x3(-262.682556f, -379.262756f, -374.090576f, 481.4474f, 104.628052f, 412.935425f, 477.877258f, 20.3778076f, 291.995972f, -138.488312f, -393.464966f, 9.363098f);
            float4x3 b1 = float4x3(-183.2796f, 22.2756348f, -265.521423f, -95.67746f, 133.2544f, 148.311462f, 249.284119f, 500.0055f, -19.3315735f, -36.69107f, 30.5238037f, -401.367f);
            float4x3 r1 = float4x3(48144.3555f, -8448.318f, 99329.06f, -46063.6641f, 13942.1475f, 61243.06f, 119127.211f, 10189.0156f, -5644.7417f, 5081.284f, -12010.0479f, -3758.03857f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x3 a2 = float4x3(-131.942291f, 364.449646f, 390.615967f, 418.797974f, -277.3448f, 11.4101563f, 474.876465f, -502.405029f, -222.59491f, 38.1690674f, 292.6125f, 203.2077f);
            float4x3 b2 = float4x3(3.43725586f, 257.24176f, -290.971924f, 337.47937f, 490.286133f, -191.0198f, -325.7345f, -52.1819763f, 123.435059f, -461.267059f, 122.353088f, 308.584656f);
            float4x3 r2 = float4x3(-453.5194f, 93751.67f, -113658.281f, 141335.672f, -135978.3f, -2179.566f, -154683.641f, 26216.4883f, -27476.0156f, -17606.1328f, 35802.043f, 62706.7773f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x3 a3 = float4x3(-330.408142f, 469.460144f, 342.2951f, -504.114655f, 319.3573f, -357.782074f, -117.9711f, 25.706543f, 226.456421f, -86.34372f, -274.126038f, -486.870972f);
            float4x3 b3 = float4x3(375.320618f, 203.212646f, 77.66797f, 218.793579f, -489.895752f, 134.472168f, -287.794373f, -116.399994f, -436.543976f, 499.591064f, -300.602356f, 105.730469f);
            float4x3 r3 = float4x3(-124008.984f, 95400.24f, 26585.3652f, -110297.047f, -156451.781f, -48111.73f, 33951.418f, -2992.24146f, -98858.19f, -43136.55f, 82402.93f, -51477.0977f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mul_wide_scalar()
        {
            float4x3 a0 = float4x3(-96.31882f, -277.142273f, -239.93689f, 509.531433f, 255.8581f, 215.7315f, -455.50827f, -389.2433f, -338.29248f, 53.7962646f, 243.757324f, 135.354675f);
            float b0 = (-301.2072f);
            float4x3 r0 = float4x3(29011.9219f, 83477.25f, 72270.72f, -153474.547f, -77066.3047f, -64979.8867f, 137202.375f, 117242.883f, 101896.133f, -16203.8232f, -73421.46f, -40769.8047f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x3 a1 = float4x3(-207.3501f, -31.4252319f, 42.6761475f, 260.38385f, 176.867554f, 25.67212f, -290.5006f, 207.091f, -156.523315f, -208.402008f, 370.945068f, -341.59845f);
            float b1 = (-383.9396f);
            float4x3 r1 = float4x3(79609.9141f, 12065.3916f, -16385.0625f, -99971.67f, -67906.46f, -9856.543f, 111534.688f, -79510.44f, 60095.5f, 80013.78f, -142420.5f, 131153.172f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x3 a2 = float4x3(10.2703247f, -61.0061035f, 186.279785f, -487.652222f, -129.376831f, -317.7163f, -207.62735f, 388.8714f, -233.335327f, 128.415527f, 510.389526f, 267.576355f);
            float b2 = (-176.888763f);
            float4x3 r2 = float4x3(-1816.70508f, 10791.2939f, -32950.8f, 86260.1953f, 22885.3086f, 56200.4453f, 36726.9453f, -68786.9844f, 41274.4f, -22715.2637f, -90282.17f, -47331.25f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x3 a3 = float4x3(-309.209656f, -189.569519f, 233.209229f, -331.086975f, -98.6447754f, -214.181f, -87.88077f, -493.165741f, -407.306061f, -411.3714f, 477.935669f, 364.748535f);
            float b3 = (-36.48297f);
            float4x3 r3 = float4x3(11280.8867f, 6916.059f, -8508.166f, 12079.0361f, 3598.85449f, 7813.95947f, 3206.15161f, 17992.1523f, 14859.7354f, 15008.0508f, -17436.5137f, -13307.11f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float4x3 b0 = float4x3(96.74756f, 492.185364f, -274.054565f, -452.870972f, 420.853333f, 102.182922f, -114.948883f, -351.120056f, -464.664978f, 444.084839f, 447.1053f, 130.829346f);
            float4x3 r0 = float4x3(3621.473f, 18423.5762f, -10258.4629f, -16951.9531f, 15753.4619f, 3824.93066f, -4302.78857f, -13143.1924f, -17393.4277f, 16623.0684f, 16736.13f, 4897.229f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-321.41333f);
            float4x3 b1 = float4x3(445.301331f, 478.2436f, 358.571716f, -144.8901f, -438.893829f, -3.536438f, -471.807556f, -42.5603943f, 119.911072f, 271.900024f, 239.684021f, 487.4414f);
            float4x3 r1 = float4x3(-143125.781f, -153713.859f, -115249.727f, 46569.6133f, 141066.328f, 1136.65833f, 151645.234f, 13679.4785f, -38541.0156f, -87392.29f, -77037.64f, -156670.172f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-79.18829f);
            float4x3 b2 = float4x3(-112.925659f, 161.370056f, 459.759155f, -337.195984f, -276.834534f, 469.723877f, -274.565155f, 506.7859f, 65.88257f, 495.855652f, -347.2796f, -343.606049f);
            float4x3 r2 = float4x3(8942.391f, -12778.6191f, -36407.543f, 26701.9746f, 21922.0547f, -37196.6328f, 21742.3457f, -40131.5078f, -5217.128f, -39265.96f, 27500.4785f, 27209.5762f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-183.7038f);
            float4x3 b3 = float4x3(460.264771f, 437.513245f, -324.557251f, -112.287781f, 273.135437f, -283.093658f, 1.880249f, -310.8167f, 326.0122f, 243.64325f, 78.17932f, -308.664f);
            float4x3 r3 = float4x3(-84552.38f, -80372.84f, 59622.4f, 20627.6914f, -50176.0156f, 52005.38f, -345.408875f, 57098.21f, -59889.68f, -44758.19f, -14361.8379f, 56702.75f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_div_wide_wide()
        {
            float4x3 a0 = float4x3(-353.131439f, -102.799866f, 51.3191528f, -191.871674f, 8.041809f, -128.73764f, -136.0596f, -370.471f, -237.69455f, -432.546875f, 200.2655f, 361.4416f);
            float4x3 b0 = float4x3(-178.739563f, -302.096283f, -199.405823f, 278.850769f, 502.3376f, -361.484833f, 353.121033f, -38.894928f, -75.76474f, -195.217834f, -405.034f, -394.23f);
            float4x3 r0 = float4x3(1.97567582f, 0.34028843f, -0.257360339f, -0.688080132f, 0.0160087738f, 0.356135666f, -0.385305852f, 9.524919f, 3.1372714f, 2.215714f, -0.4944412f, -0.9168292f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x3 a1 = float4x3(-416.226135f, -450.0192f, -273.497437f, -286.908173f, -314.256042f, 177.762085f, 97.6270142f, -68.10727f, -386.450745f, 263.699341f, -297.0271f, -501.777039f);
            float4x3 b1 = float4x3(-375.8277f, -121.245483f, 447.623352f, 338.286255f, -405.5442f, -431.168945f, 296.205139f, 437.939819f, 39.2106323f, 331.289734f, -310.619568f, 207.26947f);
            float4x3 r1 = float4x3(1.107492f, 3.71163678f, -0.610999048f, -0.8481225f, 0.7748996f, -0.412279427f, 0.3295926f, -0.155517414f, -9.855764f, 0.795978f, 0.9562408f, -2.42089224f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x3 a2 = float4x3(-263.40686f, -451.080841f, -416.34552f, -315.278748f, -28.1811218f, -397.870148f, -261.386658f, 40.3482056f, 277.245728f, 464.77124f, -336.641052f, 375.4781f);
            float4x3 b2 = float4x3(-223.293f, -480.0914f, 448.675964f, -460.097443f, -220.569855f, -84.85315f, 441.373779f, 72.41846f, 44.9760742f, -242.515381f, -451.302063f, -21.8996887f);
            float4x3 r2 = float4x3(1.17964673f, 0.9395729f, -0.9279426f, 0.6852434f, 0.127765059f, 4.688926f, -0.592211545f, 0.557153642f, 6.164294f, -1.91646087f, 0.7459329f, -17.14536f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x3 a3 = float4x3(504.342529f, -320.7671f, -156.733337f, 414.797058f, -386.0507f, -369.838623f, 386.704224f, 242.631836f, 421.7345f, 109.012207f, 182.075256f, 187.326416f);
            float4x3 b3 = float4x3(-358.486664f, -350.945129f, -481.848145f, 406.393433f, -145.288666f, 461.795532f, -318.816772f, -250.932f, 125.859558f, -193.803162f, -495.25412f, -315.824554f);
            float4x3 r3 = float4x3(-1.40686548f, 0.9140092f, 0.3252754f, 1.02067852f, 2.65712881f, -0.800870955f, -1.21293569f, -0.966922641f, 3.35083413f, -0.562489331f, -0.367640078f, -0.5931344f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_div_wide_scalar()
        {
            float4x3 a0 = float4x3(171.3424f, 0.103393555f, 57.8882446f, -256.130737f, 95.66968f, -290.3869f, -127.4487f, -79.7449f, 146.466858f, -499.843567f, 58.68634f, -453.2058f);
            float b0 = (171.796814f);
            float4x3 r0 = float4x3(0.997355f, 0.000601836247f, 0.3369576f, -1.49089336f, 0.5568769f, -1.69029272f, -0.7418572f, -0.4641815f, 0.8525586f, -2.90950418f, 0.3416032f, -2.63803387f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x3 a1 = float4x3(-205.033813f, 464.479065f, -293.4635f, -158.505585f, -289.5822f, 494.1286f, 203.583435f, 180.9704f, 259.1192f, 460.844727f, 490.956238f, -280.478058f);
            float b1 = (481.738159f);
            float4x3 r1 = float4x3(-0.425612569f, 0.9641733f, -0.609176338f, -0.3290285f, -0.6011195f, 1.02572024f, 0.422601849f, 0.375661343f, 0.5378839f, 0.9566291f, 1.019135f, -0.582221f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x3 a2 = float4x3(-320.243866f, 264.800842f, 226.852966f, -192.235687f, 460.9765f, -437.8922f, -413.232727f, 249.471863f, 313.035034f, 216.785583f, 383.7389f, 82.0233154f);
            float b2 = (192.41449f);
            float4x3 r2 = float4x3(-1.66434383f, 1.37620008f, 1.17898071f, -0.999070764f, 2.39574742f, -2.27577567f, -2.14761758f, 1.2965337f, 1.62687874f, 1.12665939f, 1.9943347f, 0.4262845f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x3 a3 = float4x3(189.574646f, -391.92218f, 121.280579f, 417.901733f, -133.262878f, -428.7424f, -188.531891f, 356.259521f, 181.969f, -140.890472f, 474.082642f, -451.357727f);
            float b3 = (314.503845f);
            float4x3 r3 = float4x3(0.6027737f, -1.24616027f, 0.3856251f, 1.32876515f, -0.423724174f, -1.36323416f, -0.599458158f, 1.13276684f, 0.5785907f, -0.447976947f, 1.50739861f, -1.43514216f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float4x3 b0 = float4x3(105.589111f, -142.349091f, -288.9489f, 39.644104f, -363.9914f, -149.718231f, -395.729126f, 258.7187f, -9.66626f, 117.725525f, -331.386536f, -509.986023f);
            float4x3 r0 = float4x3(-2.50444865f, 1.85770416f, 0.9151877f, -6.670412f, 0.7265076f, 1.7662679f, 0.6682412f, -1.02212369f, 27.3572731f, -2.246263f, 0.797988057f, 0.518528938f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (427.896484f);
            float4x3 b1 = float4x3(467.617126f, -407.124634f, 252.690735f, 444.599365f, -88.31329f, 199.955017f, -218.346924f, -13.4171753f, -296.131073f, 0.561340332f, -289.299316f, 196.218323f);
            float4x3 r1 = float4x3(0.915057361f, -1.05102086f, 1.69336045f, 0.9624316f, -4.84521055f, 2.13996363f, -1.95970929f, -31.8916969f, -1.44495642f, 762.276367f, -1.47907877f, 2.18071628f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (334.733459f);
            float4x3 b2 = float4x3(-282.392731f, -479.5036f, -473.439453f, 105.050781f, -287.6313f, 77.29932f, -210.894379f, -184.068237f, -315.148438f, 87.86688f, 101.590515f, 345.9364f);
            float4x3 r2 = float4x3(-1.18534732f, -0.6980833f, -0.7070249f, 3.1863966f, -1.16375887f, 4.33035469f, -1.587209f, -1.81852913f, -1.06214535f, 3.809552f, 3.29492831f, 0.9676156f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-146.318115f);
            float4x3 b3 = float4x3(479.999939f, -172.67688f, -178.013641f, 361.760437f, 349.376953f, -398.686127f, -243.78f, 296.622925f, 477.810669f, 486.600342f, 256.917236f, -89.86423f);
            float4x3 r3 = float4x3(-0.304829448f, 0.8473521f, 0.8219489f, -0.404461354f, -0.418797284f, 0.367000759f, 0.6002056f, -0.493279874f, -0.306226134f, -0.300694644f, -0.5695146f, 1.62821317f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mod_wide_wide()
        {
            float4x3 a0 = float4x3(-388.8125f, 181.681213f, -167.078735f, 432.820129f, -258.438965f, -170.110809f, 283.3183f, 122.716492f, 335.271f, -503.608521f, 191.022522f, 289.742676f);
            float4x3 b0 = float4x3(436.944153f, 58.9400635f, -201.116241f, 279.289368f, -397.079773f, 377.899963f, 174.693848f, -228.176514f, -317.060181f, -417.4801f, -249.975952f, -397.571564f);
            float4x3 r0 = float4x3(-388.8125f, 4.861023f, -167.078735f, 153.530762f, -258.438965f, -170.110809f, 108.624451f, 122.716492f, 18.2108154f, -86.12842f, 191.022522f, 289.742676f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x3 a1 = float4x3(-124.033722f, 259.274f, -274.358459f, -140.030792f, 324.577576f, -200.513092f, 211.423157f, -51.2722168f, -230.633911f, 99.98938f, 399.18988f, 24.90326f);
            float4x3 b1 = float4x3(-358.745453f, -198.15921f, 208.737122f, -12.1194153f, 25.2714233f, -194.1207f, -493.8718f, -312.3017f, -216.980591f, 413.570984f, -436.3944f, 3.491272f);
            float4x3 r1 = float4x3(-124.033722f, 61.1147766f, -65.62134f, -6.717224f, 21.3204956f, -6.392395f, 211.423157f, -51.2722168f, -13.65332f, 99.98938f, 399.18988f, 0.464355469f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x3 a2 = float4x3(50.92401f, -364.863678f, -252.626617f, -281.2898f, -364.798523f, -329.026245f, 51.6098022f, 41.6478271f, 254.95105f, -458.6776f, -136.79303f, 72.40033f);
            float4x3 b2 = float4x3(-308.233429f, -441.375061f, 84.60083f, 373.163452f, 67.25275f, -320.333282f, 118.97937f, 44.8239746f, 354.0086f, -253.953125f, -195.162811f, 317.142822f);
            float4x3 r2 = float4x3(50.92401f, -364.863678f, -83.42496f, -281.2898f, -28.53479f, -8.692963f, 51.6098022f, 41.6478271f, 254.95105f, -204.724487f, -136.79303f, 72.40033f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x3 a3 = float4x3(246.212036f, 325.1538f, 162.034668f, -284.761444f, 128.351257f, 262.916748f, 61.60077f, -271.4928f, -205.438812f, -341.322144f, 347.154419f, 148.0885f);
            float4x3 b3 = float4x3(320.693176f, -103.996887f, 388.171753f, -199.639313f, -256.217316f, -478.125031f, -210.655731f, -272.0233f, -61.6765442f, -367.8296f, -242.938934f, 162.386719f);
            float4x3 r3 = float4x3(246.212036f, 13.163147f, 162.034668f, -85.12213f, 128.351257f, 262.916748f, 61.60077f, -271.4928f, -20.40918f, -341.322144f, 104.215485f, 148.0885f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mod_wide_scalar()
        {
            float4x3 a0 = float4x3(-244.499634f, -211.8193f, -145.926788f, -304.9182f, 155.479492f, -133.907776f, 281.309631f, -226.535767f, 335.166138f, 101.706482f, 319.4715f, -285.4023f);
            float b0 = (39.63495f);
            float4x3 r0 = float4x3(-6.68994141f, -13.6445618f, -27.0219421f, -27.4735718f, 36.574646f, -15.00293f, 3.86499023f, -28.3610229f, 18.0865479f, 22.4365845f, 2.39190674f, -7.957672f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x3 a1 = float4x3(-355.846863f, -330.871948f, -284.343567f, -102.683441f, -172.141754f, 206.41687f, -416.713654f, -339.256653f, 435.2975f, 132.552917f, 226.944092f, -306.1183f);
            float b1 = (259.378f);
            float4x3 r1 = float4x3(-96.46887f, -71.49396f, -24.9655762f, -102.683441f, -172.141754f, 206.41687f, -157.335663f, -79.87866f, 175.9195f, 132.552917f, 226.944092f, -46.7402954f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x3 a2 = float4x3(115.438477f, -218.347443f, -140.0405f, -462.3235f, -211.6087f, 351.331055f, 321.047f, 346.0852f, -94.4077454f, 465.40918f, -367.197021f, -467.5106f);
            float b2 = (281.882935f);
            float4x3 r2 = float4x3(115.438477f, -218.347443f, -140.0405f, -180.440552f, -211.6087f, 69.44812f, 39.1640625f, 64.20227f, -94.4077454f, 183.526245f, -85.31409f, -185.627655f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x3 a3 = float4x3(415.2151f, -3.729828f, 128.249878f, 134.941589f, 247.616943f, -285.287872f, 433.766663f, -141.831024f, -229.781891f, 471.218018f, 377.681458f, 433.4076f);
            float b3 = (506.186157f);
            float4x3 r3 = float4x3(415.2151f, -3.729828f, 128.249878f, 134.941589f, 247.616943f, -285.287872f, 433.766663f, -141.831024f, -229.781891f, 471.218018f, 377.681458f, 433.4076f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float4x3 b0 = float4x3(-249.7761f, -396.073761f, 386.492065f, 168.939453f, -199.418243f, 261.7517f, 16.1274414f, 257.668152f, -75.78845f, 170.9563f, -242.858276f, 425.9453f);
            float4x3 r0 = float4x3(-66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -2.43527222f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (303.2724f);
            float4x3 b1 = float4x3(3.033081f, -505.74353f, 461.957031f, 205.972778f, 270.040649f, -47.4807129f, -150.254486f, 149.499512f, -220.298035f, 31.1188354f, 400.635681f, 6.23144531f);
            float4x3 r1 = float4x3(2.99737549f, 303.2724f, 303.2724f, 97.29962f, 33.23175f, 18.3881226f, 2.76342773f, 4.27337646f, 82.9743652f, 23.20288f, 303.2724f, 4.163025f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-39.05075f);
            float4x3 b2 = float4x3(-71.9411f, -495.307129f, -86.7196045f, -436.970062f, -472.294739f, -130.008759f, -251.516846f, 281.976379f, 388.86084f, 50.6152954f, 293.87085f, 123.744263f);
            float4x3 r2 = float4x3(-39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f, -39.05075f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (422.904358f);
            float4x3 b3 = float4x3(-53.87619f, -178.857666f, -362.27594f, 361.085266f, 465.276123f, -269.889648f, -159.408966f, -29.0952148f, 484.499451f, -354.950623f, -328.6906f, -171.739227f);
            float4x3 r3 = float4x3(45.7710266f, 65.1890259f, 60.628418f, 61.81909f, 422.904358f, 153.014709f, 104.086426f, 15.57135f, 422.904358f, 67.9537354f, 94.2137451f, 79.4259f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_plus()
        {
            float4x3 a0 = float4x3(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f);
            float4x3 r0 = float4x3(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f);
            TestUtils.AreEqual(+a0, r0);

            float4x3 a1 = float4x3(-170.746521f, -478.7494f, 116.400757f, 421.409668f, -258.596069f, 447.8661f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f);
            float4x3 r1 = float4x3(-170.746521f, -478.7494f, 116.400757f, 421.409668f, -258.596069f, 447.8661f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f);
            TestUtils.AreEqual(+a1, r1);

            float4x3 a2 = float4x3(279.072937f, 37.9992065f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f, -161.454834f, -355.270874f, 141.314331f, 239.320862f, -494.6041f);
            float4x3 r2 = float4x3(279.072937f, 37.9992065f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f, -161.454834f, -355.270874f, 141.314331f, 239.320862f, -494.6041f);
            TestUtils.AreEqual(+a2, r2);

            float4x3 a3 = float4x3(361.59198f, 141.712524f, 25.2562866f, -268.2269f, 106.774658f, 176.744385f, 104.119934f, 144.618591f, 289.4519f, -393.0167f, -198.95575f, -419.009216f);
            float4x3 r3 = float4x3(361.59198f, 141.712524f, 25.2562866f, -268.2269f, 106.774658f, 176.744385f, 104.119934f, 144.618591f, 289.4519f, -393.0167f, -198.95575f, -419.009216f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_neg()
        {
            float4x3 a0 = float4x3(148.461731f, -467.122681f, 132.04718f, 183.522644f, 473.701f, -407.9911f, -54.95877f, -382.9898f, -299.093384f, -383.014069f, 407.709778f, 168.735474f);
            float4x3 r0 = float4x3(-148.461731f, 467.122681f, -132.04718f, -183.522644f, -473.701f, 407.9911f, 54.95877f, 382.9898f, 299.093384f, 383.014069f, -407.709778f, -168.735474f);
            TestUtils.AreEqual(-a0, r0);

            float4x3 a1 = float4x3(466.441528f, -280.558319f, -78.857605f, 318.69635f, -39.9154053f, 140.340027f, 132.195618f, -505.895264f, 410.380554f, -237.056946f, -137.617828f, -245.349976f);
            float4x3 r1 = float4x3(-466.441528f, 280.558319f, 78.857605f, -318.69635f, 39.9154053f, -140.340027f, -132.195618f, 505.895264f, -410.380554f, 237.056946f, 137.617828f, 245.349976f);
            TestUtils.AreEqual(-a1, r1);

            float4x3 a2 = float4x3(422.521362f, 60.22223f, -466.5663f, 426.894531f, 146.649536f, -391.37207f, 423.237732f, 254.297546f, -114.848907f, 108.059692f, -507.9763f, -306.245728f);
            float4x3 r2 = float4x3(-422.521362f, -60.22223f, 466.5663f, -426.894531f, -146.649536f, 391.37207f, -423.237732f, -254.297546f, 114.848907f, -108.059692f, 507.9763f, 306.245728f);
            TestUtils.AreEqual(-a2, r2);

            float4x3 a3 = float4x3(219.66626f, -98.76068f, 492.111084f, 84.04584f, 300.976624f, -483.864624f, -389.15744f, -324.6861f, 378.85437f, 190.219238f, -69.10242f, 507.495361f);
            float4x3 r3 = float4x3(-219.66626f, 98.76068f, -492.111084f, -84.04584f, -300.976624f, 483.864624f, 389.15744f, 324.6861f, -378.85437f, -190.219238f, 69.10242f, -507.495361f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_prefix_inc()
        {
            float4x3 a0 = float4x3(-139.842072f, -56.7436523f, -381.955322f, 509.796326f, -222.896332f, 210.319885f, -392.7315f, -300.1941f, 362.212769f, 401.6148f, 130.90918f, -450.230164f);
            float4x3 r0 = float4x3(-138.842072f, -55.7436523f, -380.955322f, 510.796326f, -221.896332f, 211.319885f, -391.7315f, -299.1941f, 363.212769f, 402.6148f, 131.90918f, -449.230164f);
            TestUtils.AreEqual(++a0, r0);

            float4x3 a1 = float4x3(243.546936f, -41.4972839f, 299.1855f, 154.356567f, -281.233276f, 200.706f, 92.95776f, 448.602173f, -295.587f, 18.4990845f, -215.711121f, 471.947266f);
            float4x3 r1 = float4x3(244.546936f, -40.4972839f, 300.1855f, 155.356567f, -280.233276f, 201.706f, 93.95776f, 449.602173f, -294.587f, 19.4990845f, -214.711121f, 472.947266f);
            TestUtils.AreEqual(++a1, r1);

            float4x3 a2 = float4x3(257.0766f, 4.82543945f, 243.004761f, -472.619019f, -125.720215f, -477.459564f, 9.89147949f, -76.92285f, -29.7675781f, -387.177429f, 461.7093f, 13.699707f);
            float4x3 r2 = float4x3(258.0766f, 5.82543945f, 244.004761f, -471.619019f, -124.720215f, -476.459564f, 10.8914795f, -75.92285f, -28.7675781f, -386.177429f, 462.7093f, 14.699707f);
            TestUtils.AreEqual(++a2, r2);

            float4x3 a3 = float4x3(-46.303772f, -222.2291f, 340.8178f, 399.741272f, -311.372345f, 300.177979f, -272.7783f, 351.019165f, 436.575256f, -137.063324f, 312.579956f, -315.999023f);
            float4x3 r3 = float4x3(-45.303772f, -221.2291f, 341.8178f, 400.741272f, -310.372345f, 301.177979f, -271.7783f, 352.019165f, 437.575256f, -136.063324f, 313.579956f, -314.999023f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_postfix_inc()
        {
            float4x3 a0 = float4x3(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f, 167.852112f, 147.94397f, -326.1076f, 41.03357f);
            float4x3 r0 = float4x3(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f, 167.852112f, 147.94397f, -326.1076f, 41.03357f);
            TestUtils.AreEqual(a0++, r0);

            float4x3 a1 = float4x3(128.5304f, -60.1323853f, -446.229767f, -296.937836f, 267.293823f, 446.2293f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f);
            float4x3 r1 = float4x3(128.5304f, -60.1323853f, -446.229767f, -296.937836f, 267.293823f, 446.2293f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f);
            TestUtils.AreEqual(a1++, r1);

            float4x3 a2 = float4x3(-298.917175f, 184.603455f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f, 239.596924f, 36.62433f, -80.70819f, -391.0335f, -478.227142f);
            float4x3 r2 = float4x3(-298.917175f, 184.603455f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f, 239.596924f, 36.62433f, -80.70819f, -391.0335f, -478.227142f);
            TestUtils.AreEqual(a2++, r2);

            float4x3 a3 = float4x3(166.860474f, -389.396667f, -52.13214f, 35.75531f, 356.052124f, 6.52948f, -285.349823f, 418.016479f, 47.1428833f, 31.4516f, 148.9469f, -219.800385f);
            float4x3 r3 = float4x3(166.860474f, -389.396667f, -52.13214f, 35.75531f, 356.052124f, 6.52948f, -285.349823f, 418.016479f, 47.1428833f, 31.4516f, 148.9469f, -219.800385f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void float4x3_operator_prefix_dec()
        {
            float4x3 a0 = float4x3(123.128723f, 256.84375f, 156.330811f, 461.737427f, 325.867981f, 392.015625f, 187.874146f, -236.225189f, 125.109619f, 469.844727f, 45.5366821f, 376.046875f);
            float4x3 r0 = float4x3(122.128723f, 255.84375f, 155.330811f, 460.737427f, 324.867981f, 391.015625f, 186.874146f, -237.225189f, 124.109619f, 468.844727f, 44.5366821f, 375.046875f);
            TestUtils.AreEqual(--a0, r0);

            float4x3 a1 = float4x3(-363.0755f, 248.7901f, 168.095032f, 168.265625f, -190.284729f, 166.945557f, 183.957947f, 485.6947f, -460.739319f, 89.5698853f, -267.4298f, 201.756226f);
            float4x3 r1 = float4x3(-364.0755f, 247.7901f, 167.095032f, 167.265625f, -191.284729f, 165.945557f, 182.957947f, 484.6947f, -461.739319f, 88.5698853f, -268.4298f, 200.756226f);
            TestUtils.AreEqual(--a1, r1);

            float4x3 a2 = float4x3(-141.216888f, 197.361755f, -213.544128f, 180.7406f, -128.3125f, 478.045532f, -454.566132f, -386.898346f, 387.857f, -315.110443f, -108.28656f, -286.317017f);
            float4x3 r2 = float4x3(-142.216888f, 196.361755f, -214.544128f, 179.7406f, -129.3125f, 477.045532f, -455.566132f, -387.898346f, 386.857f, -316.110443f, -109.28656f, -287.317017f);
            TestUtils.AreEqual(--a2, r2);

            float4x3 a3 = float4x3(-375.601563f, 78.27545f, 161.531982f, -346.847961f, -57.54077f, 455.372864f, 444.798157f, 129.820129f, 134.710632f, 61.322998f, -274.543335f, -43.39557f);
            float4x3 r3 = float4x3(-376.601563f, 77.27545f, 160.531982f, -347.847961f, -58.54077f, 454.372864f, 443.798157f, 128.820129f, 133.710632f, 60.322998f, -275.543335f, -44.39557f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void float4x3_operator_postfix_dec()
        {
            float4x3 a0 = float4x3(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f);
            float4x3 r0 = float4x3(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f);
            TestUtils.AreEqual(a0--, r0);

            float4x3 a1 = float4x3(-200.304291f, 407.420349f, 327.670349f, 48.06018f, -209.667969f, -38.43506f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f);
            float4x3 r1 = float4x3(-200.304291f, 407.420349f, 327.670349f, 48.06018f, -209.667969f, -38.43506f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f);
            TestUtils.AreEqual(a1--, r1);

            float4x3 a2 = float4x3(159.233582f, 168.41394f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f, 145.896729f, -296.790955f, -274.570831f, -250.04126f, -70.85629f);
            float4x3 r2 = float4x3(159.233582f, 168.41394f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f, 145.896729f, -296.790955f, -274.570831f, -250.04126f, -70.85629f);
            TestUtils.AreEqual(a2--, r2);

            float4x3 a3 = float4x3(-485.627838f, -503.192078f, 397.648621f, 446.621582f, -292.81012f, 126.6225f, -250.442413f, 470.816467f, 26.9436035f, -186.923523f, 45.7460938f, -206.455963f);
            float4x3 r3 = float4x3(-485.627838f, -503.192078f, 397.648621f, 446.621582f, -292.81012f, 126.6225f, -250.442413f, 470.816467f, 26.9436035f, -186.923523f, 45.7460938f, -206.455963f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
