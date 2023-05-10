// swapping 2 numbers
using System;
public class Example3
{
    public static void Main (string[] args)
    {
        int num1, num2, temp;
        Console.WriteLine("enter first num1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter num2");
        num2 = int.Parse(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.Write("after swapping");
        Console.Write("\n first number" + num1);
        Console.Write("\nsecond number" + num2);
        Console.Read();

    }
}