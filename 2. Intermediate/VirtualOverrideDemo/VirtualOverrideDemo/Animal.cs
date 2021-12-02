using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Animal
    {
        // name prop
        public string Name { get; set; }
        // age prop
        public int Age { get; set; }
        // is hungry boolean to check wether the animal is hungry
        public bool IsHungry { get; set; }

        // simple constructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            // all animals are by default hungry
            this.IsHungry = true;
        }

        

        // make some noise
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes some Sound");
        }

        // eat something
        public virtual void Eat()
        {
            if (IsHungry)
            {
                // if yes then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                //otherwise print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
            
        }

        // virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing with something");
        }
    }
}
