using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Audi : Car
    {
        public string Model { get; set; }
        public string Brand { get; set; } = "Audi";
        public Audi(string model, int horsePower, string colour) : base(colour, horsePower)
        {
            this.Model = model;            
            
        }


        public new void ShowDetails()
        {
            Console.WriteLine("The Cars colour is {0}, and has {1} Horsepower, The Cars Brand is a {2} and the Model is called {3}", Colour, HorsePower, Brand, Model);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }



    }
}
