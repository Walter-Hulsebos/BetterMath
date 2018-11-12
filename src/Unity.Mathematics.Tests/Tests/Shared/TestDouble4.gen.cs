// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble4
    {
        [TestCompiler]
        public void double4_zero()
        {
            TestUtils.AreEqual(double4.zero.x, 0.0);
            TestUtils.AreEqual(double4.zero.y, 0.0);
            TestUtils.AreEqual(double4.zero.z, 0.0);
            TestUtils.AreEqual(double4.zero.w, 0.0);
        }

        [TestCompiler]
        public void double4_constructor()
        {
            double4 a = new double4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public void double4_scalar_constructor()
        {
            double4 a = new double4(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
            TestUtils.AreEqual(a.z, 17.0);
            TestUtils.AreEqual(a.w, 17.0);
        }

        [TestCompiler]
        public void double4_static_constructor()
        {
            double4 a = double4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public void double4_static_scalar_constructor()
        {
            double4 a = double4(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
            TestUtils.AreEqual(a.z, 17.0);
            TestUtils.AreEqual(a.w, 17.0);
        }

        [TestCompiler]
        public void double4_operator_equal_wide_wide()
        {
            double4 a0 = double4(492.15758275061728, -495.20632027797694, 227.45765195947968, -147.37405950733182);
            double4 b0 = double4(192.56880888369346, -235.61102472786376, -254.04311740307281, -412.62472052715009);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4 a1 = double4(-222.68201909897942, 64.093720704360749, -23.890404473939157, -16.8197190839889);
            double4 b1 = double4(471.90480945627428, -6.4727852374654162, -339.10237447316865, 488.1875700839737);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4 a2 = double4(163.23210890741655, -165.27101071424363, 470.87767980568003, -423.94255967808078);
            double4 b2 = double4(-379.5965842584132, -308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4 a3 = double4(109.63436918595539, 462.69031283943468, -335.38147727371262, 357.23446934168896);
            double4 b3 = double4(226.51573835430463, -356.90132896830391, -362.91277544708589, -427.89843746083716);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double4_operator_equal_wide_scalar()
        {
            double4 a0 = double4(-303.2300766926399, 451.52631327674089, -253.65587413201848, -105.20363502632995);
            double b0 = (123.5445759871717);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4 a1 = double4(-500.6910920090466, 159.87609656149334, -59.558379439431405, -57.477391031327386);
            double b1 = (-426.19248338518315);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4 a2 = double4(-182.0497396840014, 370.88599866017978, -172.03530629539642, 455.40001198993991);
            double b2 = (406.51375861024189);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4 a3 = double4(-11.338988547836891, -27.150561106927, -325.97606507221985, -290.35904254129116);
            double b3 = (363.93823044557973);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double4_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double4 b0 = double4(19.952187785856495, -185.79199346610903, 407.8136052600172, -87.2766969610363);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-206.27469382354741);
            double4 b1 = double4(160.503138855334, -274.77081478516141, -2.6315281403397535, 448.35453602688131);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-410.03524251004461);
            double4 b2 = double4(247.32901465489022, 355.53915350303942, -298.06671180299793, 414.10151429385951);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (-481.30262707234482);
            double4 b3 = double4(196.55074438664633, 34.60100008668428, 113.76156645350227, -386.45337861890596);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double4_operator_not_equal_wide_wide()
        {
            double4 a0 = double4(430.8425316432689, 104.69001798736394, 225.80243478799355, -310.57017841496048);
            double4 b0 = double4(210.02470622305975, -55.203330304102678, -269.92533672504373, -234.54673372700194);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4 a1 = double4(-418.61945815506363, 304.12820281839379, -509.32682561749908, -160.53807719076895);
            double4 b1 = double4(25.917412054686565, -63.726991444699024, -484.55371092471933, -425.333599050219);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4 a2 = double4(-203.30197606016975, -505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double4 b2 = double4(-53.274394775402925, 328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4 a3 = double4(65.662074358045174, 102.78780250567377, 172.93008120960099, 26.621009123800832);
            double4 b3 = double4(-113.36304455313973, -240.07297264787974, 495.11916970420589, 203.5583661550462);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double4_operator_not_equal_wide_scalar()
        {
            double4 a0 = double4(-16.914588697680529, 168.83411486858233, -462.71352145760949, 130.30776959765137);
            double b0 = (-145.37277109239847);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4 a1 = double4(214.50161443208424, -197.12796053529155, -169.09985860115842, -386.61117595555783);
            double b1 = (-440.26328178879959);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4 a2 = double4(-281.02101362916687, -403.96372313236992, -269.80570877241234, 299.65422763473089);
            double b2 = (-270.26885593601912);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4 a3 = double4(-71.750904831919286, -457.36312100727258, -13.519590622521719, 273.87305773136814);
            double b3 = (-432.75573917513515);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double4_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double4 b0 = double4(-57.196896341255353, -382.4325279586169, 97.820359990848374, -161.46364529499022);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-458.39563367254829);
            double4 b1 = double4(-499.61786364932448, 327.92217818271467, 367.57121699283425, 59.7863667289663);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-209.58068118318016);
            double4 b2 = double4(-62.580453186566217, -479.97497604786184, -49.494519495169868, -114.68521338081229);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (109.93924599044919);
            double4 b3 = double4(-176.28482755286842, -347.48529903380449, 85.540928165214609, -356.65954868712441);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_wide_wide()
        {
            double4 a0 = double4(196.84256825076534, 336.40979997087732, 251.96372115424072, 257.65591466503963);
            double4 b0 = double4(-465.34502313348696, -256.15239751346053, -314.814018634527, 364.56673662949663);
            bool4 r0 = bool4(false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double4 a1 = double4(430.04588647840819, -62.419644146421774, 8.8392293494376872, -333.81671563434259);
            double4 b1 = double4(100.21050290959443, 182.56098636545289, 3.116978885194726, -259.43047893207074);
            bool4 r1 = bool4(false, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double4 a2 = double4(164.67880662003472, -350.94487516532877, 3.84143662631584, 125.40972024081725);
            double4 b2 = double4(-437.33490749696966, -456.0437321402336, -394.2559718537405, 401.91369099259077);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double4 a3 = double4(-111.12994127680076, 70.005523475820951, 448.19828173527412, -419.98711200244122);
            double4 b3 = double4(313.43916454605721, 121.28668194696616, -28.012290729215522, -282.96589697663012);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_wide_scalar()
        {
            double4 a0 = double4(-132.05731708000292, -192.46500477216438, -66.834607870706634, -379.01750081545561);
            double b0 = (-156.01021845452965);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double4 a1 = double4(-360.28242199508588, -158.24074537970159, 437.34587522845061, -20.452607402788772);
            double b1 = (20.927834282129879);
            bool4 r1 = bool4(true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double4 a2 = double4(225.29148517609178, 274.01523292903562, 373.54965584983563, 398.52368301829495);
            double b2 = (307.48418607725023);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double4 a3 = double4(105.0301654827922, 109.67008810381878, -108.853174498702, -44.971252223929014);
            double b3 = (-58.010895994496934);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_scalar_wide()
        {
            double a0 = (-423.117411095238);
            double4 b0 = double4(385.09483617595151, -123.93348532725753, 86.376572887588509, 133.44217378154497);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (161.45794947513286);
            double4 b1 = double4(229.75426660746064, 222.57159934871436, 315.53116360098647, -447.20351883731945);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (271.83385790131695);
            double4 b2 = double4(-393.60531324595462, 317.48689737798964, -164.6051085761772, -282.87605370342544);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (296.97953071118309);
            double4 b3 = double4(-254.40115582868509, 365.61562054493265, -441.98425671178114, -131.42866021554391);
            bool4 r3 = bool4(false, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_wide_wide()
        {
            double4 a0 = double4(483.50140141113729, 310.81563415695712, 106.9661896726891, 295.73526038589671);
            double4 b0 = double4(-471.39802454011425, -371.98528617060992, 36.900723236101044, -316.76360407320954);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double4 a1 = double4(116.95757179938141, -478.29977653841479, -14.897393471979228, -33.817441717636484);
            double4 b1 = double4(19.683055648432628, 207.3091381561519, 362.79748861994483, 324.95341816775192);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double4 a2 = double4(-24.740548383789417, 319.78262701620474, -120.15856581561201, -289.00857962714906);
            double4 b2 = double4(340.94807140014507, 25.986035120666998, -114.2111352021858, 240.80346428640348);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double4 a3 = double4(455.85146662958505, 144.70691139283917, 63.931990891663304, -285.68304099034663);
            double4 b3 = double4(273.42244757033063, 325.51576224226312, 27.341068995809678, 64.479532510265472);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_wide_scalar()
        {
            double4 a0 = double4(64.317918092160426, -397.70346445483318, 431.87690826499693, 85.702980796668157);
            double b0 = (305.85991992888034);
            bool4 r0 = bool4(false, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double4 a1 = double4(246.26305233978803, 286.1994608781298, 280.81334818564972, -405.78459210218148);
            double b1 = (197.49155602114809);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double4 a2 = double4(171.56538661362856, 333.57817498481745, 370.27919524269146, -413.70138116073861);
            double b2 = (-241.80727326209063);
            bool4 r2 = bool4(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double4 a3 = double4(-356.5923551789449, 396.64532608382649, 467.22205541432936, -240.0134228393498);
            double b3 = (-353.03129522550444);
            bool4 r3 = bool4(false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_scalar_wide()
        {
            double a0 = (-282.67049635698572);
            double4 b0 = double4(358.09997360692353, -72.5964134077525, -232.16380106292843, -60.706723956720282);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (75.156642710397364);
            double4 b1 = double4(150.88350040786133, 339.53917924479538, -498.19602965665797, 459.74610326241054);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (-227.96872316485678);
            double4 b2 = double4(335.86213485145106, 76.178844248959308, 296.85993899817572, 177.49000390688423);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (-281.20120657663847);
            double4 b3 = double4(244.72285162877427, 137.32857257562159, -385.33824724021287, 443.16345879210326);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_equal_wide_wide()
        {
            double4 a0 = double4(-438.52313753521219, 210.48942837980087, 4.8773329280677444, -137.29793817237857);
            double4 b0 = double4(-474.8141498392514, 304.3710555063426, 234.8241737982371, -390.48543209139513);
            bool4 r0 = bool4(false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            double4 a1 = double4(156.09410174009111, -363.92412035722475, -97.948485181642923, 437.29539009430232);
            double4 b1 = double4(-297.17535295019638, -326.29239121372461, 107.2538764976216, -413.13107342884462);
            bool4 r1 = bool4(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double4 a2 = double4(458.53029153241323, -294.06474675520542, 23.622613679441884, -34.284056441059363);
            double4 b2 = double4(67.094432623635271, 470.07522724106684, -84.499104777583455, 392.78422683886447);
            bool4 r2 = bool4(false, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double4 a3 = double4(149.736484835733, -418.8866781754823, -197.50252899783783, -88.2055118494693);
            double4 b3 = double4(-263.53175485484849, 369.30090039284005, -333.32529298091555, 238.41347443238533);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_equal_wide_scalar()
        {
            double4 a0 = double4(193.4958237118534, 168.91555197952107, -313.9930695565385, 81.826965131716292);
            double b0 = (443.85054299042122);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double4 a1 = double4(18.503590830836288, 241.36115776810846, -463.81641242644582, -1.3577692515020203);
            double b1 = (-0.35819602029312136);
            bool4 r1 = bool4(false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double4 a2 = double4(-268.89945591096739, -471.253072242836, -264.93778264938749, 82.258299150624453);
            double b2 = (398.9919504593089);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double4 a3 = double4(11.246050124636895, 426.48223157715154, 56.319978501796754, -196.28791126808522);
            double b3 = (424.7040156911612);
            bool4 r3 = bool4(true, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_less_equal_scalar_wide()
        {
            double a0 = (393.60626644343427);
            double4 b0 = double4(-75.688363825757222, -44.2638714519627, 125.8649156679702, 191.96488174794467);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (13.543054825413492);
            double4 b1 = double4(-197.0519259893577, -423.945100743298, -330.04861680141119, 420.16553779140372);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (105.54730777887039);
            double4 b2 = double4(174.82126363311954, 296.71757831085358, -469.70041845259277, 123.26718979853536);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (112.9969695140594);
            double4 b3 = double4(495.14339493920249, -488.65789364681478, 388.53941148730894, -493.24077080806751);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_equal_wide_wide()
        {
            double4 a0 = double4(-507.92858409692, 504.49748181947393, -385.43449205226938, -262.32340944107784);
            double4 b0 = double4(-81.346509732933043, 297.66615047010885, 171.06540616371922, -431.03805538222105);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double4 a1 = double4(-37.550928848586466, -111.59527759980193, -463.70202157632542, 387.44885772627265);
            double4 b1 = double4(-6.859075311040101, 319.72570362674332, 254.079170106947, 396.5724000393285);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double4 a2 = double4(456.96878573716094, -211.01015506079892, 182.41135391146474, -53.596053863687473);
            double4 b2 = double4(178.83927615864172, -447.06336304501787, 288.49268569075161, 474.88929460704765);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double4 a3 = double4(-309.57021608463032, -136.02249127999994, 280.73629082401112, -96.9958942388165);
            double4 b3 = double4(-321.75022831640683, -395.97722048125104, -158.69246037243516, 391.48869318118727);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_equal_wide_scalar()
        {
            double4 a0 = double4(465.15218732559686, -424.8860745024337, -209.22109685150025, 58.779852656079356);
            double b0 = (-5.5998842742293391);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double4 a1 = double4(-302.26910533675414, 16.353385694489475, -344.55997316192838, 393.27804846003562);
            double b1 = (140.12558252183976);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double4 a2 = double4(-315.70155086913218, -509.78156757251435, -36.994287269652943, 494.82028865014217);
            double b2 = (441.0115565923096);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double4 a3 = double4(-164.97393830352183, -123.8137477020797, 215.65121779947128, 104.99569730879534);
            double b3 = (-466.12009046325466);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_greater_equal_scalar_wide()
        {
            double a0 = (374.82703393270594);
            double4 b0 = double4(-1.609757185731894, 338.61524049314448, -116.18140392945213, -332.15732375353451);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-355.9793509710484);
            double4 b1 = double4(-468.90144107719021, 38.579884785497484, -332.34754697063357, 2.8901150240051265);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (467.77776477661814);
            double4 b2 = double4(121.40638762405445, -305.02337303060267, -58.428812292604164, -226.51955209789776);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (-47.020994446715804);
            double4 b3 = double4(305.3026770582901, -427.40123315686418, 92.263649745035764, -497.17853736187266);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double4_operator_add_wide_wide()
        {
            double4 a0 = double4(506.12905263627374, -501.77980803967444, 420.08479638587903, -186.03206476291274);
            double4 b0 = double4(-28.757987751047096, -337.135153689019, -340.676816860529, 152.31202633320913);
            double4 r0 = double4(477.37106488522664, -838.91496172869347, 79.407979525350015, -33.720038429703607);
            TestUtils.AreEqual(a0 + b0, r0);

            double4 a1 = double4(-9.3123953385801883, 328.51179686585056, 424.34407659263536, 87.791079800478656);
            double4 b1 = double4(423.66745420157326, 90.374096674087468, 376.18866246574964, 1.7671887882831925);
            double4 r1 = double4(414.35505886299308, 418.885893539938, 800.532739058385, 89.558268588761848);
            TestUtils.AreEqual(a1 + b1, r1);

            double4 a2 = double4(462.41368148402012, -46.178705952213477, 401.17006296718966, -454.12414643453627);
            double4 b2 = double4(-120.18586045139745, -279.62936628965167, -344.66710273580026, 242.8391956029642);
            double4 r2 = double4(342.22782103262267, -325.80807224186515, 56.502960231389409, -211.28495083157208);
            TestUtils.AreEqual(a2 + b2, r2);

            double4 a3 = double4(69.195687564646732, -177.95734485329939, 299.60415544156183, 340.7048587001417);
            double4 b3 = double4(418.5930504363929, -23.312797318823982, -95.099945827899489, 147.92812568877275);
            double4 r3 = double4(487.78873800103963, -201.27014217212337, 204.50420961366234, 488.63298438891445);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double4_operator_add_wide_scalar()
        {
            double4 a0 = double4(-194.51420387742769, 338.54838696985894, 246.97140252169754, 100.51093797595752);
            double b0 = (124.121678171736);
            double4 r0 = double4(-70.3925257056917, 462.67006514159493, 371.09308069343354, 224.63261614769351);
            TestUtils.AreEqual(a0 + b0, r0);

            double4 a1 = double4(-45.724677822424439, 30.916145577522116, 60.37435224483454, -242.1187475855084);
            double b1 = (-478.11131094308166);
            double4 r1 = double4(-523.835988765506, -447.19516536555955, -417.73695869824712, -720.23005852859);
            TestUtils.AreEqual(a1 + b1, r1);

            double4 a2 = double4(82.50134495762245, -484.69981287638649, -188.26501068298938, -213.52673087526426);
            double b2 = (6.7993848355483806);
            double4 r2 = double4(89.300729793170831, -477.90042804083811, -181.465625847441, -206.72734603971588);
            TestUtils.AreEqual(a2 + b2, r2);

            double4 a3 = double4(-267.78430688929944, 198.53359684652355, 187.53610023648298, -424.92567582844089);
            double b3 = (189.25996669999324);
            double4 r3 = double4(-78.5243401893062, 387.79356354651679, 376.79606693647622, -235.66570912844765);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double4_operator_add_scalar_wide()
        {
            double a0 = (-340.35468284243473);
            double4 b0 = double4(511.36225652665007, -146.21663791789518, -106.21042661844308, -363.45024960276214);
            double4 r0 = double4(171.00757368421535, -486.57132076032991, -446.56510946087781, -703.80493244519687);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (199.08958325120136);
            double4 b1 = double4(-27.108407271610758, 419.84900041103788, 284.95503748811552, -164.92418129971446);
            double4 r1 = double4(171.9811759795906, 618.93858366223924, 484.04462073931688, 34.1654019514869);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (-249.19032561461921);
            double4 b2 = double4(150.92817718858282, 298.17509784278229, -457.15341803857751, 424.71807094324288);
            double4 r2 = double4(-98.26214842603639, 48.984772228163081, -706.34374365319673, 175.52774532862367);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (-301.85750283946163);
            double4 b3 = double4(230.28885208363124, -423.58759351428023, -67.060037882560891, 68.7241366229598);
            double4 r3 = double4(-71.56865075583039, -725.44509635374186, -368.91754072202252, -233.13336621650183);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double4_operator_sub_wide_wide()
        {
            double4 a0 = double4(160.4922617229131, 11.223957305412682, 359.20010607279846, -498.22830485656311);
            double4 b0 = double4(115.46876078260539, -130.98230630298252, 241.54083716196044, 9.9870860623135513);
            double4 r0 = double4(45.023500940307713, 142.2062636083952, 117.65926891083802, -508.21539091887666);
            TestUtils.AreEqual(a0 - b0, r0);

            double4 a1 = double4(-355.25362913462038, -94.534852787170053, -410.46404786150163, -401.38464398001537);
            double4 b1 = double4(419.89512582304656, 59.124466208333388, -402.38163847587145, -75.370143687059226);
            double4 r1 = double4(-775.14875495766694, -153.65931899550344, -8.0824093856301715, -326.01450029295614);
            TestUtils.AreEqual(a1 - b1, r1);

            double4 a2 = double4(317.70681944382693, 447.0604133303558, -489.07414482956477, -230.00838218909149);
            double4 b2 = double4(320.97960796997859, -73.908757482612884, -31.444742455819949, -389.25194734579509);
            double4 r2 = double4(-3.2727885261516576, 520.96917081296874, -457.62940237374482, 159.2435651567036);
            TestUtils.AreEqual(a2 - b2, r2);

            double4 a3 = double4(24.875419389864192, 366.61447136784648, -107.3741567634857, -219.0081404275299);
            double4 b3 = double4(-375.02884000122026, 259.18275821357167, 276.648654351313, -453.06919905779381);
            double4 r3 = double4(399.90425939108445, 107.4317131542748, -384.02281111479869, 234.06105863026392);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double4_operator_sub_wide_scalar()
        {
            double4 a0 = double4(207.38960108877609, 248.45773684627272, -384.82393211164697, -205.34476122881506);
            double b0 = (-36.112476604111691);
            double4 r0 = double4(243.50207769288778, 284.57021345038441, -348.71145550753528, -169.23228462470337);
            TestUtils.AreEqual(a0 - b0, r0);

            double4 a1 = double4(-374.81156152058929, 18.856238135535364, -44.96160151667965, 480.85798738936796);
            double b1 = (191.64204820973896);
            double4 r1 = double4(-566.45360973032825, -172.7858100742036, -236.60364972641861, 289.215939179629);
            TestUtils.AreEqual(a1 - b1, r1);

            double4 a2 = double4(16.338193185784917, -35.523088233323335, 349.39776460705218, 439.07729336203886);
            double b2 = (-366.86545269883493);
            double4 r2 = double4(383.20364588461985, 331.34236446551159, 716.26321730588711, 805.94274606087379);
            TestUtils.AreEqual(a2 - b2, r2);

            double4 a3 = double4(490.2222661870635, -384.84940952102158, 189.05188545447402, 55.602777745389744);
            double b3 = (195.02405104181923);
            double4 r3 = double4(295.19821514524426, -579.87346056284082, -5.9721655873452164, -139.42127329642949);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double4_operator_sub_scalar_wide()
        {
            double a0 = (-86.008225719448262);
            double4 b0 = double4(466.42511413359318, 298.48694219183506, -300.95010652251085, 315.38003006362362);
            double4 r0 = double4(-552.43333985304139, -384.49516791128332, 214.94188080306259, -401.38825578307188);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (-381.09218543632522);
            double4 b1 = double4(-125.00837546447684, 58.466194418476107, 214.74609361158036, -257.54942739082009);
            double4 r1 = double4(-256.08380997184838, -439.55837985480133, -595.83827904790564, -123.54275804550514);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (480.22459505508868);
            double4 b2 = double4(-443.35507723472784, 260.79503858312728, 29.681931747906788, 139.85773164586055);
            double4 r2 = double4(923.57967228981647, 219.42955647196141, 450.5426633071819, 340.36686340922813);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (-247.78996216868512);
            double4 b3 = double4(-248.4662297929014, 91.445112509394562, 86.384162704639266, 373.81828206303453);
            double4 r3 = double4(0.67626762421627973, -339.23507467807968, -334.17412487332439, -621.60824423171971);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mul_wide_wide()
        {
            double4 a0 = double4(-482.71381710596097, -407.29348559272171, 137.70058995937029, 208.54113278563182);
            double4 b0 = double4(-236.36788355389979, 260.72759139757954, -416.38629718142852, -364.49561541364324);
            double4 r0 = double4(114098.04331156027, -106192.64949051509, -57336.638772880389, -76012.328533757158);
            TestUtils.AreEqual(a0 * b0, r0);

            double4 a1 = double4(194.296573967811, -484.24241684574747, 183.98730739578014, -241.33547770294149);
            double4 b1 = double4(-253.14750897751537, -369.20287220981106, 193.54791531038836, 169.08491976982214);
            double4 r1 = double4(-49185.69370281692, 178783.69114527057, 35610.359790024842, -40806.189885013562);
            TestUtils.AreEqual(a1 * b1, r1);

            double4 a2 = double4(45.868758938214114, 363.32610266438041, -328.11893692990714, -471.02307413100408);
            double4 b2 = double4(201.96966442930034, 249.45608317547294, -308.19319810913555, -385.57964843585137);
            double4 r2 = double4(9264.0978505395742, 90633.9064860661, 101124.02453259782, 181616.91132860651);
            TestUtils.AreEqual(a2 * b2, r2);

            double4 a3 = double4(-262.68257415605831, -379.26274674910246, -374.09058182970182, 481.44738720424812);
            double4 b3 = double4(-183.27959522198864, 22.275629292370581, -265.52144229855458, -95.677454277722859);
            double4 r3 = double4(48144.355863192381, -8448.3163509892329, 99329.070837727879, -46063.660376363579);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mul_wide_scalar()
        {
            double4 a0 = double4(-96.318821236639678, -277.14229239017811, -239.93690191951436, 509.53140544776409);
            double b0 = (-301.20720424373042);
            double4 r0 = double4(29011.922860739887, 83477.255068544036, 72270.723422079071, -153474.5301092997);
            TestUtils.AreEqual(a0 * b0, r0);

            double4 a1 = double4(255.85810172551226, -455.50827500573746, -389.24327367788334, -338.29248658674419);
            double b1 = (215.73149667295229);
            double4 r1 = double4(55196.651221145235, -98267.481913902491, -83972.034000409345, -72980.344444572955);
            TestUtils.AreEqual(a1 * b1, r1);

            double4 a2 = double4(53.796284939067618, 135.35469991311186, -207.35010275959508, -383.93960946795517);
            double b2 = (243.75734459783757);
            double4 r2 = double4(13113.239565975766, 32993.702229657305, -50543.11045076765, -93588.099689839524);
            TestUtils.AreEqual(a2 * b2, r2);

            double4 a3 = double4(-31.425238862366086, 260.38388049806645, 176.86755927692525, 25.672123205695357);
            double b3 = (42.676120539510634);
            double4 r3 = double4(-1341.1072816732492, 11112.173870681016, 7548.021279231104, 1095.5866244314232);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mul_scalar_wide()
        {
            double a0 = (37.432166355397612);
            double4 b0 = double4(96.747546479454058, 492.18539427788244, -274.05458534604617, -452.87096926796761);
            double4 r0 = double4(3621.4702542954869, 18423.565556306661, -10258.456829132712, -16951.941459168724);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (420.85330434369541);
            double4 b1 = double4(102.18292694081686, -114.94887762654054, -351.12003843445336, -464.66496799172131);
            double4 r1 = double4(43004.022450553188, -48376.614979728663, -147770.02839642504, -195555.78719207339);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (444.08484646495663);
            double4 b2 = double4(447.10525605040846, 130.82935124767448, -321.41334191030512, 445.30131861441828);
            double4 r2 = double4(198552.66898682076, 58099.332361933404, -142734.79459402646, 197751.56770752667);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (478.24357317306271);
            double4 b3 = double4(358.57170622356784, -144.89011222910608, -438.89383741789209, -3.536441089369589);
            double4 r3 = double4(171484.61402312081, -69292.764989893767, -209898.15705036998, -1691.2802228961507);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double4_operator_div_wide_wide()
        {
            double4 a0 = double4(-353.13144390337703, -102.79985456485292, 51.319128298814917, -191.87167868012176);
            double4 b0 = double4(-178.73954805114283, -302.09628381491467, -199.40583739029518, 278.85077561012042);
            double4 r0 = double4(1.97567604793504, 0.34028837848212429, -0.25736021056579439, -0.68808013268139567);
            TestUtils.AreEqual(a0 / b0, r0);

            double4 a1 = double4(8.0418245829836223, -128.73764210973758, -136.05959779399427, -370.4710053738537);
            double4 b1 = double4(502.33758782890516, -361.48483078623417, 353.121059820578, -38.894930142394685);
            double4 r1 = double4(0.016008805189634039, 0.35613566917796119, -0.3853058151307277, 9.5249176182488586);
            TestUtils.AreEqual(a1 / b1, r1);

            double4 a2 = double4(-237.69456326109105, -432.54687496300176, 200.26549181727012, 361.44157068871039);
            double4 b2 = double4(-75.764737402910725, -195.21784719974636, -405.03399224068687, -394.2300085473014);
            double4 r2 = double4(3.1372716570909582, 2.2157137842034547, -0.49444119667433889, -0.9168291678773689);
            TestUtils.AreEqual(a2 / b2, r2);

            double4 a3 = double4(-416.22613234828509, -450.01919362042992, -273.49744594911925, -286.90817011841955);
            double4 b3 = double4(-375.82771342612227, -121.24548655433836, 447.623344391409, 338.28628007429018);
            double4 r3 = double4(1.1074918572499153, 3.7116366671409717, -0.61099906735420106, -0.84812239519560884);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double4_operator_div_wide_scalar()
        {
            double4 a0 = double4(171.34242184988341, 0.10338377957384637, 57.888263967767443, -256.13074529177078);
            double b0 = (171.79682191265601);
            double4 r0 = double4(0.99735501473360411, 0.00060177934855167557, 0.33695771157628673, -1.4908933846400916);
            TestUtils.AreEqual(a0 / b0, r0);

            double4 a1 = double4(95.6696842162263, -127.44869118903239, -79.7448890580539, 146.46688110496234);
            double b1 = (-290.38690461329509);
            double4 r1 = double4(-0.32945591793689361, 0.43889269510536072, 0.27461599607685222, -0.50438528314494968);
            TestUtils.AreEqual(a1 / b1, r1);

            double4 a2 = double4(-499.84355687529012, -453.20579859856787, -205.03382143985192, 481.73814247629514);
            double b2 = (58.686315802245531);
            double4 r2 = double4(-8.5172079733136776, -7.7225123506769311, -3.4937245358995028, 8.2086962844899229);
            TestUtils.AreEqual(a2 / b2, r2);

            double4 a3 = double4(464.47907159499778, -158.50557930697948, -289.5822156824089, 494.12860535743118);
            double b3 = (-293.46349753693841);
            double4 r3 = double4(-1.5827490488370997, 0.54012025562745947, 0.9867742261402, -1.683782172245238);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double4_operator_div_scalar_wide()
        {
            double a0 = (-264.44250095283729);
            double4 b0 = double4(105.58908157497137, -142.34910137129441, -288.94890679463231, 39.644133824689334);
            double4 r0 = double4(-2.5044492954044237, 1.85770404172122, 0.915187753732487, -6.670406827961755);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (-363.99138396046658);
            double4 b1 = double4(-149.71822006521666, -395.72912306139671, 258.71868693955184, -9.6662514254759344);
            double4 r1 = double4(2.4311762710103912, 0.91979933431382543, -1.4069002446874319, 37.655898645585339);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (117.72553282497711);
            double4 b2 = double4(-331.38655797177296, -509.98602676297821, 427.8964666928614, 467.61712882836218);
            double4 r2 = double4(-0.35525138239012338, -0.23084070277810059, 0.275126209232008, 0.25175624579866063);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-407.12461943511136);
            double4 b3 = double4(252.69070994699871, 444.59937664708093, -88.313306134340053, 199.95503411067421);
            double4 r3 = double4(-1.6111578439923842, -0.91571117914158318, 4.6100031496477243, -2.0360808681104259);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mod_wide_wide()
        {
            double4 a0 = double4(-388.81249422059045, 181.68118842955732, -167.07872470052854, 432.82015319951813);
            double4 b0 = double4(436.94417187056695, 58.940049437312382, -201.11623368091705, 279.2893537391393);
            double4 r0 = double4(-388.81249422059045, 4.8610401176201776, -167.07872470052854, 153.53079946037883);
            TestUtils.AreEqual(a0 % b0, r0);

            double4 a1 = double4(-258.43895995730486, -170.11079629236406, 283.318293464984, 122.71651297561664);
            double4 b1 = double4(-397.07975954426445, 377.89994758083481, 174.69386657266591, -228.17652736798698);
            double4 r1 = double4(-258.43895995730486, -170.11079629236406, 108.62442689231807, 122.71651297561664);
            TestUtils.AreEqual(a1 % b1, r1);

            double4 a2 = double4(335.27101413126616, -503.60851668920765, 191.02251848532933, 289.74269379756538);
            double4 b2 = double4(-317.06019106370405, -417.48011107811709, -249.9759434433542, -397.57157177364991);
            double4 r2 = double4(18.210823067562103, -86.128405611090557, 191.02251848532933, 289.74269379756538);
            TestUtils.AreEqual(a2 % b2, r2);

            double4 a3 = double4(-124.03371745163281, 259.27395761165485, -274.35845030208975, -140.03080398404541);
            double4 b3 = double4(-358.74544947163452, -198.15921005893461, 208.73709378425826, -12.119406944196385);
            double4 r3 = double4(-124.03371745163281, 61.114747552720246, -65.621356517831487, -6.7173275978851734);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mod_wide_scalar()
        {
            double4 a0 = double4(-244.49962889612635, -211.81931958525411, -145.92677576184588, -304.91822090042672);
            double b0 = (39.634963769295723);
            double4 r0 = double4(-6.6898462803520147, -13.644500738775491, -27.021884453958705, -27.473474515356656);
            TestUtils.AreEqual(a0 % b0, r0);

            double4 a1 = double4(155.47946436492703, 281.30965412841624, -226.53575311719243, 335.16613046041039);
            double b1 = (-133.90778428591221);
            double4 r1 = double4(21.571680079014811, 13.494085556591813, -92.627968831280214, 67.350561888585958);
            TestUtils.AreEqual(a1 % b1, r1);

            double4 a2 = double4(101.70649032560482, -285.40231646476423, -355.84685985923136, 259.37800061860025);
            double b2 = (319.47152033423606);
            double4 r2 = double4(101.70649032560482, -285.40231646476423, -36.3753395249953, 259.37800061860025);
            TestUtils.AreEqual(a2 % b2, r2);

            double4 a3 = double4(-330.87193957477433, -102.68343811048356, -172.14173921017988, 206.41684517935698);
            double b3 = (-284.34358109363518);
            double4 r3 = double4(-46.528358481139151, -102.68343811048356, -172.14173921017988, 206.41684517935698);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double4_operator_mod_scalar_wide()
        {
            double a0 = (-66.945025236785909);
            double4 b0 = double4(-249.77609479137516, -396.07375664081133, 386.49204582091977, 168.93948109864232);
            double4 r0 = double4(-66.945025236785909, -66.945025236785909, -66.945025236785909, -66.945025236785909);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (-199.4182442163202);
            double4 b1 = double4(261.7517141130528, 16.127438791155555, 257.66814744550186, -75.788451945310669);
            double4 r1 = double4(-199.4182442163202, -5.8889787224535439, -199.4182442163202, -47.841340325698866);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (170.95630439136005);
            double4 b2 = double4(-242.85828005655588, 425.94531913564788, 303.27240409668184, 3.033060790520608);
            double4 r2 = double4(170.95630439136005, 170.95630439136005, 170.95630439136005, 1.1049001222060042);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (-505.74352788633831);
            double4 b3 = double4(461.95706126743789, 205.97275672013529, 270.04063642678807, -47.480711720642034);
            double4 r3 = double4(-43.78646661890042, -93.798014446067725, -235.70289145955024, -30.936410679917969);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double4_operator_plus()
        {
            double4 a0 = double4(-418.82956357432045, -405.79894823851015, -34.041791216489742, 236.99924456188421);
            double4 r0 = double4(-418.82956357432045, -405.79894823851015, -34.041791216489742, 236.99924456188421);
            TestUtils.AreEqual(+a0, r0);

            double4 a1 = double4(-459.83910129025537, 293.74197902052754, -373.015422279488, -386.059833944803);
            double4 r1 = double4(-459.83910129025537, 293.74197902052754, -373.015422279488, -386.059833944803);
            TestUtils.AreEqual(+a1, r1);

            double4 a2 = double4(4.9544198536101476, 504.47483062393724, -170.74650843941907, 439.55937572920664);
            double4 r2 = double4(4.9544198536101476, 504.47483062393724, -170.74650843941907, 439.55937572920664);
            TestUtils.AreEqual(+a2, r2);

            double4 a3 = double4(-478.74939916969714, 421.40964742256779, -258.5960806620289, 447.86609122150867);
            double4 r3 = double4(-478.74939916969714, 421.40964742256779, -258.5960806620289, 447.86609122150867);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void double4_operator_neg()
        {
            double4 a0 = double4(148.46174890755754, -467.12267873581624, 132.04719954917539, 183.52262290917463);
            double4 r0 = double4(-148.46174890755754, 467.12267873581624, -132.04719954917539, -183.52262290917463);
            TestUtils.AreEqual(-a0, r0);

            double4 a1 = double4(473.7010145009034, -54.958759571872065, -382.98981803608581, -299.09338893512887);
            double4 r1 = double4(-473.7010145009034, 54.958759571872065, 382.98981803608581, 299.09338893512887);
            TestUtils.AreEqual(-a1, r1);

            double4 a2 = double4(-383.01406377508027, 168.73550351370852, 466.44152829909763, 171.90249474900895);
            double4 r2 = double4(383.01406377508027, -168.73550351370852, -466.44152829909763, -171.90249474900895);
            TestUtils.AreEqual(-a2, r2);

            double4 a3 = double4(-280.55831564616335, 318.69633522569029, -39.91539694737429, 140.34000284054321);
            double4 r3 = double4(280.55831564616335, -318.69633522569029, 39.91539694737429, -140.34000284054321);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void double4_operator_prefix_inc()
        {
            double4 a0 = double4(-139.84208137348389, -56.743654039103376, -381.955324589254, 509.79634380237962);
            double4 r0 = double4(-138.84208137348389, -55.743654039103376, -380.955324589254, 510.79634380237962);
            TestUtils.AreEqual(++a0, r0);

            double4 a1 = double4(-222.89634452708827, -392.73151058365193, -300.19410218866267, 362.21273939787068);
            double4 r1 = double4(-221.89634452708827, -391.73151058365193, -299.19410218866267, 363.21273939787068);
            TestUtils.AreEqual(++a1, r1);

            double4 a2 = double4(401.614830919362, -450.23016402229212, 243.54693114177644, 46.19202735190845);
            double4 r2 = double4(402.614830919362, -449.23016402229212, 244.54693114177644, 47.19202735190845);
            TestUtils.AreEqual(++a2, r2);

            double4 a3 = double4(-41.497298975241051, 154.35656530892311, -281.23327435237974, 200.70599922943211);
            double4 r3 = double4(-40.497298975241051, 155.35656530892311, -280.23327435237974, 201.70599922943211);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void double4_operator_postfix_inc()
        {
            double4 a0 = double4(-396.6697396695007, 511.20749378167443, 249.11127030528678, -128.81731301584154);
            double4 r0 = double4(-396.6697396695007, 511.20749378167443, 249.11127030528678, -128.81731301584154);
            TestUtils.AreEqual(a0++, r0);

            double4 a1 = double4(-259.49027669592306, -81.393423356764686, 66.719732554033271, 167.85212691493894);
            double4 r1 = double4(-259.49027669592306, -81.393423356764686, 66.719732554033271, 167.85212691493894);
            TestUtils.AreEqual(a1++, r1);

            double4 a2 = double4(147.94395048354932, 41.033564825092185, 128.5304239394751, 73.155582223625629);
            double4 r2 = double4(147.94395048354932, 41.033564825092185, 128.5304239394751, 73.155582223625629);
            TestUtils.AreEqual(a2++, r2);

            double4 a3 = double4(-60.132380275117384, -296.93783797739906, 267.29380071689081, 446.22930714405572);
            double4 r3 = double4(-60.132380275117384, -296.93783797739906, 267.29380071689081, 446.22930714405572);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void double4_operator_prefix_dec()
        {
            double4 a0 = double4(123.12869626056806, 256.8437465433235, 156.33078844674435, 461.73742530389563);
            double4 r0 = double4(122.12869626056806, 255.84374654332351, 155.33078844674435, 460.73742530389563);
            TestUtils.AreEqual(--a0, r0);

            double4 a1 = double4(325.86799755965728, 187.87412580655609, -236.2252043393558, 125.10963517292851);
            double4 r1 = double4(324.86799755965728, 186.87412580655609, -237.2252043393558, 124.10963517292851);
            TestUtils.AreEqual(--a1, r1);

            double4 a2 = double4(469.8447313112415, 376.04684680329956, -363.07547991493504, -22.028951416736902);
            double4 r2 = double4(468.8447313112415, 375.04684680329956, -364.07547991493504, -23.028951416736902);
            TestUtils.AreEqual(--a2, r2);

            double4 a3 = double4(248.79012667797042, 168.26565011230559, -190.284744112885, 166.9455474200405);
            double4 r3 = double4(247.79012667797042, 167.26565011230559, -191.284744112885, 165.9455474200405);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void double4_operator_postfix_dec()
        {
            double4 a0 = double4(379.68831723727669, 302.69287814884115, -176.07134040448409, -291.25267066212962);
            double4 r0 = double4(379.68831723727669, 302.69287814884115, -176.07134040448409, -291.25267066212962);
            TestUtils.AreEqual(a0--, r0);

            double4 a1 = double4(470.56758401848731, -63.655158787805192, 355.26110069605568, -27.889220489137415);
            double4 r1 = double4(470.56758401848731, -63.655158787805192, 355.26110069605568, -27.889220489137415);
            TestUtils.AreEqual(a1--, r1);

            double4 a2 = double4(-100.76183824462902, 479.94519613680677, -200.30429491787419, -445.0269393609031);
            double4 r2 = double4(-100.76183824462902, 479.94519613680677, -200.30429491787419, -445.0269393609031);
            TestUtils.AreEqual(a2--, r2);

            double4 a3 = double4(407.42034907239508, 48.0602071509046, -209.66798100698179, -38.435048836485976);
            double4 r3 = double4(407.42034907239508, 48.0602071509046, -209.66798100698179, -38.435048836485976);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void double4_shuffle_result_1()
        {
            double4 a = double4(0, 1, 2, 3);
            double4 b = double4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW), (7));
        }

        [TestCompiler]
        public void double4_shuffle_result_2()
        {
            double4 a = double4(0, 1, 2, 3);
            double4 b = double4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), double2(5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX), double2(6, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), double2(1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftW), double2(7, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftZ), double2(7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), double2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW), double2(5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), double2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightW), double2(6, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ), double2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), double2(6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), double2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), double2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightY), double2(7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), double2(4, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW), double2(1, 3));
        }

        [TestCompiler]
        public void double4_shuffle_result_3()
        {
            double4 a = double4(0, 1, 2, 3);
            double4 b = double4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightY), double3(2, 7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.LeftW), double3(6, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightX), double3(2, 7, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), double3(5, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), double3(7, 6, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightX), double3(3, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightW), double3(3, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.RightZ), double3(6, 5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), double3(5, 4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightW, ShuffleComponent.LeftX), double3(7, 7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(6, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightW), double3(6, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightY), double3(3, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), double3(6, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightW), double3(5, 1, 7));
        }

        [TestCompiler]
        public void double4_shuffle_result_4()
        {
            double4 a = double4(0, 1, 2, 3);
            double4 b = double4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ), double4(1, 3, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightZ), double4(5, 3, 6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.RightW, ShuffleComponent.LeftZ), double4(6, 6, 7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ), double4(4, 5, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), double4(6, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightW), double4(4, 5, 5, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightW, ShuffleComponent.LeftX, ShuffleComponent.RightW), double4(1, 7, 0, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftX), double4(5, 0, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightW, ShuffleComponent.LeftW, ShuffleComponent.LeftY), double4(4, 7, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), double4(5, 4, 1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), double4(0, 2, 6, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightW, ShuffleComponent.RightW), double4(2, 5, 7, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ, ShuffleComponent.RightX), double4(3, 4, 2, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), double4(4, 0, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(6, 4, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.LeftY, ShuffleComponent.RightY), double4(3, 7, 1, 5));
        }


    }
}
