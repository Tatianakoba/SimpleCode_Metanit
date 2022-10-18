using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person ( "Bill", "Gates");
            Employee employee = new Employee ("John", "Smith", "Google");
            person.Display();
            employee.Display();
            Console.ReadKey();
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
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public void Display()
        {
            Console.WriteLine(FirstName
                +" "+LastName);
        }
    }
}
