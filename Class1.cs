using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIG1
{
    internal class code2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the distances in km");
            int km=int.Parse(Console.ReadLine());
            int m = km * 1000;
            Console.WriteLine($"Distances in meters is {m}");
        }
    }
}
