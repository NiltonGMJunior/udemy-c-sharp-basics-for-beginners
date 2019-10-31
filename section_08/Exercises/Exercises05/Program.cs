using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            var input = Console.ReadLine();
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;
            try
            {
                foreach (var character in input)
                {
                    if (vowels.Contains(character))
                        vowelsCount++;
                }
                Console.WriteLine(vowelsCount);
            }
            catch (Exception)
            {

            }
        }
    }
}
