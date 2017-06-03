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
        private static _ AvatarBehav = Behav()
        #region old avatar behavior until v8.1.72
            /*.Init(0x7083, Behaves("Avatar of the Forgotten King",
                If.Instance(IsEntityPresent.Instance(35, null),
                    new RunBehaviors(
                        Once.Instance(IsEntityPresent.Instance(1, null)),
                        new QueuedBehavior(
        #region circle avatar 1
                            Rand.Instance(
                                new SimpleTaunt("BURN!"),
                                new SimpleTaunt("Foolish whelps... leave me be..."),
                                new SimpleTaunt("HAHAHAHAHAHA!"),
                                new SimpleTaunt("LEAVE THIS PLACE!"),
                                new SimpleTaunt("I must gather my strength...")
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Rand.Instance(
                                new SimpleTaunt("BURN!"),
                                new SimpleTaunt("Foolish whelps... leave me be..."),
                                new SimpleTaunt("HAHAHAHAHAHA!"),
                                new SimpleTaunt("LEAVE THIS PLACE!"),
                                new SimpleTaunt("I must gather my strength...")
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
        #endregion
        #region circle avatar 2
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Rand.Instance(
                                new SimpleTaunt("BURN!"),
                                new SimpleTaunt("Foolish whelps... leave me be..."),
                                new SimpleTaunt("HAHAHAHAHAHA!"),
                                new SimpleTaunt("LEAVE THIS PLACE!"),
                                new SimpleTaunt("I must gather my strength...")
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(
                                    RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(

                                RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
                                ),
                            Rand.Instance(
                                new SimpleTaunt("BURN!"),
                                new SimpleTaunt("Foolish whelps... leave me be..."),
                                new SimpleTaunt("HAHAHAHAHAHA!"),
                                new SimpleTaunt("LEAVE THIS PLACE!"),
                                new SimpleTaunt("I must gather my strength...")
                                ),
                            Flashing.Instance(150, 0xFFFFFF), Cooldown.Instance(150),
                            new RunBehaviors(
                                Cooldown.Instance(4000,
                                    RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
                                    )
                                )
        #endregion
                            )
                        )
                    ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.45, (ILoot)new ItemLoot("Potion of Life"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(WBChance / 10, (ILoot)new ItemLoot("Pirate King's Cutlass")),
                            Tuple.Create(WBChance / 10, (ILoot)new ItemLoot("Doku No Ken"))
                    )),
                        Tuple.Create(100, new LootDef(0, 8, 0, 8,
                            Tuple.Create(WBChance, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(WBChance * 1.25, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(WBChance * 1.75, (ILoot)new TierLoot(9, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(WBChance, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(WBChance * 1.25, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(WBChance * 1.75, (ILoot)new TierLoot(10, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(WBChance, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(WBChance * 2, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(WBChance * 4, (ILoot)new TierLoot(3, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(WBChance / 2, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(WBChance, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(WBChance * 2, (ILoot)new TierLoot(3, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(WBChance * 1.5, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(WBChance * 1.75, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(WBChance * 2, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(WBChance * 2.25, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(WBChance * 2.5, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x5050, 45, 300)
                }
                )
            )*/
        #endregion

            
			/*
				ObjectID used by this behavior script (Avatar Full Behavior Script by Devwarlt):
					- 0x70a0 (Shades of the Avatar)	[Behavior: NO] | [XML: OK]
					- 0x70a9 (Eye of the Avatar) 	[Behavior: NO] | [XML: OK]
					- 0x70aa (Blobomb)				[Behavior: NO] | [XML: OK]
					- 0x70ab (Killer Pillar)		[Behavior: NO] | [XML: OK]
			*/

            
            .Init(0x70a0, Behaves("Shades of the Avatar",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(350,
                                RingAttack.Instance(6, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Cooldown.Instance(1000,
                                SimpleAttack.Instance(12, projectileIndex: 1)
                                )
                            )
                        )
                    )
                )
            )
            .Init(0x70a9, Behaves("Eye of the Avatar",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    Circling.Instance(4, 100, 10, 0x7083),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Circling.Instance(4, 100, 10, 0x7083),
                            CooldownExact.Instance(500,
                                SimpleAttack.Instance(12, projectileIndex: 0)
                                )
                            )
                        )
                    )
                )
            )
            .Init(0x70aa, Behaves("Blobomb",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    Chasing.Instance(10, 18, 0, null),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(1650),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Flashing.Instance(250, 0xffff3333),
                            Cooldown.Instance(250,
                                RingAttack.Instance(36, offset: 0 * (float)Math.PI / 180,
                                    projectileIndex: 0)
                                ),
                            Die.Instance
                            )
                        )
                    )
                )
            )
            
            .Init(0x70ab, Behaves("Killer Pillar",
                new RunBehaviors(
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(150,
                                RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
                                ),
                            Cooldown.Instance(1000,
                                SimpleAttack.Instance(12, projectileIndex: 1)
                                )
                            )
                        )
                    )
                )
            )
        
            .Init(0x7083, Behaves("Avatar of the Forgotten King",
                If.Instance(IsEntityPresent.Instance(35, null),
                    new RunBehaviors(
						Once.Instance(new SetKey(-1, 0)),
						IfEqual.Instance(-1, 0,
							new QueuedBehavior(
			#region circle avatar 1
								HpLesserPercent.Instance(0.9f, new SetKey(-1, 1)),
								Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
								Rand.Instance(
									new SimpleTaunt("BURN!"),
									new SimpleTaunt("Foolish whelps... leave me be..."),
									new SimpleTaunt("HAHAHAHAHAHA!"),
									new SimpleTaunt("LEAVE THIS PLACE!"),
									new SimpleTaunt("I must gather my strength...")
									),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
								Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
								Rand.Instance(
									new SimpleTaunt("BURN!"),
									new SimpleTaunt("Foolish whelps... leave me be..."),
									new SimpleTaunt("HAHAHAHAHAHA!"),
									new SimpleTaunt("LEAVE THIS PLACE!"),
									new SimpleTaunt("I must gather my strength...")
									),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
									),
								Cooldown.Instance(250),
			#endregion
			#region circle avatar 2
								new RunBehaviors(
									RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								new RunBehaviors(
									RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
									),
								Cooldown.Instance(250),
								Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
								Rand.Instance(
									new SimpleTaunt("BURN!"),
									new SimpleTaunt("Foolish whelps... leave me be..."),
									new SimpleTaunt("HAHAHAHAHAHA!"),
									new SimpleTaunt("LEAVE THIS PLACE!"),
									new SimpleTaunt("I must gather my strength...")
									),
								new RunBehaviors(
									Cooldown.Instance(4000,
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
										)
									),
								Cooldown.Instance(250)
			#endregion
								)
							),
						IfEqual.Instance(-1, 1,
							new RunBehaviors(
								SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
								Flashing.Instance(500, 0xffff3333),
								Cooldown.Instance(4000),
								TossEnemy.Instance(0*(float) Math.PI/180, 6, 0x70a0),
								TossEnemy.Instance(60*(float) Math.PI/180, 6, 0x70a0),
								TossEnemy.Instance(120*(float) Math.PI/180, 6, 0x70a0),
								TossEnemy.Instance(180*(float) Math.PI/180, 6, 0x70a0),
								TossEnemy.Instance(240*(float) Math.PI/180, 6, 0x70a0),
								TossEnemy.Instance(300*(float) Math.PI/180, 6, 0x70a0),
                                Cooldown.Instance(5000),
								new SetKey(-1, 2)
								)
							),
						IfEqual.Instance(-1, 2,
							new RunBehaviors(
								Flashing.Instance(500, 0xffff3333),
								IfNot.Instance(
									IsEntityPresent.Instance(20, 0x70a0),
									new SetKey(-1, 3)
									)
								)
							),
						IfEqual.Instance(-1, 3,
							new RunBehaviors(
								UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
								Flashing.Instance(4000, 0xffff3333),
								Cooldown.Instance(250),
								new SetKey(-1, 4)
								)
							),
						IfEqual.Instance(-1, 4,
							new RunBehaviors(
								new QueuedBehavior(
				#region circle avatar 1
									HpLesserPercent.Instance(0.7f, new SetKey(-1, 5)),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
				#endregion
				#region circle avatar 2
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										Cooldown.Instance(4000,
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
											)
										),
									Cooldown.Instance(250)
				#endregion
									)
								)
							),
						IfEqual.Instance(-1, 5,
							new RunBehaviors(
								new QueuedBehavior(
									SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
									Cooldown.Instance(1500),
									new SimpleTaunt("BURN! You will not enter in Shatters! My eyes protect me!"),
									Flashing.Instance(500, 0xffff3333),
									Cooldown.Instance(7000),
									TossEnemy.Instance(0*(float) Math.PI/180, 2, 0x70a9),
									TossEnemy.Instance(60*(float) Math.PI/180, 2, 0x70a9),
									TossEnemy.Instance(120*(float) Math.PI/180, 2, 0x70a9),
									TossEnemy.Instance(180*(float) Math.PI/180, 2, 0x70a9),
									TossEnemy.Instance(240*(float) Math.PI/180, 2, 0x70a9),
									TossEnemy.Instance(300*(float) Math.PI/180, 2, 0x70a9),
                                    Cooldown.Instance(5000),
									new SetKey(-1, 6)
									)
								)
							),
						IfEqual.Instance(-1, 6,
							new RunBehaviors(
								Flashing.Instance(500, 0xffff3333),
                                CooldownExact.Instance(10000,
                                    new QueuedBehavior(
                                        If.Instance(EntityLesserThan.Instance(10, 1, 0x70a9),
                                            new RunBehaviors(
									            TossEnemy.Instance(0*(float) Math.PI/180, 2, 0x70a9),
									            TossEnemy.Instance(60*(float) Math.PI/180, 2, 0x70a9),
									            TossEnemy.Instance(120*(float) Math.PI/180, 2, 0x70a9),
									            TossEnemy.Instance(180*(float) Math.PI/180, 2, 0x70a9),
									            TossEnemy.Instance(240*(float) Math.PI/180, 2, 0x70a9),
									            TossEnemy.Instance(300*(float) Math.PI/180, 2, 0x70a9)
                                                )
                                            )
                                        )
                                    ),
								IfNot.Instance(
									IsEntityPresent.Instance(20, 0x70a9),
									new SetKey(-1, 7)
									)
								)
							),
						IfEqual.Instance(-1, 7,
							new RunBehaviors(
								UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
								Flashing.Instance(4000, 0xffff3333),
								Cooldown.Instance(250),
								new SetKey(-1, 8)
								)
							),
						IfEqual.Instance(-1, 8,
							new RunBehaviors(
								new QueuedBehavior(
				#region circle avatar 1
									HpLesserPercent.Instance(0.5f, new SetKey(-1, 9)),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
				#endregion
				#region circle avatar 2
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										Cooldown.Instance(4000,
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
											)
										),
									Cooldown.Instance(250)
				#endregion
									)
								)
							),
						IfEqual.Instance(-1, 9,
							new RunBehaviors(
								new QueuedBehavior(
									SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
									Cooldown.Instance(1500),
									new SimpleTaunt("BURN! You will not enter in Shatters! My blobombs protect me and BURN YOU!"),
									Flashing.Instance(500, 0xffff3333),
									Cooldown.Instance(7000),
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
									TossEnemy.Instance(330*(float) Math.PI/180, 12, 0x70aa),
                                    Cooldown.Instance(5000),
									new SetKey(-1, 10)
									)
								)
							),
						IfEqual.Instance(-1, 10,
							new RunBehaviors(
								Flashing.Instance(500, 0xffff3333),
								IfNot.Instance(
									IsEntityPresent.Instance(20, 0x70aa),
									new SetKey(-1, 11)
									)
								)
							),
						IfEqual.Instance(-1, 11,
							new RunBehaviors(
								UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
								Flashing.Instance(4000, 0xffff3333),
								Cooldown.Instance(250),
								new SetKey(-1, 12)
								)
							),
						IfEqual.Instance(-1, 12,
							new RunBehaviors(
								new QueuedBehavior(
				#region circle avatar 1
									HpLesserPercent.Instance(0.4f, new SetKey(-1, 13)),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
				#endregion
				#region circle avatar 2
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										Cooldown.Instance(4000,
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
											)
										),
									Cooldown.Instance(250)
				#endregion
									)
								)
							),
						IfEqual.Instance(-1, 13,
							new RunBehaviors(
								new QueuedBehavior(
									SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
									Cooldown.Instance(1500),
									new SimpleTaunt("BURN! You will not enter in Shatters! My killer pillars protect me!"),
									Flashing.Instance(500, 0xffff3333),
									Cooldown.Instance(7000),
									TossEnemy.Instance(45*(float) Math.PI/180, 6, 0x70ab),
									TossEnemy.Instance(135*(float) Math.PI/180, 6, 0x70ab),
									TossEnemy.Instance(225*(float) Math.PI/180, 6, 0x70ab),
									TossEnemy.Instance(315*(float) Math.PI/180, 6, 0x70ab),
                                    Cooldown.Instance(5000),
									new SetKey(-1, 14)
									)
								)
							),
						IfEqual.Instance(-1, 14,
							new RunBehaviors(
								Flashing.Instance(500, 0xffff3333),
								IfNot.Instance(
									IsEntityPresent.Instance(20, 0x70ab),
									new SetKey(-1, 15)
									)
								)
							),
						IfEqual.Instance(-1, 15,
							new RunBehaviors(
								UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
								Flashing.Instance(4000, 0xffff3333),
								Cooldown.Instance(250),
								new SetKey(-1, 16)
								)
							),
						IfEqual.Instance(-1, 16,
							new RunBehaviors(
								new QueuedBehavior(
				#region circle avatar 1
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 0)
										),
									Cooldown.Instance(250),
				#endregion
				#region circle avatar 2
									new RunBehaviors(
										RingAttack.Instance(4, offset: 0 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 180 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 162 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 144 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 126 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 108 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 90 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 72 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 54 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									new RunBehaviors(
										RingAttack.Instance(4, offset: 36 * (float)Math.PI / 180, projectileIndex: 1)
										),
									Cooldown.Instance(250),
									Flashing.Instance(150, 0xffff3333), Cooldown.Instance(150),
									Rand.Instance(
										new SimpleTaunt("BURN!"),
										new SimpleTaunt("Foolish whelps... leave me be..."),
										new SimpleTaunt("HAHAHAHAHAHA!"),
										new SimpleTaunt("LEAVE THIS PLACE!"),
										new SimpleTaunt("I must gather my strength...")
										),
									new RunBehaviors(
										Cooldown.Instance(4000,
											RingAttack.Instance(4, offset: 18 * (float)Math.PI / 180, projectileIndex: 1)
											)
										),
									Cooldown.Instance(250)
				#endregion
									)
								)
							)
						)
                    ),
                    loot: new LootBehavior(LootDef.Empty,
					/*
						t9-11 wpn ok
						t9-12 arm ok
						t5 abi ok
						stats pots
						tablet (not added)
					*/
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Resurrected Warrior's Armor"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(11, ItemType.Weapon)),
                            Tuple.Create(goodloot, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(9, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(12, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(10, ItemType.Armor)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(9, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 3, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Gold Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Cyan Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Blue Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Red Dragon Lord Egg")),
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Green Dragon Lord Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x5050, 75, 600),
                    new OnDeath(
						new RunBehaviors(
							new SimpleTaunt("Nooooooo! The Forgotten King will defeat you!!!")
							)
						)
                }
                )
            )

            ;
    }
}