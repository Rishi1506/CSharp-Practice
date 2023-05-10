// check number as even or odd
using System;

namespace Example5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            int num, rem;
            Console.WriteLine("input an number");
            num = Convert.ToInt32(Console.ReadLine());

            rem = num % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an even number" + num);
            else
                Console.WriteLine("{0} is an odd number" + num);
        }
    }
}
