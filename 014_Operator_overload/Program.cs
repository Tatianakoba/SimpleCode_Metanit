using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _014_Operator_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };
            Counter c3 = c2 + c1;
            Console.WriteLine(c3.Value);
            bool result = c1 > c2;
            Console.WriteLine(result);
            int x = c2 + 20;
            Console.WriteLine(x); 
            c1++;
            ++c1;
            Console.ReadKey();
        }
    }
    // -, !, ~,++,--, +,-,*,/,==,!=,>,<, <=, >=,&&,||,+=,-=,*=,/=
    // не можем перегрузить:
    //=,?:


        class Counter
        {
            public int Value { get; set; }
        //возвращаемый тип Counter
        //перегрузка операторов представляет собой метод
            public static Counter operator ++(Counter c1)
        {
            
            return new Counter { Value = c1.Value +1};
        }
            public static Counter operator +(Counter c1,Counter c2)
            {
                return new Counter { Value = c1.Value + c2.Value };
            }
            public static int operator +( Counter c1, int y)
            {
                return   y + c1.Value;
            }
            public static bool operator >(Counter c1, Counter c2)
            {
                if (c1.Value > c2.Value)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Counter c1, Counter c2)
            {
                if (c1.Value < c2.Value)
                    return true;
                else
                    return false;
            }

    }
    
}
