﻿namespace wServer.realm.setpieces
{
    internal class OryxFour : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var o4 = Entity.Resolve(0x7100);
            o4.Move(pos.X + 2.5f, pos.Y + 2.5f);
            world.EnterWorld(o4);
        }
    }
}