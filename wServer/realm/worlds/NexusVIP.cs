namespace wServer.realm.worlds
{
    public class NexusVIP : World
    {
        public NexusVIP()
        {
            Id = NEXUS_VIP;
            Name = "Nexus VIP";
            Background = 0;
            AllowTeleport = true;
            SetMusic("Island");
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.(v2)newnexusvipbydev.wmap"));
        }
        //(v1)newnexusvipbydev
        //loenexusvip

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new NexusVIP());
        }
    }
}