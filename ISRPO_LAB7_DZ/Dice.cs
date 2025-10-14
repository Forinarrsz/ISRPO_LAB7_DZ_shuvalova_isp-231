using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPO_LAB7_DZ
{
    internal class Dice
    {
        int sides;
        static Random rand = new Random();

        public Dice(int s = 6)
        {
            sides = s;
        }

        public int Roll()
        {
            return rand.Next(1, sides + 1);
        }
    }
}

