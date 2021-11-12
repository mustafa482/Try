using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Main3()
        {
            //loops
            bool isContinue = false;
            do
            {
                Console.WriteLine("Davam edirsiz?");
                string result = Console.ReadLine();
                isContinue = result.ToLower() == "he";

                Console.WriteLine(isContinue ? "Siz davam edirsiz": "Siz cixdiniz");
            } while (isContinue);

            static void Main2()
            {
                while (true)
                {

                    Console.WriteLine("Davam elemek isteyirsiz?");
                    string result = Console.ReadLine();
                    bool IsContinue = result.ToLower() == "he";

                    if (IsContinue)
                    {
                        Console.WriteLine("Davam edirsiz");
                        continue;
                    }
                    Console.WriteLine("Cixdiniz");
                    break;

                }
            }
            
            static void Main1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i > 75)
                    {
                        break;
                    }
                    if (i % 10 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
            
           
            Console.ReadLine();
        }
    }
}
