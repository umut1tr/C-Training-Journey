using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBossWorker
{
    class Boss:Employee
    {

        public string CompanyCar { get; set; }


        public Boss(string companyCar, string firstName, string lastName, int salary):base(lastName, firstName, salary)
        {
            this.CompanyCar = companyCar;
            
        }

        public void Lead()
        {
            Console.WriteLine("I´m Boss! My Firstname is {0}, My Second Name is {1}, My Salary is {2}", FirstName, LastName, Salary);
        }

    }

    
}
