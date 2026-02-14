// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics;
using SmartBankSystem;

public class UserInterface
{
    public static void Main(String[] args)
    {
        try
        {
//    -Customer Name
//    - Age
//    - Employment Type
//    - Monthly Income
//    - Existing Credit Card Dues
//    - Credit Score
//    - Number of Loan Defaults
Console.WriteLine("Enter Customer Name: ");
string CustomerName=Console.ReadLine();

Console.WriteLine("Enter Age: ");
int age=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Employment Type: ");
string emptype=Console.ReadLine();

Console.WriteLine("Enter Monthly Income: ");
double income=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Existisng Credit Card Dues :");
int dues=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Credit Score: ");
int creditscore=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter The Number of Loan Defaults: ");
int defaults=Convert.ToInt32(Console.ReadLine());

CreditRiskProcessor processor=new CreditRiskProcessor(age,emptype,income,dues,creditscore,defaults);
processor.ValidateEmployeeDetails();
double limit=processor.CralculateCreditLimits();
System.Console.WriteLine("Customer Name :"+CustomerName);
System.Console.WriteLine("Credit Limit is: "+limit);




            
            
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}