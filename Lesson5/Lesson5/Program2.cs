using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program2
    {
        static void Main()
        {
            var random = new Random();
            var number = random.Next(1, 101);
            var input =0;
            Console.Write("Ededinizi daxil edin: ");
            while (input != number)
            {
                
                input = int.Parse(Console.ReadLine());

                

                

                if (input > number)
                {
                    Console.WriteLine("Texminin boyukdur");

                    
                }
                else if(input < number)
                {
                    Console.WriteLine("Texmin kicikdir");
                }
                else
                {
                    Console.WriteLine("Texmin duzdur");
                }
                
            }
            Console.WriteLine($"Your number {input}");
            Console.ReadLine();
        }
    }
}
