using System;

namespace Assigment2
{
    internal class Class18
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string w1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string w2 = Console.ReadLine();

            if (w1 == w2)
                Console.WriteLine("Both words are same");
            else
                Console.WriteLine("Words are different");
        }
    }
}