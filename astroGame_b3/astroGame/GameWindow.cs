using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astroGame
{
    public partial class GameWindow : Form
    {
        Gamer gamer;
        SpaceShip? ship;
        Laser? laser;
        Meteor? meteor;
        Random rnd = new Random();
        Panel panel = new Panel();
        CollisionMenager collision;  

        private bool nextLasers = true;
        private const int _countLaser = 3;
        private const int _countMeteor = 12;
        private int prevMeteorX = 0;
        private int scorePoints = 0;

        List<string> checkKeyEvens = new List<string> { "", "", "", "", "", ""};
        List<Laser> lasersList = new List<Laser>(_countLaser);
        List<Meteor> meteorList = new List<Meteor>(_countMeteor);

        public GameWindow()
        {
            InitializeComponent();
            Init("spaceship\\playerShip2_green.png");
        }

        public GameWindow(Gamer g)
        {
            gamer = g;
            InitializeComponent();
            Init(gamer.Ship);
        }

        private void Init(string s)
        {
            WindowManager game = new WindowManager(this, "background\\spaceBg.jpeg");
            ship = new SpaceShip(s, 600, 600, 70, 70, 6, 8, 3, true, 2);
            laser = new Laser("laser\\laserGreen02.png", -1000, -1000, 12, 30, 10, false);
            meteor = new Meteor("meteor\\meteorBrown_big3.png", 20, 40, 4, false, 3, 1);
            collision = new CollisionMenager();

            for (var i = 0; i < _countLaser; i++)
                lasersList.Add(new Laser(laser));
            laser = null;
            for (var i = 0; i < _countMeteor; i++)
                meteorList.Add(new Meteor(meteor));  

            printTimer.Interval = 16;
            laserTimer.Interval = 1000;
            meteorsTimer.Interval = 700;

            Pause();

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // WS_EX_COMPOSITED
                return cp;
            }
        } 

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// timers
        /// </summary>
        
        private void printTimer_Tick(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            foreach (var eventMove in checkKeyEvens)
            {
                switch(eventMove)
                {
                    case "Left":
                        x += -1;
                        break;
                    case "Right":
                        x += 1;
                        break;
                    case "Up":
                        y += -1;
                        break;
                    case "Down":
                        y += 1;
                        break;
                    case "Space":
                        foreach (Laser laser in lasersList)
                        {
                            if (!laser.Draw && nextLasers)
                            {
                                nextLasers = false;
                                laser.X = ship.X + 30;
                                laser.Y = ship.Y + 30;
                                laser.Draw = true;
                                laserTimer.Start();
                                break;
                            }
                        }
                        break;
                }
            }
            ship.Move(x, y);

            foreach(Laser laser in lasersList)
                laser.Move();
            foreach (Meteor meteor in meteorList)
                meteor.Move();

            Invalidate();

            foreach (Meteor meteor in meteorList) {
                if (collision.CheckCollision(meteor, ship)){ GameOver();}
                foreach (Laser laser in lasersList)
                    if (collision.CheckCollision(meteor, laser, ship.Damage))
                    {
                        scorePoints += 3;
                        if (scorePoints == 51) LoadBoss();
                    }
               }
                    
        }

        int countTimetL = 0;
        private void laserTimer_Tick(object sender, EventArgs e)
        {
            if (countTimetL == 1) { nextLasers = true; countTimetL = 0; laserTimer.Stop(); }
            countTimetL++;
        }

        private void meteorsTimer_Tick(object sender, EventArgs e)
        {
            var nextMeteor = true;
            foreach (Meteor meteor in meteorList)
            {
                if (nextMeteor && !meteor.Draw)
                {
                    meteor.Y = -20;
                    meteor.H = rnd.Next(80, 120);
                    meteor.W = meteor.H;
                    meteor.Hit = (int)(meteor.H / 20)-1;
                    do
                    {
                        meteor.X = rnd.Next(80, 1200);
                    } while (Math.Abs(meteor.X - prevMeteorX) <= 200);
                    prevMeteorX = meteor.X;

                    meteor.Draw = true;
                    nextMeteor = false;
                }
            }
        }

        /// <summary>
        /// KeyUpDown
        /// </summary>
        
        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    checkKeyEvens[0] = "";
                    break;
                case Keys.Right:
                    checkKeyEvens[1] = "";
                    break;
                case Keys.Up:
                    checkKeyEvens[2] = "";
                    break;
                case Keys.Down:
                    checkKeyEvens[3] = "";
                    break;
                case Keys.Space:
                    checkKeyEvens[4] = "";
                    break;
            }
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.Left:
                    checkKeyEvens[0] = e.KeyCode.ToString();
                    break;
                case Keys.Right:
                    checkKeyEvens[1] = e.KeyCode.ToString();
                    break;
                case Keys.Up:
                    checkKeyEvens[2] = e.KeyCode.ToString();
                    break;
                case Keys.Down:
                    checkKeyEvens[3] = e.KeyCode.ToString();
                    break;
                case Keys.Space:
                    checkKeyEvens[4] = e.KeyCode.ToString();
                    StartGame();
                    break;
                case Keys.Escape:
                    Pause();
                    break;


            }
        }

        /// <summary>
        /// Paint game
        /// </summary>


        public delegate void ParameterizedThreadStart(object? obj);
        private void Paint_Game(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            foreach (Laser laser in lasersList)
                laser.PrintSprite(graphics);
            foreach (Meteor meteor in meteorList)
                meteor.PrintSprite(graphics);
            ship.PrintSprite(graphics);
            ship.PrintHitbox(graphics);
            ship.PrintPoints(graphics, scorePoints);

        }

        /// <summary>
        /// Game functions
        /// </summary>

        private void StartGame()
        {
            laserTimer.Start();
            meteorsTimer.Start();
            printTimer.Start();
        }

        private void GameOver() { 
            Pause();
            WindowManager.g.Point = scorePoints;
            WindowManager.g.Money = scorePoints/3;
            this.Hide(); 
        }

        private void Pause()
        {
            laserTimer.Stop();
            meteorsTimer.Stop();
            printTimer.Stop();
        }

        private void LoadBoss() { }


    
    }
}
