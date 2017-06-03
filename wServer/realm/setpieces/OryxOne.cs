namespace wServer.realm.setpieces
{
    internal class OryxOne : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var o1 = Entity.Resolve(0x1740);
            o1.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(o1);
        }
    }
}