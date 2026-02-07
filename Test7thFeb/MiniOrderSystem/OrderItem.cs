using System;

namespace MiniOrderSystem;

public class OrderItem
{
     public Product Product { get; }
    public int Quantity { get; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public double GetTotal()
    {
        return Product.Price * Quantity;
    }

}
