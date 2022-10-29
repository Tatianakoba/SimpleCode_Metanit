using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_events
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
    class Account
    {
        int _sum;
        //AccountStateHandler _del;
        public event AccountStateHandler Added;//Past Participle
        public event AccountStateHandler Adding;//ing form

        public event AccountStateHandler Withdrawn;
        //public void RegisterHandler(AccountStateHandler del)
        //{
        //    _del += del;
        //}
        //public void UnregisterHandler(AccountStateHandler del)
        //{
        //    _del -= del;
        //}
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            if (Adding != null)
            {
                Added(this, 
                    new AccountEventArgs($"На счет добавляется {sum}", sum));

            }
            _sum += sum;
            if (Added != null)
            {
                Added(this,
                    new AccountEventArgs($"На счет пришло {sum}", sum));

            }
                    }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                {
                    Withdrawn(this,
                        new AccountEventArgs($"Со счета снято {sum}", sum));

                }
            }
            else
            {
                if (Withdrawn != null)
                {
                    Withdrawn(this,
                        new AccountEventArgs($"На счете недостаточно средств", 0));

                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(3000);
            account.Added += new AccountStateHandler(Display);
            account.Withdrawn += Display;
            account.Put(500);
            account.Withdraw(800);
            account.Withdrawn -= Display;
            account.Withdrawn += ColorDisplay;
            account.Withdraw(8000);

            



            Console.ReadKey();
        }

        static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
        static void ColorDisplay(object sender, AccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}
