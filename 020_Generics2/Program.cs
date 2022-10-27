using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(23) { Sum = 4500 };
            Account acc2 = new Account(55) { Sum = 5000 };

            DemandAccount acc3 = new DemandAccount(102) { Sum = 4000 };
            DemandAccount acc4 = new DemandAccount(125) { Sum = 3000 };

            Transaction<Account> t1 = new Transaction<Account>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };

            Transaction<DemandAccount> t2 = new Transaction<DemandAccount>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700
            };

            t1.Execute();
            t2.Execute();

            Console.ReadKey();
        }
    }
    class Transaction<T> where T : Account //счета, которые используются в классе Transaction представляют класс Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }
        public void Execute()
        {
            if (FromAccount.Sum >Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n" + $"{ToAccount.Id} : {ToAccount.Sum}");
            }
        }
    }
    class Account
    {
        public int Id { get;}
        public int Sum { get; set; }
        public Account(int id)
        {
            Id = id;
        }

    }
    class DemandAccount: Account
    {
        public DemandAccount(int id): base(id)
        { }
    }
}
