using System;
using System.Runtime.InteropServices;

namespace if__switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите 3 числа:");
            //var variables = Console.ReadLine().Split(' ');
            //int a = int.Parse(variables[0]);
            //int b = int.Parse(variables[1]);
            //int c = int.Parse(variables[2]);
            //if ((a>b)&&(a>c)) 
            //{
            //    Console.WriteLine("Наибольшее {0}",a);
            //}
            //else if ((b>c)&&(b>a))
            //{
            //    Console.WriteLine("Наибольшее {0}", b);
            //}
            //else
            //{
            //    Console.WriteLine("Наибольшее {0}", c);
            //}

            Console.WriteLine("Введите  число:");
            int x = int.Parse(Console.ReadLine());
            int y = x % 2;
            switch (y)
            {
                case 0:
                    y = 0;
                    Console.WriteLine("Четное");

                    break;
                case 1:
                    Console.WriteLine("Нечетное");
                    break;

            }
            var s = x < 100 ?  "да" : "нет";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
