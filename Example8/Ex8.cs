//cSharp to display a right angle triangle with an asterisk.
using System;

namespace Example8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle using asterisk:\n");
            
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
