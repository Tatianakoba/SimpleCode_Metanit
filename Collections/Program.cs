//коллекции и перечисления
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Collections
{
    internal class Program
    {
        //перечисления
        enum daysOfWeek
        {
            Monday=1,
            Tuersday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        static void Main(string[] args)
        {
            Console.WriteLine(daysOfWeek.Sunday);

            //массив
            int[] ints = new int[5];
            Console.WriteLine("Введите числа");
            for (int i = 0; i < ints.Length; i++)
            {
               ints[i] = int.Parse (Console.ReadLine());
            }
            for (int j = 0;  j < ints.Length; j++)
            {
                Console.Write(ints[j]);
            }
            Console.ReadLine();
            
            //список
            List<int> list = new List<int>();
            for (int k=0; k<5; k++) 
            {
                list.Add (k);
            }

            Console.Write(String.Join(",", list));
            


            Console.ReadKey();
        }
    }
}
