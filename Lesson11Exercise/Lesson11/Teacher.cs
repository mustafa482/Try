using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
   public class Teacher:SchoolPerson
    {
        public string subject { get; set; }
        public override void GoToClasses()
        {
            Console.WriteLine($"I am {Name} {SurName}.I am teacher");
        }
        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {subject}");
        }
    }
}
