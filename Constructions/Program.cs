using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{//break, goto case, return, throw
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали клавишу Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали клавишу N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    break;
            }

            //тернарный оператор ор1?ор2:ор3 (если ор1 истина, то выполняется ор2, если ложно, то выполняется ор3
            int x = 3;
            int y = 2;
            Console.WriteLine("Введите + или -");
            string selection2 = Console.ReadLine();
            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
            Console.ReadKey();


        }
    }
}
