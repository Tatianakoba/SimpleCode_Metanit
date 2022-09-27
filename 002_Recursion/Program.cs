using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Recursion
{
    internal class Program
    {
        //Факториал F(n) = n!; 5! = 1*2*3*4*5 = 120
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n*Factorial(n - 1);
        }
        // Фибоначчи
        //f(n)=f(n-1)+f(n-2)
        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {
            int x = Factorial(5);

            Console.WriteLine(x);
            x = Fibonachi(8);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
