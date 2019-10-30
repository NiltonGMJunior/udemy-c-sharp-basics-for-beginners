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
            var numbers = new List<int>();
            do
            {
                try
                {
                    Console.Write("Input a new number in the list: ");
                    var number = int.Parse(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("The list already contains the number " + number + ". Try again.");
                        continue;
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (numbers.Count < 5);

            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
