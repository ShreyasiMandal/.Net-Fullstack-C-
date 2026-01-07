using System;

namespace PettyCash;

public class ExpenseTransaction:Transaction
{
    public string Category { get; set; }
    public ExpenseTransaction(int id,DateTime date,decimal amount,string description,string category)
    :base(id,date,amount,description)
    {
        Category=category;
    }
    public override string GetSummary()
    {
        return $"[EXPENSE] {Date.ToShortDateString()} |Category: {Category} | ${Amount} | {Description}";
    }

}
