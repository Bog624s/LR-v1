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
        private static _ Dvst = Behav()
            .Init(0x70e1, Behaves("Exp Gift Tower",
                Once.Instance(new SimpleTaunt("Come close to get free experience reward!")),
                Once.Instance(new SetKey(-1, 1)),
                new RunBehaviors(
                    IfEqual.Instance(-1, 1,
                        new RunBehaviors(
                            SetConditionEffect.Instance(ConditionEffectIndex.Invincible),
                            //new SimpleTaunt("Come closer! Starting to spawn in 5 seconds..."),
                            Cooldown.Instance(5000, new SetKey(-1, 2))
                            )
                        ),
                    IfEqual.Instance(-1, 3,
                        new RunBehaviors(
                            //new SimpleTaunt("Next wave in 5 seconds..."),
                            Cooldown.Instance(5000, new SetKey(-1, 2))
                            )
                        ),
                    IfEqual.Instance(-1, 2,
                        new RunBehaviors(
							Flashing.Instance(500, 0xffff3333),
                            If.Instance(EntityLesserThan.Instance(10, 36, 0x70e0),
                                new RunBehaviors(
                                    TossEnemy.Instance(0*(float) Math.PI/180, 2, 0x70e0),
						            TossEnemy.Instance(60*(float) Math.PI/180, 2, 0x70e0),
						            TossEnemy.Instance(120*(float) Math.PI/180, 2, 0x70e0),
						            TossEnemy.Instance(180*(float) Math.PI/180, 2, 0x70e0),
						            TossEnemy.Instance(240*(float) Math.PI/180, 2, 0x70e0),
						            TossEnemy.Instance(300*(float) Math.PI/180, 2, 0x70e0),
                                    Cooldown.Instance(500, new SetKey(-1, 3))
                                    )
                                )
                            )
                        )
                    )
                )
            )
            ;
    }
}