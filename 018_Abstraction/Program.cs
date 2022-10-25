using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person client = new Client("John", "Smith", 500);
            Person employee = new Employee("Bob", "Tompson", "manager");
            client.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
    abstract class Human
    {
        public string Name { get; set; }
    }
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
            
        }
        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
    class Client : Person
    {
       
        public int Sum { get; set; }
        public Client(string name, string surname, int sum)
            :base(name, surname)
        {
            
            Sum = sum; 
        }
        
    }
    class Employee : Person
    {

        
        public string Position { get; set; }
        public Employee(string name, string surname, string position)
            :base(name,surname)
        {
            
            Position = position;
        }
       
    }
}
