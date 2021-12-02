using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;



namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCountinue;
            const string ApiUrl = "https://catfact.ninja/fact";

            HttpClient client = new HttpClient();
            Console.WriteLine("Starting to show facts \r\n \r\n");

            do
            {
                var result =  client.GetStringAsync(ApiUrl).Result;

                var catfact = JsonConvert.DeserializeObject<CatFact>(result);

                Console.WriteLine(catfact.Fact);

                Console.WriteLine();

                Console.WriteLine("Do you want to continue? True or False");

                isCountinue = Convert.ToBoolean(Console.ReadLine());
            }
            while (isCountinue);
        }
       public static async Task Main1(string[] args)
        {
            var user = new User()
            {
                Name = "Mustafa",
                isStudent = true,
                Age = 19,
                SuccessYears = new int[] { 1, 3, 5 },
                Parent = new Person()
                {
                    Name = "Vidadi",
                    DateofBirth = new DateTime(1977, 1, 5)
                },
                Children = new Person[]
                {
                    new Person()
                    {
                        Name = "A",
                        DateofBirth = DateTime.Parse("2027-10-22")
                    },
                    new Person()
                    {
                        Name = "B",
                        DateofBirth = DateTime.Parse("2028-1-2")
                    }
                }
            
            };
            var JsonString = JsonConvert.SerializeObject(user, Formatting.Indented);

            Console.WriteLine(JsonString);

            Console.ReadKey();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public bool isStudent { get; set; }
        public int Age { get; set; }
        public Person Parent { get; set; }
        public Person[] Children { get; set; }
        public int[] SuccessYears { get; set; }
    }
    public class Person 
    {
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
    }

    public class CatFact
    {
        public string Fact { get; set; }
        public int Length { get; set; }
    }
}
