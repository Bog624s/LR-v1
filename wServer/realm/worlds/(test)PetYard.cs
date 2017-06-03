/*
using System.Collections.Generic;
using System.Linq;
using db;
using MySql.Data.MySqlClient;
using wServer.svrPackets;
using wServer.cliPackets;
using wServer.realm.entities;
using wServer.realm.entities.player;

namespace wServer.realm.worlds
{
    public class PetYard : World
    {
        private readonly Player player;
        public PetYard(bool isLimbo)
        {
            Id = PETYARD;
            Name = "Pet Yard";
            Background = 0;
            SetMusic("Overworld");
            if (!(IsLimbo = isLimbo))
            {
                base.FromWorldMap(
                    typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.petyardv2.wmap"));
            }
        }

        protected override void Init()
        {
            LoadPetYardData(player);
        }

        private void LoadPetYardData(Player player)
        {
            Manager.Database.DoActionAsync(db =>
            {
                MySqlCommand cmd = db.CreateQuery();
                cmd.CommandText = "SELECT petId, objType FROM pets WHERE accId=@accId AND NOT petId=@petId;";
                cmd.Parameters.AddWithValue("@accId", player.AccountId);
                cmd.Parameters.AddWithValue("@petId", player.Pet is NewPet ? player.NewPet.PetId : -1);

                List<PetItem> petData = new List<PetItem>();

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int petId = rdr.GetInt32("petId");
                        if (player.Pet != null && player.NewPet.PetId == petId) continue;
                        petData.Add(db.GetPet(petId, player.Client.Account));
                    }
                }

                foreach (PetItem i in petData)
                {
                    NewPet obj = new NewPet(player.Manager, i, null);
                    int x, y;
                    do
                    {
                        x = player.Random.Next(0, this.Map.Width);
                        y = player.Random.Next(0, this.Map.Height);
                    } while (this.Map[x, y].Region != TileRegion.Defender || this.Map[x, y].ObjType != 0);
                    obj.Move(x + 0.5f, y + 0.5f);
                    EnterWorld(obj);
                }
            });
        }

        public NewPet FindPetById(int petId)
        {
            NewPet ret = null;
            for (int i = 0; i < this.NewPets.Values.Count; i++)
            {
                ret = this.NewPets.Values.ToArray()[i];
                if (ret != null)
                {
                    if (ret.PlayerOwner != null)
                        ret.PlayerOwner = null;

                    if (ret.PetId == petId)
                        return ret;
                }
            }
            return ret;
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new PetYard(false));
        }
    }
}*/