using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = DateTime.Today.Hour;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("It's afternoon");
            //else
            //    Console.WriteLine("It's evening");

            //bool isGoldCustomer = true;

            ////float price;
            ////if (isGoldCustomer)
            ////    price = 19.95f;
            ////else
            ////    price = 29.95f;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("It's autum and a beautiful season.");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("It's perfect to go to the beach");
            //        break;
            //    default:
            //        Console.WriteLine("I don't understad that season!");
            //        break;
            //}

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion.");
                    break;
                default:
                    Console.WriteLine("I don't understad that season!");
                    break;
            }
        }
    }
}
