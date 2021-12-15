using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Lesson13
{
    class Program
    {
        public class Country
        {
            public string country_id { get; set; }
            public double probability { get; set; }
        }
        public class JsonResult
        {
            public string name { get; set; }
            public Country[] country { get; set; }
        }
        static void Main()
        {
            var name = Console.ReadLine();
            var apiUrl = $"https://api.nationalize.io/?name={name}";

            var httpClient = new HttpClient();
            var StringResult = httpClient.GetStringAsync(apiUrl).Result;

            var result = JsonConvert.DeserializeObject<JsonResult>(StringResult);

            Console.WriteLine($"Name is {result.name}");

            foreach (var item in result.country)
            {
                Console.WriteLine($"CountryName is {item.country_id}, probability is {item.probability}");
            }

            Console.ReadKey();

        }
        static void Main3()
        {
            var smsService = new SMSService1();

            var userManager = new UserManager(smsService);
            userManager.RegisterNewUser(new User
            {
                id = 1,
                Name = "Mustafa"
            });

            userManager.RegisterNewUser(new User
            {
                id = 2,
                Name = "Ilkin"
            });

            userManager.EditUser(new User
            {
                id = 1,
                Name = "Samir"
            });
            Console.ReadKey();
        }

        static void Main2(string[] args)
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
