//multiplication table
using System;

namespace Example4
{
   public class Ex4
    {
        static void Main(string[] args)
        {
            int x;
            int result;
            Console.WriteLine("enter a number;");
            x = Convert.ToInt32(Console.ReadLine());

            result = x * 1;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *2;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *3;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *4;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *5;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *6;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *7;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *8;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x *9;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
            result = x * 10;
            Console.WriteLine("the table is : {0} x {1} = {2}", x, 1, result);
        }
    }
}
