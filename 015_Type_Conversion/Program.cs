using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _015_Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Seconds = 115};
            Timer timer1 = counter1;//1:55
            Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Seconds}");
            Counter counter3 = (Counter)timer1;//115
            Console.WriteLine(counter3.Seconds);
            int x = (int)counter1;
            Counter counter2 = x;

            byte y = (byte)x;//явное преобразование
             
            int z = y; //неявное преобразование

            

            Console.ReadKey();
        }
    }
    class Counter
    {
        public int Seconds { get; set; }
        //операция преобзразования типов
        //неявное преобразование implicit,
        public static implicit operator Counter(int x)
        {
            return new Counter { Seconds=x };
        }
        // явное преобразование explicit 
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h+m+timer.Seconds };
        }
        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds/ 3600;
            int m = (counter.Seconds - h*3600)/60;
            int s = counter.Seconds - h*3600-m*60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }

    }
    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }    
        public int Seconds { get; set; }


    }
}
