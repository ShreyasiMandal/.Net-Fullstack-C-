// See https://aka.ms/new-console-template for more information
using System;
namespace CustomPropertyDemo;
struct Customer1
    // struct is value type in cSharp => no memory allocation on heap
{
    int id;
    string name;

    // In structures, default constructors don't exist
    // The purpose of constructors in structures is to assign data to members
    // Structures don't have destructors because Structures are value type
    public Customer1(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    //public int ID { get; set; } 
    //public string Name { get; set; }
}

// If you don't want to implement inheritance => go for structure
// no inheritance, abstraction, methods => structures because they are lightweight
class Program
{
    public static void Main()
    {


        // Init customer object first
        //Customer custObj = null;

        // custObj.CustID = 101;
        //System.NullReferenceException: Object reference not set to an instance of an object.
        // Because we initialised custObj with null

        Customer1 cust1;

        Customer custObj = new Customer();
        custObj.Name = "Alok";

        // Init the Shipping Address
        custObj.ShippingAddress = new Address(); // you have to init every single class
        custObj.ShippingAddress.FlatNo = 1802;
        custObj.ShippingAddress.BuildingName = "Twin Towers";
        custObj.ShippingAddress.Street = "Lane 1";
        custObj.ShippingAddress.City = "Pune";
        custObj.ShippingAddress.Locality = "Deccan";

        // 1 Customer - Have many Orders

        custObj.MyOrders = new List<Orders>()
        {
            new Orders{OrderID = 8540, OrderDate = new DateTime(2001,12,22), Amount = 14000},
            new Orders{OrderID = 1124, OrderDate = new DateTime(2002,3,12), Amount = 24000},
            new Orders{OrderID = 2076, OrderDate = new DateTime(2002,10,12), Amount = 6000},
            new Orders{OrderID = 1212, OrderDate = new DateTime(2008,1,26), Amount = 2000},
            // DateTime is structured
        };
    }
}
