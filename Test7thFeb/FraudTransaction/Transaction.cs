using System;

namespace FraudTransaction;

public class Transaction
{
    public string CardNumber { get; set; }
    public double Amount { get; set; }
    public string City { get; set; }
    public DateTime Time { get; set; }

    public Transaction(string cardNumber, double amount, string city, DateTime time)
    {
        CardNumber = cardNumber;
        Amount = amount;
        City = city;
        Time = time;
    }
}


