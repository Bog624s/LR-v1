namespace wServer.realm.worlds
{
    public class Manor : World
    {
        public Manor()
        {
            Name = "Manor of the Immortals";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Haunted Cemetary");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.manoroftheimmortals.wmap"));
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Manor());
        }
    }
}