using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Tom";
            person.LastName = "Smith";

            person.Age = 18;
            Console.WriteLine(person.Age);
            person.Age = -23;
            person.Age = 200000;
            //person.Age = 45;
            //int r = person.Age;
            Console.WriteLine(person.Age);
            Console.WriteLine(person.FullName);
            
            

            Console.ReadKey();
        }
    }
    class Person
    {
        private int age;
        public int Age
        { 
            get { return age; }
            set { 
                    if (value>=0 && value<99)    
                         age = value; 
                } 
        }
        private string firstName;
        //Определяем свойства
        public string FirstName
        {
            
            set { firstName = value; }
        }



        private string lastName;
        //Определяем свойства
        public string LastName
        {
           
            set { lastName = value; }
        }


        
        //Определяем свойства
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
            
        }

        ////Автоматические свойства
        //public int Age { get; set; } = 56; //присвоили некоторое начальное значение
        ////тоде самое, что и 
        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //         age = value;
        //    }
        //}

    }
}
