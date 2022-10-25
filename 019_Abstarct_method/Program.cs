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
    //abstract class Figure
    //{
    //    public abstract float Perimeter();
    //    public abstract float Square();
    //}
    //class Rectangle : Figure
    //{
    //    public float Width { get; set; }
    //    public float Height { get; set; }
    //    public override float Perimeter()
    //    {
    //        return Width*2 + Height*2;
    //    }

    //    public override float Square()
    //    {
    //        return Height*Width;
    //    }
    //}

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
        public abstract void Display(); //не могут быть private
        //абстрактные методы могут быть только в абстрактном классе
        

    }
    class Client : Person
    {

        public int Sum { get; set; }
        public Client(string name, string surname, int sum)
            : base(name, surname)
        {

            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"Client {FirstName} {LastName}");
        }

    }
    class Employee : Person
    {


        public string Position { get; set; }
        public Employee(string name, string surname, string position)
            : base(name, surname)
        {

            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine($"Employee {FirstName} {LastName}");
        }
    }
}
