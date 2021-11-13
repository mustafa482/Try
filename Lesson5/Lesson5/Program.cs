using System;
using System.Collections;

namespace Lesson5
{
    class Program
    {
        static void Main4(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            ArrayList list = CreateArray(30,"My Lesson",DateTime.Now);
            PrintArray(list);
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

                Console.WriteLine(isContinue ? "Siz davam edirsiz" : "Siz cixdiniz");
            } while (isContinue);
        }
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
        static ArrayList CreateArray(int num,string text,DateTime date)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < num; i++)
            {
                list.Add(i);
            }
            list.Add(100);
            list.Add(text);
            list.Add(date);
            
            return list;
        }
        static void PrintArray(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
            
           
            
        
    }
}
