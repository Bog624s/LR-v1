namespace wServer.realm.worlds
{
    public class DDocks : World
    {
        public DDocks()
        {
            Name = "The Deadwater Docks";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.ddocks.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new DDocks());
        }
    }
}