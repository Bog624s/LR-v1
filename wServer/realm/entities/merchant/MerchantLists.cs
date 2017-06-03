#region

using System;
using System.Collections.Generic;
using System.Linq;
using db.data;

#endregion

namespace wServer.realm.entities
{
    internal class MerchantLists
    {
        public static Dictionary<int, Tuple<int, CurrencyType>> prices = new Dictionary<int, Tuple<int, CurrencyType>>
        {
            //////////////PRICES ONLY\\\\\\\\\\\\\
                            
              //small clothes    
          /*  {0x1337, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1348, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1349, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1301, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1302, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1303, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1304, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1305, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1306, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1307, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1308, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1309, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130a, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130b, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130c, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130d, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130e, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x130f, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1310, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1311, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1312, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1313, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1314, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1315, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1316, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1317, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1318, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1319, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x131a, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x131b, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x131c, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x131d, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x131e, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1320, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1321, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1322, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1323, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1324, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1325, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1326, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1327, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1328, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1329, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132a, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132b, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132c, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132d, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132e, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132f, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132e, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x132f, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1330, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1331, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1332, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1333, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1334, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1335, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1336, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1337, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1338, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1339, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133a, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133b, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133c, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133d, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133e, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x133f, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1340, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1341, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1342, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1343, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1344, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1345, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},
            {0x1346, new Tuple<int, CurrencyType>(175, CurrencyType.Gold)},

            //large clothes
            {0x1247, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1248, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1249, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1200, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1201, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1202, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1203, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1204, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1205, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1206, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1207, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1208, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1209, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120a, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120b, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120c, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120d, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120e, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x120f, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1210, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1211, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1212, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1213, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1214, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1215, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1216, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1217, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1218, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1219, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121a, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121b, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121c, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121d, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121e, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x121f, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1220, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1221, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1222, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1223, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1224, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1225, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1226, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1227, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1228, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1229, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122a, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122b, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122c, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122d, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122e, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x122f, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1230, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1231, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1232, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1233, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1234, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1235, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1236, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1237, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1238, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1239, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123a, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123b, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123c, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123d, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123e, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x123f, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1240, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1241, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1242, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1243, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1244, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1245, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0x1246, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},*/


//Rings t4
            {0xab8, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Defense
            {0xab7, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Attack
            {0xab9, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Speed
            {0xaba, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Vitality
            {0xabb, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Wisdom
            {0xabc, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Dexterity
            {0xabd, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Health
            {0xabe, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Magic


//Armor t8
            {0xadc, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Robe
            {0xa12, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Heavy
            {0xa0e, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Leather


                                  
//weapons t10
            {0xa19, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Dagger
            {0xa82, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Sword
            {0xa1e, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Bow
            {0xa9f, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Staff
            {0xa07, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Wand
            {0xc4c, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Katana


                                  
//Abilities t4


            {2774, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, // Spell
            {0xa33, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Tome
            {0xa64, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Quiver
            {0xa59, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Cloak
            {0xa6a, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Helm
            {0xa0b, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Shield
            {0xa54, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Seal
            {0xaa7, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Poison
            {0xaae, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Skull
            {0xab5, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Trap
            {0xa45, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Orb
            {0xb1f, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Prism
            {0xb31, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Scepter
            {0xfbd, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Pearl



// Effusions
            {0xaef, new Tuple<int, CurrencyType>(500, CurrencyType.Fame)}, // Defense
            {0xaf0, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, // Defense
            {0xaf1, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, // Defense
            {0xaf2, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, // Defense
            {0xaf3, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, // Defense


//randum stuff
            {2878, new Tuple<int, CurrencyType>(20, CurrencyType.Fame)}, //Amulet of Resurrection
            {0xaeb, new Tuple<int, CurrencyType>(20, CurrencyType.Fame)}, //Greater Health Potion
            {0xaec, new Tuple<int, CurrencyType>(20, CurrencyType.Fame)}, //Greater Magic Potion
            {0x161f, new Tuple<int, CurrencyType>(2000, CurrencyType.Gold)}, //Valentine

            //PETS
            
            {0x6003, new Tuple<int, CurrencyType>(750, CurrencyType.Fame)},
            {0x6004, new Tuple<int, CurrencyType>(1750, CurrencyType.Fame)},
            {0x6005, new Tuple<int, CurrencyType>(3435, CurrencyType.Fame)},
            {0x6006, new Tuple<int, CurrencyType>(5785, CurrencyType.Fame)},
            {0x6007, new Tuple<int, CurrencyType>(6575, CurrencyType.Gold)},
            {0x6008, new Tuple<int, CurrencyType>(17315, CurrencyType.Gold)},
            {0x6009, new Tuple<int, CurrencyType>(39270, CurrencyType.Gold)},


// dyes (For now)
// Clothing
            {0x1007, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Black
            {0x1009, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Blue
            {0x100b, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Brown
            {0x1010, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Coral
            {0x1012, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Cornsilk
            {0x1015, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Dark Blue
            {0x101f, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Dark Red
            {0x1002, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Aqua
            {0x1004, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Azure
            {0x1033, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Green
            {0x102f, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, // Ghost White
            {0x1079, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Sienna
            {0x1030, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Gold

//Accessory
            {0x1107, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Black
            {0x1109, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Blue
            {0x110b, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Brown
            {0x1110, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Coral
            {0x1112, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Cornsilk
            {0x1115, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Dark Blue
            {0x111f, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Dark Red
            {0x1102, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Aqua
            {0x1104, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Azure
            {0x1133, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Green
            {0x112f, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Ghost White
            {0x1179, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Sienna
            {0x1130, new Tuple<int, CurrencyType>(285, CurrencyType.Fame)}, //Gold

            {0x1962, new Tuple<int, CurrencyType>(500, CurrencyType.Fame)}, //backpack

            //The Wineler
            

            //t11-12 armors
            {0xa8f, new Tuple<int, CurrencyType>(250, CurrencyType.Gold)},
            {0xa90, new Tuple<int, CurrencyType>(350, CurrencyType.Gold)},
            {0xa92, new Tuple<int, CurrencyType>(250, CurrencyType.Gold)},
            {0xa93, new Tuple<int, CurrencyType>(350, CurrencyType.Gold)},
            {0xa95, new Tuple<int, CurrencyType>(250, CurrencyType.Gold)},
            {0xa96, new Tuple<int, CurrencyType>(350, CurrencyType.Gold)},

            //t10-11 weapons
            {0xa89, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xa8a, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0xa86, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xa87, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0xaa1, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xaa2, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0xa84, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xa47, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0xa8c, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xa8d, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},
            {0xc4e, new Tuple<int, CurrencyType>(275, CurrencyType.Gold)},
            {0xc4f, new Tuple<int, CurrencyType>(385, CurrencyType.Gold)},

            /*
                0xa8f,0xa90, 0xa92,0xa93,0xa95,0xa96,0xa89,0xa8a,0xa86,0xa87,0xaa1,0xaa2,0xa84,0xa47,0xa8c,0xa8d,
                0xc4e,0xc4f,0xac7,0xac8,0xac9,0xaca,0xacb,0xacc,0xacd,0xace
            */

            //t5 rings
            {0xac7, new Tuple<int, CurrencyType>(315, CurrencyType.Gold)},
            {0xac8, new Tuple<int, CurrencyType>(300, CurrencyType.Gold)},
            {0xac9, new Tuple<int, CurrencyType>(300, CurrencyType.Gold)},
            {0xaca, new Tuple<int, CurrencyType>(300, CurrencyType.Gold)},
            {0xacb, new Tuple<int, CurrencyType>(300, CurrencyType.Gold)},
            {0xacc, new Tuple<int, CurrencyType>(300, CurrencyType.Gold)},
            {0xacd, new Tuple<int, CurrencyType>(315, CurrencyType.Gold)},
            {0xace, new Tuple<int, CurrencyType>(315, CurrencyType.Gold)},

        };

        /* public static int[] store1List = { 0x701, 0x705, 0x706, 0x70a, 0x70b, 0x710, 0x71f, 0x722, 0xc11, 0xc19, 0xc23, 0xc2e, 0xc3d }; //keys */
        public static int[] store1List = {
            0xa19, 0xa82, 0xa1e, 0xa9f, 0xa07, 0xc4c, //weapons
            0xadc, 0xa12, 0xa0e, //armor
            0xaef, 0xaf0, 0xaf1, 0xaf2, 0xaf3, //Consumables(fame)
            0xab8, 0xab9, 0xaba, 0xabb, 0xabc, 0xabd, 0xabe, 0xab7 //rings
        }; // Keys (?) added to the map

        public static int[] store2List =
        {
            2774, 0xa33, 0xa64, 0xa59, 0xa6a, 0xa0b, 0xa54, 0xaa7, 0xaae, 0xab5, 0xa45,
            0xb1f, 0xb31, 0xfbd
        }; // ????

        //small clothes
        public static int[] store3List = {
            0x1107, 0x1109, 0x110b, 0x1110, 0x1112, 0x1115, 0x111f, 0x1102, 0x1104, 0x1133,
            0x112f, 0x1179, 0x1130, 0x100b, 0x1010, 0x1012, 0x1015, 0x101f, 0x1002, 0x1004,
            0x1033, 0x102f, 0x1079, 0x1030
        //    0x1337, 0x1348, 0x1349, 0x1300, 0x1301, 0x1302, 0x1303, 0x1304, 0x1305, 0x1306, 0x1307, 0x1308, 0x1309, 0x130a, 0x130b, 0x130c, 0x130d, 0x130e, 0x130f,
         //   0x1310, 0x1311, 0x1312, 0x1313, 0x1314, 0x1315, 0x1316, 0x1317, 0x1318, 0x1319, 0x131a, 0x131b, 0x131c, 0x131d, 0x131e, 0x131f, 0x1320, 0x1321, 0x1323,
           // 0x1324, 0x1325, 0x1326, 0x1327, 0x1328, 0x1329, 0x132a, 0x132b, 0x132c, 0x132d, 0x132e, 0x132f, 0x1330, 0x1331, 0x1332, 0x1333, 0x1334, 0x1335, 0x1336,
          //  0x1337, 0x1338, 0x1339, 0x133a, 0x133b, 0x133c, 0x133d, 0x133e, 0x133f, 0x1340, 0x1341, 0x1342, 0x1343, 0x1344, 0x1345, 0x1346
        };

        //pets
        public static int[] store4List = {
            0x6003, 0x6004, 0x6005, 0x6006, 0x6007, 0x6008, 0x6009
        };
        public static int[] store5List = {
            0x1107, 0x1109, 0x110b, 0x1110, 0x1112, 0x1115, 0x111f, 0x1102, 0x1104, 0x1133,
            0x112f, 0x1179, 0x1130, 0x100b, 0x1010, 0x1012, 0x1015, 0x101f, 0x1002, 0x1004,
            0x1033, 0x102f, 0x1079, 0x1030
        }; //Consumables
        public static int[] store6List = {0xab8, 0xab9, 0xaba, 0xabb, 0xabc, 0xabd, 0xabe, 0xab7}; // Rings

        //large clothes
        public static int[] store7List = {
            0x1007, 0x1009, 0x100b, 0x1010, 0x1012, 0x1015, 0x101f, 0x1002, 0x1004, 0x1033,
            0x102f, 0x1079, 0x1030
           // 0x1247, 0x1248, 0x1249, 0x1200, 0x1201, 0x1202, 0x1203, 0x1204, 0x1205, 0x1206, 0x1207, 0x1208, 0x1209, 0x120a, 0x120b, 0x120c, 0x120d,0x120e, 0x120f,
           // 0x1210, 0x1211, 0x1212, 0x1213, 0x1214, 0x1215, 0x1216, 0x1217, 0x1218, 0x1219, 0x121a, 0x121b, 0x121c, 0x121d, 0x121e, 0x121f, 0x1220, 0x1221, 0x1222,
           // 0x1223, 0x1224, 0x1225, 0x1226, 0x1227, 0x1228, 0x1229, 0x122a, 0x122b, 0x122c, 0x122d, 0x122e, 0x122f, 0x1230, 0x1231, 0x1232, 0x1233, 0x1234, 0x1235,
           // 0x1236, 0x1237, 0x1238, 0x1239, 0x123a, 0x123b, 0x123c, 0x123d, 0x123e, 0x123f, 0x1240, 0x1241, 0x1242, 0x1243, 0x1244, 0x1245, 0x1246
        }; // Empty

        public static int[] store8List =
        {
            0x1007, 0x1009, 0x100b, 0x1010, 0x1012, 0x1015, 0x101f, 0x1002, 0x1004, 0x1033,
            0x102f, 0x1079, 0x1030
        }; // Large Dyes

        public static int[] store9List =
        {
            0xa8f,0xa90,0xa92,
            0xa93,0xa95,0xa96,
            0xa89,0xa8a,0xa86,
            0xa87,0xaa1,0xaa2,
            0xa84,0xa47,0xa8c,
            0xa8d,0xc4e,0xc4f,
            0xac7,0xac8,0xac9,
            0xaca,0xacb,0xacc,
            0xacd,0xace
           // 0x1107, 0x1109, 0x110b, 0x1110, 0x1112, 0x1115, 0x111f, 0x1102, 0x1104, 0x1133,
           // 0x112f, 0x1179, 0x1130
        }; // Small Dyes <!-- The Wineler -->

        public static int[] store10List = {0xc0a};


        public static Dictionary<string, int[]> shopLists = new Dictionary<string, int[]>();

        public static void AddPetShop()
        {
            var PetShop = new List<int>();
            for (var i = 0x1500; i < 0x1562; i++)
            {
                PetShop.Add(i);
            }
            shopLists.Add("pets", PetShop.ToArray());
            PetShop.Shuffle();
            shopLists.Add("pets2", PetShop.ToArray());
            PetShop.Shuffle();
            shopLists.Add("pets3", PetShop.ToArray());
        }

        public static void GetKeys()
        {
            var nkeys = new List<int>();
            foreach (var i in XmlDatas.Keys)
            {
                prices[i] = new Tuple<int, CurrencyType>(XmlDatas.KeyPrices[i], CurrencyType.Fame);
                nkeys.Add(i);
            }
            shopLists["keys"] = nkeys.ToArray();
        }


        public static void AddCustomShops()
        {
            foreach (var i in XmlDatas.ItemPrices)
            {
                prices.Add(i.Key, new Tuple<int, CurrencyType>(i.Value, CurrencyType.Fame));
            }
            foreach (var i in XmlDatas.ItemShops)
            {
                if (shopLists.ContainsKey(i.Value))
                {
                    var ls = shopLists[i.Value].ToList();
                    ls.Add(i.Key);
                    shopLists[i.Value] = ls.ToArray();
                }
                else
                {
                    shopLists.Add(i.Value, new[] {i.Key});
                }
            }
        }
    }
}