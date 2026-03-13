using System;

namespace Assigment2
{
    internal class Class13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            Console.WriteLine("Largest number: " + max);
        }
    }
}