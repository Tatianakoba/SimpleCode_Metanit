using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Structures
{
    struct User
    {
        public string name;
        public int age;

        public User(string n, int a)
        {
            name = n; age = a; 
        }
    
        public  void DisplayInfo()
        {
            Console.WriteLine($"name ={name} age ={age}");
        }
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            User tom = new User("Tom",23);
            //tom.name = "Tom";
            //tom.age = 23;
            tom.DisplayInfo(); 
            User[] users = new User[2];
            users[0] = new User("Bob",18);
            users[1] = new User("Charlie", 20);
            //users[0].name = "Bob";
            //users[1].name = "Charlie";
            //users[0].age = 18;
            //users[1].age = 20;
            foreach (User user in users)
            {
                user.DisplayInfo();
            }
            Console.ReadKey();

        }
    }
}
