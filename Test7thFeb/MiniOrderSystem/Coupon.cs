using System;

namespace MiniOrderSystem;

public class Coupon
{
    public string Code { get; }
    public double DiscountPercentage { get; }

    public Coupon(string code, double discountPercentage)
    {
        Code = code;
        DiscountPercentage = discountPercentage;
    }

    public double Apply(double total)
    {
        if (total < 500)
            throw new InvalidCouponException("Coupon applicable only for orders above ₹500");

        return total - (total * DiscountPercentage / 100);
    }
}
