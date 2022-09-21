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
                    break ;
            }


        }
    }
}
