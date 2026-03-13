using System;

namespace Assigment2
{
    internal class Class10
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            while (a <= 40)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}