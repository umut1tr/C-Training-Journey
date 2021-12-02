using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBossWorker
{
    class Trainee : Employee
    {

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string firstName, string lastName, int salary):base(firstName, lastName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am learning. My FirstName is {0} , My LastName is {1} and my Salary is {2}", FirstName, LastName, Salary);
        }

        public void Work()
        {
            Console.WriteLine("I work for {0} Hours", WorkingHours);
        }

        public void School()
        {
            Console.WriteLine("I go to school for {0} Hours", SchoolHours);
        }
    }
}
