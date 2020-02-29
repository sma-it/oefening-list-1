using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public enum Race
    {
        Troll,
        Gnome,
        Human,
        MaxValue,
    }

    public class Enemy
    {
        public double Health { get; }
        public Race Race { get; }

        static Random random = new Random();

        public Enemy(Race race)
        {
            Race = race;
            Health = 10 + random.Next(10);
        }

        public override string ToString()
        {
            return "A " + Race + ", with health " + Health.ToString("0.##");
        }
    }
}
