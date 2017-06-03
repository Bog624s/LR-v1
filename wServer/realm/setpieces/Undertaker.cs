namespace wServer.realm.setpieces
{
    internal class Undertaker : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var undr = Entity.Resolve(0x70e8);//undertaker the great juggernaut
            undr.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(undr);
        }
    }
}