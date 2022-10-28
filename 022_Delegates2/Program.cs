using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Delegates2
{
    delegate void AccountStateHandler(string message);
    class Account
    {
        int _sum;
        AccountStateHandler _del;
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del;
        }
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            _sum += sum;
            if (_del !=null)
            {
                _del($"На счет пришло {sum}");
                
            }
            
        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if (_del != null)
                {
                    _del($"Со счета снято {sum}");
                    
                }
            }
            else
            {
                if (_del != null)
                {
                    _del($"На счете недостаточно средств");
                    
                }
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(3000);
            account.RegisterHandler(Display);
            account.Put(500);
            account.Withdraw(800);
            account.UnregisterHandler(Display);
            account.RegisterHandler(ColorDisplay);
            account.Withdraw(8000);
            account.UnregisterHandler(ColorDisplay);
            


            Console.ReadKey();
        }
        
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static void ColorDisplay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
