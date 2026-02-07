using System.Collections.Generic;

namespace MiniOrderSystem;
public class Customer
{
    public int Id { get; }
    public string Name { get; }
    public List<OrderItem> Cart { get; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
        Cart = new List<OrderItem>();
    }

    public void AddToCart(Product product, int quantity)
    {
        if (quantity <= 0)
            throw new InvalidOrderException("Quantity must be greater than zero");

        Cart.Add(new OrderItem(product, quantity));
    }
}
