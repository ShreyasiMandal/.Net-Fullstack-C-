// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace QuickMart;
class Program
    {
        static void Main()
        {
            int option;

            do
            {
                Console.WriteLine("\n================== QuickMart Traders ==================");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        TransactionManager.CreateNewTransaction();
                        break;

                    case 2:
                        TransactionManager.ViewLastTransaction();
                        break;

                    case 3:
                        TransactionManager.RecalculateProfitLoss();
                        break;

                    case 4:
                        Console.WriteLine("Thank you. Application closed normally.");
                        break;

                    default:
                        Console.WriteLine("Invalid menu option. Please try again.");
                        break;
                }

            } while (option != 4);
        }
    }

