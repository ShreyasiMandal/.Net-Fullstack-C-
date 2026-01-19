using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
    internal class PrimeCustomer : Customer
    {
        public List<Orders> MyPrimeOrders // Write Only Property
        { set 
            { 
                MyOrders = value; // encapsulation
            }
        }
    }
}
