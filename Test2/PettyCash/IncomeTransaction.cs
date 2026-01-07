using System;

namespace PettyCash;

public class IncomeTransaction:Transaction
{
    public string Source { get; set; }
    public IncomeTransaction(int id,DateTime date,decimal amount,string description,string source)
    :base(id,date,amount,description)
    {
        Source=source;
    }
    public override string GetSummary()
    {
        return $"[EXPENSE] {Date.ToShortDateString()} | Source :{Source} | ${Amount} | {Description}";
    }


}
