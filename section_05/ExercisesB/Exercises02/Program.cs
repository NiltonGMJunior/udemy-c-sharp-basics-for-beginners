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
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number to continue or 'ok' to exit: ");
                var input = Console.ReadLine();

                try
                {
                    if (input != "ok")
                        sum += int.Parse(input);
                    else
                        break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
