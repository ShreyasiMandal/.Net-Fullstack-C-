using System;

namespace MiniOrderSystem;

public class InsufficientStockException : Exception
{
    public InsufficientStockException(string message) : base(message) { }
}

public class InvalidOrderException : Exception
{
    public InvalidOrderException(string message) : base(message) { }
}

public class InvalidCouponException : Exception
{
    public InvalidCouponException(string message) : base(message) { }
}

public class PaymentException : Exception
{
    public PaymentException(string message) : base(message) { }
}
