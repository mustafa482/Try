using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = int.Parse(Console.ReadLine());
            //var IsItOk = int.TryParse(Console.ReadLine(), out int result);//TryParse - Tip deyisimi ucundur.Parse den ferqi odurki burda xeta olsa ekrana exception cixmir.Teyin etdiyimiz deyerde True yaxud False verir.False olsa result 0 olur olmasa verilen qiymet olur.

            //float var1 = 234.45F;
            //var var2 = var1.ToString();
            //Console.WriteLine(var2);

            #region Exercise
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //bool result = x % 2 == 0 && y % 2 == 0;
            //bool result1 = x % 2 == 1 && y % 2 == 1;

            //string a = "Azerbaycan";
            //bool b = a.Contains("A");

            
            double q = 16 / 5;
            Console.WriteLine(q);
            #endregion

            Console.ReadLine();
        }
        /// <summary>
        /// Operatorlar ile is
        /// </summary>BU metodu cagiranda onun ne ise yaradigini bilmek ucun summer ler arasina melumat daxil edirik.
        /// <param name="s">Bu parametr istifadede deyil</param>
        static void Main1(string s)
        {
            #region Operators
            {
                int a = 10;
                int b = 20;

                Console.WriteLine(a--);
                Console.WriteLine(a);
                Console.WriteLine(b++);
                Console.WriteLine(b);
                Console.WriteLine(++b);
            }

            #endregion

            {
                int a = 100;
                var result = a.GetType() == typeof(int);
                Console.WriteLine(a.GetType());

                bool x = a is int;
            }


            long? y = 100;
            int? z = y as int?;
            int f = (int)y;
        }
    }
}
