#region

using System;
using wServer.logic.taunt;
using wServer.logic.attack;
using wServer.logic.movement;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private const double eventmultipler = 100*1; //normal loot event over
        private const double WBChance = 0.000025*eventmultipler; //Global white bag chance to get
        private const double PotProbability = 0.04*eventmultipler; // pot probability in glands
        ///////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /////////////////////////////////////////New Loot System in LoE Realm by Devwarlt\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        ///////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private const double superrareblackbag = 0.00001*eventmultipler;
        private const double whitebag = 0.00364*eventmultipler;      //0.085%      -       White Bag
        private const double blackbag = 0.00222*eventmultipler;     //0.002%     -       Black Bag
        private const double greenbag = 0.0040625*eventmultipler;       //0.40625%        -       Green Bag
        private const double awesomeloot = 0.008125*eventmultipler;  //0.8125%     -       T13~14 weapons / T14~15 armors / T7~8 abilities / T7~8 rings
        private const double greatloot = 0.01625*eventmultipler;      //1.625%        -       T12 weapons / T13 armors / T6 abilities / T6 rings
        private const double goodloot = 0.03125*eventmultipler;       //3.125%        -       T10-11 weapons / T12 armors / T5 abilities / T5 rings
        private const double normalloot = 0.0625*eventmultipler;     //6.25%       -       T9 weapons / T10-11 armors / T4 abilities / T4 rings
        private const double mediumloot = 0.125*eventmultipler;     //12.5%       -       T7-8 weapons / T8-9 armors / T3 abilities /T3 rings
        private const double poorloot = 0.25*eventmultipler;       //25%       -       T0-6 weapons / T1-7 armors / T0-2 abilities / T1-2 rings
        ///////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        ///////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        ///////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private static _ NexusCrier = Behav()
            .Init(0x0e78, Behaves("Nexus Crier",
                Once.Instance(new SetKey(-1, 1)),
                IfEqual.Instance(-1, 1,
                    new RunBehaviors(
                Flashing.Instance(5000, 0xFFA500),
                SimpleWandering.Instance(1, 3),
                Cooldown.Instance(30000,
                     Rand.Instance(
                        new SimpleTaunt("Welcome to LoE Realm! Visit our forum, http://loerealm.forumotion.com/, sponsored by our community!"),
                        //new SimpleTaunt("Don't tell to any Team member to give items or spawn, it will result in ban!"),
                        new SimpleTaunt("We got solid 2 hours of gameplay! New realm events added for more fun!"),
                        new SimpleTaunt("You can close realm three times! Do realm quest and invite your friends to help you!"),
                        new SimpleTaunt("This server is public but you can consider to donate to keep this project alive much more! All funds go to keep this VPS online monthly."),
                        new SimpleTaunt("If you're VIP you can use /vipcommands to check all VIP perks commands!"),
                        new SimpleTaunt("Hey beginners! You can use /shop to access The Wineler."),
                        new SimpleTaunt("If your pet disappear don't worry! Use /pet to teleport your pet near your instantly!"),
                        new SimpleTaunt("Gold Consumables Items has been added in Realm Quests! Try to get it!"),
                        new SimpleTaunt("Use /update to check latest news on LoE Realm.")
                        )
                    /*,
                    new SimpleTaunt(
                        "Welcome everybody! I hope you enjoy this server, please note this is a legit server and we'll not spawn or give items."))*/
                )),
                IfEqual.Instance(-1, 2,
                    new RunBehaviors(
                        new SimpleTaunt("Use /update to check latest news on LoE Realm."),
                        Cooldown.Instance(3000),
                        new SetKey(-1, 1)
                        )
                    ))/*,
                condBehaviors: new ConditionalBehavior[]
                {
                    new ChatEvent(
                        IfEqual.Instance(-1, 1, Cooldown.Instance(500, new SetKey(-1, 2)))
                        ).SetChats(
                            "event"
                        )
                }*/))
            ;
    }
}