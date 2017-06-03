namespace wServer.realm.worlds
{
    public class BGrotto : World
    {
        public BGrotto()
        {
            Name = "The Bilgewater Grotto";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Oryx");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.bgrotto.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new BGrotto());
        }
    }
}