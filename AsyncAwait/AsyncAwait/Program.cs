﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceDemo.Starter();
            ServiceDemo.DoLongAsync();

            Console.ReadLine();
        }
    }
}
