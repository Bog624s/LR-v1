using System;

namespace wServer.realm.setpieces
{
    internal class DraconisGod : ISetPiece
    {
        public int Size
        {
            get { return 5; }
        }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            //Random rnd = new Random();
            //int dragon = rnd.Next(1, 4);

            var black = Entity.Resolve(0x7504); //black
            black.Move(pos.X + 2.5f, pos.Y + 6.5f);
            world.EnterWorld(black);

            var blue = Entity.Resolve(0x7499);
            blue.Move(pos.X + 2.5f, pos.Y + 2.5f); //blue
            world.EnterWorld(blue);

            var red = Entity.Resolve(0x7543);
            red.Move(pos.X + 6.5f, pos.Y + 6.5f); //red
            world.EnterWorld(red);

            var green = Entity.Resolve(0x7541);
            green.Move(pos.X + 6.5f, pos.Y + 2.5f); //green
            world.EnterWorld(green);

            /*if (dragon == 1)
            {
                var black = Entity.Resolve(0x7504); //black
                black.Move(pos.X + 2.5f, pos.Y + 6.5f);
                world.EnterWorld(black);
            } else if (dragon == 2)
            {
                var blue = Entity.Resolve(0x7499);
                blue.Move(pos.X + 2.5f, pos.Y + 2.5f); //blue
                world.EnterWorld(blue);
            } else if (dragon == 3)
            {
                var red = Entity.Resolve(0x7543);
                red.Move(pos.X + 6.5f, pos.Y + 6.5f); //red
                world.EnterWorld(red);
            } else if (dragon == 4)
            {
                var green = Entity.Resolve(0x7541);
                green.Move(pos.X + 6.5f, pos.Y + 2.5f); //green
                world.EnterWorld(green);
            }  */
        }
    }
}