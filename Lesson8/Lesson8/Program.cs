using System;

namespace Lesson8
{
    class Program
    {
       public static void Main(string[] args)
        {
            
            
            User.cins = "Kisi";
             
            User U = new User("Mustafa","Mustafayev",2002);
            User U2 = new User("Ilkin","Nesibli",2003);
            
            

            U.Print();
            Console.WriteLine(U.FullName());
            Console.WriteLine($"Yasim: {U.GetAge()}");
            Console.WriteLine(U.GetAgeAfterxYear(10));

            U2.Print();
            Console.WriteLine(U2.FullName());
            Console.WriteLine($"Yasim: {U2.GetAge()}");
            Console.WriteLine(U2.GetAgeAfterxYear(15));
        }
       public static int Summ(int x,int y)
        {
            return x + y;
        }

    }
    class User
    {
        public string ad;
        public string soyad;
        public int year;
        public static string cins;

        public void Print()
        {
            Console.WriteLine($"Menim adim {ad}, soyadim {soyad}.Dogdugum il ise {year} dir. Cinsiyetim {cins} dir");
        }
        public string FullName()
        {
            return ad + " " + soyad;
            
        }
        public int GetAge()
        {
           
            return DateTime.Now.Year - year;
        }
        public int GetAgeAfterxYear(int years)
        {
            return GetAge() + years;
        }
        public User(string Ad,string Soyad,int Year)
        {
            year = Year;
            ad = Ad;
            soyad = Soyad;
        }
        public User(string Ad, string Soyad)
        {
            ad = Ad;
            soyad = Soyad;
        }
        public User(int Year)
        {
            year = Year;
        }
        public User()
        {
                
        }
        ~User()//Destructor Garbic Collector yaddas dolanda heap hissede lazimsiz seyleri silen zaman isleyir.
        {

        }
        static void value()
        {
            
            
            Console.WriteLine();
        }

    }
}
