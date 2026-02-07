using System;
namespace FraudTransaction;
public class FraudAlert
{
    public string CardNumber { get; set; }
    public string Reason { get; set; }
    public DateTime DetectedAt { get; set; }

    public FraudAlert(string cardNumber, string reason)
    {
        CardNumber = cardNumber;
        Reason = reason;
        DetectedAt = DateTime.Now;
    }
}

