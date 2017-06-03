using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.logic.attack;
using wServer.logic.movement;
using wServer.logic.loot;
using wServer.logic.taunt;
using wServer.logic.cond;


namespace wServer.logic
{
  partial class BehaviorDb
  {
        static _ Shatters = Behav()
            .Init(0x709c, Behaves("The Shatters Sentinel Chest",
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
                                Flashing.Instance(1500, 0x8B2323)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.75, (ILoot)new ItemLoot("Potion of Mana"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Ancient Bracer of the Guardian")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("The Ancient Twilight Gemstone"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Bracer of the Guardian")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("The Twilight Gemstone"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Staff of the Rising Sun")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Thousand Suns Spell")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Robe of the Summer Solstice")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Ring of the Burning Sun"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(7, ItemType.Ring)),
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
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Twilight Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Twilight Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    )
                )
            )
            .Init(0x709d, Behaves("The Shatters King Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                    Flashing.Instance(3000, 0x000000),
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
                            Tuple.Create(0.45, (ILoot)new ItemLoot("Potion of Life"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("The Ancient Forgotten Crown"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("The Forgotten Crown"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Staff of the Rising Sun")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Thousand Suns Spell")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Robe of the Summer Solstice")),
                            Tuple.Create(greatloot, (ILoot)new ItemLoot("Ring of the Burning Sun"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(14, ItemType.Weapon)),
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(13, ItemType.Weapon)),
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(15, ItemType.Armor)),
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(14, ItemType.Armor)),
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(8, ItemType.Ring)),
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(7, ItemType.Ring)),
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ring)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(8, ItemType.Ability)),
                            Tuple.Create(awesomeloot, (ILoot)new TierLoot(7, ItemType.Ability)),
                            Tuple.Create(greatloot, (ILoot)new TierLoot(6, ItemType.Ability)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Evil Blob Egg")),
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
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Demonic Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Demonic Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    )
                )
            )
            .Init(0x5005, Behaves("Stone Knight",
                new RunBehaviors(
                    Chasing.Instance(4, 10, 2, null),
                    Cooldown.Instance(450, PredictiveMultiAttack.Instance(10, 5 * (float)Math.PI / 60, 2, 0, projectileIndex: 0)),
                    Cooldown.Instance(4200, PredictiveMultiAttack.Instance(10, 10 * (float)Math.PI / 180, 3, 1, projectileIndex: 1)
                    ))
                        ))
            .Init(0x5007, Behaves("Stone Mage",
                new RunBehaviors(
                    Chasing.Instance(6, 10, 6, null),
                    Cooldown.Instance(100, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 2, 0, projectileIndex: 0))
                    )
                        ))
            .Init(0x5006, Behaves("Fire Mage",
                new RunBehaviors(
                    Chasing.Instance(6, 10, 6, null),
                    Cooldown.Instance(450, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 2, 0, projectileIndex: 0)),
                    Cooldown.Instance(1000, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 1)),
                    Cooldown.Instance(1100, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 2, 0, projectileIndex: 2))
                    )
                        ))
            .Init(0x5009, Behaves("Ice Mage",
                new RunBehaviors(
                    Chasing.Instance(6, 10, 6, null),
                    Cooldown.Instance(2000, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 5, 0, projectileIndex: 0))
                    )
                        ))
            .Init(0x5011, Behaves("Fire Adept",
                new RunBehaviors(
                    Chasing.Instance(6, 10, 6, null),
                new QueuedBehavior(
                    Cooldown.Instance(300, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 0)),
                    Cooldown.Instance(600, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 1)),
                    Cooldown.Instance(900, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 2))
                    ))
                        ))
            .Init(0x5012, Behaves("Ice Adept",
                new RunBehaviors(
                    Chasing.Instance(8, 9, 5, null),
                    Cooldown.Instance(2500, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 8, 0, projectileIndex: 0)),
                    Cooldown.Instance(3500, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 1))
                    )
                        ))
            .Init(0x5013, Behaves("Titanum",
                new RunBehaviors(
                    Cooldown.Instance(200, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 0)),
                    Cooldown.Instance(5000, RingAttack.Instance(8, 0, 0, 0)),
                    If.Instance(
                    EntityGroupLesserThan.Instance(10, 10, "Titanumminions"),
                    Rand.Instance(
                    SpawnMinion.Instance(0x5005, 3, 1, 200000, 200000),
                    SpawnMinion.Instance(0x5007, 3, 1, 200000, 200000),
                    SpawnMinion.Instance(0x7092, 1, 1, 120000, 120000)
                    )))
                          ))
            .Init(0x5015, Behaves("Bridge Sentinel",
                new RunBehaviors(
                    Cooldown.Instance(3000, RingAttack.Instance(8, 0, 0, 0)),
                    HpLesserPercent.Instance(0.75f, new SetKey(-1, 5)),
                    Once.Instance(new SetKey(-1, 1)),
        #region Awake
 IfEqual.Instance(-1, 1,
                new RunBehaviors(
                    Cooldown.Instance(15000, (new SimpleTaunt("No one can cross this bridge!"))),
                new QueuedBehavior(
                    Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 0)),
                    Cooldown.Instance(110, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(120, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(130, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(600)
                    ),


                new QueuedBehavior(
                    Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                    Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                    ),


                new QueuedBehavior(
                    Cooldown.Instance(15000),
                    new SetKey(-1, 2))


                    )
                ),
        #endregion


        #region Sleepy
 IfEqual.Instance(-1, 2,
                new RunBehaviors(
                new QueuedBehavior(
                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    TossEnemy.Instance(180, 3, 0x5022),
                    TossEnemy.Instance(270, 3, 0x5022),
                    TossEnemy.Instance(90, 3, 0x5022),
                    If.Instance(IsEntityPresent.Instance(20000, 0x5022),
                    new SetKey(-1, 3)),
                    Cooldown.Instance(10000)


                ))),
                IfEqual.Instance(-1, 3,
                new RunBehaviors(
                    If.Instance(
                    EntityLesserThan.Instance(20000, 1, 0x5022),
                    new SetKey(-1, 4))
                    )),
        #endregion


        #region Awake2
 IfEqual.Instance(-1, 4,
                new RunBehaviors(
                    Cooldown.Instance(15000, new SimpleTaunt("You chose the wrong way, and you will die!")),
                new QueuedBehavior(
                    Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 5, 0, projectileIndex: 2)),
                    Cooldown.Instance(120, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 5, 0, projectileIndex: 3)),
                    Cooldown.Instance(600)
                    ),
                new QueuedBehavior(
                    Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                    Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                    ),
                new QueuedBehavior(
                    Cooldown.Instance(15000),
                    new SetKey(-1, 1)
                        )
                    )
                        ),
        #endregion


        #region NearDeath
 IfEqual.Instance(-1, 5,
                new QueuedBehavior(
                    If.Instance(EntityLesserThan.Instance(40, 5, 0x70aa), 
                            CooldownExact.Instance(10000,
                                new QueuedBehavior(
								    TossEnemy.Instance(0*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(30*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(60*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(90*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(120*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(150*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(180*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(210*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(240*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(270*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(300*(float) Math.PI/180, 5, 0x70aa),
								    TossEnemy.Instance(330*(float) Math.PI/180, 5, 0x70aa)
                                    )
                                )
                            ),
                    Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 5, 0, projectileIndex: 2)),
                    Cooldown.Instance(110, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 5, 0, projectileIndex: 3)),
                    Cooldown.Instance(120, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                    Cooldown.Instance(130, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(150, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                    Cooldown.Instance(800))
                    )
        #endregion
),
                condBehaviors: new ConditionalBehavior[]
                {
                    //new DeathPortal(0x070e, 100, -1),
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x709c, 1, 1, 1))))
                }
                /*condBehaviors: new ConditionalBehavior[] {
                    new OnDeath(
                        new QueuedBehavior(
                    Once.Instance(SpawnMinionImmediate.Instance(0x5033, 5, 1, 1)),
                    Once.Instance(new SimpleTaunt("Your army was stronger.")),
                    Once.Instance(new SimpleTaunt("You deserve to cross."))))
                }*/
                    ))


        .Init(0x5022, Behaves("Paladin Obelisk",
            new RunBehaviors(
                Cooldown.Instance(3000, RingAttack.Instance(8, 0, 0, 0)),
                Cooldown.Instance(600, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 8, 0, projectileIndex: 0)),
                Cooldown.Instance(600, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 8, 0, projectileIndex: 1)),
                        If.Instance(
                            EntityLesserThan.Instance(20, 10, 0x5020),
                            Rand.Instance(
                 Cooldown.Instance(120000, SpawnMinionImmediate.Instance(0x5020, 5, 1, 1)))
                )),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                   Tuple.Create(0.015, (ILoot)new ItemLoot("Potion of Dexterity"))
                    )))
                           ))
        /* OLD
        .Init(0x5020, Behaves("Stone Paladin",
            new RunBehaviors(
                Chasing.Instance(4, 9, 1, null),
                Cooldown.Instance(1000, MultiAttack.Instance(4, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 0))
                ),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.05, (ILoot)new ItemLoot("Potion of Wisdom"))
                                )
                            )
                        )
                )
            )*/
            
        .Init(0x5020, Behaves("Stone Paladin",
                new QueuedBehavior(
                    UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Timed.Instance(2500, False.Instance(Chasing.Instance(4, 10, 2, null))),
                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    If.Instance(IsEntityPresent.Instance(8, null),
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
                        )
                    ),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.005, (ILoot)new ItemLoot("Potion of Wisdom"))
                                )
                            )
                        )
                )
            )
                     .Init(0x5027, Behaves("Archmage of Flame",
            new RunBehaviors(
                Chasing.Instance(6, 10, 6, null),
            new QueuedBehavior(
                Cooldown.Instance(30, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                Cooldown.Instance(60, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                Cooldown.Instance(90, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                Cooldown.Instance(110, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 4, 0, projectileIndex: 0)),
                Cooldown.Instance(130, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 1)),
                Cooldown.Instance(800)
                    )),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.005, (ILoot)new ItemLoot("Potion of Vitality"))
                        )))
                        ))
                     .Init(0x5028, Behaves("Glassier Archmage",
            new RunBehaviors(
                Chasing.Instance(6, 10, 6, null),
            new QueuedBehavior(
                Cooldown.Instance(30, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 6, 0, projectileIndex: 0)),
                Cooldown.Instance(60, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 6, 0, projectileIndex: 0)),
                Cooldown.Instance(90, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 6, 0, projectileIndex: 0)),
                Cooldown.Instance(110, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 6, 0, projectileIndex: 0)),
                Cooldown.Instance(130, MultiAttack.Instance(8, 5 * (float)Math.PI / 100, 6, 0, projectileIndex: 1)),
                If.Instance(EntityLesserThan.Instance(2000, 20, 0x7092),
                    Cooldown.Instance(5000,
                        TossEnemyAtPlayer.Instance(4, 0x7092)
                    )
                    //SpawnMinion.Instance(0x7092, 3, 1, 20000, 20000)
                    )
                    )),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.005, (ILoot)new ItemLoot("Potion of Defense"))
                        )))
                        ))
        .Init(0x5033, Behaves("Bridge Despawner",
            new RunBehaviors(
                Chasing.Instance(4, 10, 2, null),
                    OrderAllEntity.Instance(25, 0x5029, Despawn.Instance))
                ))
        .Init(0x5034, Behaves("Twilight Archmage",
            new RunBehaviors(
                Cooldown.Instance(3000, RingAttack.Instance(8, 0, 0, 0)),
                HpLesserPercent.Instance(0.2f, new SetKey(-1, 3)),
                Once.Instance(new SetKey(-1, 1)),
                Cooldown.Instance(10000, (RingAttack.Instance(6, 0, 2, projectileIndex: 5))),
    #region Awake
 IfEqual.Instance(-1, 1,
            new RunBehaviors(
                Cooldown.Instance(15000, (new SimpleTaunt("Who are you? Leave the Shatters!"))),
            new QueuedBehavior(
                Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 9, 0, projectileIndex: 0)),
                Cooldown.Instance(110, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 9, 0, projectileIndex: 1)),
                Cooldown.Instance(2000)
                ),


            new QueuedBehavior(
                Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                ),


            new QueuedBehavior(
                Cooldown.Instance(15000),
                new SetKey(-1, 2))


                )
            ),
    #endregion


    #region Pissed
 IfEqual.Instance(-1, 2,
            new RunBehaviors(
                Cooldown.Instance(15000, (new SimpleTaunt("Feel the power of darkness!!"))),
            new QueuedBehavior(
                Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 2)),
                Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 3)),
                Cooldown.Instance(180, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 4)),
                Cooldown.Instance(220, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 5)),
                Cooldown.Instance(260, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(800)
                ),


            new QueuedBehavior(
                Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                ),


            new QueuedBehavior(
                Cooldown.Instance(15000),
                new SetKey(-1, 1))


                )
            ),
    #endregion


    #region Extremely Pissed
 IfEqual.Instance(-1, 3,
            new RunBehaviors(
                SimpleWandering.Instance(2, 3f),
                Cooldown.Instance(860, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(15000, (new SimpleTaunt("YOUR SOUL WILL BE FOREVER MINE!!!"))),
            new QueuedBehavior(
                Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 2)),
                Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 3)),
                Cooldown.Instance(180, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 4)),
                Cooldown.Instance(220, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 3, 0, projectileIndex: 5)),
                Cooldown.Instance(260, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(600)
                ),


            new QueuedBehavior(
                Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                ),


            new QueuedBehavior(
                Cooldown.Instance(15000),
                new SetKey(-1, 1))


                )
            )
    #endregion
),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.15, (ILoot)new ItemLoot("Potion of Mana")),
                        Tuple.Create(0.001, (ILoot)new ItemLoot("Void Incantation")),
                        Tuple.Create(0.005, (ILoot)new ItemLoot("Wine Cellar Incantation")),
                        Tuple.Create(0.15, (ILoot)new ItemLoot("Potion of Defense")),
                        Tuple.Create(0.15, (ILoot)new TierLoot(4, ItemType.Ring)),
                        Tuple.Create(0.15, (ILoot)new TierLoot(5, ItemType.Ring)),
                        Tuple.Create(0.15, (ILoot)new TierLoot(4, ItemType.Ability)),
                        Tuple.Create(0.15, (ILoot)new TierLoot(5, ItemType.Ability)),
                        Tuple.Create(0.15, (ILoot)new TierLoot(9, ItemType.Weapon)),
                        Tuple.Create(0.15, (ILoot)new TierLoot(10, ItemType.Weapon))
                        ))
                    ),
                condBehaviors: new ConditionalBehavior[] {
                    new OnDeath(
                        new QueuedBehavior(
                    Once.Instance(SpawnMinionImmediate.Instance(0x5042, 5, 1, 1)),
                    Once.Instance(new SimpleTaunt("You were strong enough...")),
                    Once.Instance(new SimpleTaunt("My Lord awaits you."))))
                }
                    ))
            .Init(0x5042, Behaves("Gate Killer", //                      Heal.Instance(5000, 1000000, 0x0935),
            new RunBehaviors(
                Chasing.Instance(4, 10, 2, null),
                    OrderAllEntity.Instance(25, 0x5029, Despawn.Instance))
                ))
            .Init(0x5047, Behaves("Royal Guardian",
            new RunBehaviors(
                Once.Instance(new SetKey(-1, 1)),
                Cooldown.Instance(10000, (RingAttack.Instance(11, 0, 2, projectileIndex: 2))),
    #region Birth
 IfEqual.Instance(-1, 1,
            new RunBehaviors(
                Chasing.Instance(8, 10, 2, null),
                Once.Instance((new SimpleTaunt("WE DEFEND THE KING!"))),
            new RunBehaviors(
                UnsetConditionEffect.Instance((ConditionEffectIndex.Invulnerable)),
                Cooldown.Instance(800, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 1)
                ),


            new QueuedBehavior(
                Cooldown.Instance(25000),
                NullBehavior.Instance,
                new SetKey(-1, 2))


                )
            )),
    #endregion


    #region Heal
 IfEqual.Instance(-1, 2,
            new RunBehaviors(
                SetConditionEffect.Instance((ConditionEffectIndex.Invulnerable)),
                Chasing.Instance(40, 10, 1, 0x5030), //Middle Stone Guardian Anchor
                Heal.Instance(5000, 1000000, 0x5047),
            new QueuedBehavior(
                Cooldown.Instance(5000),
                NullBehavior.Instance,
                new SetKey(-1, 1))


                )
            )
    #endregion
),
                   loot: new LootBehavior(LootDef.Empty,
                   Tuple.Create(100, new LootDef(0, 5, 0, 10,
                        Tuple.Create(0.01, (ILoot)new ItemLoot("Potion of Wisdom"))
                        )))
                        ))
            .Init(0x5048, Behaves("The Forgotten King",
            new RunBehaviors(
                HpLesserPercent.Instance(0.8f, new SetKey(-1, 4)),
                Once.Instance(new SetKey(-1, 1)),
    #region Awake
 IfEqual.Instance(-1, 1,
            new RunBehaviors(
                 ReturnSpawn.Instance(2),
                Once.Instance(new SimpleTaunt("Who dares to interrupt the Shatters?")),
                Once.Instance(new SimpleTaunt("Ah, it's you, heroes... Finally, a deserved rivals to challenge with!")),
            new QueuedBehavior(
                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                SpawnMinionImmediate.Instance(0x5047, 5, 5, 5),
                If.Instance(IsEntityPresent.Instance(80, 0x5047),
                new SetKey(-1, 3)),
                Cooldown.Instance(10000)


            ))),
            IfEqual.Instance(-1, 3,
            new RunBehaviors(
                If.Instance(
                EntityLesserThan.Instance(80, 1, 0x5047),
                new SetKey(-1, 2))
                )),
    #endregion


    #region Pissed
 IfEqual.Instance(-1, 2,
            new RunBehaviors(
                Cooldown.Instance(15000, (new SimpleTaunt("Kneel before me, and I'll save your worthless lives!"))),
            new QueuedBehavior(
                            ReturnSpawn.Instance(2),
                Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 3)),
                Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(180, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 4)),
                Cooldown.Instance(220, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 3)),
                Cooldown.Instance(260, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 5)),
                Cooldown.Instance(800)
                ),


            new QueuedBehavior(
                Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                ),


            new QueuedBehavior(
                Cooldown.Instance(15000),
                new SetKey(-1, 1))


                )
            ),
    #endregion


    #region Extremely Pissed
 IfEqual.Instance(-1, 4,
            new RunBehaviors(
                            ReturnSpawn.Instance(2),
                SimpleWandering.Instance(2, 3f),
                Cooldown.Instance(860, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(15000, (new SimpleTaunt("YOU WILL BE BURIED HERE WITH ME!!!"))),
            new QueuedBehavior(
                Cooldown.Instance(100, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 1)),
                Cooldown.Instance(140, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 6)),
                Cooldown.Instance(180, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 4)),
                Cooldown.Instance(220, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 3)),
                Cooldown.Instance(260, MultiAttack.Instance(10, 5 * (float)Math.PI / 100, 1, 0, projectileIndex: 5)),
                Cooldown.Instance(600)
                ),


            new QueuedBehavior(
                Cooldown.Instance(3000, (SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))),
                Cooldown.Instance(5000, (UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)))
                )
                )
            )
    #endregion
),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x070e, 100, -1),
                    new OnDeath(
                        Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x709d, 1, 1, 1))))
                }
                /*condBehaviors: new ConditionalBehavior[] {
                    new OnDeath(
                        new QueuedBehavior(
                    Once.Instance(new SimpleTaunt("My Kingdom has lost again,")),
                    Once.Instance(new SimpleTaunt("My family and friends murdered,")),
                    Once.Instance(new SimpleTaunt("All so you monsters can get hands on some loot..."))))
                }*/
                    ));
  }
}

