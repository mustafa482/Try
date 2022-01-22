using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
   public static class MyExtension
    {
        public static void PrintUserDetails(this User user)
        {
            Console.WriteLine($"Name: {user.Name} DateofBirth: {user.DateOfBirth}");
        }
    }
}
