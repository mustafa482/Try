using Helpers;
using Lesson10.Model;
using System;
using System.Linq;

namespace Lesson10
{
    class Program
    {
        static void Main()
        {
            var student = new Student();
            //byte iq = byte.Parse(Console.ReadLine());
            //student.SetIQ(iq);
            //Console.WriteLine(student.GetIq());
            student.IQ = 210;
            Console.WriteLine(student.IQ);
           
        }
        static void Main1(string[] args)
        {
            Student s = new Student();
            s.Name = "Ahmed";
            
            //Animal animal = new Dog("Coban iti", "tehlukeli ses");
            //animal.Move();
            Animal[] animal = new Animal[3];
            animal[0] = new Animal("Cat");
            animal[1] = new Dog("Hop","ses");
            animal[2] = new CobanIti("CobDog","sjsj","Test");
            ProcessAnimals(animal);
            foreach (var item in animal)
            {
                item.Move();
            }
            
            //Dog d = new Animal("");

            Dog dog = new Dog("Toplan", "Hav-hav");
            dog.SomeProperty = "";
            dog.Move();

            

            

            Model.User user = new Model.User();
            Console.WriteLine("Hello World!");

        }

       static void ProcessAnimals(Animal[] animal)
        {
            
            foreach (Animal animals in animal)
            {

                var d = animals as Dog;
                if(d != null)
                {
                    d.Run();
                }
                if (animals is Dog)
                {
                    
                    ((Dog)animals).Run();//Bu üsul base clasın child clasdan istifadə edə bilməsi üçündür Belə etsək ancaq iflə yoxlayıb etməliyik Aşağıdakı kimi etsək ya yoxlamalıyıq yada yuxarıdakı kimi yazmalıyıq
                    //var d = animals as Dog;        
                    //d.Run();

                }

                var dogCount = animal.Where(animals => animals is Dog).Count();
            }
           
        }
        

        
    }
}
