using System;
using System.Collections.Generic;
namespace MultiTenantReportGenerator;
class Program
{
    static void Main()
    {
        List<Transaction> transactions = new List<Transaction>();

        Console.WriteLine("===== MULTI-TENANT REPORT SYSTEM =====");

        Console.Write("Enter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nTransaction {i}");

            Console.Write("Enter Tenant Id: ");
            string tenantId = Console.ReadLine();

            Console.Write("Enter Type (Credit/Debit): ");
            string type = Console.ReadLine();

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter Timestamp (yyyy-MM-dd HH:mm): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            transactions.Add(new Transaction(tenantId, type, amount, time));
        }

        var reports = ReportGenerator.GenerateReports(transactions);

        Console.WriteLine("\n===== TENANT REPORTS =====");
        foreach (var report in reports)
        {
            Console.WriteLine($"Tenant Id        : {report.TenantId}");
            Console.WriteLine($"Total Credits    : {report.TotalCredits}");
            Console.WriteLine($"Total Debits     : {report.TotalDebits}");
            Console.WriteLine($"Peak Hour        : {report.PeakTransactionHour}");
            Console.WriteLine($"Suspicious       : {report.IsSuspicious}");
            Console.WriteLine("----------------------------------");
        }
    }
}
