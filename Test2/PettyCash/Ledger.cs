using System;

namespace PettyCash;

public class Ledger<T> where T:Transaction
{
    private List<T> entries = new List<T>();
    //Add the Entries
    public void AddEntry(T entry)
    {
        entries.Add(entry);
    }
    //Get the Transaction Data By Date
    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result=new List<T>();
        foreach (T entry in entries)
    {
        if (entry.Date.Date ==date.Date)
        {
            result.Add(entry);
        }
    }

    return result;
    }
    //Calculating the total
    public decimal CalculateTotal()
    {
       decimal total=0;
       foreach(T entry in entries)
        {
            total+=entry.Amount;
        }
        return total;

    }
    public List<T> GetAllEntries()
        {
            return entries;
        }

   
}
