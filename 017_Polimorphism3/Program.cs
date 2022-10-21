using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill", "Gates");
            p1.Display();
            Person p2 = new Employee("John", "Smith", "Google");
            p2.Display();
            Employee p3 = new Employee("Bob", "Tompson", "Apple");
            p3.Display();
            Employee p4 = new Manager("Richard", "Speight jr.", "Disney");
            p4.Display();
            Console.ReadKey();
        }
    }
    class Manager : Employee
    {
        public Manager(string name, string surname, string comp)
            : base(name, surname, comp)
        {

        }

    }
    class Employee : Person
    {

        private string _company;
        public Employee(string name, string surname, string comp)
            : base(name, surname)
        {
            Company = comp;
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public new void Display()
        {
            //base.Display();
            Console.WriteLine(" works in " + Company);
        }

    }
    class Person
    {
        private string _firstName;
        private string _lastName;


        public Person(string name, string surname)
        {
            _firstName = name;
            _lastName = surname;
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public virtual string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public void Display()
        {
            Console.WriteLine(FirstName
                + " " + LastName);
        }
    }
}
