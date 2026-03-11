using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIG1
{
    internal class Class7
    {
        public void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            char ch = str[2];s

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The third character is a vowel");
            }
            else
            {
                Console.WriteLine("The third character is a consonant");
            }
        }
    }
}
