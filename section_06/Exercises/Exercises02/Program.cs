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
            Console.Write("Enter your name: ");
            try
            {
                var name = Console.ReadLine();
                var charArray = name.ToCharArray();
                Array.Reverse(charArray);
                var reversedName = new string(charArray);
                Console.WriteLine("Reversed name: " + reversedName);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
