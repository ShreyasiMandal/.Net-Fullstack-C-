using System;
using System.Collections.Generic;
namespace FraudTransaction;
class Program
{
    static void Main()
    {
        List<Transaction> transactions = new List<Transaction>();

        Console.WriteLine("===== FRAUD DETECTION SYSTEM =====");

        Console.Write("Enter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nTransaction {i}");

            Console.Write("Enter Card Number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter transaction time (yyyy-MM-dd HH:mm): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            transactions.Add(new Transaction(cardNumber, amount, city, time));
        }

        // Detect fraud
        List<FraudAlert> alerts = FraudDetector.DetectFraud(transactions);

        // Output
        Console.WriteLine("\n===== FRAUD ALERTS =====");

        if (alerts.Count == 0)
        {
            Console.WriteLine("No fraud detected.");
        }
        else
        {
            foreach (var alert in alerts)
            {
                Console.WriteLine($"Card Number : {alert.CardNumber}");
                Console.WriteLine($"Reason      : {alert.Reason}");
                Console.WriteLine($"Detected At : {alert.DetectedAt}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
