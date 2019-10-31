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
            Console.Write("Enter words separated by spaces: ");
            var input = Console.ReadLine();
            try
            {
                var words = input.Split(' ');
                var builder = new StringBuilder();
                foreach (var word in words)
                {
                    builder.Append(word.First().ToString().ToUpper() + word.Substring(1).ToLower());
                }
                var output = builder.ToString();
                Console.WriteLine(output);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
