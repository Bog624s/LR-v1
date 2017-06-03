#region

using System.Linq;
using db.data;
using wServer.cliPackets;

#endregion

namespace wServer.realm.entities.player
{
    public partial class Player
    {
        private bool OxygenRegen;
        private long b;
        private long l;

        private void HandleGround(RealmTime time)
        {
            if (time.tickTimes - l > 500)
            {
                if (HasConditionEffect(ConditionEffects.Paused) ||
                    HasConditionEffect(ConditionEffects.Invincible))
                    return;

                try
                {
                    var tile = Owner.Map[(int) X, (int) Y];
                    var objDesc = tile.ObjType == 0 ? null : XmlDatas.ObjectDescs[tile.ObjType];
                    var tileDesc = XmlDatas.TileDescs[tile.TileId];
                    if (tileDesc.Damaging && (objDesc == null || !objDesc.ProtectFromGroundDamage))
                    {
                        var dmg = Random.Next(tileDesc.MinDamage, tileDesc.MaxDamage);
                        dmg = (int) statsMgr.GetDefenseDamage(dmg, true);

                        HP -= dmg;
                        UpdateCount++;
                        if (HP <= 0)
                            Death("lava");

                        l = time.tickTimes;
                    }
                }
                catch
                {
                }
            }
            if (time.tickTimes - b > 60)
            {
                try
                {
                    /*if(Owner.Name != "Test")
                    {
                        int playerHP = (psr.Character.HitPoints / psr.Character.MaxHitPoints);
                        if((playerHP >= 0) && (playerHP <= 1))
                        {
                            OxygenBar = playerHP/OxygenBar;
                        }
                    }*/
                    //if (Owner.Name != "Test")
                    //{
                    /*var fObject = false;
                    foreach (var i in Owner.StaticObjects.Where(i => i.Value.ObjectType == 0x0731).Where(i => (X - i.Value.X)*(X - i.Value.X) + (Y - i.Value.Y)*(Y - i.Value.Y) < 2))
                        fObject = false;


                    OxygenRegen = fObject;

                    if (!OxygenRegen)
                    {
                        if (OxygenBar == (psr.Character.HitPoints/psr.Character.MaxHitPoints)*100)
                            HP -= psr.Character.MaxHitPoints;
                        else
                            OxygenBar -= 0;

                        UpdateCount++;

                        //if (HP <= 0)
                            //Death("lack of oxygen");
                    }
                    else
                    {
                        if (OxygenBar < (psr.Character.MaxHitPoints/psr.Character.MaxHitPoints))
                            OxygenBar = (psr.Character.HitPoints/psr.Character.MaxHitPoints)*100;
                        if (OxygenBar >= (psr.Character.MaxHitPoints/psr.Character.MaxHitPoints))
                            OxygenBar = 100;

                        UpdateCount++;
                    }*/
                    //}
                    /*
                    HP = psr.Character.HitPoints;
                    int HP1k = (HP/10); //max 1000 hit points.
                    int HP10k = (HP/100); //max 10000 hit points.
                    if ((HP > 0) && (HP <= 1000))
                    {
                        OxygenBar = HP1k;
                    }
                    if ((HP > 1000) && (HP <= 10000))
                    {
                        OxygenBar = HP10k;
                    }
                    else
                    {
                        OxygenBar = 0;
                    }*/

                    UpdateCount++;
                    b = time.tickTimes;
                }
                catch
                {
                }
            }
        }

        public void GroundDamage(RealmTime t, GroundDamagePacket pkt)
        {
        }
    }
}