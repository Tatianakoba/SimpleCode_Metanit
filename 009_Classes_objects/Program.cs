using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Classes_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User {name = "Tom", age = 22 };
            //ChangeUser(ref user1); //убрать ref  и выведет изначальное значение
            //Console.WriteLine($"{user1.name} - {user1.age}");

            Person person1 = new Person {name = "Max", age = 21};
            ChangePerson(ref person1);
            Console.WriteLine($"{person1.name} - {person1.age}");
            Console.ReadKey();
        }
        static void ChangeUser(ref User user) //убрать ref  и выведет изначальное значение
        {
            user.name = "Bob";
            user.age = 33;
        }
        static void ChangePerson(ref Person person)
        {
            person.name = "Bobby";
            person.age = 31;
            person = new Person { name = "Bill", age = 31 };

        }
    }
    struct User
    {
        public string name;
        public int age;
    }
    class Person
    {
        public string name;
        public int age;
    }
}
