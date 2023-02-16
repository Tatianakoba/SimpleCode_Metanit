using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Anonimus_methods
{
    internal class Program
    {
        delegate void MessageHandler(string mes);
        static void Main(string[] args)
        {
            MessageHandler handler = delegate (string message)
            {
                Console.WriteLine(message);
            };
            handler("hello");
            Show("World!", delegate (string m)
            {
                Console.WriteLine(m);
            });

            Console.ReadKey();
        }
        static void Show(string mes, MessageHandler handler)
        {
            handler(mes);
        }
    }
}
