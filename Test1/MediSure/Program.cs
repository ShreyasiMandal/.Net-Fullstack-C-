// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Runtime.InteropServices;
namespace Healthcare;

class Program
{
    static void Main()
    {
        int option;
        do
        {
            System.Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            System.Console.WriteLine("Enter Your Option: ");
            if (!int.TryParse(Console.ReadLine(), out option))
                {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
                }

            switch (option)
            {
                case 1 :
                Billing.CreateNewBill();
                break;

                case 2 :
                Billing.ViewLastBill();
                break;

                case 3 :
                Billing.ClearLastBill();
                break;

                case 4:
                System.Console.WriteLine("Thank You. Application Closed normally");
                break;

                default:
                System.Console.WriteLine("Invalid Menu Option! Please Try again ");
                break;
            }

        }while(option !=4);
    }
}


