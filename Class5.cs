using System;

namespace Assigment2
{
    internal class Class5
    {
        public static void Main(string[] args)
        {
            int odd = 0, even = 0;

            Console.Write("Enter count of numbers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Even count: " + even);
            Console.WriteLine("Odd count: " + odd);
        }
    }
}