using System;

namespace Assigment2
{
    internal class Class14
    {
        public static void Main(string[] args)
        {
            int min = int.MaxValue;

            Console.WriteLine("Enter five numbers:");

            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                    min = num;
            }

            Console.WriteLine("Smallest number: " + min);
        }
    }
}