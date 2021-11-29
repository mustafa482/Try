using System;
using System.Net.Http;
using System.Threading.Tasks;



namespace Lesson11
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool isCountinue;
            const string ApiUrl = "https://catfact.ninja/fact";

            HttpClient client = new HttpClient();
            Console.WriteLine("Starting to show facts \r\n \r\n");

            do
            {
                var result = await client.GetStringAsync(ApiUrl);
                Console.WriteLine(result);

                Console.WriteLine();

                Console.WriteLine("Do you want to continue? True or False");

                isCountinue = Convert.ToBoolean(Console.ReadLine());
            }
            while (isCountinue);
        }
    }
}
