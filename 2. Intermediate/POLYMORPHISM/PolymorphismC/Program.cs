using System;
using System.Collections.Generic;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {

            // a car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi, Bmw , Porsche 
            // can all be used whereever a Car is expected. No cast is
            // required because and implicit conversion exists from a derived 
            // class to its base class
            var cars = new List<Car>
            {
               new Audi("RS7", 580, "Red"),
               new Bmw("M5", 700, "Black")                
            };

            // Polymorphism at work #2: the virtual method Repair is 
            // invoked on each of the derived classes, not the base class.

            //foreach(var car in cars)
            //{
            //    car.Repair();

            //}


            Car bmwZ3 = new Bmw("Z3", 400, "Red");
            Car audiA3 = new Audi("A3", 100, "Green");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Umut Türk");
            audiA3.SetCarIDInfo(1235, "Frank White");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            //Bmw bmwM5 = new Bmw("M5", 330, "White"); // with the new parameter in the function i am overriding the base Car´s Showdetails function
            //Audi audiA5 = new Audi("A5", 116, "Black");

            //bmwM5.ShowDetails();
            //audiA5.ShowDetails();

            //Car carB = (Car)bmwM5;
            //carB.ShowDetails();

            //M3 myM3 = new M3("M3 Gran Turismo", 260, "Red");
            //myM3.Repair();


        }
    }
}
