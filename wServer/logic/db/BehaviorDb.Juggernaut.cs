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
        private static _ Jugg = Behav()
            .Init(0x70e8, Behaves("Undertaker the Great Juggernaut",
                Once.Instance(new SetKey(-1, 1)),
                new RunBehaviors(
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            new SimpleTaunt("Of all the kingdoms this is the most chaotic I've ever visited..."),
                            Cooldown.Instance(2000),
                            new SimpleTaunt("These humans... Every time disturb the kingdom of Oryx!"),
                            Cooldown.Instance(4000),
                            new SimpleTaunt("This may not be acceptable! I do my duty..."),
                            Cooldown.Instance(2000),
                            new SimpleTaunt("This time I am the law here!"),
                            Cooldown.Instance(1000),
                            new SetKey(-1, 2)
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            Cooldown.Instance(7000),
                            TossEnemy.Instance(0, 5, 0x70e9),
                            TossEnemy.Instance(90, 5, 0x70e9),
                            TossEnemy.Instance(180, 5, 0x70e9),
                            TossEnemy.Instance(270, 5, 0x70e9),
                            TossEnemy.Instance(0, 10, 0x70e9),
                            TossEnemy.Instance(90, 10, 0x70e9),
                            TossEnemy.Instance(180, 10, 0x70e9),
                            TossEnemy.Instance(270, 10, 0x70e9),
                            TossEnemy.Instance(0, 15, 0x70e9),
                            TossEnemy.Instance(90, 15, 0x70e9),
                            TossEnemy.Instance(180, 15, 0x70e9),
                            TossEnemy.Instance(270, 15, 0x70e9),
                            TossEnemy.Instance(0, 25, 0x70e9),
                            TossEnemy.Instance(90, 25, 0x70e9),
                            TossEnemy.Instance(180, 25, 0x70e9),
                            TossEnemy.Instance(270, 25, 0x70e9),
                            new SimpleTaunt("Prepare to fight... It's just beginning!"),
                            Cooldown.Instance(4000),
                            new SetKey(-1, 16)                            
                            )
                        ),
                    IfEqual.Instance(-1, 16,
                        new RunBehaviors(
                            If.Instance(EntityLesserThan.Instance(20, 1, 0x70e9), new SetKey(-1, 3))
                            )
                        ),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            CooldownExact.Instance(500, RingAttack.Instance(16, 12, 16, 0)),
                            If.Instance(EntityLesserThan.Instance(40, 5, 0x70aa), 
                                CooldownExact.Instance(10000,
                                    new QueuedBehavior(
								        TossEnemy.Instance(0*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(30*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(60*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(90*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(120*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(150*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(180*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(210*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(240*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(270*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(300*(float) Math.PI/180, 12, 0x70aa),
								        TossEnemy.Instance(330*(float) Math.PI/180, 12, 0x70aa)
                                        )
                                    )
                                ),
                            HpLesserPercent.Instance(0.5f, new SetKey(-1, 5))
                            )
                        ),
                    IfEqual.Instance(-1, 5,
                        new RunBehaviors(
                            /*If.Instance(CheckConditionEffects.Instance(new[] {ConditionEffects.Stunned}), new RunBehaviors(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                                UnsetConditionEffect.Instance(ConditionEffectIndex.Stunned),
                                Cooldown.Instance(2000),
                                new SimpleTaunt("Your fragile stun cannot stop me..."),
                                Cooldown.Instance(1000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invincible)),
                                new SetKey(-1, 5)
                                )),
                            If.Instance(CheckConditionEffects.Instance(new[] {ConditionEffects.Weak}), new RunBehaviors(
                                UnsetConditionEffect.Instance(ConditionEffectIndex.Weak),
                                new SetKey(-1, 5)
                                )),*/
                            new QueuedBehavior(
                                Chasing.Instance(4, 12, 1, null),
                                CooldownExact.Instance(25000, new SetConditionEffectTimed(ConditionEffectIndex.Armored, 5000)),
                                CooldownExact.Instance(2000, MultiAttack.Instance(12, 0, 3, 0, 0)),
                                HpLesserPercent.Instance(0.3f, new SetKey(-1, 6))
                                )
                            )
                        ),
                    IfEqual.Instance(-1, 6,
                        new RunBehaviors(
                            Cooldown.Instance(125, Heal.Instance(0.1f, 9999, 0x70e8)),
                            HpGreaterEqual.Instance(500000, new SetKey(-1, 7))
                            )
                        ),
                    IfEqual.Instance(-1, 7,
                        new RunBehaviors(
                            SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            new SimpleTaunt("I did say, this battle was begin..."),
                            Cooldown.Instance(2000),
                            new SimpleTaunt("GATHERING POWER!"),
                            Flashing.Instance(3000, 0x00000000),
                            new SimpleTaunt("FURIUS BESERKER!"),
                            new SetKey(-1, 8)
                            )
                        ),
                    IfEqual.Instance(-1, 8,
                        new RunBehaviors(
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            new QueuedBehavior(
                                Chasing.Instance(20, 12, 1, null),
                                //CooldownExact.Instance(5000, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                                CooldownExact.Instance(15000, new SetConditionEffectTimed(ConditionEffectIndex.Berserk, 5000)),
                                CooldownExact.Instance(5000,
                                    new QueuedBehavior(
                                        //new SimpleTaunt("ULTIMATE STRIKE!"),
                                        Flashing.Instance(1000, 0x00000000),
                                        new QueuedBehavior(
                                            Cooldown.Instance(200),
                                            new RunBehaviors(
                                                RingAttack.Instance(4, offset: 0*(float) Math.PI/180),
                                                RingAttack.Instance(4, offset: 90*(float) Math.PI/180)
                                                ),
                                            Cooldown.Instance(200),
                                            new RunBehaviors(
                                                RingAttack.Instance(4, offset: 10*(float) Math.PI/180),
                                                RingAttack.Instance(4, offset: 80*(float) Math.PI/180)
                                                ),
                                            Cooldown.Instance(200),
                                            new RunBehaviors(
                                                RingAttack.Instance(4, offset: 20*(float) Math.PI/180),
                                                RingAttack.Instance(4, offset: 70*(float) Math.PI/180)
                                                ),
                                            Cooldown.Instance(200),
                                            new RunBehaviors(
                                                RingAttack.Instance(4, offset: 30*(float) Math.PI/180),
                                                RingAttack.Instance(4, offset: 60*(float) Math.PI/180)
                                                ),
                                            Cooldown.Instance(200),
                                            new RunBehaviors(
                                                RingAttack.Instance(4, offset: 40*(float) Math.PI/180),
                                                RingAttack.Instance(4, offset: 50*(float) Math.PI/180)
                                                ),
                                            Cooldown.Instance(250)
                                            )
                                    ))
                                )
                            )
                        )
                ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x5050, 50, 600),
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70ea, 1, 1, 1))))
                }
            )
                )
            
            .Init(0x70e9, Behaves("Undertaker Portal",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(500,
                                RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
                                )
                            )
                        )
                    )
                )
            )
            
            
            
            
            .Init(0x70ea, Behaves("Undertaker the Great Juggernaut Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0x8B2323),
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
                                Flashing.Instance(1500, 0x000000)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.05, (ILoot)new ItemLoot("Potion of Life")),
                            Tuple.Create(0.1, (ILoot)new ItemLoot("Potion of Mana"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Glove of the Elder Juggernaut")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Helm of the Armored Juggernaut")),
                            Tuple.Create(whitebag, (ILoot) new ItemLoot("Helm of the Juggernaut")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Sword of the Juggernaut")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Heavyarmor of the Juggernaut")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Ring of the Great Juggernaut"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ring)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ability)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            //Tuple.Create(blackbag, (ILoot) new DivineEgg(1)),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Gold Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Cyan Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Blue Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Red Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Green Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Evil Blob Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Twilight Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Twilight Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    //new DeathPortal(0x070e, 100, -1),
                    new DeathPortal(0x7235, 10, 600),
                }
                )
            )
            
            
            ;
    }
}