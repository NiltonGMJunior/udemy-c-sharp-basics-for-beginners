using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises04
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.Write("Input a number: ");
            var input = Console.ReadLine();
            try
            {
                if (int.Parse(input) == randomNumber)
                    Console.WriteLine("You won");
                else
                    Console.WriteLine("You lost");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid unput!");
                throw;
            }
            Console.WriteLine("The correct number was " + randomNumber);
        }
    }
}
