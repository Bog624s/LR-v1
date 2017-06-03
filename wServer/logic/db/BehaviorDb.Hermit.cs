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
        private static _ Hermit = Behav()
            .Init(0x0d61, Behaves("Hermit God",
                new RunBehaviors(
                    If.Instance(IsEntityPresent.Instance(20, null),
                        OrderAllEntity.Instance(20, 0x0d64, Circling.Instance(8, 20, 3, 0x0d61))),
                    If.Instance(IsEntityPresent.Instance(9, null),
                        OrderAllEntity.Instance(20, 0x0d64, Chasing.Instance(4, 2, 0, null))),
                    If.Instance(IsEntityNotPresent.Instance(9, 0x0d64),
                        OrderAllEntity.Instance(20, 0x0d64, Circling.Instance(8, 20, 3, 0x0d61))),
                    Once.Instance(TossEnemy.Instance(90*(float) Math.PI/180, 5, 0x0d66)),
                    Once.Instance(new SetKey(-1, 1)
                        ),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                                OrderAllEntity.Instance(10, 0x0d65, new SetKey(-1, 1)),
                                CooldownExact.Instance(1500),
                                new SetKey(-1, 2)
                                ))),
                    IfEqual.Instance(-1, 2,
                        new QueuedBehavior(
                            If.Instance(EntityLesserThan.Instance(10, 1, 0x0d64), new SetKey(-1, 3))
                            )),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetAltTexture.Instance(1),
                                CooldownExact.Instance(800),
                                SetAltTexture.Instance(2),
                                TossEnemyNull.Instance(0*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(45*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(90*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(135*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(180*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(225*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(270*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(315*(float) Math.PI/180, 5, 0x0d63),
                                TossEnemyNull.Instance(0 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(45 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(90 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(135 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(180 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(225 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(270 * (float)Math.PI / 180, 5, 0x0d62),
                                TossEnemyNull.Instance(315 * (float)Math.PI / 180, 5, 0x0d62),
                                CooldownExact.Instance(700),
                                SetAltTexture.Instance(0),
                                CooldownExact.Instance(400),
                                SetAltTexture.Instance(0),
                                CooldownExact.Instance(100),
                                new SetKey(-1, 4)
                                )
                            )),
                    IfEqual.Instance(-1, 4,
                        new RunBehaviors(
                            new QueuedBehavior(
                                UnsetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                                CooldownExact.Instance(100),
                                MultiAttack.Instance(10, 10*(float) Math.PI/180, 3, 0, projectileIndex: 0),
                                MultiAttack.Instance(10, 11*(float) Math.PI/180, 3, 0, projectileIndex: 0),
                                MultiAttack.Instance(10, 12*(float) Math.PI/180, 3, 0, projectileIndex: 0),
                                MultiAttack.Instance(10, 13*(float) Math.PI/180, 3, 0, projectileIndex: 0),
                                MultiAttack.Instance(10, 14*(float) Math.PI/180, 3, 0, projectileIndex: 0),
                                CooldownExact.Instance(100)
                                ),
                            new QueuedBehavior(
                                CooldownExact.Instance(9500),
                                SetAltTexture.Instance(2),
                                OrderAllEntity.Instance(10, 0x0d63, Despawn.Instance),
                                OrderAllEntity.Instance(10, 0x0d63, new SetKey(-1, 0)),
                                CooldownExact.Instance(450),
                                SetAltTexture.Instance(3),
                                Cooldown.Instance(450),
                                new SetKey(-1, 1),
                                Cooldown.Instance(1500)
                                ))
                        )
                    ),
                loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Hermit's Carapace Piece"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Helm of the Armored Juggernaut")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Helm of the Juggernaut"))
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
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Shamrock Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Shamrock Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new Corpse(0x0d66),
                    new OnDeath(
                        SpawnMinionImmediate.Instance(0x3f07, 0, 1, 1)
                        ),
                    new DeathPortal(0x0730, 100, 600)
                }
                ))
            .Init(0x0d64, Behaves("Hermit God Tentacles",
                new RunBehaviors(
                    Cooldown.Instance(500, RingAttack.Instance(5, 5, 5, 0))
                    )))
            .Init(0x0d65, Behaves("Hermit God Tentacle Spawner", //Minnions Too!
                SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                new RunBehaviors(
                    Once.Instance(SpawnMinionImmediate.Instance(0x0d62, 5, 3, 4)),
                    If.Instance(IsEntityNotPresent.Instance(10, 0x0d61), Despawn.Instance),
                    IfEqual.Instance(-1, 0, NullBehavior.Instance),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            SpawnMinionImmediate.Instance(0x0d64, 1, 1, 1),
                            //SpawnMinionImmediate.Instance(0x0d62, 1, 1, 1),
                            CooldownExact.Instance(100),
                            new SetKey(-1, 0),
                            CooldownExact.Instance(1500)
                            ))
                    )
                ))
            .Init(0x0d63, Behaves("Whirlpool",
                new RunBehaviors(
                    Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invincible)),
                    Once.Instance(new SetKey(-2, 0)),
                    If.Instance(IsEntityNotPresent.Instance(10, 0x0d61), Despawn.Instance),
                    IfEqual.Instance(-1, 0, Die.Instance),
                    IfEqual.Instance(-2, 0,
                        new RunBehaviors(InfiniteSpiralAttack.Instance(500, 1, 45, 0))
                        )
                    )
                ))
            .Init(0x0d62, Behaves("Hermit Minion",
                IfNot.Instance(
                    Chasing.Instance(4, 3, 0, null),
                    Circling.Instance(15, 40, 7, 0x0d61)
                    ),
                new RunBehaviors(
                    Cooldown.Instance(1500, MultiAttack.Instance(4, 15*(float) Math.PI/360, 2, 0, projectileIndex: 0)),
                    CooldownExact.Instance(1500, SimpleAttack.Instance(4, 1))
                    )
                ))
            .Init(0x3f07, Behaves("HermitOnDeathSetPiece",
                new RunBehaviors(
                    new QueuedBehavior(
                        MonsterSetPiece.Instance("HermitOnDeath1", 15),
                        Cooldown.Instance(500),
                        MonsterSetPiece.Instance("HermitOnDeath2", 15),
                        Cooldown.Instance(500),
                        MonsterSetPiece.Instance("HermitOnDeath3", 15),
                        Cooldown.Instance(500),
                        MonsterSetPiece.Instance("HermitOnDeath4", 15),
                        Cooldown.Instance(500),
                        MonsterSetPiece.Instance("HermitOnDeath5", 15),
                        Despawn.Instance
                        )
                    ))
            )
            ;
    }
}