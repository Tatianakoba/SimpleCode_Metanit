using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_enum
{
    internal class Program
    {
        enum Days : int
        {
            Monday = 1, 
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        static void ApplyOperation (double x, double y, Operation op)
        {
            double result = 0.0;
            switch(op)
            {
                case Operation.Add: 
                    result = x+y; break;
                case Operation.Subtract: 
                    result = x-y; break;
                case Operation.Multiply:
                    result = x*y; break;
                case Operation.Divide:
                    result = x/y; break;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Days day;
            day = Days.Monday;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            ApplyOperation(10,15, Operation.Subtract);


            Console.ReadKey();
        }
    }
}
