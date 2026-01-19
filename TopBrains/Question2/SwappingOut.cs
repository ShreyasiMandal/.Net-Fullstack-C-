using System;

namespace Swapping;
//Swapping Using Out

public class SwappingOut
{
    static void SwappingUsingOut(int a,int b,out int x,out int y)
    {
        a=a+b;
        b=a-b;
        a=a-b;

        x=a;
        y=b;
    }

    public static void Main()
    {
         Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBefore Swap:");
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");

            int x, y;
            SwappingUsingOut(num1, num2, out x, out y);

            Console.WriteLine("\nAfter Swap:");
            Console.WriteLine($"num1 = {x}, num2 = {y}");
    }
}
