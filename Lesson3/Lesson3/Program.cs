using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var IsItOk = int.TryParse(Console.ReadLine(), out int result);//TryParse - Tip deyisimi ucundur.Parse den ferqi odurki burda xeta olsa ekrana exception cixmir.Teyin etdiyimiz deyerde True yaxud False verir.False olsa result 0 olur olmasa verilen qiymet olur.

            float var1 = 234.45F;
            var var2 = var1.ToString();
            Console.WriteLine(var2);

            Console.ReadLine();
        }
    }
}
