#region

using System;
using wServer.logic.attack;
using wServer.logic.loot;
using wServer.logic.movement;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private static _ CubeGod = Behav()
            .Init(0x0d59, Behaves("Cube God",
                SimpleWandering.Instance(1, .5f),
                new RunBehaviors(
                    Cooldown.Instance(750,
                        PredictiveMultiAttack.Instance(25, 10*(float) Math.PI/180, 9, 1, projectileIndex: 0)),
                    Cooldown.Instance(1500, PredictiveMultiAttack.Instance(25, 10*(float) Math.PI/180, 4, 1, 1)),
                    If.Instance(
                        IsEntityPresent.Instance(15, null),
                        OrderGroup.Instance(20, "Cube Minions", new SetKey(-1, 0)),
                        If.Instance(
                            IsEntityNotPresent.Instance(20, null),
                            OrderGroup.Instance(20, "Cube Minions", new SetKey(-1, 1))
                            )
                        )
                    ),
                IfNot.Instance(
                    Once.Instance(
                        new RunBehaviors(
                            SpawnMinionImmediate.Instance(0x0d5a, 5, 4, 5),
                            SpawnMinionImmediate.Instance(0x0d5b, 5, 9, 18),
                            SpawnMinionImmediate.Instance(0x0d5c, 5, 9, 18)
                            )
                        ),
                    Rand.Instance(
                        Reproduce.Instance(0x0d5a, 4, 5000, 20),
                        Reproduce.Instance(0x0d5b, 20, 1000, 20),
                        Reproduce.Instance(0x0d5c, 20, 1000, 20)
                        )
                    ),
                loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Slice of Cube God"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Eternal Dirk of Cronus")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Dirk of Cronus"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(9, ItemType.Weapon)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(8, ItemType.Weapon)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(7, ItemType.Weapon)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(6, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(10, ItemType.Armor)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(9, ItemType.Armor)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(8, ItemType.Armor)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(7, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ring)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(2, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Futuristic Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Futuristic Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.05, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                        ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x704c, 5, 300)
                }
                ))
            .Init(0x0d5a, Behaves("Cube Overseer",
                IfNot.Instance(
                    Circling.Instance(5, 25, 4, 0x0d59),
                    SimpleWandering.Instance(2)
                    ),
                new RunBehaviors(
                    Cooldown.Instance(1000,
                        PredictiveMultiAttack.Instance(10, 5*(float) Math.PI/180, 4, 1, projectileIndex: 0)),
                    Cooldown.Instance(2000, PredictiveAttack.Instance(10, 1, 1))
                    )
                ))
            .Init(0x0d5b, Behaves("Cube Defender",
                IfNot.Instance(
                    IfEqual.Instance(-1, 0,
                        Chasing.Instance(7, 20, 1, null),
                        IfNot.Instance(
                            Chasing.Instance(7, 25, 7.5f, 0x0d59),
                            Circling.Instance(7.5f, 25, 7, 0x0d5a)
                            )
                        ),
                    SimpleWandering.Instance(5)
                    ),
                Cooldown.Instance(500, SimpleAttack.Instance(10))
                ))
            .Init(0x0d5c, Behaves("Cube Blaster",
                IfNot.Instance(
                    IfEqual.Instance(-1, 0,
                        Chasing.Instance(7, 20, 1, null),
                        IfNot.Instance(
                            Chasing.Instance(7, 25, 7.5f, 0x0d5a),
                            Circling.Instance(7.5f, 25, 7, 0x0d59)
                            )
                        ),
                    SimpleWandering.Instance(5)
                    ),
                Cooldown.Instance(1000, new RunBehaviors(
                    SimpleAttack.Instance(10, 1),
                    MultiAttack.Instance(10, 5*(float) Math.PI/180, 2, projectileIndex: 0)
                    ))
                ));
    }
}