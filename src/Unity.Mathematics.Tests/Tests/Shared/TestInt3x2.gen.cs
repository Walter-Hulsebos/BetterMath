// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt3x2
    {
        [TestCompiler]
        public void int3x2_zero()
        {
            TestUtils.AreEqual(int3x2.zero.c0.x, 0);
            TestUtils.AreEqual(int3x2.zero.c0.y, 0);
            TestUtils.AreEqual(int3x2.zero.c0.z, 0);
            TestUtils.AreEqual(int3x2.zero.c1.x, 0);
            TestUtils.AreEqual(int3x2.zero.c1.y, 0);
            TestUtils.AreEqual(int3x2.zero.c1.z, 0);
        }

        [TestCompiler]
        public void int3x2_operator_equal_wide_wide()
        {
            int3x2 a0 = int3x2(2105871082, 35218899, 1550755093, 764676020, 606743782, 1208156098);
            int3x2 b0 = int3x2(1477587886, 579629692, 540974792, 208405066, 2063397938, 1060167409);
            bool3x2 r0 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3x2 a1 = int3x2(1023640014, 1038468316, 1416064367, 727143393, 2061243891, 184669837);
            int3x2 b1 = int3x2(362592601, 2097545362, 277670088, 426944490, 901076223, 857900673);
            bool3x2 r1 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3x2 a2 = int3x2(1303661760, 2044073738, 370395888, 1822916805, 1076983135, 345215866);
            int3x2 b2 = int3x2(1548779757, 325265488, 312658571, 176373760, 2052378097, 858156597);
            bool3x2 r2 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3x2 a3 = int3x2(833676277, 1987782708, 1481088614, 1364754268, 93639636, 1850596922);
            int3x2 b3 = int3x2(982817797, 1252095508, 882634538, 1959142806, 72495800, 1077678183);
            bool3x2 r3 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_equal_wide_scalar()
        {
            int3x2 a0 = int3x2(437822262, 2020661134, 541786900, 853113810, 23716499, 179951405);
            int b0 = (1332833578);
            bool3x2 r0 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3x2 a1 = int3x2(1409026299, 953202998, 691955848, 1926262965, 1851546137, 712957637);
            int b1 = (948838849);
            bool3x2 r1 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3x2 a2 = int3x2(2028784869, 1836975611, 1016802970, 390120467, 464814777, 1451642042);
            int b2 = (1049962241);
            bool3x2 r2 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3x2 a3 = int3x2(289137869, 808355440, 660053867, 597354173, 67320270, 151461188);
            int b3 = (152339338);
            bool3x2 r3 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_equal_scalar_wide()
        {
            int a0 = (542329200);
            int3x2 b0 = int3x2(1115584594, 684107773, 1928988941, 890709324, 641152437, 1410341302);
            bool3x2 r0 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (497505660);
            int3x2 b1 = int3x2(1068223109, 2014009435, 213835595, 1592428361, 1819361470, 448650623);
            bool3x2 r1 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1942175642);
            int3x2 b2 = int3x2(64377057, 1485938610, 1146305380, 1312317120, 263290348, 812663708);
            bool3x2 r2 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1585209188);
            int3x2 b3 = int3x2(40646617, 1378718922, 1957797737, 873652576, 1780082094, 1513270921);
            bool3x2 r3 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_not_equal_wide_wide()
        {
            int3x2 a0 = int3x2(1977284100, 1293292704, 1547283851, 422428953, 195833190, 1711544892);
            int3x2 b0 = int3x2(1514195556, 957972049, 507667364, 581861672, 1128094576, 940096636);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3x2 a1 = int3x2(5606053, 737069074, 647386678, 13079405, 1413841590, 1076166545);
            int3x2 b1 = int3x2(57559040, 181752616, 962017320, 1762015406, 1107218953, 2042026522);
            bool3x2 r1 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3x2 a2 = int3x2(1211445174, 1289303469, 1436402489, 1129570126, 1566836685, 1343313905);
            int3x2 b2 = int3x2(836002288, 570272309, 2112081980, 1500634658, 1787808345, 566425667);
            bool3x2 r2 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3x2 a3 = int3x2(329259205, 1774944480, 33906739, 2055853627, 2035015372, 1702756001);
            int3x2 b3 = int3x2(2037529609, 1520589840, 266793699, 538816359, 2075474643, 553571317);
            bool3x2 r3 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_not_equal_wide_scalar()
        {
            int3x2 a0 = int3x2(1038269360, 1427812625, 103361237, 1347017023, 1523584313, 150442802);
            int b0 = (768873026);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3x2 a1 = int3x2(660334527, 262959423, 484398043, 506946952, 226568494, 507918242);
            int b1 = (719113717);
            bool3x2 r1 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3x2 a2 = int3x2(1702162286, 166187260, 114581840, 1045389187, 1648095254, 1461803977);
            int b2 = (923269270);
            bool3x2 r2 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3x2 a3 = int3x2(61801615, 2146927809, 1557151164, 1284033253, 1345705546, 1747302566);
            int b3 = (1317840133);
            bool3x2 r3 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_not_equal_scalar_wide()
        {
            int a0 = (1652127596);
            int3x2 b0 = int3x2(953791238, 271722683, 1278885987, 735128017, 112416504, 25967222);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1761444475);
            int3x2 b1 = int3x2(1844594536, 1199122922, 634219279, 942501101, 67161343, 969944293);
            bool3x2 r1 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (833229499);
            int3x2 b2 = int3x2(1304301133, 704045745, 345012334, 1253134152, 325772538, 855127202);
            bool3x2 r2 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (793668881);
            int3x2 b3 = int3x2(1584481616, 1101301152, 276853534, 987168816, 1258105989, 362645228);
            bool3x2 r3 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_wide_wide()
        {
            int3x2 a0 = int3x2(1486550609, 1779244308, 1602148045, 1614085440, 1975613414, 942838342);
            int3x2 b0 = int3x2(97842578, 536551311, 413528975, 1838293684, 1283898480, 1456599961);
            bool3x2 r0 = bool3x2(false, false, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int3x2 a1 = int3x2(1092279031, 373677431, 1419098312, 337757077, 1081797900, 1336745069);
            int3x2 b1 = int3x2(1080278602, 529676676, 156584048, 117348799, 246927124, 1916615924);
            bool3x2 r1 = bool3x2(false, true, false, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int3x2 a2 = int3x2(840685445, 1220554047, 2013681746, 192965012, 532043965, 1000693402);
            int3x2 b2 = int3x2(1731071394, 1328098431, 1014995792, 480319327, 1765937053, 1333997067);
            bool3x2 r2 = bool3x2(true, true, false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int3x2 a3 = int3x2(927236048, 1215860000, 780607596, 1882056852, 1354146545, 2135295778);
            int3x2 b3 = int3x2(688515308, 1856106947, 1303906227, 646821776, 1169473993, 316770064);
            bool3x2 r3 = bool3x2(false, true, true, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_wide_scalar()
        {
            int3x2 a0 = int3x2(796797557, 670113454, 933579492, 278884514, 318174822, 1117630673);
            int b0 = (746564682);
            bool3x2 r0 = bool3x2(false, true, false, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int3x2 a1 = int3x2(741886928, 1030849597, 1546212312, 1718582899, 1648393417, 1857132231);
            int b1 = (1990922600);
            bool3x2 r1 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int3x2 a2 = int3x2(1909506562, 952084157, 1303736668, 845460171, 979430272, 1368236640);
            int b2 = (1294006045);
            bool3x2 r2 = bool3x2(false, true, false, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int3x2 a3 = int3x2(24980695, 659552739, 1058492383, 165694933, 1204097259, 922212691);
            int b3 = (1434668705);
            bool3x2 r3 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_scalar_wide()
        {
            int a0 = (186400299);
            int3x2 b0 = int3x2(1881344229, 813834467, 1254886626, 1353590345, 1412343685, 1555571443);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1540508298);
            int3x2 b1 = int3x2(1735458634, 135888070, 1643818742, 248291654, 1739560105, 728539891);
            bool3x2 r1 = bool3x2(true, false, true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (480507742);
            int3x2 b2 = int3x2(1696553040, 540223931, 1840493353, 146833656, 798115946, 2002002066);
            bool3x2 r2 = bool3x2(true, true, true, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (1011261705);
            int3x2 b3 = int3x2(783550942, 1093071215, 598253401, 1432416562, 1863582169, 103622950);
            bool3x2 r3 = bool3x2(false, true, false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_wide_wide()
        {
            int3x2 a0 = int3x2(2087717754, 1725569452, 1298066182, 1693943616, 1319019629, 70674491);
            int3x2 b0 = int3x2(85148514, 293632137, 1151128249, 409440398, 1115020183, 1508500597);
            bool3x2 r0 = bool3x2(true, true, true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int3x2 a1 = int3x2(1042499725, 1002821508, 1021857133, 1744374599, 821751047, 467646903);
            int3x2 b1 = int3x2(1834583302, 1755218534, 1788761753, 1128238489, 834223713, 1578743290);
            bool3x2 r1 = bool3x2(false, false, false, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int3x2 a2 = int3x2(2029731638, 1377214212, 1207816926, 474621063, 20781266, 366593779);
            int3x2 b2 = int3x2(1647150256, 1756397855, 1131080201, 1208965204, 1495161099, 1283714281);
            bool3x2 r2 = bool3x2(true, false, true, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int3x2 a3 = int3x2(2068457387, 10181449, 793634464, 144474612, 99947390, 930377263);
            int3x2 b3 = int3x2(908051907, 412849651, 815822687, 730271942, 40756039, 883326140);
            bool3x2 r3 = bool3x2(true, false, false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_wide_scalar()
        {
            int3x2 a0 = int3x2(1208626274, 239697208, 1979453345, 1253474001, 1590192876, 1487911635);
            int b0 = (1715176566);
            bool3x2 r0 = bool3x2(false, false, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int3x2 a1 = int3x2(1673945595, 222749855, 1433540517, 566635217, 1773305960, 1850273578);
            int b1 = (1662650098);
            bool3x2 r1 = bool3x2(true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int3x2 a2 = int3x2(206147145, 333381537, 1905567362, 2053577491, 570397194, 2128431130);
            int b2 = (325913453);
            bool3x2 r2 = bool3x2(false, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int3x2 a3 = int3x2(1735325311, 1663525234, 1972984241, 1587865063, 488268523, 121921923);
            int b3 = (529971908);
            bool3x2 r3 = bool3x2(true, true, true, true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_scalar_wide()
        {
            int a0 = (480938827);
            int3x2 b0 = int3x2(1824731899, 921496110, 586859044, 946430596, 1231356727, 1390167458);
            bool3x2 r0 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1785807092);
            int3x2 b1 = int3x2(28949024, 2037899283, 595656760, 1778095771, 1233500439, 1696302238);
            bool3x2 r1 = bool3x2(true, false, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1445965340);
            int3x2 b2 = int3x2(484020151, 1586962841, 1361740714, 265628948, 2003122957, 332267433);
            bool3x2 r2 = bool3x2(true, false, true, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (1128353075);
            int3x2 b3 = int3x2(377919478, 982113135, 1117675960, 630865591, 1550679736, 895945757);
            bool3x2 r3 = bool3x2(true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_equal_wide_wide()
        {
            int3x2 a0 = int3x2(154092149, 1515170149, 1083970332, 785807178, 1401094881, 310537627);
            int3x2 b0 = int3x2(77984380, 1712054191, 1566203809, 254834519, 450519938, 389457083);
            bool3x2 r0 = bool3x2(false, true, true, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3x2 a1 = int3x2(868328962, 1990816725, 2035349541, 457043352, 1123282035, 1001842946);
            int3x2 b1 = int3x2(1298669505, 207343167, 1214449047, 2059561026, 896534357, 1897470050);
            bool3x2 r1 = bool3x2(true, false, false, true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3x2 a2 = int3x2(1387761992, 195272789, 659549000, 888761458, 283706617, 1790185840);
            int3x2 b2 = int3x2(521075677, 1848221945, 374708019, 1573731118, 2093466449, 1660210829);
            bool3x2 r2 = bool3x2(false, true, false, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3x2 a3 = int3x2(899029812, 848317418, 1743712447, 1504407474, 1798441490, 1902791952);
            int3x2 b3 = int3x2(1568778785, 1352157589, 1212771905, 1457525058, 1493446008, 1784768208);
            bool3x2 r3 = bool3x2(true, true, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_equal_wide_scalar()
        {
            int3x2 a0 = int3x2(1479531977, 1427983411, 415250630, 1245345407, 1112546666, 1072990632);
            int b0 = (2004563877);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3x2 a1 = int3x2(1579912858, 1070894375, 509818792, 1910488590, 85452501, 518127023);
            int b1 = (101048307);
            bool3x2 r1 = bool3x2(false, false, false, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3x2 a2 = int3x2(1246249980, 1964410699, 1968139888, 1191853379, 662096238, 1140643434);
            int b2 = (1097326500);
            bool3x2 r2 = bool3x2(false, false, false, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3x2 a3 = int3x2(754434551, 995927387, 974873240, 1773400038, 497436329, 1825940497);
            int b3 = (155343473);
            bool3x2 r3 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_less_equal_scalar_wide()
        {
            int a0 = (1899193992);
            int3x2 b0 = int3x2(915011820, 980913757, 1337699683, 1476321359, 1102143668, 660493983);
            bool3x2 r0 = bool3x2(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (184664508);
            int3x2 b1 = int3x2(381579707, 1954892821, 1295090571, 1440368586, 1696003686, 88708652);
            bool3x2 r1 = bool3x2(true, true, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1332251857);
            int3x2 b2 = int3x2(1310713644, 2112132784, 48951945, 1888568027, 39340955, 1108242207);
            bool3x2 r2 = bool3x2(false, true, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (260777425);
            int3x2 b3 = int3x2(593122164, 291471959, 253457314, 1264570386, 699618012, 927735863);
            bool3x2 r3 = bool3x2(true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_equal_wide_wide()
        {
            int3x2 a0 = int3x2(8538378, 2131749726, 265427108, 523609761, 994991818, 839709564);
            int3x2 b0 = int3x2(903145828, 1697992986, 1432491982, 169789504, 1059357300, 1744255222);
            bool3x2 r0 = bool3x2(false, true, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3x2 a1 = int3x2(101288202, 1886280970, 2032074826, 631221455, 1456286159, 961342752);
            int3x2 b1 = int3x2(1606584463, 1905414425, 1448794969, 136181998, 1678754836, 2069656857);
            bool3x2 r1 = bool3x2(false, false, true, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3x2 a2 = int3x2(424526026, 788481984, 1662488497, 870326690, 708712581, 1260182701);
            int3x2 b2 = int3x2(398982689, 243317404, 740939613, 1894753119, 301760792, 1260647988);
            bool3x2 r2 = bool3x2(true, true, true, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3x2 a3 = int3x2(1165630721, 138247561, 1108650168, 1933222913, 672493999, 1541402159);
            int3x2 b3 = int3x2(3608523, 52576030, 903420465, 1648820371, 627296845, 1679808907);
            bool3x2 r3 = bool3x2(true, true, true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_equal_wide_scalar()
        {
            int3x2 a0 = int3x2(2049236663, 182691143, 634973382, 1197012109, 439837565, 1367606469);
            int b0 = (1061998015);
            bool3x2 r0 = bool3x2(true, false, false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3x2 a1 = int3x2(1108037359, 1898505669, 411667685, 1998610091, 4652390, 996159180);
            int b1 = (351147187);
            bool3x2 r1 = bool3x2(true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3x2 a2 = int3x2(2111455181, 96217144, 814085575, 1525995206, 1293933760, 1732973229);
            int b2 = (727766399);
            bool3x2 r2 = bool3x2(true, false, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3x2 a3 = int3x2(1473283041, 1023753195, 1373738074, 518164359, 717850464, 1765188600);
            int b3 = (899444524);
            bool3x2 r3 = bool3x2(true, true, true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_greater_equal_scalar_wide()
        {
            int a0 = (1859811087);
            int3x2 b0 = int3x2(1070365918, 1783869452, 830091760, 377157428, 327199016, 90384229);
            bool3x2 r0 = bool3x2(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1154649706);
            int3x2 b1 = int3x2(376758501, 1079802834, 2054742898, 1328349472, 434061447, 951207723);
            bool3x2 r1 = bool3x2(true, true, false, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (598695892);
            int3x2 b2 = int3x2(975131651, 1714007943, 177416473, 1267232721, 31082860, 216791741);
            bool3x2 r2 = bool3x2(false, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (119054289);
            int3x2 b3 = int3x2(1905107583, 89559116, 55041824, 691334141, 462326883, 1658303669);
            bool3x2 r3 = bool3x2(false, true, true, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_add_wide_wide()
        {
            int3x2 a0 = int3x2(2135171378, 21433296, 1954723494, 683604307, 1054212315, 1762680995);
            int3x2 b0 = int3x2(1013431952, 366718162, 359290756, 1393163294, 1962236872, 1263270041);
            int3x2 r0 = int3x2(-1146363966, 388151458, -1980953046, 2076767601, -1278518109, -1269016260);
            TestUtils.AreEqual(a0 + b0, r0);

            int3x2 a1 = int3x2(1963655852, 1257853062, 2043493600, 976898058, 1915056423, 121374462);
            int3x2 b1 = int3x2(1862666629, 1077447887, 821693806, 487316539, 350922520, 1583012528);
            int3x2 r1 = int3x2(-468644815, -1959666347, -1429779890, 1464214597, -2028988353, 1704386990);
            TestUtils.AreEqual(a1 + b1, r1);

            int3x2 a2 = int3x2(1218855698, 700538222, 1702057277, 1788251699, 1534939160, 398651016);
            int3x2 b2 = int3x2(1951595076, 1024851344, 874302782, 1383969588, 1767968088, 900721406);
            int3x2 r2 = int3x2(-1124516522, 1725389566, -1718607237, -1122746009, -992060048, 1299372422);
            TestUtils.AreEqual(a2 + b2, r2);

            int3x2 a3 = int3x2(1674272498, 374510467, 824322986, 1217622199, 1122376670, 642613771);
            int3x2 b3 = int3x2(1659790033, 1792273749, 443844328, 633981449, 2010244807, 335566991);
            int3x2 r3 = int3x2(-960904765, -2128183080, 1268167314, 1851603648, -1162345819, 978180762);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_add_wide_scalar()
        {
            int3x2 a0 = int3x2(665815972, 1783729250, 1591678394, 1284528538, 977850224, 71069732);
            int b0 = (1334043849);
            int3x2 r0 = int3x2(1999859821, -1177194197, -1369245053, -1676394909, -1983073223, 1405113581);
            TestUtils.AreEqual(a0 + b0, r0);

            int3x2 a1 = int3x2(1138577680, 565982008, 1246759684, 1088001167, 57252642, 678921480);
            int b1 = (1200356017);
            int3x2 r1 = int3x2(-1956033599, 1766338025, -1847851595, -2006610112, 1257608659, 1879277497);
            TestUtils.AreEqual(a1 + b1, r1);

            int3x2 a2 = int3x2(625943813, 1470648741, 1490096953, 1467033531, 182608093, 1707296407);
            int b2 = (512157429);
            int3x2 r2 = int3x2(1138101242, 1982806170, 2002254382, 1979190960, 694765522, -2075513460);
            TestUtils.AreEqual(a2 + b2, r2);

            int3x2 a3 = int3x2(1703724354, 653973063, 1139546735, 1834005844, 184572739, 1980578280);
            int b3 = (1333833947);
            int3x2 r3 = int3x2(-1257408995, 1987807010, -1821586614, -1127127505, 1518406686, -980555069);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_add_scalar_wide()
        {
            int a0 = (359966320);
            int3x2 b0 = int3x2(2146146202, 767103309, 851002415, 311531406, 1491262941, 1016891373);
            int3x2 r0 = int3x2(-1788854774, 1127069629, 1210968735, 671497726, 1851229261, 1376857693);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1954228994);
            int3x2 b1 = int3x2(1671335850, 727870747, 551151834, 1390261152, 1699060326, 115021619);
            int3x2 r1 = int3x2(-669402452, -1612867555, -1789586468, -950477150, -641677976, 2069250613);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1964440175);
            int3x2 b2 = int3x2(440700758, 1556692550, 185414255, 933106731, 1217866784, 729761881);
            int3x2 r2 = int3x2(-1889826363, -773834571, -2145112866, -1397420390, -1112660337, -1600765240);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1742597318);
            int3x2 b3 = int3x2(1090109152, 1467373815, 1066072609, 138237856, 634834665, 993603553);
            int3x2 r3 = int3x2(-1462260826, -1084996163, -1486297369, 1880835174, -1917535313, -1558766425);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_sub_wide_wide()
        {
            int3x2 a0 = int3x2(1410318491, 1097280168, 1827039044, 28881338, 328720965, 875487868);
            int3x2 b0 = int3x2(1315897366, 799052018, 1580289673, 1094686261, 1954325726, 1197734816);
            int3x2 r0 = int3x2(94421125, 298228150, 246749371, -1065804923, -1625604761, -322246948);
            TestUtils.AreEqual(a0 - b0, r0);

            int3x2 a1 = int3x2(212936325, 231977215, 1740021315, 2011295463, 48079003, 591379285);
            int3x2 b1 = int3x2(229886366, 915679176, 1746884850, 918743925, 1007797419, 257421324);
            int3x2 r1 = int3x2(-16950041, -683701961, -6863535, 1092551538, -959718416, 333957961);
            TestUtils.AreEqual(a1 - b1, r1);

            int3x2 a2 = int3x2(1125909359, 1842588095, 848561896, 614448464, 2067598029, 1618238416);
            int3x2 b2 = int3x2(287249342, 1617287463, 1653916102, 123586847, 502107404, 672875302);
            int3x2 r2 = int3x2(838660017, 225300632, -805354206, 490861617, 1565490625, 945363114);
            TestUtils.AreEqual(a2 - b2, r2);

            int3x2 a3 = int3x2(318516219, 1090119767, 1991095823, 949592162, 1951912339, 1457818751);
            int3x2 b3 = int3x2(1256481116, 1975569142, 1794443030, 1327558915, 330955394, 1596041731);
            int3x2 r3 = int3x2(-937964897, -885449375, 196652793, -377966753, 1620956945, -138222980);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_sub_wide_scalar()
        {
            int3x2 a0 = int3x2(1508669340, 1594795463, 266707545, 643102647, 287705008, 1475644328);
            int b0 = (998008471);
            int3x2 r0 = int3x2(510660869, 596786992, -731300926, -354905824, -710303463, 477635857);
            TestUtils.AreEqual(a0 - b0, r0);

            int3x2 a1 = int3x2(1113286221, 2082174113, 1108005498, 304369206, 999244508, 1806482044);
            int b1 = (979450511);
            int3x2 r1 = int3x2(133835710, 1102723602, 128554987, -675081305, 19793997, 827031533);
            TestUtils.AreEqual(a1 - b1, r1);

            int3x2 a2 = int3x2(1994553647, 1482736902, 266654115, 1470212363, 1190349300, 958542155);
            int b2 = (2101812429);
            int3x2 r2 = int3x2(-107258782, -619075527, -1835158314, -631600066, -911463129, -1143270274);
            TestUtils.AreEqual(a2 - b2, r2);

            int3x2 a3 = int3x2(1185075537, 499527536, 1612473406, 1696960099, 1287292743, 1360229454);
            int b3 = (1738124835);
            int3x2 r3 = int3x2(-553049298, -1238597299, -125651429, -41164736, -450832092, -377895381);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_sub_scalar_wide()
        {
            int a0 = (893369501);
            int3x2 b0 = int3x2(2051906184, 1699714311, 442603706, 1735141684, 274533585, 811580259);
            int3x2 r0 = int3x2(-1158536683, -806344810, 450765795, -841772183, 618835916, 81789242);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1196354320);
            int3x2 b1 = int3x2(1524097023, 533621527, 2080845793, 143958837, 1620668660, 1135989346);
            int3x2 r1 = int3x2(-327742703, 662732793, -884491473, 1052395483, -424314340, 60364974);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1367044745);
            int3x2 b2 = int3x2(554088609, 552670373, 1265516124, 1254902543, 1857695581, 1619865274);
            int3x2 r2 = int3x2(812956136, 814374372, 101528621, 112142202, -490650836, -252820529);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1313559400);
            int3x2 b3 = int3x2(99812999, 843597298, 420111239, 1299949060, 531009038, 1103306550);
            int3x2 r3 = int3x2(1213746401, 469962102, 893448161, 13610340, 782550362, 210252850);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mul_wide_wide()
        {
            int3x2 a0 = int3x2(61417577, 219585476, 1362520891, 1511084277, 1481211272, 58211871);
            int3x2 b0 = int3x2(578042444, 1620527213, 200516468, 309339115, 542853019, 299467282);
            int3x2 r0 = int3x2(-1426863828, 1326150260, -990894148, -1322856473, 1973926232, 88546350);
            TestUtils.AreEqual(a0 * b0, r0);

            int3x2 a1 = int3x2(1459591173, 567624644, 1169935583, 1835691886, 385626539, 85934842);
            int3x2 b1 = int3x2(1479641221, 1428338601, 1497302909, 1596889147, 427413842, 265122693);
            int3x2 r1 = int3x2(-863919463, -582821788, 556671459, 1098186330, 1848083398, -58320414);
            TestUtils.AreEqual(a1 * b1, r1);

            int3x2 a2 = int3x2(522856538, 278370196, 289217012, 2083410174, 1293162798, 1939730122);
            int3x2 b2 = int3x2(689376654, 1120457204, 516903000, 873091659, 1353196495, 1384773500);
            int3x2 r2 = int3x2(2005201900, 651971856, -1721160736, -110160278, -119429582, -536965160);
            TestUtils.AreEqual(a2 * b2, r2);

            int3x2 a3 = int3x2(2075923048, 1116477212, 1686101741, 783310758, 248585944, 1093377716);
            int3x2 b3 = int3x2(1596528529, 2122329305, 1033200564, 996795088, 1137754930, 232014195);
            int3x2 r3 = int3x2(-2049587992, -759667012, 1443849636, 550781664, -959017424, -353108260);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mul_wide_scalar()
        {
            int3x2 a0 = int3x2(871746615, 492532311, 570557670, 2142306629, 1610315153, 1526163563);
            int b0 = (442064533);
            int3x2 r0 = int3x2(338365955, 1081376419, -1729147426, -1015409879, -873485467, -175501241);
            TestUtils.AreEqual(a0 * b0, r0);

            int3x2 a1 = int3x2(118471734, 364291059, 1186560810, 1584938026, 1357601203, 638897141);
            int b1 = (257439514);
            int3x2 r1 = int3x2(-174540932, 172874670, -725841852, -1852628412, 448041262, -853124638);
            TestUtils.AreEqual(a1 * b1, r1);

            int3x2 a2 = int3x2(268562104, 1163240135, 1619806399, 1444659979, 1127580168, 464517916);
            int b2 = (1007838321);
            int3x2 r2 = int3x2(-1156956360, 610309591, 1271183439, 624387035, -1778809464, 784123740);
            TestUtils.AreEqual(a2 * b2, r2);

            int3x2 a3 = int3x2(1508043166, 636691139, 1851670006, 357357967, 1095280227, 702779195);
            int b3 = (745488654);
            int3x2 r3 = int3x2(-79960924, 1705798058, 478992756, -1770900270, 757415018, 1348784186);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mul_scalar_wide()
        {
            int a0 = (1152242766);
            int3x2 b0 = int3x2(1276636134, 2105929407, 499007702, 124002565, 1956335172, 1288034953);
            int3x2 r0 = int3x2(-2129504236, 999811634, 1179056436, -801426554, 404105400, 1339492798);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (832676555);
            int3x2 b1 = int3x2(337389733, 99268757, 2005055247, 2011389505, 1348110859, 399689191);
            int3x2 r1 = int3x2(-388913961, -727472089, 2079172325, -1429086325, -284070727, -223994835);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (2007606374);
            int3x2 b2 = int3x2(2076691289, 1825721194, 769885235, 153314735, 1066325369, 84289667);
            int3x2 r2 = int3x2(-324990602, 588510268, 67262546, -893018182, -7630282, -1780281294);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (984486192);
            int3x2 b3 = int3x2(1325213504, 1643957457, 1576395620, 2095980601, 907671947, 836919582);
            int3x2 r3 = int3x2(-862807040, -1190246352, 673990336, 227005360, -118815472, 826880928);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_div_wide_wide()
        {
            int3x2 a0 = int3x2(333171510, 858154903, 1181365836, 671357749, 1090606752, 803759420);
            int3x2 b0 = int3x2(698897823, 440199998, 655557473, 1658534285, 2127220100, 315653188);
            int3x2 r0 = int3x2(0, 1, 1, 0, 0, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            int3x2 a1 = int3x2(788404166, 296807814, 575260195, 166625280, 1493729000, 1831739736);
            int3x2 b1 = int3x2(1814290360, 992173243, 914851653, 664340325, 224323977, 246981573);
            int3x2 r1 = int3x2(0, 0, 0, 0, 6, 7);
            TestUtils.AreEqual(a1 / b1, r1);

            int3x2 a2 = int3x2(200852358, 129983172, 500176108, 472051781, 414699094, 1446535974);
            int3x2 b2 = int3x2(285573983, 819471609, 2012476015, 1783179572, 223253978, 169515029);
            int3x2 r2 = int3x2(0, 0, 0, 0, 1, 8);
            TestUtils.AreEqual(a2 / b2, r2);

            int3x2 a3 = int3x2(1278480457, 930910505, 263295881, 1626759436, 450830871, 21439121);
            int3x2 b3 = int3x2(1694929006, 1992168131, 1155972447, 1768506696, 422325410, 1508417406);
            int3x2 r3 = int3x2(0, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_div_wide_scalar()
        {
            int3x2 a0 = int3x2(1433072926, 1073958635, 1195142312, 536596719, 1274375693, 464756346);
            int b0 = (1434025872);
            int3x2 r0 = int3x2(0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int3x2 a1 = int3x2(806462546, 1380905136, 25493909, 1196815948, 123300377, 643754735);
            int b1 = (906504670);
            int3x2 r1 = int3x2(0, 1, 0, 1, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int3x2 a2 = int3x2(2084019932, 458304263, 741331531, 466443901, 2110004616, 1500687214);
            int b2 = (2047825037);
            int3x2 r2 = int3x2(1, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int3x2 a3 = int3x2(1453264263, 2040203220, 2103351724, 485536709, 402141749, 1477264254);
            int b3 = (1617154145);
            int3x2 r3 = int3x2(0, 1, 1, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_div_scalar_wide()
        {
            int a0 = (519165704);
            int3x2 b0 = int3x2(1295178177, 775214121, 467772046, 1156881598, 310396565, 759759959);
            int3x2 r0 = int3x2(0, 0, 1, 0, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (243837702);
            int3x2 b1 = int3x2(1616314235, 1053470225, 1320630160, 378773841, 4223608, 1971105754);
            int3x2 r1 = int3x2(0, 0, 0, 0, 57, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (2054406020);
            int3x2 b2 = int3x2(219939614, 1603672651, 2006134295, 888535397, 1493077923, 615835131);
            int3x2 r2 = int3x2(9, 1, 1, 2, 1, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (1045603945);
            int3x2 b3 = int3x2(452709946, 1074919059, 467037221, 1485241506, 1775728786, 481521341);
            int3x2 r3 = int3x2(2, 0, 2, 0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mod_wide_wide()
        {
            int3x2 a0 = int3x2(258342924, 1454754891, 723352342, 1981431473, 531756042, 716993627);
            int3x2 b0 = int3x2(1990080167, 1197348066, 651970512, 1659454050, 241005212, 1866255454);
            int3x2 r0 = int3x2(258342924, 257406825, 71381830, 321977423, 49745618, 716993627);
            TestUtils.AreEqual(a0 % b0, r0);

            int3x2 a1 = int3x2(1667903349, 1331097004, 1776856101, 17598216, 1474345080, 1681376293);
            int3x2 b1 = int3x2(1440101415, 595220963, 408818410, 198222574, 549504274, 239973807);
            int3x2 r1 = int3x2(227801934, 140655078, 141582461, 17598216, 375336532, 1559644);
            TestUtils.AreEqual(a1 % b1, r1);

            int3x2 a2 = int3x2(813624265, 1617478722, 498370451, 780075943, 1754430321, 653235398);
            int3x2 b2 = int3x2(321398087, 658171840, 1511495237, 1048325585, 1126739824, 666641241);
            int3x2 r2 = int3x2(170828091, 301135042, 498370451, 780075943, 627690497, 653235398);
            TestUtils.AreEqual(a2 % b2, r2);

            int3x2 a3 = int3x2(1517128354, 966216200, 590067427, 1283434795, 1910903650, 1125967790);
            int3x2 b3 = int3x2(38017598, 418797691, 618700513, 1941062990, 158556432, 1081063558);
            int3x2 r3 = int3x2(34442032, 128620818, 590067427, 1283434795, 8226466, 44904232);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mod_wide_scalar()
        {
            int3x2 a0 = int3x2(560988938, 629524514, 767711194, 434281967, 1399805893, 792916846);
            int b0 = (1156862367);
            int3x2 r0 = int3x2(560988938, 629524514, 767711194, 434281967, 242943526, 792916846);
            TestUtils.AreEqual(a0 % b0, r0);

            int3x2 a1 = int3x2(1663690927, 1776636144, 1287035793, 1743722161, 475209785, 327476870);
            int b1 = (598661916);
            int3x2 r1 = int3x2(466367095, 579312312, 89711961, 546398329, 475209785, 327476870);
            TestUtils.AreEqual(a1 % b1, r1);

            int3x2 a2 = int3x2(1617696916, 477430114, 858399046, 712734431, 1506629323, 199829950);
            int b2 = (379853074);
            int3x2 r2 = int3x2(98284620, 97577040, 98692898, 332881357, 367070101, 199829950);
            TestUtils.AreEqual(a2 % b2, r2);

            int3x2 a3 = int3x2(362269020, 1351725413, 1549678101, 431765276, 1315833792, 1664893153);
            int b3 = (1986626876);
            int3x2 r3 = int3x2(362269020, 1351725413, 1549678101, 431765276, 1315833792, 1664893153);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_mod_scalar_wide()
        {
            int a0 = (933347930);
            int3x2 b0 = int3x2(549923387, 243114953, 1884274390, 1428033594, 655531454, 1622674954);
            int3x2 r0 = int3x2(383424543, 204003071, 933347930, 933347930, 277816476, 933347930);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1107563514);
            int3x2 b1 = int3x2(1614111094, 914801920, 1432263179, 564431096, 1967013901, 1709750152);
            int3x2 r1 = int3x2(1107563514, 192761594, 1107563514, 543132418, 1107563514, 1107563514);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1080102613);
            int3x2 b2 = int3x2(13120773, 2042535998, 1505698002, 1640058084, 974167554, 758635306);
            int3x2 r2 = int3x2(4199227, 1080102613, 1080102613, 1080102613, 105935059, 321467307);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (1387264978);
            int3x2 b3 = int3x2(611743343, 1139002766, 1913935748, 1086810076, 991846486, 922870408);
            int3x2 r3 = int3x2(163778292, 248262212, 1387264978, 300454902, 395418492, 464394570);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_plus()
        {
            int3x2 a0 = int3x2(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277);
            int3x2 r0 = int3x2(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277);
            TestUtils.AreEqual(+a0, r0);

            int3x2 a1 = int3x2(1689763402, 264115671, 1084131995, 195779102, 2131702223, 715660442);
            int3x2 r1 = int3x2(1689763402, 264115671, 1084131995, 195779102, 2131702223, 715660442);
            TestUtils.AreEqual(+a1, r1);

            int3x2 a2 = int3x2(1995564647, 1317851903, 1957501908, 531426536, 2012985092, 1334133318);
            int3x2 r2 = int3x2(1995564647, 1317851903, 1957501908, 531426536, 2012985092, 1334133318);
            TestUtils.AreEqual(+a2, r2);

            int3x2 a3 = int3x2(1539671418, 1575048895, 2119066258, 781435471, 1659000230, 1301861249);
            int3x2 r3 = int3x2(1539671418, 1575048895, 2119066258, 781435471, 1659000230, 1301861249);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_neg()
        {
            int3x2 a0 = int3x2(1385088677, 94114564, 1350664872, 1458616659, 2067164853, 218122493);
            int3x2 r0 = int3x2(-1385088677, -94114564, -1350664872, -1458616659, -2067164853, -218122493);
            TestUtils.AreEqual(-a0, r0);

            int3x2 a1 = int3x2(958484951, 446497525, 270503114, 1928771252, 1427605822, 2051940607);
            int3x2 r1 = int3x2(-958484951, -446497525, -270503114, -1928771252, -1427605822, -2051940607);
            TestUtils.AreEqual(-a1, r1);

            int3x2 a2 = int3x2(1434247484, 908365416, 1742096480, 990033169, 1368056141, 1350976157);
            int3x2 r2 = int3x2(-1434247484, -908365416, -1742096480, -990033169, -1368056141, -1350976157);
            TestUtils.AreEqual(-a2, r2);

            int3x2 a3 = int3x2(12802586, 576597401, 785136322, 559205611, 1959833280, 162379661);
            int3x2 r3 = int3x2(-12802586, -576597401, -785136322, -559205611, -1959833280, -162379661);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_prefix_inc()
        {
            int3x2 a0 = int3x2(780471723, 954741756, 272723451, 2142862245, 606294309, 1514814550);
            int3x2 r0 = int3x2(780471724, 954741757, 272723452, 2142862246, 606294310, 1514814551);
            TestUtils.AreEqual(++a0, r0);

            int3x2 a1 = int3x2(250124151, 1833356994, 1915989169, 1348278302, 129540735, 1584496757);
            int3x2 r1 = int3x2(250124152, 1833356995, 1915989170, 1348278303, 129540736, 1584496758);
            TestUtils.AreEqual(++a1, r1);

            int3x2 a2 = int3x2(1170613526, 1701179230, 1397451003, 483952900, 1494652811, 1268688387);
            int3x2 r2 = int3x2(1170613527, 1701179231, 1397451004, 483952901, 1494652812, 1268688388);
            TestUtils.AreEqual(++a2, r2);

            int3x2 a3 = int3x2(2014528731, 1112537171, 621362788, 2063486914, 1612870531, 1161037742);
            int3x2 r3 = int3x2(2014528732, 1112537172, 621362789, 2063486915, 1612870532, 1161037743);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_postfix_inc()
        {
            int3x2 a0 = int3x2(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229);
            int3x2 r0 = int3x2(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229);
            TestUtils.AreEqual(a0++, r0);

            int3x2 a1 = int3x2(903047443, 1425753247, 1384002775, 389844650, 1159795446, 1343289659);
            int3x2 r1 = int3x2(903047443, 1425753247, 1384002775, 389844650, 1159795446, 1343289659);
            TestUtils.AreEqual(a1++, r1);

            int3x2 a2 = int3x2(1227160199, 137930180, 451018043, 1634297552, 2009552507, 1176922170);
            int3x2 r2 = int3x2(1227160199, 137930180, 451018043, 1634297552, 2009552507, 1176922170);
            TestUtils.AreEqual(a2++, r2);

            int3x2 a3 = int3x2(388721494, 2062858295, 715101397, 1725384327, 446867079, 2101314783);
            int3x2 r3 = int3x2(388721494, 2062858295, 715101397, 1725384327, 446867079, 2101314783);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void int3x2_operator_prefix_dec()
        {
            int3x2 a0 = int3x2(1331961415, 1612382200, 1401591249, 2042075388, 1757136546, 1895858159);
            int3x2 r0 = int3x2(1331961414, 1612382199, 1401591248, 2042075387, 1757136545, 1895858158);
            TestUtils.AreEqual(--a0, r0);

            int3x2 a1 = int3x2(1467742422, 1336115745, 2059077641, 1169239112, 1862369220, 312317355);
            int3x2 r1 = int3x2(1467742421, 1336115744, 2059077640, 1169239111, 1862369219, 312317354);
            TestUtils.AreEqual(--a1, r1);

            int3x2 a2 = int3x2(1027543764, 1426262619, 1426620468, 674685792, 1423852012, 1459529624);
            int3x2 r2 = int3x2(1027543763, 1426262618, 1426620467, 674685791, 1423852011, 1459529623);
            TestUtils.AreEqual(--a2, r2);

            int3x2 a3 = int3x2(2092317419, 1261583506, 512900840, 1496855314, 777588547, 617644613);
            int3x2 r3 = int3x2(2092317418, 1261583505, 512900839, 1496855313, 777588546, 617644612);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_postfix_dec()
        {
            int3x2 a0 = int3x2(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869);
            int3x2 r0 = int3x2(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869);
            TestUtils.AreEqual(a0--, r0);

            int3x2 a1 = int3x2(940247280, 1015253889, 862428933, 1401191870, 2080259851, 653673271);
            int3x2 r1 = int3x2(940247280, 1015253889, 862428933, 1401191870, 2080259851, 653673271);
            TestUtils.AreEqual(a1--, r1);

            int3x2 a2 = int3x2(140452688, 1760916301, 1174531383, 634036198, 993137684, 1669210509);
            int3x2 r2 = int3x2(140452688, 1760916301, 1174531383, 634036198, 993137684, 1669210509);
            TestUtils.AreEqual(a2--, r2);

            int3x2 a3 = int3x2(874927437, 471308632, 620865961, 220103745, 1407678826, 319906934);
            int3x2 r3 = int3x2(874927437, 471308632, 620865961, 220103745, 1407678826, 319906934);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_and_wide_wide()
        {
            int3x2 a0 = int3x2(1055241304, 859321394, 1088358961, 2090949513, 300561740, 651904515);
            int3x2 b0 = int3x2(749698416, 748105424, 1842764797, 9990577, 1989102105, 1666634755);
            int3x2 r0 = int3x2(749024336, 537928720, 1087769137, 8409473, 277479432, 575816707);
            TestUtils.AreEqual(a0 & b0, r0);

            int3x2 a1 = int3x2(1331035868, 2012752753, 1298126656, 53199569, 1752363533, 1303061302);
            int3x2 b1 = int3x2(58116798, 868036607, 1420638875, 1308767169, 564040763, 478617502);
            int3x2 r1 = int3x2(55888540, 867707761, 1141707264, 33686209, 538087433, 209912598);
            TestUtils.AreEqual(a1 & b1, r1);

            int3x2 a2 = int3x2(1929998247, 1504941434, 470682792, 713577376, 1493231658, 1340884669);
            int3x2 b2 = int3x2(806150474, 674015378, 1505309955, 36064977, 1779639327, 808650076);
            int3x2 r2 = int3x2(805855490, 136347666, 403178496, 33571456, 1207967754, 2098204);
            TestUtils.AreEqual(a2 & b2, r2);

            int3x2 a3 = int3x2(1577921467, 44846626, 1105094388, 1143008413, 333009589, 2116296009);
            int3x2 b3 = int3x2(1634437037, 1997568501, 1930853951, 1901503461, 1508772523, 2010961769);
            int3x2 r3 = int3x2(1074332585, 33572896, 1091986996, 1073782917, 298320545, 1979979081);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_and_wide_scalar()
        {
            int3x2 a0 = int3x2(1513158868, 284695609, 734595037, 1566510707, 1601252476, 84213838);
            int b0 = (1173647397);
            int3x2 r0 = int3x2(1076916228, 15732769, 29360133, 1163132961, 1164976164, 84148228);
            TestUtils.AreEqual(a0 & b0, r0);

            int3x2 a1 = int3x2(314333543, 753481263, 327392481, 1619794917, 2143619546, 1873208293);
            int b1 = (430856908);
            int3x2 r1 = int3x2(279730244, 145232396, 293738688, 9181892, 428083400, 161891012);
            TestUtils.AreEqual(a1 & b1, r1);

            int3x2 a2 = int3x2(126982769, 1383096952, 1689107088, 1368301071, 366962092, 1729929586);
            int b2 = (651482651);
            int3x2 r2 = int3x2(110137873, 38814232, 612667920, 8689163, 81019912, 638877714);
            TestUtils.AreEqual(a2 & b2, r2);

            int3x2 a3 = int3x2(989550739, 1592791064, 2047510829, 678485991, 586400261, 771972179);
            int b3 = (1914435619);
            int3x2 r3 = int3x2(840652803, 1376784384, 1913292833, 537974819, 571719681, 570644483);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (477163326);
            int3x2 b0 = int3x2(110453385, 703240362, 2075630560, 1884904031, 1734899436, 947945203);
            int3x2 r0 = int3x2(68182536, 140544042, 405834528, 273697310, 73426476, 402681394);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1664399051);
            int3x2 b1 = int3x2(458879298, 158491426, 79772356, 2054527944, 202228212, 359225061);
            int3x2 r1 = int3x2(51425346, 19931650, 12992, 1647612616, 295104, 18880193);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (639811396);
            int3x2 b2 = int3x2(1821945318, 1821303024, 2030124055, 1985961756, 579780373, 2061831301);
            int3x2 r2 = int3x2(604024132, 604151872, 536886276, 637673220, 570605316, 572525572);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1139618293);
            int3x2 b3 = int3x2(1145191868, 1121606282, 1414714065, 688688277, 1508875606, 664318814);
            int3x2 r3 = int3x2(1077948852, 1120407680, 1077940433, 17563797, 1106055508, 59257172);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_or_wide_wide()
        {
            int3x2 a0 = int3x2(1920951869, 1750772852, 1420019191, 732977093, 1169579447, 229437930);
            int3x2 b0 = int3x2(214585254, 275414367, 858759675, 190211455, 1218691723, 2129565457);
            int3x2 r0 = int3x2(2130669503, 2021326207, 2008016383, 737572863, 1303895999, 2146367483);
            TestUtils.AreEqual(a0 | b0, r0);

            int3x2 a1 = int3x2(1966721348, 2039812323, 113550869, 1912038362, 1569990624, 1490718227);
            int3x2 b1 = int3x2(1862809466, 495728846, 868064152, 1756913766, 933656055, 247722084);
            int3x2 r1 = int3x2(2134507390, 2107455727, 939376541, 2046780414, 2142664695, 1591475831);
            TestUtils.AreEqual(a1 | b1, r1);

            int3x2 a2 = int3x2(1686257697, 2137727522, 1569900650, 856504729, 2033376384, 2086259889);
            int3x2 b2 = int3x2(1884195075, 1804207631, 1913174711, 1815920856, 1226577606, 1696467642);
            int3x2 r2 = int3x2(1959708963, 2146117167, 2140863231, 2134768089, 2034163398, 2103430843);
            TestUtils.AreEqual(a2 | b2, r2);

            int3x2 a3 = int3x2(671790684, 1189001916, 1756048437, 417084592, 2024165808, 966008272);
            int3x2 b3 = int3x2(186912044, 1778908130, 1461256625, 1142152181, 272117331, 1162254035);
            int3x2 r3 = int3x2(724483964, 1860172798, 2142973365, 1558183925, 2025750515, 2111217619);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_or_wide_scalar()
        {
            int3x2 a0 = int3x2(1295304853, 1307252624, 350194630, 1128063578, 1774824542, 2085245467);
            int b0 = (1305527136);
            int3x2 r0 = int3x2(1307888629, 1308350448, 1574947814, 1341973370, 1842999166, 2111492987);
            TestUtils.AreEqual(a0 | b0, r0);

            int3x2 a1 = int3x2(1988423804, 2110327307, 1050875188, 341855232, 1317039676, 228656898);
            int b1 = (999162350);
            int3x2 r1 = int3x2(2140074494, 2144275439, 1068439038, 1072582126, 2140041214, 1068435438);
            TestUtils.AreEqual(a1 | b1, r1);

            int3x2 a2 = int3x2(41280811, 606786773, 1739461580, 2040936581, 1350320187, 1377874553);
            int b2 = (1536908787);
            int3x2 r2 = int3x2(1543503355, 2143018487, 2143248383, 2076147191, 1543462395, 1539047419);
            TestUtils.AreEqual(a2 | b2, r2);

            int3x2 a3 = int3x2(1522262112, 1732466858, 1535976093, 375675620, 1614193383, 226059393);
            int b3 = (1496806239);
            int3x2 r3 = int3x2(1539306367, 2138536959, 1539273695, 1601666047, 2033710079, 1568634847);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1768627592);
            int3x2 b0 = int3x2(1849658052, 1759912154, 729979455, 975926310, 1987690876, 1809506714);
            int3x2 r0 = int3x2(1870634956, 1777286618, 1810603967, 2070642094, 2138824188, 1811676570);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (1160695341);
            int3x2 b1 = int3x2(408963395, 314072711, 1560007537, 1709003416, 977086639, 1448375596);
            int3x2 r1 = int3x2(1567543151, 1472126639, 1577049981, 1711267517, 2134896303, 1467940653);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1689568808);
            int3x2 b2 = int3x2(595543345, 559778387, 621080913, 438994183, 1742637145, 1219409263);
            int3x2 r2 = int3x2(1744815929, 1711132283, 1706358649, 2126432047, 1744752249, 1824454511);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1602932494);
            int3x2 b3 = int3x2(1204461702, 2111538444, 836730895, 1207638621, 802100209, 1089077339);
            int3x2 r3 = int3x2(1607135118, 2145111822, 2145373967, 1610342239, 2144329727, 1609224031);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_xor_wide_wide()
        {
            int3x2 a0 = int3x2(1843655608, 362425681, 640805534, 1342040268, 945678755, 980321850);
            int3x2 b0 = int3x2(1422803441, 1234691140, 119589253, 1101464929, 121896337, 1880109018);
            int3x2 r0 = int3x2(959296073, 1544407317, 554771227, 240840109, 1058935858, 1249815008);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3x2 a1 = int3x2(390165019, 1682422658, 303897251, 230477768, 1103646442, 1503102919);
            int3x2 b1 = int3x2(1000210266, 1718938232, 464406940, 884337881, 34199854, 1430659227);
            int3x2 r1 = int3x2(752651585, 36917754, 162747199, 956900113, 1136760772, 215066460);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3x2 a2 = int3x2(26631152, 1016475570, 1862440929, 379588576, 1943580404, 691527166);
            int3x2 b2 = int3x2(126415540, 1069919967, 1810763253, 2082802224, 941097951, 27782297);
            int3x2 r2 = int3x2(102672708, 55804269, 82614804, 1787102672, 1270918443, 680538471);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3x2 a3 = int3x2(723280696, 497086939, 1640104913, 893178410, 1596765788, 664096470);
            int3x2 b3 = int3x2(156353074, 607061607, 470737131, 1151564598, 8268481, 434405645);
            int3x2 r3 = int3x2(575512842, 965736380, 2110579514, 1906288924, 1599249565, 1047646171);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_xor_wide_scalar()
        {
            int3x2 a0 = int3x2(169345668, 176087064, 2084362901, 1663924004, 193851255, 517476661);
            int b0 = (354464228);
            int3x2 r0 = int3x2(523809632, 526275068, 1763470193, 1980614336, 514678419, 200843473);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3x2 a1 = int3x2(905336222, 365003873, 835837496, 954341348, 1464576786, 625604047);
            int b1 = (863800783);
            int3x2 r1 = int3x2(109762641, 649922990, 44913655, 194943531, 1681336029, 372602880);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3x2 a2 = int3x2(1700827127, 1481813598, 1077374714, 1043379893, 1991576049, 781860967);
            int b2 = (2003392824);
            int3x2 r2 = int3x2(302634703, 792459110, 928921538, 1230630797, 31215817, 1509103967);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3x2 a3 = int3x2(60088394, 858716109, 858484213, 178843494, 1223183458, 866652388);
            int b3 = (1196907956);
            int3x2 r3 = int3x2(1153678846, 1954130553, 1954295873, 1308603090, 264180182, 1962888528);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1361775641);
            int3x2 b0 = int3x2(1452773578, 459050892, 1986218254, 1689037698, 999278344, 1229114508);
            int3x2 r0 = int3x2(129801427, 1249346453, 659047703, 898082715, 1789184785, 409583765);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1087843538);
            int3x2 b1 = int3x2(733699740, 106187872, 1533632738, 1107817672, 492506236, 597602329);
            int3x2 r1 = int3x2(1802269262, 1183015090, 465456176, 47241242, 1569464494, 1665768651);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1439603382);
            int3x2 b2 = int3x2(1001169118, 1231718216, 1693179077, 1050897427, 1796435561, 1100532547);
            int3x2 r2 = int3x2(1851931240, 480517630, 824526451, 1802368677, 1054733535, 341201397);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (2106589181);
            int3x2 b3 = int3x2(79691722, 851486414, 381749210, 1743618507, 2038827673, 1680906962);
            int3x2 r3 = int3x2(2033188919, 1330600243, 1800337447, 442662454, 67761508, 431973679);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_left_shift()
        {
            int3x2 a0 = int3x2(1129100049, 829482269, 1571297368, 443753193, 1872142968, 249554593);
            int b0 = (218351941);
            int3x2 r0 = int3x2(1771463200, 773628832, -1258091776, 1315200288, -220967168, -604187616);
            TestUtils.AreEqual(a0 << b0, r0);

            int3x2 a1 = int3x2(892627436, 62369727, 849916599, 1271350845, 108441902, 1959056531);
            int b1 = (980302862);
            int3x2 r1 = int3x2(444268544, -336609280, 749584384, -779141120, -1404338176, 891600896);
            TestUtils.AreEqual(a1 << b1, r1);

            int3x2 a2 = int3x2(1779118882, 2082026915, 1149883636, 1380536034, 186532735, 1487486874);
            int b2 = (1451674188);
            int3x2 r2 = int3x2(-1288560640, -1822806016, -1655750656, -1796333568, -466096128, -1812357120);
            TestUtils.AreEqual(a2 << b2, r2);

            int3x2 a3 = int3x2(1498738574, 1647167336, 772453640, 456967739, 947384545, 1463252873);
            int b3 = (752067504);
            int3x2 r3 = int3x2(-275906560, -949485568, -1257766912, -969211904, -253689856, 2005467136);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_right_shift()
        {
            int3x2 a0 = int3x2(809126085, 908563670, 763568837, 1986717290, 1174507510, 646821842);
            int b0 = (994800051);
            int3x2 r0 = int3x2(1543, 1732, 1456, 3789, 2240, 1233);
            TestUtils.AreEqual(a0 >> b0, r0);

            int3x2 a1 = int3x2(1242726074, 1521420393, 1923166649, 102096936, 400863878, 667378673);
            int b1 = (390811632);
            int3x2 r1 = int3x2(18962, 23215, 29345, 1557, 6116, 10183);
            TestUtils.AreEqual(a1 >> b1, r1);

            int3x2 a2 = int3x2(1611921244, 479442287, 2014389412, 1673938174, 1075916177, 1248577253);
            int b2 = (307750782);
            int3x2 r2 = int3x2(1, 0, 1, 1, 1, 1);
            TestUtils.AreEqual(a2 >> b2, r2);

            int3x2 a3 = int3x2(848199210, 848976170, 500930883, 662405800, 126875849, 1103917083);
            int b3 = (813936577);
            int3x2 r3 = int3x2(424099605, 424488085, 250465441, 331202900, 63437924, 551958541);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public void int3x2_operator_bitwise_not()
        {
            int3x2 a0 = int3x2(111796841, 603562399, 745091931, 853183268, 1110916612, 381888399);
            int3x2 r0 = int3x2(-111796842, -603562400, -745091932, -853183269, -1110916613, -381888400);
            TestUtils.AreEqual(~a0, r0);

            int3x2 a1 = int3x2(1891338755, 771210628, 787710759, 875964607, 96456785, 916013379);
            int3x2 r1 = int3x2(-1891338756, -771210629, -787710760, -875964608, -96456786, -916013380);
            TestUtils.AreEqual(~a1, r1);

            int3x2 a2 = int3x2(203444882, 1020232736, 683852713, 375158799, 881353367, 1218471344);
            int3x2 r2 = int3x2(-203444883, -1020232737, -683852714, -375158800, -881353368, -1218471345);
            TestUtils.AreEqual(~a2, r2);

            int3x2 a3 = int3x2(1174233245, 443427914, 1385118179, 215320517, 860122767, 1411266016);
            int3x2 r3 = int3x2(-1174233246, -443427915, -1385118180, -215320518, -860122768, -1411266017);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
