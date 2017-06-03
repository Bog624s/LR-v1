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
        private static _ GrawOverlord = Behav()
            .Init(0x722a, Behaves("Graw the Overlord",
                new RunBehaviors(
                    HpGreaterEqual.Instance(25000, (new SetKey(-1, 1))),
                    HpLesser.Instance(25000, new SetKey(-1, 2)),
                    Cooldown.Instance(5000, If.Instance(EntityLesserThan.Instance(20, 4, 0x70aa),
                        new QueuedBehavior(
                            new RunBehaviors(
                                TossEnemy.Instance(0*(float) Math.PI/180, 10, 0x70aa),
                                TossEnemy.Instance(90*(float) Math.PI/180, 10, 0x70aa),
                                TossEnemy.Instance(180*(float) Math.PI/180, 10, 0x70aa),
                                TossEnemy.Instance(270*(float) Math.PI/180, 10, 0x70aa)),
                            Cooldown.Instance(1000),
                            OrderAllEntity.Instance(20, 0x70aa, Despawn.Instance),
                            Cooldown.Instance(1000)
                            ))),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            Cooldown.Instance(2500, TossEnemyAtPlayer.Instance(20, 0x70aa)),
                            Cooldown.Instance(8000, new RunBehaviors(
                                TossEnemy.Instance(45*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(135*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(225*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(315*(float) Math.PI/180, 14, 0x70aa))),
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
                            SimpleWandering.Instance(1f, 1f),
                            Cooldown.Instance(550, Once.Instance(Flashing.Instance(500, 0x01ADFF2F))),
                            Cooldown.Instance(6000, new RunBehaviors(
                                TossEnemy.Instance(45*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(135*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(225*(float) Math.PI/180, 14, 0x70aa),
                                TossEnemy.Instance(315*(float) Math.PI/180, 14, 0x70aa))),
                            Cooldown.Instance(1500, TossEnemyAtPlayer.Instance(20, 0x70aa)),
                            new QueuedBehavior(
                                ReturnSpawn.Instance(40),
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
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x722b, 1, 1, 1))))
                }
                ))
            
            .Init(0x722b, Behaves("Graw the Overlord Chest",
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
                            Tuple.Create(whitebag / 2, (ILoot)new ItemLoot("Potion of Divine Supplies")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Eon"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Overlord Docks Key"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Seal of the Overlord"))
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
                    ))/*,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + awesomeloot, (ILoot)new ItemLoot("Banana T8")),
                            Tuple.Create(greenbag + awesomeloot*2, (ILoot)new ItemLoot("Banana T7")),
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Banana T6")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Banana T5")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Banana T4")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Banana T3")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Banana T2")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Banana T1")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Banana T0"))
                    ))*/
                    )
                )
            )
            ;
    }
}