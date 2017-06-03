namespace wServer.realm.worlds
{
    public class CoLoE : World
    {
        public CoLoE()
        {
            Name = "Oryx's Kitchen";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Overworld");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.kitchen.wmap"));
        }
        //(v1)fametrain.wmap

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new CoLoE());
        }
    }
}