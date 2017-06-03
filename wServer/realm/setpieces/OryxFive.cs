namespace wServer.realm.setpieces
{
    internal class OryxFive : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var o5 = Entity.Resolve(0x7102);
            o5.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(o5);
        }
    }
}