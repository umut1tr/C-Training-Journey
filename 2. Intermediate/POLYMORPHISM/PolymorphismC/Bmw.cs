using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    // a BMW is a Car
    class Bmw : Car
    {
        public string Model { get; set; }
        public string Brand { get; set; } = "BMW";

        

        public Bmw(string model,int horsePower, string colour) : base(colour, horsePower)
        {
            this.Model = model;                       
        }



        public new void ShowDetails()
        {
            Console.WriteLine("The Cars colour is {0}, and has {1} Horsepower, The Cars Brand is a {2} and the Model is called {3}", Colour, HorsePower, Brand, Model);
        }

        public override void Repair() // can add seled command before override so no derived class can override this function anymore
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }

    }
}
