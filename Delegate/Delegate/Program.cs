using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidDelegate v = new VoidDelegate(DoSomething);
            v += DoSomething1;
            v += () =>
            {
                Console.WriteLine("Lambda Expression");
            };
            
            v();
            
        }

        public delegate void VoidDelegate();

        public static void DoSomething()
        {
            Console.WriteLine("Do Something");
        }
        public static void DoSomething1()
        {
            Console.WriteLine("Do Something1");
        }
        
    }
}
