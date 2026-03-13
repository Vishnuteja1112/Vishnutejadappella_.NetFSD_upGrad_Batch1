using System;

namespace Assigment2
{
    internal class Class19
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            string rev = new string(arr);

            if (word == rev)
                Console.WriteLine("It is a Palindrome");
            else
                Console.WriteLine("It is not a Palindrome");
        }
    }
}