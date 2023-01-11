using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    internal class Laser: Sprite
    {
        public Laser(string image, int xStart, int yStart, int widht, int height, int ySpeed, bool draw) : base(image, xStart, yStart, widht, height, 0, ySpeed, draw, 0)
        {Hit = 1;}

        public Laser(Laser laser) : base(laser)
        { Hit = laser.Hit; }

        public void Move() //up and right == 1 or -1
        {
            if (Y <= 10)Draw = false;
            if(Draw)Y += YSpeed * -1;
        }
    }
}
