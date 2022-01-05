using System;
using System.Collections.Generic;

namespace Lesson16
{
    class Program
    {
        //Delegates
        delegate List<int> FilterMyList(bool condition);
        static void Main(string[] args)
        {

            var user = new User()
            {
                Name = "Mustafa",
                Gmail = "Mm.Gmail.com"
                
            };

            Console.WriteLine(user);
            var list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
            };

            //var NewList = GetElementMoreThanTen(list,10);
            Console.WriteLine(GetListAsString(GetElementMoreThanNum(list,2)));
            
           
        }
        static List<int> GetElementMoreThanTen(List<int> list, int number)
        {



            var sublist = new List<int>();
            foreach (var item in list)
            {
                if (item > number)
                {
                    sublist.Add(item);
                }
            }
            return sublist;

        }


        static List<int> GetElementMoreThanNum(List<int> list, int number)
        {



            var sublist = new List<int>();
            foreach (var item in list)
            {
                if (item % number ==0)
                {
                    sublist.Add(item);
                }
            }
            return sublist;

        }


        static List<int> GetElementMoreThanSimple(List<int> list)
        {



            var sublist = new List<int>();
            foreach (var item in list)
            {
                if (item )
                {
                    sublist.Add(item);
                }
            }
            return sublist;

        }


        static string GetListAsString(List<int> list)
        {
            var str = "";
            int max = 0;

            foreach (var item in list)
            {

                str += item + ",";
            }
            //str = str.Remove(str.Length - 1, 1);//Sonuncudan basla 1 denesini sil
            //str = str.TrimEnd(',');//En sondaki vergulu sil
            str = str.Substring(0, str.Length - 1);//0cidan basla sonuncuya qeder i silme.Sadece sonuncuyu sil.
            return str;
            
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Gmail { get; set; }

        public override string ToString()
        {
            return Name + "," + Gmail;
        }
    }
}
