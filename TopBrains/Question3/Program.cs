// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class Solution{
public static int[] GetMultiplicationRows(int n,int upto)
{
    int[] result=new int[upto];
    for(int i=1; i <= upto; i++)
        {
            result[i-1]=n*i;
            
        }

return result;  

}
static void Main()
{
      Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter upto: ");
        int upto = int.Parse(Console.ReadLine());

        int[] table = GetMultiplicationRows(n, upto);

        Console.WriteLine("Multiplication Table Row:");
        Console.WriteLine(string.Join(", ", table));
}

}