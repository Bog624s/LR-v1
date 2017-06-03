namespace wServer.realm.setpieces
{
    internal class Succubus : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var sucu = Entity.Resolve(0x70d8);//Maurth the Succubus Queen
            sucu.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(sucu);
        }
    }
}