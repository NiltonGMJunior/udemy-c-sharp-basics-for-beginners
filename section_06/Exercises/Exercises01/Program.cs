using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string currentName;
            do
            {
                Console.Write("Enter a name to continue, or press leave blank to finish: ");
                currentName = Console.ReadLine();
                if (!String.IsNullOrEmpty(currentName))
                    names.Add(currentName);
            } while (!String.IsNullOrEmpty(currentName));

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(String.Format("{0} likes your post.", names[0]));
                    break;
                case 2:
                    Console.WriteLine(String.Format("{0} and {1} like your post.", names[0], names[1]));
                    break;
                default:
                    Console.WriteLine(String.Format("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2));
                    break;
            }
        }
    }
}
