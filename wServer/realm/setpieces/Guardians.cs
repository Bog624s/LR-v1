namespace wServer.realm.setpieces
{
    internal class Guardians : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var right = Entity.Resolve(0x0d78);
            right.Move(pos.X + 2.5f, pos.Y + 6.5f); //right
            world.EnterWorld(right);

            var left = Entity.Resolve(0x0d79);
            left.Move(pos.X + 2.5f, pos.Y + 2.5f); //left
            world.EnterWorld(left);
        }
    }
}