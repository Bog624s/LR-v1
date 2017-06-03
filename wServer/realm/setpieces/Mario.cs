namespace wServer.realm.setpieces
{
    internal class Mario : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var mari = Entity.Resolve(0x7278);//mario
            mari.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(mari);
        }
    }
}