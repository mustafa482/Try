using System;
using System.IO;

namespace Lesson12
{
    class Program
    {
        const string MyDbDirectory = @"D:\Desktop\MyDB";
        const string DateFormat = "yyyy-MM-dd";
        static void Main1(string[] args)
        {
            Console.WriteLine("What do you want to do ?\n 1-Create Student\n 2-See all registered student");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var student = CreateStudent();
                    RegisterStudentInDb(student);
                    break;
                case 2:
                    var students = GetStudents();
                    PrintStudents(students);
                    break;
                default:
                    throw new ArgumentException(nameof(option));
            }
            Console.ReadKey();
            //var student = CreateStudent();
            //RegisterStudentInDb(student);
        }
        public static Student CreateStudent()
        {
            Console.WriteLine("Student Register...");
            Console.WriteLine();

            var student = new Student();

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("SurName: ");
            student.SurName = Console.ReadLine();

            Console.Write($"DateOfBirth:  ({DateFormat})");
            student.DateOfBirth = DateTime.Parse(Console.ReadLine());

            student.Id = Guid.NewGuid();

            return student;
        }
        public static void RegisterStudentInDb(Student student)
        {
            //var directory = new DirectoryInfo(MyDbDirectory);//File alir c# formatina cevirir.
            var file = Path.Combine(MyDbDirectory, student.Id + ".txt");//Path file ve directoryler haqqinda melumat saxlayir.
            if (File.Exists(file))
            {
                Console.WriteLine("This student has already been registered");
            }
            else
            {
                var filetext = $"Name: {student.Name}\n" +
                    $"Surname: {student.SurName}\n" +
                    $"DateOfBirth: {student.DateOfBirth.ToString(DateFormat)}";

                File.WriteAllText(file, filetext);

                Console.WriteLine("Student is succesfully registed");
            }
            
        }


        public static Student[] GetStudents()
        {
            var directory = new DirectoryInfo(MyDbDirectory);
            var files = directory.GetFiles();

            var students = new Student[100];

            var i = 0;

            foreach (var file in files)
            {
                var fileLines = File.ReadAllLines(file.FullName);
                var student = new Student();
                student.Name = fileLines[0].Split(':')[1].Trim();
                student.SurName = fileLines[1].Split(':')[1].Trim();
                student.DateOfBirth = DateTime.Parse(fileLines[2].Split(':')[1].Trim());

                students[i] = student;
                i++;
            }

            return students;
        }


        public static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                if (student is null)
                {
                    break;
                }
                PrintStudent(student);
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine();

            }
        }


        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"{nameof(student.Name)}: {student.Name}");
            Console.WriteLine($"{nameof(student.SurName)}: {student.SurName}");
            Console.WriteLine($"{nameof(student.DateOfBirth)}: {student.DateOfBirth.ToString(DateFormat)}");
        }
    }
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
