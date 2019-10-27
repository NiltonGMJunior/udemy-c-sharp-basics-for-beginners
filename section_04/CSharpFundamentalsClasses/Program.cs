using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentalsClasses.Math;


namespace CSharpFundamentalsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
