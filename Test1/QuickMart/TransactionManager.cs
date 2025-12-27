using System;

namespace QuickMart;

public class TransactionManager
{
  //Static Storage
  public static SaleTransaction LastTransaction;
  public static bool HasLastTransaction = false;

  //Create Register
  public static void CreateNewTransaction()
    {
        SaleTransaction st = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        st.InvoiceNo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(st.InvoiceNo))
        {
        Console.WriteLine("Invoice No cannot be empty.");
        return;
        }

        Console.Write("Enter Customer Name: ");
        st.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        st.ItemName = Console.ReadLine();

        System.Console.WriteLine("Enter Quantity: ");
        st.Quantity=int.Parse(Console.ReadLine());
        if (st.Quantity < 0)
        {
            System.Console.WriteLine("Quantity must be Greater than Zero!");
            return;
        }
        System.Console.WriteLine("Enter Purchase Amount (total): ");
        st.PurchaseAmount=decimal.Parse(Console.ReadLine());
        if (st.PurchaseAmount < 0)
        {
            System.Console.WriteLine("Purchase Amount must be greater than Zero!");
            return;
        }

        System.Console.WriteLine("Enter Selling Amount (total): ");
        st.SellingAmount=decimal.Parse(Console.ReadLine());
        if (st.SellingAmount< 0)
        {
            System.Console.WriteLine("Selling Amount must be greater than Zero!");
            return;
        }
        //Profit Loss calculation
        Calculate(st);

        // Store statically
        LastTransaction = st;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        Console.WriteLine("Status: " + st.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + st.ProfitOrLossAmount.ToString("F2"));
        Console.WriteLine("Profit Margin (%): " + st.ProfitMarginPercent.ToString("F2"));
        Console.WriteLine("------------------------------------------------------");
    }

     //View Last Transaction
     public static void ViewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("\n-------------- Last Transaction --------------");
            Console.WriteLine("InvoiceNo: " + LastTransaction.InvoiceNo);
            Console.WriteLine("Customer: " + LastTransaction.CustomerName);
            Console.WriteLine("Item: " + LastTransaction.ItemName);
            Console.WriteLine("Quantity: " + LastTransaction.Quantity);
            Console.WriteLine("Purchase Amount: " + LastTransaction.PurchaseAmount.ToString("F2"));
            Console.WriteLine("Selling Amount: " + LastTransaction.SellingAmount.ToString("F2"));
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent.ToString("F2"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void RecalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Calculate(LastTransaction);

            Console.WriteLine("\nRecalculated Profit/Loss:");
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent.ToString("F2"));
            Console.WriteLine("------------------------------------------------------");
        }
         private static void Calculate(SaleTransaction st)
        {
            if (st.SellingAmount > st.PurchaseAmount)
            {
                st.ProfitOrLossStatus = "PROFIT";
                st.ProfitOrLossAmount = st.SellingAmount - st.PurchaseAmount;
            }
            else if (st.SellingAmount < st.PurchaseAmount)
            {
                st.ProfitOrLossStatus = "LOSS";
                st.ProfitOrLossAmount = st.PurchaseAmount - st.SellingAmount;
            }
            else
            {
                st.ProfitOrLossStatus = "BREAK-EVEN";
                st.ProfitOrLossAmount = 0;
            }

            st.ProfitMarginPercent =
                (st.ProfitOrLossAmount / st.PurchaseAmount) * 100;
        }
        
    }

