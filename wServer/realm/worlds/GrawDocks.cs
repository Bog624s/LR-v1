namespace wServer.realm.worlds
{
    public class Graw : World
    {
        public Graw()
        {
            Name = "The Graw's Overlord Docks";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Oryx");
            base.FromWorldMap(typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.grawdocks.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Graw());
        }
    }
}