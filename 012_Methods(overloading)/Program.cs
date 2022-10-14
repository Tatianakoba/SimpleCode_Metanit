using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Methods_overloading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1,2);
            calc.Add(1,2,3);
            calc.Add(1.2,3.0);
            calc.Add(1, 2, 3, 4);
            Console.ReadKey();

        }
    }
    class Calculator
    {
        public void Add (int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"result = {result}") ;
        }
        public void Add (int x, int y, int z)
        {
            int result = x + y+z ;
            Console.WriteLine($"result = {result}");
        }

        public void Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"result = {result}");
        }
        public int Add(int x, int y, int z, int t)
        {
            int result = x + y+x+t;
            
            Console.WriteLine($"result = {result}");
            return x + y;
        }
    }
}
