using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ISRPO_LAB7_DZ
{
    internal class Car
    {
        public string model;
        private int maxspeed = 200;
        public int speed = 0;

        public void Accelerate(int delta)
        {
            if (delta <= maxspeed) {
                speed += delta;
                Console.WriteLine($"текущая скорость: {speed} km/h");
                    }
            else Console.WriteLine("скорость не должна превышать максимальное значение");
        }
        public void Brake()
        {
            speed = 0;
            Console.WriteLine($"после торможения: {speed} km/h");
        }
    }
}
