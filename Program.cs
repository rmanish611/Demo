using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static double FindX(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }

            if (a < 0)
            {
                throw new ArgumentException("Input 'a' must be non-negative.");
            }

            double x = Math.Sqrt((3 * a) + 1) / b;
            return x;
        }

        static void Main(string[] args)
        {
            try
            {
                double result = Program.FindX(9.0, 3.0);
                Console.WriteLine("Result: " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
