using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            try
            {
                var input = Console.ReadLine();
                var number = int.Parse(input);
                var factorial = 1;
                for (var i = 1; i <= number; i++)
                    factorial *= i;
                Console.WriteLine(factorial);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                throw;
            }
        }
    }
}
