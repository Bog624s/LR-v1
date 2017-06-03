namespace wServer.realm.worlds
{
    public class ARuins : World
    {
        public ARuins()
        {
            Name = "The Ancient Ruins";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Overworld");
            base.FromWorldMap(
                typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.aruins.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new ARuins());
        }
    }
}