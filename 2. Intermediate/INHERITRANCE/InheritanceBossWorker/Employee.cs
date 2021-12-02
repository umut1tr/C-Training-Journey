using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBossWorker
{
    class Employee
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }


        public Employee(string firstName, string lastName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            LastName = "Türk";
            FirstName = "Umut";
            Salary = 2000;
        }

        public void Work()
        {
            Console.WriteLine("I am working My FirstName is {0} , My LastName is {1} and my Salary is {2}", FirstName, LastName, Salary);
        }

        public void Pause()
        {
            Console.WriteLine("I´m having a break My FirstName is {0} , My LastName is {1} and my Salary is {2}", FirstName, LastName, Salary);
        }

    }
}
