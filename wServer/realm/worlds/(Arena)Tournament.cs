﻿/*namespace wServer.realm.worlds
{
    public class Tournament : World
    {
        public Tournament()
        {
            Name = "Tournament Arena";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.tournamentarena.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Tournament());
        }
    }
}*/

#region

using System;
using System.Collections.Generic;
using db;
using db.data;
using wServer.svrPackets;

#endregion

namespace wServer.realm.worlds
{
    public class Tournament : World
    {
        private readonly Dictionary<string, bool> Flags = new Dictionary<string, bool>();

        private readonly string[] RandomEnemies =
        {
            "Djinn", "Beholder", "White Demon", "Flying Brain", "Slime God", "Ent God"
        };

        private int FamePot;
        public List<string> Participants = new List<string>();
        private string[] RandomBosses;
        public int Wave;
        private Random rand;

        public Tournament()
        {
            
            Name = "Tournament Arena";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.v2newtarena.wmap"));

            /*Id = ARENA_PAID;
            Name = "Battle Arena";
            Background = 0;
            AllowTeleport = true;*/
            Flags.Add("started", false);
            Flags.Add("counting", false);
            rand = new Random();
            /*base.FromWorldMap(
                typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.NewArena.wmap"));*/
        }

        public bool Joinable
        {
            get { return !Flags["started"]; }
        }

        public bool OutOfBounds(float x, float y)
        {
            return ((x <= 3.5 || x >= 29.5f) || (y <= 3.5f || y >= 29.5f));
        }

        private void SpawnEnemies()
        {
            var enems = new List<string>();
            var r = new Random();
            for (var i = 0; i < Math.Ceiling((double) (Wave + Players.Count)/2); i++)
            {
                enems.Add(RandomEnemies[r.Next(0, RandomEnemies.Length)]);
            }
            var r2 = new Random();
            foreach (var i in enems)
            {
                var id = XmlDatas.IdToType[i];
                var xloc = r2.Next(6, 27) + 0.5f;
                var yloc = r2.Next(6, 27) + 0.5f;
                var enemy = Entity.Resolve(id);
                enemy.Move(xloc, yloc);
                EnterWorld(enemy);
            }
        }

        private void SpawnBosses()
        {
            var enems = new List<string>();
            var r = new Random();
            for (var i = 0; i < (1); i++)
            {
                enems.Add(RandomBosses[r.Next(0, RandomBosses.Length)]);
            }
            var r2 = new Random();
            foreach (var i in enems)
            {
                var id = XmlDatas.IdToType[i];
                var xloc = r2.Next(6, 27) + 0.5f;
                var yloc = r2.Next(6, 27) + 0.5f;
                var enemy = Entity.Resolve(id);
                enemy.Move(xloc, yloc);
                EnterWorld(enemy);
            }
        }

        public void Countdown(int s)
        {
            if (s != 0)
            {
                if (!Flags["started"])
                {
                    foreach (var i in Players)
                        i.Value.Client.SendPacket(new NotificationPacket
                        {
                            Color = new ARGB(0xffff00ff),
                            ObjectId = i.Value.Id,
                            Text = s + " Second" + (s == 1 ? "" : "s")
                        });
                    Timers.Add(new WorldTimer(1000, (w, t) => Countdown(s - 1)));
                }
                else
                {
                    foreach (var i in Players)
                        i.Value.Client.SendPacket(new NotificationPacket
                        {
                            Color = new ARGB(0xffff00ff),
                            ObjectId = i.Value.Id,
                            Text = (s == 5 ? "Wave " + Wave + " - " : "") + s + " Second" + (s == 1 ? "" : "s")
                        });
                    Timers.Add(new WorldTimer(1000, (w, t) => Countdown(s - 1)));
                }
            }
            else
            {
                if (!Flags["started"])
                {
                    Flags["started"] = true;
                    Flags["counting"] = false;
                }
                else
                {
                    Flags["counting"] = false;
                    SpawnEnemies();
                    SpawnBosses();
                }
            }
        }

        public override void Tick(RealmTime time)
        {
            base.Tick(time);
            if (Players.Count > 0)
            {
                if (!Flags["started"] && !Flags["counting"])
                {
                    foreach (var i in RealmManager.Clients.Values)
                        i.SendPacket(new TextPacket
                        {
                            Stars = -1,
                            BubbleTime = 0,
                            Name = "#Announcement",
                            Text = "The Tournament Arena opened by Devwarlt! Come to join and fight against powerful monsters!!!"
                        });
                    Flags["counting"] = true;
                    Countdown(120);
                }


                else if (Flags["started"] && !Flags["counting"])
                {
                    if (Enemies.Count < 1 + Pets.Count)
                    {
                        Wave++;
                        if (Wave < 6)
                        {
                            RandomBosses = new[] {"Red Demon", "Phoenix Lord", "Henchman of Oryx"};
                        }
                        if (Wave > 5 && Wave < 11)
                        {
                            RandomBosses = new[]
                            {"Red Demon", "Phoenix Lord", "Henchman of Oryx", "Stheno the Snake Queen"};
                        }
                        if (Wave > 10 && Wave < 16)
                        {
                            RandomBosses = new[]
                            {"Elder Tree", "Stheno the Snake Queen", "Archdemon Malphas", "Septavius the Ghost God"};
                        }
                        if (Wave > 15 && Wave < 21)
                        {
                            RandomBosses = new[]
                            {
                                "Elder Tree", "Archdemon Malphas", "Septavius the Ghost God",
                                "Thessal the Mermaid Goddess",
                                "Crystal Prisoner"
                            };
                        }
                        if (Wave > 20 && Wave < 26)
                        {
                            RandomBosses = new[]
                            {
                                "Thessal the Mermaid Goddess", "Crystal Prisoner", "Tomb Support", "Tomb Defender",
                                "Tomb Attacker", "Oryx the Mad God 2"
                            };
                        }
                        if (Wave > 25 && Wave < 30)
                        {
                          RandomBosses = new[]
                            {
                                "Thessal the Mermaid Goddess", "Crystal Prisoner", "Tomb Support", "Tomb Defender",
                                "Tomb Attacker", "Oryx the Mad God 2", "Phoenix God Egg", "Bridge Sentinel"
                            };
                        }
                        if (Wave > 31)
                        {
                          RandomBosses = new[]
                            {
                                "Oryx the Mad God 4", "Oryx the Mad God 5", "Oryx the Mad God 6", "Maurth the Succubus Queen",
                                "McFarvo the Fire God", "Undertaker the Great Juggernaut", "Graw the Overlord"
                            };
                        }
                        var db = new Database();
                        //FamePot = (Wave/2)*10/(Players.Count == 1 ? 1 : 2);
                        if(Players.Count == 1)
                        {
                          FamePot = (Wave / 2) * 50;
                        }
                        else if(Wave % 2 == 1)
                        {
                          FamePot = ((Wave + 1) / 4) * 50;
                        }
                        else
                        {
                          FamePot = (Wave / 4) * 50;
                        }
                        foreach (var i in Players)
                        {
                            i.Value.CurrentFame =
                                i.Value.Client.Account.Stats.Fame = db.UpdateFame(i.Value.Client.Account, FamePot);
                            i.Value.UpdateCount++;
                            i.Value.Client.SendPacket(new NotificationPacket
                            {
                                Color = new ARGB(0xFFFF6600),
                                ObjectId = i.Value.Id,
                                Text = "+" + FamePot + " Fame"
                            });
                            if (Math.IEEERemainder(Wave, 15) == 0)
                            {
                                i.Value.Credits = i.Value.Client.Account.Credits = db.UpdateCredit(i.Value.Client.Account, 1);
                                i.Value.UpdateCount++;
                            }
                        }
                        db.Dispose();
                        var Invincible = new ConditionEffect();
                        Invincible.Effect = ConditionEffectIndex.Invulnerable;
                        Invincible.DurationMS = 6000;
                        var Healing = new ConditionEffect();
                        Healing.Effect = ConditionEffectIndex.Healing;
                        Healing.DurationMS = 6000;
                        foreach (var i in Players)
                        {
                            i.Value.Client.SendPacket(new SwitchMusicPacket()
                            {
                                Music = "Oryx"
                            });
                            i.Value.ApplyConditionEffect(new[]
                            {
                                Invincible,
                                Healing
                            });
                        }
                        foreach (var i in Players)
                        {
                            try
                            {
                                if (!Participants.Contains(i.Value.Client.Account.Name))
                                    Participants.Add(i.Value.Client.Account.Name);
                            }
                            catch
                            {
                            }
                        }
                        Flags["counting"] = true;
                        Timers.Add(new WorldTimer(1000, (world, t) => Countdown(5)));
                    }
                    else
                    {
                        foreach (var i in Enemies)
                        {
                            if (OutOfBounds(i.Value.X, i.Value.Y))
                            {
                                LeaveWorld(i.Value);
                            }
                        }
                    }
                }
            }
            else
            {
                if (Participants.Count > 0)
                {
                    new Database().AddToArenaLb(Wave, Participants);
                    Participants.Clear();
                }
            }
        }
    }
}