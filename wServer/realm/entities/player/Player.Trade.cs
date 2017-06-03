#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using wServer.cliPackets;
using wServer.svrPackets;
using db;
using db.data;
using MySql.Data.MySqlClient;
using wServer.realm.entities;
using wServer.realm.entities.player;
using wServer.realm.setpieces;
using wServer.realm.worlds;

#endregion

namespace wServer.realm.entities.player
{
    partial class Player
    {
        private readonly Dictionary<Player, int> potentialTrader = new Dictionary<Player, int>();
        private int itemnumber1;
        private int itemnumber2;
        private bool[] trade;
        private bool tradeAccepted;
        public Player tradeTarget;
        public static string items1 { get; set; }
        public static string items2 { get; set; }
        string name1;
        string name2;
        public bool taking;
        private bool[] itemresult;
        List<string> itemsNeeded = new List<string>();
        List<int> slotsInUse = new List<int>();
        List<int> neededSlots = new List<int>();
        List<string> itemsInUse = new List<string>();
        Dictionary<int, int[]> usingSlots = new Dictionary<int, int[]>();
        ForgeList f = new ForgeList();
        bool[] inUse = new bool[12];

        public void RequestTrade(RealmTime time, RequestTradePacket pkt)
        {
            if (!NameChosen)
            {
                SendInfo("Unique name is required to trade with others!");
                return;
            }
            var target = Owner.GetUniqueNamedPlayer(pkt.Name);
            if (intake)
            {
                SendError(target.Name + " is already trading!");
                return;
            }
            if (tradeTarget != null)
            {
                SendError("You're already trading!");
                tradeTarget = null;
                return;
            }
            //if (psr.Player == target)
            //{
            //    SendError("Trading with yourself would be pointless.");
            //    tradeTarget = null;
            //    return;
            //}
            if (target == null)
            {
                SendError("Player not found!");
                return;
            }
            if (target.tradeTarget != null && target.tradeTarget != this)
            {
                SendError(target.Name + " is already trading!");
                return;
            }

            if((Owner.Name == "Oryx's Castle") || (Owner.Name == "Battle Arena") || (Owner.Name == "Free Battle Arena") || (Owner.Name == "Guild Hall") || (Owner.Name == "Tournament Arena"))
            {
                SendError("Devwarlt disabled to trade in this place, about too many dupeing reports by community!");
                return;
            }
            else
            {
                if (potentialTrader.ContainsKey(target))
                {
                    tradeTarget = target;
                    trade = new bool[12];
                    tradeAccepted = false;
                    target.tradeTarget = this;
                    target.trade = new bool[12];
                    target.tradeAccepted = false;
                    potentialTrader.Clear();
                    target.potentialTrader.Clear();
                    taking = false;

                    var my = new TradeItem[Inventory.Length];
                    for (var i = 0; i < Inventory.Length; i++)
                        my[i] = new TradeItem
                        {
                            Item = Inventory[i] == null ? -1 : Inventory[i].ObjectType,
                            SlotType = SlotTypes[i],
                            Included = false,
                            Tradeable =
                                (Inventory[i] != null && i >= 4) && (!Inventory[i].Soulbound && !Inventory[i].Undead && !Inventory[i].SUndead)
                        };
                    var your = new TradeItem[target.Inventory.Length];
                    for (var i = 0; i < target.Inventory.Length; i++)
                        your[i] = new TradeItem
                        {
                            Item = target.Inventory[i] == null ? -1 : target.Inventory[i].ObjectType,
                            SlotType = target.SlotTypes[i],
                            Included = false,
                            Tradeable =
                                (target.Inventory[i] != null && i >= 4) && (!target.Inventory[i].Soulbound && !target.Inventory[i].Undead &&
                                                                            !target.Inventory[i].SUndead)
                        };

                    psr.SendPacket(new TradeStartPacket
                    {
                        MyItems = my,
                        YourName = target.Name,
                        YourItems = your
                    });
                    target.psr.SendPacket(new TradeStartPacket
                    {
                        MyItems = your,
                        YourName = Name,
                        YourItems = my
                    });
                }
                else
                {
                    target.potentialTrader[this] = 1000 * 20;
                    target.psr.SendPacket(new TradeRequestedPacket
                    {
                        Name = Name
                    });
                    SendInfo("Sent trade request to " + target.Name);
                } 
            }
            
        }
        public bool usable(int slot, string[] needed)
        {
            if (inUse[slot] == true)
            {
                return false;
            }
            if (Inventory[slot] == null)
            {
                return false;
            }
            for (var i = 0; i < needed.Length; i++)
            {
                if (Inventory[slot].ObjectId != needed[i])
                {
                    if (i == needed.Length)
                    {
                        return false;
                    }
                }
                else
                {
                    inUse[slot] = true;
                    itemsNeeded.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void ChangeTrade(RealmTime time, ChangeTradePacket pkt)
        {   
            if (trade != pkt.Offers)
            {
                tradeAccepted = false;
                tradeTarget.tradeAccepted = false;
                trade = pkt.Offers;

                tradeTarget.psr.SendPacket(new TradeChangedPacket
                {
                    Offers = trade
                });
            }
            
        }

        public void AcceptTrade(RealmTime time, AcceptTradePacket pkt)
        {
            trade = pkt.MyOffers;
            if(
                        (Inventory[0].ObjectType == -1) || (Inventory[1].ObjectType == -1) ||
                        (Inventory[2].ObjectType == -1) || (Inventory[3].ObjectType == -1) ||
                        (tradeTarget.Inventory[0].ObjectType == -1) || (tradeTarget.Inventory[1].ObjectType == -1) ||
                        (tradeTarget.Inventory[2].ObjectType == -1) || (tradeTarget.Inventory[3].ObjectType == -1)
                        ) {
                            SendError("Devwarlt disable to trade without any stuffs in equipment slots, about too many dupe reports! Equip all your slots to trade.");
                            return;
                    }
             else if (tradeTarget.trade.SequenceEqual(pkt.YourOffers) && 
                        (Inventory[0].ObjectType != -1) || (Inventory[1].ObjectType != -1) ||
                        (Inventory[2].ObjectType != -1) || (Inventory[3].ObjectType != -1) ||
                        (tradeTarget.Inventory[0].ObjectType != -1) || (tradeTarget.Inventory[1].ObjectType != -1) ||
                        (tradeTarget.Inventory[2].ObjectType != -1) || (tradeTarget.Inventory[3].ObjectType != -1)
                )
            {
                tradeTarget.trade = pkt.YourOffers;
                tradeAccepted = true;
                tradeTarget.psr.SendPacket(new TradeAcceptedPacket
                {
                    MyOffers = tradeTarget.trade,
                    YourOffers = trade
                });
                Console.Out.WriteLine("Player {0} accepted trade with {1}", nName, tradeTarget.nName);

                /*if (this.tradeAccepted && tradeTarget.tradeAccepted)
                {
                    DoTrade();
                    Console.Out.WriteLine("Did trade!");
                }*/
            }
        }

        public void CancelTrade(RealmTime time, CancelTradePacket pkt)
        {
            {
                psr.SendPacket(new TradeDonePacket
                {
                    Result = 1,
                    Message = "Trade cancelled."
                });
                tradeTarget.psr.SendPacket(new TradeDonePacket
                {
                    Result = 1,
                    Message = "Trade cancelled."
                });
                tradeTarget.tradeTarget = null;
                tradeTarget.trade = null;
                tradeTarget.tradeAccepted = false;
                tradeTarget = null;
                trade = null;
                tradeAccepted = false;
            }
        }

        private void TradeTick(RealmTime time)
        {
            if (trade != null)
                if (taking == false)
                    if (tradeTarget != null)
                        if (tradeAccepted && tradeTarget.tradeAccepted)
                            if (tradeTarget != null && Owner != null && tradeTarget.Owner != null &&
                                Owner == tradeTarget.Owner)
                            {
                                name1 = Name;
                                name2 = tradeTarget.Name;
                                DoTrade();
                            }
                        else
                            {
                                name1 = Name;
                                name2 = tradeTarget.Name;
                                tradeAccepted = false;
                                /*tradeTarget.tradeTarget = null;
                                tradeTarget.trade = null;
                                tradeTarget.tradeAccepted = false;
                                tradeTarget = null;
                                trade = null;
                                tradeAccepted = false;
                                return;*/
                            }
                CheckTradeTimeout(time);
        }

        private void CheckTradeTimeout(RealmTime time)
        {
            var newState = potentialTrader.Select(i => new Tuple<Player, int>(i.Key, i.Value - time.thisTickTimes)).ToList();

            foreach (var i in newState)
            {
                if (i.Item2 < 0)
                {
                    {
                        i.Item1.SendError("Trade to " + Name + " has timed out!");
                    }
                    potentialTrader.Remove(i.Item1);
                }
                else potentialTrader[i.Item1] = i.Item2;
            }
        }

        private void DoTrade()
        {
            if (tradeTarget != null && Owner != null && tradeTarget.Owner != null && Owner == tradeTarget.Owner)
            {
                int thisemptyslots = 0;
                int targetemptyslots = 0;
                var thisItems = new List<Item>();
                for (var i = 0; i < trade.Length; i++)
                    if (trade[i])
                    {
                        thisItems.Add(Inventory[i]);
                        Inventory[i] = null;
                        UpdateCount++;
                        if (itemnumber1 == 0)
                        {
                            items1 = items1 + " " + thisItems[itemnumber1].ObjectId;
                        }
                        else if (itemnumber1 > 0)
                        {
                            items1 = items1 + ", " + thisItems[itemnumber1].ObjectId;
                        }
                        itemnumber1++;
                    }

                var targetItems = new List<Item>();
                for (var i = 0; i < tradeTarget.trade.Length; i++)
                    if (tradeTarget.trade[i])
                    {
                        targetItems.Add(tradeTarget.Inventory[i]);
                        tradeTarget.Inventory[i] = null;
                        tradeTarget.UpdateCount++;

                        if (itemnumber2 == 0)
                        {

                            tradeTarget.psr.SendPacket(new TradeDonePacket
                            {
                                Result = 1,
                                Message = "You can not trade nothing!"
                            });
                            //items2 = items2 + " " + targetItems[itemnumber2].ObjectId;
                        }
                        else if (itemnumber2 > 0)
                        {
                            items2 = items2 + ", " + targetItems[itemnumber2].ObjectId;
                        }
                        itemnumber2++;
                    }
                
                
                for (var i = 0; i != Inventory.Length; i++)
                {
                    if (Inventory[i] == null)
                    {
                        if (SlotTypes[i] == 0)
                        {
                            thisemptyslots++;
                        }
                        else
                        {
                            for (var j = 0; j < targetItems.Count; j++)
                            {
                                if (targetItems[j].SlotType == SlotTypes[i])
                                {
                                    thisemptyslots++;
                                    break;
                                }
                            }
                        }
                    }
                    
                }
                for (var i = 0; i != tradeTarget.Inventory.Length; i++)
                {
                    if (SlotTypes[i] == 0)
                    {
                        targetemptyslots++;
                    }
                    else
                    {
                        for (var j = 0; j < thisItems.Count; j++)
                        {
                            if (thisItems[j].SlotType == SlotTypes[i])
                            {
                                targetemptyslots++;
                                break;
                            }
                        }
                    }
                }
                if (targetemptyslots >= thisItems.Count && thisemptyslots >= targetItems.Count)
                {
                    if (targetItems.Count == 0)
                        targetItems.Add(null);
                    if (thisItems.Count == 0)
                        thisItems.Add(null);
                    for (var i = 0; i < Inventory.Length; i++) //put items by slotType
                        if (Inventory[i] == null)
                        {
                            if (SlotTypes[i] == 0)
                            {
                                Inventory[i] = targetItems[0];
                                targetItems.RemoveAt(0);
                            }
                            else
                            {
                                var itmIdx = -1;
                                for (var j = 0; j < targetItems.Count; j++)
                                {
                                    try
                                    {
                                        if (targetItems[j].SlotType == SlotTypes[i])
                                        {
                                            itmIdx = j;
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        itmIdx = -1;
                                    }
                                }
                                if (itmIdx != -1)
                                {
                                    Inventory[i] = targetItems[itmIdx];
                                    targetItems.RemoveAt(itmIdx);
                                }
                            }
                            if (targetItems.Count == 0) break;
                        }
                    if (targetItems.Count > 0)
                        for (var i = 0; i < Inventory.Length; i++) //force put item
                            if (Inventory[i] == null)
                            {
                                Inventory[i] = targetItems[0];
                                targetItems.RemoveAt(0);
                                if (targetItems.Count == 0) break;
                            }


                    for (var i = 0; i < tradeTarget.Inventory.Length; i++) //put items by slotType
                        if (tradeTarget.Inventory[i] == null)
                        {
                            if (tradeTarget.SlotTypes[i] == 0)
                            {
                                tradeTarget.Inventory[i] = thisItems[0];
                                thisItems.RemoveAt(0);
                            }
                            else
                            {
                                var itmIdx = -1;
                                for (var j = 0; j < thisItems.Count; j++)
                                {
                                    try
                                    {
                                        if (thisItems[j].SlotType == tradeTarget.SlotTypes[i])
                                        {
                                            itmIdx = j;
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        itmIdx = -1;
                                    }
                                }
                                if (itmIdx != -1)
                                {
                                    tradeTarget.Inventory[i] = thisItems[itmIdx];
                                    thisItems.RemoveAt(itmIdx);
                                }
                            }
                            if (thisItems.Count == 0) break;
                        }
                    if (thisItems.Count > 0)
                        for (var i = 0; i < tradeTarget.Inventory.Length; i++) //force put item
                            if (tradeTarget.Inventory[i] == null)
                            {
                                tradeTarget.Inventory[i] = thisItems[0];
                                thisItems.RemoveAt(0);
                                if (thisItems.Count == 0) break;
                            }
                    psr.Player.SaveToCharacter();
                    psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Trade successful!"
                    });
                    tradeTarget.psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Trade successful!"
                    });

                    const string dir = @"logs";
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);
                    using (var writer = new StreamWriter(@"logs\TradeLog.log", true))
                    {
                        writer.WriteLine(Name + " traded " + "{" + items1 + "}" + " with " + tradeTarget.Name + " for " +
                                         "{" + items2 + "}");
                    }
                    Console.Out.WriteLine(Name + " traded " + "{" + items1 + "}" + " with " + tradeTarget.Name + " for " +
                                          "{" + items2 + "}");
                    items1 = "";
                    items2 = "";
                    itemnumber1 = 0;
                    itemnumber2 = 0;
                    UpdateCount++;
                    tradeTarget.UpdateCount++;
                    name1 = "";
                    name2 = "";
                    tradeTarget.tradeTarget = null;
                    tradeTarget.trade = null;
                    tradeTarget.tradeAccepted = false;
                    tradeTarget = null;
                    trade = null;
                    tradeAccepted = false;
                }
                else
                {
                    /*try
                    {
                        using (var dbx = new Database())
                        {
                            var dir = @"logs";
                            var cmd = dbx.CreateQuery();
                            cmd.CommandText = "UPDATE accounts SET banned=1, rank=0 WHERE name=@name";
                            cmd.Parameters.AddWithValue("@name", Name);
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                psr.SendPacket(new TradeDonePacket
                                {
                                    Result = 1,
                                    Message = "[#ERROR PT.514] Something wrong in Anti-Cheating System. Contact developers of LoE Team about this error!"
                                });
                            }
                            else
                            {
                                foreach (var i in RealmManager.Clients.Values)
                                {
                                    i.SendPacket(new TextPacket
                                    {
                                        BubbleTime = 0,
                                        Stars = -1,
                                        Name = "#Announcement",
                                        Text = " Player " + Name + " used exploit to play. For this reason, Anti-Cheat System detected this abuse and give ban to him."
                                    });
                                }
                                Player target = null;
                                if ((target = RealmManager.FindPlayer(Name)) != null)
                                {
                                    target.Client.Disconnect();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Out.WriteLine("[Anti-Cheat System] " + Name + " was banned.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (!Directory.Exists(dir))
                                {
                                    Directory.CreateDirectory(dir);
                                }
                                using (var writer = new StreamWriter(@"logs\Bans.log", true))
                                {
                                    writer.WriteLine(Name + " has been banned by LoE Team. This player trying to use Exploit to cheat ingame!");
                                }
                            }
                            dbx.Dispose();
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Out.WriteLine("[Anti-Cheat System] [#ERROR PT.552]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }*/
                    psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Exploit Halted! You have been logged. The LoE Team can ban you if you don't stop to abuse this bug!"
                    });
                    tradeTarget.psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Exploit Halted! You have been logged. The LoE Team can ban you if you don't stop to abuse this bug!"
                    });
                    //var dbx = new Database();
                    //var cmd = dbx.CreateQuery();
                    //cmd.CommandText = "UPDATE accounts SET banned=1, rank=0 WHERE name=@name";
                    //cmd.Parameters.AddWithValue("@name", Name);
                    const string dir = @"logs";
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);
                    using (var writer = new StreamWriter(@"logs\ExploitLog.log", true))
                    {
                        writer.WriteLine(Name + " tried to trade an ability into a weapon slot with " + tradeTarget.Name + " (Error: More items than free inventory slots)");
                    }
                    Console.Out.WriteLine(Name + " tried to trade an ability into a weapon slot with " + tradeTarget.Name + " (Error: More items than free inventory slots)");
                    //dbx.Dispose();
                    items1 = "";
                    items2 = "";
                    itemnumber1 = 0;
                    itemnumber2 = 0;
                    UpdateCount++;
                    tradeTarget.UpdateCount++;
                    name1 = "";
                    name2 = "";
                    tradeTarget.tradeTarget = null;
                    tradeTarget.trade = null;
                    tradeTarget.tradeAccepted = false;
                    tradeTarget = null;
                    trade = null;
                    tradeAccepted = false;
                    return;

                }
            }
            else
            {
                if (this != null)
                {
                    psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Exploit Halted! You have been logged. The LoE Team can ban you if you don't stop to abuse this bug!"
                    });
                }
                if (tradeTarget != null)
                {
                    tradeTarget.psr.SendPacket(new TradeDonePacket
                    {
                        Result = 1,
                        Message = "Exploit Halted! You have been logged. The LoE Team can ban you if you don't stop to abuse this bug!"
                    });
                }
                const string dir = @"logs";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                using (var writer = new StreamWriter(@"logs\ExploitLog.log", true))
                {
                    writer.WriteLine(name1 + " tried to trade an ability into a weapon slot with " + name2 + " (Error: More items than free inventory slots)");
                }
                Console.Out.WriteLine(name1 + " tried to trade an ability into a weapon slot with " + name2 + " (Error: More items than free inventory slots)");
                items1 = "";
                items2 = "";
                name1 = "";
                name2 = "";
                itemnumber1 = 0;
                itemnumber2 = 0;
                UpdateCount++;
                tradeTarget.UpdateCount++;
                tradeTarget.tradeTarget = null;
                tradeTarget.trade = null;
                tradeTarget.tradeAccepted = false;
                tradeTarget = null;
                trade = null;
                tradeAccepted = false;
                return;  
            }
        }
    }
}