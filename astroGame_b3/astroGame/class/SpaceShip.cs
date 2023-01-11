using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    internal class SpaceShip: Sprite
    {
        Image? hitbox;
        List<Image> image = new List<Image>(11);

        public SpaceShip(string image, int xStart, int yStart, int widht, int height, int xSpeed, int ySpeed, int hit, bool draw, int damage) : base (image, xStart, yStart, widht, height, xSpeed, ySpeed, draw, damage)
        { 
            Hit = hit;
            for(var i = 0; i < 10; i++)
                this.image.Add(new Bitmap(SpriteFolder + $"other\\numeral{i}.png"));
            this.image.Add(new Bitmap(SpriteFolder + "other\\bolt_bronze.png"));

        }

        public void PrintHitbox(Graphics g)
        {
            for(int i = 1; i <= Hit; i++)
                g.DrawImage(image[10], i * 20, 20, 15, 15);
        }

        public void PrintPoints(Graphics g, int points)
        {
            int count = 1;
            for (var i = points; i > 0; i = i/10, count++)
                g.DrawImage(image[i%10], 1200- count * 20, 20, 20, 20);
        }
    }
}
