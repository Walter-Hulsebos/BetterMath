// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2x4
    {
        [TestCompiler]
        public void int2x4_zero()
        {
            TestUtils.AreEqual(int2x4.zero.c0.x, 0);
            TestUtils.AreEqual(int2x4.zero.c0.y, 0);
            TestUtils.AreEqual(int2x4.zero.c1.x, 0);
            TestUtils.AreEqual(int2x4.zero.c1.y, 0);
            TestUtils.AreEqual(int2x4.zero.c2.x, 0);
            TestUtils.AreEqual(int2x4.zero.c2.y, 0);
            TestUtils.AreEqual(int2x4.zero.c3.x, 0);
            TestUtils.AreEqual(int2x4.zero.c3.y, 0);
        }

        [TestCompiler]
        public void int2x4_operator_equal_wide_wide()
        {
            int2x4 a0 = int2x4(2105871082, 35218899, 1550755093, 764676020, 606743782, 1208156098, 1023640014, 1038468316);
            int2x4 b0 = int2x4(1477587886, 579629692, 540974792, 208405066, 2063397938, 1060167409, 362592601, 2097545362);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x4 a1 = int2x4(1416064367, 727143393, 2061243891, 184669837, 1303661760, 2044073738, 370395888, 1822916805);
            int2x4 b1 = int2x4(277670088, 426944490, 901076223, 857900673, 1548779757, 325265488, 312658571, 176373760);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x4 a2 = int2x4(1076983135, 345215866, 833676277, 1987782708, 1481088614, 1364754268, 93639636, 1850596922);
            int2x4 b2 = int2x4(2052378097, 858156597, 982817797, 1252095508, 882634538, 1959142806, 72495800, 1077678183);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x4 a3 = int2x4(2073471507, 1745989448, 28118669, 1267554232, 1292918049, 1423451579, 644384701, 1985492825);
            int2x4 b3 = int2x4(1729269763, 1607675346, 1813461519, 1204794859, 1324801873, 1975336, 439410532, 294085211);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_equal_wide_scalar()
        {
            int2x4 a0 = int2x4(437822262, 2020661134, 541786900, 853113810, 23716499, 179951405, 1409026299, 948838849);
            int b0 = (1332833578);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x4 a1 = int2x4(953202998, 1926262965, 1851546137, 712957637, 2028784869, 1049962241, 1836975611, 1016802970);
            int b1 = (691955848);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x4 a2 = int2x4(390120467, 1451642042, 289137869, 152339338, 808355440, 660053867, 597354173, 67320270);
            int b2 = (464814777);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x4 a3 = int2x4(151461188, 602895443, 186996278, 129611815, 1031574999, 1697392883, 1463742000, 857785521);
            int b3 = (35153827);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_equal_scalar_wide()
        {
            int a0 = (542329200);
            int2x4 b0 = int2x4(1115584594, 684107773, 1928988941, 890709324, 641152437, 1410341302, 497505660, 1068223109);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (2014009435);
            int2x4 b1 = int2x4(213835595, 1592428361, 1819361470, 448650623, 1942175642, 64377057, 1485938610, 1146305380);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1312317120);
            int2x4 b2 = int2x4(263290348, 812663708, 1585209188, 40646617, 1378718922, 1957797737, 873652576, 1780082094);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1513270921);
            int2x4 b3 = int2x4(2095980581, 1413074719, 1387984261, 1547119354, 924385171, 1253636050, 1477542688, 969120167);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_not_equal_wide_wide()
        {
            int2x4 a0 = int2x4(1977284100, 1293292704, 1547283851, 422428953, 195833190, 1711544892, 5606053, 737069074);
            int2x4 b0 = int2x4(1514195556, 957972049, 507667364, 581861672, 1128094576, 940096636, 57559040, 181752616);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x4 a1 = int2x4(647386678, 13079405, 1413841590, 1076166545, 1211445174, 1289303469, 1436402489, 1129570126);
            int2x4 b1 = int2x4(962017320, 1762015406, 1107218953, 2042026522, 836002288, 570272309, 2112081980, 1500634658);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x4 a2 = int2x4(1566836685, 1343313905, 329259205, 1774944480, 33906739, 2055853627, 2035015372, 1702756001);
            int2x4 b2 = int2x4(1787808345, 566425667, 2037529609, 1520589840, 266793699, 538816359, 2075474643, 553571317);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x4 a3 = int2x4(1164186087, 329853698, 769052491, 1893312730, 438029011, 1894010522, 1365847542, 1292942830);
            int2x4 b3 = int2x4(218264354, 654754196, 1392180230, 870065147, 1398749829, 711281563, 1999640291, 231234857);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_not_equal_wide_scalar()
        {
            int2x4 a0 = int2x4(1038269360, 1427812625, 103361237, 1347017023, 1523584313, 150442802, 660334527, 719113717);
            int b0 = (768873026);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x4 a1 = int2x4(262959423, 506946952, 226568494, 507918242, 1702162286, 923269270, 166187260, 114581840);
            int b1 = (484398043);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x4 a2 = int2x4(1045389187, 1461803977, 61801615, 1317840133, 2146927809, 1557151164, 1284033253, 1345705546);
            int b2 = (1648095254);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x4 a3 = int2x4(1747302566, 1368046109, 1848036266, 2025452920, 373992983, 289537519, 1388743060, 146455100);
            int b3 = (611028295);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_not_equal_scalar_wide()
        {
            int a0 = (1652127596);
            int2x4 b0 = int2x4(953791238, 271722683, 1278885987, 735128017, 112416504, 25967222, 1761444475, 1844594536);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1199122922);
            int2x4 b1 = int2x4(634219279, 942501101, 67161343, 969944293, 833229499, 1304301133, 704045745, 345012334);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1253134152);
            int2x4 b2 = int2x4(325772538, 855127202, 793668881, 1584481616, 1101301152, 276853534, 987168816, 1258105989);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (362645228);
            int2x4 b3 = int2x4(293978043, 1772395973, 1692007315, 681268929, 1535518457, 595209334, 25745185, 1278016813);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_wide_wide()
        {
            int2x4 a0 = int2x4(1486550609, 1779244308, 1602148045, 1614085440, 1975613414, 942838342, 1092279031, 373677431);
            int2x4 b0 = int2x4(97842578, 536551311, 413528975, 1838293684, 1283898480, 1456599961, 1080278602, 529676676);
            bool2x4 r0 = bool2x4(false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x4 a1 = int2x4(1419098312, 337757077, 1081797900, 1336745069, 840685445, 1220554047, 2013681746, 192965012);
            int2x4 b1 = int2x4(156584048, 117348799, 246927124, 1916615924, 1731071394, 1328098431, 1014995792, 480319327);
            bool2x4 r1 = bool2x4(false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x4 a2 = int2x4(532043965, 1000693402, 927236048, 1215860000, 780607596, 1882056852, 1354146545, 2135295778);
            int2x4 b2 = int2x4(1765937053, 1333997067, 688515308, 1856106947, 1303906227, 646821776, 1169473993, 316770064);
            bool2x4 r2 = bool2x4(true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x4 a3 = int2x4(1145973790, 1938006975, 895882838, 2006524299, 908581156, 1843349513, 1340458575, 1972095585);
            int2x4 b3 = int2x4(1518155802, 416732703, 529193056, 1239623485, 2010112031, 2018560298, 285987009, 960617622);
            bool2x4 r3 = bool2x4(true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_wide_scalar()
        {
            int2x4 a0 = int2x4(796797557, 670113454, 933579492, 278884514, 318174822, 1117630673, 741886928, 1990922600);
            int b0 = (746564682);
            bool2x4 r0 = bool2x4(false, true, false, true, true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x4 a1 = int2x4(1030849597, 1718582899, 1648393417, 1857132231, 1909506562, 1294006045, 952084157, 1303736668);
            int b1 = (1546212312);
            bool2x4 r1 = bool2x4(true, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x4 a2 = int2x4(845460171, 1368236640, 24980695, 1434668705, 659552739, 1058492383, 165694933, 1204097259);
            int b2 = (979430272);
            bool2x4 r2 = bool2x4(true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x4 a3 = int2x4(922212691, 24629507, 1386458568, 1325149699, 1498707004, 1650355158, 1213017950, 1650457461);
            int b3 = (281328069);
            bool2x4 r3 = bool2x4(false, true, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_scalar_wide()
        {
            int a0 = (186400299);
            int2x4 b0 = int2x4(1881344229, 813834467, 1254886626, 1353590345, 1412343685, 1555571443, 1540508298, 1735458634);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (135888070);
            int2x4 b1 = int2x4(1643818742, 248291654, 1739560105, 728539891, 480507742, 1696553040, 540223931, 1840493353);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (146833656);
            int2x4 b2 = int2x4(798115946, 2002002066, 1011261705, 783550942, 1093071215, 598253401, 1432416562, 1863582169);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (103622950);
            int2x4 b3 = int2x4(775175960, 116908309, 1213433625, 1428954824, 1760442490, 1208143947, 751820805, 1491872302);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_wide_wide()
        {
            int2x4 a0 = int2x4(2087717754, 1725569452, 1298066182, 1693943616, 1319019629, 70674491, 1042499725, 1002821508);
            int2x4 b0 = int2x4(85148514, 293632137, 1151128249, 409440398, 1115020183, 1508500597, 1834583302, 1755218534);
            bool2x4 r0 = bool2x4(true, true, true, true, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x4 a1 = int2x4(1021857133, 1744374599, 821751047, 467646903, 2029731638, 1377214212, 1207816926, 474621063);
            int2x4 b1 = int2x4(1788761753, 1128238489, 834223713, 1578743290, 1647150256, 1756397855, 1131080201, 1208965204);
            bool2x4 r1 = bool2x4(false, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x4 a2 = int2x4(20781266, 366593779, 2068457387, 10181449, 793634464, 144474612, 99947390, 930377263);
            int2x4 b2 = int2x4(1495161099, 1283714281, 908051907, 412849651, 815822687, 730271942, 40756039, 883326140);
            bool2x4 r2 = bool2x4(false, false, true, false, false, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x4 a3 = int2x4(683686232, 742803073, 918292048, 875621429, 1764985258, 411384146, 1921397684, 1349107119);
            int2x4 b3 = int2x4(476260632, 1024136446, 1440596667, 1253494041, 146826162, 1798399573, 2085029408, 187939428);
            bool2x4 r3 = bool2x4(true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_wide_scalar()
        {
            int2x4 a0 = int2x4(1208626274, 239697208, 1979453345, 1253474001, 1590192876, 1487911635, 1673945595, 1662650098);
            int b0 = (1715176566);
            bool2x4 r0 = bool2x4(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x4 a1 = int2x4(222749855, 566635217, 1773305960, 1850273578, 206147145, 325913453, 333381537, 1905567362);
            int b1 = (1433540517);
            bool2x4 r1 = bool2x4(false, false, true, true, false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x4 a2 = int2x4(2053577491, 2128431130, 1735325311, 529971908, 1663525234, 1972984241, 1587865063, 488268523);
            int b2 = (570397194);
            bool2x4 r2 = bool2x4(true, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x4 a3 = int2x4(121921923, 181082921, 1281638484, 1818357732, 116518997, 1397728785, 1924199337, 742950077);
            int b3 = (812076921);
            bool2x4 r3 = bool2x4(false, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_scalar_wide()
        {
            int a0 = (480938827);
            int2x4 b0 = int2x4(1824731899, 921496110, 586859044, 946430596, 1231356727, 1390167458, 1785807092, 28949024);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (2037899283);
            int2x4 b1 = int2x4(595656760, 1778095771, 1233500439, 1696302238, 1445965340, 484020151, 1586962841, 1361740714);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (265628948);
            int2x4 b2 = int2x4(2003122957, 332267433, 1128353075, 377919478, 982113135, 1117675960, 630865591, 1550679736);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (895945757);
            int2x4 b3 = int2x4(287025687, 643452096, 660504007, 613135893, 633307118, 514276792, 1377364317, 84491736);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_equal_wide_wide()
        {
            int2x4 a0 = int2x4(154092149, 1515170149, 1083970332, 785807178, 1401094881, 310537627, 868328962, 1990816725);
            int2x4 b0 = int2x4(77984380, 1712054191, 1566203809, 254834519, 450519938, 389457083, 1298669505, 207343167);
            bool2x4 r0 = bool2x4(false, true, true, false, false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x4 a1 = int2x4(2035349541, 457043352, 1123282035, 1001842946, 1387761992, 195272789, 659549000, 888761458);
            int2x4 b1 = int2x4(1214449047, 2059561026, 896534357, 1897470050, 521075677, 1848221945, 374708019, 1573731118);
            bool2x4 r1 = bool2x4(false, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x4 a2 = int2x4(283706617, 1790185840, 899029812, 848317418, 1743712447, 1504407474, 1798441490, 1902791952);
            int2x4 b2 = int2x4(2093466449, 1660210829, 1568778785, 1352157589, 1212771905, 1457525058, 1493446008, 1784768208);
            bool2x4 r2 = bool2x4(true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x4 a3 = int2x4(606340844, 1994437705, 301831413, 654230470, 1223625081, 324292199, 1370931020, 1742769166);
            int2x4 b3 = int2x4(1993422493, 1378671664, 1447376929, 1405041439, 1765183746, 562894655, 1085068880, 1026386862);
            bool2x4 r3 = bool2x4(true, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_equal_wide_scalar()
        {
            int2x4 a0 = int2x4(1479531977, 1427983411, 415250630, 1245345407, 1112546666, 1072990632, 1579912858, 101048307);
            int b0 = (2004563877);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x4 a1 = int2x4(1070894375, 1910488590, 85452501, 518127023, 1246249980, 1097326500, 1964410699, 1968139888);
            int b1 = (509818792);
            bool2x4 r1 = bool2x4(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x4 a2 = int2x4(1191853379, 1140643434, 754434551, 155343473, 995927387, 974873240, 1773400038, 497436329);
            int b2 = (662096238);
            bool2x4 r2 = bool2x4(false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x4 a3 = int2x4(1825940497, 1477043363, 1378470734, 96190147, 37188105, 839762283, 781102710, 766321672);
            int b3 = (527516420);
            bool2x4 r3 = bool2x4(false, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_less_equal_scalar_wide()
        {
            int a0 = (1899193992);
            int2x4 b0 = int2x4(915011820, 980913757, 1337699683, 1476321359, 1102143668, 660493983, 184664508, 381579707);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1954892821);
            int2x4 b1 = int2x4(1295090571, 1440368586, 1696003686, 88708652, 1332251857, 1310713644, 2112132784, 48951945);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1888568027);
            int2x4 b2 = int2x4(39340955, 1108242207, 260777425, 593122164, 291471959, 253457314, 1264570386, 699618012);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (927735863);
            int2x4 b3 = int2x4(2063158939, 932253787, 1168754049, 749328788, 1882694892, 168499987, 378173027, 339963627);
            bool2x4 r3 = bool2x4(true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_equal_wide_wide()
        {
            int2x4 a0 = int2x4(8538378, 2131749726, 265427108, 523609761, 994991818, 839709564, 101288202, 1886280970);
            int2x4 b0 = int2x4(903145828, 1697992986, 1432491982, 169789504, 1059357300, 1744255222, 1606584463, 1905414425);
            bool2x4 r0 = bool2x4(false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x4 a1 = int2x4(2032074826, 631221455, 1456286159, 961342752, 424526026, 788481984, 1662488497, 870326690);
            int2x4 b1 = int2x4(1448794969, 136181998, 1678754836, 2069656857, 398982689, 243317404, 740939613, 1894753119);
            bool2x4 r1 = bool2x4(true, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x4 a2 = int2x4(708712581, 1260182701, 1165630721, 138247561, 1108650168, 1933222913, 672493999, 1541402159);
            int2x4 b2 = int2x4(301760792, 1260647988, 3608523, 52576030, 903420465, 1648820371, 627296845, 1679808907);
            bool2x4 r2 = bool2x4(true, false, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x4 a3 = int2x4(1921596027, 1557351956, 147242547, 892772168, 2089286723, 1273466960, 644009998, 654784654);
            int2x4 b3 = int2x4(1719102039, 1718081638, 655586949, 477267189, 62092869, 2013928066, 280292357, 254052205);
            bool2x4 r3 = bool2x4(true, false, false, true, true, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_equal_wide_scalar()
        {
            int2x4 a0 = int2x4(2049236663, 182691143, 634973382, 1197012109, 439837565, 1367606469, 1108037359, 351147187);
            int b0 = (1061998015);
            bool2x4 r0 = bool2x4(true, false, false, true, false, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x4 a1 = int2x4(1898505669, 1998610091, 4652390, 996159180, 2111455181, 727766399, 96217144, 814085575);
            int b1 = (411667685);
            bool2x4 r1 = bool2x4(true, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x4 a2 = int2x4(1525995206, 1732973229, 1473283041, 899444524, 1023753195, 1373738074, 518164359, 717850464);
            int b2 = (1293933760);
            bool2x4 r2 = bool2x4(true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x4 a3 = int2x4(1765188600, 527594558, 1816542874, 839185150, 1143596061, 1819554651, 160724539, 993212636);
            int b3 = (1826820341);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_greater_equal_scalar_wide()
        {
            int a0 = (1859811087);
            int2x4 b0 = int2x4(1070365918, 1783869452, 830091760, 377157428, 327199016, 90384229, 1154649706, 376758501);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1079802834);
            int2x4 b1 = int2x4(2054742898, 1328349472, 434061447, 951207723, 598695892, 975131651, 1714007943, 177416473);
            bool2x4 r1 = bool2x4(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (1267232721);
            int2x4 b2 = int2x4(31082860, 216791741, 119054289, 1905107583, 89559116, 55041824, 691334141, 462326883);
            bool2x4 r2 = bool2x4(true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1658303669);
            int2x4 b3 = int2x4(914628512, 1134364322, 1677134711, 1955614770, 2067009301, 1454405405, 299467282, 1584922149);
            bool2x4 r3 = bool2x4(true, true, false, false, false, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_add_wide_wide()
        {
            int2x4 a0 = int2x4(2135171378, 21433296, 1954723494, 683604307, 1054212315, 1762680995, 1963655852, 1257853062);
            int2x4 b0 = int2x4(1013431952, 366718162, 359290756, 1393163294, 1962236872, 1263270041, 1862666629, 1077447887);
            int2x4 r0 = int2x4(-1146363966, 388151458, -1980953046, 2076767601, -1278518109, -1269016260, -468644815, -1959666347);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x4 a1 = int2x4(2043493600, 976898058, 1915056423, 121374462, 1218855698, 700538222, 1702057277, 1788251699);
            int2x4 b1 = int2x4(821693806, 487316539, 350922520, 1583012528, 1951595076, 1024851344, 874302782, 1383969588);
            int2x4 r1 = int2x4(-1429779890, 1464214597, -2028988353, 1704386990, -1124516522, 1725389566, -1718607237, -1122746009);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x4 a2 = int2x4(1534939160, 398651016, 1674272498, 374510467, 824322986, 1217622199, 1122376670, 642613771);
            int2x4 b2 = int2x4(1767968088, 900721406, 1659790033, 1792273749, 443844328, 633981449, 2010244807, 335566991);
            int2x4 r2 = int2x4(-992060048, 1299372422, -960904765, -2128183080, 1268167314, 1851603648, -1162345819, 978180762);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x4 a3 = int2x4(1097903998, 359042741, 929182687, 1713065399, 892057490, 1295346111, 1806236181, 1838589664);
            int2x4 b3 = int2x4(521931102, 544297835, 1681549647, 1784248858, 585904415, 3128418, 1806236610, 179909533);
            int2x4 r3 = int2x4(1619835100, 903340576, -1684234962, -797653039, 1477961905, 1298474529, -682494505, 2018499197);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_add_wide_scalar()
        {
            int2x4 a0 = int2x4(665815972, 1783729250, 1591678394, 1284528538, 977850224, 71069732, 1138577680, 1200356017);
            int b0 = (1334043849);
            int2x4 r0 = int2x4(1999859821, -1177194197, -1369245053, -1676394909, -1983073223, 1405113581, -1822345767, -1760567430);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x4 a1 = int2x4(565982008, 1088001167, 57252642, 678921480, 625943813, 512157429, 1470648741, 1490096953);
            int b1 = (1246759684);
            int2x4 r1 = int2x4(1812741692, -1960206445, 1304012326, 1925681164, 1872703497, 1758917113, -1577558871, -1558110659);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x4 a2 = int2x4(1467033531, 1707296407, 1703724354, 1333833947, 653973063, 1139546735, 1834005844, 184572739);
            int b2 = (182608093);
            int2x4 r2 = int2x4(1649641624, 1889904500, 1886332447, 1516442040, 836581156, 1322154828, 2016613937, 367180832);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x4 a3 = int2x4(1980578280, 97099208, 421437295, 1251829854, 166844260, 1568146789, 82548613, 533562157);
            int b3 = (1858520040);
            int2x4 r3 = int2x4(-455868976, 1955619248, -2015009961, -1184617402, 2025364300, -868300467, 1941068653, -1902885099);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_add_scalar_wide()
        {
            int a0 = (359966320);
            int2x4 b0 = int2x4(2146146202, 767103309, 851002415, 311531406, 1491262941, 1016891373, 1954228994, 1671335850);
            int2x4 r0 = int2x4(-1788854774, 1127069629, 1210968735, 671497726, 1851229261, 1376857693, -1980771982, 2031302170);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (727870747);
            int2x4 b1 = int2x4(551151834, 1390261152, 1699060326, 115021619, 1964440175, 440700758, 1556692550, 185414255);
            int2x4 r1 = int2x4(1279022581, 2118131899, -1868036223, 842892366, -1602656374, 1168571505, -2010403999, 913285002);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (933106731);
            int2x4 b2 = int2x4(1217866784, 729761881, 1742597318, 1090109152, 1467373815, 1066072609, 138237856, 634834665);
            int2x4 r2 = int2x4(-2143993781, 1662868612, -1619263247, 2023215883, -1894486750, 1999179340, 1071344587, 1567941396);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (993603553);
            int2x4 b3 = int2x4(347587889, 2050191349, 670698672, 1658205080, 1874808705, 2082982954, 869839589, 118460267);
            int2x4 r3 = int2x4(1341191442, -1251172394, 1664302225, -1643158663, -1426555038, -1218380789, 1863443142, 1112063820);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_sub_wide_wide()
        {
            int2x4 a0 = int2x4(1410318491, 1097280168, 1827039044, 28881338, 328720965, 875487868, 212936325, 231977215);
            int2x4 b0 = int2x4(1315897366, 799052018, 1580289673, 1094686261, 1954325726, 1197734816, 229886366, 915679176);
            int2x4 r0 = int2x4(94421125, 298228150, 246749371, -1065804923, -1625604761, -322246948, -16950041, -683701961);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x4 a1 = int2x4(1740021315, 2011295463, 48079003, 591379285, 1125909359, 1842588095, 848561896, 614448464);
            int2x4 b1 = int2x4(1746884850, 918743925, 1007797419, 257421324, 287249342, 1617287463, 1653916102, 123586847);
            int2x4 r1 = int2x4(-6863535, 1092551538, -959718416, 333957961, 838660017, 225300632, -805354206, 490861617);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x4 a2 = int2x4(2067598029, 1618238416, 318516219, 1090119767, 1991095823, 949592162, 1951912339, 1457818751);
            int2x4 b2 = int2x4(502107404, 672875302, 1256481116, 1975569142, 1794443030, 1327558915, 330955394, 1596041731);
            int2x4 r2 = int2x4(1565490625, 945363114, -937964897, -885449375, 196652793, -377966753, 1620956945, -138222980);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x4 a3 = int2x4(1642553126, 2114366549, 1420516260, 596841760, 724518081, 1820626306, 1885185225, 246124365);
            int2x4 b3 = int2x4(1069074732, 1120817099, 2076417364, 402521072, 839858844, 1539789702, 559077522, 822288510);
            int2x4 r3 = int2x4(573478394, 993549450, -655901104, 194320688, -115340763, 280836604, 1326107703, -576164145);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_sub_wide_scalar()
        {
            int2x4 a0 = int2x4(1508669340, 1594795463, 266707545, 643102647, 287705008, 1475644328, 1113286221, 979450511);
            int b0 = (998008471);
            int2x4 r0 = int2x4(510660869, 596786992, -731300926, -354905824, -710303463, 477635857, 115277750, -18557960);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x4 a1 = int2x4(2082174113, 304369206, 999244508, 1806482044, 1994553647, 2101812429, 1482736902, 266654115);
            int b1 = (1108005498);
            int2x4 r1 = int2x4(974168615, -803636292, -108760990, 698476546, 886548149, 993806931, 374731404, -841351383);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x4 a2 = int2x4(1470212363, 958542155, 1185075537, 1738124835, 499527536, 1612473406, 1696960099, 1287292743);
            int b2 = (1190349300);
            int2x4 r2 = int2x4(279863063, -231807145, -5273763, 547775535, -690821764, 422124106, 506610799, 96943443);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x4 a3 = int2x4(1360229454, 1779621585, 964948785, 1739264125, 94254551, 968533883, 2075770560, 946189008);
            int b3 = (1032360376);
            int2x4 r3 = int2x4(327869078, 747261209, -67411591, 706903749, -938105825, -63826493, 1043410184, -86171368);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_sub_scalar_wide()
        {
            int a0 = (893369501);
            int2x4 b0 = int2x4(2051906184, 1699714311, 442603706, 1735141684, 274533585, 811580259, 1196354320, 1524097023);
            int2x4 r0 = int2x4(-1158536683, -806344810, 450765795, -841772183, 618835916, 81789242, -302984819, -630727522);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (533621527);
            int2x4 b1 = int2x4(2080845793, 143958837, 1620668660, 1135989346, 1367044745, 554088609, 552670373, 1265516124);
            int2x4 r1 = int2x4(-1547224266, 389662690, -1087047133, -602367819, -833423218, -20467082, -19048846, -731894597);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1254902543);
            int2x4 b2 = int2x4(1857695581, 1619865274, 1313559400, 99812999, 843597298, 420111239, 1299949060, 531009038);
            int2x4 r2 = int2x4(-602793038, -364962731, -58656857, 1155089544, 411305245, 834791304, -45046517, 723893505);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1103306550);
            int2x4 b3 = int2x4(104920105, 1137308312, 1207332725, 103438360, 1157123503, 1174401240, 701247193, 1498366995);
            int2x4 r3 = int2x4(998386445, -34001762, -104026175, 999868190, -53816953, -71094690, 402059357, -395060445);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mul_wide_wide()
        {
            int2x4 a0 = int2x4(61417577, 219585476, 1362520891, 1511084277, 1481211272, 58211871, 1459591173, 567624644);
            int2x4 b0 = int2x4(578042444, 1620527213, 200516468, 309339115, 542853019, 299467282, 1479641221, 1428338601);
            int2x4 r0 = int2x4(-1426863828, 1326150260, -990894148, -1322856473, 1973926232, 88546350, -863919463, -582821788);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x4 a1 = int2x4(1169935583, 1835691886, 385626539, 85934842, 522856538, 278370196, 289217012, 2083410174);
            int2x4 b1 = int2x4(1497302909, 1596889147, 427413842, 265122693, 689376654, 1120457204, 516903000, 873091659);
            int2x4 r1 = int2x4(556671459, 1098186330, 1848083398, -58320414, 2005201900, 651971856, -1721160736, -110160278);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x4 a2 = int2x4(1293162798, 1939730122, 2075923048, 1116477212, 1686101741, 783310758, 248585944, 1093377716);
            int2x4 b2 = int2x4(1353196495, 1384773500, 1596528529, 2122329305, 1033200564, 996795088, 1137754930, 232014195);
            int2x4 r2 = int2x4(-119429582, -536965160, -2049587992, -759667012, 1443849636, 550781664, -959017424, -353108260);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x4 a3 = int2x4(797038788, 1838048120, 1892922904, 1952024781, 492107602, 1097670675, 2069629919, 20122103);
            int2x4 b3 = int2x4(1080950243, 1613216909, 463529448, 1781487382, 2101946430, 673144237, 390627073, 964308272);
            int2x4 r3 = int2x4(-1093604916, 264300824, -121602624, 1825729694, -241519140, -1246587945, -2064143137, -251115184);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mul_wide_scalar()
        {
            int2x4 a0 = int2x4(871746615, 492532311, 570557670, 2142306629, 1610315153, 1526163563, 118471734, 257439514);
            int b0 = (442064533);
            int2x4 r0 = int2x4(338365955, 1081376419, -1729147426, -1015409879, -873485467, -175501241, -838181010, 513646114);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x4 a1 = int2x4(364291059, 1584938026, 1357601203, 638897141, 268562104, 1007838321, 1163240135, 1619806399);
            int b1 = (1186560810);
            int2x4 r1 = int2x4(1029154526, 989596900, 521189470, -1619710670, 1627099696, 753911178, -1861135962, 167687254);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x4 a2 = int2x4(1444659979, 464517916, 1508043166, 745488654, 636691139, 1851670006, 357357967, 1095280227);
            int b2 = (1127580168);
            int2x4 r2 = int2x4(204516952, -1949298464, -1049655056, 73999472, -492889064, -2074682448, 679242360, 1245870360);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x4 a3 = int2x4(702779195, 1464398841, 51061000, 802418971, 407442471, 638315697, 1889264235, 584402164);
            int b3 = (945802744);
            int2x4 r3 = int2x4(-586547160, -76431816, -567056448, 1852387624, 241680584, -171571080, 1493698216, 2103324768);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mul_scalar_wide()
        {
            int a0 = (1152242766);
            int2x4 b0 = int2x4(1276636134, 2105929407, 499007702, 124002565, 1956335172, 1288034953, 832676555, 337389733);
            int2x4 r0 = int2x4(-2129504236, 999811634, 1179056436, -801426554, 404105400, 1339492798, -381766182, -1111620026);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (99268757);
            int2x4 b1 = int2x4(2005055247, 2011389505, 1348110859, 399689191, 2007606374, 2076691289, 1825721194, 769885235);
            int2x4 r1 = int2x4(559764411, -1619094571, 1022902375, -1005504653, -685637794, 1103844045, 2105414834, 302946735);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (153314735);
            int2x4 b2 = int2x4(1066325369, 84289667, 984486192, 1325213504, 1643957457, 1576395620, 2095980601, 907671947);
            int2x4 r2 = int2x4(1030204087, 35283085, -749359152, 2102006976, 305231839, -663165604, -1035369481, 1010199813);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (836919582);
            int2x4 b3 = int2x4(1412159342, 2037926630, 366590562, 493177763, 2058824164, 497936968, 2136548816, 1211907591);
            int2x4 r3 = int2x4(-1226838812, -175772428, 1537669500, -865230822, 1738427576, -71910288, -446284192, 1673391058);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_div_wide_wide()
        {
            int2x4 a0 = int2x4(333171510, 858154903, 1181365836, 671357749, 1090606752, 803759420, 788404166, 296807814);
            int2x4 b0 = int2x4(698897823, 440199998, 655557473, 1658534285, 2127220100, 315653188, 1814290360, 992173243);
            int2x4 r0 = int2x4(0, 1, 1, 0, 0, 2, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x4 a1 = int2x4(575260195, 166625280, 1493729000, 1831739736, 200852358, 129983172, 500176108, 472051781);
            int2x4 b1 = int2x4(914851653, 664340325, 224323977, 246981573, 285573983, 819471609, 2012476015, 1783179572);
            int2x4 r1 = int2x4(0, 0, 6, 7, 0, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x4 a2 = int2x4(414699094, 1446535974, 1278480457, 930910505, 263295881, 1626759436, 450830871, 21439121);
            int2x4 b2 = int2x4(223253978, 169515029, 1694929006, 1992168131, 1155972447, 1768506696, 422325410, 1508417406);
            int2x4 r2 = int2x4(1, 8, 0, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x4 a3 = int2x4(521337599, 127756712, 200601965, 412554396, 1014641734, 239347640, 525574301, 1158358177);
            int2x4 b3 = int2x4(605462475, 66917170, 2014683461, 108847533, 611173330, 895791853, 1999369787, 1225614384);
            int2x4 r3 = int2x4(0, 1, 0, 3, 1, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_div_wide_scalar()
        {
            int2x4 a0 = int2x4(1433072926, 1073958635, 1195142312, 536596719, 1274375693, 464756346, 806462546, 906504670);
            int b0 = (1434025872);
            int2x4 r0 = int2x4(0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x4 a1 = int2x4(1380905136, 1196815948, 123300377, 643754735, 2084019932, 2047825037, 458304263, 741331531);
            int b1 = (25493909);
            int2x4 r1 = int2x4(54, 46, 4, 25, 81, 80, 17, 29);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x4 a2 = int2x4(466443901, 1500687214, 1453264263, 1617154145, 2040203220, 2103351724, 485536709, 402141749);
            int b2 = (2110004616);
            int2x4 r2 = int2x4(0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x4 a3 = int2x4(1477264254, 1549487015, 670594363, 2040479674, 155415284, 207130003, 1596922206, 1730223836);
            int b3 = (1629069474);
            int2x4 r3 = int2x4(0, 0, 0, 1, 0, 0, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_div_scalar_wide()
        {
            int a0 = (519165704);
            int2x4 b0 = int2x4(1295178177, 775214121, 467772046, 1156881598, 310396565, 759759959, 243837702, 1616314235);
            int2x4 r0 = int2x4(0, 0, 1, 0, 1, 0, 2, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1053470225);
            int2x4 b1 = int2x4(1320630160, 378773841, 4223608, 1971105754, 2054406020, 219939614, 1603672651, 2006134295);
            int2x4 r1 = int2x4(0, 2, 249, 0, 0, 4, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (888535397);
            int2x4 b2 = int2x4(1493077923, 615835131, 1045603945, 452709946, 1074919059, 467037221, 1485241506, 1775728786);
            int2x4 r2 = int2x4(0, 1, 0, 1, 0, 1, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (481521341);
            int2x4 b3 = int2x4(68149923, 80867357, 1294049272, 470535313, 1235850199, 631464286, 687722755, 412827650);
            int2x4 r3 = int2x4(7, 5, 0, 1, 0, 0, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mod_wide_wide()
        {
            int2x4 a0 = int2x4(258342924, 1454754891, 723352342, 1981431473, 531756042, 716993627, 1667903349, 1331097004);
            int2x4 b0 = int2x4(1990080167, 1197348066, 651970512, 1659454050, 241005212, 1866255454, 1440101415, 595220963);
            int2x4 r0 = int2x4(258342924, 257406825, 71381830, 321977423, 49745618, 716993627, 227801934, 140655078);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x4 a1 = int2x4(1776856101, 17598216, 1474345080, 1681376293, 813624265, 1617478722, 498370451, 780075943);
            int2x4 b1 = int2x4(408818410, 198222574, 549504274, 239973807, 321398087, 658171840, 1511495237, 1048325585);
            int2x4 r1 = int2x4(141582461, 17598216, 375336532, 1559644, 170828091, 301135042, 498370451, 780075943);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x4 a2 = int2x4(1754430321, 653235398, 1517128354, 966216200, 590067427, 1283434795, 1910903650, 1125967790);
            int2x4 b2 = int2x4(1126739824, 666641241, 38017598, 418797691, 618700513, 1941062990, 158556432, 1081063558);
            int2x4 r2 = int2x4(627690497, 653235398, 34442032, 128620818, 590067427, 1283434795, 8226466, 44904232);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x4 a3 = int2x4(1180537254, 308567230, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599);
            int2x4 b3 = int2x4(427329468, 148111230, 1251162672, 1856322297, 1214781084, 401954255, 1323259633, 1167744452);
            int2x4 r3 = int2x4(325878318, 12344770, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mod_wide_scalar()
        {
            int2x4 a0 = int2x4(560988938, 629524514, 767711194, 434281967, 1399805893, 792916846, 1663690927, 598661916);
            int b0 = (1156862367);
            int2x4 r0 = int2x4(560988938, 629524514, 767711194, 434281967, 242943526, 792916846, 506828560, 598661916);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x4 a1 = int2x4(1776636144, 1743722161, 475209785, 327476870, 1617696916, 379853074, 477430114, 858399046);
            int b1 = (1287035793);
            int2x4 r1 = int2x4(489600351, 456686368, 475209785, 327476870, 330661123, 379853074, 477430114, 858399046);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x4 a2 = int2x4(712734431, 199829950, 362269020, 1986626876, 1351725413, 1549678101, 431765276, 1315833792);
            int b2 = (1506629323);
            int2x4 r2 = int2x4(712734431, 199829950, 362269020, 479997553, 1351725413, 43048778, 431765276, 1315833792);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x4 a3 = int2x4(1664893153, 780055604, 104179235, 629966219, 1810536428, 1747026206, 1799535061, 875754431);
            int b3 = (615834034);
            int2x4 r3 = int2x4(433225085, 164221570, 104179235, 14132185, 578868360, 515358138, 567866993, 259920397);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_mod_scalar_wide()
        {
            int a0 = (933347930);
            int2x4 b0 = int2x4(549923387, 243114953, 1884274390, 1428033594, 655531454, 1622674954, 1107563514, 1614111094);
            int2x4 r0 = int2x4(383424543, 204003071, 933347930, 933347930, 277816476, 933347930, 933347930, 933347930);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (914801920);
            int2x4 b1 = int2x4(1432263179, 564431096, 1967013901, 1709750152, 1080102613, 13120773, 2042535998, 1505698002);
            int2x4 r1 = int2x4(914801920, 350370824, 914801920, 914801920, 914801920, 9468583, 914801920, 914801920);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1640058084);
            int2x4 b2 = int2x4(974167554, 758635306, 1387264978, 611743343, 1139002766, 1913935748, 1086810076, 991846486);
            int2x4 r2 = int2x4(665890530, 122787472, 252793106, 416571398, 501055318, 1640058084, 553248008, 648211598);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (922870408);
            int2x4 b3 = int2x4(35007468, 891877602, 157349181, 83267982, 801093706, 546272767, 1665089132, 1889242068);
            int2x4 r3 = int2x4(12676240, 30992806, 136124503, 6922606, 121776702, 376597641, 922870408, 922870408);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_plus()
        {
            int2x4 a0 = int2x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785);
            int2x4 r0 = int2x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785);
            TestUtils.AreEqual(+a0, r0);

            int2x4 a1 = int2x4(264115671, 195779102, 2131702223, 715660442, 1995564647, 69731564, 1317851903, 1957501908);
            int2x4 r1 = int2x4(264115671, 195779102, 2131702223, 715660442, 1995564647, 69731564, 1317851903, 1957501908);
            TestUtils.AreEqual(+a1, r1);

            int2x4 a2 = int2x4(531426536, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471, 1659000230);
            int2x4 r2 = int2x4(531426536, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471, 1659000230);
            TestUtils.AreEqual(+a2, r2);

            int2x4 a3 = int2x4(1301861249, 1360657696, 578750954, 150348334, 1791553179, 1288641627, 735146513, 328684789);
            int2x4 r3 = int2x4(1301861249, 1360657696, 578750954, 150348334, 1791553179, 1288641627, 735146513, 328684789);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_neg()
        {
            int2x4 a0 = int2x4(1385088677, 94114564, 1350664872, 1458616659, 2067164853, 218122493, 958484951, 270553961);
            int2x4 r0 = int2x4(-1385088677, -94114564, -1350664872, -1458616659, -2067164853, -218122493, -958484951, -270553961);
            TestUtils.AreEqual(-a0, r0);

            int2x4 a1 = int2x4(446497525, 1928771252, 1427605822, 2051940607, 1434247484, 485368391, 908365416, 1742096480);
            int2x4 r1 = int2x4(-446497525, -1928771252, -1427605822, -2051940607, -1434247484, -485368391, -908365416, -1742096480);
            TestUtils.AreEqual(-a1, r1);

            int2x4 a2 = int2x4(990033169, 1350976157, 12802586, 1934372287, 576597401, 785136322, 559205611, 1959833280);
            int2x4 r2 = int2x4(-990033169, -1350976157, -12802586, -1934372287, -576597401, -785136322, -559205611, -1959833280);
            TestUtils.AreEqual(-a2, r2);

            int2x4 a3 = int2x4(162379661, 95281343, 1969004480, 1381288239, 252975075, 1961335692, 1607042487, 832886233);
            int2x4 r3 = int2x4(-162379661, -95281343, -1969004480, -1381288239, -252975075, -1961335692, -1607042487, -832886233);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_prefix_inc()
        {
            int2x4 a0 = int2x4(780471723, 954741756, 272723451, 2142862245, 606294309, 1514814550, 250124151, 444189162);
            int2x4 r0 = int2x4(780471724, 954741757, 272723452, 2142862246, 606294310, 1514814551, 250124152, 444189163);
            TestUtils.AreEqual(++a0, r0);

            int2x4 a1 = int2x4(1833356994, 1348278302, 129540735, 1584496757, 1170613526, 986715680, 1701179230, 1397451003);
            int2x4 r1 = int2x4(1833356995, 1348278303, 129540736, 1584496758, 1170613527, 986715681, 1701179231, 1397451004);
            TestUtils.AreEqual(++a1, r1);

            int2x4 a2 = int2x4(483952900, 1268688387, 2014528731, 453850931, 1112537171, 621362788, 2063486914, 1612870531);
            int2x4 r2 = int2x4(483952901, 1268688388, 2014528732, 453850932, 1112537172, 621362789, 2063486915, 1612870532);
            TestUtils.AreEqual(++a2, r2);

            int2x4 a3 = int2x4(1161037742, 1583359796, 82587894, 810087437, 72436569, 1094485773, 912422931, 1011314676);
            int2x4 r3 = int2x4(1161037743, 1583359797, 82587895, 810087438, 72436570, 1094485774, 912422932, 1011314677);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_postfix_inc()
        {
            int2x4 a0 = int2x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244);
            int2x4 r0 = int2x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244);
            TestUtils.AreEqual(a0++, r0);

            int2x4 a1 = int2x4(1425753247, 389844650, 1159795446, 1343289659, 1227160199, 947635082, 137930180, 451018043);
            int2x4 r1 = int2x4(1425753247, 389844650, 1159795446, 1343289659, 1227160199, 947635082, 137930180, 451018043);
            TestUtils.AreEqual(a1++, r1);

            int2x4 a2 = int2x4(1634297552, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327, 446867079);
            int2x4 r2 = int2x4(1634297552, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327, 446867079);
            TestUtils.AreEqual(a2++, r2);

            int2x4 a3 = int2x4(2101314783, 1683365096, 1319511974, 1418603655, 1938539756, 592683318, 1576213022, 1150548583);
            int2x4 r3 = int2x4(2101314783, 1683365096, 1319511974, 1418603655, 1938539756, 592683318, 1576213022, 1150548583);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void int2x4_operator_prefix_dec()
        {
            int2x4 a0 = int2x4(1331961415, 1612382200, 1401591249, 2042075388, 1757136546, 1895858159, 1467742422, 578341664);
            int2x4 r0 = int2x4(1331961414, 1612382199, 1401591248, 2042075387, 1757136545, 1895858158, 1467742421, 578341663);
            TestUtils.AreEqual(--a0, r0);

            int2x4 a1 = int2x4(1336115745, 1169239112, 1862369220, 312317355, 1027543764, 1595492535, 1426262619, 1426620468);
            int2x4 r1 = int2x4(1336115744, 1169239111, 1862369219, 312317354, 1027543763, 1595492534, 1426262618, 1426620467);
            TestUtils.AreEqual(--a1, r1);

            int2x4 a2 = int2x4(674685792, 1459529624, 2092317419, 107501474, 1261583506, 512900840, 1496855314, 777588547);
            int2x4 r2 = int2x4(674685791, 1459529623, 2092317418, 107501473, 1261583505, 512900839, 1496855313, 777588546);
            TestUtils.AreEqual(--a2, r2);

            int2x4 a3 = int2x4(617644613, 625907330, 1452782388, 804650978, 2076275981, 120447533, 262357170, 1887136873);
            int2x4 r3 = int2x4(617644612, 625907329, 1452782387, 804650977, 2076275980, 120447532, 262357169, 1887136872);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_postfix_dec()
        {
            int2x4 a0 = int2x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351);
            int2x4 r0 = int2x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351);
            TestUtils.AreEqual(a0--, r0);

            int2x4 a1 = int2x4(1015253889, 1401191870, 2080259851, 653673271, 140452688, 1928164223, 1760916301, 1174531383);
            int2x4 r1 = int2x4(1015253889, 1401191870, 2080259851, 653673271, 140452688, 1928164223, 1760916301, 1174531383);
            TestUtils.AreEqual(a1--, r1);

            int2x4 a2 = int2x4(634036198, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745, 1407678826);
            int2x4 r2 = int2x4(634036198, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745, 1407678826);
            TestUtils.AreEqual(a2--, r2);

            int2x4 a3 = int2x4(319906934, 488775250, 1681733117, 1916879863, 2060905976, 636358505, 1379709480, 451326084);
            int2x4 r3 = int2x4(319906934, 488775250, 1681733117, 1916879863, 2060905976, 636358505, 1379709480, 451326084);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_and_wide_wide()
        {
            int2x4 a0 = int2x4(1055241304, 859321394, 1088358961, 2090949513, 300561740, 651904515, 1331035868, 2012752753);
            int2x4 b0 = int2x4(749698416, 748105424, 1842764797, 9990577, 1989102105, 1666634755, 58116798, 868036607);
            int2x4 r0 = int2x4(749024336, 537928720, 1087769137, 8409473, 277479432, 575816707, 55888540, 867707761);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x4 a1 = int2x4(1298126656, 53199569, 1752363533, 1303061302, 1929998247, 1504941434, 470682792, 713577376);
            int2x4 b1 = int2x4(1420638875, 1308767169, 564040763, 478617502, 806150474, 674015378, 1505309955, 36064977);
            int2x4 r1 = int2x4(1141707264, 33686209, 538087433, 209912598, 805855490, 136347666, 403178496, 33571456);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x4 a2 = int2x4(1493231658, 1340884669, 1577921467, 44846626, 1105094388, 1143008413, 333009589, 2116296009);
            int2x4 b2 = int2x4(1779639327, 808650076, 1634437037, 1997568501, 1930853951, 1901503461, 1508772523, 2010961769);
            int2x4 r2 = int2x4(1207967754, 2098204, 1074332585, 33572896, 1091986996, 1073782917, 298320545, 1979979081);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x4 a3 = int2x4(2067254825, 121795325, 2122365250, 1088796653, 1594120761, 965590824, 337823363, 1686791432);
            int2x4 b3 = int2x4(1495957269, 1914669725, 1263994006, 491200541, 380703892, 282208487, 1416934135, 942735432);
            int2x4 r3 = int2x4(1495420417, 33686173, 1241513986, 4530189, 369102864, 276834336, 337674883, 536870920);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_and_wide_scalar()
        {
            int2x4 a0 = int2x4(1513158868, 284695609, 734595037, 1566510707, 1601252476, 84213838, 314333543, 430856908);
            int b0 = (1173647397);
            int2x4 r0 = int2x4(1076916228, 15732769, 29360133, 1163132961, 1164976164, 84148228, 11816997, 27545604);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x4 a1 = int2x4(753481263, 1619794917, 2143619546, 1873208293, 126982769, 651482651, 1383096952, 1689107088);
            int b1 = (327392481);
            int2x4 r1 = int2x4(8459297, 8394977, 327223488, 58884321, 58824801, 41980929, 301989984, 8493184);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x4 a2 = int2x4(1368301071, 1729929586, 989550739, 1914435619, 1592791064, 2047510829, 678485991, 586400261);
            int b2 = (366962092);
            int2x4 r2 = int2x4(294519820, 85729568, 282804352, 270229536, 349175816, 269091116, 5260708, 13844484);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x4 a3 = int2x4(771972179, 131945492, 1707451796, 394184188, 1943201012, 558008097, 1070093422, 34324916);
            int b3 = (309059606);
            int2x4 r3 = int2x4(33767442, 38354964, 4300820, 308985876, 306372628, 4358144, 306724870, 34324500);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_and_scalar_wide()
        {
            int a0 = (477163326);
            int2x4 b0 = int2x4(110453385, 703240362, 2075630560, 1884904031, 1734899436, 947945203, 1664399051, 458879298);
            int2x4 r0 = int2x4(68182536, 140544042, 405834528, 273697310, 73426476, 402681394, 3188234, 407953666);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (158491426);
            int2x4 b1 = int2x4(79772356, 2054527944, 202228212, 359225061, 639811396, 1821945318, 1821303024, 2030124055);
            int2x4 r1 = int2x4(4203008, 141558528, 134234400, 23085600, 2237184, 135274786, 134373408, 151003138);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1985961756);
            int2x4 b2 = int2x4(579780373, 2061831301, 1139618293, 1145191868, 1121606282, 1414714065, 688688277, 1508875606);
            int2x4 r2 = int2x4(571350804, 1917127684, 1112346900, 1145183516, 1113217544, 1414681104, 537660436, 1347362068);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (664318814);
            int2x4 b3 = int2x4(2092766410, 1010043618, 599967779, 47076367, 1325716015, 1119912335, 2083412385, 1805692137);
            int2x4 r3 = int2x4(613945418, 605028930, 595623938, 42471438, 117477902, 41976078, 604508416, 595632200);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_or_wide_wide()
        {
            int2x4 a0 = int2x4(1920951869, 1750772852, 1420019191, 732977093, 1169579447, 229437930, 1966721348, 2039812323);
            int2x4 b0 = int2x4(214585254, 275414367, 858759675, 190211455, 1218691723, 2129565457, 1862809466, 495728846);
            int2x4 r0 = int2x4(2130669503, 2021326207, 2008016383, 737572863, 1303895999, 2146367483, 2134507390, 2107455727);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x4 a1 = int2x4(113550869, 1912038362, 1569990624, 1490718227, 1686257697, 2137727522, 1569900650, 856504729);
            int2x4 b1 = int2x4(868064152, 1756913766, 933656055, 247722084, 1884195075, 1804207631, 1913174711, 1815920856);
            int2x4 r1 = int2x4(939376541, 2046780414, 2142664695, 1591475831, 1959708963, 2146117167, 2140863231, 2134768089);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x4 a2 = int2x4(2033376384, 2086259889, 671790684, 1189001916, 1756048437, 417084592, 2024165808, 966008272);
            int2x4 b2 = int2x4(1226577606, 1696467642, 186912044, 1778908130, 1461256625, 1142152181, 272117331, 1162254035);
            int2x4 r2 = int2x4(2034163398, 2103430843, 724483964, 1860172798, 2142973365, 1558183925, 2025750515, 2111217619);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x4 a3 = int2x4(2031026290, 1461019191, 1071959084, 1645847295, 871350674, 736640317, 868515800, 767794452);
            int2x4 b3 = int2x4(870448102, 1845053992, 257334526, 987295814, 1503050768, 1683307763, 1076253109, 1403888383);
            int2x4 r3 = int2x4(2079325174, 2147314239, 1073143038, 2061103871, 2080374162, 1878867455, 1944485885, 2146418687);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_or_wide_scalar()
        {
            int2x4 a0 = int2x4(1295304853, 1307252624, 350194630, 1128063578, 1774824542, 2085245467, 1988423804, 999162350);
            int b0 = (1305527136);
            int2x4 r0 = int2x4(1307888629, 1308350448, 1574947814, 1341973370, 1842999166, 2111492987, 2144662396, 2145305582);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x4 a1 = int2x4(2110327307, 341855232, 1317039676, 228656898, 41280811, 1536908787, 606786773, 1739461580);
            int b1 = (1050875188);
            int2x4 r1 = int2x4(2146115391, 1055087924, 2124644156, 1067652918, 1056437567, 2142985719, 1051448821, 2142181372);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x4 a2 = int2x4(2040936581, 1377874553, 1522262112, 1496806239, 1732466858, 1535976093, 375675620, 1614193383);
            int b2 = (1350320187);
            int2x4 r2 = int2x4(2046720191, 1383920251, 1526718587, 1501524863, 2004834491, 1543332543, 1450990335, 1887363839);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x4 a3 = int2x4(226059393, 112556963, 1614163749, 1583289054, 1370656810, 1286074530, 1155438844, 1835671387);
            int b3 = (697385997);
            int2x4 r3 = int2x4(771318925, 800423855, 1773629229, 2145343199, 2041828399, 1840772271, 1843387645, 1845190495);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1768627592);
            int2x4 b0 = int2x4(1849658052, 1759912154, 729979455, 975926310, 1987690876, 1809506714, 1160695341, 408963395);
            int2x4 r0 = int2x4(1870634956, 1777286618, 1810603967, 2070642094, 2138824188, 1811676570, 1836048301, 2037079499);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (314072711);
            int2x4 b1 = int2x4(1560007537, 1709003416, 977086639, 1448375596, 1689568808, 595543345, 559778387, 621080913);
            int2x4 r1 = int2x4(1593565175, 2013093535, 985497263, 1459388335, 1992089263, 872374199, 872275671, 935133143);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (438994183);
            int2x4 b2 = int2x4(1742637145, 1219409263, 1602932494, 1204461702, 2111538444, 836730895, 1207638621, 802100209);
            int2x4 r2 = int2x4(2147388767, 1521399151, 1605029647, 1609213319, 2147190031, 1006601487, 1610325855, 1072666615);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1089077339);
            int2x4 b3 = int2x4(1315030334, 249047666, 1604790897, 1848168086, 347254235, 1777613639, 1876731927, 842785732);
            int2x4 r3 = int2x4(1324074367, 1325017723, 1609509499, 1860882143, 1425714651, 1778269023, 1878960223, 1929110495);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_xor_wide_wide()
        {
            int2x4 a0 = int2x4(1843655608, 362425681, 640805534, 1342040268, 945678755, 980321850, 390165019, 1682422658);
            int2x4 b0 = int2x4(1422803441, 1234691140, 119589253, 1101464929, 121896337, 1880109018, 1000210266, 1718938232);
            int2x4 r0 = int2x4(959296073, 1544407317, 554771227, 240840109, 1058935858, 1249815008, 752651585, 36917754);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x4 a1 = int2x4(303897251, 230477768, 1103646442, 1503102919, 26631152, 1016475570, 1862440929, 379588576);
            int2x4 b1 = int2x4(464406940, 884337881, 34199854, 1430659227, 126415540, 1069919967, 1810763253, 2082802224);
            int2x4 r1 = int2x4(162747199, 956900113, 1136760772, 215066460, 102672708, 55804269, 82614804, 1787102672);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x4 a2 = int2x4(1943580404, 691527166, 723280696, 497086939, 1640104913, 893178410, 1596765788, 664096470);
            int2x4 b2 = int2x4(941097951, 27782297, 156353074, 607061607, 470737131, 1151564598, 8268481, 434405645);
            int2x4 r2 = int2x4(1270918443, 680538471, 575512842, 965736380, 2110579514, 1906288924, 1599249565, 1047646171);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x4 a3 = int2x4(2043360590, 799560121, 287637604, 696169196, 2067184169, 1208059988, 1250597330, 1386507647);
            int2x4 b3 = int2x4(519003095, 1880915120, 608970922, 1809455754, 1079250101, 514389994, 272120301, 1282399149);
            int2x4 r3 = int2x4(1730440857, 1605643529, 896084174, 1118087270, 996325020, 1453948862, 1521655871, 516667090);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_xor_wide_scalar()
        {
            int2x4 a0 = int2x4(169345668, 176087064, 2084362901, 1663924004, 193851255, 517476661, 905336222, 863800783);
            int b0 = (354464228);
            int2x4 r0 = int2x4(523809632, 526275068, 1763470193, 1980614336, 514678419, 200843473, 550954106, 643578923);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x4 a1 = int2x4(365003873, 954341348, 1464576786, 625604047, 1700827127, 2003392824, 1481813598, 1077374714);
            int b1 = (835837496);
            int2x4 r1 = int2x4(605051481, 154388956, 1721398570, 345517047, 1420906959, 1186498304, 1770221670, 1910943938);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x4 a2 = int2x4(1043379893, 781860967, 60088394, 1196907956, 858716109, 858484213, 178843494, 1223183458);
            int b2 = (1991576049);
            int2x4 r2 = int2x4(1216724804, 1479494038, 1965156795, 836916293, 1167851068, 1168008196, 2082334359, 1046300051);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x4 a3 = int2x4(866652388, 1206307664, 2037729583, 1324393116, 497725784, 1367278685, 962962860, 906632547);
            int b3 = (1771693181);
            int2x4 r3 = int2x4(1513223321, 780087085, 283946322, 661210849, 1949521189, 954654752, 1358709201, 1603533086);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1361775641);
            int2x4 b0 = int2x4(1452773578, 459050892, 1986218254, 1689037698, 999278344, 1229114508, 1087843538, 733699740);
            int2x4 r0 = int2x4(129801427, 1249346453, 659047703, 898082715, 1789184785, 409583765, 301736139, 2056278661);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (106187872);
            int2x4 b1 = int2x4(1533632738, 1107817672, 492506236, 597602329, 1439603382, 1001169118, 1231718216, 1693179077);
            int2x4 r1 = int2x4(1564290178, 1146337448, 453984284, 634059897, 1402656470, 1039723710, 1329515304, 1656721573);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1050897427);
            int2x4 b2 = int2x4(1796435561, 1100532547, 2106589181, 79691722, 851486414, 381749210, 1743618507, 2038827673);
            int2x4 r2 = int2x4(1437598330, 2134615888, 1126994926, 974951385, 207866589, 677538761, 1498344920, 1193633418);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (1680906962);
            int2x4 b3 = int2x4(161437943, 171927307, 277703584, 1344718195, 1634011177, 28540247, 1205447252, 150341716);
            int2x4 r3 = int2x4(1840235045, 1846541785, 1958605170, 873881505, 89494267, 1703143301, 602484870, 1824952966);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_left_shift()
        {
            int2x4 a0 = int2x4(1129100049, 829482269, 1571297368, 443753193, 1872142968, 249554593, 892627436, 980302862);
            int b0 = (218351941);
            int2x4 r0 = int2x4(1771463200, 773628832, -1258091776, 1315200288, -220967168, -604187616, -1500693120, 1304920512);
            TestUtils.AreEqual(a0 << b0, r0);

            int2x4 a1 = int2x4(62369727, 1271350845, 108441902, 1959056531, 1779118882, 1451674188, 2082026915, 1149883636);
            int b1 = (849916599);
            int2x4 r1 = int2x4(-545259520, 511705088, -1761607680, 1233125376, -1862270976, 637534208, -780140544, 2046820352);
            TestUtils.AreEqual(a1 << b1, r1);

            int2x4 a2 = int2x4(1380536034, 1487486874, 1498738574, 752067504, 1647167336, 772453640, 456967739, 947384545);
            int b2 = (186532735);
            int2x4 r2 = int2x4(0, 0, 0, 0, 0, 0, -2147483648, -2147483648);
            TestUtils.AreEqual(a2 << b2, r2);

            int2x4 a3 = int2x4(1463252873, 640579158, 56630178, 1650899378, 2142944517, 565484033, 965161323, 1634169280);
            int b3 = (1315516161);
            int2x4 r3 = int2x4(-1368461550, 1281158316, 113260356, -993168540, -9078262, 1130968066, 1930322646, -1026628736);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_right_shift()
        {
            int2x4 a0 = int2x4(809126085, 908563670, 763568837, 1986717290, 1174507510, 646821842, 1242726074, 390811632);
            int b0 = (994800051);
            int2x4 r0 = int2x4(1543, 1732, 1456, 3789, 2240, 1233, 2370, 745);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2x4 a1 = int2x4(1521420393, 102096936, 400863878, 667378673, 1611921244, 307750782, 479442287, 2014389412);
            int b1 = (1923166649);
            int2x4 r1 = int2x4(45, 3, 11, 19, 48, 9, 14, 60);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2x4 a2 = int2x4(1673938174, 1248577253, 848199210, 813936577, 848976170, 500930883, 662405800, 126875849);
            int b2 = (1075916177);
            int2x4 r2 = int2x4(12771, 9525, 6471, 6209, 6477, 3821, 5053, 967);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2x4 a3 = int2x4(1103917083, 955487090, 1013356510, 391605984, 185228398, 87452680, 2021602226, 1401766495);
            int b3 = (1199000503);
            int2x4 r3 = int2x4(131, 113, 120, 46, 22, 10, 240, 167);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public void int2x4_operator_bitwise_not()
        {
            int2x4 a0 = int2x4(111796841, 603562399, 745091931, 853183268, 1110916612, 381888399, 1891338755, 1506860135);
            int2x4 r0 = int2x4(-111796842, -603562400, -745091932, -853183269, -1110916613, -381888400, -1891338756, -1506860136);
            TestUtils.AreEqual(~a0, r0);

            int2x4 a1 = int2x4(771210628, 875964607, 96456785, 916013379, 203444882, 1172294211, 1020232736, 683852713);
            int2x4 r1 = int2x4(-771210629, -875964608, -96456786, -916013380, -203444883, -1172294212, -1020232737, -683852714);
            TestUtils.AreEqual(~a1, r1);

            int2x4 a2 = int2x4(375158799, 1218471344, 1174233245, 592898220, 443427914, 1385118179, 215320517, 860122767);
            int2x4 r2 = int2x4(-375158800, -1218471345, -1174233246, -592898221, -443427915, -1385118180, -215320518, -860122768);
            TestUtils.AreEqual(~a2, r2);

            int2x4 a3 = int2x4(1411266016, 686325107, 829984855, 191189901, 319233142, 156019905, 1467719681, 1193642973);
            int2x4 r3 = int2x4(-1411266017, -686325108, -829984856, -191189902, -319233143, -156019906, -1467719682, -1193642974);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
