namespace wServer.realm.setpieces
{
    internal class FireGod : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var fg = Entity.Resolve(0x70fa);//mcfarvo the fire god
            fg.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(fg);
        }
    }
}