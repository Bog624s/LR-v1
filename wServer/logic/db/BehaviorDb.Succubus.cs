#region

using System;
using wServer.logic.attack;
using wServer.logic.loot;
using wServer.logic.movement;
using wServer.logic.taunt;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private static _ Succubus = Behav()
            .Init(0x70d9, Behaves("Maurth the Succubus Queen Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0xFF00FF),
                                Cooldown.Instance(10000),
                                new SetKey(-1, 2)
                                )
                            )
                        )
                    ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            new QueuedBehavior(
                                UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(1500, 0xFF00FF)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wand of the Succubus")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Heart Pearl of Flaming Arrow")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Robe of the Succubus")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Ring of the Succubus"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Etherite Dagger")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Mantle of Skuld")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Ghastly Drape")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Spectral Ring of Horrors"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(9, ItemType.Weapon)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(8, ItemType.Weapon)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(7, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(10, ItemType.Armor)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(9, ItemType.Armor)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(8, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ring)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ring)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(2, ItemType.Ring)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(1, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ability)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ability)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(2, ItemType.Ability)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(1, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            //Tuple.Create(blackbag, (ILoot) new DivineEgg(1)),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Gold Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Cyan Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Blue Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Red Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Green Dragon Lord Egg")),
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    ))
                    )
                )
            )
            .Init(0x70d8, Behaves("Maurth the Succubus Queen",
                Once.Instance(new SimpleTaunt("YOU SHALL NOT PASS!")),
                new RunBehaviors(
                    new State("idle",
                        SimpleWandering.Instance(5, 15),
                        CooldownExact.Instance(500, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                        CooldownExact.Instance(11000, SimpleAttack.Instance(18, projectileIndex: 1)),
                        CooldownExact.Instance(17000, SimpleAttack.Instance(35, projectileIndex: 2)),
                        HpLesserPercent.Instance(0.75f, SetState.Instance("Quieting"))
                        ),
                    new State("Quieting",
                        SimpleWandering.Instance(5, 15),
                        CooldownExact.Instance(300, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                        CooldownExact.Instance(9000, SimpleAttack.Instance(18, projectileIndex: 1)),
                        CooldownExact.Instance(14000, SimpleAttack.Instance(35, projectileIndex: 2)),
                        HpLesserPercent.Instance(0.15f, SetState.Instance("rage"))
                        ),
                    new State("rage",
                        SimpleWandering.Instance(5, 15),
                        SetConditionEffect.Instance(ConditionEffectIndex.Armored),
                        Once.Instance(new SimpleTaunt("I'M THE SUCCUBUS QUEEN! NO ONE CAN BEAT ME!!!")),
                        Flashing.Instance(10000, 0xFFFF0000),
                        Chasing.Instance(5, 25, 0, null),
                        CooldownExact.Instance(150,
                            MultiAttack.Instance(10, 10*(float) Math.PI/180, 4, projectileIndex: 0)),
                        CooldownExact.Instance(4750,
                            MultiAttack.Instance(10, 15*(float) Math.PI/180, 8, projectileIndex: 1)),
                        CooldownExact.Instance(8750,
                            MultiAttack.Instance(25, 10*(float) Math.PI/180, 1, 0, projectileIndex: 2)),
                        CooldownExact.Instance(500, SimpleAttack.Instance(10))
                        )
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    //new DeathPortal(0x070e, 100, -1),
                    new DeathPortal(0x7235, 10, 600),
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70d9, 1, 1, 1))))
                }
                )
            )
            ;
    }
}