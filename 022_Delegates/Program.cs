using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Delegates
{
    internal class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Message message;
            message = Display; // или message = new Message(Display);
            message.Invoke();
            message();

            Operation operation = Add;
            int result = operation.Invoke(4, 5);
            Console.WriteLine(result);
            operation = Multiply;
            result = operation.Invoke(4, 5);
            Console.WriteLine(result);

            DoOperation(4, 5, Add);
            DoOperation(4,5, Multiply);

            Console.ReadKey();

        }
        static void DoOperation(int x, int y, Operation operation)
        {
            int res = operation(x, y);
            Console.WriteLine(res);

        }
        static int Add(int x,int y)
            { return x + y; }

        static int Multiply(int x, int y)
            { return x * y; }
            
        static void Display()
        {
            Console.WriteLine("Hello");
        }
    }
}
