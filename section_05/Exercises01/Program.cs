﻿using System;
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
            int count = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    count++;
            Console.WriteLine(count);
        }
    }
}
