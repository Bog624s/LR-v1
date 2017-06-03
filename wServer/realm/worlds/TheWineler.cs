namespace wServer.realm.worlds
{
    public class Wineler : World
    {
        public Wineler()
        {
            Id = WINELER;
            Name = "The Wineler";
            Background = 0;
            AllowTeleport = false;
            SetMusic("Island");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.thewineler.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Wineler());
        }
    }
}