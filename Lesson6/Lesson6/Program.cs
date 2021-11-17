using System;

namespace Lesson6
{
    class Program
    {
        static void Main()
        {
            TryParse(Console.ReadLine(), out int result);
            int a = 5;
            a =  IncreaseNumber(ref a);//ref acar sözü value typelerde istifade olunur. Stack hissede yer alır ve kopyasından istifadə olunur.
            Console.WriteLine(a);
            
        }
        static bool TryParse(string s,out int result)
        {
            int actually;
            try
            {
                actually = int.Parse(s);
                result = actually;
                return true;
            }
            catch (Exception e)
            {

                result = 0;
                return false;
            }
        }
        static int IncreaseNumber(ref int number)
        {
            ++number;

            return number;
        }

        static void Main1(string[] args)
        {


            //Print("Mustafa",19);
            Console.WriteLine(Sum(2,4,5,7));
            Console.WriteLine(Sum(10,100,1000));
            

           //var result = PrintReturnName("Mustafa", 19);
           // Console.WriteLine(result.ToUpper());
            Console.ReadLine();
        }
        static int Sum(params int [] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static void Print(string name,int ages,int experience = 0)//Eger default olaraq deyer qebul olunursa, bu default degerler sonlarda yazilmalidi.Optional parametrler.
        {
            var result = $"Adiniz: {name},Yasiniz: {ages}";

            if (experience != 0)
            {
                result += $" and your experience is {experience}";
            }
            else
            {
                result += " Is tecruben yoxdur";
            }

            Console.WriteLine(result);
        }
        static string PrintReturnName(string name,int age)
        {
            return $"Hello {name}, Your Name: {age}";
        }


    }
}
