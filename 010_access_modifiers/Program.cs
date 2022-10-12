using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person ();
            //person.name = "Tom";
            person.Display();
            User user = new User ();// или Accounts.User =... или using Accounts вверху
            Console.ReadKey();
        }
    }
    class Manager: User
    {
        public void DisplayManager()
        {
            Console.WriteLine(name);
        }
    }
    class Person
    {
        public string name;
        public int age;
        public void Display()
        {
            Console.WriteLine(name);
        }
    }
}
