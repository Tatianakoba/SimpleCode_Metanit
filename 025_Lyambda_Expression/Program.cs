using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _025_Lyambda_Expression
{
    internal class Program
    {
        delegate int Operation(int x, int y);
        delegate int Square(int x);
        delegate void Hello();
        delegate bool IsEqual(int n);
        static void Main(string[] args)
        {
            Operation operation = (x, y) => x + y;
            Square square = x => x*x;
            Hello hello1 = () => Console.WriteLine("Hello");
            Hello hello2 = () => Console.WriteLine("Welcome");
            hello1();
            hello2();
            Console.WriteLine(operation(3,4));
            Console.WriteLine(operation(5,6));


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x1 = Sum(numbers, n => n > 5);
            int x2 = Sum(numbers, n => n %2==0);
            Console.WriteLine($"Сумма чисел массива, больше 5: {x1}");
            Console.WriteLine($"Сумма четных чисел массива {x2}");
            Console.ReadKey();

         }
        static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach(int n in numbers)
            {
                if(func(n))
                result += n;
            }
            return result;
        }
    }
}
