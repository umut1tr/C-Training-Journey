using System;

namespace TrainingGround
{
    class Program
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Person(int id, string name)
            {
                this.Name = name;
                this.Id = id;
            }

            public override string ToString()
            {
                return $"My ID is: {Id} and my Name is: {Name}";
            }
            
        }

        public class PersonFactory
        {
            int Index = 0;

            public Person CreatePerson(string name)
            {
                Person newPerson = new Person(Index, name);
                Index++;
                return newPerson;
            }
        }

        static void Main(string[] args)
        {

            PersonFactory personFactory = new PersonFactory();

            var p = personFactory.CreatePerson("Hans");
            var p2 = personFactory.CreatePerson("Umut");
            var p3 = personFactory.CreatePerson("Dieter");
            var p4 = personFactory.CreatePerson("Peter");

            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

        }
    }
}
