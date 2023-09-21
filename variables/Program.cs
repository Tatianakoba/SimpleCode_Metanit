using System;


namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int c = 5;
            double b = 3.4;
            string s = "hello   ";
            float f = 3.5f;
            decimal d = 1.2M;
            bool x = true;
            
            
            
            
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(x);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine(a.CompareTo(c));
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(a.ToString());

            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(f.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(s.ToUpper()) ;
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Normalize());
            Console.WriteLine(s.Replace("h","c"));
            Console.WriteLine(s.Contains("l"));
            Console.WriteLine(s.Remove(2,1));
            Console.WriteLine(s.Trim());


            Console.ReadLine();
            Console.Clear();
            int result;
            if (int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ты не прав!");
            }
            Console.ReadLine();
        }
    }
}
