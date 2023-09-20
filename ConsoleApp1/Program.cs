using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string a = "Wake up, Neo...";
            foreach (char ch in a)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
            Thread.Sleep(5000);
            Console.Clear();
            String b = "The Matrix has you...";
            foreach (char ch in b)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
            
            Console.ReadKey();
            Console.Clear();
            String c = "Follow the white rabbit.";
            foreach (char ch in c)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
            
            Console.ReadKey();
            Console.Clear();
            String d = "Knok, knok, Neo.";
            foreach (char ch in d)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
            Console.ReadKey();

        }
    }
}
