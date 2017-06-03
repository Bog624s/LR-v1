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
        private static _ BoshyGuy = Behav()
            
        .Init(0x7277, Behaves("Boshy Guardian",
            new RunBehaviors(
                Chasing.Instance(8, 12, 1, null),
                Cooldown.Instance(2000, RingAttack.Instance(12, 0, 0, 0)),
                Cooldown.Instance(400, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                Cooldown.Instance(400, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 1))
                        /*If.Instance(
                            EntityLesserThan.Instance(20, 10, 0x5020),
                            Rand.Instance(
                 Cooldown.Instance(120000, SpawnMinionImmediate.Instance(0x5020, 5, 1, 1)))
                )*/),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                   Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Dexterity"))
                    )))
                           ))
            .Init(0x7262, Behaves("Dankins the Boshy Guy",
                new RunBehaviors(
                    HpGreaterEqual.Instance(25000, (new SetKey(-1, 1))),
                    HpLesser.Instance(25000, new SetKey(-1, 2)),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                        If.Instance(
                            EntityLesserThan.Instance(999, 2, 0x7277),
                            Rand.Instance(
                             Cooldown.Instance(20000, SpawnMinionImmediate.Instance(0x7277, 1, 1, 1)))
                            ),
                            SmoothWandering.Instance(1f, 1f),
                            new QueuedBehavior(
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(1000),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(1000),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(1000),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                RingAttack.Instance(8, 0, 0, 0),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(8, 0, 0, 0),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(8, 0, 0, 0),
                                Cooldown.Instance(1000)
                                ))
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            If.Instance(
                                EntityLesserThan.Instance(999, 2, 0x7277),
                                Rand.Instance(
                                    Cooldown.Instance(20000, SpawnMinionImmediate.Instance(0x7277, 1, 1, 1)))
                                ),
                            SimpleWandering.Instance(2f, 2f),
                            Cooldown.Instance(550, Once.Instance(Flashing.Instance(500, 0x01ADFF2F))),
                            new QueuedBehavior(
                                ReturnSpawn.Instance(10),
                                Flashing.Instance(1000, 0x01ADFF2F),
                                RingAttack.Instance(30, 0, 0, 3),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(30, 0, 0, 3),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(30, 0, 0, 3),
                                Cooldown.Instance(1000),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(750),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(750),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(750),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(750),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(0*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(90*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(180*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(270*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(750),
                                new RunBehaviors(
                                    AngleMultiAttack.Instance(45*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(135*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(225*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2),
                                    AngleMultiAttack.Instance(315*(float) Math.PI/180, 20*(float) Math.PI/180, 2, 2)),
                                Cooldown.Instance(500),
                                RingAttack.Instance(16, 0, 0, 0),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(16, 0, 0, 0),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(16, 0, 0, 0),
                                Cooldown.Instance(1000),
                                RingAttack.Instance(16, 0, 0, 0)
                                )))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x7263, 1, 1, 1))))
                }
                ))
            
            .Init(0x7263, Behaves("Dankins the Boshy Guy Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0x8B2252),
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
                                Flashing.Instance(1500, 0x8B2252)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 8,
                            Tuple.Create(0.45, (ILoot)new StatPotionsLoot(1, 2)),
                            Tuple.Create(0.225, (ILoot)new StatPotionsLoot(3))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(superrareblackbag, (ILoot)new ItemLoot("Potion of Divine Supplies")),
                            Tuple.Create(superrareblackbag, (ILoot)new ItemLoot("Eon")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Enchanted Greater Potion of Life")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Enchanted Greater Potion of Mana")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Attack")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Defense")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Speed")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Dexterity")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Vitality")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Enchanted Greater Potion of Wisdom"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(superrareblackbag/2, (ILoot)new ItemLoot("Boshy Gun"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ability)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ring)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring))
                    ))
                    )
                )
            )
            ;
    }
}