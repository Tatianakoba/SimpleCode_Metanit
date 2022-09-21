using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //по значению
        static int Sum(int x, int y)
        {
            return x + y;


        }
        //По ссылке
        static void AdditionVal(int x, int y)
        {
             x += y;
            Console.WriteLine($"Addition Val x = {x}");

        }
        static void AdditionRef(ref int x, int y)
        {
            x += y;
            Console.WriteLine($"Addition Ref x = {x}");

        }
        //OUT
        static void GetData(int width, int height, out int perimeter, out int area)
        {
            perimeter = (width+height)*2;
            area = width * height;

        }
        //Необязательные параметры
        static int Optional(int x, int y, int z=5, int s=7)
        {
            return x+y+z+s;
        }
        static void Main(string[] args)
        {
            int d1 = Optional(s: 1, y: 2, z: 3,x: 4); ;
            int d2 = Optional(1,2,3);
            int d3 = Optional(1, 2);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            //    int perimeter;
            //    int area;
            //    GetData(10, 15, out perimeter, out area);
            //    Console.WriteLine($"Area {area}");
            //    Console.WriteLine($"Perimeter {perimeter}");
            //Console.WriteLine("Введите два целых числа");
            //var DAta_x_y =Console.ReadLine().Split(' ');
            //int x = int.Parse(DAta_x_y[0]);
            //int y = int.Parse(DAta_x_y[1]);
            //int z = Sum(x, y);
            //int a = 5;
            //int b = 6;
            //Console.WriteLine($"Initial Value a = {a}");
            //AdditionVal(a,b);
            //Console.WriteLine($"After Addition Val a = {a}");
            //AdditionRef(ref a, b);
            //Console.WriteLine($"After Addition Ref a = {a}");
            ////Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
