using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10));
            //}

            //Console.WriteLine((int)'a');
            //Console.WriteLine((char)97);

            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next((int)'y', (int)'z' + 1));
            //}
            //Console.WriteLine();

            const int password_length = 10;
            var random = new Random();
            var buffer = new char[password_length];
            for (var i = 0; i < password_length; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
