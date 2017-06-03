namespace wServer.realm.setpieces
{
    internal class OryxSeven : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var o7 = Entity.Resolve(0x70fb);
            o7.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(o7);
        }
    }
}