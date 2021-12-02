using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
   public class Struct
    {
        public static void Main1()
        {
            var user1 = new user
            {
                Name = "Samir",
                Age = 20

            };
            Console.WriteLine($"user1 name is {user1.Name}");
            var user2 = user1;
            user2.Name = "Ehmed";
            Console.WriteLine($"user1 name is {user1.Name}");
            Console.WriteLine($"user2 name is {user2.Name}");

        }
        public static void Main2()
        {
            var user1 = new User1
            {
                Name = "Samir",
                Age = 20
            };
            User1 user0 = default;//Structlara new demeden de bele default deger vermek olur ama classlarda mutleq instanse ni yaratmalisan.Structda inheritance yoxdur.Struct Value.Type dan toreyir.O gedir Object den toreyir.Ana tip Objectdir.struct single unite i ifade elemek ucun istifade olunur.(int,boolean,double,decimal)vs.
            user0.Age = 21;
            user0.Name = "Filankes";
            Console.WriteLine($"user1 name is {user1.Name}");
            var user2 = user1;
            user2.Name = "Ehmed";
            Console.WriteLine($"user1 name is {user1.Name}");
            Console.WriteLine($"user2 name is {user2.Name}");
        }
        public static void Main5()
        {
            var user1 = new user
            {
                Name = "Samir",
                Age = 20
            };
            Console.WriteLine($"user1 name is {user1.Name}");
            var user2 = new user();
            user2.StructAnother(user1);
            user2.Name = "Ehmed";
            Console.WriteLine($"user1 name is {user1.Name}");
            Console.WriteLine($"user2 name is {user2.Name}");
        }
    }
   public class user 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void StructAnother(user userProp)
        {
            Name = userProp.Name;
            Age = userProp.Age;
        }
    }
    public struct User1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
