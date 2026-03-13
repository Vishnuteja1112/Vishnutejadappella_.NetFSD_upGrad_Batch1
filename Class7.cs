using System;

namespace Assigment2
{
    internal class Class7
    {
        public static void Main(string[] args)
        {
            double total = 0;

            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter product number: ");
                int p = int.Parse(Console.ReadLine());

                Console.Write("Enter quantity: ");
                int q = int.Parse(Console.ReadLine());

                if (p == 1)
                    total += 22.5 * q;
                else if (p == 2)
                    total += 44.5 * q;
                else if (p == 3)
                    total += 9.98 * q;
            }

            Console.WriteLine("Total price: " + total);
        }
    }
}