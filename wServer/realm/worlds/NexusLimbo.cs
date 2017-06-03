namespace wServer.realm.worlds
{
    public class NexusLimbo : World
    {
        public NexusLimbo()
        {
            Id = NEXUS_LIMBO;
            Name = "Nexus Tutorial";
            Background = 0;
            SetMusic("Island");
            base.FromWorldMap(
                typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.nexusLimbo.wmap"));
        }
    }
}