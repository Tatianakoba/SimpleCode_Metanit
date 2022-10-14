using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Static_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1000, 6);
            //Account acc2 = new Account(900, 5);
            //Account.MinSum = 200;
            //Account.GetSum(1000, 10, 5);
            //acc2.MinSum = 200;
            //Console.WriteLine(acc1.GetSum(1000,10,5));
            //Console.WriteLine(acc2.GetSum(1000,10,5));
            User user1 = new User(); //при создании первого пользователя был выполнен статический конструктор
            User user2 = new User();
            User user3 = new User();
            User.Display();
            Console.WriteLine($"User1 Id = {user1.Id}");
            Console.WriteLine($"User3 Id = {user3.Id}");

            Console.ReadKey();
        }
    }
    class User
    {
        private static int counter = 0;
        public int Id { get; set; }
        static User() //статический конструктор
        {
            Console.WriteLine("First User is created");
        }
        public User()
        {
            Id = ++counter;
        }
        public static void Display()
        {
            Console.WriteLine($"Количество зарегистрированных пользователей {counter}");
        }
    }
    class Account
    { 
        //Минимально допустимая сумма для всех счетов
        private static decimal minSum = 100;
        public Account(decimal sum, decimal rate)
        {
            if (sum < minSum) throw new Exception("Недопустимая сумма!");
            Sum = sum; Rate = rate;
        }
        public static decimal MinSum
        {
            get { return minSum; }
            set {if (value>0) minSum=value ; } 
        }
        public decimal Sum { get; private set; }//сумма на счете
        public decimal Rate { get; private set; }//процентная ставка

        //подсчет суммы на счете через определенный период по определенной процентной ставке
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i= 0; i < period; i++)
                result = result+result * rate/100;
            return result;

        }
    }
}
