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
        private static _ MWorld = Behav()
            .Init(0x7278, Behaves("Mario Bros",
                new RunBehaviors(
                    HpGreaterEqual.Instance(5000,
                        new RunBehaviors(
                            SimpleWandering.Instance(2f, 2f),
                            ReturnSpawn.Instance(2),
                            Cooldown.Instance(3000, Heal.Instance(1f, 1000, 0x0d28))
                            )
                        ),
                    HpLesserPercent.Instance(0.99f,
                        new RunBehaviors(
                            SimpleWandering.Instance(2f, 2f),
                            ReturnSpawn.Instance(2),
                            Cooldown.Instance(2000, MultiAttack.Instance(10, 10*(float) Math.PI/180, 1, 0, 5)),
                            Cooldown.Instance(5000, MultiAttack.Instance(10, 10*(float) Math.PI/180, 1, 0, 6)),
                            Cooldown.Instance(3000, MultiAttack.Instance(10, 45*(float) Math.PI/180, 10, 0, 1)),
                            Cooldown.Instance(3500, MultiAttack.Instance(10, 45*(float) Math.PI/180, 10, 0, 2)),
                            Cooldown.Instance(3500, MultiAttack.Instance(10, 45*(float) Math.PI/180, 10, 0, 3)),
                            Cooldown.Instance(3500, MultiAttack.Instance(10, 45*(float) Math.PI/180, 10, 0, 4)),
                            Cooldown.Instance(5000,
                                MultiAttack.Instance(10, 45*(float) Math.PI/180, 7, 0, projectileIndex: 0))
                            )),
                    HpLesserPercent.Instance(0.5f,
                        Once.Instance(
                            new RunBehaviors(
                                True.Instance(
                                    Once.Instance(
                                        new SimpleTaunt(
                                            "Heeey its Mario!"))),
                                Once.Instance(
                                    new RunBehaviors(
                                        SpawnMinionImmediate.Instance(0x0d1b, 1, 5, 20),
                                        SpawnMinionImmediate.Instance(0x0d1c, 3, 3, 4),
                                        SpawnMinionImmediate.Instance(0x0d1d, 3, 3, 4),
                                        SpawnMinionImmediate.Instance(0x0d1e, 3, 3, 4)
                                        )
                                    )
                                )
                            )
                        ),
                    HpLesserPercent.Instance(0.0625f,
                        new RunBehaviors(
                            SimpleWandering.Instance(2f, 2f),
                            ReturnSpawn.Instance(2),
                            Flashing.Instance(500, 0xffff3333),
                            Chasing.Instance(8, 10, 0, null),
                            Cooldown.Instance(3000, MultiAttack.Instance(25, 45*(float) Math.PI/180, 10, 0, 1)),
                            Cooldown.Instance(3500, MultiAttack.Instance(25, 45*(float) Math.PI/180, 10, 0, 2)),
                            Cooldown.Instance(3500, MultiAttack.Instance(25, 45*(float) Math.PI/180, 10, 0, 3)),
                            Cooldown.Instance(500, MultiAttack.Instance(25, 10*(float) Math.PI/180, 5, 0, 8)),
                            Cooldown.Instance(700, MultiAttack.Instance(25, 10*(float) Math.PI/180, 1, 0, 5)),
                            Cooldown.Instance(4000, MultiAttack.Instance(25, 10*(float) Math.PI/180, 2, 0, 6)),
                            Once.Instance(new SimpleTaunt("Hey its Mario!"))
                            ))
                    ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Enchanted Mushroom"))
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
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ring)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(2, ItemType.Ring)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(1, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ability)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(2, ItemType.Ability)),
                            Tuple.Create(poorloot, (ILoot)new TierLoot(1, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Gold Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Cyan Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Blue Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Red Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Green Dragon Lord Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    ))
                ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x7235, 25, -1)
                }
                )
            )
            ;
    }
}