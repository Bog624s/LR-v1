namespace wServer.realm.setpieces
{
    internal class Avatar : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var avat = Entity.Resolve(0x7083);//avatar of the forgotten king
            avat.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(avat);
        }
    }
}