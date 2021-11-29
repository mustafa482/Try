using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Student:SchoolPerson
    {
        public override void GoToClasses()
        {
            Console.WriteLine($"I am {Name} {SurName}.I am student");
        }
    }
}
