using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
   public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        private int _age { get; set; }
        public int Age { get 
            {
                return _age;
            }

            set 
            {
                if (value < 50 && value > 6)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age failed");
                }

            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello {Name} {SurName}");
        }
        public virtual void GoToClasses()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }
    }
}
