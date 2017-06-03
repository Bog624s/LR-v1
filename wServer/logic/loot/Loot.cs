#region

using System;
using System.Collections.Generic;
using System.Linq;
using db.data;

#endregion

namespace wServer.logic.loot
{
    public interface ILoot
    {
        Item GetLoot(Random rand);
    }

    public enum ItemType
    {
        Weapon,
        Ability,
        Armor,
        Ring,
        Misc
    }

    internal class TierLoot : ILoot
    {
        public static readonly int[] WeaponsT = {1, 2, 3, 8, 17, 24, 29};

        public static readonly int[] AbilityT =
        {
            4, 5, 11, 12, 13, 15, 16, 18, 19, 20, 21, 22, 23, 25, 26, 27, 28, 30,
            32, 31
        };

        public static readonly int[] ArmorsT = {6, 7, 14};
        public static readonly int[] RingT = {9};
        public static readonly int[] MiscT = {10};

        public static readonly Dictionary<int, Item[]> WeaponItems;
        public static readonly Dictionary<int, Item[]> AbilityItems;
        public static readonly Dictionary<int, Item[]> ArmorItems;
        public static readonly Dictionary<int, Item[]> RingItems;
        public static readonly Dictionary<int, Item[]> MiscItems;

        static TierLoot()
        {
            WeaponItems = new Dictionary<int, Item[]>();
            for (var tier = 1; tier < 20; tier++)
            {
                var items = new List<Item>();
                foreach (var i in WeaponsT)
                    items.AddRange(XmlDatas.ItemDescs.Select(_ => _.Value).Where(_ => _.Tier == tier && _.SlotType == i));
                if (items.Count == 0)
                    break;
                WeaponItems[tier] = items.ToArray();
            }
            AbilityItems = new Dictionary<int, Item[]>();
            for (var tier = 1; tier < 20; tier++)
            {
                var items = new List<Item>();
                foreach (var i in AbilityT)
                    items.AddRange(XmlDatas.ItemDescs.Select(_ => _.Value).Where(_ => _.Tier == tier && _.SlotType == i));
                if (items.Count == 0)
                    break;
                AbilityItems[tier] = items.ToArray();
            }
            ArmorItems = new Dictionary<int, Item[]>();
            for (var tier = 1; tier < 20; tier++)
            {
                var items = new List<Item>();
                foreach (var i in ArmorsT)
                    items.AddRange(XmlDatas.ItemDescs.Select(_ => _.Value).Where(_ => _.Tier == tier && _.SlotType == i));
                if (items.Count == 0)
                    break;
                ArmorItems[tier] = items.ToArray();
            }
            RingItems = new Dictionary<int, Item[]>();
            for (var tier = 1; tier < 20; tier++)
            {
                var items = new List<Item>();
                foreach (var i in RingT)
                    items.AddRange(XmlDatas.ItemDescs.Select(_ => _.Value).Where(_ => _.Tier == tier && _.SlotType == i));
                if (items.Count == 0)
                    break;
                RingItems[tier] = items.ToArray();
            }
            MiscItems = new Dictionary<int, Item[]>();
            for (var tier = 1; tier < 20; tier++)
            {
                var items = new List<Item>();
                foreach (var i in MiscT)
                    items.AddRange(XmlDatas.ItemDescs.Select(_ => _.Value).Where(_ => _.Tier == tier && _.SlotType == i));
                if (items.Count == 0)
                    break;
                MiscItems[tier] = items.ToArray();
            }
        }

        public TierLoot(byte tier, ItemType type)
        {
            Tier = tier;
            Type = type;
        }

        public byte Tier { get; private set; }
        public ItemType Type { get; private set; }

        public Item GetLoot(Random rand)
        {
            Item[] candidates;
            switch (Type)
            {
                case ItemType.Weapon:
                    candidates = WeaponItems[Tier];
                    break;
                case ItemType.Ability:
                    candidates = AbilityItems[Tier];
                    break;
                case ItemType.Armor:
                    candidates = ArmorItems[Tier];
                    break;
                case ItemType.Ring:
                    candidates = RingItems[Tier];
                    break;
                case ItemType.Misc:
                default:
                    candidates = MiscItems[Tier];
                    break;
            }
            var idx = rand.Next(0, candidates.Length);
            return candidates[idx];
        }
    }

    public class ItemLoot : ILoot
    {
        public ItemLoot(string loot) : this(XmlDatas.IdToType[loot])
        {
        }

        protected ItemLoot(short objType)
        {
            Item = XmlDatas.ItemDescs[objType];
        }

        public Item Item { get; private set; }

        public Item GetLoot(Random rand)
        {
            return Item;
        }
    }

    internal class HpPotionLoot : ItemLoot
    {
        public static readonly HpPotionLoot Instance = new HpPotionLoot();

        private HpPotionLoot() : base(0x0a22)
        {
        }
    }

    internal class MpPotionLoot : ItemLoot
    {
        public static readonly MpPotionLoot Instance = new MpPotionLoot();

        private MpPotionLoot() : base(0x0a23)
        {
        }
    }

    internal class PotionLoot : ILoot
    {
        public static readonly PotionLoot Instance = new PotionLoot();

        private PotionLoot()
        {
        }

        public Item GetLoot(Random rand)
        {
            return rand.Next()%2 == 0 ? XmlDatas.ItemDescs[0x0a22] : XmlDatas.ItemDescs[0x0a23];
        }
    }
    

    internal class DivineEgg : ILoot
    {
        public static readonly DivineEgg Instance = new DivineEgg();

        private DivineEgg()
        {
        }

        internal enum DivineList : short
        {
            Tiger = 0x60f4,
            PinkLion = 0x60f5,
            MidnightWolf = 0x60f6,
            GoldHyena = 0x60f7,
            Phoenix = 0x60f8,
            Griffin = 0x60f9,
            WarElephant = 0x60fa,
            KingGorilla = 0x60fb,
            EnragedYack = 0x60fc,
            NightMare = 0x60fd,
            SilverDoe = 0x60fe,
            SolarOwl = 0x60ff,
            TandemCobra = 0x4100,
            PoisonDrake = 0x4101,
            Bettleman = 0x4102,
            Ultrawasp = 0x4103,
            BattlePenguin = 0x4104,
            TankPenguin = 0x4105,
            GoldenCrab = 0x4106,
            GreatShark = 0x4107,
            BlueLandfish = 0x4108,
            GlowingSkull = 0x4109,
            MonkeyHead = 0x410a,
            Reaper = 0x410b,
            BattleGod = 0x410c,
            Centaur = 0x410d,
            ForestFairy = 0x410e,
            Shroom = 0x410f,
            GreatJelly = 0x4110,
            Spiderbot = 0x4111,
            Cilindron = 0x4112,
            Gutsbot = 0x4113,
        }
        
        public DivineEgg(params int[] tiers)
        {
            var p = new List<DivineList>();
            foreach (var i in tiers)
                p.AddRange(EggTiers[i - 1]);
            eggrarity = p.Distinct().ToArray();
        }

        private static readonly DivineList[][] EggTiers =
        {
            new[] {
                DivineList.BattleGod,
                DivineList.BattlePenguin,
                DivineList.Bettleman,
                DivineList.BlueLandfish,
                DivineList.Centaur,
                DivineList.Cilindron,
                DivineList.EnragedYack,
                DivineList.ForestFairy,
                DivineList.GlowingSkull,
                DivineList.GoldenCrab,
                DivineList.GoldHyena,
                DivineList.GreatJelly,
                DivineList.GreatShark,
                DivineList.Griffin,
                DivineList.Gutsbot,
                DivineList.KingGorilla,
                DivineList.MidnightWolf,
                DivineList.MonkeyHead,
                DivineList.NightMare,
                DivineList.Phoenix,
                DivineList.PinkLion,
                DivineList.PoisonDrake,
                DivineList.Reaper,
                DivineList.Shroom,
                DivineList.SilverDoe,
                DivineList.SolarOwl,
                DivineList.Spiderbot,
                DivineList.TandemCobra,
                DivineList.TankPenguin,
                DivineList.Tiger,
                DivineList.Ultrawasp,
                DivineList.WarElephant
            }
        };

        private readonly DivineList[] eggrarity;

        public Item GetLoot(Random rand)
        {
            //return rand.Next()%2 == 0 ? XmlDatas.ItemDescs[0x0a22] : XmlDatas.ItemDescs[0x0a23];
            return XmlDatas.ItemDescs[(short) eggrarity[rand.Next(0, eggrarity.Length)]];
        }
    }

    internal class IncLoot : ItemLoot
    {
        public static readonly IncLoot Instance = new IncLoot();

        private IncLoot() : base(0x722)
        {
        }
    }

    internal enum StatPotion : short
    {
        Att = 0xa1f,
        Def = 0xa20,
        Spd = 0xa21,
        Vit = 0xa34,
        Wis = 0xa35,
        Dex = 0xa4c,
        Life = 0xae9,
        Mana = 0xaea,
    }

    internal class StatPotionLoot : ItemLoot
    {
        public StatPotionLoot(StatPotion pot) : base((short) pot)
        {
        }
    }

    internal class StatPotionsLoot : ILoot
    {
        private static readonly StatPotion[][] Tiers =
        {
            new[] {StatPotion.Att, StatPotion.Def, StatPotion.Spd},
            new[] {StatPotion.Vit, StatPotion.Wis, StatPotion.Dex},
            new[] {StatPotion.Life, StatPotion.Mana}
        };

        private readonly StatPotion[] pots;

        public StatPotionsLoot(params int[] tiers)
        {
            var p = new List<StatPotion>();
            foreach (var i in tiers)
                p.AddRange(Tiers[i - 1]);
            pots = p.Distinct().ToArray();
        }
        
        public Item GetLoot(Random rand)
        {
            return XmlDatas.ItemDescs[(short) pots[rand.Next(0, pots.Length)]];
        }
    }
}