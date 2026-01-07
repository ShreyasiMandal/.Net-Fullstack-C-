using System;
using System.Collections.Generic;

namespace PettyCash
{
    class Program
    {
        static void Main()
        {
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            Console.WriteLine("=== DIGITAL PETTY CASH SYSTEM ===");

            Console.WriteLine("\n--- ADD INCOME ---");
            Console.Write("Enter income amount: ");
            decimal incomeAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Select income source:");
            Console.WriteLine("1. Main Cash");
            Console.WriteLine("2. Bank Transfer");
            Console.WriteLine("3. Office Account");
            Console.Write("Choice: ");
            int sourceChoice = int.Parse(Console.ReadLine());

            string source = sourceChoice switch
            {
                1 => "Main Cash",
                2 => "Bank Transfer",
                3 => "Office Account",
                _ => "Unknown Source"
            };

            incomeLedger.AddEntry(
                new IncomeTransaction(
                    1,
                    DateTime.Now,
                    incomeAmount,
                    "Petty Cash Replenishment",
                    source
                )
            );

            Console.WriteLine("\n--- ADD EXPENSES ---");
            Console.Write("How many expenses do you want to add? ");
            int expenseCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= expenseCount; i++)
            {
                Console.WriteLine($"\nExpense {i}");

                Console.Write("Enter expense amount: ");
                decimal expenseAmount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Select expense category:");
                Console.WriteLine("1. Stationery");
                Console.WriteLine("2. Food");
                Console.WriteLine("3. Travel");
                Console.Write("Choice: ");
                int categoryChoice = int.Parse(Console.ReadLine());

                string category = categoryChoice switch
                {
                    1 => "Stationery",
                    2 => "Food",
                    3 => "Travel",
                    _ => "Other"
                };

                Console.Write("Enter expense description: ");
                string description = Console.ReadLine();

                expenseLedger.AddEntry(
                    new ExpenseTransaction(
                        i + 1,
                        DateTime.Now,
                        expenseAmount,
                        description,
                        category
                    )
                );
            }

            decimal totalIncome = incomeLedger.CalculateTotal();
            decimal totalExpense = expenseLedger.CalculateTotal();
            decimal netBalance = totalIncome - totalExpense;

            Console.WriteLine("\n=== SUMMARY ===");
            Console.WriteLine($"Total Income   : {totalIncome}");
            Console.WriteLine($"Total Expense  : {totalExpense}");
            Console.WriteLine($"Net Balance    : {netBalance}");

            Console.WriteLine("\n=== ALL TRANSACTIONS ===");
            List<Transaction> allTransactions = new List<Transaction>();
            allTransactions.AddRange(incomeLedger.GetAllEntries());
            allTransactions.AddRange(expenseLedger.GetAllEntries());

            foreach (Transaction t in allTransactions)
            {
                Console.WriteLine(t.GetSummary());
            }
        }
    }
}
