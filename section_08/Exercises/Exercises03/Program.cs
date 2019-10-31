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
            Console.Write("Input a number in the 24 hour format (HH:mm): ");
            var input = Console.ReadLine();
            try
            {
                var time = TimeSpan.Parse(input);
                Console.WriteLine("Ok");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
