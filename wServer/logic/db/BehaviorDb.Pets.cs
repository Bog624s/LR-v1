#region

using System;
using wServer.logic.attack;
using wServer.logic.cond;
using wServer.logic.movement;
using wServer.logic.taunt;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private static _ Pets = Behav()
            .InitMany(0x4214, 0x4217, i => Behaves("Tournament Pet",
                new RunBehaviors(
                        If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 2)),
                    Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000),
                        new IfTag("HP",
                            new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 0),
                                new GetTag(i).GetInt("HP", "Max", 0)))),
                    Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 0),
                        new IfTag("MP",
                            new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30),
                                new GetTag(i).GetInt("MP", "Max", 60)))),
                        new IfTag("Shoot",
                            Cooldown.Instance(new GetTag(i).GetInt("Shoot", "Cooldown", 1200),
                            PetSimpleAttack.Instance(new GetTag(i).GetInt("Shoot", "Range", 10),
                            new GetTag(i).GetInt("Shoot", "Index", 0))))

                    )
                ))

                 
            
            .InitMany(0x41f4, 0x4213, i => Behaves("Divine Pet",
                new RunBehaviors(
                        If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 2)),
                    Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000),
                        new IfTag("HP",
                            new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 0),
                                new GetTag(i).GetInt("HP", "Max", 0)))),
                    Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 0),
                        new IfTag("MP",
                            new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30),
                                new GetTag(i).GetInt("MP", "Max", 60)))),
                        new IfTag("Shoot",
                            Cooldown.Instance(new GetTag(i).GetInt("Shoot", "Cooldown", 1200),
                            PetSimpleAttack.Instance(new GetTag(i).GetInt("Shoot", "Range", 10),
                            new GetTag(i).GetInt("Shoot", "Index", 0))))

                    )
                ))

            .InitMany(0x71d3, 0x71d7, i => Behaves("Dragon Lord Pet",
                new RunBehaviors(
                        If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 2)),
                    Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000),
                        new IfTag("HP",
                            new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 0),
                                new GetTag(i).GetInt("HP", "Max", 0)))),
                    Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 0),
                        new IfTag("MP",
                            new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30),
                                new GetTag(i).GetInt("MP", "Max", 60)))),
                        new IfTag("Taunt",
                            Cooldown.Instance(new GetTag(i).GetInt("Taunt", "Cooldown", 60000),
                                new SimpleTaunt(new GetTag(i).Get("Taunt", "Message", "Prepare to die!"))))/*,
                        new IfTag("Shoot",
                            Cooldown.Instance(new GetTag(i).GetInt("Shoot", "Cooldown", 1200),
                            PetSimpleAttack.Instance(new GetTag(i).GetInt("Shoot", "Range", 10),
                            new GetTag(i).GetInt("Shoot", "Index", 0))))*/

                    )
                ))

            .InitMany(0x610a, 0x610f, i => Behaves("High Pet",
                new RunBehaviors(
                        If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 2)),
                    Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000),
                        new IfTag("HP",
                            new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 0),
                                new GetTag(i).GetInt("HP", "Max", 0)))),
                    Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 0),
                        new IfTag("MP",
                            new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30),
                                new GetTag(i).GetInt("MP", "Max", 60)))),
                        new IfTag("Taunt",
                            Cooldown.Instance(new GetTag(i).GetInt("Taunt", "Cooldown", 60000),
                                new SimpleTaunt(new GetTag(i).Get("Taunt", "Message", "Prepare to die!")))),
                        new IfTag("Shoot",
                            Cooldown.Instance(new GetTag(i).GetInt("Shoot", "Cooldown", 1200),
                            PetSimpleAttack.Instance(new GetTag(i).GetInt("Shoot", "Range", 10),
                            new GetTag(i).GetInt("Shoot", "Index", 0))))

                    )
                ))
            .InitMany(0x6101, 0x6109, i => Behaves("Donator Pet",
                new RunBehaviors(
                        If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 2)),
                    Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000),
                        new IfTag("HP",
                            new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 0),
                                new GetTag(i).GetInt("HP", "Max", 0)))),
                    Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 0),
                        new IfTag("MP",
                            new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30),
                                new GetTag(i).GetInt("MP", "Max", 60)))),
                        new IfTag("Taunt",
                            Cooldown.Instance(new GetTag(i).GetInt("Taunt", "Cooldown", 60000),
                                new SimpleTaunt(new GetTag(i).Get("Taunt", "Message", "Prepare to die!")))),
                        new IfTag("Shoot",
                            Cooldown.Instance(new GetTag(i).GetInt("Shoot", "Cooldown", 1200),
                            PetSimpleAttack.Instance(new GetTag(i).GetInt("Shoot", "Range", 10),
                            new GetTag(i).GetInt("Shoot", "Index", 0))))

                    )))
            /*.Init(0x1664, Behaves("MySQL Pet System",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(8, 9999, 9999)),
						Cooldown.Instance(
                            new GetTag(0x1664).
                            )
                    )))*/
            .Init(0x1659, Behaves("Josh's Pet",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(80, 80)),
                    Cooldown.Instance(1500, new PetsHealingMP(50, 50)),
                    Cooldown.Instance(2000, new PetAttack(400, 500, 7)
                        ))
                ))
            .Init(0x1660, Behaves("Spiritual Defender Pet",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1150, PetSimpleAttack.Instance(9.2f, projectileIndex: 0))
                    ))
            )
            .Init(0x1661, Behaves("Knight Pet",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(76, 76)),
                    Cooldown.Instance(1500, new PetsHealingMP(38, 38)),
                    Cooldown.Instance(2000, new PetAttack(200, 300, 7)
                        ))
                ))
                .Init(0x1662, Behaves("Lunar's Phoenix",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(60, 70)),
                    Cooldown.Instance(1500, new PetsHealingMP(40, 50))
                        ))
                )
            .Init(0x1656, Behaves("Dallas's Pet",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(69, 69)),
                    Cooldown.Instance(1500, new PetsHealingMP(40, 40))
                    ))
            )
            .Init(0x1657, Behaves("Astro's Griffin",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(69, 69)),
                    Cooldown.Instance(1500, new PetsHealingMP(33, 33))
                    ))
            )
            .Init(0x1658, Behaves("Scootaloo",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingHP(50, 50)),
                    Cooldown.Instance(1500, new PetsHealingMP(60, 60))
                    ))
            )
            .Init(0x1663, Behaves("Twilight Sparkle",
                new RunBehaviors(
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
                    Cooldown.Instance(1500, new PetsHealingMP(70, 70)),
                    Cooldown.Instance(1500, PetMultiAttack.Instance(7, 10*(float) Math.PI/180, 4))
                    ))
            )
            .Init(0x1642, Behaves("Cube Pet",
                new RunBehaviors(
                    Cooldown.Instance(750,
                        PetPredictiveMultiAttack.Instance(25, 10*(float) Math.PI/180, 9, 1, projectileIndex: 0)),
                    Cooldown.Instance(1500, PetPredictiveMultiAttack.Instance(25, 10*(float) Math.PI/180, 4, 1, 1)),
                    If.Instance(new PetBehaves(), PetChasing.Instance(8, 10, 3))
                    )))
            .InitMany(0x1643, 0x1655, (i) => Behaves("Elite Pet",
            new RunBehaviors(
                new Switch(
                    new IfValue("Speed", "Value", 
                        If.Instance(new PetBehaves(), PetChasing.Instance(new GetTag(i).GetInt("Speed", "Value", 10), new GetTag(i).GetInt("Speed", "Value", 10), 3))),
                    If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3))),
                Cooldown.Instance(new GetTag(i).GetInt("HP", "Cooldown", 1000), new IfTag("HP", new PetsHealingHP(new GetTag(i).GetInt("HP", "Min", 50), new GetTag(i).GetInt("HP", "Max", 100)))),
                Cooldown.Instance(new GetTag(i).GetInt("MP", "Cooldown", 1000), new IfTag("MP", new PetsHealingMP(new GetTag(i).GetInt("MP", "Min", 30), new GetTag(i).GetInt("MP", "Max", 60)))),
                Cooldown.Instance(new GetTag(i).GetInt("Dmg", "Cooldown", 1000), new IfTag("Dmg", new PetAttack(new GetTag(i).GetInt("Dmg", "Min", 50), new GetTag(i).GetInt("Dmg", "Max", 70), new GetTag(i).GetInt("Dmg", "Range", 10))))
                //Cooldown.Instance(1000, ThrowAttackPet.Instance(4, 10, 40, 70))
            )))

           .Init(0x6004, Behaves("Wverhe's Pet",
             new RunBehaviors(
               If.Instance(new PetBehaves(), PetChasing.Instance(10, 10, 3)),
               Cooldown.Instance(1500, new PetsHealingHP(69, 69)),
               Cooldown.Instance(1500, new PetsHealingMP(69, 69))
             )
           ))

            
            
            ;
    }
}