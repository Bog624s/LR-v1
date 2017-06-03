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
        private static _ Draconis = Behav()
            .Init(0x70a1, Behaves("The Draconis Black Chest",
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
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.45, (ILoot)new StatPotionsLoot(1, 2))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag / 2, (ILoot)new ItemLoot("Void Incantation")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wine Cellar Incantation"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Celestial Blade"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Black Striped Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Black Striped Cloth"))
                    ))
                    )
                )
            )
            .Init(0x7504, Behaves("Black Dragon God",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(400)
                                ),
                            SetAltTexture.Instance(1),
                            new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))
                            )
                        ),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 7)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.96f, new SetKey(-1, 2)))
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            SetAltTexture.Instance(2),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 7)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.75f, new SetKey(-1, 3)))
                            )
                        ),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 7)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.50f, new SetKey(-1, 4)))
                            )
                        ),
                    IfEqual.Instance(-1, 4,
                        new RunBehaviors(
                            SetAltTexture.Instance(2),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 7)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.25f, new SetKey(-1, 5)))
                            )
                        ),
                    IfEqual.Instance(-1, 5,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 7))
                            )
                        )
                    ),
                condBehaviors: new ConditionalBehavior[]
                    {
                        //new DeathPortal(0x070e, 100, -1),
                        new OnDeath(
                            Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70a1, 1, 1, 1))))
                    }
                ))
            .Init(0x70a2, Behaves("The Draconis Blue Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0x0000FF),
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
                                Flashing.Instance(1500, 0x0000FF)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.45, (ILoot)new StatPotionsLoot(1, 2))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag / 2, (ILoot)new ItemLoot("Void Incantation")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wine Cellar Incantation"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Water Dragon Silk Robe"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Big-Stripe Blue Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Big-Stripe Blue Cloth"))
                    ))
                    )
                )
            )
            .Init(0x7499, Behaves("Blue Dragon God",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(400)
                                ),
                            SetAltTexture.Instance(1),
                            new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))
                            )
                        ),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Chasing.Instance(6, 11, 1, null),
                            Cooldown.Instance(900, RingAttack.Instance(10, 2, 0, 1)),
                            Cooldown.Instance(900, RingAttack.Instance(18, 2, 0, projectileIndex: 0)),
                            Cooldown.Instance(1260, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 0, 3)),
                            Cooldown.Instance(1260, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, 5)),
                            Cooldown.Instance(1260, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 15, 2f, 6))
                            )
                        )),
                condBehaviors: new ConditionalBehavior[]
                    {
                        //new DeathPortal(0x070e, 100, -1),
                        new OnDeath(
                            Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70a2, 1, 1, 1))))
                    }
                ))
            .Init(0x70a3, Behaves("The Draconis Red Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0xCD0000),
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
                                Flashing.Instance(1500, 0xCD0000)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.45, (ILoot)new StatPotionsLoot(1, 2))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag / 2, (ILoot)new ItemLoot("Void Incantation")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wine Cellar Incantation"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Fire Dragon Battle Armor"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Green Weave Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Green Weave Cloth"))
                    ))
                    )
                )
            )
            .Init(0x7543, Behaves("Red Dragon God",
                new RunBehaviors(

                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(400)
                                ),
                            SetAltTexture.Instance(1),
                            new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))
                            )
                        ),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Cooldown.Instance(500, AngleAttack.Instance(0, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(45, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(90, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(135, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(180, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(225, projectileIndex: 0)),
                            new QueuedBehavior(HpLesserPercent.Instance(0.33f, new SetKey(-1, 2)))
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            Cooldown.Instance(500, AngleAttack.Instance(0, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(45, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(90, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(135, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(180, projectileIndex: 0)),
                            Cooldown.Instance(500, AngleAttack.Instance(225, projectileIndex: 0))
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
                                    projectileIndex: 3)))
                            ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                    {
                        //new DeathPortal(0x070e, 100, -1),
                        new OnDeath(
                            Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70a3, 1, 1, 1))))
                    }
                ))
            .Init(0x70a4, Behaves("The Draconis Green Chest",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                                Flashing.Instance(3000, 0x00EE00),
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
                                Flashing.Instance(1500, 0x00EE00)
                                )
                            )
                        ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.45, (ILoot)new StatPotionsLoot(1, 2))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Leaf Dragon Hide Armor"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag / 2, (ILoot)new ItemLoot("Void Incantation")),
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Wine Cellar Incantation"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(12, ItemType.Weapon))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greatloot, (ILoot)new TierLoot(13, ItemType.Armor))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(greenbag + greatloot, (ILoot)new ItemLoot("Golden Skullmaster Egg")),
                            Tuple.Create(greenbag + greatloot*2, (ILoot)new ItemLoot("Hell Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot, (ILoot)new ItemLoot("Firefighter Egg")),
                            Tuple.Create(greenbag + goodloot*2, (ILoot)new ItemLoot("Ice Egg")),
                            Tuple.Create(greenbag + normalloot, (ILoot)new ItemLoot("Ent Egg")),
                            Tuple.Create(greenbag + normalloot*2, (ILoot)new ItemLoot("Fire Egg")),
                            Tuple.Create(greenbag + mediumloot*2, (ILoot)new ItemLoot("Ghost Egg"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Green Weave Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Green Weave Cloth"))
                    ))
                    )
                )
            )
            .Init(0x7541, Behaves("Green Dragon God",
                new RunBehaviors(
                    IfExist.Instance(-1, NullBehavior.Instance,
                        new RunBehaviors(
                            new QueuedBehavior(
                                CooldownExact.Instance(400)
                                ),
                            SetAltTexture.Instance(1),
                            new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))
                            )
                        ),
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Once.Instance(TossEnemy.Instance(0*(float) Math.PI/180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(45*(float) Math.PI/180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(90*(float) Math.PI/180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(135*(float) Math.PI/180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(180*(float) Math.PI/180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(225*(float) Math.PI/180, 4, 0x7545)),
                            Cooldown.Instance(500, MultiAttack.Instance(12, 10*(float) Math.PI/180, 7, 0, 6)),
                            Cooldown.Instance(600, MultiAttack.Instance(12, 10*(float) Math.PI/180, 4, 0, 1)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10*(float) Math.PI/180, 1, 0, 3)),
                            new QueuedBehavior(EntityLesserThan.Instance(5, 0, 0x7545),
                                new SetKey(-1, 2)
                                )
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
                            SetAltTexture.Instance(3),
                            Chasing.Instance(3, 11, 1, null),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10*(float) Math.PI/180, 5, 6f, 2)),
                            Cooldown.Instance(800, MultiAttack.Instance(12, 10*(float) Math.PI/180, 5, 3f, 3)),
                            Cooldown.Instance(450, MultiAttack.Instance(12, 10*(float) Math.PI/180, 3, 6f, 4)),
                            Cooldown.Instance(600, MultiAttack.Instance(300, 20*(float) Math.PI/360, 1, 0, 1)),
                            Cooldown.Instance(850, MultiAttack.Instance(300, 20*(float) Math.PI/360, 15, 0, 7)),
                            new QueuedBehavior(Timed.Instance(30000, new SetKey(-1, 1)))
                            ))
                    ),
                condBehaviors: new ConditionalBehavior[]
                    {
                        //new DeathPortal(0x070e, 100, -1),
                        new OnDeath(
                            Once.Instance(new RandomDo(100, SpawnMinionImmediate.Instance(0x70a4, 1, 1, 1))))
                    }
                )
            )
            .Init(0x7545, Behaves("NM Green Dragon Shield",
                new RunBehaviors(
                    Circling.Instance(4, 100, 5, 0x7541)
                    )
                ));
    }
}