using System;

namespace MiniOrderSystem;

public class Payment

{
    public static void MakePayment(double amount)
    {
        if (amount <= 0)
            throw new PaymentException("Invalid payment amount");

        Console.WriteLine($"Payment of ₹{amount} successful!");
    }
}


