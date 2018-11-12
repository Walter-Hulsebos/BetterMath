// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3x4
    {
        [TestCompiler]
        public void uint3x4_zero()
        {
            TestUtils.AreEqual(uint3x4.zero.c0.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c0.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c0.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.z, 0u);
        }

        [TestCompiler]
        public void uint3x4_operator_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(2105871082, 35218899, 1550755093, 764676020, 606743782, 1208156098, 1023640014, 1038468316, 1416064367, 727143393, 2061243891, 184669837);
            uint3x4 b0 = uint3x4(1477587886, 579629692, 540974792, 208405066, 2063397938, 1060167409, 362592601, 2097545362, 277670088, 426944490, 901076223, 857900673);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x4 a1 = uint3x4(1303661760, 2044073738, 370395888, 1822916805, 1076983135, 345215866, 833676277, 1987782708, 1481088614, 1364754268, 93639636, 1850596922);
            uint3x4 b1 = uint3x4(1548779757, 325265488, 312658571, 176373760, 2052378097, 858156597, 982817797, 1252095508, 882634538, 1959142806, 72495800, 1077678183);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x4 a2 = uint3x4(2073471507, 1745989448, 28118669, 1267554232, 1292918049, 1423451579, 644384701, 1985492825, 240481133, 2130667921, 17376735, 1263869085);
            uint3x4 b2 = uint3x4(1729269763, 1607675346, 1813461519, 1204794859, 1324801873, 1975336, 439410532, 294085211, 1031782338, 1118745564, 180311719, 433246570);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x4 a3 = uint3x4(437371027, 1093339523, 1683805602, 764261037, 1845666482, 399277628, 714152770, 148255091, 784823865, 1712722195, 1706849865, 607710807);
            uint3x4 b3 = uint3x4(1622531532, 1178609353, 373010678, 1231165960, 966395555, 788609772, 215241459, 1411005263, 1287904654, 1656358051, 1985807372, 1041678082);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(437822262, 2020661134, 541786900, 853113810, 23716499, 179951405, 1409026299, 948838849, 953202998, 691955848, 1926262965, 1851546137);
            uint b0 = (1332833578);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x4 a1 = uint3x4(712957637, 1049962241, 1836975611, 1016802970, 390120467, 464814777, 1451642042, 289137869, 152339338, 808355440, 660053867, 597354173);
            uint b1 = (2028784869);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x4 a2 = uint3x4(67320270, 35153827, 602895443, 186996278, 129611815, 1031574999, 1697392883, 1463742000, 857785521, 611116281, 594150729, 375387566);
            uint b2 = (151461188);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x4 a3 = uint3x4(1984352551, 570698441, 1872629381, 1263218472, 315982238, 122473806, 1404530826, 43943273, 1695786992, 2085125114, 432271298, 465353570);
            uint b3 = (1925707182);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_equal_scalar_wide()
        {
            uint a0 = (542329200);
            uint3x4 b0 = uint3x4(1115584594, 684107773, 1928988941, 890709324, 641152437, 1410341302, 497505660, 1068223109, 2014009435, 213835595, 1592428361, 1819361470);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (448650623);
            uint3x4 b1 = uint3x4(1942175642, 64377057, 1485938610, 1146305380, 1312317120, 263290348, 812663708, 1585209188, 40646617, 1378718922, 1957797737, 873652576);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (1780082094);
            uint3x4 b2 = uint3x4(1513270921, 2095980581, 1413074719, 1387984261, 1547119354, 924385171, 1253636050, 1477542688, 969120167, 591812191, 856880926, 1114040166);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (2107388425);
            uint3x4 b3 = uint3x4(1368188588, 512677295, 1337925727, 2076181515, 1317314747, 299981273, 601822512, 1079453890, 125277108, 1257151509, 1915342590, 1034639325);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_not_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(1977284100, 1293292704, 1547283851, 422428953, 195833190, 1711544892, 5606053, 737069074, 647386678, 13079405, 1413841590, 1076166545);
            uint3x4 b0 = uint3x4(1514195556, 957972049, 507667364, 581861672, 1128094576, 940096636, 57559040, 181752616, 962017320, 1762015406, 1107218953, 2042026522);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x4 a1 = uint3x4(1211445174, 1289303469, 1436402489, 1129570126, 1566836685, 1343313905, 329259205, 1774944480, 33906739, 2055853627, 2035015372, 1702756001);
            uint3x4 b1 = uint3x4(836002288, 570272309, 2112081980, 1500634658, 1787808345, 566425667, 2037529609, 1520589840, 266793699, 538816359, 2075474643, 553571317);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x4 a2 = uint3x4(1164186087, 329853698, 769052491, 1893312730, 438029011, 1894010522, 1365847542, 1292942830, 2146008097, 1520743598, 861728782, 1999977058);
            uint3x4 b2 = uint3x4(218264354, 654754196, 1392180230, 870065147, 1398749829, 711281563, 1999640291, 231234857, 210910234, 365281355, 170643407, 757340716);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x4 a3 = uint3x4(1334556487, 1728108667, 1198848973, 7011150, 1280729934, 1553569869, 1782228282, 731582167, 2041979262, 128396656, 143519087, 154742298);
            uint3x4 b3 = uint3x4(639973212, 1147047891, 537350186, 1283454178, 735732152, 1218138135, 474815930, 174656455, 473248758, 1077993023, 1063662917, 181750095);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_not_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1038269360, 1427812625, 103361237, 1347017023, 1523584313, 150442802, 660334527, 719113717, 262959423, 484398043, 506946952, 226568494);
            uint b0 = (768873026);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x4 a1 = uint3x4(507918242, 923269270, 166187260, 114581840, 1045389187, 1648095254, 1461803977, 61801615, 1317840133, 2146927809, 1557151164, 1284033253);
            uint b1 = (1702162286);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x4 a2 = uint3x4(1345705546, 611028295, 1368046109, 1848036266, 2025452920, 373992983, 289537519, 1388743060, 146455100, 1854553487, 872755032, 2113020512);
            uint b2 = (1747302566);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x4 a3 = uint3x4(1062447442, 109864030, 1583997921, 1732461790, 1276630817, 721080697, 922945173, 1528002730, 282331576, 1372281893, 167200566, 1271483982);
            uint b3 = (632285066);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_not_equal_scalar_wide()
        {
            uint a0 = (1652127596);
            uint3x4 b0 = uint3x4(953791238, 271722683, 1278885987, 735128017, 112416504, 25967222, 1761444475, 1844594536, 1199122922, 634219279, 942501101, 67161343);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (969944293);
            uint3x4 b1 = uint3x4(833229499, 1304301133, 704045745, 345012334, 1253134152, 325772538, 855127202, 793668881, 1584481616, 1101301152, 276853534, 987168816);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1258105989);
            uint3x4 b2 = uint3x4(362645228, 293978043, 1772395973, 1692007315, 681268929, 1535518457, 595209334, 25745185, 1278016813, 2125682481, 2037751005, 1405297618);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1825546885);
            uint3x4 b3 = uint3x4(1584424742, 1779859088, 1262387250, 936213998, 739749071, 1934808433, 1333711144, 571211509, 445791940, 43428024, 1509344718, 1643255886);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_wide_wide()
        {
            uint3x4 a0 = uint3x4(1486550609, 1779244308, 1602148045, 1614085440, 1975613414, 942838342, 1092279031, 373677431, 1419098312, 337757077, 1081797900, 1336745069);
            uint3x4 b0 = uint3x4(97842578, 536551311, 413528975, 1838293684, 1283898480, 1456599961, 1080278602, 529676676, 156584048, 117348799, 246927124, 1916615924);
            bool3x4 r0 = bool3x4(false, false, false, true, false, true, false, true, false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x4 a1 = uint3x4(840685445, 1220554047, 2013681746, 192965012, 532043965, 1000693402, 927236048, 1215860000, 780607596, 1882056852, 1354146545, 2135295778);
            uint3x4 b1 = uint3x4(1731071394, 1328098431, 1014995792, 480319327, 1765937053, 1333997067, 688515308, 1856106947, 1303906227, 646821776, 1169473993, 316770064);
            bool3x4 r1 = bool3x4(true, true, false, true, true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x4 a2 = uint3x4(1145973790, 1938006975, 895882838, 2006524299, 908581156, 1843349513, 1340458575, 1972095585, 1090933468, 924555996, 79585200, 1749924275);
            uint3x4 b2 = uint3x4(1518155802, 416732703, 529193056, 1239623485, 2010112031, 2018560298, 285987009, 960617622, 462519015, 1473825625, 1187164011, 730583004);
            bool3x4 r2 = bool3x4(true, false, false, false, true, true, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x4 a3 = uint3x4(1088207695, 1484224850, 512353919, 562469379, 1743259263, 182124641, 1224472464, 1731920136, 1906896401, 425415911, 992649442, 515648372);
            uint3x4 b3 = uint3x4(629133777, 1925375320, 689923293, 1818695099, 903783983, 495525944, 1923715956, 2850909, 1908553564, 1064607664, 1344783349, 494620587);
            bool3x4 r3 = bool3x4(false, true, true, true, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_wide_scalar()
        {
            uint3x4 a0 = uint3x4(796797557, 670113454, 933579492, 278884514, 318174822, 1117630673, 741886928, 1990922600, 1030849597, 1546212312, 1718582899, 1648393417);
            uint b0 = (746564682);
            bool3x4 r0 = bool3x4(false, true, false, true, true, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x4 a1 = uint3x4(1857132231, 1294006045, 952084157, 1303736668, 845460171, 979430272, 1368236640, 24980695, 1434668705, 659552739, 1058492383, 165694933);
            uint b1 = (1909506562);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x4 a2 = uint3x4(1204097259, 281328069, 24629507, 1386458568, 1325149699, 1498707004, 1650355158, 1213017950, 1650457461, 759932777, 1542997846, 1227393490);
            uint b2 = (922212691);
            bool3x4 r2 = bool3x4(false, true, true, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x4 a3 = uint3x4(1520634374, 1951142425, 1956860037, 681224518, 1889763470, 1915403219, 850845857, 1871934613, 1882514458, 1326783898, 1044736383, 24899250);
            uint b3 = (1750827258);
            bool3x4 r3 = bool3x4(true, false, false, true, false, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_scalar_wide()
        {
            uint a0 = (186400299);
            uint3x4 b0 = uint3x4(1881344229, 813834467, 1254886626, 1353590345, 1412343685, 1555571443, 1540508298, 1735458634, 135888070, 1643818742, 248291654, 1739560105);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (728539891);
            uint3x4 b1 = uint3x4(480507742, 1696553040, 540223931, 1840493353, 146833656, 798115946, 2002002066, 1011261705, 783550942, 1093071215, 598253401, 1432416562);
            bool3x4 r1 = bool3x4(false, true, false, true, false, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1863582169);
            uint3x4 b2 = uint3x4(103622950, 775175960, 116908309, 1213433625, 1428954824, 1760442490, 1208143947, 751820805, 1491872302, 560004484, 2065157473, 310839658);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (697329242);
            uint3x4 b3 = uint3x4(898786601, 1448893980, 1204091943, 1933043135, 828031833, 1737703663, 1672512847, 1112905025, 1666248737, 1352503217, 406395888, 1734008932);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_wide_wide()
        {
            uint3x4 a0 = uint3x4(2087717754, 1725569452, 1298066182, 1693943616, 1319019629, 70674491, 1042499725, 1002821508, 1021857133, 1744374599, 821751047, 467646903);
            uint3x4 b0 = uint3x4(85148514, 293632137, 1151128249, 409440398, 1115020183, 1508500597, 1834583302, 1755218534, 1788761753, 1128238489, 834223713, 1578743290);
            bool3x4 r0 = bool3x4(true, true, true, true, true, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x4 a1 = uint3x4(2029731638, 1377214212, 1207816926, 474621063, 20781266, 366593779, 2068457387, 10181449, 793634464, 144474612, 99947390, 930377263);
            uint3x4 b1 = uint3x4(1647150256, 1756397855, 1131080201, 1208965204, 1495161099, 1283714281, 908051907, 412849651, 815822687, 730271942, 40756039, 883326140);
            bool3x4 r1 = bool3x4(true, false, true, false, false, false, true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x4 a2 = uint3x4(683686232, 742803073, 918292048, 875621429, 1764985258, 411384146, 1921397684, 1349107119, 640399120, 1487719331, 1467989523, 1834244794);
            uint3x4 b2 = uint3x4(476260632, 1024136446, 1440596667, 1253494041, 146826162, 1798399573, 2085029408, 187939428, 1009192934, 1694822273, 1866590874, 113805226);
            bool3x4 r2 = bool3x4(true, false, false, false, true, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x4 a3 = uint3x4(1778580304, 334604025, 689749101, 1478795900, 716772993, 1072711623, 388277128, 290673156, 619539670, 1666212670, 496667761, 638935614);
            uint3x4 b3 = uint3x4(1331524948, 5928360, 1884858608, 1988975599, 493888072, 731556294, 1597968264, 727668246, 1260583385, 1921631225, 359265523, 856088703);
            bool3x4 r3 = bool3x4(true, true, false, false, true, true, false, false, false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1208626274, 239697208, 1979453345, 1253474001, 1590192876, 1487911635, 1673945595, 1662650098, 222749855, 1433540517, 566635217, 1773305960);
            uint b0 = (1715176566);
            bool3x4 r0 = bool3x4(false, false, true, false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x4 a1 = uint3x4(1850273578, 325913453, 333381537, 1905567362, 2053577491, 570397194, 2128431130, 1735325311, 529971908, 1663525234, 1972984241, 1587865063);
            uint b1 = (206147145);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x4 a2 = uint3x4(488268523, 812076921, 181082921, 1281638484, 1818357732, 116518997, 1397728785, 1924199337, 742950077, 1463993051, 1598027926, 842851852);
            uint b2 = (121921923);
            bool3x4 r2 = bool3x4(true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x4 a3 = uint3x4(160842093, 540338405, 174088887, 1609299242, 425486336, 1462766889, 651513452, 1122649822, 771802057, 839323192, 325778683, 406189885);
            uint b3 = (1226313895);
            bool3x4 r3 = bool3x4(false, false, false, true, false, true, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_scalar_wide()
        {
            uint a0 = (480938827);
            uint3x4 b0 = uint3x4(1824731899, 921496110, 586859044, 946430596, 1231356727, 1390167458, 1785807092, 28949024, 2037899283, 595656760, 1778095771, 1233500439);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1696302238);
            uint3x4 b1 = uint3x4(1445965340, 484020151, 1586962841, 1361740714, 265628948, 2003122957, 332267433, 1128353075, 377919478, 982113135, 1117675960, 630865591);
            bool3x4 r1 = bool3x4(true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1550679736);
            uint3x4 b2 = uint3x4(895945757, 287025687, 643452096, 660504007, 613135893, 633307118, 514276792, 1377364317, 84491736, 746768197, 1282879723, 589415384);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (363082240);
            uint3x4 b3 = uint3x4(1774333756, 741005890, 413100725, 702141547, 1434366582, 1489794027, 1710601432, 1914069735, 1811684885, 1007116016, 1883396218, 318035497);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(154092149, 1515170149, 1083970332, 785807178, 1401094881, 310537627, 868328962, 1990816725, 2035349541, 457043352, 1123282035, 1001842946);
            uint3x4 b0 = uint3x4(77984380, 1712054191, 1566203809, 254834519, 450519938, 389457083, 1298669505, 207343167, 1214449047, 2059561026, 896534357, 1897470050);
            bool3x4 r0 = bool3x4(false, true, true, false, false, true, true, false, false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x4 a1 = uint3x4(1387761992, 195272789, 659549000, 888761458, 283706617, 1790185840, 899029812, 848317418, 1743712447, 1504407474, 1798441490, 1902791952);
            uint3x4 b1 = uint3x4(521075677, 1848221945, 374708019, 1573731118, 2093466449, 1660210829, 1568778785, 1352157589, 1212771905, 1457525058, 1493446008, 1784768208);
            bool3x4 r1 = bool3x4(false, true, false, true, true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x4 a2 = uint3x4(606340844, 1994437705, 301831413, 654230470, 1223625081, 324292199, 1370931020, 1742769166, 1709242127, 105750466, 1655967312, 1455797002);
            uint3x4 b2 = uint3x4(1993422493, 1378671664, 1447376929, 1405041439, 1765183746, 562894655, 1085068880, 1026386862, 884290156, 922346160, 330605896, 466570756);
            bool3x4 r2 = bool3x4(true, false, true, true, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x4 a3 = uint3x4(366131629, 315848579, 1539610530, 99028560, 765767372, 1241881101, 527753961, 1271899705, 1439235979, 436585748, 1244486586, 2128710216);
            uint3x4 b3 = uint3x4(1252369410, 2057993777, 1691801535, 2041799631, 557988228, 813610154, 1657573441, 983813335, 385144401, 1281329713, 285422763, 658643567);
            bool3x4 r3 = bool3x4(true, true, true, true, false, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1479531977, 1427983411, 415250630, 1245345407, 1112546666, 1072990632, 1579912858, 101048307, 1070894375, 509818792, 1910488590, 85452501);
            uint b0 = (2004563877);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x4 a1 = uint3x4(518127023, 1097326500, 1964410699, 1968139888, 1191853379, 662096238, 1140643434, 754434551, 155343473, 995927387, 974873240, 1773400038);
            uint b1 = (1246249980);
            bool3x4 r1 = bool3x4(true, true, false, false, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x4 a2 = uint3x4(497436329, 527516420, 1477043363, 1378470734, 96190147, 37188105, 839762283, 781102710, 766321672, 1145011483, 139031840, 127837780);
            uint b2 = (1825940497);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x4 a3 = uint3x4(817806943, 649140851, 913173654, 1530989756, 856611228, 479496140, 287809619, 626008542, 2075114788, 269756518, 1123999963, 1061241170);
            uint b3 = (1248492707);
            bool3x4 r3 = bool3x4(true, true, true, false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_less_equal_scalar_wide()
        {
            uint a0 = (1899193992);
            uint3x4 b0 = uint3x4(915011820, 980913757, 1337699683, 1476321359, 1102143668, 660493983, 184664508, 381579707, 1954892821, 1295090571, 1440368586, 1696003686);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (88708652);
            uint3x4 b1 = uint3x4(1332251857, 1310713644, 2112132784, 48951945, 1888568027, 39340955, 1108242207, 260777425, 593122164, 291471959, 253457314, 1264570386);
            bool3x4 r1 = bool3x4(true, true, true, false, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (699618012);
            uint3x4 b2 = uint3x4(927735863, 2063158939, 932253787, 1168754049, 749328788, 1882694892, 168499987, 378173027, 339963627, 832906712, 559482768, 53067420);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1895722478);
            uint3x4 b3 = uint3x4(809981860, 591790551, 1680760399, 653274934, 1664284538, 1283249545, 767500110, 1334099884, 1271622829, 1270706578, 56782179, 505839576);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(8538378, 2131749726, 265427108, 523609761, 994991818, 839709564, 101288202, 1886280970, 2032074826, 631221455, 1456286159, 961342752);
            uint3x4 b0 = uint3x4(903145828, 1697992986, 1432491982, 169789504, 1059357300, 1744255222, 1606584463, 1905414425, 1448794969, 136181998, 1678754836, 2069656857);
            bool3x4 r0 = bool3x4(false, true, false, true, false, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x4 a1 = uint3x4(424526026, 788481984, 1662488497, 870326690, 708712581, 1260182701, 1165630721, 138247561, 1108650168, 1933222913, 672493999, 1541402159);
            uint3x4 b1 = uint3x4(398982689, 243317404, 740939613, 1894753119, 301760792, 1260647988, 3608523, 52576030, 903420465, 1648820371, 627296845, 1679808907);
            bool3x4 r1 = bool3x4(true, true, true, false, true, false, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x4 a2 = uint3x4(1921596027, 1557351956, 147242547, 892772168, 2089286723, 1273466960, 644009998, 654784654, 189030610, 1035542641, 346401762, 739783704);
            uint3x4 b2 = uint3x4(1719102039, 1718081638, 655586949, 477267189, 62092869, 2013928066, 280292357, 254052205, 1092440092, 1947011057, 625632982, 2028466303);
            bool3x4 r2 = bool3x4(true, false, false, true, true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x4 a3 = uint3x4(1310547408, 1175015477, 1893015570, 1397162858, 1005064177, 469205024, 1331071304, 1747510572, 1556472271, 1318844912, 877625210, 1556049679);
            uint3x4 b3 = uint3x4(578645425, 552865694, 1460006028, 1944712828, 1256156724, 2090870105, 1299728699, 53125632, 782915512, 1103537852, 271803142, 828357811);
            bool3x4 r3 = bool3x4(true, true, true, false, false, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(2049236663, 182691143, 634973382, 1197012109, 439837565, 1367606469, 1108037359, 351147187, 1898505669, 411667685, 1998610091, 4652390);
            uint b0 = (1061998015);
            bool3x4 r0 = bool3x4(true, false, false, true, false, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x4 a1 = uint3x4(996159180, 727766399, 96217144, 814085575, 1525995206, 1293933760, 1732973229, 1473283041, 899444524, 1023753195, 1373738074, 518164359);
            uint b1 = (2111455181);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x4 a2 = uint3x4(717850464, 1826820341, 527594558, 1816542874, 839185150, 1143596061, 1819554651, 160724539, 993212636, 878086499, 363122662, 1989978759);
            uint b2 = (1765188600);
            bool3x4 r2 = bool3x4(false, true, false, true, false, false, true, false, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x4 a3 = uint3x4(2145562949, 122055824, 1432184946, 690328424, 638547285, 403700518, 569358695, 1988815901, 933324785, 1709851817, 1451640349, 1782506169);
            uint b3 = (491416140);
            bool3x4 r3 = bool3x4(true, false, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1859811087);
            uint3x4 b0 = uint3x4(1070365918, 1783869452, 830091760, 377157428, 327199016, 90384229, 1154649706, 376758501, 1079802834, 2054742898, 1328349472, 434061447);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (951207723);
            uint3x4 b1 = uint3x4(598695892, 975131651, 1714007943, 177416473, 1267232721, 31082860, 216791741, 119054289, 1905107583, 89559116, 55041824, 691334141);
            bool3x4 r1 = bool3x4(true, false, false, true, false, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (462326883);
            uint3x4 b2 = uint3x4(1658303669, 914628512, 1134364322, 1677134711, 1955614770, 2067009301, 1454405405, 299467282, 1584922149, 561776357, 564147844, 398216936);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (1478439642);
            uint3x4 b3 = uint3x4(958973988, 725612832, 1586062302, 1992817431, 732550238, 1151725147, 11183347, 643483664, 1846311608, 999376922, 1029876878, 1092702918);
            bool3x4 r3 = bool3x4(true, true, false, false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_add_wide_wide()
        {
            uint3x4 a0 = uint3x4(2135171378, 21433296, 1954723494, 683604307, 1054212315, 1762680995, 1963655852, 1257853062, 2043493600, 976898058, 1915056423, 121374462);
            uint3x4 b0 = uint3x4(1013431952, 366718162, 359290756, 1393163294, 1962236872, 1263270041, 1862666629, 1077447887, 821693806, 487316539, 350922520, 1583012528);
            uint3x4 r0 = uint3x4(3148603330, 388151458, 2314014250, 2076767601, 3016449187, 3025951036, 3826322481, 2335300949, 2865187406, 1464214597, 2265978943, 1704386990);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x4 a1 = uint3x4(1218855698, 700538222, 1702057277, 1788251699, 1534939160, 398651016, 1674272498, 374510467, 824322986, 1217622199, 1122376670, 642613771);
            uint3x4 b1 = uint3x4(1951595076, 1024851344, 874302782, 1383969588, 1767968088, 900721406, 1659790033, 1792273749, 443844328, 633981449, 2010244807, 335566991);
            uint3x4 r1 = uint3x4(3170450774, 1725389566, 2576360059, 3172221287, 3302907248, 1299372422, 3334062531, 2166784216, 1268167314, 1851603648, 3132621477, 978180762);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x4 a2 = uint3x4(1097903998, 359042741, 929182687, 1713065399, 892057490, 1295346111, 1806236181, 1838589664, 173985173, 1875814528, 1464015613, 1550659036);
            uint3x4 b2 = uint3x4(521931102, 544297835, 1681549647, 1784248858, 585904415, 3128418, 1806236610, 179909533, 378711407, 195687764, 357131656, 383703567);
            uint3x4 r2 = uint3x4(1619835100, 903340576, 2610732334, 3497314257, 1477961905, 1298474529, 3612472791, 2018499197, 552696580, 2071502292, 1821147269, 1934362603);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x4 a3 = uint3x4(447183339, 1810477200, 1280783968, 460635858, 1308981305, 2074430993, 515260041, 454786901, 54902689, 8663916, 364443922, 2133521215);
            uint3x4 b3 = uint3x4(1332107956, 1471212095, 1634876660, 1356094538, 364971231, 1180126175, 1243953864, 2000873160, 761885805, 1088368083, 371382049, 1165570023);
            uint3x4 r3 = uint3x4(1779291295, 3281689295, 2915660628, 1816730396, 1673952536, 3254557168, 1759213905, 2455660061, 816788494, 1097031999, 735825971, 3299091238);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_add_wide_scalar()
        {
            uint3x4 a0 = uint3x4(665815972, 1783729250, 1591678394, 1284528538, 977850224, 71069732, 1138577680, 1200356017, 565982008, 1246759684, 1088001167, 57252642);
            uint b0 = (1334043849);
            uint3x4 r0 = uint3x4(1999859821, 3117773099, 2925722243, 2618572387, 2311894073, 1405113581, 2472621529, 2534399866, 1900025857, 2580803533, 2422045016, 1391296491);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x4 a1 = uint3x4(678921480, 512157429, 1470648741, 1490096953, 1467033531, 182608093, 1707296407, 1703724354, 1333833947, 653973063, 1139546735, 1834005844);
            uint b1 = (625943813);
            uint3x4 r1 = uint3x4(1304865293, 1138101242, 2096592554, 2116040766, 2092977344, 808551906, 2333240220, 2329668167, 1959777760, 1279916876, 1765490548, 2459949657);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x4 a2 = uint3x4(184572739, 1858520040, 97099208, 421437295, 1251829854, 166844260, 1568146789, 82548613, 533562157, 1464065228, 716600557, 831997894);
            uint b2 = (1980578280);
            uint3x4 r2 = uint3x4(2165151019, 3839098320, 2077677488, 2402015575, 3232408134, 2147422540, 3548725069, 2063126893, 2514140437, 3444643508, 2697178837, 2812576174);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x4 a3 = uint3x4(861575416, 1590793088, 240051362, 656307111, 1116911778, 1508531454, 1488841996, 651080626, 850104335, 697550029, 1501177275, 308656842);
            uint b3 = (1614335536);
            uint3x4 r3 = uint3x4(2475910952, 3205128624, 1854386898, 2270642647, 2731247314, 3122866990, 3103177532, 2265416162, 2464439871, 2311885565, 3115512811, 1922992378);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_add_scalar_wide()
        {
            uint a0 = (359966320);
            uint3x4 b0 = uint3x4(2146146202, 767103309, 851002415, 311531406, 1491262941, 1016891373, 1954228994, 1671335850, 727870747, 551151834, 1390261152, 1699060326);
            uint3x4 r0 = uint3x4(2506112522, 1127069629, 1210968735, 671497726, 1851229261, 1376857693, 2314195314, 2031302170, 1087837067, 911118154, 1750227472, 2059026646);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (115021619);
            uint3x4 b1 = uint3x4(1964440175, 440700758, 1556692550, 185414255, 933106731, 1217866784, 729761881, 1742597318, 1090109152, 1467373815, 1066072609, 138237856);
            uint3x4 r1 = uint3x4(2079461794, 555722377, 1671714169, 300435874, 1048128350, 1332888403, 844783500, 1857618937, 1205130771, 1582395434, 1181094228, 253259475);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (634834665);
            uint3x4 b2 = uint3x4(993603553, 347587889, 2050191349, 670698672, 1658205080, 1874808705, 2082982954, 869839589, 118460267, 2126166073, 1826004041, 1976984739);
            uint3x4 r2 = uint3x4(1628438218, 982422554, 2685026014, 1305533337, 2293039745, 2509643370, 2717817619, 1504674254, 753294932, 2761000738, 2460838706, 2611819404);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (1612682951);
            uint3x4 b3 = uint3x4(1509218893, 283188530, 175981795, 290469072, 90401332, 92990995, 1697612984, 10695923, 584353656, 1985077669, 261483046, 1433592717);
            uint3x4 r3 = uint3x4(3121901844, 1895871481, 1788664746, 1903152023, 1703084283, 1705673946, 3310295935, 1623378874, 2197036607, 3597760620, 1874165997, 3046275668);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_sub_wide_wide()
        {
            uint3x4 a0 = uint3x4(1410318491, 1097280168, 1827039044, 28881338, 328720965, 875487868, 212936325, 231977215, 1740021315, 2011295463, 48079003, 591379285);
            uint3x4 b0 = uint3x4(1315897366, 799052018, 1580289673, 1094686261, 1954325726, 1197734816, 229886366, 915679176, 1746884850, 918743925, 1007797419, 257421324);
            uint3x4 r0 = uint3x4(94421125, 298228150, 246749371, 3229162373, 2669362535, 3972720348, 4278017255, 3611265335, 4288103761, 1092551538, 3335248880, 333957961);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x4 a1 = uint3x4(1125909359, 1842588095, 848561896, 614448464, 2067598029, 1618238416, 318516219, 1090119767, 1991095823, 949592162, 1951912339, 1457818751);
            uint3x4 b1 = uint3x4(287249342, 1617287463, 1653916102, 123586847, 502107404, 672875302, 1256481116, 1975569142, 1794443030, 1327558915, 330955394, 1596041731);
            uint3x4 r1 = uint3x4(838660017, 225300632, 3489613090, 490861617, 1565490625, 945363114, 3357002399, 3409517921, 196652793, 3917000543, 1620956945, 4156744316);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x4 a2 = uint3x4(1642553126, 2114366549, 1420516260, 596841760, 724518081, 1820626306, 1885185225, 246124365, 1339877262, 1277620434, 759131597, 597162957);
            uint3x4 b2 = uint3x4(1069074732, 1120817099, 2076417364, 402521072, 839858844, 1539789702, 559077522, 822288510, 751901021, 1858312568, 1706585560, 483540199);
            uint3x4 r2 = uint3x4(573478394, 993549450, 3639066192, 194320688, 4179626533, 280836604, 1326107703, 3718803151, 587976241, 3714275162, 3347513333, 113622758);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x4 a3 = uint3x4(656765083, 1075131749, 58205257, 452992632, 976914238, 2122217984, 1687033200, 850554234, 2052749291, 2095840868, 1583338457, 90383917);
            uint3x4 b3 = uint3x4(35726321, 401119620, 1411304017, 794953965, 246546364, 1926970811, 1641115012, 2138664312, 1215717344, 1626141022, 1697813712, 1432018301);
            uint3x4 r3 = uint3x4(621038762, 674012129, 2941868536, 3953005963, 730367874, 195247173, 45918188, 3006857218, 837031947, 469699846, 4180492041, 2953332912);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_sub_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1508669340, 1594795463, 266707545, 643102647, 287705008, 1475644328, 1113286221, 979450511, 2082174113, 1108005498, 304369206, 999244508);
            uint b0 = (998008471);
            uint3x4 r0 = uint3x4(510660869, 596786992, 3563666370, 3940061472, 3584663833, 477635857, 115277750, 4276409336, 1084165642, 109997027, 3601328031, 1236037);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x4 a1 = uint3x4(1806482044, 2101812429, 1482736902, 266654115, 1470212363, 1190349300, 958542155, 1185075537, 1738124835, 499527536, 1612473406, 1696960099);
            uint b1 = (1994553647);
            uint3x4 r1 = uint3x4(4106895693, 107258782, 3783150551, 2567067764, 3770626012, 3490762949, 3258955804, 3485489186, 4038538484, 2799941185, 3912887055, 3997373748);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x4 a2 = uint3x4(1287292743, 1032360376, 1779621585, 964948785, 1739264125, 94254551, 968533883, 2075770560, 946189008, 1074604044, 1171596880, 1033389665);
            uint b2 = (1360229454);
            uint3x4 r2 = uint3x4(4222030585, 3967098218, 419392131, 3899686627, 379034671, 3028992393, 3903271725, 715541106, 3880926850, 4009341886, 4106334722, 3968127507);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x4 a3 = uint3x4(1905912138, 372717946, 658343960, 572101777, 361378660, 1043302867, 1535109165, 695707807, 153321516, 1464557635, 308141270, 69622833);
            uint b3 = (1219683758);
            uint3x4 r3 = uint3x4(686228380, 3448001484, 3733627498, 3647385315, 3436662198, 4118586405, 315425407, 3770991345, 3228605054, 244873877, 3383424808, 3144906371);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_sub_scalar_wide()
        {
            uint a0 = (893369501);
            uint3x4 b0 = uint3x4(2051906184, 1699714311, 442603706, 1735141684, 274533585, 811580259, 1196354320, 1524097023, 533621527, 2080845793, 143958837, 1620668660);
            uint3x4 r0 = uint3x4(3136430613, 3488622486, 450765795, 3453195113, 618835916, 81789242, 3991982477, 3664239774, 359747974, 3107491004, 749410664, 3567668137);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1135989346);
            uint3x4 b1 = uint3x4(1367044745, 554088609, 552670373, 1265516124, 1254902543, 1857695581, 1619865274, 1313559400, 99812999, 843597298, 420111239, 1299949060);
            uint3x4 r1 = uint3x4(4063911897, 581900737, 583318973, 4165440518, 4176054099, 3573261061, 3811091368, 4117397242, 1036176347, 292392048, 715878107, 4131007582);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (531009038);
            uint3x4 b2 = uint3x4(1103306550, 104920105, 1137308312, 1207332725, 103438360, 1157123503, 1174401240, 701247193, 1498366995, 467017290, 109208355, 1594646461);
            uint3x4 r2 = uint3x4(3722669784, 426088933, 3688668022, 3618643609, 427570678, 3668852831, 3651575094, 4124729141, 3327609339, 63991748, 421800683, 3231329873);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1252691221);
            uint3x4 b3 = uint3x4(919863765, 2826939, 1969148647, 1576198850, 2075870798, 1610641273, 1783880129, 59074246, 1766624573, 521313783, 1333637752, 509364704);
            uint3x4 r3 = uint3x4(332827456, 1249864282, 3578509870, 3971459667, 3471787719, 3937017244, 3763778388, 1193616975, 3781033944, 731377438, 4214020765, 743326517);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mul_wide_wide()
        {
            uint3x4 a0 = uint3x4(61417577, 219585476, 1362520891, 1511084277, 1481211272, 58211871, 1459591173, 567624644, 1169935583, 1835691886, 385626539, 85934842);
            uint3x4 b0 = uint3x4(578042444, 1620527213, 200516468, 309339115, 542853019, 299467282, 1479641221, 1428338601, 1497302909, 1596889147, 427413842, 265122693);
            uint3x4 r0 = uint3x4(2868103468, 1326150260, 3304073148, 2972110823, 1973926232, 88546350, 3431047833, 3712145508, 556671459, 1098186330, 1848083398, 4236646882);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x4 a1 = uint3x4(522856538, 278370196, 289217012, 2083410174, 1293162798, 1939730122, 2075923048, 1116477212, 1686101741, 783310758, 248585944, 1093377716);
            uint3x4 b1 = uint3x4(689376654, 1120457204, 516903000, 873091659, 1353196495, 1384773500, 1596528529, 2122329305, 1033200564, 996795088, 1137754930, 232014195);
            uint3x4 r1 = uint3x4(2005201900, 651971856, 2573806560, 4184807018, 4175537714, 3758002136, 2245379304, 3535300284, 1443849636, 550781664, 3335949872, 3941859036);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x4 a2 = uint3x4(797038788, 1838048120, 1892922904, 1952024781, 492107602, 1097670675, 2069629919, 20122103, 606926492, 1153788131, 1687394746, 1499899200);
            uint3x4 b2 = uint3x4(1080950243, 1613216909, 463529448, 1781487382, 2101946430, 673144237, 390627073, 964308272, 1332603859, 106394678, 1330334791, 1720890701);
            uint3x4 r2 = uint3x4(3201362380, 264300824, 4173364672, 1825729694, 4053448156, 3048379351, 2230824159, 4043852112, 1004304020, 3964664802, 638638742, 892728384);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x4 a3 = uint3x4(380825697, 2058271053, 1791586731, 16536749, 1743482585, 323418416, 826338527, 1127652402, 1548655361, 892665898, 498857854, 52699386);
            uint3x4 b3 = uint3x4(1860846228, 1499909622, 1236623401, 1532585255, 46356001, 1355750416, 470193265, 829633350, 158242740, 2121460265, 443332975, 1295474668);
            uint3x4 r3 = uint3x4(2820012564, 1744222462, 3318371427, 2734565211, 2648780793, 1971376896, 936606319, 4269976492, 3894449076, 3059182266, 4018298274, 2504076408);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mul_wide_scalar()
        {
            uint3x4 a0 = uint3x4(871746615, 492532311, 570557670, 2142306629, 1610315153, 1526163563, 118471734, 257439514, 364291059, 1186560810, 1584938026, 1357601203);
            uint b0 = (442064533);
            uint3x4 r0 = uint3x4(338365955, 1081376419, 2565819870, 3279557417, 3421481829, 4119466055, 3456786286, 513646114, 1627104879, 1523063666, 1353478258, 3777359663);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x4 a1 = uint3x4(638897141, 1007838321, 1163240135, 1619806399, 1444659979, 1127580168, 464517916, 1508043166, 745488654, 636691139, 1851670006, 357357967);
            uint b1 = (268562104);
            uint3x4 r1 = uint3x4(3498401304, 3138010936, 2242445576, 154458952, 643000808, 258008512, 1024230432, 1508298128, 2139080208, 2748663336, 2404203728, 2332971208);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x4 a2 = uint3x4(1095280227, 945802744, 1464398841, 51061000, 802418971, 407442471, 638315697, 1889264235, 584402164, 1343048690, 2144106255, 1634890111);
            uint b2 = (702779195);
            uint3x4 r2 = uint3x4(91792849, 3708420136, 350441827, 2098992344, 2272765497, 2293132797, 2817092555, 4014470057, 1627861052, 4195528390, 2750271861, 1566775621);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x4 a3 = uint3x4(425282134, 676185747, 1562817045, 379402138, 866868743, 624571724, 889442510, 39498317, 219559094, 211033504, 2076045580, 1838674974);
            uint b3 = (997231492);
            uint3x4 r3 = uint3x4(3842442840, 3292280012, 3402971604, 3617671528, 1887062172, 2721300272, 1014465592, 910409396, 3484549080, 3195348608, 689032752, 3137743224);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mul_scalar_wide()
        {
            uint a0 = (1152242766);
            uint3x4 b0 = uint3x4(1276636134, 2105929407, 499007702, 124002565, 1956335172, 1288034953, 832676555, 337389733, 99268757, 2005055247, 2011389505, 1348110859);
            uint3x4 r0 = uint3x4(2165463060, 999811634, 1179056436, 3493540742, 404105400, 1339492798, 3913201114, 3183347270, 2131796326, 1519334034, 3342961614, 2874551130);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (399689191);
            uint3x4 b1 = uint3x4(2007606374, 2076691289, 1825721194, 769885235, 153314735, 1066325369, 84289667, 984486192, 1325213504, 1643957457, 1576395620, 2095980601);
            uint3x4 r1 = uint3x4(2336347658, 1053162063, 1757322918, 2212333829, 2663279593, 1080737071, 1177640245, 1336635984, 136489664, 3207308695, 2229543740, 2272063599);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (907671947);
            uint3x4 b2 = uint3x4(836919582, 1412159342, 2037926630, 366590562, 493177763, 2058824164, 497936968, 2136548816, 1211907591, 2113626509, 345443734, 353147704);
            uint3x4 r2 = uint3x4(374270282, 2518021818, 3382730978, 2199094582, 1098685569, 4168516300, 1465269528, 1820252144, 1505328333, 774184079, 299976306, 2840182632);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (688487056);
            uint3x4 b3 = uint3x4(2038986981, 1991273614, 393095943, 838257274, 1646548338, 480051387, 1077685034, 421911953, 1757438926, 1584698689, 1237695787, 426426495);
            uint3x4 r3 = uint3x4(1399726800, 1710668768, 1354271216, 1603930272, 3358221344, 3829172016, 216288160, 872201104, 470175712, 1493036688, 1155786288, 1195363696);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_div_wide_wide()
        {
            uint3x4 a0 = uint3x4(333171510, 858154903, 1181365836, 671357749, 1090606752, 803759420, 788404166, 296807814, 575260195, 166625280, 1493729000, 1831739736);
            uint3x4 b0 = uint3x4(698897823, 440199998, 655557473, 1658534285, 2127220100, 315653188, 1814290360, 992173243, 914851653, 664340325, 224323977, 246981573);
            uint3x4 r0 = uint3x4(0, 1, 1, 0, 0, 2, 0, 0, 0, 0, 6, 7);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x4 a1 = uint3x4(200852358, 129983172, 500176108, 472051781, 414699094, 1446535974, 1278480457, 930910505, 263295881, 1626759436, 450830871, 21439121);
            uint3x4 b1 = uint3x4(285573983, 819471609, 2012476015, 1783179572, 223253978, 169515029, 1694929006, 1992168131, 1155972447, 1768506696, 422325410, 1508417406);
            uint3x4 r1 = uint3x4(0, 0, 0, 0, 1, 8, 0, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x4 a2 = uint3x4(521337599, 127756712, 200601965, 412554396, 1014641734, 239347640, 525574301, 1158358177, 1655168319, 2048437741, 367754386, 1861176433);
            uint3x4 b2 = uint3x4(605462475, 66917170, 2014683461, 108847533, 611173330, 895791853, 1999369787, 1225614384, 1168063495, 565150188, 127292785, 1027814836);
            uint3x4 r2 = uint3x4(0, 1, 0, 3, 1, 0, 0, 0, 1, 3, 2, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x4 a3 = uint3x4(2131424795, 401044444, 745048188, 1943634349, 264134862, 298134010, 1884719303, 1582577607, 1958183229, 1302356942, 1455581366, 1466593830);
            uint3x4 b3 = uint3x4(321940796, 337756553, 63233040, 1926010595, 769049413, 2042197280, 405134611, 547499280, 1337688441, 667307127, 35118652, 411409741);
            uint3x4 r3 = uint3x4(6, 1, 11, 1, 0, 0, 4, 2, 1, 1, 41, 3);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_div_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1433072926, 1073958635, 1195142312, 536596719, 1274375693, 464756346, 806462546, 906504670, 1380905136, 25493909, 1196815948, 123300377);
            uint b0 = (1434025872);
            uint3x4 r0 = uint3x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x4 a1 = uint3x4(643754735, 2047825037, 458304263, 741331531, 466443901, 2110004616, 1500687214, 1453264263, 1617154145, 2040203220, 2103351724, 485536709);
            uint b1 = (2084019932);
            uint3x4 r1 = uint3x4(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x4 a2 = uint3x4(402141749, 1629069474, 1549487015, 670594363, 2040479674, 155415284, 207130003, 1596922206, 1730223836, 1528374182, 1878500631, 1245757182);
            uint b2 = (1477264254);
            uint3x4 r2 = uint3x4(0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x4 a3 = uint3x4(1471308702, 251821475, 1328085649, 1950145317, 794269329, 174603836, 678361822, 1820872200, 1455358409, 778273070, 2067965131, 127176068);
            uint b3 = (1733304186);
            uint3x4 r3 = uint3x4(0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_div_scalar_wide()
        {
            uint a0 = (519165704);
            uint3x4 b0 = uint3x4(1295178177, 775214121, 467772046, 1156881598, 310396565, 759759959, 243837702, 1616314235, 1053470225, 1320630160, 378773841, 4223608);
            uint3x4 r0 = uint3x4(0, 0, 1, 0, 1, 0, 2, 0, 0, 0, 1, 122);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1971105754);
            uint3x4 b1 = uint3x4(2054406020, 219939614, 1603672651, 2006134295, 888535397, 1493077923, 615835131, 1045603945, 452709946, 1074919059, 467037221, 1485241506);
            uint3x4 r1 = uint3x4(0, 8, 1, 0, 2, 1, 3, 1, 4, 1, 4, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1775728786);
            uint3x4 b2 = uint3x4(481521341, 68149923, 80867357, 1294049272, 470535313, 1235850199, 631464286, 687722755, 412827650, 1258012095, 1286792622, 1799223034);
            uint3x4 r2 = uint3x4(3, 26, 21, 1, 3, 1, 2, 2, 4, 1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (766890491);
            uint3x4 b3 = uint3x4(2080374598, 711612151, 700420132, 1832408481, 1806438353, 237636410, 562498090, 1695805237, 2075783388, 2094216740, 1612536340, 885282904);
            uint3x4 r3 = uint3x4(0, 1, 1, 0, 0, 3, 1, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mod_wide_wide()
        {
            uint3x4 a0 = uint3x4(258342924, 1454754891, 723352342, 1981431473, 531756042, 716993627, 1667903349, 1331097004, 1776856101, 17598216, 1474345080, 1681376293);
            uint3x4 b0 = uint3x4(1990080167, 1197348066, 651970512, 1659454050, 241005212, 1866255454, 1440101415, 595220963, 408818410, 198222574, 549504274, 239973807);
            uint3x4 r0 = uint3x4(258342924, 257406825, 71381830, 321977423, 49745618, 716993627, 227801934, 140655078, 141582461, 17598216, 375336532, 1559644);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x4 a1 = uint3x4(813624265, 1617478722, 498370451, 780075943, 1754430321, 653235398, 1517128354, 966216200, 590067427, 1283434795, 1910903650, 1125967790);
            uint3x4 b1 = uint3x4(321398087, 658171840, 1511495237, 1048325585, 1126739824, 666641241, 38017598, 418797691, 618700513, 1941062990, 158556432, 1081063558);
            uint3x4 r1 = uint3x4(170828091, 301135042, 498370451, 780075943, 627690497, 653235398, 34442032, 128620818, 590067427, 1283434795, 8226466, 44904232);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x4 a2 = uint3x4(1180537254, 308567230, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599, 1608412916, 111825133, 786866017, 1225576256);
            uint3x4 b2 = uint3x4(427329468, 148111230, 1251162672, 1856322297, 1214781084, 401954255, 1323259633, 1167744452, 1816151689, 541163525, 664455763, 1738838503);
            uint3x4 r2 = uint3x4(325878318, 12344770, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599, 1608412916, 111825133, 122410254, 1225576256);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x4 a3 = uint3x4(1590085857, 1755638794, 1413553126, 476553804, 1342913944, 1625118233, 1202928007, 504380191, 642905424, 357937367, 1801777444, 1384305901);
            uint3x4 b3 = uint3x4(1746284172, 855644567, 1887796950, 655067833, 536415164, 71040983, 631964713, 503267649, 944396748, 302347270, 564261945, 1414291441);
            uint3x4 r3 = uint3x4(1590085857, 44349660, 1413553126, 476553804, 270083616, 62216607, 570963294, 1112542, 642905424, 55590097, 108991609, 1384305901);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mod_wide_scalar()
        {
            uint3x4 a0 = uint3x4(560988938, 629524514, 767711194, 434281967, 1399805893, 792916846, 1663690927, 598661916, 1776636144, 1287035793, 1743722161, 475209785);
            uint b0 = (1156862367);
            uint3x4 r0 = uint3x4(560988938, 629524514, 767711194, 434281967, 242943526, 792916846, 506828560, 598661916, 619773777, 130173426, 586859794, 475209785);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x4 a1 = uint3x4(327476870, 379853074, 477430114, 858399046, 712734431, 1506629323, 199829950, 362269020, 1986626876, 1351725413, 1549678101, 431765276);
            uint b1 = (1617696916);
            uint3x4 r1 = uint3x4(327476870, 379853074, 477430114, 858399046, 712734431, 1506629323, 199829950, 362269020, 368929960, 1351725413, 1549678101, 431765276);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x4 a2 = uint3x4(1315833792, 615834034, 780055604, 104179235, 629966219, 1810536428, 1747026206, 1799535061, 875754431, 2049775667, 303673867, 93301056);
            uint b2 = (1664893153);
            uint3x4 r2 = uint3x4(1315833792, 615834034, 780055604, 104179235, 629966219, 145643275, 82133053, 134641908, 875754431, 384882514, 303673867, 93301056);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x4 a3 = uint3x4(1944511005, 1065919801, 1342701312, 1356734788, 1593032231, 475449806, 1983416442, 776300612, 591854273, 2061957684, 1865797266, 1982663429);
            uint b3 = (2135291183);
            uint3x4 r3 = uint3x4(1944511005, 1065919801, 1342701312, 1356734788, 1593032231, 475449806, 1983416442, 776300612, 591854273, 2061957684, 1865797266, 1982663429);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_mod_scalar_wide()
        {
            uint a0 = (933347930);
            uint3x4 b0 = uint3x4(549923387, 243114953, 1884274390, 1428033594, 655531454, 1622674954, 1107563514, 1614111094, 914801920, 1432263179, 564431096, 1967013901);
            uint3x4 r0 = uint3x4(383424543, 204003071, 933347930, 933347930, 277816476, 933347930, 933347930, 933347930, 18546010, 933347930, 368916834, 933347930);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1709750152);
            uint3x4 b1 = uint3x4(1080102613, 13120773, 2042535998, 1505698002, 1640058084, 974167554, 758635306, 1387264978, 611743343, 1139002766, 1913935748, 1086810076);
            uint3x4 r1 = uint3x4(629647539, 4049662, 1709750152, 204052150, 69692068, 735582598, 192479540, 322485174, 486263466, 570747386, 1709750152, 622940076);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (991846486);
            uint3x4 b2 = uint3x4(922870408, 35007468, 891877602, 157349181, 83267982, 801093706, 546272767, 1665089132, 1889242068, 1179889796, 1690033703, 1333252321);
            uint3x4 r2 = uint3x4(68976078, 11637382, 99968884, 47751400, 75898684, 190752780, 445573719, 991846486, 991846486, 991846486, 991846486, 991846486);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1960636489);
            uint3x4 b3 = uint3x4(960755248, 698650125, 313994074, 1830992514, 2049496523, 507742240, 739436968, 1012724736, 2089810815, 329356442, 384427687, 713578570);
            uint3x4 r3 = uint3x4(39125993, 563336239, 76672045, 129643975, 1960636489, 437409769, 481762553, 947911753, 1960636489, 313854279, 38498054, 533479349);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_plus()
        {
            uint3x4 a0 = uint3x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671, 1084131995, 195779102, 2131702223);
            uint3x4 r0 = uint3x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671, 1084131995, 195779102, 2131702223);
            TestUtils.AreEqual(+a0, r0);

            uint3x4 a1 = uint3x4(715660442, 69731564, 1317851903, 1957501908, 531426536, 2012985092, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471);
            uint3x4 r1 = uint3x4(715660442, 69731564, 1317851903, 1957501908, 531426536, 2012985092, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471);
            TestUtils.AreEqual(+a1, r1);

            uint3x4 a2 = uint3x4(1659000230, 1153431944, 1360657696, 578750954, 150348334, 1791553179, 1288641627, 735146513, 328684789, 1370099515, 1575634098, 36481877);
            uint3x4 r2 = uint3x4(1659000230, 1153431944, 1360657696, 578750954, 150348334, 1791553179, 1288641627, 735146513, 328684789, 1370099515, 1575634098, 36481877);
            TestUtils.AreEqual(+a2, r2);

            uint3x4 a3 = uint3x4(1832055170, 1370934466, 1126708142, 511229253, 1297664549, 1444401655, 1292097101, 1377029046, 1680766483, 249526091, 656501406, 195015813);
            uint3x4 r3 = uint3x4(1832055170, 1370934466, 1126708142, 511229253, 1297664549, 1444401655, 1292097101, 1377029046, 1680766483, 249526091, 656501406, 195015813);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_neg()
        {
            uint3x4 a0 = uint3x4(1385088677, 94114564, 1350664872, 1458616659, 2067164853, 218122493, 958484951, 270553961, 446497525, 270503114, 1928771252, 1427605822);
            uint3x4 r0 = uint3x4(2909878619, 4200852732, 2944302424, 2836350637, 2227802443, 4076844803, 3336482345, 4024413335, 3848469771, 4024464182, 2366196044, 2867361474);
            TestUtils.AreEqual(-a0, r0);

            uint3x4 a1 = uint3x4(2051940607, 485368391, 908365416, 1742096480, 990033169, 1368056141, 1350976157, 12802586, 1934372287, 576597401, 785136322, 559205611);
            uint3x4 r1 = uint3x4(2243026689, 3809598905, 3386601880, 2552870816, 3304934127, 2926911155, 2943991139, 4282164710, 2360595009, 3718369895, 3509830974, 3735761685);
            TestUtils.AreEqual(-a1, r1);

            uint3x4 a2 = uint3x4(1959833280, 1200036971, 95281343, 1969004480, 1381288239, 252975075, 1961335692, 1607042487, 832886233, 1300359361, 8438338, 431498011);
            uint3x4 r2 = uint3x4(2335134016, 3094930325, 4199685953, 2325962816, 2913679057, 4041992221, 2333631604, 2687924809, 3462081063, 2994607935, 4286528958, 3863469285);
            TestUtils.AreEqual(-a2, r2);

            uint3x4 a3 = uint3x4(1534415387, 866625695, 2105773520, 1249998702, 1704935592, 59004141, 257619538, 392825753, 1868257049, 1472660509, 928823577, 2138036799);
            uint3x4 r3 = uint3x4(2760551909, 3428341601, 2189193776, 3044968594, 2590031704, 4235963155, 4037347758, 3902141543, 2426710247, 2822306787, 3366143719, 2156930497);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_prefix_inc()
        {
            uint3x4 a0 = uint3x4(780471723, 954741756, 272723451, 2142862245, 606294309, 1514814550, 250124151, 444189162, 1833356994, 1915989169, 1348278302, 129540735);
            uint3x4 r0 = uint3x4(780471724, 954741757, 272723452, 2142862246, 606294310, 1514814551, 250124152, 444189163, 1833356995, 1915989170, 1348278303, 129540736);
            TestUtils.AreEqual(++a0, r0);

            uint3x4 a1 = uint3x4(1584496757, 986715680, 1701179230, 1397451003, 483952900, 1494652811, 1268688387, 2014528731, 453850931, 1112537171, 621362788, 2063486914);
            uint3x4 r1 = uint3x4(1584496758, 986715681, 1701179231, 1397451004, 483952901, 1494652812, 1268688388, 2014528732, 453850932, 1112537172, 621362789, 2063486915);
            TestUtils.AreEqual(++a1, r1);

            uint3x4 a2 = uint3x4(1612870531, 1083861484, 1583359796, 82587894, 810087437, 72436569, 1094485773, 912422931, 1011314676, 261771874, 2042016403, 1102472175);
            uint3x4 r2 = uint3x4(1612870532, 1083861485, 1583359797, 82587895, 810087438, 72436570, 1094485774, 912422932, 1011314677, 261771875, 2042016404, 1102472176);
            TestUtils.AreEqual(++a2, r2);

            uint3x4 a3 = uint3x4(976635804, 607693651, 1788488571, 1912059986, 420746703, 1703260621, 501684292, 1809882373, 1989306461, 786299198, 1729269500, 411043860);
            uint3x4 r3 = uint3x4(976635805, 607693652, 1788488572, 1912059987, 420746704, 1703260622, 501684293, 1809882374, 1989306462, 786299199, 1729269501, 411043861);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_postfix_inc()
        {
            uint3x4 a0 = uint3x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247, 1384002775, 389844650, 1159795446);
            uint3x4 r0 = uint3x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247, 1384002775, 389844650, 1159795446);
            TestUtils.AreEqual(a0++, r0);

            uint3x4 a1 = uint3x4(1343289659, 947635082, 137930180, 451018043, 1634297552, 2009552507, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327);
            uint3x4 r1 = uint3x4(1343289659, 947635082, 137930180, 451018043, 1634297552, 2009552507, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327);
            TestUtils.AreEqual(a1++, r1);

            uint3x4 a2 = uint3x4(446867079, 1460883320, 1683365096, 1319511974, 1418603655, 1938539756, 592683318, 1576213022, 1150548583, 904484472, 253685095, 70826818);
            uint3x4 r2 = uint3x4(446867079, 1460883320, 1683365096, 1319511974, 1418603655, 1938539756, 592683318, 1576213022, 1150548583, 904484472, 253685095, 70826818);
            TestUtils.AreEqual(a2++, r2);

            uint3x4 a3 = uint3x4(1423673637, 257117856, 964412816, 1148726183, 1820437224, 1087435092, 475319856, 1950385959, 1172607661, 1139700625, 1386106060, 612787013);
            uint3x4 r3 = uint3x4(1423673637, 257117856, 964412816, 1148726183, 1820437224, 1087435092, 475319856, 1950385959, 1172607661, 1139700625, 1386106060, 612787013);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_prefix_dec()
        {
            uint3x4 a0 = uint3x4(1331961415, 1612382200, 1401591249, 2042075388, 1757136546, 1895858159, 1467742422, 578341664, 1336115745, 2059077641, 1169239112, 1862369220);
            uint3x4 r0 = uint3x4(1331961414, 1612382199, 1401591248, 2042075387, 1757136545, 1895858158, 1467742421, 578341663, 1336115744, 2059077640, 1169239111, 1862369219);
            TestUtils.AreEqual(--a0, r0);

            uint3x4 a1 = uint3x4(312317355, 1595492535, 1426262619, 1426620468, 674685792, 1423852012, 1459529624, 2092317419, 107501474, 1261583506, 512900840, 1496855314);
            uint3x4 r1 = uint3x4(312317354, 1595492534, 1426262618, 1426620467, 674685791, 1423852011, 1459529623, 2092317418, 107501473, 1261583505, 512900839, 1496855313);
            TestUtils.AreEqual(--a1, r1);

            uint3x4 a2 = uint3x4(777588547, 1487639376, 625907330, 1452782388, 804650978, 2076275981, 120447533, 262357170, 1887136873, 412907314, 846648478, 473291493);
            uint3x4 r2 = uint3x4(777588546, 1487639375, 625907329, 1452782387, 804650977, 2076275980, 120447532, 262357169, 1887136872, 412907313, 846648477, 473291492);
            TestUtils.AreEqual(--a2, r2);

            uint3x4 a3 = uint3x4(286048219, 1237897291, 1412498905, 346348942, 953070054, 2028727932, 2006551142, 1345994403, 1356250542, 1202345509, 497982699, 982734742);
            uint3x4 r3 = uint3x4(286048218, 1237897290, 1412498904, 346348941, 953070053, 2028727931, 2006551141, 1345994402, 1356250541, 1202345508, 497982698, 982734741);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_postfix_dec()
        {
            uint3x4 a0 = uint3x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889, 862428933, 1401191870, 2080259851);
            uint3x4 r0 = uint3x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889, 862428933, 1401191870, 2080259851);
            TestUtils.AreEqual(a0--, r0);

            uint3x4 a1 = uint3x4(653673271, 1928164223, 1760916301, 1174531383, 634036198, 993137684, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745);
            uint3x4 r1 = uint3x4(653673271, 1928164223, 1760916301, 1174531383, 634036198, 993137684, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745);
            TestUtils.AreEqual(a1--, r1);

            uint3x4 a2 = uint3x4(1407678826, 1426931482, 488775250, 1681733117, 1916879863, 2060905976, 636358505, 1379709480, 451326084, 497925052, 549367303, 925145385);
            uint3x4 r2 = uint3x4(1407678826, 1426931482, 488775250, 1681733117, 1916879863, 2060905976, 636358505, 1379709480, 451326084, 497925052, 549367303, 925145385);
            TestUtils.AreEqual(a2--, r2);

            uint3x4 a3 = uint3x4(55306458, 18471540, 1907671409, 2010375112, 459674494, 1339288497, 548526029, 2061115550, 1130246689, 681734791, 1169678318, 640772261);
            uint3x4 r3 = uint3x4(55306458, 18471540, 1907671409, 2010375112, 459674494, 1339288497, 548526029, 2061115550, 1130246689, 681734791, 1169678318, 640772261);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_and_wide_wide()
        {
            uint3x4 a0 = uint3x4(1055241304, 859321394, 1088358961, 2090949513, 300561740, 651904515, 1331035868, 2012752753, 1298126656, 53199569, 1752363533, 1303061302);
            uint3x4 b0 = uint3x4(749698416, 748105424, 1842764797, 9990577, 1989102105, 1666634755, 58116798, 868036607, 1420638875, 1308767169, 564040763, 478617502);
            uint3x4 r0 = uint3x4(749024336, 537928720, 1087769137, 8409473, 277479432, 575816707, 55888540, 867707761, 1141707264, 33686209, 538087433, 209912598);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x4 a1 = uint3x4(1929998247, 1504941434, 470682792, 713577376, 1493231658, 1340884669, 1577921467, 44846626, 1105094388, 1143008413, 333009589, 2116296009);
            uint3x4 b1 = uint3x4(806150474, 674015378, 1505309955, 36064977, 1779639327, 808650076, 1634437037, 1997568501, 1930853951, 1901503461, 1508772523, 2010961769);
            uint3x4 r1 = uint3x4(805855490, 136347666, 403178496, 33571456, 1207967754, 2098204, 1074332585, 33572896, 1091986996, 1073782917, 298320545, 1979979081);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x4 a2 = uint3x4(2067254825, 121795325, 2122365250, 1088796653, 1594120761, 965590824, 337823363, 1686791432, 1275524729, 173403097, 864715776, 1437598787);
            uint3x4 b2 = uint3x4(1495957269, 1914669725, 1263994006, 491200541, 380703892, 282208487, 1416934135, 942735432, 615839538, 1698880188, 1204102677, 1811173266);
            uint3x4 r2 = uint3x4(1495420417, 33686173, 1241513986, 4530189, 369102864, 276834336, 337674883, 536870920, 67434032, 4246168, 58721280, 1102054402);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x4 a3 = uint3x4(1375792249, 203672781, 1568515997, 145607913, 837338112, 754244200, 1383514630, 61183374, 690842674, 1362012962, 668846213, 1659745138);
            uint3x4 b3 = uint3x4(203114715, 1968993229, 1549041488, 421225724, 1641463312, 1122209170, 946391298, 229237652, 849684128, 1197217575, 1910121786, 1835643900);
            uint3x4 r3 = uint3x4(18521, 67125453, 1549018896, 134825192, 566264832, 14714880, 274776066, 27361668, 539304992, 1091306274, 567803904, 1617539952);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_and_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1513158868, 284695609, 734595037, 1566510707, 1601252476, 84213838, 314333543, 430856908, 753481263, 327392481, 1619794917, 2143619546);
            uint b0 = (1173647397);
            uint3x4 r0 = uint3x4(1076916228, 15732769, 29360133, 1163132961, 1164976164, 84148228, 11816997, 27545604, 81801253, 25169953, 1082396709, 1170472960);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x4 a1 = uint3x4(1873208293, 651482651, 1383096952, 1689107088, 1368301071, 366962092, 1729929586, 989550739, 1914435619, 1592791064, 2047510829, 678485991);
            uint b1 = (126982769);
            uint3x4 r1 = uint3x4(125862497, 110137873, 34603632, 75602448, 25205249, 93388832, 118521968, 43063313, 34707489, 110104592, 33589281, 1088097);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x4 a2 = uint3x4(586400261, 309059606, 131945492, 1707451796, 394184188, 1943201012, 558008097, 1070093422, 34324916, 258102213, 1800249857, 922911179);
            uint b2 = (771972179);
            uint3x4 r2 = uint3x4(570638337, 33767442, 100750352, 604046352, 100811856, 570573904, 537003009, 771773506, 33767440, 235032641, 704708609, 637665347);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x4 a3 = uint3x4(1719705954, 1162961184, 851638827, 889902874, 1622363409, 785352441, 1741477119, 452211039, 1144654389, 641588835, 1574197624, 568430284);
            uint b3 = (609219265);
            uint3x4 r3 = uint3x4(604020800, 71393280, 541258241, 604688896, 537083905, 609190593, 609013953, 4468801, 67764737, 604885569, 71585856, 541164224);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (477163326);
            uint3x4 b0 = uint3x4(110453385, 703240362, 2075630560, 1884904031, 1734899436, 947945203, 1664399051, 458879298, 158491426, 79772356, 2054527944, 202228212);
            uint3x4 r0 = uint3x4(68182536, 140544042, 405834528, 273697310, 73426476, 402681394, 3188234, 407953666, 141583138, 71313924, 410028808, 201376052);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (359225061);
            uint3x4 b1 = uint3x4(639811396, 1821945318, 1821303024, 2030124055, 1985961756, 579780373, 2061831301, 1139618293, 1145191868, 1121606282, 1414714065, 688688277);
            uint3x4 r1 = uint3x4(69211716, 67634404, 67649760, 285283333, 340350468, 529925, 274793605, 23662821, 71308452, 4739712, 339759809, 17302661);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1508875606);
            uint3x4 b2 = uint3x4(664318814, 2092766410, 1010043618, 599967779, 47076367, 1325716015, 1119912335, 2083412385, 1805692137, 1689798540, 265665838, 1616867488);
            uint3x4 r2 = uint3x4(25727318, 1487737922, 405014594, 29526018, 13505542, 1225035782, 1086357766, 1479416064, 1235258432, 1084753156, 163945734, 1078923264);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (244288538);
            uint3x4 b3 = uint3x4(688929004, 1157047188, 1381359113, 1562107079, 944933664, 1994959125, 1413414673, 1280114143, 1373827711, 1107998701, 890185579, 195053206);
            uint3x4 r3 = uint3x4(134219784, 75956240, 33917960, 202083330, 134383616, 109611024, 68062224, 202148890, 8552474, 34243592, 68092938, 176161810);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_or_wide_wide()
        {
            uint3x4 a0 = uint3x4(1920951869, 1750772852, 1420019191, 732977093, 1169579447, 229437930, 1966721348, 2039812323, 113550869, 1912038362, 1569990624, 1490718227);
            uint3x4 b0 = uint3x4(214585254, 275414367, 858759675, 190211455, 1218691723, 2129565457, 1862809466, 495728846, 868064152, 1756913766, 933656055, 247722084);
            uint3x4 r0 = uint3x4(2130669503, 2021326207, 2008016383, 737572863, 1303895999, 2146367483, 2134507390, 2107455727, 939376541, 2046780414, 2142664695, 1591475831);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x4 a1 = uint3x4(1686257697, 2137727522, 1569900650, 856504729, 2033376384, 2086259889, 671790684, 1189001916, 1756048437, 417084592, 2024165808, 966008272);
            uint3x4 b1 = uint3x4(1884195075, 1804207631, 1913174711, 1815920856, 1226577606, 1696467642, 186912044, 1778908130, 1461256625, 1142152181, 272117331, 1162254035);
            uint3x4 r1 = uint3x4(1959708963, 2146117167, 2140863231, 2134768089, 2034163398, 2103430843, 724483964, 1860172798, 2142973365, 1558183925, 2025750515, 2111217619);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x4 a2 = uint3x4(2031026290, 1461019191, 1071959084, 1645847295, 871350674, 736640317, 868515800, 767794452, 362186994, 96189073, 1924033224, 1971421809);
            uint3x4 b2 = uint3x4(870448102, 1845053992, 257334526, 987295814, 1503050768, 1683307763, 1076253109, 1403888383, 561000721, 740143742, 343344681, 2074122472);
            uint3x4 r2 = uint3x4(2079325174, 2147314239, 1073143038, 2061103871, 2080374162, 1878867455, 1944485885, 2146418687, 905361907, 767539967, 1996451561, 2141297401);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x4 a3 = uint3x4(1826545883, 865329, 516571463, 371039923, 918186803, 1920664988, 452155520, 743961772, 1728213958, 825116968, 1597755374, 910392330);
            uint3x4 b3 = uint3x4(133130232, 108733999, 348566046, 1414140366, 975473487, 699452548, 1158934384, 1776041858, 1098964075, 1316223563, 1653177800, 679795328);
            uint3x4 r3 = uint3x4(1879042043, 109000255, 516879199, 1449107455, 1052699519, 2080099740, 1609826288, 1843396526, 1736638447, 2139093867, 2143027182, 1053294218);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_or_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1295304853, 1307252624, 350194630, 1128063578, 1774824542, 2085245467, 1988423804, 999162350, 2110327307, 1050875188, 341855232, 1317039676);
            uint b0 = (1305527136);
            uint3x4 r0 = uint3x4(1307888629, 1308350448, 1574947814, 1341973370, 1842999166, 2111492987, 2144662396, 2145305582, 2111425387, 2146686836, 1576062816, 1339092860);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x4 a1 = uint3x4(228656898, 1536908787, 606786773, 1739461580, 2040936581, 1350320187, 1377874553, 1522262112, 1496806239, 1732466858, 1535976093, 375675620);
            uint b1 = (41280811);
            uint3x4 r1 = uint3x4(267773739, 1543503355, 645920255, 1744828399, 2079849903, 1383982395, 1383462779, 1526719851, 1534588799, 1735916971, 1543366591, 376831983);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x4 a2 = uint3x4(1614193383, 697385997, 112556963, 1614163749, 1583289054, 1370656810, 1286074530, 1155438844, 1835671387, 440002979, 1569359727, 5393691);
            uint b2 = (226059393);
            uint3x4 r2 = uint3x4(1837098727, 771318925, 268271523, 1837068197, 1602189023, 1576793259, 1308619939, 1308622077, 1836810203, 528084387, 1576789999, 226192795);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x4 a3 = uint3x4(774282482, 212144562, 1525899482, 463019249, 1531812233, 1944160603, 953179348, 1692078056, 1331652826, 183129856, 1305664018, 626899632);
            uint b3 = (1217128427);
            uint3x4 r3 = uint3x4(1857028091, 1286600699, 1526458363, 1536950267, 1540358123, 2079059963, 2027683839, 1826353131, 1340076027, 1256978411, 1306263547, 1843396603);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1768627592);
            uint3x4 b0 = uint3x4(1849658052, 1759912154, 729979455, 975926310, 1987690876, 1809506714, 1160695341, 408963395, 314072711, 1560007537, 1709003416, 977086639);
            uint3x4 r0 = uint3x4(1870634956, 1777286618, 1810603967, 2070642094, 2138824188, 1811676570, 1836048301, 2037079499, 2080071567, 2113658873, 1845452696, 2071936431);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1448375596);
            uint3x4 b1 = uint3x4(1689568808, 595543345, 559778387, 621080913, 438994183, 1742637145, 1219409263, 1602932494, 1204461702, 2111538444, 836730895, 1207638621);
            uint3x4 r1 = uint3x4(1995765548, 2004841789, 2002648959, 2002056573, 1585378607, 2011102589, 1593767279, 1608449838, 1474229678, 2145383724, 2011165999, 1476362109);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (802100209);
            uint3x4 b2 = uint3x4(1089077339, 1315030334, 249047666, 1604790897, 1848168086, 347254235, 1777613639, 1876731927, 842785732, 1023558747, 1567635900, 1888818835);
            uint3x4 r2 = uint3x4(1877939195, 1877989375, 803159027, 2146384881, 1877991415, 1073725435, 1878998007, 1876933623, 1073738741, 1070553083, 2147433469, 2145327091);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (1681286114);
            uint3x4 b3 = uint3x4(816160472, 669874393, 856364582, 957707703, 533888601, 707380794, 1472392035, 1658477097, 490006292, 1104319323, 1803275943, 1843251082);
            uint3x4 r3 = uint3x4(1958215674, 1744796667, 2000648166, 2100787191, 2146861051, 1849681914, 2012670947, 1727953899, 2100750326, 1710683131, 1870655463, 1845487594);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_xor_wide_wide()
        {
            uint3x4 a0 = uint3x4(1843655608, 362425681, 640805534, 1342040268, 945678755, 980321850, 390165019, 1682422658, 303897251, 230477768, 1103646442, 1503102919);
            uint3x4 b0 = uint3x4(1422803441, 1234691140, 119589253, 1101464929, 121896337, 1880109018, 1000210266, 1718938232, 464406940, 884337881, 34199854, 1430659227);
            uint3x4 r0 = uint3x4(959296073, 1544407317, 554771227, 240840109, 1058935858, 1249815008, 752651585, 36917754, 162747199, 956900113, 1136760772, 215066460);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x4 a1 = uint3x4(26631152, 1016475570, 1862440929, 379588576, 1943580404, 691527166, 723280696, 497086939, 1640104913, 893178410, 1596765788, 664096470);
            uint3x4 b1 = uint3x4(126415540, 1069919967, 1810763253, 2082802224, 941097951, 27782297, 156353074, 607061607, 470737131, 1151564598, 8268481, 434405645);
            uint3x4 r1 = uint3x4(102672708, 55804269, 82614804, 1787102672, 1270918443, 680538471, 575512842, 965736380, 2110579514, 1906288924, 1599249565, 1047646171);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x4 a2 = uint3x4(2043360590, 799560121, 287637604, 696169196, 2067184169, 1208059988, 1250597330, 1386507647, 1889791408, 2084012261, 308683100, 995657536);
            uint3x4 b2 = uint3x4(519003095, 1880915120, 608970922, 1809455754, 1079250101, 514389994, 272120301, 1282399149, 1045003273, 1596550715, 1654640361, 147544177);
            uint3x4 r2 = uint3x4(1730440857, 1605643529, 896084174, 1118087270, 996325020, 1453948862, 1521655871, 516667090, 1323995577, 589229790, 1895428021, 865328945);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x4 a3 = uint3x4(2114803648, 1391716615, 1288505091, 1981377086, 1609802717, 1174043024, 1011203132, 1795164620, 244928755, 108081775, 1095776733, 1503947924);
            uint3x4 b3 = uint3x4(1770899808, 632909311, 351538321, 18362671, 582069925, 1343437834, 646157103, 1334609482, 1029555059, 1791514242, 2130180592, 1367984612);
            uint3x4 r3 = uint3x4(394305184, 2001372408, 1480133522, 1996577553, 2101480824, 367609242, 449195795, 613191558, 868520832, 1824089325, 1067958317, 137209200);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_xor_wide_scalar()
        {
            uint3x4 a0 = uint3x4(169345668, 176087064, 2084362901, 1663924004, 193851255, 517476661, 905336222, 863800783, 365003873, 835837496, 954341348, 1464576786);
            uint b0 = (354464228);
            uint3x4 r0 = uint3x4(523809632, 526275068, 1763470193, 1980614336, 514678419, 200843473, 550954106, 643578923, 14759301, 619802588, 767731200, 1114315510);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x4 a1 = uint3x4(625604047, 2003392824, 1481813598, 1077374714, 1043379893, 1991576049, 781860967, 60088394, 1196907956, 858716109, 858484213, 178843494);
            uint b1 = (1700827127);
            uint3x4 r1 = uint3x4(1076460088, 302634703, 1026695593, 626516237, 1531984194, 332760582, 1274728336, 1727295421, 574083651, 1447983162, 1447813634, 1875402897);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x4 a2 = uint3x4(1223183458, 1771693181, 1206307664, 2037729583, 1324393116, 497725784, 1367278685, 962962860, 906632547, 1570278596, 1744797352, 574677361);
            uint b2 = (866652388);
            uint3x4 r2 = uint3x4(2067815558, 1513223321, 1951325108, 1256020427, 2102964856, 771924412, 1658262713, 181253448, 94506375, 1848679456, 1415016012, 300478869);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x4 a3 = uint3x4(1363709514, 801937870, 1010182360, 1851940033, 346084804, 1153678862, 443991213, 53881334, 2016754499, 1219039118, 98879165, 1431003548);
            uint b3 = (1256194849);
            uint3x4 r3 = uint3x4(464031083, 1697422063, 1993747449, 612524000, 1581307621, 237223215, 1352058764, 1238772439, 852834402, 38341807, 1325712796, 531325629);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1361775641);
            uint3x4 b0 = uint3x4(1452773578, 459050892, 1986218254, 1689037698, 999278344, 1229114508, 1087843538, 733699740, 106187872, 1533632738, 1107817672, 492506236);
            uint3x4 r0 = uint3x4(129801427, 1249346453, 659047703, 898082715, 1789184785, 409583765, 301736139, 2056278661, 1467957369, 172125435, 321714385, 1282408549);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (597602329);
            uint3x4 b1 = uint3x4(1439603382, 1001169118, 1231718216, 1693179077, 1050897427, 1796435561, 1100532547, 2106589181, 79691722, 851486414, 381749210, 1743618507);
            uint3x4 r1 = uint3x4(1984965295, 405934279, 1794389841, 1198877916, 490593290, 1217257072, 1644591962, 1578192868, 656494547, 291378903, 895465411, 1148400082);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (2038827673);
            uint3x4 b2 = uint3x4(1680906962, 161437943, 171927307, 277703584, 1344718195, 1634011177, 28540247, 1205447252, 150341716, 899457210, 1927941858, 1213321665);
            uint3x4 r2 = uint3x4(498503755, 1880707694, 1941532050, 1762353465, 698404842, 417530544, 2016769998, 1046454477, 1903166157, 1276815907, 191628411, 836229976);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1943899052);
            uint3x4 b3 = uint3x4(1166699955, 244059986, 698605361, 770240668, 1451322609, 409403288, 227252138, 455879262, 1859170556, 2135312326, 436746325, 843204844);
            uint3x4 r3 = uint3x4(911730207, 2102494462, 1518228637, 1580563248, 626845533, 1807447092, 2119572486, 1760666098, 487406416, 211537002, 1775612921, 1100989248);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_left_shift()
        {
            uint3x4 a0 = uint3x4(1129100049, 829482269, 1571297368, 443753193, 1872142968, 249554593, 892627436, 980302862, 62369727, 849916599, 1271350845, 108441902);
            int b0 = (218351941);
            uint3x4 r0 = uint3x4(1771463200, 773628832, 3036875520, 1315200288, 4074000128, 3690779680, 2794274176, 1304920512, 1995831264, 1427527392, 2028521376, 3470140864);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3x4 a1 = uint3x4(1959056531, 1451674188, 2082026915, 1149883636, 1380536034, 186532735, 1487486874, 1498738574, 752067504, 1647167336, 772453640, 456967739);
            int b1 = (1779118882);
            uint3x4 r1 = uint3x4(3541258828, 1511729456, 4033140364, 304567248, 1227176840, 746130940, 1654980200, 1699987000, 3008270016, 2293702048, 3089814560, 1827870956);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3x4 a2 = uint3x4(947384545, 1315516161, 640579158, 56630178, 1650899378, 2142944517, 565484033, 965161323, 1634169280, 1821547426, 1959741996, 1189216014);
            int b2 = (1463252873);
            uint3x4 r2 = uint3x4(4024549888, 3529376256, 1559014400, 3224847360, 3446891520, 1970932224, 1765016064, 241358336, 3471015936, 624378880, 2660521984, 3288210432);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3x4 a3 = uint3x4(2088913234, 1765476869, 1716088059, 2042799042, 1560870407, 1332136179, 1595140080, 1067324801, 948699739, 1516035622, 1153563832, 1430593538);
            int b3 = (331636352);
            uint3x4 r3 = uint3x4(2088913234, 1765476869, 1716088059, 2042799042, 1560870407, 1332136179, 1595140080, 1067324801, 948699739, 1516035622, 1153563832, 1430593538);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_right_shift()
        {
            uint3x4 a0 = uint3x4(809126085, 908563670, 763568837, 1986717290, 1174507510, 646821842, 1242726074, 390811632, 1521420393, 1923166649, 102096936, 400863878);
            int b0 = (994800051);
            uint3x4 r0 = uint3x4(1543, 1732, 1456, 3789, 2240, 1233, 2370, 745, 2901, 3668, 194, 764);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3x4 a1 = uint3x4(667378673, 307750782, 479442287, 2014389412, 1673938174, 1075916177, 1248577253, 848199210, 813936577, 848976170, 500930883, 662405800);
            int b1 = (1611921244);
            uint3x4 r1 = uint3x4(2, 1, 1, 7, 6, 4, 4, 3, 3, 3, 1, 2);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3x4 a2 = uint3x4(126875849, 1199000503, 955487090, 1013356510, 391605984, 185228398, 87452680, 2021602226, 1401766495, 275199908, 664576720, 363706280);
            int b2 = (1103917083);
            uint3x4 r2 = uint3x4(0, 8, 7, 7, 2, 1, 0, 15, 10, 2, 4, 2);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3x4 a3 = uint3x4(1600231415, 1403250657, 1132760506, 388419548, 1563117590, 1786307084, 1386128491, 1614558171, 370772389, 47213745, 1348912303, 1452132416);
            int b3 = (19835299);
            uint3x4 r3 = uint3x4(200028926, 175406332, 141595063, 48552443, 195389698, 223288385, 173266061, 201819771, 46346548, 5901718, 168614037, 181516552);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public void uint3x4_operator_bitwise_not()
        {
            uint3x4 a0 = uint3x4(111796841, 603562399, 745091931, 853183268, 1110916612, 381888399, 1891338755, 1506860135, 771210628, 787710759, 875964607, 96456785);
            uint3x4 r0 = uint3x4(4183170454, 3691404896, 3549875364, 3441784027, 3184050683, 3913078896, 2403628540, 2788107160, 3523756667, 3507256536, 3419002688, 4198510510);
            TestUtils.AreEqual(~a0, r0);

            uint3x4 a1 = uint3x4(916013379, 1172294211, 1020232736, 683852713, 375158799, 881353367, 1218471344, 1174233245, 592898220, 443427914, 1385118179, 215320517);
            uint3x4 r1 = uint3x4(3378953916, 3122673084, 3274734559, 3611114582, 3919808496, 3413613928, 3076495951, 3120734050, 3702069075, 3851539381, 2909849116, 4079646778);
            TestUtils.AreEqual(~a1, r1);

            uint3x4 a2 = uint3x4(860122767, 1349739899, 686325107, 829984855, 191189901, 319233142, 156019905, 1467719681, 1193642973, 957020051, 610113447, 1906177458);
            uint3x4 r2 = uint3x4(3434844528, 2945227396, 3608642188, 3464982440, 4103777394, 3975734153, 4138947390, 2827247614, 3101324322, 3337947244, 3684853848, 2388789837);
            TestUtils.AreEqual(~a2, r2);

            uint3x4 a3 = uint3x4(1022824453, 1876376887, 479785538, 1454477141, 1062967600, 864049393, 916152339, 1644897753, 1624633488, 210894078, 759733457, 40062168);
            uint3x4 r3 = uint3x4(3272142842, 2418590408, 3815181757, 2840490154, 3231999695, 3430917902, 3378814956, 2650069542, 2670333807, 4084073217, 3535233838, 4254905127);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
