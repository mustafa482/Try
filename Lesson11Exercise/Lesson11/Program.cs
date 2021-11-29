using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson SP1 = new SchoolPerson();
            SP1.Name = "Mustafa";
            SP1.SurName = "Mustafayev";
            SP1.Age = 19;
            SP1.GoToClasses();

            Student s1 = new Student();
            s1.Name = "Ilkin";
            s1.SurName = "Nesibli";
            s1.GoToClasses();

            Teacher t1 = new Teacher();
            t1.Name = "Haci";
            t1.SurName = "Masmaliyev";
            t1.subject = "Riyazi Analiz";
            t1.GoToClasses();
            t1.Explain();
        }
    }
}
