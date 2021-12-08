using System;
using System.IO;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = File.ReadAllText(@"D:\Desktop\MyDB\UserDocument.txt");
            IUser user;
            if (config == "1")
            {
                user = new Person1();
            }
            else
            {
                user = new Person2();
            }
            User user1 = new User(user)
            {
                Id = 1,
                Name = "Mustafa",
                SurName = "Mustafayev"
            };
            user1.Person();
            Console.WriteLine();
            Console.ReadKey();
        }
        public class User
        {
            private readonly IUser _user;
            public int Id { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            

            public User(IUser user )
            {
                _user = user;
            }

            public void Person()
            {
                _user.Person(this);
            }
        }



        public class Person1: IUser
        {
            public void Person(User user)
            {
                Console.WriteLine($"{nameof(user.Id)}: {user.Id}");
                Console.WriteLine($"{nameof(user.Name)}: {user.Name}");
                Console.WriteLine($"{nameof(user.SurName)}: {user.SurName}");
            }
        }
        public class Person2 : IUser
        {
            public void Person(User user)
            {
                Console.WriteLine($"Person1- {nameof(user.Id)}: {user.Id}");
                Console.WriteLine($"Person1- {nameof(user.Name)}: {user.Name}");
                Console.WriteLine($"Person1- {nameof(user.SurName)}: {user.SurName}");
            }
        }
        public interface IUser
        {
            void Person(User user);
        }
    }
}
