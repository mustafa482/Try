using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson17
{
    class Program
    {
        public delegate void DoSomething();

        public static void PrintHelloToScreen()
        {
            Console.WriteLine("Hello");
        }
        public static void WriteHelloToFile()
        {
            File.WriteAllText("myfile.txt", "hello");
        }

        


        static void Main(string[] args)
        {

            var user = new User("Hasim", new DateTime(2001, 1, 1));
            MyExtension.PrintUserDetails(user);
            user.PrintUserDetails();













            //Func<User, bool> myFunctionDelegate = Get2<User, bool>;
            Func<User, bool> myFunctionDelegate = (u) => u.DateOfBirth > new DateTime(2000, 1, 1);
            var isTrue = myFunctionDelegate(new User("Hasim", new DateTime(2001,1,1)));

            var users = InitializeUserList();
            var filteredList = users.Where(GetReal);

            //var filteredList1 = users.Where(delegate(User user) 
            //{
            //    return user.DateOfBirth < DateTime.Today.AddYears(-20);
            //});//Əvvəlcədən bir metod yazib da daxil etmək olur belə anonymous metodda

            var filteredList1 = users.Where(user => user.DateOfBirth < DateTime.Today.AddYears(-20));//Yuxarida commente alinan formatin lambda expression ile yazilisi.
        
            
               





            Action myAction = () =>
            {
                Console.WriteLine("DO Something");
            };

            myAction();

            Action<string, string> greetsomeone = (name, surname) =>
            {
                Console.WriteLine($"Hello {name} {surname}");
            };

            greetsomeone("Mustafa", "Mustafayev");


            DoSomething myDelegate = new DoSomething(PrintHelloToScreen);
            myDelegate += WriteHelloToFile;

            myDelegate();

            Console.ReadKey();

        }

        public static List<User> InitializeUserList()
        {
            return new List<User>()
            {
                new User("Mustafa",DateTime.Parse("2002-04-09")),
                new User("Samir",DateTime.Parse("2003-10-11")),
                new User("Ilkin",DateTime.Parse("2005-01-01")),
                new User("Ferid",DateTime.Parse("2000-03-30")),
                new User("Ilqar",DateTime.Parse("1997-12-18"))

            };
        }


        public static void Do1()
        {

        }
        public static void Do2<T>(T arg)
        {

        }
        public static void Do3<T1,T2>(T1 arg1, T2 arg2)
        {

        }
        //Action delegate

        public static TResult Get1<TResult>()
        {
            return default;
        }
        public static bool GetReal(User user)
        {
            return user.DateOfBirth < DateTime.Today.AddYears(-20);
        }
        public static TResult Get3<T1,T2, TResult>(T1 arg1,T2 arg2)
        {
            return default;
        }
        //Bu sintatksis ise Func delegate
    }
    public class User
    {
        public User(string name,DateTime date)
        {
            Name = name;
            DateOfBirth = date;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

    }//Extension Method => Nuget Packages le yuklediyimiz classda deyisiklik etmek ucun istifade olunur.Basqa bir static olan class yaradiriq evvelce. Daha sonra o metodu ora elave edib yaziriq.Diqqet etmeliyik eyni namespace de olamlidirlar.
}
