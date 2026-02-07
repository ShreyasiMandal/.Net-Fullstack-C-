using System;
using System.Collections.Generic;
namespace MiniOrderSystem;

public class Order
{
    private static int invoiceCounter = 1000;

    public int InvoiceNumber { get; }
    public List<OrderItem> Items { get; }
    public double TotalAmount { get; private set; }

    public Order(List<OrderItem> items)
    {
        Items = items;
        InvoiceNumber = ++invoiceCounter;
    }

    public void PlaceOrder(Coupon coupon = null)
    {
        // Validate & deduct stock 
        foreach (var item in Items)
        {
            item.Product.ReduceStock(item.Quantity);
            TotalAmount += item.GetTotal();
        }

        if (coupon != null)
            TotalAmount = coupon.Apply(TotalAmount);
    }
}