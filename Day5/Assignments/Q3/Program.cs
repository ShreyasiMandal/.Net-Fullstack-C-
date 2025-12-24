// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Problem 3:
John's father recently launched Candy Craze, a new candy shop, 
and wants to entice more customers by offering discounts on specific flavors. 
To achieve this, 
he's enlisted John's help in developing an application 
that can easily calculate the discounted price of the candy. 
John is currently working on building this application.
 Help him to create an application using your C# coding skills.
Functionalities:
In class Candy, implement the below-given properties and method.
    Data Type
   Property Name
    string
  Flavour
    int
  Quantity
    int
  PricePerPiece
    double
  TotalPrice
    double
  Discount
    Method
   Description
   public bool ValidateCandyFlavour()
 This method is used to validate the candy flavour.
If the flavour is Strawberry or Lemon or Mint, then return true. Otherwise, return false.
In class Program, implement the below-given method.
    Method
   Description
   public Candy CalculateDiscountedPrice(Candy candy)
 This method is used to calculate the discounted price and return the Candy object.
The discount calculation procedure is given below.
Formula : Total Price = Quantity * PricePerPiece
 Discount = Total Price - (Total Price * Discount Percentage/100)
    Flavour
   Discount Percentage
    Strawberry
  15
    Lemon
  10
    Mint
  5
Note:
Flavour is Case-sensitive.
In Program class - Main method,
1.    Get the values from the user as per the Sample Input.
2.   Call the ValidateCandyFlavour method. If this method returns true, then move on to step 3. Otherwise, display Invalid flavour.
3.    Call the CalculateDiscountedPrice method and display the result as per the Sample Output.
Note:
Keep the properties, methods and classes as public.
Please read the method rules clearly.
Do not use Environment.Exit() to terminate the program.
Do not change the given code template.
Summary :
Through creating this application, he has learned about class and objects in C#.
Classes in C# define blueprints or templates for creating objects that encapsulate data and behavior.
Objects are instances of a class that have specific values for their properties and can perform actions through their methods.
Sample Input 1:
Enter the flavour
Strawberry
Enter the quantity
10
Enter the price per piece
5
Sample Output 1:
Flavour : Strawberry
Quantity : 10
Price Per Piece : 5
Total Price : 50
Discount Price : 42.5
Sample Input 2:
Enter the flavour
Chocolate
Enter the quantity
50
Enter the price per piece
3
Sample Output 2:
Invalid flavour*/
using System;
namespace Q3Practice;
class Program
{

    public static void Main()

    {
        // Create an object of Candy class
        // This object will store flavour, quantity, price, total, discount

        Candy candy=new Candy();

        // Create an object of Program class
        // Needed because CalculateDiscountedPrice() is NON-static
        Program p=new Program();


        System.Console.WriteLine("Enter the Flavour: ");
        candy.Flavour=Console.ReadLine();

        System.Console.WriteLine("Enter the Quantity");
        candy.Quantity=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the PriceperPiece");
        candy.PricePerPiece=int.Parse(Console.ReadLine());

       // Call ValidateCandyFlavour() using candy object
        // This checks whether flavour is Strawberry, Lemon, or Mint
        if (candy.ValidateCandyFlavour())
        {
            candy=p.CalculateDiscountedPrice(candy);
            System.Console.WriteLine("The Falvour is : "+candy.Flavour);
            System.Console.WriteLine("The Quantity is :"+candy.Quantity);
            System.Console.WriteLine("The PricePerPiece is : "+candy.PricePerPiece);
            System.Console.WriteLine("The TotalPrice is : "+candy.TotalPrice);
            System.Console.WriteLine("The Discount is : "+candy.Discount);
        }
        else
        {
            System.Console.WriteLine("Invalid Flavour");
        }
    }

    // Method to calculate total price and discounted price
    // Accepts a Candy object and returns updated Candy object
        public Candy CalculateDiscountedPrice(Candy candy)
    {
        double Price=0;
//    Formula : Total Price = Quantity * PricePerPiece
//  Discount = 
//Total Price - (Total Price * Discount Percentage/100)
//     Flavour
//    Discount Percentage
//     Strawberry
//   15
//     Lemon
//   10
//     Mint
//   5


candy.TotalPrice=candy.Quantity *candy.PricePerPiece;
        if (candy.Flavour == "Strawberry")
        {
            candy.Discount=candy.TotalPrice-(candy.TotalPrice*15/100);
        }else if(candy.Flavour == "Lemon")
        {
           candy.Discount=candy.TotalPrice-(candy.TotalPrice*10/100);
        }
        else if(candy.Flavour=="Mint")
        {
            candy.Discount=candy.TotalPrice-(candy.TotalPrice*5/100);
        }
        // Return updated Candy object
        return candy;     
    }
        
    }



