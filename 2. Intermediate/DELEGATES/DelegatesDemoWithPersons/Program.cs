using System;
using System.Collections.Generic;

namespace DelegatesDemoWithPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Person> allPersons = new List<Person>();

            allPersons.Add(new Person("Umut", 28));
            allPersons.Add(new Person("Franz", 17));
            allPersons.Add(new Person("Dennis", 18));
            allPersons.Add(new Person("Peta", 39));
            
            foreach(var person in allPersons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("--Before--");

            allPersons.RemoveAll(IsNotAdult);

            Console.WriteLine("After");

            foreach (var person in allPersons)
            {
                Console.WriteLine(person.ToString());
            }

        }


        static bool IsNotAdult(Person person)
        {

            if(person.Age < 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
