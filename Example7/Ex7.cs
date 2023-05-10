//check a alphabet is  a vowel or consonent
using System;

namespace Example7
{
    class Ex7
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("input an alphabet");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if(i >=48 && i<=57)
            {
                Console.WriteLine("you entered a number , please enter alphabet");

            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The alphabet is vowel");
                        break;

                    case 'e':
                        Console.WriteLine("The alphabet is vowel");
                        break;

                    case 'i':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The alphabet is vowel");
                        break;

                    default:

                        Console.WriteLine("the alphabet is not a vowel");
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
