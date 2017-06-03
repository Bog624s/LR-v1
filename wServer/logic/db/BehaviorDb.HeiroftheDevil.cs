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
        private static _ HotD = Behav()
            .Init(0x7093, Behaves("The Underground Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0xFF0000),
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
                                Flashing.Instance(1500, 0xFF0000)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new ItemLoot("Amulet of Resurrection"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wand of Spectral"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Pixie-Enchanted Sword")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Candy-coated Armor")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Candy Ring")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Fairy Plate")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Seal of the Enchanted Forest")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Ring of Pure Wishes"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(9, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(10, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
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
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Dark Eyes Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Dark Eyes Cloth"))
                    ))
                    )
                )
            )
            /*.Init(0x7092, Behaves("Ice Sphere",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Timed.Instance(2500, Circling.Instance(2, 20, 4, 0x5028)),
                            If.Instance(EntityLesserThan.Instance(10, 1, 0x5028),
                                new QueuedBehavior(
                                    Cooldown.Instance(2000),
                                    Chasing.Instance(14, 12, 1, null),
                                    RingAttack.Instance(36, offset: 0 * (float)Math.PI / 180,
                                        projectileIndex: 0),
                                    Die.Instance
                                    )
                                )
							)
                        )
                    )
                )
            )
            */
            
            .Init(0x7092, Behaves("Ice Sphere",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Circling.Instance(2, 100, 4, 0x5028),
                            If.Instance(EntityLesserThan.Instance(10, 1, 0x5028),
                                new QueuedBehavior(
                                    Cooldown.Instance(1000, Chasing.Instance(14, 12, 1, null)),
                                    CooldownExact.Instance(2000, 
                                        RingAttack.Instance(36, offset: 0 * (float)Math.PI / 180,
                                            projectileIndex: 0)
                                        ),
                                    CooldownExact.Instance(2150, Die.Instance)
                                    )
                                )
							)
                        )
                    )
                )
            )

            .Init(0x709f, Behaves("Lord of Empires Eyeball",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(1000),
                            SimpleWandering.Instance(30, 5),
                            RingAttack.Instance(36, offset: 0 * (float)Math.PI / 180,
                                projectileIndex: 0)
							)
                        )
                    )
                )
            )
            .Init(0x704b, Behaves("Heir of the Devil",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(400)
                                ),
                            new QueuedBehavior(
                                //HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)),
                                HpLesserPercent.Instance(0.99f, new SetKey(-1, 1))
                                //HpLesserPercent.Instance(0.85f, new SetKey(-1, 2)),
                                //HpLesserPercent.Instance(0.65f, new SetKey(-1, 3))
                                )
                            )
                        ),
        #region Initial
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            Cooldown.Instance(250, AngleAttack.Instance(0, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(45, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(90, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(135, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(180, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(225, projectileIndex: 0)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.85f, new SetKey(-1, 2)))
                            //new QueuedBehavior(HpLesserPercent.Instance(0.33f, new SetKey(-1, 2)))
                            )
                        ),
        #endregion
        #region Less Easy Difficult 99% to 85% HP
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            SmoothWandering.Instance(1.5f, 2f),
                            Cooldown.Instance(250, AngleAttack.Instance(0, projectileIndex: 1)),
                            Cooldown.Instance(250, AngleAttack.Instance(45, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(90, projectileIndex: 1)),
                            Cooldown.Instance(250, AngleAttack.Instance(135, projectileIndex: 0)),
                            Cooldown.Instance(250, AngleAttack.Instance(180, projectileIndex: 1)),
                            Cooldown.Instance(250, AngleAttack.Instance(225, projectileIndex: 0))
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new QueuedBehavior(
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 3))),
                            new QueuedBehavior(HpLesserPercent.Instance(0.65f, new SetKey(-1, 3)))
                            )
                        ),
        #endregion
        #region Talking Level 85% to 65% HP
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            new QueuedBehavior(
                            SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                            Cooldown.Instance(1500),
                            new SimpleTaunt("Hmm... Why are you invading my place?"),
                            Flashing.Instance(2500, 0xffff3333),
                            Cooldown.Instance(2000),
                            new SimpleTaunt("Now you got two options..."),
                            Flashing.Instance(2500, 0xffff3333),
                            Cooldown.Instance(2000),
                            new SimpleTaunt("Leave or stay here to battle..."),
                            Flashing.Instance(2500, 0xffff3333),
                            Cooldown.Instance(4000),
                            new SimpleTaunt("Hmmm! Already stay here!? Okay, you did it, now fell my strenght."),
                            Flashing.Instance(2500, 0xffff3333),
                            Cooldown.Instance(1250),
                            new SimpleTaunt("GATHERING POWER!!!"),
                            Flashing.Instance(5000, 0x00000000),
                            Cooldown.Instance(3000),
                            new SimpleTaunt("Gimme a break, it take a while..."),
                            new SetKey(-1, 4)
                                )
                            )
                        ),
        #endregion
        #region Medium Level 65% (Initial level to Tentacles of Wrath)
                    IfEqual.Instance(-1, 4,
                        new RunBehaviors(
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                        new QueuedBehavior(
                            HpLesserPercent.Instance(0.45f, new SetKey(-1, 5)),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180,
                                    projectileIndex: 0))),
                            Cooldown.Instance(250,
                                new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180,
                                    projectileIndex: 3)))
                                )
                            )
                        ),
        #endregion
        #region Initial of Tentacles of Wrath level
        IfEqual.Instance(-1, 5,
            new RunBehaviors(
                    new QueuedBehavior(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                        new SimpleTaunt("TENTACLES OF WRATH!!!"),
                        Flashing.Instance(15000, 0xffff3333),
                        new SetKey(-1, 6)
                    )
                )
            ),
        #endregion
        #region Avatar Shoots
                IfEqual.Instance(-1, 6,
                    new RunBehaviors(
                        new QueuedBehavior(
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 9 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 27 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 45 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 63 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 81 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 99 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 117 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 135 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 153 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 171 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0),
                                RingAttack.Instance(4, offset: 189 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            new SimpleTaunt("MUAHAHAHA! YOU CAN'T DEFEAT ME!"),
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                            Cooldown.Instance(2000),
                            //If.Instance(EntityLesserThan.Instance(2000, 2, 0x7092),
                                    SpawnMinion.Instance(0x7092, 0, 2, 12000, 12000),
                                    /*,
                                    Cooldown.Instance(1000),
                                    SpawnMinion.Instance(0x7092, 0, 1, 12000, 12000)*/
                                    //),
                            SimpleWandering.Instance(4, 8),
                            SetConditionEffect.Instance(ConditionEffectIndex.Invincible)
                        )
                    )),
        #endregion
                    If.Instance(CheckConditionEffects.Instance(new[] { ConditionEffects.Stunned }), new RunBehaviors(
                            Cooldown.Instance(3000, TossEnemyAtPlayer.Instance(20, 0x709f)), //Eyeball
                            Cooldown.Instance(4500, TossEnemyAtPlayer.Instance(20, 0x2f77)) //Arch Eyeball
                        ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x070e, 100, -1),
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x7093, 1, 1, 1))))
                }
                ))
            ;
    }
}