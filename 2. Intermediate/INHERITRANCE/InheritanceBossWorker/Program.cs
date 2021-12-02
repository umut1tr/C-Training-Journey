using System;

namespace InheritanceBossWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);
            michael.Work();
            michael.Pause();
            

            Boss ivan = new Boss("Ferrari", "Ivan", "Vysotksyy", 40000000);
            ivan.Lead();

            Trainee mongo = new Trainee(20, 15, "Rafael", "Mitter", 40);
            mongo.Learn();
            mongo.Work();
            mongo.School();
            

        }
    }
}
