using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson15
{
    class Program
    {
        public static void Main()
        {
            DataCollection<int> dataCollection = new DataCollection<int>();
            dataCollection.Add(1);
            dataCollection.Add(2);
            dataCollection.Add(3);

            
            Console.WriteLine(dataCollection.GetElementByIndex(0));
            Console.WriteLine(dataCollection.GetElementByIndex(1));
            int sum = 0;
            //for (int i = 0; i < dataCollection.Count; i++)
            //{
            //    sum += dataCollection.GetElementByIndex(i);
            //}
            //Console.WriteLine(sum);
            foreach (var item in dataCollection)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
        static void Main3()
        {
            //HashSet
            HashSet<string> MyHashSet1 = new HashSet<string>();
            MyHashSet1.Add("Salam");

            HashSet<string> MyHashSet2 = new HashSet<string>();
            MyHashSet2.Add("Salam");
            MyHashSet2.Add("Salam1");

            MyHashSet1.ExceptWith(MyHashSet2);//Ferqli olan elementleri
            MyHashSet1.IntersectWith(MyHashSet2);//Ortaq elementleri tapir.
            MyHashSet1.UnionWith(MyHashSet2);//Birlesdirir 2 HashSeti

            Console.ReadKey();


        }
        static void Main2()
        {
            //Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var queueCount = queue.Count;

            for (int i = 0; i < queueCount; i++)
            {
                Console.WriteLine("Next queque element is: " + queue.Dequeue());
            }
            Console.ReadKey();
            //3.stack

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var stackCount = stack.Count;
            for (int i = 0; i < stackCount; i++)
            {
                Console.WriteLine("Next stack element is: " + stack.Pop());
            }

            Console.ReadKey();
        }
        static void Main1(string[] args)
        {
            /*Data Structures
              1.Array
              2.ArrayList
            3.List
             */
            List<int> myIntList = new List<int>();
            myIntList.Add(10);
            myIntList.Add(11);
            myIntList.Add(12);
            //4.Dictionary

            Dictionary<string, int> regionPeopleCount = new Dictionary<string, int>();
            regionPeopleCount.Add("Baku", 5000);
            regionPeopleCount.Add("Sumgayit", 3500);
            regionPeopleCount.Add("Shaki", 3000);
            regionPeopleCount.Add("Naxcivan", 4000);

            foreach (var item in regionPeopleCount)
            {
                Console.WriteLine($"Region is people {item.Key},People count is {item.Value}");
            }
           

            Dictionary<int, User> userDictionary = new Dictionary<int, User>();
            var user1 = new User
            {
                ID = 1,
                Name = "Samir",
                DateOfBirth = DateTime.Now.AddYears(-20)
            };
            userDictionary.Add(user1.ID,user1);
            var user2 = new User
            {
                ID = 2,
                Name = "Samira",
                DateOfBirth = DateTime.Now.AddYears(-15)
            };
            userDictionary.Add(user2.ID, user2);

            Console.Write("Enter user id to find: ");

            var userID = int.Parse(Console.ReadLine());
            if (userDictionary.ContainsKey(userID))
            {
                var foundUser = userDictionary[userID];
                Console.WriteLine("Found user is " + foundUser);
            }
            else
            {
                Console.WriteLine("User with this id is not found");
            }
            


            var dataStoreForString = new DataStoreForString();
            dataStoreForString.Data = "Salam";

            var dataStoreForInt = new DataStoreForInt();
            dataStoreForInt.Data = 29;

            var dataStore = new DataStore<double>();
            dataStore.Data = 123.34;
        }
    }
    public class DataStoreForString
    {
        public string Data { get; set; }
    }
    public class DataStoreForInt
    {
        public int Data { get; set; }
    }
    public class DataStore<T>//Generic adlanir.Bele etmeymizin sebebi bu clasin instansi yarananda icindeki deyerin tipini o vaxt vermekdir.
    {
        public T Data { get; set; }
    }
    public class DataCollection<T>: IEnumerable<T>
    {
        private List<T> _item;

        public DataCollection()
        {
            _item = new List<T>();
        }
        public void Add(T item)
        {
            _item.Add(item);
        }
        public T GetElementByIndex(int index)
        {
            return _item[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count {
            get
            {
                return _item.Count;
            }
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Id is {ID}, Name is {Name},DateOfBirth is {DateOfBirth.ToString("dd.MM.yyyy")}";
        }
    }
}
