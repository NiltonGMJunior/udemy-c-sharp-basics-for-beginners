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
            try
            {
                Console.Write("Input the speed limit: ");
                var speedLimit = int.Parse(Console.ReadLine());

                Console.Write("Input the speed: ");
                var speed = int.Parse(Console.ReadLine());
                int points = speed > speedLimit ? (speed - speedLimit) / 5 : 0;
                if (points == 0)
                {
                    Console.WriteLine("Ok");
                } else if (points <= 12)
                {
                    Console.WriteLine(string.Format("{} demerit points", points));
                } else
                {
                    Console.WriteLine("License Suspended");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
