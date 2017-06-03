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
        private static _ RockDragon = Behav()
            .Init(0x70ac, Behaves("Eye of the Rock Dragon",
                Once.Instance(new SimpleTaunt("GRRRRRRRRRRRRRRRRRRRR!!!")),
                Once.Instance(new SetKey(-1, 1)),
                new RunBehaviors(
                    Circling.Instance(9, 100, 4, 0x70ad),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            Circling.Instance(9, 100, 10, 0x70ad),
                            SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            Cooldown.Instance(500),
                            SpawnMinion.Instance(0x70ad, 1, 1, 1, 1),
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            new SetKey(-1, 2)
                            //If.Instance(EntityGroupLesserThan.Instance(40, 1, "Dragon Body"), new SetKey(-1, 2))
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(  
                            Circling.Instance(9, 100, 4, 0x70ad),
                            SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            Once.Instance(new SimpleTaunt("You don't shall pass this way to Lair of Draconis! SOON I'LL BEAT YOU!!!")),
                            /*SpawnMinion.Instance(0x70ae, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70af, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b0, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b1, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b2, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b3, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b4, 1, 8, 8, 1),
                            SpawnMinion.Instance(0x70b5, 1, 8, 8, 1),*/
                            Cooldown.Instance(150),
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            new SetKey(-1, 3)
                            )
                        
                        ),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            Circling.Instance(9, 100, 4, 0x70ad),
                            Once.Instance(new SimpleTaunt("FIGHT!")),
                            new SetKey(-1, 4)
                            )
                        ),
                    IfEqual.Instance(-1, 4,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(50, Circling.Instance(9, 100, 15, 0x70ad)),
                                CooldownExact.Instance(2250,
                                    MultiAttack.Instance(25, 10*(float) Math.PI/180, 1, projectileIndex: 0)),
                                CooldownExact.Instance(1755,
                                    MultiAttack.Instance(12, 10*(float) Math.PI/180, 6, 0, projectileIndex: 1)),
                                CooldownExact.Instance(1000,
                                    MultiAttack.Instance(5, 10*(float) Math.PI/180, 2, 0, projectileIndex: 2))/*,
                                CooldownExact.Instance(5000,
                                    If.Instance(EntityGroupLesserThan.Instance(2000, 1, "Dragon Body"), new SetKey(-1, 2))
                                    )*/
                                )
                            )
                        )
                    ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Ray Katana")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Doku No Ken"))
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
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x753E, 100, 600),
                    new OnDeath(
						new RunBehaviors(
							new SimpleTaunt("Nooooooo! YOU GONNA DIE IN THIS LAIR...")
							)
						)
                }
                )
            )
            .Init(0x70ae, Behaves("Body Segment 1",
                new RunBehaviors(
                    Chasing.Instance(5, 2, 100, 0x70ac),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70ac),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70af, Behaves("Body Segment 2",
                new RunBehaviors(
                    Chasing.Instance(5, 2, 100, 0x70ae),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70ae),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b0, Behaves("Body Segment 3",
                new RunBehaviors(
                    Chasing.Instance(4, 2, 100, 0x70af),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70af),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b1, Behaves("Body Segment 4",
                new RunBehaviors(
                    Circling.Instance(4, 2, 100, 0x70b0),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70b0),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b2, Behaves("Body Segment 5",
                new RunBehaviors(
                    Chasing.Instance(4, 2, 100, 0x70b1),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70b1),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b3, Behaves("Body Segment 6",
                new RunBehaviors(
                    Chasing.Instance(4, 2, 100, 0x70b2),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70b2),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b4, Behaves("Body Segment 7",
                new RunBehaviors(
                    Chasing.Instance(4, 2, 100, 0x70b3),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70b3),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            .Init(0x70b5, Behaves("Body Segment 8",
                new RunBehaviors(
                    Chasing.Instance(4, 2, 100, 0x70b4),
                    Once.Instance(new SetKey(-1, 1)),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            //Chasing.Instance(10, 18, 1, 0x70b4),
                            MultiAttack.Instance(2, 0, 1, 0, 0)
                            )
                        )
                    )
                )
            )
            /*.Init(0xfd9, Behaves("Eye of the Rock Dragon",
                new RunBehaviors(
                    If.Instance(IsEntityPresent.Instance(15, null), Once.Instance(new SetKey(-1, 1))),
                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            SetAltTexture.Instance(6),
                            SpawnMinion.Instance(0xf98, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf65, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf64, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf63, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf62, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf61, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf60, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf59, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf58, 1, 1, 1, 1),
                            SpawnMinion.Instance(0xf57, 1, 1, 1, 1),
                            new SetKey(-1, 2),
                            Cooldown.Instance(1000)
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            SetSize.Instance(120),
                            Swirling.Instance(20, 10),
                            SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            Cooldown.Instance(350,
                                MultiAttack.Instance(10, 5*(float) Math.PI/180, 6, 0, projectileIndex: 0)),
                            If.Instance(EntityGroupLesserThan.Instance(40, 1, "Dragon Body"), new SetKey(-1, 3))
                            )
                        ),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            SmoothWandering.Instance(10, 7),
                            Cooldown.Instance(1200, SimpleAttack.Instance(8, 2)),
                            Cooldown.Instance(1400, RingAttack.Instance(16, 75, 75, 3)),
                            UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            new QueuedBehavior(
                                Cooldown.Instance(200), SetAltTexture.Instance(0),
                                Cooldown.Instance(100), SetAltTexture.Instance(5),
                                Cooldown.Instance(110), SetAltTexture.Instance(4),
                                Cooldown.Instance(150), SetAltTexture.Instance(1),
                                Cooldown.Instance(160), SetAltTexture.Instance(2),
                                Cooldown.Instance(170), SetAltTexture.Instance(3),
                                Cooldown.Instance(180), SetAltTexture.Instance(2),
                                Cooldown.Instance(190), SetAltTexture.Instance(1)
                                ),
                            new QueuedBehavior(
                                CooldownExact.Instance(15000),
                                new SetKey(-1, 1)
                                )
                            )
                        )
                    ),
                loot: new LootBehavior(LootDef.Empty,
                    Tuple.Create(100, new LootDef(0, 5, 2, 5,
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Dexterity")),
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Attack")),
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Defense")),
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Wisdom")),
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Speed")),
                        Tuple.Create(0.10, (ILoot) new ItemLoot("Potion of Vitality"))
                        )))))*/
            
            ;
    }
}