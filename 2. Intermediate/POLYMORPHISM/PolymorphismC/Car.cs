using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Car
    {

        public string Colour { get; set; } = "Red";
        public int HorsePower { get; set; } = 110;

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the Id of {0} and is owned by {1} " , carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car (string colour, int horsePower)
        {
            this.Colour = colour;
            this.HorsePower = horsePower;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The Cars colour is {0}, and has {1} Horsepower", Colour, HorsePower);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was Repaired!");
        }
    }
}
