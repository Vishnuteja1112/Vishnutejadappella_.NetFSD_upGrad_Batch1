using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment2
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                int num1 = int.Parse(args[0]);
                int num2 = int.Parse(args[1]);

                for (int i = num1 + 1; i < num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Please enter two numbers as command line arguments.");
            }
        }
    }
}