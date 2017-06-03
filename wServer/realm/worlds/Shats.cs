namespace wServer.realm.worlds
{
    public class Shats : World
    {
        public Shats()
        {
            Name = "The Shatters";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.newshatters.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Shats());
        }
    }
}