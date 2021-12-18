using System;
using System.IO;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LogFiles = @"D:\Desktop\MyDB\Exception.txt";
            Console.Write("Please Numbers: ");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                result = number1 / number2;
                //string str = null;
                //str.Trim();
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("Second number should not be 0");
                File.AppendAllText(LogFiles, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:ff") + '\n' + exc.ToString() + "\n \n");
                throw new OperationMyException("0 a bolmek olmaz",exc,"Divide");
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Please enter correct number");
                File.AppendAllText(LogFiles, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:ff") + '\n' + exc.ToString() + "\n \n");
            }
            catch (Exception exc)
            {

                Console.WriteLine("Something unexcepted occured");
                File.AppendAllText(LogFiles, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:ff") + '\n' + exc.ToString() + "\n \n");
                //throw;
            }
            finally
            {
                Console.WriteLine("Show always");
            }

            Console.WriteLine(result);
            Console.WriteLine("Next Statment");
        }
    }
}
