namespace wServer.realm.worlds
{
    public class MiniOne : World
    {
        public MiniOne()
        {
            Id = MINI_ONE;
            Name = "Dye Shop";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Island");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.dyeshop.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new MiniOne());
        }
    }
}