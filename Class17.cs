using System;

namespace Assigment2
{
    internal class Class17
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            string rev = new string(arr);

            Console.WriteLine("Reversed word: " + rev);
        }
    }
}