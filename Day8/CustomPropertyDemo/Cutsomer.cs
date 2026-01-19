using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
    class Customer
    {
        // Orders[] myOrders = null;
        List<Orders> OrderList; // Dynamic
        // attributes are never public
        public Customer()
        {
            //myOrders = new Orders[5];
            OrderList = new List<Orders>();
        }
        public int CustID { get; set; } //CLR properties
        // IN CLR => Auto Implicit Properties
        // read only properties are known as default properties
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public List<Orders> MyOrders {
            get
            {
                return OrderList;
            }
            protected set // cannot set this property without a child class
            // nobody can modify this
            {
                OrderList = value;
            }
        }

        // loose coupling => interface
    }
}
