using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    public struct Gamer
    {
        public string Name { get; }
        public string Ship { get; set; }
        public int Money { get; set; }
        public int Point { get; set; }
        public Gamer(string name, string ship, int money, int point)
        {
            Name = name;
            Ship = ship;
            Money = money;
            Point = point;
        }
    }
}
