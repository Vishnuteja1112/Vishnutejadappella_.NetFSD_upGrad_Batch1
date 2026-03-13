using System;

namespace Assigment2
{
    internal class Class9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial: " + fact);
        }
    }
}