using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Vehicle
    {

        public float Speed { get; set; }
        public string Color { get; set; }


        // default constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "Red";
        }

        // simple constructor
        public Vehicle(int speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }

    }
}
