using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i=0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        
        static void Main(string[] args)
        {
            //PARAMS
            Addition(new int[] { 1, 2, 3, 4 });
            Addition(2, 3, 4, 5);
            Addition();

            
            Console.ReadKey();
        }
    }
}
