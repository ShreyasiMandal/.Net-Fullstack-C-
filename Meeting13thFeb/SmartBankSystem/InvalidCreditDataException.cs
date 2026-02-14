using System;

namespace SmartBankSystem;

public class InvalidCreditDataException : Exception
{
    public InvalidCreditDataException(string message) : base(message)
    {
        
    }
}
