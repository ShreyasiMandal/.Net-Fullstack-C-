// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Method 1
//Swapping Using Reference
using System;
class Solution
{
    static void SwappingRef(ref int a,ref int b)
    {
        (a,b)=(b,a);  //tuple deconstruction with ref
    }

    static void Main()
    {
        System.Console.WriteLine("Enter First Number: ");
        int num1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Second Number: ");
        int num2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("\nBefore Swap: ");
        System.Console.WriteLine("num1= "+num1+", num2 ="+ num2);

        SwappingRef(ref num1,ref num2);
        System.Console.WriteLine("\nAfter Swap: ");
        System.Console.WriteLine("num1= "+num1+", num2 ="+ num2);




    }
}
