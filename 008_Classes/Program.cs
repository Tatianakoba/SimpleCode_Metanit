using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom",23);
            //tom.name = "Tom";
            //tom.age = 22;
            tom.Info();
            Console.ReadKey();
        }

    }
    class User
    {
        public string name;
        public int age;
        public void Info()
        {
            Console.WriteLine($"{name} - {age}");
        }
        public User(string name)
        {
            this.name = name;
        }
        public User(string n, int a) : this(n)
        {
            
            age = a;
        }
    }
}
