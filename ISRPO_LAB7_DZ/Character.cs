using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPO_LAB7_DZ
{
    internal class Character
    {
        public string Name;
        public int Health;
        public int Mana;

        public Character(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакует");
        }
    }
}
