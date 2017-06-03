namespace wServer.realm.worlds
{
    public class Kitchen : World
    {
        public Kitchen()
        {
            Name = "Oryx's Kitchen";
            Background = 0;
            SetMusic("Overworld");
            base.FromWorldMap(
                typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.kitchen.wmap"));
        }
    }
}