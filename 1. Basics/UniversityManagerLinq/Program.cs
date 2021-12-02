using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagerLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.TransStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.AllStudentsFromYale();
            um.StudentAndUniversityNameCollection();


            //int[] someInts = { 30, 12, 4, 3, 12 };
            //IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            //IEnumerable<int> reversedInts = sortedInts.Reverse();
            //IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            //foreach(int i in sortedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();

            //foreach(int i in reversedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();

            //foreach(int i in reversedSortedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter the Id of the University you want to search all Students for: 1 - Yale , 2 - Beijing Tech");
            //string _userInput = Console.ReadLine();
            //try
            //{
            //    int _userInputInt = Convert.ToInt32(_userInput);
            //    Console.WriteLine("The List of Students");
            //    um.SearchForStudentsByUniversityId(_userInputInt);
            //}
            //catch (Exception inputParsingError)
            //{
            //    Console.WriteLine("Something went wrong parsing the input");
            //}           

            //Console.ReadKey();

        }
    }



    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // let´s add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            // let´s add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 27, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Leyla", Gender = "female", Age = 25, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }


        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach(Student student in maleStudents)
            {
                student.Print();                
            }
            Console.WriteLine();
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> FemaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in FemaleStudents)
            {
                student.Print();               
            }
            Console.WriteLine();
        }

        public void TransStudents()
        {
            IEnumerable<Student> TransStudents = from student in students where student.Gender == "trans-gender" select student;
            Console.WriteLine("Transgender - Students: ");

            foreach (Student student in TransStudents)
            {
                student.Print();                
            }
            Console.WriteLine();
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;
            foreach(Student student in bjtStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void AllStudentsFromYale()
        {
            IEnumerable<Student> yaleStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Yale"
                                               select student;
            foreach (Student student in yaleStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void SearchForStudentsByUniversityId(int Id)
        {
            IEnumerable<Student> allStudents = from student in students
                                            join university in universities on student.UniversityId equals university.Id
                                            where university.Id == Id
                                            select student;
            foreach(Student student in allStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
            Console.WriteLine();
        }

    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key        
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}",Name, Id, Gender, Age, UniversityId);
        }
    }

}
