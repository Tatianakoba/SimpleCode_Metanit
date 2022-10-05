using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try... catch... finally

            int[] nums = new int[4];
            try
            {
                Console.WriteLine("Введите строку:");
                string message = Console.ReadLine();
                if (message.Length>6)
                {
                    throw new Exception("Длина строки больше 6 симовлов");
                }
                nums[5] = 10;
                int x = 0;
                int y = 9 / x;
                Console.WriteLine("End of try block");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"General error occured: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            
            Console.ReadKey();
        }
    }
}
