using System;
using MiniOrderSystem;

class Program
{
    static void Main()
    {
        try
        {
            // Products
            Product laptop = new Product(1, "Laptop", 60000, 5);
            Product mouse = new Product(2, "Mouse", 500, 10);
            Product keyboard = new Product(3, "Keyboard", 1200, 8);
            Product headphones = new Product(4, "Headphones", 2500, 6);

            Console.WriteLine("===== MINI ORDER SYSTEM =====");

            Console.Write("Enter Customer Id: ");
            int custId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string custName = Console.ReadLine();

            Customer customer = new Customer(custId, custName);

            // Add to cart
            while (true)
            {
                Console.WriteLine("\nAvailable Products:");
                Console.WriteLine("1. Laptop - ₹60000");
                Console.WriteLine("2. Mouse - ₹500");
                Console.WriteLine("3. Keyboard - ₹1200");
                Console.WriteLine("4. Headphones - ₹2500");

                Console.Write("Choose product (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                Product selectedProduct = choice switch
                {
                    1 => laptop,
                    2 => mouse,
                    3 => keyboard,
                    4 => headphones,
                    _ => throw new Exception("Invalid product choice")
                };

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                customer.AddToCart(selectedProduct, quantity);

                Console.Write("Add more items? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            // Coupon
            Console.WriteLine("\nAvailable Coupons:");
            Console.WriteLine("SAVE10     - 10% off (Min ₹500)");
            Console.WriteLine("STUDENT15  - 15% off");

            Console.Write("Enter coupon code (or press Enter to skip): ");
            string code = Console.ReadLine();

            Coupon coupon = null;

            if (!string.IsNullOrEmpty(code))
            {
                coupon = code.ToUpper() switch
                {
                    "SAVE10" => new Coupon(code, 10),
                    "STUDENT15" => new Coupon(code, 15),
                    _ => throw new Exception("Invalid coupon code")
                };
            }

            // Place order
            Order order = new Order(customer.Cart);
            order.PlaceOrder(coupon);

            // Payment
            Payment.MakePayment(order.TotalAmount);

            // Invoice
            Console.WriteLine("\n===== INVOICE =====");
            Console.WriteLine($"Customer Name : {customer.Name}");
            Console.WriteLine($"Invoice No    : {order.InvoiceNumber}");
            Console.WriteLine($"Total Payble:{order.PlaceOrder}");
            Console.WriteLine("Order Created Successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nERROR: " + ex.Message);
        }
    }
}
