using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region birolculuArray
            int[] array1 = new int[3];
            array1[0] = 5;
            array1[1] = 6;
            array1[2] = 11;
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];

            }
            Console.WriteLine(sum);

            int[] array2 = new int[50];
            var random = new Random();

            int sum1 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(1, 100);
                sum1 += array2[i];
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine(sum1);
            #endregion
            Console.WriteLine();
            int[,] array3 = new int[2, 3];
            array3[0, 0] = 5;
            array3[0, 1] = 6;
            array3[0, 2] = 7;
            array3[1, 0] = 8;
            array3[1, 1] = 9;
            array3[1, 2] = 10;

            int sum2 = 0;
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum2 += array3[k,j];
                }
            }
            Console.WriteLine(sum2);

            Console.ReadLine();

        }
        static void Main1(string[] args)
        {
            DateTime D1 = DateTime.Now;
            Console.WriteLine(D1.ToLongDateString());
            Console.WriteLine(D1.Date.ToString("dd.MM.yyyy HH:mm:ss:fff"));
            Console.WriteLine((int)D1.DayOfWeek);//Burda heftenin gununu string sekilde verir meselen Thursday.(int) yazanda enumm da etdiyimizin tersini edirik ve string degeri int degere ceviririk.heftenin 2 ssi yəni.
            Console.WriteLine(D1.DayOfYear);
            Console.WriteLine(D1.TimeOfDay);
            Console.WriteLine(D1.Add(TimeSpan.Parse("10:00:00")));

            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            var studentType = (StudentType)int.Parse(Console.ReadLine());

            if (studentType == StudentType.GoodStudent)
            {
                //do something
            }
            else if(studentType == StudentType.ExcellentStudent)
            {
                //do some other stuff
            }
        }
    }
    public enum StudentType//Enum ededlere string deger vermek ucundur.
    {
        BadStudent,
        GoodStudent,
        VeryGoodStudent,
        ExcellentStudent
    }
}

