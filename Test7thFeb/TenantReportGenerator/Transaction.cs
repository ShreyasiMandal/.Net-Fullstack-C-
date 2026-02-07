using System;
namespace MultiTenantReportGenerator;
public class Transaction
{
    public string TenantId { get; set; }
    public string Type { get; set; }   // Credit or Debit
    public double Amount { get; set; }
    public DateTime Timestamp { get; set; }

    public Transaction(string tenantId, string type, double amount, DateTime timestamp)
    {
        TenantId = tenantId;
        Type = type;
        Amount = amount;
        Timestamp = timestamp;
    }
}
