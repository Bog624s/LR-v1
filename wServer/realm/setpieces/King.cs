namespace wServer.realm.setpieces
{
    internal class King : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var forgot = Entity.Resolve(0x5048);
            forgot.Move(pos.X + 2.5f, pos.Y + 2.5f); //the forgotten king
            world.EnterWorld(forgot);
        }
    }
}