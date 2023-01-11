using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astroGame 
{ 
    internal class Meteor: Sprite
    {
        public Meteor(string image, int yStart, int size, int ySpeed, bool draw, int hits, int damage) : base(image, 10, yStart, size, size, 0, ySpeed, draw, damage)
        { Hit = hits; }

        public Meteor(Meteor meteor) : base(meteor)
        { Hit = meteor.Hit; }

        public void Move() //up and right == 1 or -1
        {
            if (Y >= M-40) { Draw = false;}
            if (Draw) Y += YSpeed;
        }
    }
}
