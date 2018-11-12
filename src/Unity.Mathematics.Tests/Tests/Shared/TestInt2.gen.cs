// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2
    {
        [TestCompiler]
        public void int2_zero()
        {
            TestUtils.AreEqual(int2.zero.x, 0);
            TestUtils.AreEqual(int2.zero.y, 0);
        }

        [TestCompiler]
        public void int2_constructor()
        {
            int2 a = new int2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public void int2_scalar_constructor()
        {
            int2 a = new int2(17);
            TestUtils.AreEqual(a.x, 17);
            TestUtils.AreEqual(a.y, 17);
        }

        [TestCompiler]
        public void int2_static_constructor()
        {
            int2 a = int2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public void int2_static_scalar_constructor()
        {
            int2 a = int2(17);
            TestUtils.AreEqual(a.x, 17);
            TestUtils.AreEqual(a.y, 17);
        }

        [TestCompiler]
        public void int2_operator_equal_wide_wide()
        {
            int2 a0 = int2(2105871082, 35218899);
            int2 b0 = int2(1477587886, 579629692);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(1550755093, 764676020);
            int2 b1 = int2(540974792, 208405066);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(606743782, 1208156098);
            int2 b2 = int2(2063397938, 1060167409);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(1023640014, 1038468316);
            int2 b3 = int2(362592601, 2097545362);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2_operator_equal_wide_scalar()
        {
            int2 a0 = int2(437822262, 2020661134);
            int b0 = (1332833578);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(541786900, 23716499);
            int b1 = (853113810);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(179951405, 948838849);
            int b2 = (1409026299);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(953202998, 1926262965);
            int b3 = (691955848);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2_operator_equal_scalar_wide()
        {
            int a0 = (542329200);
            int2 b0 = int2(1115584594, 684107773);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1928988941);
            int2 b1 = int2(890709324, 641152437);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1410341302);
            int2 b2 = int2(497505660, 1068223109);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (2014009435);
            int2 b3 = int2(213835595, 1592428361);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2_operator_not_equal_wide_wide()
        {
            int2 a0 = int2(1977284100, 1293292704);
            int2 b0 = int2(1514195556, 957972049);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(1547283851, 422428953);
            int2 b1 = int2(507667364, 581861672);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(195833190, 1711544892);
            int2 b2 = int2(1128094576, 940096636);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(5606053, 737069074);
            int2 b3 = int2(57559040, 181752616);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2_operator_not_equal_wide_scalar()
        {
            int2 a0 = int2(1038269360, 1427812625);
            int b0 = (768873026);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(103361237, 1523584313);
            int b1 = (1347017023);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(150442802, 719113717);
            int b2 = (660334527);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(262959423, 506946952);
            int b3 = (484398043);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2_operator_not_equal_scalar_wide()
        {
            int a0 = (1652127596);
            int2 b0 = int2(953791238, 271722683);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1278885987);
            int2 b1 = int2(735128017, 112416504);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (25967222);
            int2 b2 = int2(1761444475, 1844594536);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1199122922);
            int2 b3 = int2(634219279, 942501101);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_wide_wide()
        {
            int2 a0 = int2(1486550609, 1779244308);
            int2 b0 = int2(97842578, 536551311);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(1602148045, 1614085440);
            int2 b1 = int2(413528975, 1838293684);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1975613414, 942838342);
            int2 b2 = int2(1283898480, 1456599961);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(1092279031, 373677431);
            int2 b3 = int2(1080278602, 529676676);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_wide_scalar()
        {
            int2 a0 = int2(796797557, 670113454);
            int b0 = (746564682);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(933579492, 318174822);
            int b1 = (278884514);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1117630673, 1990922600);
            int b2 = (741886928);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(1030849597, 1718582899);
            int b3 = (1546212312);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_scalar_wide()
        {
            int a0 = (186400299);
            int2 b0 = int2(1881344229, 813834467);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1254886626);
            int2 b1 = int2(1353590345, 1412343685);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1555571443);
            int2 b2 = int2(1540508298, 1735458634);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (135888070);
            int2 b3 = int2(1643818742, 248291654);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_wide_wide()
        {
            int2 a0 = int2(2087717754, 1725569452);
            int2 b0 = int2(85148514, 293632137);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(1298066182, 1693943616);
            int2 b1 = int2(1151128249, 409440398);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(1319019629, 70674491);
            int2 b2 = int2(1115020183, 1508500597);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(1042499725, 1002821508);
            int2 b3 = int2(1834583302, 1755218534);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_wide_scalar()
        {
            int2 a0 = int2(1208626274, 239697208);
            int b0 = (1715176566);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(1979453345, 1590192876);
            int b1 = (1253474001);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(1487911635, 1662650098);
            int b2 = (1673945595);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(222749855, 566635217);
            int b3 = (1433540517);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_scalar_wide()
        {
            int a0 = (480938827);
            int2 b0 = int2(1824731899, 921496110);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (586859044);
            int2 b1 = int2(946430596, 1231356727);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1390167458);
            int2 b2 = int2(1785807092, 28949024);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (2037899283);
            int2 b3 = int2(595656760, 1778095771);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_equal_wide_wide()
        {
            int2 a0 = int2(154092149, 1515170149);
            int2 b0 = int2(77984380, 1712054191);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(1083970332, 785807178);
            int2 b1 = int2(1566203809, 254834519);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(1401094881, 310537627);
            int2 b2 = int2(450519938, 389457083);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(868328962, 1990816725);
            int2 b3 = int2(1298669505, 207343167);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_equal_wide_scalar()
        {
            int2 a0 = int2(1479531977, 1427983411);
            int b0 = (2004563877);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(415250630, 1112546666);
            int b1 = (1245345407);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(1072990632, 101048307);
            int b2 = (1579912858);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(1070894375, 1910488590);
            int b3 = (509818792);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_less_equal_scalar_wide()
        {
            int a0 = (1899193992);
            int2 b0 = int2(915011820, 980913757);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1337699683);
            int2 b1 = int2(1476321359, 1102143668);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (660493983);
            int2 b2 = int2(184664508, 381579707);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (1954892821);
            int2 b3 = int2(1295090571, 1440368586);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_equal_wide_wide()
        {
            int2 a0 = int2(8538378, 2131749726);
            int2 b0 = int2(903145828, 1697992986);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(265427108, 523609761);
            int2 b1 = int2(1432491982, 169789504);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(994991818, 839709564);
            int2 b2 = int2(1059357300, 1744255222);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(101288202, 1886280970);
            int2 b3 = int2(1606584463, 1905414425);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_equal_wide_scalar()
        {
            int2 a0 = int2(2049236663, 182691143);
            int b0 = (1061998015);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(634973382, 439837565);
            int b1 = (1197012109);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(1367606469, 351147187);
            int b2 = (1108037359);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(1898505669, 1998610091);
            int b3 = (411667685);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_greater_equal_scalar_wide()
        {
            int a0 = (1859811087);
            int2 b0 = int2(1070365918, 1783869452);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (830091760);
            int2 b1 = int2(377157428, 327199016);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (90384229);
            int2 b2 = int2(1154649706, 376758501);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1079802834);
            int2 b3 = int2(2054742898, 1328349472);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2_operator_add_wide_wide()
        {
            int2 a0 = int2(2135171378, 21433296);
            int2 b0 = int2(1013431952, 366718162);
            int2 r0 = int2(-1146363966, 388151458);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(1954723494, 683604307);
            int2 b1 = int2(359290756, 1393163294);
            int2 r1 = int2(-1980953046, 2076767601);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(1054212315, 1762680995);
            int2 b2 = int2(1962236872, 1263270041);
            int2 r2 = int2(-1278518109, -1269016260);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(1963655852, 1257853062);
            int2 b3 = int2(1862666629, 1077447887);
            int2 r3 = int2(-468644815, -1959666347);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2_operator_add_wide_scalar()
        {
            int2 a0 = int2(665815972, 1783729250);
            int b0 = (1334043849);
            int2 r0 = int2(1999859821, -1177194197);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(1591678394, 977850224);
            int b1 = (1284528538);
            int2 r1 = int2(-1418760364, -2032588534);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(71069732, 1200356017);
            int b2 = (1138577680);
            int2 r2 = int2(1209647412, -1956033599);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(565982008, 1088001167);
            int b3 = (1246759684);
            int2 r3 = int2(1812741692, -1960206445);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2_operator_add_scalar_wide()
        {
            int a0 = (359966320);
            int2 b0 = int2(2146146202, 767103309);
            int2 r0 = int2(-1788854774, 1127069629);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (851002415);
            int2 b1 = int2(311531406, 1491262941);
            int2 r1 = int2(1162533821, -1952701940);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1016891373);
            int2 b2 = int2(1954228994, 1671335850);
            int2 r2 = int2(-1323846929, -1606740073);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (727870747);
            int2 b3 = int2(551151834, 1390261152);
            int2 r3 = int2(1279022581, 2118131899);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2_operator_sub_wide_wide()
        {
            int2 a0 = int2(1410318491, 1097280168);
            int2 b0 = int2(1315897366, 799052018);
            int2 r0 = int2(94421125, 298228150);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(1827039044, 28881338);
            int2 b1 = int2(1580289673, 1094686261);
            int2 r1 = int2(246749371, -1065804923);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(328720965, 875487868);
            int2 b2 = int2(1954325726, 1197734816);
            int2 r2 = int2(-1625604761, -322246948);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(212936325, 231977215);
            int2 b3 = int2(229886366, 915679176);
            int2 r3 = int2(-16950041, -683701961);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2_operator_sub_wide_scalar()
        {
            int2 a0 = int2(1508669340, 1594795463);
            int b0 = (998008471);
            int2 r0 = int2(510660869, 596786992);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(266707545, 287705008);
            int b1 = (643102647);
            int2 r1 = int2(-376395102, -355397639);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(1475644328, 979450511);
            int b2 = (1113286221);
            int2 r2 = int2(362358107, -133835710);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(2082174113, 304369206);
            int b3 = (1108005498);
            int2 r3 = int2(974168615, -803636292);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2_operator_sub_scalar_wide()
        {
            int a0 = (893369501);
            int2 b0 = int2(2051906184, 1699714311);
            int2 r0 = int2(-1158536683, -806344810);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (442603706);
            int2 b1 = int2(1735141684, 274533585);
            int2 r1 = int2(-1292537978, 168070121);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (811580259);
            int2 b2 = int2(1196354320, 1524097023);
            int2 r2 = int2(-384774061, -712516764);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (533621527);
            int2 b3 = int2(2080845793, 143958837);
            int2 r3 = int2(-1547224266, 389662690);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mul_wide_wide()
        {
            int2 a0 = int2(61417577, 219585476);
            int2 b0 = int2(578042444, 1620527213);
            int2 r0 = int2(-1426863828, 1326150260);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(1362520891, 1511084277);
            int2 b1 = int2(200516468, 309339115);
            int2 r1 = int2(-990894148, -1322856473);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(1481211272, 58211871);
            int2 b2 = int2(542853019, 299467282);
            int2 r2 = int2(1973926232, 88546350);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(1459591173, 567624644);
            int2 b3 = int2(1479641221, 1428338601);
            int2 r3 = int2(-863919463, -582821788);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mul_wide_scalar()
        {
            int2 a0 = int2(871746615, 492532311);
            int b0 = (442064533);
            int2 r0 = int2(338365955, 1081376419);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(570557670, 1610315153);
            int b1 = (2142306629);
            int2 r1 = int2(-1449773058, 310198549);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(1526163563, 257439514);
            int b2 = (118471734);
            int2 r2 = int2(-333210990, -174540932);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(364291059, 1584938026);
            int b3 = (1186560810);
            int2 r3 = int2(1029154526, 989596900);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mul_scalar_wide()
        {
            int a0 = (1152242766);
            int2 b0 = int2(1276636134, 2105929407);
            int2 r0 = int2(-2129504236, 999811634);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (499007702);
            int2 b1 = int2(124002565, 1956335172);
            int2 r1 = int2(1219156526, 400321752);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1288034953);
            int2 b2 = int2(832676555, 337389733);
            int2 r2 = int2(-1101529949, 10961485);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (99268757);
            int2 b3 = int2(2005055247, 2011389505);
            int2 r3 = int2(559764411, -1619094571);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2_operator_div_wide_wide()
        {
            int2 a0 = int2(333171510, 858154903);
            int2 b0 = int2(698897823, 440199998);
            int2 r0 = int2(0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(1181365836, 671357749);
            int2 b1 = int2(655557473, 1658534285);
            int2 r1 = int2(1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(1090606752, 803759420);
            int2 b2 = int2(2127220100, 315653188);
            int2 r2 = int2(0, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(788404166, 296807814);
            int2 b3 = int2(1814290360, 992173243);
            int2 r3 = int2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2_operator_div_wide_scalar()
        {
            int2 a0 = int2(1433072926, 1073958635);
            int b0 = (1434025872);
            int2 r0 = int2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(1195142312, 1274375693);
            int b1 = (536596719);
            int2 r1 = int2(2, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(464756346, 906504670);
            int b2 = (806462546);
            int2 r2 = int2(0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(1380905136, 1196815948);
            int b3 = (25493909);
            int2 r3 = int2(54, 46);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2_operator_div_scalar_wide()
        {
            int a0 = (519165704);
            int2 b0 = int2(1295178177, 775214121);
            int2 r0 = int2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (467772046);
            int2 b1 = int2(1156881598, 310396565);
            int2 r1 = int2(0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (759759959);
            int2 b2 = int2(243837702, 1616314235);
            int2 r2 = int2(3, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (1053470225);
            int2 b3 = int2(1320630160, 378773841);
            int2 r3 = int2(0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mod_wide_wide()
        {
            int2 a0 = int2(258342924, 1454754891);
            int2 b0 = int2(1990080167, 1197348066);
            int2 r0 = int2(258342924, 257406825);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(723352342, 1981431473);
            int2 b1 = int2(651970512, 1659454050);
            int2 r1 = int2(71381830, 321977423);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(531756042, 716993627);
            int2 b2 = int2(241005212, 1866255454);
            int2 r2 = int2(49745618, 716993627);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(1667903349, 1331097004);
            int2 b3 = int2(1440101415, 595220963);
            int2 r3 = int2(227801934, 140655078);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mod_wide_scalar()
        {
            int2 a0 = int2(560988938, 629524514);
            int b0 = (1156862367);
            int2 r0 = int2(560988938, 629524514);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(767711194, 1399805893);
            int b1 = (434281967);
            int2 r1 = int2(333429227, 96959992);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(792916846, 598661916);
            int b2 = (1663690927);
            int2 r2 = int2(792916846, 598661916);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(1776636144, 1743722161);
            int b3 = (1287035793);
            int2 r3 = int2(489600351, 456686368);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2_operator_mod_scalar_wide()
        {
            int a0 = (933347930);
            int2 b0 = int2(549923387, 243114953);
            int2 r0 = int2(383424543, 204003071);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1884274390);
            int2 b1 = int2(1428033594, 655531454);
            int2 r1 = int2(456240796, 573211482);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1622674954);
            int2 b2 = int2(1107563514, 1614111094);
            int2 r2 = int2(515111440, 8563860);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (914801920);
            int2 b3 = int2(1432263179, 564431096);
            int2 r3 = int2(914801920, 350370824);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2_operator_plus()
        {
            int2 a0 = int2(195392567, 222719748);
            int2 r0 = int2(195392567, 222719748);
            TestUtils.AreEqual(+a0, r0);

            int2 a1 = int2(1002351013, 109389333);
            int2 r1 = int2(1002351013, 109389333);
            TestUtils.AreEqual(+a1, r1);

            int2 a2 = int2(1515950277, 291471785);
            int2 r2 = int2(1515950277, 291471785);
            TestUtils.AreEqual(+a2, r2);

            int2 a3 = int2(264115671, 195779102);
            int2 r3 = int2(264115671, 195779102);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void int2_operator_neg()
        {
            int2 a0 = int2(1385088677, 94114564);
            int2 r0 = int2(-1385088677, -94114564);
            TestUtils.AreEqual(-a0, r0);

            int2 a1 = int2(1350664872, 2067164853);
            int2 r1 = int2(-1350664872, -2067164853);
            TestUtils.AreEqual(-a1, r1);

            int2 a2 = int2(218122493, 270553961);
            int2 r2 = int2(-218122493, -270553961);
            TestUtils.AreEqual(-a2, r2);

            int2 a3 = int2(446497525, 1928771252);
            int2 r3 = int2(-446497525, -1928771252);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void int2_operator_prefix_inc()
        {
            int2 a0 = int2(780471723, 954741756);
            int2 r0 = int2(780471724, 954741757);
            TestUtils.AreEqual(++a0, r0);

            int2 a1 = int2(272723451, 606294309);
            int2 r1 = int2(272723452, 606294310);
            TestUtils.AreEqual(++a1, r1);

            int2 a2 = int2(1514814550, 444189162);
            int2 r2 = int2(1514814551, 444189163);
            TestUtils.AreEqual(++a2, r2);

            int2 a3 = int2(1833356994, 1348278302);
            int2 r3 = int2(1833356995, 1348278303);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void int2_operator_postfix_inc()
        {
            int2 a0 = int2(241865086, 2145821641);
            int2 r0 = int2(241865086, 2145821641);
            TestUtils.AreEqual(a0++, r0);

            int2 a1 = int2(1596166022, 529551271);
            int2 r1 = int2(1596166022, 529551271);
            TestUtils.AreEqual(a1++, r1);

            int2 a2 = int2(1656767229, 1213663244);
            int2 r2 = int2(1656767229, 1213663244);
            TestUtils.AreEqual(a2++, r2);

            int2 a3 = int2(1425753247, 389844650);
            int2 r3 = int2(1425753247, 389844650);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void int2_operator_prefix_dec()
        {
            int2 a0 = int2(1331961415, 1612382200);
            int2 r0 = int2(1331961414, 1612382199);
            TestUtils.AreEqual(--a0, r0);

            int2 a1 = int2(1401591249, 1757136546);
            int2 r1 = int2(1401591248, 1757136545);
            TestUtils.AreEqual(--a1, r1);

            int2 a2 = int2(1895858159, 578341664);
            int2 r2 = int2(1895858158, 578341663);
            TestUtils.AreEqual(--a2, r2);

            int2 a3 = int2(1336115745, 1169239112);
            int2 r3 = int2(1336115744, 1169239111);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void int2_operator_postfix_dec()
        {
            int2 a0 = int2(1870005937, 1708534798);
            int2 r0 = int2(1870005937, 1708534798);
            TestUtils.AreEqual(a0--, r0);

            int2 a1 = int2(704493460, 2060593573);
            int2 r1 = int2(704493460, 2060593573);
            TestUtils.AreEqual(a1--, r1);

            int2 a2 = int2(228744869, 1818778351);
            int2 r2 = int2(228744869, 1818778351);
            TestUtils.AreEqual(a2--, r2);

            int2 a3 = int2(1015253889, 1401191870);
            int2 r3 = int2(1015253889, 1401191870);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_and_wide_wide()
        {
            int2 a0 = int2(1055241304, 859321394);
            int2 b0 = int2(749698416, 748105424);
            int2 r0 = int2(749024336, 537928720);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(1088358961, 2090949513);
            int2 b1 = int2(1842764797, 9990577);
            int2 r1 = int2(1087769137, 8409473);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(300561740, 651904515);
            int2 b2 = int2(1989102105, 1666634755);
            int2 r2 = int2(277479432, 575816707);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(1331035868, 2012752753);
            int2 b3 = int2(58116798, 868036607);
            int2 r3 = int2(55888540, 867707761);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_and_wide_scalar()
        {
            int2 a0 = int2(1513158868, 284695609);
            int b0 = (1173647397);
            int2 r0 = int2(1076916228, 15732769);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(734595037, 1601252476);
            int b1 = (1566510707);
            int2 r1 = int2(155780689, 1565592688);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(84213838, 430856908);
            int b2 = (314333543);
            int2 r2 = int2(262214, 279730244);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(753481263, 1619794917);
            int b3 = (327392481);
            int2 r3 = int2(8459297, 8394977);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (477163326);
            int2 b0 = int2(110453385, 703240362);
            int2 r0 = int2(68182536, 140544042);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (2075630560);
            int2 b1 = int2(1884904031, 1734899436);
            int2 r1 = int2(1880169024, 1663046368);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (947945203);
            int2 b2 = int2(1664399051, 458879298);
            int2 r2 = int2(536884931, 402681922);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (158491426);
            int2 b3 = int2(79772356, 2054527944);
            int2 r3 = int2(4203008, 141558528);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_or_wide_wide()
        {
            int2 a0 = int2(1920951869, 1750772852);
            int2 b0 = int2(214585254, 275414367);
            int2 r0 = int2(2130669503, 2021326207);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(1420019191, 732977093);
            int2 b1 = int2(858759675, 190211455);
            int2 r1 = int2(2008016383, 737572863);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(1169579447, 229437930);
            int2 b2 = int2(1218691723, 2129565457);
            int2 r2 = int2(1303895999, 2146367483);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(1966721348, 2039812323);
            int2 b3 = int2(1862809466, 495728846);
            int2 r3 = int2(2134507390, 2107455727);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_or_wide_scalar()
        {
            int2 a0 = int2(1295304853, 1307252624);
            int b0 = (1305527136);
            int2 r0 = int2(1307888629, 1308350448);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(350194630, 1774824542);
            int b1 = (1128063578);
            int2 r1 = int2(1476389854, 1811803742);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(2085245467, 999162350);
            int b2 = (1988423804);
            int2 r2 = int2(2127491711, 2140074494);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(2110327307, 341855232);
            int b3 = (1050875188);
            int2 r3 = int2(2146115391, 1055087924);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1768627592);
            int2 b0 = int2(1849658052, 1759912154);
            int2 r0 = int2(1870634956, 1777286618);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (729979455);
            int2 b1 = int2(975926310, 1987690876);
            int2 r1 = int2(1001127487, 2147212159);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1809506714);
            int2 b2 = int2(1160695341, 408963395);
            int2 r2 = int2(1878978495, 2080041435);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (314072711);
            int2 b3 = int2(1560007537, 1709003416);
            int2 r3 = int2(1593565175, 2013093535);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_xor_wide_wide()
        {
            int2 a0 = int2(1843655608, 362425681);
            int2 b0 = int2(1422803441, 1234691140);
            int2 r0 = int2(959296073, 1544407317);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(640805534, 1342040268);
            int2 b1 = int2(119589253, 1101464929);
            int2 r1 = int2(554771227, 240840109);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(945678755, 980321850);
            int2 b2 = int2(121896337, 1880109018);
            int2 r2 = int2(1058935858, 1249815008);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(390165019, 1682422658);
            int2 b3 = int2(1000210266, 1718938232);
            int2 r3 = int2(752651585, 36917754);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_xor_wide_scalar()
        {
            int2 a0 = int2(169345668, 176087064);
            int b0 = (354464228);
            int2 r0 = int2(523809632, 526275068);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(2084362901, 193851255);
            int b1 = (1663924004);
            int2 r1 = int2(521252273, 1755355219);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(517476661, 863800783);
            int b2 = (905336222);
            int2 r2 = int2(724452523, 109762641);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(365003873, 954341348);
            int b3 = (835837496);
            int2 r3 = int2(605051481, 154388956);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1361775641);
            int2 b0 = int2(1452773578, 459050892);
            int2 r0 = int2(129801427, 1249346453);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1986218254);
            int2 b1 = int2(1689037698, 999278344);
            int2 r1 = int2(315613836, 1307348486);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1229114508);
            int2 b2 = int2(1087843538, 733699740);
            int2 r2 = int2(160817246, 1660523024);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (106187872);
            int2 b3 = int2(1533632738, 1107817672);
            int2 r3 = int2(1564290178, 1146337448);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2_operator_left_shift()
        {
            int2 a0 = int2(1129100049, 829482269);
            int b0 = (218351941);
            int2 r0 = int2(1771463200, 773628832);
            TestUtils.AreEqual(a0 << b0, r0);

            int2 a1 = int2(1571297368, 1872142968);
            int b1 = (443753193);
            int2 r1 = int2(1345368064, 759492608);
            TestUtils.AreEqual(a1 << b1, r1);

            int2 a2 = int2(249554593, 980302862);
            int b2 = (892627436);
            int2 r2 = int2(-26603520, -473899008);
            TestUtils.AreEqual(a2 << b2, r2);

            int2 a3 = int2(62369727, 1271350845);
            int b3 = (849916599);
            int2 r3 = int2(-545259520, 511705088);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public void int2_operator_right_shift()
        {
            int2 a0 = int2(809126085, 908563670);
            int b0 = (994800051);
            int2 r0 = int2(1543, 1732);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2 a1 = int2(763568837, 1174507510);
            int b1 = (1986717290);
            int2 r1 = int2(745672, 1146979);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2 a2 = int2(646821842, 390811632);
            int b2 = (1242726074);
            int2 r2 = int2(9, 5);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2 a3 = int2(1521420393, 102096936);
            int b3 = (1923166649);
            int2 r3 = int2(45, 3);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public void int2_operator_bitwise_not()
        {
            int2 a0 = int2(111796841, 603562399);
            int2 r0 = int2(-111796842, -603562400);
            TestUtils.AreEqual(~a0, r0);

            int2 a1 = int2(745091931, 1110916612);
            int2 r1 = int2(-745091932, -1110916613);
            TestUtils.AreEqual(~a1, r1);

            int2 a2 = int2(381888399, 1506860135);
            int2 r2 = int2(-381888400, -1506860136);
            TestUtils.AreEqual(~a2, r2);

            int2 a3 = int2(771210628, 875964607);
            int2 r3 = int2(-771210629, -875964608);
            TestUtils.AreEqual(~a3, r3);
        }

        [TestCompiler]
        public void int2_shuffle_result_1()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public void int2_shuffle_result_2()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), int2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), int2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), int2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), int2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), int2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), int2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), int2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), int2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), int2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), int2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), int2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), int2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), int2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), int2(3, 3));
        }

        [TestCompiler]
        public void int2_shuffle_result_3()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), int3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), int3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), int3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), int3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), int3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), int3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), int3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), int3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(3, 1, 1));
        }

        [TestCompiler]
        public void int2_shuffle_result_4()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), int4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), int4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), int4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), int4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), int4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), int4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), int4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), int4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), int4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), int4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int4(2, 0, 0, 0));
        }


    }
}
