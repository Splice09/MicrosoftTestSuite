﻿// arguments: A B C D
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.HelloWorld
{
    /* Test class for: console writing, command line argument reading, and basic loop implementation. */
    class HelloClass
    {
        //Constructor
        public HelloClass()
        {
        }
        public void toString(String[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
       
    }
}
