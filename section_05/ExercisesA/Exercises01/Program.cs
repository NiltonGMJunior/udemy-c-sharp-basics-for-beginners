using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number between 1 and 10: ");
            var input = Console.ReadLine();
            try
            {
                var intInput = int.Parse(input);
                if (intInput >= 1 && intInput <= 10)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
