#region

using System;
using wServer.realm;
using wServer.realm.entities;
using wServer.realm.entities.player;
using wServer.svrPackets;

#endregion

namespace wServer.logic.cond
{
    internal class NexusHealHp : Behavior
    {
        protected override bool TickCore(RealmTime time)
        {
            float dist = 5;
            var entity = GetNearestEntity(ref dist, null) as Player;
            while (entity != null)
            {
                if (entity.HasConditionEffect(ConditionEffects.Sick)) return false;
                var hp = entity.HP;
                var mp = entity.MP;
                var maxHp = entity.Stats[0] + entity.Boost[0];
                var maxMp = entity.Stats[1] + entity.Boost[1];
                hp = Math.Min(hp + 100, maxHp);
                mp = Math.Min(mp + 100, maxHp);
                if (hp != entity.HP)
                {
                    entity.HP = hp;
                    entity.MP = mp;
                    entity.UpdateCount++;
                    entity.Owner.BroadcastPacket(new ShowEffectPacket
                    {
                        EffectType = EffectType.Potion,
                        TargetId = entity.Id,
                        Color = new ARGB(0xff0000ff)
                    }, null);
                    entity.Owner.BroadcastPacket(new ShowEffectPacket
                    {
                        EffectType = EffectType.Trail,
                        TargetId = Host.Self.Id,
                        PosA = new Position {X = entity.X, Y = entity.Y},
                        Color = new ARGB(0xffcccccc)
                    }, null);
                    entity.Owner.BroadcastPacket(new NotificationPacket
                    {
                        ObjectId = entity.Id,
                        Text = "Aaah!",
                        Color = new ARGB(0xffffff00)
                    }, null);

                    return true;
                }
                entity = GetNearestEntity(ref dist, null) as Player;
            }
            return false;
        }
    }
}