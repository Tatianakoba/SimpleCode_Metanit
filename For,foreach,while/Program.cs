using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace For_foreach_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            //заполняем список элементами с проверкой на int
            while (ints.Count<15)
            {

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    ints.Add(number);
                }
                else
                {
                    Console.WriteLine("Упс");
                }
            }
            
            //считаем сумму всех элементов списка
            int sum = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                sum+= ints[i];
            }

            Console.WriteLine(sum);
            //считаем разность всех элементов списка от первого
            var counter = 0;
            var dif = 0;
            dif += ints[0];

            while (counter<ints.Count)
            {
                dif -= ints[counter];
                counter++;
            }
            Console.WriteLine(dif);
            //считаем прооизведение всех элементов
            var h = 0;
            var mult = 1;
            do
            {
                mult *= ints[h];
                h++;
            }
            while (h < ints.Count);
            Console.WriteLine(mult);

            //выводим список через запятую
            foreach (var item in ints)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
