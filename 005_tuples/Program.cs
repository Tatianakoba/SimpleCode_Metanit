
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_tuples
{
    internal class Program
    {
        static (string, int) GetValue((string,int) tuple, int x)
        {
            var result = (name:tuple.Item1, age:tuple.Item2+x);
            //int result = 1;
            //int result2 = 3;
            return result;

        }
        static void Main(string[] args)
        {
            var (name, age) = ("Tom", 25);
            //var tuple = (count: 5, sum: 10);
            //Console.WriteLine(tuple.count);
            //Console.WriteLine(tuple.sum);

            //tuple.Item1 += 20;
            //Console.WriteLine(tuple.count);
            Console.WriteLine(name);
            Console.WriteLine(age);

            var tuple = GetValue(("Tom",25), 10);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            Console.ReadKey();
        }
    }
}
