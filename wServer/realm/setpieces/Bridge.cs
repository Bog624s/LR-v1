namespace wServer.realm.setpieces
{
    internal class Sentinel : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var sentinel = Entity.Resolve(0x5015);
            sentinel.Move(pos.X + 2.5f, pos.Y + 2.5f); //bridge sentinel
            world.EnterWorld(sentinel);
        }
    }
}