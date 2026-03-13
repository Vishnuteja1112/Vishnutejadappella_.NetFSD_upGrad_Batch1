using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment2
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hi! " + args[0]);
                Console.WriteLine("Welcome to the world of C#");
            }
            else
            {
                Console.WriteLine("Please enter a name as command line argument.");
            }
        }
    }
}