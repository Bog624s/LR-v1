namespace wServer.realm.setpieces
{
    internal class Tomb : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var bes = Entity.Resolve(0x0d28);
            bes.Move(pos.X + 2.5f, pos.Y + 6.5f); //bes
            world.EnterWorld(bes);

            var geb = Entity.Resolve(0x0d27);
            geb.Move(pos.X + 2.5f, pos.Y + 2.5f); //geb
            world.EnterWorld(geb);

            var nut = Entity.Resolve(0x0d26);
            nut.Move(pos.X + 6.5f, pos.Y + 2.5f); //nut
            world.EnterWorld(nut);
        }
    }
}