namespace wServer.realm.setpieces
{
    internal class EyRockDragon : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var eyr = Entity.Resolve(0x70ac);//eye of the rock dragon
            eyr.Move(pos.X, pos.Y);
            world.EnterWorld(eyr);
        }
    }
}