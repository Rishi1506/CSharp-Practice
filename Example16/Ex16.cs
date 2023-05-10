//adding 2 numbers using functions

using System;
public class funcexer3
{
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    public static void Main()
    {

        Console.Write("Enter number 1");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number2 ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
    }
}
