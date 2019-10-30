using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //        numbers.Remove(number);
            //}

            for (var i = 0; i < numbers.Count; i++)
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
