// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble2
    {
        [TestCompiler]
        public void double2_zero()
        {
            TestUtils.AreEqual(double2.zero.x, 0.0);
            TestUtils.AreEqual(double2.zero.y, 0.0);
        }

        [TestCompiler]
        public void double2_constructor()
        {
            double2 a = new double2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public void double2_scalar_constructor()
        {
            double2 a = new double2(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
        }

        [TestCompiler]
        public void double2_static_constructor()
        {
            double2 a = double2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public void double2_static_scalar_constructor()
        {
            double2 a = double2(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
        }

        [TestCompiler]
        public void double2_operator_equal_wide_wide()
        {
            double2 a0 = double2(492.15758275061728, -495.20632027797694);
            double2 b0 = double2(192.56880888369346, -235.61102472786376);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2 a1 = double2(227.45765195947968, -147.37405950733182);
            double2 b1 = double2(-254.04311740307281, -412.62472052715009);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2 a2 = double2(-222.68201909897942, 64.093720704360749);
            double2 b2 = double2(471.90480945627428, -6.4727852374654162);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2 a3 = double2(-23.890404473939157, -16.8197190839889);
            double2 b3 = double2(-339.10237447316865, 488.1875700839737);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double2_operator_equal_wide_scalar()
        {
            double2 a0 = double2(-303.2300766926399, 451.52631327674089);
            double b0 = (123.5445759871717);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2 a1 = double2(-253.65587413201848, -500.6910920090466);
            double b1 = (-105.20363502632995);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2 a2 = double2(-426.19248338518315, -59.558379439431405);
            double b2 = (159.87609656149334);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2 a3 = double2(-57.477391031327386, 406.51375861024189);
            double b3 = (-182.0497396840014);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double2_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double2 b0 = double2(19.952187785856495, -185.79199346610903);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (407.8136052600172);
            double2 b1 = double2(-87.2766969610363, -206.27469382354741);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (160.503138855334);
            double2 b2 = double2(-274.77081478516141, -2.6315281403397535);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (448.35453602688131);
            double2 b3 = double2(-410.03524251004461, 247.32901465489022);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void double2_operator_not_equal_wide_wide()
        {
            double2 a0 = double2(430.8425316432689, 104.69001798736394);
            double2 b0 = double2(210.02470622305975, -55.203330304102678);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2 a1 = double2(225.80243478799355, -310.57017841496048);
            double2 b1 = double2(-269.92533672504373, -234.54673372700194);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2 a2 = double2(-418.61945815506363, 304.12820281839379);
            double2 b2 = double2(25.917412054686565, -63.726991444699024);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2 a3 = double2(-509.32682561749908, -160.53807719076895);
            double2 b3 = double2(-484.55371092471933, -425.333599050219);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double2_operator_not_equal_wide_scalar()
        {
            double2 a0 = double2(-16.914588697680529, 168.83411486858233);
            double b0 = (-145.37277109239847);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2 a1 = double2(-462.71352145760949, 214.50161443208424);
            double b1 = (130.30776959765137);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2 a2 = double2(-440.26328178879959, -169.09985860115842);
            double b2 = (-197.12796053529155);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2 a3 = double2(-386.61117595555783, -270.26885593601912);
            double b3 = (-281.02101362916687);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double2_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double2 b0 = double2(-57.196896341255353, -382.4325279586169);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (97.820359990848374);
            double2 b1 = double2(-161.46364529499022, -458.39563367254829);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-499.61786364932448);
            double2 b2 = double2(327.92217818271467, 367.57121699283425);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (59.7863667289663);
            double2 b3 = double2(-209.58068118318016, -62.580453186566217);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_wide_wide()
        {
            double2 a0 = double2(196.84256825076534, 336.40979997087732);
            double2 b0 = double2(-465.34502313348696, -256.15239751346053);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double2 a1 = double2(251.96372115424072, 257.65591466503963);
            double2 b1 = double2(-314.814018634527, 364.56673662949663);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double2 a2 = double2(430.04588647840819, -62.419644146421774);
            double2 b2 = double2(100.21050290959443, 182.56098636545289);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double2 a3 = double2(8.8392293494376872, -333.81671563434259);
            double2 b3 = double2(3.116978885194726, -259.43047893207074);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_wide_scalar()
        {
            double2 a0 = double2(-132.05731708000292, -192.46500477216438);
            double b0 = (-156.01021845452965);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double2 a1 = double2(-66.834607870706634, -360.28242199508588);
            double b1 = (-379.01750081545561);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double2 a2 = double2(20.927834282129879, 437.34587522845061);
            double b2 = (-158.24074537970159);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double2 a3 = double2(-20.452607402788772, 307.48418607725023);
            double b3 = (225.29148517609178);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_scalar_wide()
        {
            double a0 = (-423.117411095238);
            double2 b0 = double2(385.09483617595151, -123.93348532725753);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (86.376572887588509);
            double2 b1 = double2(133.44217378154497, 161.45794947513286);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (229.75426660746064);
            double2 b2 = double2(222.57159934871436, 315.53116360098647);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (-447.20351883731945);
            double2 b3 = double2(271.83385790131695, -393.60531324595462);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_wide_wide()
        {
            double2 a0 = double2(483.50140141113729, 310.81563415695712);
            double2 b0 = double2(-471.39802454011425, -371.98528617060992);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double2 a1 = double2(106.9661896726891, 295.73526038589671);
            double2 b1 = double2(36.900723236101044, -316.76360407320954);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double2 a2 = double2(116.95757179938141, -478.29977653841479);
            double2 b2 = double2(19.683055648432628, 207.3091381561519);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double2 a3 = double2(-14.897393471979228, -33.817441717636484);
            double2 b3 = double2(362.79748861994483, 324.95341816775192);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_wide_scalar()
        {
            double2 a0 = double2(64.317918092160426, -397.70346445483318);
            double b0 = (305.85991992888034);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double2 a1 = double2(431.87690826499693, 246.26305233978803);
            double b1 = (85.702980796668157);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double2 a2 = double2(197.49155602114809, 280.81334818564972);
            double b2 = (286.1994608781298);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double2 a3 = double2(-405.78459210218148, -241.80727326209063);
            double b3 = (171.56538661362856);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_scalar_wide()
        {
            double a0 = (-282.67049635698572);
            double2 b0 = double2(358.09997360692353, -72.5964134077525);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (-232.16380106292843);
            double2 b1 = double2(-60.706723956720282, 75.156642710397364);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (150.88350040786133);
            double2 b2 = double2(339.53917924479538, -498.19602965665797);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (459.74610326241054);
            double2 b3 = double2(-227.96872316485678, 335.86213485145106);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_equal_wide_wide()
        {
            double2 a0 = double2(-438.52313753521219, 210.48942837980087);
            double2 b0 = double2(-474.8141498392514, 304.3710555063426);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2 a1 = double2(4.8773329280677444, -137.29793817237857);
            double2 b1 = double2(234.8241737982371, -390.48543209139513);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2 a2 = double2(156.09410174009111, -363.92412035722475);
            double2 b2 = double2(-297.17535295019638, -326.29239121372461);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2 a3 = double2(-97.948485181642923, 437.29539009430232);
            double2 b3 = double2(107.2538764976216, -413.13107342884462);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_equal_wide_scalar()
        {
            double2 a0 = double2(193.4958237118534, 168.91555197952107);
            double b0 = (443.85054299042122);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2 a1 = double2(-313.9930695565385, 18.503590830836288);
            double b1 = (81.826965131716292);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2 a2 = double2(-0.35819602029312136, -463.81641242644582);
            double b2 = (241.36115776810846);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2 a3 = double2(-1.3577692515020203, 398.9919504593089);
            double b3 = (-268.89945591096739);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_less_equal_scalar_wide()
        {
            double a0 = (393.60626644343427);
            double2 b0 = double2(-75.688363825757222, -44.2638714519627);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (125.8649156679702);
            double2 b1 = double2(191.96488174794467, 13.543054825413492);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (-197.0519259893577);
            double2 b2 = double2(-423.945100743298, -330.04861680141119);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (420.16553779140372);
            double2 b3 = double2(105.54730777887039, 174.82126363311954);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_equal_wide_wide()
        {
            double2 a0 = double2(-507.92858409692, 504.49748181947393);
            double2 b0 = double2(-81.346509732933043, 297.66615047010885);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2 a1 = double2(-385.43449205226938, -262.32340944107784);
            double2 b1 = double2(171.06540616371922, -431.03805538222105);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2 a2 = double2(-37.550928848586466, -111.59527759980193);
            double2 b2 = double2(-6.859075311040101, 319.72570362674332);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2 a3 = double2(-463.70202157632542, 387.44885772627265);
            double2 b3 = double2(254.079170106947, 396.5724000393285);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_equal_wide_scalar()
        {
            double2 a0 = double2(465.15218732559686, -424.8860745024337);
            double b0 = (-5.5998842742293391);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2 a1 = double2(-209.22109685150025, -302.26910533675414);
            double b1 = (58.779852656079356);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2 a2 = double2(140.12558252183976, -344.55997316192838);
            double b2 = (16.353385694489475);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2 a3 = double2(393.27804846003562, 441.0115565923096);
            double b3 = (-315.70155086913218);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_greater_equal_scalar_wide()
        {
            double a0 = (374.82703393270594);
            double2 b0 = double2(-1.609757185731894, 338.61524049314448);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-116.18140392945213);
            double2 b1 = double2(-332.15732375353451, -355.9793509710484);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (-468.90144107719021);
            double2 b2 = double2(38.579884785497484, -332.34754697063357);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (2.8901150240051265);
            double2 b3 = double2(467.77776477661814, 121.40638762405445);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void double2_operator_add_wide_wide()
        {
            double2 a0 = double2(506.12905263627374, -501.77980803967444);
            double2 b0 = double2(-28.757987751047096, -337.135153689019);
            double2 r0 = double2(477.37106488522664, -838.91496172869347);
            TestUtils.AreEqual(a0 + b0, r0);

            double2 a1 = double2(420.08479638587903, -186.03206476291274);
            double2 b1 = double2(-340.676816860529, 152.31202633320913);
            double2 r1 = double2(79.407979525350015, -33.720038429703607);
            TestUtils.AreEqual(a1 + b1, r1);

            double2 a2 = double2(-9.3123953385801883, 328.51179686585056);
            double2 b2 = double2(423.66745420157326, 90.374096674087468);
            double2 r2 = double2(414.35505886299308, 418.885893539938);
            TestUtils.AreEqual(a2 + b2, r2);

            double2 a3 = double2(424.34407659263536, 87.791079800478656);
            double2 b3 = double2(376.18866246574964, 1.7671887882831925);
            double2 r3 = double2(800.532739058385, 89.558268588761848);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double2_operator_add_wide_scalar()
        {
            double2 a0 = double2(-194.51420387742769, 338.54838696985894);
            double b0 = (124.121678171736);
            double2 r0 = double2(-70.3925257056917, 462.67006514159493);
            TestUtils.AreEqual(a0 + b0, r0);

            double2 a1 = double2(246.97140252169754, -45.724677822424439);
            double b1 = (100.51093797595752);
            double2 r1 = double2(347.48234049765506, 54.786260153533078);
            TestUtils.AreEqual(a1 + b1, r1);

            double2 a2 = double2(-478.11131094308166, 60.37435224483454);
            double b2 = (30.916145577522116);
            double2 r2 = double2(-447.19516536555955, 91.290497822356656);
            TestUtils.AreEqual(a2 + b2, r2);

            double2 a3 = double2(-242.1187475855084, 6.7993848355483806);
            double b3 = (82.50134495762245);
            double2 r3 = double2(-159.61740262788595, 89.300729793170831);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double2_operator_add_scalar_wide()
        {
            double a0 = (-340.35468284243473);
            double2 b0 = double2(511.36225652665007, -146.21663791789518);
            double2 r0 = double2(171.00757368421535, -486.57132076032991);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (-106.21042661844308);
            double2 b1 = double2(-363.45024960276214, 199.08958325120136);
            double2 r1 = double2(-469.66067622120522, 92.879156632758281);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (-27.108407271610758);
            double2 b2 = double2(419.84900041103788, 284.95503748811552);
            double2 r2 = double2(392.74059313942712, 257.84663021650476);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (-164.92418129971446);
            double2 b3 = double2(-249.19032561461921, 150.92817718858282);
            double2 r3 = double2(-414.11450691433367, -13.99600411113164);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void double2_operator_sub_wide_wide()
        {
            double2 a0 = double2(160.4922617229131, 11.223957305412682);
            double2 b0 = double2(115.46876078260539, -130.98230630298252);
            double2 r0 = double2(45.023500940307713, 142.2062636083952);
            TestUtils.AreEqual(a0 - b0, r0);

            double2 a1 = double2(359.20010607279846, -498.22830485656311);
            double2 b1 = double2(241.54083716196044, 9.9870860623135513);
            double2 r1 = double2(117.65926891083802, -508.21539091887666);
            TestUtils.AreEqual(a1 - b1, r1);

            double2 a2 = double2(-355.25362913462038, -94.534852787170053);
            double2 b2 = double2(419.89512582304656, 59.124466208333388);
            double2 r2 = double2(-775.14875495766694, -153.65931899550344);
            TestUtils.AreEqual(a2 - b2, r2);

            double2 a3 = double2(-410.46404786150163, -401.38464398001537);
            double2 b3 = double2(-402.38163847587145, -75.370143687059226);
            double2 r3 = double2(-8.0824093856301715, -326.01450029295614);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double2_operator_sub_wide_scalar()
        {
            double2 a0 = double2(207.38960108877609, 248.45773684627272);
            double b0 = (-36.112476604111691);
            double2 r0 = double2(243.50207769288778, 284.57021345038441);
            TestUtils.AreEqual(a0 - b0, r0);

            double2 a1 = double2(-384.82393211164697, -374.81156152058929);
            double b1 = (-205.34476122881506);
            double2 r1 = double2(-179.47917088283191, -169.46680029177423);
            TestUtils.AreEqual(a1 - b1, r1);

            double2 a2 = double2(191.64204820973896, -44.96160151667965);
            double b2 = (18.856238135535364);
            double2 r2 = double2(172.7858100742036, -63.817839652215014);
            TestUtils.AreEqual(a2 - b2, r2);

            double2 a3 = double2(480.85798738936796, -366.86545269883493);
            double b3 = (16.338193185784917);
            double2 r3 = double2(464.51979420358305, -383.20364588461985);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double2_operator_sub_scalar_wide()
        {
            double a0 = (-86.008225719448262);
            double2 b0 = double2(466.42511413359318, 298.48694219183506);
            double2 r0 = double2(-552.43333985304139, -384.49516791128332);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (-300.95010652251085);
            double2 b1 = double2(315.38003006362362, -381.09218543632522);
            double2 r1 = double2(-616.33013658613447, 80.142078913814373);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (-125.00837546447684);
            double2 b2 = double2(58.466194418476107, 214.74609361158036);
            double2 r2 = double2(-183.47456988295295, -339.75446907605721);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (-257.54942739082009);
            double2 b3 = double2(480.22459505508868, -443.35507723472784);
            double2 r3 = double2(-737.77402244590871, 185.80564984390776);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mul_wide_wide()
        {
            double2 a0 = double2(-482.71381710596097, -407.29348559272171);
            double2 b0 = double2(-236.36788355389979, 260.72759139757954);
            double2 r0 = double2(114098.04331156027, -106192.64949051509);
            TestUtils.AreEqual(a0 * b0, r0);

            double2 a1 = double2(137.70058995937029, 208.54113278563182);
            double2 b1 = double2(-416.38629718142852, -364.49561541364324);
            double2 r1 = double2(-57336.638772880389, -76012.328533757158);
            TestUtils.AreEqual(a1 * b1, r1);

            double2 a2 = double2(194.296573967811, -484.24241684574747);
            double2 b2 = double2(-253.14750897751537, -369.20287220981106);
            double2 r2 = double2(-49185.69370281692, 178783.69114527057);
            TestUtils.AreEqual(a2 * b2, r2);

            double2 a3 = double2(183.98730739578014, -241.33547770294149);
            double2 b3 = double2(193.54791531038836, 169.08491976982214);
            double2 r3 = double2(35610.359790024842, -40806.189885013562);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mul_wide_scalar()
        {
            double2 a0 = double2(-96.318821236639678, -277.14229239017811);
            double b0 = (-301.20720424373042);
            double2 r0 = double2(29011.922860739887, 83477.255068544036);
            TestUtils.AreEqual(a0 * b0, r0);

            double2 a1 = double2(-239.93690191951436, 255.85810172551226);
            double b1 = (509.53140544776409);
            double2 r1 = double2(-122255.38685383248, 130367.73816739726);
            TestUtils.AreEqual(a1 * b1, r1);

            double2 a2 = double2(215.73149667295229, -389.24327367788334);
            double b2 = (-455.50827500573746);
            double2 r2 = double2(-98267.481913902491, 177303.53215059883);
            TestUtils.AreEqual(a2 * b2, r2);

            double2 a3 = double2(-338.29248658674419, 243.75734459783757);
            double b3 = (53.796284939067618);
            double2 r3 = double2(-18198.879001166202, 13113.239565975766);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mul_scalar_wide()
        {
            double a0 = (37.432166355397612);
            double2 b0 = double2(96.747546479454058, 492.18539427788244);
            double2 r0 = double2(3621.4702542954869, 18423.565556306661);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (-274.05458534604617);
            double2 b1 = double2(-452.87096926796761, 420.85330434369541);
            double2 r1 = double2(124111.36569799489, -115336.77781342482);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (102.18292694081686);
            double2 b2 = double2(-114.94887762654054, -351.12003843445336);
            double2 r2 = double2(-11745.812764441689, -35878.473234804551);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (-464.66496799172131);
            double2 b3 = double2(444.08484646495663, 447.10525605040846);
            double2 r3 = double2(-206350.67096824755, -207754.14949159342);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void double2_operator_div_wide_wide()
        {
            double2 a0 = double2(-353.13144390337703, -102.79985456485292);
            double2 b0 = double2(-178.73954805114283, -302.09628381491467);
            double2 r0 = double2(1.97567604793504, 0.34028837848212429);
            TestUtils.AreEqual(a0 / b0, r0);

            double2 a1 = double2(51.319128298814917, -191.87167868012176);
            double2 b1 = double2(-199.40583739029518, 278.85077561012042);
            double2 r1 = double2(-0.25736021056579439, -0.68808013268139567);
            TestUtils.AreEqual(a1 / b1, r1);

            double2 a2 = double2(8.0418245829836223, -128.73764210973758);
            double2 b2 = double2(502.33758782890516, -361.48483078623417);
            double2 r2 = double2(0.016008805189634039, 0.35613566917796119);
            TestUtils.AreEqual(a2 / b2, r2);

            double2 a3 = double2(-136.05959779399427, -370.4710053738537);
            double2 b3 = double2(353.121059820578, -38.894930142394685);
            double2 r3 = double2(-0.3853058151307277, 9.5249176182488586);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double2_operator_div_wide_scalar()
        {
            double2 a0 = double2(171.34242184988341, 0.10338377957384637);
            double b0 = (171.79682191265601);
            double2 r0 = double2(0.99735501473360411, 0.00060177934855167557);
            TestUtils.AreEqual(a0 / b0, r0);

            double2 a1 = double2(57.888263967767443, 95.6696842162263);
            double b1 = (-256.13074529177078);
            double2 r1 = double2(-0.22601060213143936, -0.37351893895925842);
            TestUtils.AreEqual(a1 / b1, r1);

            double2 a2 = double2(-290.38690461329509, -79.7448890580539);
            double b2 = (-127.44869118903239);
            double2 r2 = double2(2.2784612529491741, 0.6257019065011501);
            TestUtils.AreEqual(a2 / b2, r2);

            double2 a3 = double2(146.46688110496234, 58.686315802245531);
            double b3 = (-499.84355687529012);
            double2 r3 = double2(-0.29302544584265894, -0.11740936738109768);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double2_operator_div_scalar_wide()
        {
            double a0 = (-264.44250095283729);
            double2 b0 = double2(105.58908157497137, -142.34910137129441);
            double2 r0 = double2(-2.5044492954044237, 1.85770404172122);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (-288.94890679463231);
            double2 b1 = double2(39.644133824689334, -363.99138396046658);
            double2 r1 = double2(-7.2885665272041447, 0.79383446841701977);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (-149.71822006521666);
            double2 b2 = double2(-395.72912306139671, 258.71868693955184);
            double2 r2 = double2(0.37833510687053507, -0.57869117162069339);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-9.6662514254759344);
            double2 b3 = double2(117.72553282497711, -331.38655797177296);
            double2 r3 = double2(-0.082108368452634473, 0.029169111398595994);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mod_wide_wide()
        {
            double2 a0 = double2(-388.81249422059045, 181.68118842955732);
            double2 b0 = double2(436.94417187056695, 58.940049437312382);
            double2 r0 = double2(-388.81249422059045, 4.8610401176201776);
            TestUtils.AreEqual(a0 % b0, r0);

            double2 a1 = double2(-167.07872470052854, 432.82015319951813);
            double2 b1 = double2(-201.11623368091705, 279.2893537391393);
            double2 r1 = double2(-167.07872470052854, 153.53079946037883);
            TestUtils.AreEqual(a1 % b1, r1);

            double2 a2 = double2(-258.43895995730486, -170.11079629236406);
            double2 b2 = double2(-397.07975954426445, 377.89994758083481);
            double2 r2 = double2(-258.43895995730486, -170.11079629236406);
            TestUtils.AreEqual(a2 % b2, r2);

            double2 a3 = double2(283.318293464984, 122.71651297561664);
            double2 b3 = double2(174.69386657266591, -228.17652736798698);
            double2 r3 = double2(108.62442689231807, 122.71651297561664);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mod_wide_scalar()
        {
            double2 a0 = double2(-244.49962889612635, -211.81931958525411);
            double b0 = (39.634963769295723);
            double2 r0 = double2(-6.6898462803520147, -13.644500738775491);
            TestUtils.AreEqual(a0 % b0, r0);

            double2 a1 = double2(-145.92677576184588, 155.47946436492703);
            double b1 = (-304.91822090042672);
            double2 r1 = double2(-145.92677576184588, 155.47946436492703);
            TestUtils.AreEqual(a1 % b1, r1);

            double2 a2 = double2(-133.90778428591221, -226.53575311719243);
            double b2 = (281.30965412841624);
            double2 r2 = double2(-133.90778428591221, -226.53575311719243);
            TestUtils.AreEqual(a2 % b2, r2);

            double2 a3 = double2(335.16613046041039, 319.47152033423606);
            double b3 = (101.70649032560482);
            double2 r3 = double2(30.046659483595931, 14.352049357421606);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double2_operator_mod_scalar_wide()
        {
            double a0 = (-66.945025236785909);
            double2 b0 = double2(-249.77609479137516, -396.07375664081133);
            double2 r0 = double2(-66.945025236785909, -66.945025236785909);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (386.49204582091977);
            double2 b1 = double2(168.93948109864232, -199.4182442163202);
            double2 r1 = double2(48.613083623635134, 187.07380160459957);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (261.7517141130528);
            double2 b2 = double2(16.127438791155555, 257.66814744550186);
            double2 r2 = double2(3.7126934545639187, 4.08356666755094);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (-75.788451945310669);
            double2 b3 = double2(170.95630439136005, -242.85828005655588);
            double2 r3 = double2(-75.788451945310669, -75.788451945310669);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void double2_operator_plus()
        {
            double2 a0 = double2(-418.82956357432045, -405.79894823851015);
            double2 r0 = double2(-418.82956357432045, -405.79894823851015);
            TestUtils.AreEqual(+a0, r0);

            double2 a1 = double2(-34.041791216489742, -459.83910129025537);
            double2 r1 = double2(-34.041791216489742, -459.83910129025537);
            TestUtils.AreEqual(+a1, r1);

            double2 a2 = double2(210.8614223985287, -373.015422279488);
            double2 r2 = double2(210.8614223985287, -373.015422279488);
            TestUtils.AreEqual(+a2, r2);

            double2 a3 = double2(-386.059833944803, -418.64524932328857);
            double2 r3 = double2(-386.059833944803, -418.64524932328857);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void double2_operator_neg()
        {
            double2 a0 = double2(148.46174890755754, -467.12267873581624);
            double2 r0 = double2(-148.46174890755754, 467.12267873581624);
            TestUtils.AreEqual(-a0, r0);

            double2 a1 = double2(132.04719954917539, 473.7010145009034);
            double2 r1 = double2(-132.04719954917539, -473.7010145009034);
            TestUtils.AreEqual(-a1, r1);

            double2 a2 = double2(-407.99109024926605, -382.98981803608581);
            double2 r2 = double2(407.99109024926605, 382.98981803608581);
            TestUtils.AreEqual(-a2, r2);

            double2 a3 = double2(-299.09338893512887, 407.70980305583669);
            double2 r3 = double2(299.09338893512887, -407.70980305583669);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void double2_operator_prefix_inc()
        {
            double2 a0 = double2(-139.84208137348389, -56.743654039103376);
            double2 r0 = double2(-138.84208137348389, -55.743654039103376);
            TestUtils.AreEqual(++a0, r0);

            double2 a1 = double2(-381.955324589254, -222.89634452708827);
            double2 r1 = double2(-380.955324589254, -221.89634452708827);
            TestUtils.AreEqual(++a1, r1);

            double2 a2 = double2(210.31986556310199, -300.19410218866267);
            double2 r2 = double2(211.31986556310199, -299.19410218866267);
            TestUtils.AreEqual(++a2, r2);

            double2 a3 = double2(362.21273939787068, 130.90919429199266);
            double2 r3 = double2(363.21273939787068, 131.90919429199266);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void double2_operator_postfix_inc()
        {
            double2 a0 = double2(-396.6697396695007, 511.20749378167443);
            double2 r0 = double2(-396.6697396695007, 511.20749378167443);
            TestUtils.AreEqual(a0++, r0);

            double2 a1 = double2(249.11127030528678, -259.49027669592306);
            double2 r1 = double2(249.11127030528678, -259.49027669592306);
            TestUtils.AreEqual(a1++, r1);

            double2 a2 = double2(278.00817764830219, 66.719732554033271);
            double2 r2 = double2(278.00817764830219, 66.719732554033271);
            TestUtils.AreEqual(a2++, r2);

            double2 a3 = double2(167.85212691493894, -326.10758486674524);
            double2 r3 = double2(167.85212691493894, -326.10758486674524);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void double2_operator_prefix_dec()
        {
            double2 a0 = double2(123.12869626056806, 256.8437465433235);
            double2 r0 = double2(122.12869626056806, 255.84374654332351);
            TestUtils.AreEqual(--a0, r0);

            double2 a1 = double2(156.33078844674435, 325.86799755965728);
            double2 r1 = double2(155.33078844674435, 324.86799755965728);
            TestUtils.AreEqual(--a1, r1);

            double2 a2 = double2(392.01561731473339, -236.2252043393558);
            double2 r2 = double2(391.01561731473339, -237.2252043393558);
            TestUtils.AreEqual(--a2, r2);

            double2 a3 = double2(125.10963517292851, 45.536655685648611);
            double2 r3 = double2(124.10963517292851, 44.536655685648611);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void double2_operator_postfix_dec()
        {
            double2 a0 = double2(379.68831723727669, 302.69287814884115);
            double2 r0 = double2(379.68831723727669, 302.69287814884115);
            TestUtils.AreEqual(a0--, r0);

            double2 a1 = double2(-176.07134040448409, 470.56758401848731);
            double2 r1 = double2(-176.07134040448409, 470.56758401848731);
            TestUtils.AreEqual(a1--, r1);

            double2 a2 = double2(-402.92594666170231, 355.26110069605568);
            double2 r2 = double2(-402.92594666170231, 355.26110069605568);
            TestUtils.AreEqual(a2--, r2);

            double2 a3 = double2(-27.889220489137415, 156.14034969924967);
            double2 r3 = double2(-27.889220489137415, 156.14034969924967);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void double2_shuffle_result_1()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public void double2_shuffle_result_2()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), double2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), double2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), double2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), double2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), double2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), double2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), double2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), double2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), double2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), double2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), double2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), double2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), double2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), double2(3, 3));
        }

        [TestCompiler]
        public void double2_shuffle_result_3()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), double3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), double3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), double3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), double3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), double3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), double3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), double3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), double3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), double3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double3(3, 1, 1));
        }

        [TestCompiler]
        public void double2_shuffle_result_4()
        {
            double2 a = double2(0, 1);
            double2 b = double2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), double4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), double4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), double4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), double4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), double4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), double4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), double4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), double4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), double4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), double4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double4(2, 0, 0, 0));
        }


    }
}
