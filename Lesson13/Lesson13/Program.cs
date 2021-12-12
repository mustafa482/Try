using System;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
        }
    }
    
    public abstract class Animal//Abstract clasin instansi yaranmir
    {
        public abstract int LegCount { get; set; }
        private string _color { get; set; }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void Go()
        {
            Console.WriteLine("Animal is moving");
        }
        public abstract void MakeSound();
    }


    public class Dog : Animal,ICreature//Eyni anda sadece 1 clasdan inherit ede bilerik.Ama interfacden istenilen qeder.
    {
        private int _legCount;
        public override int LegCount { 
            get 
            {
                return _legCount;
            }
            set 
            {
                _legCount = value;
            } 
        }

        public string Name { get; set;}

        public void Grow()
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hav-Hav");   
        }
    }
    public interface ICreature
    {
        string Name { get; set; }
        void Grow();
        
    }
}
