using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter your Name: ");
//         string? name = Console.ReadLine();
//         Console.WriteLine("Hello, " + name + "!");
//     }
// }
//Print Prime Number 
// Console.Write("Enter a no: ");
// int n=int.Parse(Console.ReadLine());
// if (n <= 1)
// {
//     Console.WriteLine("Not a Prime number ");
//     return;
// }
// bool isPrime =true;
// for(int i = 2; i * i <= n; i++)
// {
//     if (n % i == 0)
//     {
//         isPrime=false;
//         break;
//     }
// }
// if (isPrime)
// {
//     Console.WriteLine("Prime no");
// }
// else
// {
//     Console.WriteLine("Not a prime no");
// }
//TryParse
class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        String? input=Console.ReadLine();
        if(int.TryParse(input,out int age))
        {
            bool isAdult = age >=18;
            Console.WriteLine("Adult? "+isAdult);


    }
        else
        {
            Console.WriteLine("Invalid! please enter a valid age no");
        }


    }
}
