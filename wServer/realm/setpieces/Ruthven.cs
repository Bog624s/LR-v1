namespace wServer.realm.setpieces
{
    internal class Ruthven : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var lordruth = Entity.Resolve(0x1720);//lord ruthven
            lordruth.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(lordruth);
        }
    }
}