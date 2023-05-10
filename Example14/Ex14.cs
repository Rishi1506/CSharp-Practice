//Check whether a character is upper OR Lower case
using System;

namespace Example14
{
    class Ex14
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input a character: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.\n");
                }
                else
                {
                    Console.WriteLine("\nThe character is lowercase.\n");
                }
            }
            else
            {
                Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
            }
        }
    }
}
