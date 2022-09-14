using System;
using System.Globalization;

namespace Simple_code__Globalisation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";
            NumberFormatInfo NumberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",

            };
            double a = Convert.ToDouble(str, NumberFormatInfo);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
