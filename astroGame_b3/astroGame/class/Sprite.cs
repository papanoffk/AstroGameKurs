using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    internal abstract class Sprite
    {
        public string SpriteFolder = AppDomain.CurrentDomain.BaseDirectory + @"sprite\\";

        private int x, y, w, h, xs, ys, hitbox;
        public Image img;

        public int N = 1280, M = 720;
        public bool Draw {get; set;}
        public int X { get => x; set { x = value; } }
        public int Y { get => y; set { y = value; } }
        public int W { get => w; set { w = value; } }
        public int H { get => h; set { h = value; } }
        public int XSpeed { get => xs; set { xs = value; } }
        public int YSpeed { get => ys; set { ys = value; } }
        public int Hit { get => hitbox; set => hitbox = value; }
        public int Damage { get; set; }
        public Sprite(string image, int xStart, int yStart, int widht, int height, int xSpeed, int ySpeed, bool draw, int damage)
        {
            X = xStart;
            Y = yStart;
            W = widht;
            H = height;
            XSpeed = xSpeed;
            YSpeed = ySpeed;
            img = new Bitmap(SpriteFolder + image);
            Draw = draw;
            Damage = damage;
        }
        public Sprite(Sprite spriteCopy)
        {
            X = spriteCopy.X;
            Y = spriteCopy.Y;
            W = spriteCopy.W;
            H = spriteCopy.H;
            Draw = spriteCopy.Draw;
            XSpeed = spriteCopy.XSpeed;
            YSpeed = spriteCopy.YSpeed;
            img = spriteCopy.img;
            Damage = spriteCopy.Damage;
        }

        public void Move(int right, int down) //up and right == 1 or -1
        {
            if (X <= N-100 && right == 1 || X >= 10 && right == -1) X+=XSpeed*right;
            if (Y <= M-150 && down == 1 || Y >= 10 && down == -1) Y+=YSpeed*down;
        }

        public void PrintSprite(Graphics g)
        {
            if(Draw)g.DrawImage(img, X, Y, W, H);
        }

    }

}
