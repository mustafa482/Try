using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Model
{
   public class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal moving");
        }

        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }
    }
}
