using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class User
    {
        protected internal string name;
        protected internal int age;
        public void Display()
        {
            Console.WriteLine(name);
        }
        //вложенные классы
        private class UserAccount
        {
            private string password;
        }
    }
    class Employee : User
    {
        public void DisplayEmployee()
        {
            Console.WriteLine(name);
        }
    }

}
