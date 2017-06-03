namespace wServer.realm.setpieces
{
    internal class OryxSix : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var o6 = Entity.Resolve(0x7103);
            o6.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(o6);
        }
    }
}