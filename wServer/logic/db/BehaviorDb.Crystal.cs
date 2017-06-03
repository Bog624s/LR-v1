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
        private static _ Crystal = Behav()
            .Init(0x0935, Behaves("Mysterious Crystal",
                new RunBehaviors(
                    HpGreaterEqual.Instance(245000,
                        Cooldown.Instance(10000, Heal.Instance(1, 5000, 0x0935))),
                    /*This is the standard healing behavior. */
                    Once.Instance(new SetKey(-1, 1)),

                    #region HpLesserPercent

                    //Cooldown.Instance(1000, HpLesser.Instance(900000, new SetKey(-1, 2))),
                    //Cooldown.Instance(1000, HpLesser.Instance(785000, new SetKey(-1, 1))),
                    //Cooldown.Instance(1000, HpLesser.Instance(124500, new SetKey(-1, 2))),

                    #endregion

                    IfEqual.Instance(-1, 1,
                        new QueuedBehavior(
                            Cooldown.Instance(100),
                            True.Instance(Rand.Instance(
                                new RandomTaunt(0.5, "HP: {HP}. Break the crystal for great rewards..."),
                                new RandomTaunt(0.5, "HP: {HP}. Help me..."),
                                new RandomTaunt(0.5, "HP: {HP}. If you are not very strong, this could kill you"),
                                new RandomTaunt(0.5, "HP: {HP}. If you are not yet powerful, stay away from the Crystal"),
                                new RandomTaunt(0.5, "HP: {HP}. New adventurers should stay away"),
                                new RandomTaunt(0.5, "HP: {HP}. That's the spirit. Lay your fire upon me."),
                                new RandomTaunt(0.5, "HP: {HP}. So close..."),
                                new RandomTaunt(0.5, "HP: {HP}. Fire upon this crystal with all your might for 10 seconds"),
                                new RandomTaunt(0.5, "HP: {HP}. If your attacks are weak, the crystal magically heals"),
                                new RandomTaunt(0.5, "HP: {HP}. Gather a large group to smash it open"),
                                new RandomTaunt(0.5, "HP: {HP}. I think you need more people..."),
                                new RandomTaunt(0.5, "HP: {HP}. Call all your friends to help you break the crystal!")
                                )
                                ),
                                //CooldownExact.Instance(1000, new SetKey(-1, 1))
                            Cooldown.Instance(2000,
                                Flashing.Instance(2000, 0xffffffff)
                                ),
                            CooldownExact.Instance(8000,
                                RingAttack.Instance(16, 22, 16, projectileIndex: 0)
                                ),
                            Cooldown.Instance(1000, HpLesser.Instance(335000, new SetKey(-1, 2)))
                            )
                        ),
        #region unusable part
                    /*
                    IfEqual.Instance(-1, 2,
                        new QueuedBehavior(
                            Cooldown.Instance(0, Flashing.Instance(1000, 0xffffffff)),
                            Cooldown.Instance(1100, Flashing.Instance(1000, 0xffffffff)),
                            True.Instance(Rand.Instance(
                                new RandomTaunt(0.5, "HP: {HP}. Fire upon this crystal with all your might for 10 seconds"),
                                new RandomTaunt(0.5, "HP: {HP}. If your attacks are weak, the crystal magically heals"),
                                new RandomTaunt(0.5, "HP: {HP}. Gather a large group to smash it open")
                                )
                                ),
                            Cooldown.Instance(1000, new SetKey(-1, 1))
                            )
                        ),
                    IfEqual.Instance(-1, 3,
                        new QueuedBehavior(
                            Cooldown.Instance(100),
                            True.Instance(Rand.Instance(
                                new RandomTaunt(0.5, "HP: {HP}. Sweet treasure awaits for powerful adventurers!"),
                                new RandomTaunt(0.5, "HP: {HP}. Yes!  Smash my prison for great rewards!")
                                )
                                ),
                            Cooldown.Instance(1000, new SetKey(-1, 4))
                            )
                        ),
                    IfEqual.Instance(-1, 4,
                        new QueuedBehavior(
                            Cooldown.Instance(100),
                            True.Instance(Rand.Instance(
                                new RandomTaunt(0.5, "HP: {HP}. If you are not very strong, this could kill you"),
                                new RandomTaunt(0.5, "HP: {HP}. If you are not yet powerful, stay away from the Crystal"),
                                new RandomTaunt(0.5, "HP: {HP}. New adventurers should stay away"),
                                new RandomTaunt(0.5, "HP: {HP}. That's the spirit. Lay your fire upon me."),
                                new RandomTaunt(0.5, "HP: {HP}. So close...")
                                )
                                ),
                            Cooldown.Instance(1000, new SetKey(-1, 5))
                            )
                        ),
                    IfEqual.Instance(-1, 5,
                        new QueuedBehavior(
                            Cooldown.Instance(100),
                            True.Instance(Rand.Instance(
                                new RandomTaunt(0.5, "HP: {HP}. I think you need more people..."),
                                new RandomTaunt(0.5, "HP: {HP}. Call all your friends to help you break the crystal!")
                                )
                                ),
                            CooldownExact.Instance(1000, new SetKey(-1, 6))
                            )
                        ),
                    IfEqual.Instance(-1, 6,
                        //Changed runbehaviors to queuedbehavior here so that the ringattack would not be repeated infinitely
                        new RunBehaviors(
                            new QueuedBehavior(
                                new SimpleTaunt("Perhaps you need a bigger group. Ask others to join you!"),
                                Cooldown.Instance(0, Flashing.Instance(1000, 0xffffffff)),
                                RingAttack.Instance(16, 22, 16, projectileIndex: 0),
                                Cooldown.Instance(1100, Flashing.Instance(1000, 0xffffffff)),
                                Once.Instance(RingAttack.Instance(16, 22, 16, projectileIndex: 0)),
                                CooldownExact.Instance(5000, new SetKey(-1, 1))
                                ))
                        ),*/
        #endregion

                    IfEqual.Instance(-1, 2,
                        new QueuedBehavior(
                            SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            Once.Instance(new SimpleTaunt("HP: {HP}. You cracked the crystal! Soon we shall emerge!")),
                            Cooldown.Instance(1000, SetSize.Instance(145)),
                            Cooldown.Instance(1000, SetSize.Instance(125)),
                            Cooldown.Instance(1000, SetSize.Instance(85)),
                            Cooldown.Instance(1000, SetSize.Instance(40)),
                            Flashing.Instance(1000, 0xffffffff),
                            Cooldown.Instance(7000,
                                RingAttack.Instance(16, 22, 16, projectileIndex: 0)
                                ),
                            CooldownExact.Instance(9000,
                                new SimpleTaunt("HP: {HP}. This your reward! Imagine what evil even Oryx needs to keep locked up!")
                                ),
                            Cooldown.Instance(2000,
                                TossEnemy.Instance(0, 0, 0x0941)
                                ),
                            Cooldown.Instance(250,
                                Despawn.Instance
                                )
                            //Once.Instance(RingAttack.Instance(16, 22, 16, projectileIndex: 0)),
                            /*Once.Instance(
                                new SimpleTaunt("This your reward! Imagine what evil even Oryx needs to keep locked up!")),*/
                            /*Once.Instance(RingAttack.Instance(16, 22, 16, projectileIndex: 0)),
                            Once.Instance(SpawnMinionImmediate.Instance(0x0941, 1, 1, 1)),
                            Once.Instance(Despawn.Instance)*/
                            //CooldownExact.Instance(4000, new SetKey(-1, 3))
                            )
                        )
                    /*IfEqual.Instance(-1, 3,
                        new QueuedBehavior(
                            Once.Instance(
                                new SimpleTaunt("This your reward! Imagine what evil even Oryx needs to keep locked up!")),
                            Once.Instance(RingAttack.Instance(16, 22, 16, projectileIndex: 0)),
                            Once.Instance(SpawnMinionImmediate.Instance(0x0941, 1, 1, 1)),
                            Once.Instance(Despawn.Instance)
                            ))*/
                    )
                ))
            .Init(0x0941, Behaves("Crystal Prisoner",
                new RunBehaviors(
                    Once.Instance(new SimpleTaunt("HP: {HP}. I'm finally free! Yesss!!!")),
                    Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                    SmoothWandering.Instance(1f, 1f),
                    Once.Instance(SpawnMinionImmediate.Instance(0x0943, 3, 3, 5)
                        ),
                    If.Instance(
                        EntityLesserThan.Instance(100, 3, 0x0943), //IsEntityNotPresent.Instance(100, 0x0943),
                        Rand.Instance(
                            Reproduce.Instance(0x0943, 3, 100, 3)
                            )
                        )
                    ),
                new QueuedBehavior( //here Is shooting start

                    #region Circle Attack 1
                    Cooldown.Instance(4000),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 0*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 18*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 36*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 54*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 72*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 90*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 108*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 126*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 144*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 162*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 180*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 198*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 216*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 234*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 252*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 270*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 288*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 306*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 324*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 342*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(250),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 360*(float) Math.PI/180)
                        ),

                    #endregion

                    #region Circle Attack 2

                    Cooldown.Instance(200),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 0*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 18*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 36*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 54*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 72*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 90*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 108*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 126*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 144*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 162*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 180*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 198*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 216*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 234*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 252*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SimpleAttack.Instance(5, 3),
                        RingAttack.Instance(4, offset: 270*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 288*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 306*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 324*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(200),
                    new RunBehaviors(
                        RingAttack.Instance(4, offset: 342*(float) Math.PI/180)
                        ),
                    Cooldown.Instance(250),
                    new RunBehaviors(
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        RingAttack.Instance(4, offset: 360*(float) Math.PI/180)
                        ),

                    #endregion

                    #region Flashing + SetCondEff

                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    Flashing.Instance(150, 0x0000FF0C),
                    /*Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),
            Flashing.Instance(150, 0x0000FF0C),*/
                    Cooldown.Instance(3000),

                    #endregion

                    #region Spawn Clones
                    
                    SpawnMinionImmediate.Instance(0x0942, 2, 4, 4),
                    TossEnemy.Instance(0, 5, 0x0942),
                    TossEnemy.Instance(60, 7, 0x0942),
                    TossEnemy.Instance(240, 5, 0x0942),
                    TossEnemy.Instance(300, 7, 0x0942),
                    Cooldown.Instance(2000),

                    #endregion

                    #region Invulnerable

                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(5000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),

                    #endregion

                    #region Whoa nelly

                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),
                    UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 15, 1, 40, 3),
                        MultiAttack.Instance(10, 15, 1, 220, 3),
                        MultiAttack.Instance(10, 15, 1, 130, 3),
                        //MultiAttack.Instance(10, 15, 1, 310, projectileIndex: 3),
                        MultiAttack.Instance(10, 15, 3, 40, 2),
                        MultiAttack.Instance(10, 15, 3, 220, 2),
                        MultiAttack.Instance(10, 15, 3, 130, 2)
                        //MultiAttack.Instance(10, 15, 3, 310, projectileIndex: 2)
                        ),

                    #endregion

                    #region Confuse Circle

                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(2000),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    SetSize.Instance(125),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    SetSize.Instance(150),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    SetSize.Instance(175),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    SetSize.Instance(200),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    SetSize.Instance(175),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    SetSize.Instance(150),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    SetSize.Instance(125),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    SetSize.Instance(100),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        ),
                    UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 40, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 60, 1)
                        ),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 50, 1)
                        ),
                    SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                    Cooldown.Instance(500),
                    new RunBehaviors(
                        MultiAttack.Instance(10, 40, 10, 70, 1)
                        )

                    #endregion

                    ),
                loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Crystal Token"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(whitebag, (ILoot)new ItemLoot("Crystal Wand")),
                            Tuple.Create(whitebag * 2, (ILoot)new ItemLoot("Crystal Sword"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(blackbag, (ILoot)new ItemLoot("Flawless Crystal Wand")),
                            Tuple.Create(blackbag * 2, (ILoot)new ItemLoot("Giant Crystal Sword"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(mediumloot, (ILoot)new TierLoot(3, ItemType.Ring))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(goodloot, (ILoot)new TierLoot(5, ItemType.Ability)),
                            Tuple.Create(normalloot, (ILoot)new TierLoot(4, ItemType.Ability))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
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
                            Tuple.Create(0.11, (ILoot)new ItemLoot("Small Tan Diamond Cloth")),
                            Tuple.Create(0.08, (ILoot)new ItemLoot("Large Tan Diamond Cloth"))
                    )),
                        Tuple.Create(100, new LootDef(0, 1, 0, 8,
                            Tuple.Create(0.55, (ILoot)new StatPotionsLoot(1, 2))
                    ))
                    )/*,
                condBehaviors: new ConditionalBehavior[]
                {
                    new DeathPortal(0x5050, 100, 1800)
                }*/

                ))
            .Init(0x0942, Behaves("Crystal Prisoner Clone",
                new RunBehaviors(
                    Cooldown.Instance(1000, SimpleAttack.Instance(10, projectileIndex: 0)),
                    Cooldown.Instance(7500, Despawn.Instance)
                    ),
                IfNot.Instance(
                    Chasing.Instance(2, 10, 3, 0x0941),
                    SimpleWandering.Instance(2f)
                    )
                ))
            .Init(0x0943, Behaves("Crystal Prisoner Steed",
                new RunBehaviors(
                    Cooldown.Instance(800, SimpleAttack.Instance(10, projectileIndex: 0))
                    ),
                IfNot.Instance(
                    Chasing.Instance(2, 10, 5, 0x0941),
                    SimpleWandering.Instance(2f)
                    )
                ));
    }
}