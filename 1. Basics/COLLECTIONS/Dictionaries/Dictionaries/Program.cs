using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee DB
            Employee[] employees =
            {
                new Employee("CEO","Gwyn", 95, 200),
                new Employee("Manager","Joe", 35,25),
                new Employee("HR","Lora", 32, 21),
                new Employee("Secretary","Petra", 28, 18),
                new Employee("Lead Developer","Artorias", 55, 35),
                new Employee("Intern","Ernest", 22, 8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);                
            }

            // UPDATE A EMPLOYEE define KEYTOUPDATE to search for key
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!." , KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}" , KeyToUpdate);
            }

            // Remove

            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!. ", KeyToRemove);
            }
            else
            {
                Console.WriteLine("Could not find anyone!");
            }


            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];

                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("Sorry Key not found");
            }
            Console.WriteLine();

            Employee result = null;
            //using TryGetValue() it return returns true if the operation was successful and false otherwise
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
                Console.WriteLine("Employee Key is " );
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

            

            Console.WriteLine("For loop");
            for (int i = 0; i < employeesDirectory.Count; i++)
            {                
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                Console.WriteLine("Employee has index {0}", i);
                //storing th evalue in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name {0}", employeeValue.Name);
                Console.WriteLine("Employee Name {0}", employeeValue.Role);
                Console.WriteLine("Employee Name {0}", employeeValue.Age);
                Console.WriteLine("Employee Name {0}", employeeValue.Salary);                
                Console.WriteLine("______________________________________________");
            }



            Console.ReadLine();

        }

        class Employee
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public float Rate { get; set; }
            // Yearly Salary = rate/h * number of days * number of weeks * number of months
            
            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;
                }
            }

            public Employee(string role, string name, int age, float rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }
        }

    }
}
