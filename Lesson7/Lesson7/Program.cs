using System;
using System.Collections;
using System.Linq;

namespace Lesson7
{
    class Program
    {
        static void Main()
        {
            MaxElement();
            
            //int num = int.Parse(Console.ReadLine());
            //int a;
            //int sum = 0;
            //while (num / 10 !=0 || num %10 !=0)
            //{
            //    a = num % 10;

            //    sum += a;


                
            //    int c = (num - a) / 10;
            //    num = c;
            //}
            //Console.WriteLine(sum);
        }
        static void Main1()
        {
            var random = new Random();
            
            int[] array = new int[90];
            
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 101);
                
                Console.WriteLine($"Sira:{i} " + array[i]);

                

            }
            Array.Sort(array);
            Array.Reverse(array);
            foreach (var item in array)
            {
                
                Console.WriteLine(item);

                
            }
            Console.WriteLine();
            Console.WriteLine(array[2]);
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }
            

            Console.ReadLine();
        }
        static void Main2()
        {
            /*Write a program in C# to create a function to swap the values of two integer numbers without additional variable. 
            Test Data : Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5*/

            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            ReverseInputtedNums4(x, y);
            
        }

        public static void ReverseInputtedNums4(int x, int y)
        {
            Console.WriteLine("Now the first number is " + y);
            Console.WriteLine("And the second number is " + x);
        }

        static void Fibonacci()
        {
            int[] fibonaci = new int[15];
            fibonaci[0] = 0;
            fibonaci[1] = 1;

            Console.WriteLine(fibonaci[0]);
            Console.WriteLine(fibonaci[1]);
            for (int i = 2; i < fibonaci.Length; i++)
            {
                fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];

                Console.WriteLine(fibonaci[i]);
            }
        }
        static void Main6()
        {

            /* Write a program in C# to create a function to calculate the sum of the individual digits of a given number. 
            Test Data : Enter a number: 1234 Expected Output : The sum of the digits of the number 1234 is : 10 */

            Console.WriteLine("This program will calculate the sum of the individual digits of a given number.\nEnter your number: ");

            int num = int.Parse(Console.ReadLine());
            SumDigitsOfGivenNum6(num);

        }

        static void SumDigitsOfGivenNum6(int num)
        {
            var numString = num.ToString();

            char[] numArray = numString.ToCharArray();

            int numDigit;
            int sum = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                numDigit = numArray[i] - '0';
                sum += numDigit;
            }

            Console.WriteLine(sum);
        }
        static void Bosluq()
        {
            int CharSpaceSum = 0;
            string Str;
            Str = Console.ReadLine();
            char[] charArray = Str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    CharSpaceSum += 1;
                }
            }
            Console.WriteLine(CharSpaceSum);
        }
        static void MinMax()
        {
            int[] mnmx = new int[5] { 3, 7, 5, 9, 11 };
            Array.Sort(mnmx);
            int MaxSum = 0;
            int MinSum = 0;
            for (int i = 0; i < mnmx.Length; i++)
            {
                if (mnmx[mnmx.Length - 1] == mnmx[i])
                {
                    continue;
                }
                MinSum += mnmx[i];
            }
            Console.WriteLine("Verilen ededler icinden en kicik alinan cemi hesabla:{0} ", MinSum);

            for (int i = 0; i < mnmx.Length; i++)
            {
                if (mnmx[0] == mnmx[i])
                {
                    continue;
                }
                MaxSum += mnmx[i];
            }
            Console.WriteLine("Verilen ededler icinden en boyuk alinan cemi hesabla:{0} ", MaxSum);




        }
        static void MaxElement()
        {
            int say = 0;
            int[] arr = new int[6] { 2, 5, 6, 5, 6, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr.Max())
                {
                    say += 1;
                }
            }
            Console.WriteLine(say);
            
            Console.ReadLine();
        }


    }
}
