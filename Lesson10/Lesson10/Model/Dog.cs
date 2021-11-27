using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Model
{
   public class Dog:Animal
    {
        public string Voice;

        internal string SomeProperty;

        private string Color;
        protected string Loyality;

        public Dog(string name, string voice) : base(name)
        {
            Voice = voice;
            Color = "Red";
        }
        public  override  void Move()
        {
            Console.WriteLine($"Dog is {Name}");
        }

        public void Movefull()
        {
            Console.WriteLine("Dog moving and color is " + Color);
        }

        public void Run()
        {
            Console.WriteLine("Dog running");
        }

        protected void Save()
        {

        }
    }
    public class CobanIti : Dog
    {
        public CobanIti(string name, string voice, string cins) : base(name, voice)
        {
            Loyality = "Very loyal";
            Save();
        }
        public override void Move()
        {
            Console.WriteLine($"Bu it {Name}");
        }
    }
}
