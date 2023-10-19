using System;
using System.Security.Cryptography.X509Certificates;

namespace Fibonacci
{
    internal class Program
    {
        public static int Fibonacci(int value)
        {
            if (value <= 1)
            {
                return value =1;

            }
            
            else
            {
                return value = Fibonacci(value - 2) + Fibonacci(value - 1);
            }            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(9));
            Console.ReadKey();
        }
       
    }
}
