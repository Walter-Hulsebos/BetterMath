// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt4x4
    {
        [TestCompiler]
        public void int4x4_zero()
        {
            TestUtils.AreEqual(int4x4.zero.c0.x, 0);
            TestUtils.AreEqual(int4x4.zero.c0.y, 0);
            TestUtils.AreEqual(int4x4.zero.c0.z, 0);
            TestUtils.AreEqual(int4x4.zero.c0.w, 0);
            TestUtils.AreEqual(int4x4.zero.c1.x, 0);
            TestUtils.AreEqual(int4x4.zero.c1.y, 0);
            TestUtils.AreEqual(int4x4.zero.c1.z, 0);
            TestUtils.AreEqual(int4x4.zero.c1.w, 0);
            TestUtils.AreEqual(int4x4.zero.c2.x, 0);
            TestUtils.AreEqual(int4x4.zero.c2.y, 0);
            TestUtils.AreEqual(int4x4.zero.c2.z, 0);
            TestUtils.AreEqual(int4x4.zero.c2.w, 0);
            TestUtils.AreEqual(int4x4.zero.c3.x, 0);
            TestUtils.AreEqual(int4x4.zero.c3.y, 0);
            TestUtils.AreEqual(int4x4.zero.c3.z, 0);
            TestUtils.AreEqual(int4x4.zero.c3.w, 0);
        }

        [TestCompiler]
        public void int4x4_identity()
        {
            TestUtils.AreEqual(int4x4.identity.c0.x, 1);
            TestUtils.AreEqual(int4x4.identity.c0.y, 0);
            TestUtils.AreEqual(int4x4.identity.c0.z, 0);
            TestUtils.AreEqual(int4x4.identity.c0.w, 0);
            TestUtils.AreEqual(int4x4.identity.c1.x, 0);
            TestUtils.AreEqual(int4x4.identity.c1.y, 1);
            TestUtils.AreEqual(int4x4.identity.c1.z, 0);
            TestUtils.AreEqual(int4x4.identity.c1.w, 0);
            TestUtils.AreEqual(int4x4.identity.c2.x, 0);
            TestUtils.AreEqual(int4x4.identity.c2.y, 0);
            TestUtils.AreEqual(int4x4.identity.c2.z, 1);
            TestUtils.AreEqual(int4x4.identity.c2.w, 0);
            TestUtils.AreEqual(int4x4.identity.c3.x, 0);
            TestUtils.AreEqual(int4x4.identity.c3.y, 0);
            TestUtils.AreEqual(int4x4.identity.c3.z, 0);
            TestUtils.AreEqual(int4x4.identity.c3.w, 1);
        }

        [TestCompiler]
        public void int4x4_operator_equal_wide_wide()
        {
            int4x4 a0 = int4x4(2105871082, 35218899, 1550755093, 764676020, 606743782, 1208156098, 1023640014, 1038468316, 1416064367, 727143393, 2061243891, 184669837, 1303661760, 2044073738, 370395888, 1822916805);
            int4x4 b0 = int4x4(1477587886, 579629692, 540974792, 208405066, 2063397938, 1060167409, 362592601, 2097545362, 277670088, 426944490, 901076223, 857900673, 1548779757, 325265488, 312658571, 176373760);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(1076983135, 345215866, 833676277, 1987782708, 1481088614, 1364754268, 93639636, 1850596922, 2073471507, 1745989448, 28118669, 1267554232, 1292918049, 1423451579, 644384701, 1985492825);
            int4x4 b1 = int4x4(2052378097, 858156597, 982817797, 1252095508, 882634538, 1959142806, 72495800, 1077678183, 1729269763, 1607675346, 1813461519, 1204794859, 1324801873, 1975336, 439410532, 294085211);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(240481133, 2130667921, 17376735, 1263869085, 437371027, 1093339523, 1683805602, 764261037, 1845666482, 399277628, 714152770, 148255091, 784823865, 1712722195, 1706849865, 607710807);
            int4x4 b2 = int4x4(1031782338, 1118745564, 180311719, 433246570, 1622531532, 1178609353, 373010678, 1231165960, 966395555, 788609772, 215241459, 1411005263, 1287904654, 1656358051, 1985807372, 1041678082);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(1044625360, 1718661673, 89311526, 1060301448, 465400678, 1170304319, 720121996, 1668472904, 560540836, 303792501, 40132904, 1727416088, 883527247, 333921699, 615073171, 873880352);
            int4x4 b3 = int4x4(1070669057, 1209340945, 731851358, 1893159788, 1312742878, 553070784, 88944879, 919907371, 192285619, 1825472793, 1196883053, 25239674, 719662658, 876955728, 1754994681, 599047302);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(437822262, 2020661134, 541786900, 853113810, 23716499, 179951405, 1409026299, 948838849, 953202998, 691955848, 1926262965, 1851546137, 712957637, 2028784869, 1049962241, 1836975611);
            int b0 = (1332833578);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(1016802970, 464814777, 1451642042, 289137869, 152339338, 808355440, 660053867, 597354173, 67320270, 151461188, 35153827, 602895443, 186996278, 129611815, 1031574999, 1697392883);
            int b1 = (390120467);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(1463742000, 611116281, 594150729, 375387566, 1984352551, 1925707182, 570698441, 1872629381, 1263218472, 315982238, 122473806, 1404530826, 43943273, 1695786992, 2085125114, 432271298);
            int b2 = (857785521);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(465353570, 841947061, 2115740248, 148684393, 1180494240, 1212305694, 2029216680, 255759637, 2103879876, 28490217, 1373872472, 345943406, 766206720, 562344033, 894687966, 154153254);
            int b3 = (1315431335);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_equal_scalar_wide()
        {
            int a0 = (542329200);
            int4x4 b0 = int4x4(1115584594, 684107773, 1928988941, 890709324, 641152437, 1410341302, 497505660, 1068223109, 2014009435, 213835595, 1592428361, 1819361470, 448650623, 1942175642, 64377057, 1485938610);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1146305380);
            int4x4 b1 = int4x4(1312317120, 263290348, 812663708, 1585209188, 40646617, 1378718922, 1957797737, 873652576, 1780082094, 1513270921, 2095980581, 1413074719, 1387984261, 1547119354, 924385171, 1253636050);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1477542688);
            int4x4 b2 = int4x4(969120167, 591812191, 856880926, 1114040166, 2107388425, 1368188588, 512677295, 1337925727, 2076181515, 1317314747, 299981273, 601822512, 1079453890, 125277108, 1257151509, 1915342590);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1034639325);
            int4x4 b3 = int4x4(456730344, 1005099225, 1071115483, 1104603659, 1074937977, 1452872498, 2118674851, 17056748, 1008553990, 2044554028, 549008726, 1802632037, 626025174, 814199888, 668043190, 565725420);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_not_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1977284100, 1293292704, 1547283851, 422428953, 195833190, 1711544892, 5606053, 737069074, 647386678, 13079405, 1413841590, 1076166545, 1211445174, 1289303469, 1436402489, 1129570126);
            int4x4 b0 = int4x4(1514195556, 957972049, 507667364, 581861672, 1128094576, 940096636, 57559040, 181752616, 962017320, 1762015406, 1107218953, 2042026522, 836002288, 570272309, 2112081980, 1500634658);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(1566836685, 1343313905, 329259205, 1774944480, 33906739, 2055853627, 2035015372, 1702756001, 1164186087, 329853698, 769052491, 1893312730, 438029011, 1894010522, 1365847542, 1292942830);
            int4x4 b1 = int4x4(1787808345, 566425667, 2037529609, 1520589840, 266793699, 538816359, 2075474643, 553571317, 218264354, 654754196, 1392180230, 870065147, 1398749829, 711281563, 1999640291, 231234857);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(2146008097, 1520743598, 861728782, 1999977058, 1334556487, 1728108667, 1198848973, 7011150, 1280729934, 1553569869, 1782228282, 731582167, 2041979262, 128396656, 143519087, 154742298);
            int4x4 b2 = int4x4(210910234, 365281355, 170643407, 757340716, 639973212, 1147047891, 537350186, 1283454178, 735732152, 1218138135, 474815930, 174656455, 473248758, 1077993023, 1063662917, 181750095);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(1121334516, 540291909, 554731045, 1839326182, 365770943, 1467681356, 1811555210, 1818699821, 1391738679, 1578035276, 446070422, 596490222, 1626811714, 470785740, 42246751, 613821629);
            int4x4 b3 = int4x4(1824618770, 1824105138, 1337474646, 993542680, 1719996629, 129079279, 746264839, 2048162472, 610556344, 630115390, 74804695, 1671192167, 1346087143, 388480024, 921984035, 270893570);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_not_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1038269360, 1427812625, 103361237, 1347017023, 1523584313, 150442802, 660334527, 719113717, 262959423, 484398043, 506946952, 226568494, 507918242, 1702162286, 923269270, 166187260);
            int b0 = (768873026);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(114581840, 1648095254, 1461803977, 61801615, 1317840133, 2146927809, 1557151164, 1284033253, 1345705546, 1747302566, 611028295, 1368046109, 1848036266, 2025452920, 373992983, 289537519);
            int b1 = (1045389187);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(1388743060, 1854553487, 872755032, 2113020512, 1062447442, 632285066, 109864030, 1583997921, 1732461790, 1276630817, 721080697, 922945173, 1528002730, 282331576, 1372281893, 167200566);
            int b2 = (146455100);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(1271483982, 1782181919, 659215598, 976467745, 1598516540, 1428368463, 693693720, 62983770, 177878767, 550623883, 49306232, 1498551255, 562406804, 606428770, 132953969, 2084514622);
            int b3 = (1769269391);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_not_equal_scalar_wide()
        {
            int a0 = (1652127596);
            int4x4 b0 = int4x4(953791238, 271722683, 1278885987, 735128017, 112416504, 25967222, 1761444475, 1844594536, 1199122922, 634219279, 942501101, 67161343, 969944293, 833229499, 1304301133, 704045745);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (345012334);
            int4x4 b1 = int4x4(1253134152, 325772538, 855127202, 793668881, 1584481616, 1101301152, 276853534, 987168816, 1258105989, 362645228, 293978043, 1772395973, 1692007315, 681268929, 1535518457, 595209334);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (25745185);
            int4x4 b2 = int4x4(1278016813, 2125682481, 2037751005, 1405297618, 1825546885, 1584424742, 1779859088, 1262387250, 936213998, 739749071, 1934808433, 1333711144, 571211509, 445791940, 43428024, 1509344718);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1643255886);
            int4x4 b3 = int4x4(383699707, 2040544421, 408607994, 858458715, 1516793269, 1317905178, 1002032453, 1895442848, 1001794162, 1810805641, 1467466432, 72198563, 1654599254, 2100433997, 1554466291, 1619435656);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_wide_wide()
        {
            int4x4 a0 = int4x4(1486550609, 1779244308, 1602148045, 1614085440, 1975613414, 942838342, 1092279031, 373677431, 1419098312, 337757077, 1081797900, 1336745069, 840685445, 1220554047, 2013681746, 192965012);
            int4x4 b0 = int4x4(97842578, 536551311, 413528975, 1838293684, 1283898480, 1456599961, 1080278602, 529676676, 156584048, 117348799, 246927124, 1916615924, 1731071394, 1328098431, 1014995792, 480319327);
            bool4x4 r0 = bool4x4(false, false, false, true, false, true, false, true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(532043965, 1000693402, 927236048, 1215860000, 780607596, 1882056852, 1354146545, 2135295778, 1145973790, 1938006975, 895882838, 2006524299, 908581156, 1843349513, 1340458575, 1972095585);
            int4x4 b1 = int4x4(1765937053, 1333997067, 688515308, 1856106947, 1303906227, 646821776, 1169473993, 316770064, 1518155802, 416732703, 529193056, 1239623485, 2010112031, 2018560298, 285987009, 960617622);
            bool4x4 r1 = bool4x4(true, true, false, true, true, false, false, false, true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(1090933468, 924555996, 79585200, 1749924275, 1088207695, 1484224850, 512353919, 562469379, 1743259263, 182124641, 1224472464, 1731920136, 1906896401, 425415911, 992649442, 515648372);
            int4x4 b2 = int4x4(462519015, 1473825625, 1187164011, 730583004, 629133777, 1925375320, 689923293, 1818695099, 903783983, 495525944, 1923715956, 2850909, 1908553564, 1064607664, 1344783349, 494620587);
            bool4x4 r2 = bool4x4(false, true, true, false, false, true, true, true, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(1479294289, 1703371955, 244917997, 237184864, 1915715174, 1476008655, 1192451853, 727269566, 1447642652, 275301035, 103862368, 1883628805, 878082526, 1714412871, 761748100, 1885417209);
            int4x4 b3 = int4x4(921439230, 891627530, 661470153, 2106293426, 1207423971, 266749061, 81148979, 218657863, 24654414, 436674592, 1476569641, 1314701159, 921705087, 318515283, 685316611, 1890907993);
            bool4x4 r3 = bool4x4(false, false, true, true, false, false, false, false, false, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_wide_scalar()
        {
            int4x4 a0 = int4x4(796797557, 670113454, 933579492, 278884514, 318174822, 1117630673, 741886928, 1990922600, 1030849597, 1546212312, 1718582899, 1648393417, 1857132231, 1909506562, 1294006045, 952084157);
            int b0 = (746564682);
            bool4x4 r0 = bool4x4(false, true, false, true, true, false, true, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(1303736668, 979430272, 1368236640, 24980695, 1434668705, 659552739, 1058492383, 165694933, 1204097259, 922212691, 281328069, 24629507, 1386458568, 1325149699, 1498707004, 1650355158);
            int b1 = (845460171);
            bool4x4 r1 = bool4x4(false, false, false, true, false, true, false, true, false, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(1213017950, 759932777, 1542997846, 1227393490, 1520634374, 1750827258, 1951142425, 1956860037, 681224518, 1889763470, 1915403219, 850845857, 1871934613, 1882514458, 1326783898, 1044736383);
            int b2 = (1650457461);
            bool4x4 r2 = bool4x4(true, true, true, true, true, false, false, false, true, false, false, true, false, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(24899250, 1979593332, 1345719300, 771816862, 1459379624, 10560715, 2022570756, 113189581, 1261561210, 195417982, 460558859, 1966293093, 1791874676, 221062613, 219875895, 2145521906);
            int b3 = (2096162636);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_scalar_wide()
        {
            int a0 = (186400299);
            int4x4 b0 = int4x4(1881344229, 813834467, 1254886626, 1353590345, 1412343685, 1555571443, 1540508298, 1735458634, 135888070, 1643818742, 248291654, 1739560105, 728539891, 480507742, 1696553040, 540223931);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1840493353);
            int4x4 b1 = int4x4(146833656, 798115946, 2002002066, 1011261705, 783550942, 1093071215, 598253401, 1432416562, 1863582169, 103622950, 775175960, 116908309, 1213433625, 1428954824, 1760442490, 1208143947);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (751820805);
            int4x4 b2 = int4x4(1491872302, 560004484, 2065157473, 310839658, 697329242, 898786601, 1448893980, 1204091943, 1933043135, 828031833, 1737703663, 1672512847, 1112905025, 1666248737, 1352503217, 406395888);
            bool4x4 r2 = bool4x4(true, false, true, false, false, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (1734008932);
            int4x4 b3 = int4x4(1237327481, 1318771944, 791935677, 1322622241, 1097793287, 1868246899, 656633225, 2068657430, 1696245163, 1451948493, 765332338, 1618550325, 1069938092, 214863918, 635332811, 531416158);
            bool4x4 r3 = bool4x4(false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_wide_wide()
        {
            int4x4 a0 = int4x4(2087717754, 1725569452, 1298066182, 1693943616, 1319019629, 70674491, 1042499725, 1002821508, 1021857133, 1744374599, 821751047, 467646903, 2029731638, 1377214212, 1207816926, 474621063);
            int4x4 b0 = int4x4(85148514, 293632137, 1151128249, 409440398, 1115020183, 1508500597, 1834583302, 1755218534, 1788761753, 1128238489, 834223713, 1578743290, 1647150256, 1756397855, 1131080201, 1208965204);
            bool4x4 r0 = bool4x4(true, true, true, true, true, false, false, false, false, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(20781266, 366593779, 2068457387, 10181449, 793634464, 144474612, 99947390, 930377263, 683686232, 742803073, 918292048, 875621429, 1764985258, 411384146, 1921397684, 1349107119);
            int4x4 b1 = int4x4(1495161099, 1283714281, 908051907, 412849651, 815822687, 730271942, 40756039, 883326140, 476260632, 1024136446, 1440596667, 1253494041, 146826162, 1798399573, 2085029408, 187939428);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, true, true, true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(640399120, 1487719331, 1467989523, 1834244794, 1778580304, 334604025, 689749101, 1478795900, 716772993, 1072711623, 388277128, 290673156, 619539670, 1666212670, 496667761, 638935614);
            int4x4 b2 = int4x4(1009192934, 1694822273, 1866590874, 113805226, 1331524948, 5928360, 1884858608, 1988975599, 493888072, 731556294, 1597968264, 727668246, 1260583385, 1921631225, 359265523, 856088703);
            bool4x4 r2 = bool4x4(false, false, false, true, true, true, false, false, true, true, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(1614199215, 89872822, 700520355, 1562820264, 789499485, 1393039789, 1105992642, 563744940, 815513909, 1081626580, 1012317785, 1947145947, 718519778, 1075282603, 200378204, 1764621112);
            int4x4 b3 = int4x4(2104018831, 1238238103, 1383038637, 964579005, 628997847, 1734250747, 869693069, 2027610297, 569892194, 1427509612, 617550825, 1189914503, 760051085, 207406138, 2060097216, 1419314781);
            bool4x4 r3 = bool4x4(false, false, false, true, true, false, true, false, true, false, true, true, false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_wide_scalar()
        {
            int4x4 a0 = int4x4(1208626274, 239697208, 1979453345, 1253474001, 1590192876, 1487911635, 1673945595, 1662650098, 222749855, 1433540517, 566635217, 1773305960, 1850273578, 206147145, 325913453, 333381537);
            int b0 = (1715176566);
            bool4x4 r0 = bool4x4(false, false, true, false, false, false, false, false, false, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(1905567362, 570397194, 2128431130, 1735325311, 529971908, 1663525234, 1972984241, 1587865063, 488268523, 121921923, 812076921, 181082921, 1281638484, 1818357732, 116518997, 1397728785);
            int b1 = (2053577491);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(1924199337, 1463993051, 1598027926, 842851852, 160842093, 1226313895, 540338405, 174088887, 1609299242, 425486336, 1462766889, 651513452, 1122649822, 771802057, 839323192, 325778683);
            int b2 = (742950077);
            bool4x4 r2 = bool4x4(true, true, true, true, false, true, false, false, true, false, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(406189885, 2101738734, 432896271, 1620784610, 1185204658, 723655621, 6469104, 1813092585, 1101924353, 1365989712, 861868674, 1481567177, 1088595018, 1762666432, 450116220, 375577175);
            int b3 = (1676059941);
            bool4x4 r3 = bool4x4(false, true, false, false, false, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_scalar_wide()
        {
            int a0 = (480938827);
            int4x4 b0 = int4x4(1824731899, 921496110, 586859044, 946430596, 1231356727, 1390167458, 1785807092, 28949024, 2037899283, 595656760, 1778095771, 1233500439, 1696302238, 1445965340, 484020151, 1586962841);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1361740714);
            int4x4 b1 = int4x4(265628948, 2003122957, 332267433, 1128353075, 377919478, 982113135, 1117675960, 630865591, 1550679736, 895945757, 287025687, 643452096, 660504007, 613135893, 633307118, 514276792);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, true, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1377364317);
            int4x4 b2 = int4x4(84491736, 746768197, 1282879723, 589415384, 363082240, 1774333756, 741005890, 413100725, 702141547, 1434366582, 1489794027, 1710601432, 1914069735, 1811684885, 1007116016, 1883396218);
            bool4x4 r2 = bool4x4(true, true, true, true, true, false, true, true, true, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (318035497);
            int4x4 b3 = int4x4(25535571, 1971931803, 1966772446, 1500069399, 1446812421, 2086866622, 1616666731, 315565005, 1828160638, 494221701, 1498781405, 1532980575, 1377395276, 2130004514, 1144788653, 719223647);
            bool4x4 r3 = bool4x4(true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_equal_wide_wide()
        {
            int4x4 a0 = int4x4(154092149, 1515170149, 1083970332, 785807178, 1401094881, 310537627, 868328962, 1990816725, 2035349541, 457043352, 1123282035, 1001842946, 1387761992, 195272789, 659549000, 888761458);
            int4x4 b0 = int4x4(77984380, 1712054191, 1566203809, 254834519, 450519938, 389457083, 1298669505, 207343167, 1214449047, 2059561026, 896534357, 1897470050, 521075677, 1848221945, 374708019, 1573731118);
            bool4x4 r0 = bool4x4(false, true, true, false, false, true, true, false, false, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(283706617, 1790185840, 899029812, 848317418, 1743712447, 1504407474, 1798441490, 1902791952, 606340844, 1994437705, 301831413, 654230470, 1223625081, 324292199, 1370931020, 1742769166);
            int4x4 b1 = int4x4(2093466449, 1660210829, 1568778785, 1352157589, 1212771905, 1457525058, 1493446008, 1784768208, 1993422493, 1378671664, 1447376929, 1405041439, 1765183746, 562894655, 1085068880, 1026386862);
            bool4x4 r1 = bool4x4(true, false, true, true, false, false, false, false, true, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(1709242127, 105750466, 1655967312, 1455797002, 366131629, 315848579, 1539610530, 99028560, 765767372, 1241881101, 527753961, 1271899705, 1439235979, 436585748, 1244486586, 2128710216);
            int4x4 b2 = int4x4(884290156, 922346160, 330605896, 466570756, 1252369410, 2057993777, 1691801535, 2041799631, 557988228, 813610154, 1657573441, 983813335, 385144401, 1281329713, 285422763, 658643567);
            bool4x4 r2 = bool4x4(false, true, false, false, true, true, true, true, false, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(1617486386, 1895766578, 1387695542, 128800896, 537625491, 1012540035, 1131528350, 2012914556, 1666155186, 1944610930, 1990671426, 498632901, 1759874098, 1630593828, 2041503795, 1369567817);
            int4x4 b3 = int4x4(478020612, 914151334, 980445792, 275734948, 1527866949, 1196945650, 743720340, 1679307193, 429976215, 812942792, 929159012, 51668686, 1269420778, 1270822911, 174467289, 80708866);
            bool4x4 r3 = bool4x4(false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1479531977, 1427983411, 415250630, 1245345407, 1112546666, 1072990632, 1579912858, 101048307, 1070894375, 509818792, 1910488590, 85452501, 518127023, 1246249980, 1097326500, 1964410699);
            int b0 = (2004563877);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(1968139888, 662096238, 1140643434, 754434551, 155343473, 995927387, 974873240, 1773400038, 497436329, 1825940497, 527516420, 1477043363, 1378470734, 96190147, 37188105, 839762283);
            int b1 = (1191853379);
            bool4x4 r1 = bool4x4(false, true, true, true, true, true, true, false, true, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(781102710, 1145011483, 139031840, 127837780, 817806943, 1248492707, 649140851, 913173654, 1530989756, 856611228, 479496140, 287809619, 626008542, 2075114788, 269756518, 1123999963);
            int b2 = (766321672);
            bool4x4 r2 = bool4x4(false, false, true, true, false, false, true, false, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(1061241170, 1419753922, 827050063, 725097426, 1849220404, 432056024, 1587861037, 1619429016, 615110337, 1394533782, 1052396438, 771488591, 1839907288, 413628645, 1873300485, 1393173865);
            int b3 = (478230935);
            bool4x4 r3 = bool4x4(false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_less_equal_scalar_wide()
        {
            int a0 = (1899193992);
            int4x4 b0 = int4x4(915011820, 980913757, 1337699683, 1476321359, 1102143668, 660493983, 184664508, 381579707, 1954892821, 1295090571, 1440368586, 1696003686, 88708652, 1332251857, 1310713644, 2112132784);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (48951945);
            int4x4 b1 = int4x4(1888568027, 39340955, 1108242207, 260777425, 593122164, 291471959, 253457314, 1264570386, 699618012, 927735863, 2063158939, 932253787, 1168754049, 749328788, 1882694892, 168499987);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (378173027);
            int4x4 b2 = int4x4(339963627, 832906712, 559482768, 53067420, 1895722478, 809981860, 591790551, 1680760399, 653274934, 1664284538, 1283249545, 767500110, 1334099884, 1271622829, 1270706578, 56782179);
            bool4x4 r2 = bool4x4(false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (505839576);
            int4x4 b3 = int4x4(416548761, 1604253810, 438515054, 1638416567, 321889656, 689441798, 1084242369, 211750973, 402525656, 1880241767, 268989216, 1596809567, 786138772, 545761783, 1705157341, 1527503699);
            bool4x4 r3 = bool4x4(false, true, false, true, false, true, true, false, false, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_equal_wide_wide()
        {
            int4x4 a0 = int4x4(8538378, 2131749726, 265427108, 523609761, 994991818, 839709564, 101288202, 1886280970, 2032074826, 631221455, 1456286159, 961342752, 424526026, 788481984, 1662488497, 870326690);
            int4x4 b0 = int4x4(903145828, 1697992986, 1432491982, 169789504, 1059357300, 1744255222, 1606584463, 1905414425, 1448794969, 136181998, 1678754836, 2069656857, 398982689, 243317404, 740939613, 1894753119);
            bool4x4 r0 = bool4x4(false, true, false, true, false, false, false, false, true, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(708712581, 1260182701, 1165630721, 138247561, 1108650168, 1933222913, 672493999, 1541402159, 1921596027, 1557351956, 147242547, 892772168, 2089286723, 1273466960, 644009998, 654784654);
            int4x4 b1 = int4x4(301760792, 1260647988, 3608523, 52576030, 903420465, 1648820371, 627296845, 1679808907, 1719102039, 1718081638, 655586949, 477267189, 62092869, 2013928066, 280292357, 254052205);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, false, true, false, false, true, true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(189030610, 1035542641, 346401762, 739783704, 1310547408, 1175015477, 1893015570, 1397162858, 1005064177, 469205024, 1331071304, 1747510572, 1556472271, 1318844912, 877625210, 1556049679);
            int4x4 b2 = int4x4(1092440092, 1947011057, 625632982, 2028466303, 578645425, 552865694, 1460006028, 1944712828, 1256156724, 2090870105, 1299728699, 53125632, 782915512, 1103537852, 271803142, 828357811);
            bool4x4 r2 = bool4x4(false, false, false, false, true, true, true, false, false, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(248635811, 1459789761, 1739237851, 1333407145, 979318335, 407534230, 1628055119, 731735266, 812413658, 1008863889, 1958570980, 1070464548, 1492413167, 390538786, 1454271717, 1150841093);
            int4x4 b3 = int4x4(1679170708, 1727537554, 1741874749, 1295963045, 1676369300, 1716080769, 339906474, 629280695, 1476237779, 1535336921, 711398196, 1036785558, 982417009, 1710969897, 1783729499, 1038744266);
            bool4x4 r3 = bool4x4(false, false, false, true, false, false, true, true, false, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(2049236663, 182691143, 634973382, 1197012109, 439837565, 1367606469, 1108037359, 351147187, 1898505669, 411667685, 1998610091, 4652390, 996159180, 2111455181, 727766399, 96217144);
            int b0 = (1061998015);
            bool4x4 r0 = bool4x4(true, false, false, true, false, true, true, false, true, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(814085575, 1293933760, 1732973229, 1473283041, 899444524, 1023753195, 1373738074, 518164359, 717850464, 1765188600, 1826820341, 527594558, 1816542874, 839185150, 1143596061, 1819554651);
            int b1 = (1525995206);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, false, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(160724539, 878086499, 363122662, 1989978759, 2145562949, 491416140, 122055824, 1432184946, 690328424, 638547285, 403700518, 569358695, 1988815901, 933324785, 1709851817, 1451640349);
            int b2 = (993212636);
            bool4x4 r2 = bool4x4(false, false, false, true, true, false, false, true, false, false, false, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(1782506169, 1298885111, 22631046, 575953622, 162553491, 1306421595, 1408718955, 678847750, 1869470748, 1749901516, 1428700665, 1971036276, 81962795, 1719966182, 855014030, 332581386);
            int b3 = (896666795);
            bool4x4 r3 = bool4x4(true, true, false, false, false, true, true, false, true, true, true, true, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_greater_equal_scalar_wide()
        {
            int a0 = (1859811087);
            int4x4 b0 = int4x4(1070365918, 1783869452, 830091760, 377157428, 327199016, 90384229, 1154649706, 376758501, 1079802834, 2054742898, 1328349472, 434061447, 951207723, 598695892, 975131651, 1714007943);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (177416473);
            int4x4 b1 = int4x4(1267232721, 31082860, 216791741, 119054289, 1905107583, 89559116, 55041824, 691334141, 462326883, 1658303669, 914628512, 1134364322, 1677134711, 1955614770, 2067009301, 1454405405);
            bool4x4 r1 = bool4x4(false, true, false, true, false, true, true, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (299467282);
            int4x4 b2 = int4x4(1584922149, 561776357, 564147844, 398216936, 1478439642, 958973988, 725612832, 1586062302, 1992817431, 732550238, 1151725147, 11183347, 643483664, 1846311608, 999376922, 1029876878);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1092702918);
            int4x4 b3 = int4x4(281884284, 1033936590, 1197933362, 1740756798, 1312741982, 1694310336, 775049936, 1833306934, 2012355780, 579564207, 240021194, 1389877826, 1550151770, 99128128, 1408823818, 1127139689);
            bool4x4 r3 = bool4x4(true, true, false, false, false, false, true, false, false, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_add_wide_wide()
        {
            int4x4 a0 = int4x4(2135171378, 21433296, 1954723494, 683604307, 1054212315, 1762680995, 1963655852, 1257853062, 2043493600, 976898058, 1915056423, 121374462, 1218855698, 700538222, 1702057277, 1788251699);
            int4x4 b0 = int4x4(1013431952, 366718162, 359290756, 1393163294, 1962236872, 1263270041, 1862666629, 1077447887, 821693806, 487316539, 350922520, 1583012528, 1951595076, 1024851344, 874302782, 1383969588);
            int4x4 r0 = int4x4(-1146363966, 388151458, -1980953046, 2076767601, -1278518109, -1269016260, -468644815, -1959666347, -1429779890, 1464214597, -2028988353, 1704386990, -1124516522, 1725389566, -1718607237, -1122746009);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1534939160, 398651016, 1674272498, 374510467, 824322986, 1217622199, 1122376670, 642613771, 1097903998, 359042741, 929182687, 1713065399, 892057490, 1295346111, 1806236181, 1838589664);
            int4x4 b1 = int4x4(1767968088, 900721406, 1659790033, 1792273749, 443844328, 633981449, 2010244807, 335566991, 521931102, 544297835, 1681549647, 1784248858, 585904415, 3128418, 1806236610, 179909533);
            int4x4 r1 = int4x4(-992060048, 1299372422, -960904765, -2128183080, 1268167314, 1851603648, -1162345819, 978180762, 1619835100, 903340576, -1684234962, -797653039, 1477961905, 1298474529, -682494505, 2018499197);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(173985173, 1875814528, 1464015613, 1550659036, 447183339, 1810477200, 1280783968, 460635858, 1308981305, 2074430993, 515260041, 454786901, 54902689, 8663916, 364443922, 2133521215);
            int4x4 b2 = int4x4(378711407, 195687764, 357131656, 383703567, 1332107956, 1471212095, 1634876660, 1356094538, 364971231, 1180126175, 1243953864, 2000873160, 761885805, 1088368083, 371382049, 1165570023);
            int4x4 r2 = int4x4(552696580, 2071502292, 1821147269, 1934362603, 1779291295, -1013278001, -1379306668, 1816730396, 1673952536, -1040410128, 1759213905, -1839307235, 816788494, 1097031999, 735825971, -995876058);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(752738311, 459996276, 134430279, 1019035025, 1118755713, 97114496, 2018556094, 503464890, 125268557, 841630760, 1879289264, 1812133139, 2071408153, 140785075, 348467740, 19259645);
            int4x4 b3 = int4x4(1037712666, 743665263, 446926007, 740772342, 2122822821, 1744558378, 241853304, 1404664477, 2086735220, 1441264950, 658463489, 1077514956, 2022425015, 702129808, 462290953, 75801290);
            int4x4 r3 = int4x4(1790450977, 1203661539, 581356286, 1759807367, -1053388762, 1841672874, -2034557898, 1908129367, -2082963519, -2012071586, -1757214543, -1405319201, -201134128, 842914883, 810758693, 95060935);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_add_wide_scalar()
        {
            int4x4 a0 = int4x4(665815972, 1783729250, 1591678394, 1284528538, 977850224, 71069732, 1138577680, 1200356017, 565982008, 1246759684, 1088001167, 57252642, 678921480, 625943813, 512157429, 1470648741);
            int b0 = (1334043849);
            int4x4 r0 = int4x4(1999859821, -1177194197, -1369245053, -1676394909, -1983073223, 1405113581, -1822345767, -1760567430, 1900025857, -1714163763, -1872922280, 1391296491, 2012965329, 1959987662, 1846201278, -1490274706);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1490096953, 182608093, 1707296407, 1703724354, 1333833947, 653973063, 1139546735, 1834005844, 184572739, 1980578280, 1858520040, 97099208, 421437295, 1251829854, 166844260, 1568146789);
            int b1 = (1467033531);
            int4x4 r1 = int4x4(-1337836812, 1649641624, -1120637358, -1124209411, -1494099818, 2121006594, -1688387030, -993927921, 1651606270, -847355485, -969413725, 1564132739, 1888470826, -1576103911, 1633877791, -1259786976);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(82548613, 1464065228, 716600557, 831997894, 861575416, 1614335536, 1590793088, 240051362, 656307111, 1116911778, 1508531454, 1488841996, 651080626, 850104335, 697550029, 1501177275);
            int b2 = (533562157);
            int4x4 r2 = int4x4(616110770, 1997627385, 1250162714, 1365560051, 1395137573, -2147069603, 2124355245, 773613519, 1189869268, 1650473935, 2042093611, 2022404153, 1184642783, 1383666492, 1231112186, 2034739432);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(308656842, 1236049353, 1462299846, 1109575265, 209902, 1129756187, 452131659, 1598006341, 793277485, 237975099, 1427541287, 1103256809, 144544713, 2142413477, 921156907, 636589500);
            int b3 = (1397806846);
            int4x4 r3 = int4x4(1706463688, -1661111097, -1434860604, -1787585185, 1398016748, -1767404263, 1849938505, -1299154109, -2103882965, 1635781945, -1469619163, -1793903641, 1542351559, -754746973, -1976003543, 2034396346);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_add_scalar_wide()
        {
            int a0 = (359966320);
            int4x4 b0 = int4x4(2146146202, 767103309, 851002415, 311531406, 1491262941, 1016891373, 1954228994, 1671335850, 727870747, 551151834, 1390261152, 1699060326, 115021619, 1964440175, 440700758, 1556692550);
            int4x4 r0 = int4x4(-1788854774, 1127069629, 1210968735, 671497726, 1851229261, 1376857693, -1980771982, 2031302170, 1087837067, 911118154, 1750227472, 2059026646, 474987939, -1970560801, 800667078, 1916658870);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (185414255);
            int4x4 b1 = int4x4(933106731, 1217866784, 729761881, 1742597318, 1090109152, 1467373815, 1066072609, 138237856, 634834665, 993603553, 347587889, 2050191349, 670698672, 1658205080, 1874808705, 2082982954);
            int4x4 r1 = int4x4(1118520986, 1403281039, 915176136, 1928011573, 1275523407, 1652788070, 1251486864, 323652111, 820248920, 1179017808, 533002144, -2059361692, 856112927, 1843619335, 2060222960, -2026570087);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (869839589);
            int4x4 b2 = int4x4(118460267, 2126166073, 1826004041, 1976984739, 1612682951, 1509218893, 283188530, 175981795, 290469072, 90401332, 92990995, 1697612984, 10695923, 584353656, 1985077669, 261483046);
            int4x4 r2 = int4x4(988299856, -1298961634, -1599123666, -1448142968, -1812444756, -1915908814, 1153028119, 1045821384, 1160308661, 960240921, 962830584, -1727514723, 880535512, 1454193245, -1440050038, 1131322635);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1433592717);
            int4x4 b3 = int4x4(1587664734, 1494226579, 1815078437, 764852649, 1056037050, 1447213141, 1932413453, 173293550, 856428276, 23287820, 1606641105, 1768628148, 57172075, 1040430401, 1662936094, 1763561019);
            int4x4 r3 = int4x4(-1273709845, -1367148000, -1046296142, -2096521930, -1805337529, -1414161438, -928961126, 1606886267, -2004946303, 1456880537, -1254733474, -1092746431, 1490764792, -1820944178, -1198438485, -1097813560);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_sub_wide_wide()
        {
            int4x4 a0 = int4x4(1410318491, 1097280168, 1827039044, 28881338, 328720965, 875487868, 212936325, 231977215, 1740021315, 2011295463, 48079003, 591379285, 1125909359, 1842588095, 848561896, 614448464);
            int4x4 b0 = int4x4(1315897366, 799052018, 1580289673, 1094686261, 1954325726, 1197734816, 229886366, 915679176, 1746884850, 918743925, 1007797419, 257421324, 287249342, 1617287463, 1653916102, 123586847);
            int4x4 r0 = int4x4(94421125, 298228150, 246749371, -1065804923, -1625604761, -322246948, -16950041, -683701961, -6863535, 1092551538, -959718416, 333957961, 838660017, 225300632, -805354206, 490861617);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(2067598029, 1618238416, 318516219, 1090119767, 1991095823, 949592162, 1951912339, 1457818751, 1642553126, 2114366549, 1420516260, 596841760, 724518081, 1820626306, 1885185225, 246124365);
            int4x4 b1 = int4x4(502107404, 672875302, 1256481116, 1975569142, 1794443030, 1327558915, 330955394, 1596041731, 1069074732, 1120817099, 2076417364, 402521072, 839858844, 1539789702, 559077522, 822288510);
            int4x4 r1 = int4x4(1565490625, 945363114, -937964897, -885449375, 196652793, -377966753, 1620956945, -138222980, 573478394, 993549450, -655901104, 194320688, -115340763, 280836604, 1326107703, -576164145);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(1339877262, 1277620434, 759131597, 597162957, 656765083, 1075131749, 58205257, 452992632, 976914238, 2122217984, 1687033200, 850554234, 2052749291, 2095840868, 1583338457, 90383917);
            int4x4 b2 = int4x4(751901021, 1858312568, 1706585560, 483540199, 35726321, 401119620, 1411304017, 794953965, 246546364, 1926970811, 1641115012, 2138664312, 1215717344, 1626141022, 1697813712, 1432018301);
            int4x4 r2 = int4x4(587976241, -580692134, -947453963, 113622758, 621038762, 674012129, -1353098760, -341961333, 730367874, 195247173, 45918188, -1288110078, 837031947, 469699846, -114475255, -1341634384);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(1548318665, 2135165300, 1200818607, 836910134, 471911775, 464052016, 1001285615, 344315815, 386866212, 562875464, 584343185, 1282738957, 2048830434, 1953046924, 1758228339, 1047685389);
            int4x4 b3 = int4x4(127303652, 1200011318, 1746989830, 2083451213, 1630826350, 1384789939, 195722140, 1460697711, 1025672341, 1638638861, 466637201, 1846245897, 1286439769, 1690897900, 1118505582, 1106435018);
            int4x4 r3 = int4x4(1421015013, 935153982, -546171223, -1246541079, -1158914575, -920737923, 805563475, -1116381896, -638806129, -1075763397, 117705984, -563506940, 762390665, 262149024, 639722757, -58749629);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_sub_wide_scalar()
        {
            int4x4 a0 = int4x4(1508669340, 1594795463, 266707545, 643102647, 287705008, 1475644328, 1113286221, 979450511, 2082174113, 1108005498, 304369206, 999244508, 1806482044, 1994553647, 2101812429, 1482736902);
            int b0 = (998008471);
            int4x4 r0 = int4x4(510660869, 596786992, -731300926, -354905824, -710303463, 477635857, 115277750, -18557960, 1084165642, 109997027, -693639265, 1236037, 808473573, 996545176, 1103803958, 484728431);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(266654115, 1190349300, 958542155, 1185075537, 1738124835, 499527536, 1612473406, 1696960099, 1287292743, 1360229454, 1032360376, 1779621585, 964948785, 1739264125, 94254551, 968533883);
            int b1 = (1470212363);
            int4x4 r1 = int4x4(-1203558248, -279863063, -511670208, -285136826, 267912472, -970684827, 142261043, 226747736, -182919620, -109982909, -437851987, 309409222, -505263578, 269051762, -1375957812, -501678480);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(2075770560, 1074604044, 1171596880, 1033389665, 1905912138, 1219683758, 372717946, 658343960, 572101777, 361378660, 1043302867, 1535109165, 695707807, 153321516, 1464557635, 308141270);
            int b2 = (946189008);
            int4x4 r2 = int4x4(1129581552, 128415036, 225407872, 87200657, 959723130, 273494750, -573471062, -287845048, -374087231, -584810348, 97113859, 588920157, -250481201, -792867492, 518368627, -638047738);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(69622833, 1194454863, 1717370179, 323593803, 1407367283, 1095267927, 801717786, 1093626195, 1147895912, 115414874, 80925845, 1347312573, 1117225328, 1516225020, 210114655, 30710625);
            int b3 = (668515891);
            int4x4 r3 = int4x4(-598893058, 525938972, 1048854288, -344922088, 738851392, 426752036, 133201895, 425110304, 479380021, -553101017, -587590046, 678796682, 448709437, 847709129, -458401236, -637805266);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_sub_scalar_wide()
        {
            int a0 = (893369501);
            int4x4 b0 = int4x4(2051906184, 1699714311, 442603706, 1735141684, 274533585, 811580259, 1196354320, 1524097023, 533621527, 2080845793, 143958837, 1620668660, 1135989346, 1367044745, 554088609, 552670373);
            int4x4 r0 = int4x4(-1158536683, -806344810, 450765795, -841772183, 618835916, 81789242, -302984819, -630727522, 359747974, -1187476292, 749410664, -727299159, -242619845, -473675244, 339280892, 340699128);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1265516124);
            int4x4 b1 = int4x4(1254902543, 1857695581, 1619865274, 1313559400, 99812999, 843597298, 420111239, 1299949060, 531009038, 1103306550, 104920105, 1137308312, 1207332725, 103438360, 1157123503, 1174401240);
            int4x4 r1 = int4x4(10613581, -592179457, -354349150, -48043276, 1165703125, 421918826, 845404885, -34432936, 734507086, 162209574, 1160596019, 128207812, 58183399, 1162077764, 108392621, 91114884);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (701247193);
            int4x4 b2 = int4x4(1498366995, 467017290, 109208355, 1594646461, 1252691221, 919863765, 2826939, 1969148647, 1576198850, 2075870798, 1610641273, 1783880129, 59074246, 1766624573, 521313783, 1333637752);
            int4x4 r2 = int4x4(-797119802, 234229903, 592038838, -893399268, -551444028, -218616572, 698420254, -1267901454, -874951657, -1374623605, -909394080, -1082632936, 642172947, -1065377380, 179933410, -632390559);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (509364704);
            int4x4 b3 = int4x4(516658115, 2089980466, 436174846, 1727293748, 1952093185, 856117013, 22492467, 435192624, 1891008194, 1855757356, 1091434215, 386788711, 1473772449, 1977407433, 1134318981, 446267420);
            int4x4 r3 = int4x4(-7293411, -1580615762, 73189858, -1217929044, -1442728481, -346752309, 486872237, 74172080, -1381643490, -1346392652, -582069511, 122575993, -964407745, -1468042729, -624954277, 63097284);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mul_wide_wide()
        {
            int4x4 a0 = int4x4(61417577, 219585476, 1362520891, 1511084277, 1481211272, 58211871, 1459591173, 567624644, 1169935583, 1835691886, 385626539, 85934842, 522856538, 278370196, 289217012, 2083410174);
            int4x4 b0 = int4x4(578042444, 1620527213, 200516468, 309339115, 542853019, 299467282, 1479641221, 1428338601, 1497302909, 1596889147, 427413842, 265122693, 689376654, 1120457204, 516903000, 873091659);
            int4x4 r0 = int4x4(-1426863828, 1326150260, -990894148, -1322856473, 1973926232, 88546350, -863919463, -582821788, 556671459, 1098186330, 1848083398, -58320414, 2005201900, 651971856, -1721160736, -110160278);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(1293162798, 1939730122, 2075923048, 1116477212, 1686101741, 783310758, 248585944, 1093377716, 797038788, 1838048120, 1892922904, 1952024781, 492107602, 1097670675, 2069629919, 20122103);
            int4x4 b1 = int4x4(1353196495, 1384773500, 1596528529, 2122329305, 1033200564, 996795088, 1137754930, 232014195, 1080950243, 1613216909, 463529448, 1781487382, 2101946430, 673144237, 390627073, 964308272);
            int4x4 r1 = int4x4(-119429582, -536965160, -2049587992, -759667012, 1443849636, 550781664, -959017424, -353108260, -1093604916, 264300824, -121602624, 1825729694, -241519140, -1246587945, -2064143137, -251115184);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(606926492, 1153788131, 1687394746, 1499899200, 380825697, 2058271053, 1791586731, 16536749, 1743482585, 323418416, 826338527, 1127652402, 1548655361, 892665898, 498857854, 52699386);
            int4x4 b2 = int4x4(1332603859, 106394678, 1330334791, 1720890701, 1860846228, 1499909622, 1236623401, 1532585255, 46356001, 1355750416, 470193265, 829633350, 158242740, 2121460265, 443332975, 1295474668);
            int4x4 r2 = int4x4(1004304020, -330302494, 638638742, 892728384, -1474954732, 1744222462, -976595869, -1560402085, -1646186503, 1971376896, 936606319, -24990804, -400518220, -1235785030, -276669022, -1790890888);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(1013078461, 389868596, 2131450446, 692103096, 1728534690, 1232391212, 552742042, 2137384298, 2085409681, 1077145299, 67208657, 137969745, 204951457, 705222964, 437668893, 1222032847);
            int4x4 b3 = int4x4(1966486133, 1063465732, 986983038, 1614187644, 117157419, 32076676, 452115159, 1402967848, 1712569067, 2023273918, 811855334, 136733227, 324154781, 1529152006, 1525922582, 2084976369);
            int4x4 r3 = int4x4(492301665, -1541534512, -654360988, -1210458848, -11534538, 1476201136, 1834965334, -585933168, 1711312923, 330198938, -233589050, 1614991259, 1710893757, -294944968, -116737666, 147610079);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mul_wide_scalar()
        {
            int4x4 a0 = int4x4(871746615, 492532311, 570557670, 2142306629, 1610315153, 1526163563, 118471734, 257439514, 364291059, 1186560810, 1584938026, 1357601203, 638897141, 268562104, 1007838321, 1163240135);
            int b0 = (442064533);
            int4x4 r0 = int4x4(338365955, 1081376419, -1729147426, -1015409879, -873485467, -175501241, -838181010, 513646114, 1627104879, 1523063666, 1353478258, -517607633, -1758745703, -1262517992, 484373445, -1714696237);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(1619806399, 1127580168, 464517916, 1508043166, 745488654, 636691139, 1851670006, 357357967, 1095280227, 702779195, 945802744, 1464398841, 51061000, 802418971, 407442471, 638315697);
            int b1 = (1444659979);
            int4x4 r1 = int4x4(-678060747, 204516952, 550116916, 1818059722, 936342938, 25036641, -1271854190, 1880770085, -213020863, 270145673, 1865007528, -1287903565, -948206760, -23335639, -275082579, 611909275);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(1889264235, 1343048690, 2144106255, 1634890111, 425282134, 997231492, 676185747, 1562817045, 379402138, 866868743, 624571724, 889442510, 39498317, 219559094, 211033504, 2076045580);
            int b2 = (584402164);
            int4x4 r2 = int4x4(1438595580, 691186344, 737965644, -1813714676, 644329976, 690489808, -785428452, 94916612, 130016968, -299730260, 1642003568, -1568687016, -371235484, 1721275768, 992656512, -1945309328);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(1838674974, 680562697, 469850888, 1511187096, 1844059526, 2003324819, 866371311, 1784948662, 515034926, 823384368, 1320152637, 940524320, 313230059, 384141839, 1177495555, 719285506);
            int b3 = (1056841954);
            int4x4 r3 = int4x4(946684540, -124893198, 646143248, -2083583440, 189976652, 31629254, 1385529086, -336212308, 660907676, -330580896, -1684147750, -1080212928, -1158614154, -2067283650, 1201386150, 1792703428);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mul_scalar_wide()
        {
            int a0 = (1152242766);
            int4x4 b0 = int4x4(1276636134, 2105929407, 499007702, 124002565, 1956335172, 1288034953, 832676555, 337389733, 99268757, 2005055247, 2011389505, 1348110859, 399689191, 2007606374, 2076691289, 1825721194);
            int4x4 r0 = int4x4(-2129504236, 999811634, 1179056436, -801426554, 404105400, 1339492798, -381766182, -1111620026, 2131796326, 1519334034, -952005682, -1420416166, -415852446, 583175956, 980068638, 1831387724);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (769885235);
            int4x4 b1 = int4x4(153314735, 1066325369, 84289667, 984486192, 1325213504, 1643957457, 1576395620, 2095980601, 907671947, 836919582, 1412159342, 2037926630, 366590562, 493177763, 2058824164, 497936968);
            int4x4 r1 = int4x4(-5734947, -556668133, 541498905, 521809040, 1382797760, 961253795, -1226318612, 1134088027, -518430031, 231133434, -1134910742, 294093778, 492874118, -826860167, 490924140, -62206888);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (2136548816);
            int4x4 b2 = int4x4(1211907591, 2113626509, 345443734, 353147704, 688487056, 2038986981, 1991273614, 393095943, 838257274, 1646548338, 480051387, 1077685034, 421911953, 1757438926, 1584698689, 1237695787);
            int4x4 r2 = int4x4(1868064944, -1906465904, -1294485536, -1423624832, -1032166144, 452481808, 510048608, 1680472240, 775038240, 1082189472, -156328208, -1162206176, -567084336, -816063136, -1159419440, -1644959248);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (426426495);
            int4x4 b3 = int4x4(272190940, 792362979, 710924244, 167756574, 2098906277, 461971950, 1070095729, 175505611, 1048663225, 451115371, 1568000860, 446946750, 1880161842, 1511877484, 2100048988, 850173891);
            int4x4 r3 = int4x4(-1075142620, 1827516829, -114093524, -2136716318, -1391112741, -855223022, -1538974961, -667900747, 659408839, -1422427115, -435363164, 2084929858, 2043124430, -874427756, -364185180, -852262467);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_div_wide_wide()
        {
            int4x4 a0 = int4x4(333171510, 858154903, 1181365836, 671357749, 1090606752, 803759420, 788404166, 296807814, 575260195, 166625280, 1493729000, 1831739736, 200852358, 129983172, 500176108, 472051781);
            int4x4 b0 = int4x4(698897823, 440199998, 655557473, 1658534285, 2127220100, 315653188, 1814290360, 992173243, 914851653, 664340325, 224323977, 246981573, 285573983, 819471609, 2012476015, 1783179572);
            int4x4 r0 = int4x4(0, 1, 1, 0, 0, 2, 0, 0, 0, 0, 6, 7, 0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(414699094, 1446535974, 1278480457, 930910505, 263295881, 1626759436, 450830871, 21439121, 521337599, 127756712, 200601965, 412554396, 1014641734, 239347640, 525574301, 1158358177);
            int4x4 b1 = int4x4(223253978, 169515029, 1694929006, 1992168131, 1155972447, 1768506696, 422325410, 1508417406, 605462475, 66917170, 2014683461, 108847533, 611173330, 895791853, 1999369787, 1225614384);
            int4x4 r1 = int4x4(1, 8, 0, 0, 0, 0, 1, 0, 0, 1, 0, 3, 1, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(1655168319, 2048437741, 367754386, 1861176433, 2131424795, 401044444, 745048188, 1943634349, 264134862, 298134010, 1884719303, 1582577607, 1958183229, 1302356942, 1455581366, 1466593830);
            int4x4 b2 = int4x4(1168063495, 565150188, 127292785, 1027814836, 321940796, 337756553, 63233040, 1926010595, 769049413, 2042197280, 405134611, 547499280, 1337688441, 667307127, 35118652, 411409741);
            int4x4 r2 = int4x4(1, 3, 2, 1, 6, 1, 11, 1, 0, 0, 4, 2, 1, 1, 41, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(2145097917, 113338377, 521371316, 1140663020, 891769689, 82976022, 1613639017, 1511282992, 815022628, 631656991, 1701235777, 1488378728, 1732969535, 754450606, 972419490, 1719717117);
            int4x4 b3 = int4x4(401145052, 1430251023, 1603772580, 394044814, 1247425523, 2026144816, 74797843, 951408694, 460820692, 1904008535, 1263644544, 1250033708, 1500938461, 1177549592, 1193869306, 2096306143);
            int4x4 r3 = int4x4(5, 0, 0, 2, 0, 0, 21, 1, 1, 0, 1, 1, 1, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_div_wide_scalar()
        {
            int4x4 a0 = int4x4(1433072926, 1073958635, 1195142312, 536596719, 1274375693, 464756346, 806462546, 906504670, 1380905136, 25493909, 1196815948, 123300377, 643754735, 2084019932, 2047825037, 458304263);
            int b0 = (1434025872);
            int4x4 r0 = int4x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(741331531, 2110004616, 1500687214, 1453264263, 1617154145, 2040203220, 2103351724, 485536709, 402141749, 1477264254, 1629069474, 1549487015, 670594363, 2040479674, 155415284, 207130003);
            int b1 = (466443901);
            int4x4 r1 = int4x4(1, 4, 3, 3, 3, 4, 4, 1, 0, 3, 3, 3, 1, 4, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(1596922206, 1528374182, 1878500631, 1245757182, 1471308702, 1733304186, 251821475, 1328085649, 1950145317, 794269329, 174603836, 678361822, 1820872200, 1455358409, 778273070, 2067965131);
            int b2 = (1730223836);
            int4x4 r2 = int4x4(0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(127176068, 610271655, 2044746707, 2127292310, 1964355374, 1181239062, 1239274235, 51060010, 872233944, 1134975739, 1324876719, 1504501302, 710310773, 132497882, 1041400664, 2063654021);
            int b3 = (1891892641);
            int4x4 r3 = int4x4(0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_div_scalar_wide()
        {
            int a0 = (519165704);
            int4x4 b0 = int4x4(1295178177, 775214121, 467772046, 1156881598, 310396565, 759759959, 243837702, 1616314235, 1053470225, 1320630160, 378773841, 4223608, 1971105754, 2054406020, 219939614, 1603672651);
            int4x4 r0 = int4x4(0, 0, 1, 0, 1, 0, 2, 0, 0, 0, 1, 122, 0, 0, 2, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (2006134295);
            int4x4 b1 = int4x4(888535397, 1493077923, 615835131, 1045603945, 452709946, 1074919059, 467037221, 1485241506, 1775728786, 481521341, 68149923, 80867357, 1294049272, 470535313, 1235850199, 631464286);
            int4x4 r1 = int4x4(2, 1, 3, 1, 4, 1, 4, 1, 1, 4, 29, 24, 1, 4, 1, 3);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (687722755);
            int4x4 b2 = int4x4(412827650, 1258012095, 1286792622, 1799223034, 766890491, 2080374598, 711612151, 700420132, 1832408481, 1806438353, 237636410, 562498090, 1695805237, 2075783388, 2094216740, 1612536340);
            int4x4 r2 = int4x4(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (885282904);
            int4x4 b3 = int4x4(762931601, 1888184154, 1235090956, 1621045406, 842468231, 1847778709, 734825, 1819123739, 682151426, 278238618, 175687779, 1535446878, 1906904600, 850094847, 1290407289, 1520242969);
            int4x4 r3 = int4x4(1, 0, 0, 0, 1, 0, 1204, 0, 1, 3, 5, 0, 0, 1, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mod_wide_wide()
        {
            int4x4 a0 = int4x4(258342924, 1454754891, 723352342, 1981431473, 531756042, 716993627, 1667903349, 1331097004, 1776856101, 17598216, 1474345080, 1681376293, 813624265, 1617478722, 498370451, 780075943);
            int4x4 b0 = int4x4(1990080167, 1197348066, 651970512, 1659454050, 241005212, 1866255454, 1440101415, 595220963, 408818410, 198222574, 549504274, 239973807, 321398087, 658171840, 1511495237, 1048325585);
            int4x4 r0 = int4x4(258342924, 257406825, 71381830, 321977423, 49745618, 716993627, 227801934, 140655078, 141582461, 17598216, 375336532, 1559644, 170828091, 301135042, 498370451, 780075943);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(1754430321, 653235398, 1517128354, 966216200, 590067427, 1283434795, 1910903650, 1125967790, 1180537254, 308567230, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599);
            int4x4 b1 = int4x4(1126739824, 666641241, 38017598, 418797691, 618700513, 1941062990, 158556432, 1081063558, 427329468, 148111230, 1251162672, 1856322297, 1214781084, 401954255, 1323259633, 1167744452);
            int4x4 r1 = int4x4(627690497, 653235398, 34442032, 128620818, 590067427, 1283434795, 8226466, 44904232, 325878318, 12344770, 543945394, 483834400, 308703874, 383723801, 1181975437, 1161083599);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1608412916, 111825133, 786866017, 1225576256, 1590085857, 1755638794, 1413553126, 476553804, 1342913944, 1625118233, 1202928007, 504380191, 642905424, 357937367, 1801777444, 1384305901);
            int4x4 b2 = int4x4(1816151689, 541163525, 664455763, 1738838503, 1746284172, 855644567, 1887796950, 655067833, 536415164, 71040983, 631964713, 503267649, 944396748, 302347270, 564261945, 1414291441);
            int4x4 r2 = int4x4(1608412916, 111825133, 122410254, 1225576256, 1590085857, 44349660, 1413553126, 476553804, 270083616, 62216607, 570963294, 1112542, 642905424, 55590097, 108991609, 1384305901);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(1605100561, 332650074, 46731299, 294197541, 1349236859, 705509020, 1643007525, 442769171, 738227280, 1206523958, 1845625047, 2112300092, 1311771498, 2045741748, 306518396, 2084544706);
            int4x4 b3 = int4x4(115690343, 94751961, 584804265, 516081491, 717212374, 945144869, 1775673480, 568390571, 1876139615, 645560273, 1090042616, 976448203, 1756041131, 1989952916, 923228986, 1025823912);
            int4x4 r3 = int4x4(101126102, 48394191, 46731299, 294197541, 632024485, 705509020, 1643007525, 442769171, 738227280, 560963685, 755582431, 159403686, 1311771498, 55788832, 306518396, 32896882);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mod_wide_scalar()
        {
            int4x4 a0 = int4x4(560988938, 629524514, 767711194, 434281967, 1399805893, 792916846, 1663690927, 598661916, 1776636144, 1287035793, 1743722161, 475209785, 327476870, 1617696916, 379853074, 477430114);
            int b0 = (1156862367);
            int4x4 r0 = int4x4(560988938, 629524514, 767711194, 434281967, 242943526, 792916846, 506828560, 598661916, 619773777, 130173426, 586859794, 475209785, 327476870, 460834549, 379853074, 477430114);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(858399046, 1506629323, 199829950, 362269020, 1986626876, 1351725413, 1549678101, 431765276, 1315833792, 1664893153, 615834034, 780055604, 104179235, 629966219, 1810536428, 1747026206);
            int b1 = (712734431);
            int4x4 r1 = int4x4(145664615, 81160461, 199829950, 362269020, 561158014, 638990982, 124209239, 431765276, 603099361, 239424291, 615834034, 67321173, 104179235, 629966219, 385067566, 321557344);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1799535061, 2049775667, 303673867, 93301056, 1944511005, 2135291183, 1065919801, 1342701312, 1356734788, 1593032231, 475449806, 1983416442, 776300612, 591854273, 2061957684, 1865797266);
            int b2 = (875754431);
            int4x4 r2 = int4x4(48026199, 298266805, 303673867, 93301056, 193002143, 383782321, 190165370, 466946881, 480980357, 717277800, 475449806, 231907580, 776300612, 591854273, 310448822, 114288404);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(1982663429, 374639153, 1919268329, 198719918, 1317719138, 1425282748, 1365516740, 2516691, 83972101, 1275507340, 1047856893, 1966089959, 1672456909, 657069574, 2080669380, 875667226);
            int b3 = (865181949);
            int4x4 r3 = int4x4(252299531, 374639153, 188904431, 198719918, 452537189, 560100799, 500334791, 2516691, 83972101, 410325391, 182674944, 235726061, 807274960, 657069574, 350305482, 10485277);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_mod_scalar_wide()
        {
            int a0 = (933347930);
            int4x4 b0 = int4x4(549923387, 243114953, 1884274390, 1428033594, 655531454, 1622674954, 1107563514, 1614111094, 914801920, 1432263179, 564431096, 1967013901, 1709750152, 1080102613, 13120773, 2042535998);
            int4x4 r0 = int4x4(383424543, 204003071, 933347930, 933347930, 277816476, 933347930, 933347930, 933347930, 18546010, 933347930, 368916834, 933347930, 933347930, 933347930, 1773047, 933347930);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1505698002);
            int4x4 b1 = int4x4(1640058084, 974167554, 758635306, 1387264978, 611743343, 1139002766, 1913935748, 1086810076, 991846486, 922870408, 35007468, 891877602, 157349181, 83267982, 801093706, 546272767);
            int4x4 r1 = int4x4(1505698002, 531530448, 747062696, 118433024, 282211316, 366695236, 1505698002, 418887926, 513851516, 582827594, 376878, 613820400, 89555373, 6874326, 704604296, 413152468);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1665089132);
            int4x4 b2 = int4x4(1889242068, 1179889796, 1690033703, 1333252321, 1960636489, 960755248, 698650125, 313994074, 1830992514, 2049496523, 507742240, 739436968, 1012724736, 2089810815, 329356442, 384427687);
            int4x4 r2 = int4x4(1665089132, 485199336, 1665089132, 331836811, 1665089132, 704333884, 267788882, 95118762, 1665089132, 1665089132, 141862412, 186215196, 652364396, 1665089132, 18306922, 127378384);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (713578570);
            int4x4 b3 = int4x4(443562339, 938288481, 1912612259, 1693566599, 2085663691, 1251595834, 2117822289, 341223518, 1811168615, 699804546, 1072556046, 722233492, 757452739, 1348995197, 1910821037, 1420741134);
            int4x4 r3 = int4x4(270016231, 713578570, 713578570, 713578570, 713578570, 713578570, 713578570, 31131534, 713578570, 13774024, 713578570, 713578570, 713578570, 713578570, 713578570, 713578570);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_plus()
        {
            int4x4 a0 = int4x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671, 1084131995, 195779102, 2131702223, 715660442, 1995564647, 69731564, 1317851903);
            int4x4 r0 = int4x4(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671, 1084131995, 195779102, 2131702223, 715660442, 1995564647, 69731564, 1317851903);
            TestUtils.AreEqual(+a0, r0);

            int4x4 a1 = int4x4(1957501908, 2012985092, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471, 1659000230, 1301861249, 1153431944, 1360657696, 578750954, 150348334, 1791553179, 1288641627);
            int4x4 r1 = int4x4(1957501908, 2012985092, 1334133318, 1539671418, 935436165, 1575048895, 2119066258, 781435471, 1659000230, 1301861249, 1153431944, 1360657696, 578750954, 150348334, 1791553179, 1288641627);
            TestUtils.AreEqual(+a1, r1);

            int4x4 a2 = int4x4(735146513, 1370099515, 1575634098, 36481877, 1832055170, 1043119761, 1370934466, 1126708142, 511229253, 1297664549, 1444401655, 1292097101, 1377029046, 1680766483, 249526091, 656501406);
            int4x4 r2 = int4x4(735146513, 1370099515, 1575634098, 36481877, 1832055170, 1043119761, 1370934466, 1126708142, 511229253, 1297664549, 1444401655, 1292097101, 1377029046, 1680766483, 249526091, 656501406);
            TestUtils.AreEqual(+a2, r2);

            int4x4 a3 = int4x4(195015813, 1562997921, 1927957096, 803204796, 1747288691, 795154500, 1030768402, 789329792, 597872750, 214089028, 536331458, 1078297736, 1832848364, 933783661, 551709570, 843060596);
            int4x4 r3 = int4x4(195015813, 1562997921, 1927957096, 803204796, 1747288691, 795154500, 1030768402, 789329792, 597872750, 214089028, 536331458, 1078297736, 1832848364, 933783661, 551709570, 843060596);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_neg()
        {
            int4x4 a0 = int4x4(1385088677, 94114564, 1350664872, 1458616659, 2067164853, 218122493, 958484951, 270553961, 446497525, 270503114, 1928771252, 1427605822, 2051940607, 1434247484, 485368391, 908365416);
            int4x4 r0 = int4x4(-1385088677, -94114564, -1350664872, -1458616659, -2067164853, -218122493, -958484951, -270553961, -446497525, -270503114, -1928771252, -1427605822, -2051940607, -1434247484, -485368391, -908365416);
            TestUtils.AreEqual(-a0, r0);

            int4x4 a1 = int4x4(1742096480, 1368056141, 1350976157, 12802586, 1934372287, 576597401, 785136322, 559205611, 1959833280, 162379661, 1200036971, 95281343, 1969004480, 1381288239, 252975075, 1961335692);
            int4x4 r1 = int4x4(-1742096480, -1368056141, -1350976157, -12802586, -1934372287, -576597401, -785136322, -559205611, -1959833280, -162379661, -1200036971, -95281343, -1969004480, -1381288239, -252975075, -1961335692);
            TestUtils.AreEqual(-a1, r1);

            int4x4 a2 = int4x4(1607042487, 1300359361, 8438338, 431498011, 1534415387, 2069192669, 866625695, 2105773520, 1249998702, 1704935592, 59004141, 257619538, 392825753, 1868257049, 1472660509, 928823577);
            int4x4 r2 = int4x4(-1607042487, -1300359361, -8438338, -431498011, -1534415387, -2069192669, -866625695, -2105773520, -1249998702, -1704935592, -59004141, -257619538, -392825753, -1868257049, -1472660509, -928823577);
            TestUtils.AreEqual(-a2, r2);

            int4x4 a3 = int4x4(2138036799, 1587572134, 1974711458, 1372286091, 170185840, 1665000810, 565528550, 899411048, 107331573, 55742832, 1905931627, 175272618, 624976692, 1036698522, 1675796177, 1613753777);
            int4x4 r3 = int4x4(-2138036799, -1587572134, -1974711458, -1372286091, -170185840, -1665000810, -565528550, -899411048, -107331573, -55742832, -1905931627, -175272618, -624976692, -1036698522, -1675796177, -1613753777);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_prefix_inc()
        {
            int4x4 a0 = int4x4(780471723, 954741756, 272723451, 2142862245, 606294309, 1514814550, 250124151, 444189162, 1833356994, 1915989169, 1348278302, 129540735, 1584496757, 1170613526, 986715680, 1701179230);
            int4x4 r0 = int4x4(780471724, 954741757, 272723452, 2142862246, 606294310, 1514814551, 250124152, 444189163, 1833356995, 1915989170, 1348278303, 129540736, 1584496758, 1170613527, 986715681, 1701179231);
            TestUtils.AreEqual(++a0, r0);

            int4x4 a1 = int4x4(1397451003, 1494652811, 1268688387, 2014528731, 453850931, 1112537171, 621362788, 2063486914, 1612870531, 1161037742, 1083861484, 1583359796, 82587894, 810087437, 72436569, 1094485773);
            int4x4 r1 = int4x4(1397451004, 1494652812, 1268688388, 2014528732, 453850932, 1112537172, 621362789, 2063486915, 1612870532, 1161037743, 1083861485, 1583359797, 82587895, 810087438, 72436570, 1094485774);
            TestUtils.AreEqual(++a1, r1);

            int4x4 a2 = int4x4(912422931, 261771874, 2042016403, 1102472175, 976635804, 1261156013, 607693651, 1788488571, 1912059986, 420746703, 1703260621, 501684292, 1809882373, 1989306461, 786299198, 1729269500);
            int4x4 r2 = int4x4(912422932, 261771875, 2042016404, 1102472176, 976635805, 1261156014, 607693652, 1788488572, 1912059987, 420746704, 1703260622, 501684293, 1809882374, 1989306462, 786299199, 1729269501);
            TestUtils.AreEqual(++a2, r2);

            int4x4 a3 = int4x4(411043860, 145863296, 877006815, 913426639, 1056275934, 1989688232, 1798844310, 79375331, 1140907425, 353776808, 1313746314, 1008313013, 1750769100, 1105901732, 1275841733, 1182538609);
            int4x4 r3 = int4x4(411043861, 145863297, 877006816, 913426640, 1056275935, 1989688233, 1798844311, 79375332, 1140907426, 353776809, 1313746315, 1008313014, 1750769101, 1105901733, 1275841734, 1182538610);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_postfix_inc()
        {
            int4x4 a0 = int4x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247, 1384002775, 389844650, 1159795446, 1343289659, 1227160199, 947635082, 137930180);
            int4x4 r0 = int4x4(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247, 1384002775, 389844650, 1159795446, 1343289659, 1227160199, 947635082, 137930180);
            TestUtils.AreEqual(a0++, r0);

            int4x4 a1 = int4x4(451018043, 2009552507, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327, 446867079, 2101314783, 1460883320, 1683365096, 1319511974, 1418603655, 1938539756, 592683318);
            int4x4 r1 = int4x4(451018043, 2009552507, 1176922170, 388721494, 2381860, 2062858295, 715101397, 1725384327, 446867079, 2101314783, 1460883320, 1683365096, 1319511974, 1418603655, 1938539756, 592683318);
            TestUtils.AreEqual(a1++, r1);

            int4x4 a2 = int4x4(1576213022, 904484472, 253685095, 70826818, 1423673637, 463104653, 257117856, 964412816, 1148726183, 1820437224, 1087435092, 475319856, 1950385959, 1172607661, 1139700625, 1386106060);
            int4x4 r2 = int4x4(1576213022, 904484472, 253685095, 70826818, 1423673637, 463104653, 257117856, 964412816, 1148726183, 1820437224, 1087435092, 475319856, 1950385959, 1172607661, 1139700625, 1386106060);
            TestUtils.AreEqual(a2++, r2);

            int4x4 a3 = int4x4(612787013, 2015267118, 1005487805, 2000627239, 804783244, 82963346, 881064625, 1225691658, 82684192, 1702936093, 1589647770, 1677781795, 106241273, 2112882767, 598788541, 567112128);
            int4x4 r3 = int4x4(612787013, 2015267118, 1005487805, 2000627239, 804783244, 82963346, 881064625, 1225691658, 82684192, 1702936093, 1589647770, 1677781795, 106241273, 2112882767, 598788541, 567112128);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public void int4x4_operator_prefix_dec()
        {
            int4x4 a0 = int4x4(1331961415, 1612382200, 1401591249, 2042075388, 1757136546, 1895858159, 1467742422, 578341664, 1336115745, 2059077641, 1169239112, 1862369220, 312317355, 1027543764, 1595492535, 1426262619);
            int4x4 r0 = int4x4(1331961414, 1612382199, 1401591248, 2042075387, 1757136545, 1895858158, 1467742421, 578341663, 1336115744, 2059077640, 1169239111, 1862369219, 312317354, 1027543763, 1595492534, 1426262618);
            TestUtils.AreEqual(--a0, r0);

            int4x4 a1 = int4x4(1426620468, 1423852012, 1459529624, 2092317419, 107501474, 1261583506, 512900840, 1496855314, 777588547, 617644613, 1487639376, 625907330, 1452782388, 804650978, 2076275981, 120447533);
            int4x4 r1 = int4x4(1426620467, 1423852011, 1459529623, 2092317418, 107501473, 1261583505, 512900839, 1496855313, 777588546, 617644612, 1487639375, 625907329, 1452782387, 804650977, 2076275980, 120447532);
            TestUtils.AreEqual(--a1, r1);

            int4x4 a2 = int4x4(262357170, 412907314, 846648478, 473291493, 286048219, 890018786, 1237897291, 1412498905, 346348942, 953070054, 2028727932, 2006551142, 1345994403, 1356250542, 1202345509, 497982699);
            int4x4 r2 = int4x4(262357169, 412907313, 846648477, 473291492, 286048218, 890018785, 1237897290, 1412498904, 346348941, 953070053, 2028727931, 2006551141, 1345994402, 1356250541, 1202345508, 497982698);
            TestUtils.AreEqual(--a2, r2);

            int4x4 a3 = int4x4(982734742, 1517311883, 735646686, 1387127643, 1263392561, 350798694, 888690409, 545220074, 979547999, 1278213546, 2127586693, 2099917981, 2030817004, 1254426663, 1240446778, 1741921687);
            int4x4 r3 = int4x4(982734741, 1517311882, 735646685, 1387127642, 1263392560, 350798693, 888690408, 545220073, 979547998, 1278213545, 2127586692, 2099917980, 2030817003, 1254426662, 1240446777, 1741921686);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_postfix_dec()
        {
            int4x4 a0 = int4x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889, 862428933, 1401191870, 2080259851, 653673271, 140452688, 1928164223, 1760916301);
            int4x4 r0 = int4x4(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889, 862428933, 1401191870, 2080259851, 653673271, 140452688, 1928164223, 1760916301);
            TestUtils.AreEqual(a0--, r0);

            int4x4 a1 = int4x4(1174531383, 993137684, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745, 1407678826, 319906934, 1426931482, 488775250, 1681733117, 1916879863, 2060905976, 636358505);
            int4x4 r1 = int4x4(1174531383, 993137684, 1669210509, 874927437, 1393579866, 471308632, 620865961, 220103745, 1407678826, 319906934, 1426931482, 488775250, 1681733117, 1916879863, 2060905976, 636358505);
            TestUtils.AreEqual(a1--, r1);

            int4x4 a2 = int4x4(1379709480, 497925052, 549367303, 925145385, 55306458, 358414755, 18471540, 1907671409, 2010375112, 459674494, 1339288497, 548526029, 2061115550, 1130246689, 681734791, 1169678318);
            int4x4 r2 = int4x4(1379709480, 497925052, 549367303, 925145385, 55306458, 358414755, 18471540, 1907671409, 2010375112, 459674494, 1339288497, 548526029, 2061115550, 1130246689, 681734791, 1169678318);
            TestUtils.AreEqual(a2--, r2);

            int4x4 a3 = int4x4(640772261, 337750282, 880417560, 995078500, 1313900720, 1237226166, 83627499, 242836958, 652914747, 2056321582, 1660799445, 1330003101, 1481004419, 1093032717, 1487769541, 1443901346);
            int4x4 r3 = int4x4(640772261, 337750282, 880417560, 995078500, 1313900720, 1237226166, 83627499, 242836958, 652914747, 2056321582, 1660799445, 1330003101, 1481004419, 1093032717, 1487769541, 1443901346);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_and_wide_wide()
        {
            int4x4 a0 = int4x4(1055241304, 859321394, 1088358961, 2090949513, 300561740, 651904515, 1331035868, 2012752753, 1298126656, 53199569, 1752363533, 1303061302, 1929998247, 1504941434, 470682792, 713577376);
            int4x4 b0 = int4x4(749698416, 748105424, 1842764797, 9990577, 1989102105, 1666634755, 58116798, 868036607, 1420638875, 1308767169, 564040763, 478617502, 806150474, 674015378, 1505309955, 36064977);
            int4x4 r0 = int4x4(749024336, 537928720, 1087769137, 8409473, 277479432, 575816707, 55888540, 867707761, 1141707264, 33686209, 538087433, 209912598, 805855490, 136347666, 403178496, 33571456);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(1493231658, 1340884669, 1577921467, 44846626, 1105094388, 1143008413, 333009589, 2116296009, 2067254825, 121795325, 2122365250, 1088796653, 1594120761, 965590824, 337823363, 1686791432);
            int4x4 b1 = int4x4(1779639327, 808650076, 1634437037, 1997568501, 1930853951, 1901503461, 1508772523, 2010961769, 1495957269, 1914669725, 1263994006, 491200541, 380703892, 282208487, 1416934135, 942735432);
            int4x4 r1 = int4x4(1207967754, 2098204, 1074332585, 33572896, 1091986996, 1073782917, 298320545, 1979979081, 1495420417, 33686173, 1241513986, 4530189, 369102864, 276834336, 337674883, 536870920);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(1275524729, 173403097, 864715776, 1437598787, 1375792249, 203672781, 1568515997, 145607913, 837338112, 754244200, 1383514630, 61183374, 690842674, 1362012962, 668846213, 1659745138);
            int4x4 b2 = int4x4(615839538, 1698880188, 1204102677, 1811173266, 203114715, 1968993229, 1549041488, 421225724, 1641463312, 1122209170, 946391298, 229237652, 849684128, 1197217575, 1910121786, 1835643900);
            int4x4 r2 = int4x4(67434032, 4246168, 58721280, 1102054402, 18521, 67125453, 1549018896, 134825192, 566264832, 14714880, 274776066, 27361668, 539304992, 1091306274, 567803904, 1617539952);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(244062519, 625978732, 1335369426, 1146245993, 58358482, 538877476, 1060321225, 1070168191, 235095979, 1592354022, 662689935, 1706704449, 554656164, 1008037514, 1989573362, 1142327053);
            int4x4 b3 = int4x4(200272981, 1864653698, 417415821, 863152148, 458105706, 1919250535, 1267287071, 45079273, 544365100, 843843698, 564582262, 329133431, 2091649092, 15031648, 240381212, 1613154110);
            int4x4 r3 = int4x4(176949269, 621021440, 142606976, 5373952, 55190082, 537137188, 184615945, 42555497, 148008, 306708578, 556191750, 26881089, 537657348, 347136, 101869584, 1074169612);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_and_wide_scalar()
        {
            int4x4 a0 = int4x4(1513158868, 284695609, 734595037, 1566510707, 1601252476, 84213838, 314333543, 430856908, 753481263, 327392481, 1619794917, 2143619546, 1873208293, 126982769, 651482651, 1383096952);
            int b0 = (1173647397);
            int4x4 r0 = int4x4(1076916228, 15732769, 29360133, 1163132961, 1164976164, 84148228, 11816997, 27545604, 81801253, 25169953, 1082396709, 1170472960, 1168400421, 93327393, 81022977, 1081106464);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(1689107088, 366962092, 1729929586, 989550739, 1914435619, 1592791064, 2047510829, 678485991, 586400261, 771972179, 309059606, 131945492, 1707451796, 394184188, 1943201012, 558008097);
            int b1 = (1368301071);
            int4x4 r1 = int4x4(1082956288, 294519820, 1091338242, 277485571, 1342871555, 1350569992, 1342867469, 40455, 8552965, 138243, 269123590, 25957380, 1099203588, 286163980, 1367507972, 16942593);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(1070093422, 258102213, 1800249857, 922911179, 1719705954, 609219265, 1162961184, 851638827, 889902874, 1622363409, 785352441, 1741477119, 452211039, 1144654389, 641588835, 1574197624);
            int b2 = (34324916);
            int4x4 r2 = int4x4(34095140, 33702276, 34177024, 33718656, 33587488, 770176, 82208, 33734688, 704784, 213264, 34308272, 34128052, 33554708, 655412, 34193440, 16688);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(568430284, 349792636, 1088197642, 523608129, 1406695425, 839388192, 834567855, 888024716, 1014852215, 1459725306, 5273937, 298911416, 1193513114, 2080691940, 1824077552, 1585611449);
            int b3 = (1840697362);
            int4x4 r3 = int4x4(564166656, 76562448, 1083478018, 221544448, 1099976704, 536870912, 565596162, 614858752, 741621778, 1157660690, 1069072, 26214416, 1159893010, 1812254720, 1823477776, 1283620880);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_and_scalar_wide()
        {
            int a0 = (477163326);
            int4x4 b0 = int4x4(110453385, 703240362, 2075630560, 1884904031, 1734899436, 947945203, 1664399051, 458879298, 158491426, 79772356, 2054527944, 202228212, 359225061, 639811396, 1821945318, 1821303024);
            int4x4 r0 = int4x4(68182536, 140544042, 405834528, 273697310, 73426476, 402681394, 3188234, 407953666, 141583138, 71313924, 410028808, 201376052, 341853732, 69250820, 202419494, 201383984);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (2030124055);
            int4x4 b1 = int4x4(1985961756, 579780373, 2061831301, 1139618293, 1145191868, 1121606282, 1414714065, 688688277, 1508875606, 664318814, 2092766410, 1010043618, 599967779, 47076367, 1325716015, 1119912335);
            int4x4 r1 = int4x4(1879120916, 536886293, 2013334533, 1090596885, 1073757204, 1073747970, 1342181393, 687868949, 1493244950, 553660438, 2013336578, 939526146, 553650179, 5127, 1224740871, 1073741831);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (2083412385);
            int4x4 b2 = int4x4(1805692137, 1689798540, 265665838, 1616867488, 244288538, 688929004, 1157047188, 1381359113, 1562107079, 944933664, 1994959125, 1413414673, 1280114143, 1373827711, 1107998701, 890185579);
            int4x4 r2 = int4x4(1746929825, 1680359808, 201595168, 1611550880, 202246144, 671094944, 1143341440, 1342461953, 1544181889, 939657504, 1948780801, 1412323585, 1275877761, 1344426017, 1074401697, 873333025);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (195053206);
            int4x4 b3 = int4x4(1877717925, 2063436477, 878745806, 1485028680, 1112745164, 1729117727, 660916495, 1196215754, 226023830, 283626389, 1719116288, 1596319327, 1706007294, 32695989, 728811929, 1229799524);
            int4x4 r3 = int4x4(195035780, 178258580, 2097286, 142607360, 33555588, 50333206, 52445190, 50349186, 153108630, 10502804, 35652096, 186664470, 27263638, 27281044, 186663056, 151011332);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_or_wide_wide()
        {
            int4x4 a0 = int4x4(1920951869, 1750772852, 1420019191, 732977093, 1169579447, 229437930, 1966721348, 2039812323, 113550869, 1912038362, 1569990624, 1490718227, 1686257697, 2137727522, 1569900650, 856504729);
            int4x4 b0 = int4x4(214585254, 275414367, 858759675, 190211455, 1218691723, 2129565457, 1862809466, 495728846, 868064152, 1756913766, 933656055, 247722084, 1884195075, 1804207631, 1913174711, 1815920856);
            int4x4 r0 = int4x4(2130669503, 2021326207, 2008016383, 737572863, 1303895999, 2146367483, 2134507390, 2107455727, 939376541, 2046780414, 2142664695, 1591475831, 1959708963, 2146117167, 2140863231, 2134768089);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(2033376384, 2086259889, 671790684, 1189001916, 1756048437, 417084592, 2024165808, 966008272, 2031026290, 1461019191, 1071959084, 1645847295, 871350674, 736640317, 868515800, 767794452);
            int4x4 b1 = int4x4(1226577606, 1696467642, 186912044, 1778908130, 1461256625, 1142152181, 272117331, 1162254035, 870448102, 1845053992, 257334526, 987295814, 1503050768, 1683307763, 1076253109, 1403888383);
            int4x4 r1 = int4x4(2034163398, 2103430843, 724483964, 1860172798, 2142973365, 1558183925, 2025750515, 2111217619, 2079325174, 2147314239, 1073143038, 2061103871, 2080374162, 1878867455, 1944485885, 2146418687);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(362186994, 96189073, 1924033224, 1971421809, 1826545883, 865329, 516571463, 371039923, 918186803, 1920664988, 452155520, 743961772, 1728213958, 825116968, 1597755374, 910392330);
            int4x4 b2 = int4x4(561000721, 740143742, 343344681, 2074122472, 133130232, 108733999, 348566046, 1414140366, 975473487, 699452548, 1158934384, 1776041858, 1098964075, 1316223563, 1653177800, 679795328);
            int4x4 r2 = int4x4(905361907, 767539967, 1996451561, 2141297401, 1879042043, 109000255, 516879199, 1449107455, 1052699519, 2080099740, 1609826288, 1843396526, 1736638447, 2139093867, 2143027182, 1053294218);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(693462173, 779965187, 175928258, 1385704458, 1046509940, 18508109, 256469197, 470724351, 1132010845, 765120960, 1303071768, 951732863, 1964522596, 1159413431, 1665711360, 476367098);
            int4x4 b3 = int4x4(1160679856, 1463165087, 225864530, 1687681609, 1534380366, 938828852, 1537113296, 522784628, 1469983598, 2040525960, 68341904, 1350736257, 467630862, 825069149, 655198246, 173368083);
            int4x4 r3 = int4x4(1837102525, 2139059103, 259947474, 1990196811, 2138372478, 939486589, 1608482013, 523218943, 1476345727, 2107635144, 1304157336, 2025511935, 2145353582, 1967111935, 1733147942, 511044603);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_or_wide_scalar()
        {
            int4x4 a0 = int4x4(1295304853, 1307252624, 350194630, 1128063578, 1774824542, 2085245467, 1988423804, 999162350, 2110327307, 1050875188, 341855232, 1317039676, 228656898, 41280811, 1536908787, 606786773);
            int b0 = (1305527136);
            int4x4 r0 = int4x4(1307888629, 1308350448, 1574947814, 1341973370, 1842999166, 2111492987, 2144662396, 2145305582, 2111425387, 2146686836, 1576062816, 1339092860, 1307690850, 1341515627, 1608245235, 1845155829);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(1739461580, 1350320187, 1377874553, 1522262112, 1496806239, 1732466858, 1535976093, 375675620, 1614193383, 226059393, 697385997, 112556963, 1614163749, 1583289054, 1370656810, 1286074530);
            int b1 = (2040936581);
            int4x4 r1 = int4x4(2142125005, 2046720191, 2074524413, 2076178661, 2042067935, 2145876143, 2075081373, 2145811173, 2042018535, 2113895557, 2042068109, 2142731175, 2041986981, 2147433183, 2042017967, 2108160167);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(1155438844, 440002979, 1569359727, 5393691, 774282482, 1217128427, 212144562, 1525899482, 463019249, 1531812233, 1944160603, 953179348, 1692078056, 1331652826, 183129856, 1305664018);
            int b2 = (1835671387);
            int4x4 r2 = int4x4(1845403647, 2138832891, 2112528255, 1836736347, 1869520891, 1844183035, 1844387835, 2147188699, 2147164155, 2138021851, 2146148187, 2113560543, 1845174267, 1870626779, 1877630811, 1845157723);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(626899632, 2094300112, 1737365603, 1920526388, 1956204544, 1722269413, 961702184, 752387958, 160631159, 1859186074, 1291037807, 886605387, 496163558, 1615069781, 1118682069, 30965146);
            int b3 = (1403426207);
            int4x4 r3 = int4x4(2013249471, 2146893791, 2007932415, 1946090943, 2009060767, 2007482367, 2079784383, 2147391487, 1538760191, 2146893215, 1610071551, 2013173727, 1605820415, 1944491999, 1404026847, 1409219999);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1768627592);
            int4x4 b0 = int4x4(1849658052, 1759912154, 729979455, 975926310, 1987690876, 1809506714, 1160695341, 408963395, 314072711, 1560007537, 1709003416, 977086639, 1448375596, 1689568808, 595543345, 559778387);
            int4x4 r0 = int4x4(1870634956, 1777286618, 1810603967, 2070642094, 2138824188, 1811676570, 1836048301, 2037079499, 2080071567, 2113658873, 1845452696, 2071936431, 2139061676, 1845485480, 1803509177, 1769971675);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (621080913);
            int4x4 b1 = int4x4(438994183, 1742637145, 1219409263, 1602932494, 1204461702, 2111538444, 836730895, 1207638621, 802100209, 1089077339, 1315030334, 249047666, 1604790897, 1848168086, 347254235, 1777613639);
            int4x4 r1 = int4x4(1060042071, 1742666073, 1840182655, 2140077919, 1741615575, 2111829341, 903868767, 1744829277, 802157553, 1710158171, 1868952959, 803011443, 2141715313, 1865220055, 901184987, 1844771671);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1876731927);
            int4x4 b2 = int4x4(842785732, 1023558747, 1567635900, 1888818835, 1681286114, 816160472, 669874393, 856364582, 957707703, 533888601, 707380794, 1472392035, 1658477097, 490006292, 1104319323, 1803275943);
            int4x4 r2 = int4x4(2147478487, 2145315935, 2147269055, 2145238679, 1878977527, 2147335903, 1878915295, 2145369655, 2145254839, 2145320543, 1878912575, 2145315703, 1876884031, 2147282711, 1876867935, 1879043767);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1843251082);
            int4x4 b3 = int4x4(1971735860, 1170365407, 938567231, 165695098, 645196350, 1795857357, 2040732207, 1915771336, 1185590667, 720429375, 1993148654, 159915729, 856765461, 1859323098, 1361749181, 1346956647);
            int4x4 r3 = int4x4(2111819710, 1843388383, 2147346367, 1845350394, 1878912958, 1876942799, 2113920943, 2147344330, 1879043979, 1878910911, 2145243118, 1843257307, 2145253279, 1876936666, 2113923007, 2111696879);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_xor_wide_wide()
        {
            int4x4 a0 = int4x4(1843655608, 362425681, 640805534, 1342040268, 945678755, 980321850, 390165019, 1682422658, 303897251, 230477768, 1103646442, 1503102919, 26631152, 1016475570, 1862440929, 379588576);
            int4x4 b0 = int4x4(1422803441, 1234691140, 119589253, 1101464929, 121896337, 1880109018, 1000210266, 1718938232, 464406940, 884337881, 34199854, 1430659227, 126415540, 1069919967, 1810763253, 2082802224);
            int4x4 r0 = int4x4(959296073, 1544407317, 554771227, 240840109, 1058935858, 1249815008, 752651585, 36917754, 162747199, 956900113, 1136760772, 215066460, 102672708, 55804269, 82614804, 1787102672);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(1943580404, 691527166, 723280696, 497086939, 1640104913, 893178410, 1596765788, 664096470, 2043360590, 799560121, 287637604, 696169196, 2067184169, 1208059988, 1250597330, 1386507647);
            int4x4 b1 = int4x4(941097951, 27782297, 156353074, 607061607, 470737131, 1151564598, 8268481, 434405645, 519003095, 1880915120, 608970922, 1809455754, 1079250101, 514389994, 272120301, 1282399149);
            int4x4 r1 = int4x4(1270918443, 680538471, 575512842, 965736380, 2110579514, 1906288924, 1599249565, 1047646171, 1730440857, 1605643529, 896084174, 1118087270, 996325020, 1453948862, 1521655871, 516667090);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(1889791408, 2084012261, 308683100, 995657536, 2114803648, 1391716615, 1288505091, 1981377086, 1609802717, 1174043024, 1011203132, 1795164620, 244928755, 108081775, 1095776733, 1503947924);
            int4x4 b2 = int4x4(1045003273, 1596550715, 1654640361, 147544177, 1770899808, 632909311, 351538321, 18362671, 582069925, 1343437834, 646157103, 1334609482, 1029555059, 1791514242, 2130180592, 1367984612);
            int4x4 r2 = int4x4(1323995577, 589229790, 1895428021, 865328945, 394305184, 2001372408, 1480133522, 1996577553, 2101480824, 367609242, 449195795, 613191558, 868520832, 1824089325, 1067958317, 137209200);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(1231713131, 1409256837, 71739867, 125722545, 1670829206, 1913595119, 1364737954, 520950663, 1245356662, 1052070924, 1245560924, 271196017, 1397322300, 1351621960, 1546558586, 1199251091);
            int4x4 b3 = int4x4(1758262908, 551762515, 1215029402, 388720229, 652015944, 664221443, 63259885, 1715645848, 1189697317, 668527405, 43069813, 1243634305, 749402779, 1426611688, 1351626941, 2132106703);
            int4x4 r3 = int4x4(564561175, 1931261910, 1278036289, 274020820, 1162489310, 1436029932, 1386052431, 2035269151, 215217491, 426622753, 1219293481, 1510622704, 2145618087, 93864096, 213822663, 946750300);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_xor_wide_scalar()
        {
            int4x4 a0 = int4x4(169345668, 176087064, 2084362901, 1663924004, 193851255, 517476661, 905336222, 863800783, 365003873, 835837496, 954341348, 1464576786, 625604047, 1700827127, 2003392824, 1481813598);
            int b0 = (354464228);
            int4x4 r0 = int4x4(523809632, 526275068, 1763470193, 1980614336, 514678419, 200843473, 550954106, 643578923, 14759301, 619802588, 767731200, 1114315510, 812205099, 1883258387, 1649010908, 1299324858);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(1077374714, 1991576049, 781860967, 60088394, 1196907956, 858716109, 858484213, 178843494, 1223183458, 866652388, 1771693181, 1206307664, 2037729583, 1324393116, 497725784, 1367278685);
            int b1 = (1043379893);
            int4x4 r1 = int4x4(2114443343, 1216724804, 279639762, 1034180351, 2036853505, 220086648, 219929408, 882399699, 1993931479, 228107857, 1470714568, 2044100069, 1195769754, 1891636265, 597297133, 1867494120);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(962962860, 1570278596, 1744797352, 574677361, 1363709514, 1256194849, 801937870, 1010182360, 1851940033, 346084804, 1153678862, 443991213, 53881334, 2016754499, 1219039118, 98879165);
            int b2 = (906632547);
            int4x4 r2 = int4x4(258980047, 1804767655, 1375036363, 340458514, 1732416297, 2095717954, 432440493, 171718075, 1483227554, 581617831, 1925817197, 746379726, 893138069, 1312761376, 2124616429, 871291870);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(1431003548, 1357679092, 1348322929, 109257274, 1305039919, 1464854602, 1225878688, 1485080510, 1118151444, 1798307920, 1281126688, 1804976766, 474757937, 1658928027, 456615564, 97298101);
            int b3 = (1566042386);
            int4x4 r3 = int4x4(136087694, 230383846, 218771299, 1540672296, 278838589, 169345368, 340166066, 97742508, 535972358, 912779586, 285972530, 918694764, 1092342307, 1068946057, 1180733342, 1486573479);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1361775641);
            int4x4 b0 = int4x4(1452773578, 459050892, 1986218254, 1689037698, 999278344, 1229114508, 1087843538, 733699740, 106187872, 1533632738, 1107817672, 492506236, 597602329, 1439603382, 1001169118, 1231718216);
            int4x4 r0 = int4x4(129801427, 1249346453, 659047703, 898082715, 1789184785, 409583765, 301736139, 2056278661, 1467957369, 172125435, 321714385, 1282408549, 1924512768, 82155183, 1787276487, 406948689);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1693179077);
            int4x4 b1 = int4x4(1050897427, 1796435561, 1100532547, 2106589181, 79691722, 851486414, 381749210, 1743618507, 2038827673, 1680906962, 161437943, 171927307, 277703584, 1344718195, 1634011177, 28540247);
            int4x4 r1 = int4x4(1514713302, 267956908, 628299654, 425993016, 1616126735, 1445689867, 1915411231, 50748686, 493737564, 14370327, 1836352562, 1859435470, 1952888677, 885856694, 93246700, 1700307346);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1205447252);
            int4x4 b2 = int4x4(150341716, 899457210, 1927941858, 1213321665, 1943899052, 1166699955, 244059986, 698605361, 770240668, 1451322609, 409403288, 227252138, 455879262, 1859170556, 2135312326, 436746325);
            int4x4 r2 = int4x4(1328521728, 1917127406, 892576950, 260602773, 872686072, 39045095, 1230349574, 1853519205, 1781619400, 291030693, 1606374860, 1246903806, 1559592970, 688462504, 950005138, 1574015489);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (843204844);
            int4x4 b3 = int4x4(52615461, 2078810590, 1178449600, 1402670107, 1373081856, 1755048125, 1604469044, 2092902838, 1107934318, 1695691193, 926405595, 561772433, 1975967935, 188914543, 1621290142, 463965989);
            int4x4 r3 = int4x4(828412361, 1235904818, 1954545196, 1641628919, 1670765036, 1524211793, 1843399128, 1325228378, 1884025986, 1464891733, 91593527, 322551677, 1199876179, 956355459, 1390453874, 702924745);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_left_shift()
        {
            int4x4 a0 = int4x4(1129100049, 829482269, 1571297368, 443753193, 1872142968, 249554593, 892627436, 980302862, 62369727, 849916599, 1271350845, 108441902, 1959056531, 1779118882, 1451674188, 2082026915);
            int b0 = (218351941);
            int4x4 r0 = int4x4(1771463200, 773628832, -1258091776, 1315200288, -220967168, -604187616, -1500693120, 1304920512, 1995831264, 1427527392, 2028521376, -824826432, -1734700448, 1097229376, -791066240, -2094615456);
            TestUtils.AreEqual(a0 << b0, r0);

            int4x4 a1 = int4x4(1149883636, 186532735, 1487486874, 1498738574, 752067504, 1647167336, 772453640, 456967739, 947384545, 1463252873, 1315516161, 640579158, 56630178, 1650899378, 2142944517, 565484033);
            int b1 = (1380536034);
            int4x4 r1 = int4x4(304567248, 746130940, 1654980200, 1699987000, -1286697280, -2001265248, -1205152736, 1827870956, -505429116, 1558044196, 967097348, -1732650664, 226520712, -1986337080, -18156524, -2033031164);
            TestUtils.AreEqual(a1 << b1, r1);

            int4x4 a2 = int4x4(965161323, 1821547426, 1959741996, 1189216014, 2088913234, 331636352, 1765476869, 1716088059, 2042799042, 1560870407, 1332136179, 1595140080, 1067324801, 948699739, 1516035622, 1153563832);
            int b2 = (1634169280);
            int4x4 r2 = int4x4(965161323, 1821547426, 1959741996, 1189216014, 2088913234, 331636352, 1765476869, 1716088059, 2042799042, 1560870407, 1332136179, 1595140080, 1067324801, 948699739, 1516035622, 1153563832);
            TestUtils.AreEqual(a2 << b2, r2);

            int4x4 a3 = int4x4(1430593538, 229486560, 1384761698, 1777845122, 1613768084, 1329798580, 798843728, 2134269101, 924758423, 933785367, 1724594922, 339723704, 5739549, 1346500868, 1275889975, 1690441516);
            int b3 = (1594641896);
            int4x4 r3 = int4x4(1159725568, -1380982784, -1983290880, -138182144, 807769088, 1126020096, -1654435840, 912043264, 514955008, -1469114624, -885331456, 1069922304, 1469324544, 1106838528, 210319104, -1038668800);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_right_shift()
        {
            int4x4 a0 = int4x4(809126085, 908563670, 763568837, 1986717290, 1174507510, 646821842, 1242726074, 390811632, 1521420393, 1923166649, 102096936, 400863878, 667378673, 1611921244, 307750782, 479442287);
            int b0 = (994800051);
            int4x4 r0 = int4x4(1543, 1732, 1456, 3789, 2240, 1233, 2370, 745, 2901, 3668, 194, 764, 1272, 3074, 586, 914);
            TestUtils.AreEqual(a0 >> b0, r0);

            int4x4 a1 = int4x4(2014389412, 1075916177, 1248577253, 848199210, 813936577, 848976170, 500930883, 662405800, 126875849, 1103917083, 1199000503, 955487090, 1013356510, 391605984, 185228398, 87452680);
            int b1 = (1673938174);
            int4x4 r1 = int4x4(1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a1 >> b1, r1);

            int4x4 a2 = int4x4(2021602226, 275199908, 664576720, 363706280, 1600231415, 19835299, 1403250657, 1132760506, 388419548, 1563117590, 1786307084, 1386128491, 1614558171, 370772389, 47213745, 1348912303);
            int b2 = (1401766495);
            int4x4 r2 = int4x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a2 >> b2, r2);

            int4x4 a3 = int4x4(1452132416, 1998929045, 455362165, 2108410522, 180863474, 59587500, 262637954, 1324311490, 1047631661, 1690388406, 43725571, 1582808189, 508063883, 1531560665, 2064352185, 313411198);
            int b3 = (241508868);
            int4x4 r3 = int4x4(90758276, 124933065, 28460135, 131775657, 11303967, 3724218, 16414872, 82769468, 65476978, 105649275, 2732848, 98925511, 31753992, 95722541, 129022011, 19588199);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public void int4x4_operator_bitwise_not()
        {
            int4x4 a0 = int4x4(111796841, 603562399, 745091931, 853183268, 1110916612, 381888399, 1891338755, 1506860135, 771210628, 787710759, 875964607, 96456785, 916013379, 203444882, 1172294211, 1020232736);
            int4x4 r0 = int4x4(-111796842, -603562400, -745091932, -853183269, -1110916613, -381888400, -1891338756, -1506860136, -771210629, -787710760, -875964608, -96456786, -916013380, -203444883, -1172294212, -1020232737);
            TestUtils.AreEqual(~a0, r0);

            int4x4 a1 = int4x4(683852713, 881353367, 1218471344, 1174233245, 592898220, 443427914, 1385118179, 215320517, 860122767, 1411266016, 1349739899, 686325107, 829984855, 191189901, 319233142, 156019905);
            int4x4 r1 = int4x4(-683852714, -881353368, -1218471345, -1174233246, -592898221, -443427915, -1385118180, -215320518, -860122768, -1411266017, -1349739900, -686325108, -829984856, -191189902, -319233143, -156019906);
            TestUtils.AreEqual(~a1, r1);

            int4x4 a2 = int4x4(1467719681, 957020051, 610113447, 1906177458, 1022824453, 1413628073, 1876376887, 479785538, 1454477141, 1062967600, 864049393, 916152339, 1644897753, 1624633488, 210894078, 759733457);
            int4x4 r2 = int4x4(-1467719682, -957020052, -610113448, -1906177459, -1022824454, -1413628074, -1876376888, -479785539, -1454477142, -1062967601, -864049394, -916152340, -1644897754, -1624633489, -210894079, -759733458);
            TestUtils.AreEqual(~a2, r2);

            int4x4 a3 = int4x4(40062168, 316098272, 360895484, 1085047243, 142465498, 160134485, 1507457399, 637862751, 250793845, 1118106030, 541598856, 820535028, 2088709420, 596520858, 556731465, 2087920527);
            int4x4 r3 = int4x4(-40062169, -316098273, -360895485, -1085047244, -142465499, -160134486, -1507457400, -637862752, -250793846, -1118106031, -541598857, -820535029, -2088709421, -596520859, -556731466, -2087920528);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
