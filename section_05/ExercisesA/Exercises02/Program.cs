using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            var firstInput = Console.ReadLine();
            Console.Write("Input another number: ");
            var secondInput = Console.ReadLine();
            try
            {
                var firstInputNumber = int.Parse(firstInput);
                var secondInputNumber = int.Parse(secondInput);
                Console.WriteLine(firstInputNumber >= secondInputNumber ? firstInputNumber : secondInputNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
