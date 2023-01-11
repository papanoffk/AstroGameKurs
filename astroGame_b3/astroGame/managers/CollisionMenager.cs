using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    internal class CollisionMenager
    {
        public CollisionMenager() { }

        public bool CheckCollision(Meteor meteor, SpaceShip ship)
        {
            int centreShipX = ship.X + ship.W / 2, centreShipY = ship.Y + ship.H / 2;
            int centreMeteorX = meteor.X + meteor.W / 2, centreMeteorY = meteor.Y + meteor.H / 2;
            int x = Math.Abs(centreShipX - centreMeteorX), y = Math.Abs(centreShipY - centreMeteorY);
            int n = 8;
            if (!meteor.Draw) return false;
            if(y <= ship.H/2 + meteor.H/2 - n)
                if(x <= meteor.H / 2 || x <= meteor.W / 2 + 5 && centreShipY - centreMeteorY < 15 || x <= ship.W / 2 + meteor.W / 2 - 4 && centreShipY - centreMeteorY < 10)
                {
                    ship.Hit -= meteor.Damage;
                    meteor.Draw = false;
                    if(ship.Hit<= 0)return true;
                }
            return false;
        }

        public bool CheckCollision(Meteor meteor, Laser laser, int damage)
        {
            if (!meteor.Draw || !laser.Draw) return false;
            if (laser.X>=meteor.X && laser.X <= meteor.X+meteor.W || laser.X+laser.W >= meteor.X && laser.X + laser.W <= meteor.X + meteor.W)
                if (laser.Y >= meteor.Y && laser.Y <= meteor.Y + meteor.H || laser.Y + laser.H >= meteor.Y && laser.Y + laser.H <= meteor.Y + meteor.H)
                {
                    laser.Draw = false;
                    meteor.Hit -= damage;
                    if (meteor.Hit <= 0)
                    {
                        meteor.Draw = false;
                        return true;
                    } 
                }
            return false;
        }
    }
}
