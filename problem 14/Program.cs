﻿using ritangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wrytangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Words words = new Words();
            Console.WriteLine(words.Compute());
        }
    }
}
