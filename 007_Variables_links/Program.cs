using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Variables_links
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int nRef = ref Find(numbers, 4);
            Console.WriteLine(numbers[3]);
            nRef = 45;
            Console.WriteLine(numbers[3]);
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine($"x={x}");
            Console.WriteLine($"xRef={xRef}");
            xRef = 125;
            Console.WriteLine($"x={x}");

            Console.ReadKey();

        }
        static ref int Find(int[] numbers, int number)
        {
            for(int i= 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
                
            }
            throw new Exception("число не найдено");
        }
    }
}
