using System;

namespace Assigment2
{
    internal class Class15
    {
        public static void Main(string[] args)
        {
            int[] marks = new int[10];
            int total = 0;

            Console.WriteLine("Enter 10 marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            int min = marks[0];
            int max = marks[0];

            for (int i = 1; i < 10; i++)
            {
                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + total / 10);
            Console.WriteLine("Minimum marks: " + min);
            Console.WriteLine("Maximum marks: " + max);

            Array.Sort(marks);

            Console.WriteLine("Ascending order:");
            foreach (int m in marks)
                Console.Write(m + " ");

            Console.WriteLine();

            Console.WriteLine("Descending order:");
            for (int i = 9; i >= 0; i--)
                Console.Write(marks[i] + " ");
        }
    }
}