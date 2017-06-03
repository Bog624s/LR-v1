namespace wServer.realm.worlds
{
    public class Underground : World
    {
        public Underground()
        {
            Name = "The Underground";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.theunderground.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Underground());
        }
    }
}