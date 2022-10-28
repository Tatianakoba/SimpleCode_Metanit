using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount client = new Client("Tom", 3000);
            client.Put(5000);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(1000);
            Console.WriteLine(client.CurrentSum);

            Client client2 = client as Client;
            string name = client2.Name; //((Client)client).Name;
              

            Console.ReadKey();
        }
    }
    interface IAccount
    {
        //не используем модификаторы доступа, по умолчанию public
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);

    }
    interface IClient
    {
        string Name { get; set; }
    }
    interface IClientAccount : IAccount, IClient
    {
        void GetIncome();
    }
    class VipClient : IClientAccount
    {
        public int CurrentSum => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetIncome()
        {
            throw new NotImplementedException();
        }

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }
    }

    class Client : IAccount, IClient
    {
        int _sum;
        //для инициализации объекта класса определим конструктор
        public Client(string name, int sum)
        {
            Name = name; _sum = sum; 
                
        }
        public int CurrentSum { get { return _sum; } }

        public string Name { get; set; }

        public void Put(int sum)
        {
            _sum += sum ;
        }

        public void Withdraw(int sum)
        {
            if (_sum>=sum) _sum -= sum;
        }
    }
}
