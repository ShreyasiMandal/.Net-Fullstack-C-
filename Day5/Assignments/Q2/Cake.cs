using System;

namespace Q2Practice;

public class Cake
{
//     Data Type
//    Property Name
//     string
//   Flavour
//     int
//   QuantityInKg
//     double
//   PricePerKg
//     Method
//    Description

public String?  Flavour { get; set; }

public int QuantityInKg { get; set; }

public double PricePerKg { get; set; }

public bool CakeOrder()
    {
        if(Flavour=="Chocolate" || Flavour=="Red Velvet" || Flavour == "Vanilla")
        {
            if (QuantityInKg > 0)
            {
                return true;
            }
            else
            {
                throw new InvalidQuantityException();
                return false;
            }

        }
        else
        {
            throw new InvalidFlavourException();
            return false;
        }
    }
//     Total Price = Quantity In Kg * Price Per Kg
// Discounted Price = Total Price - (Total Price * Discount /100)
//     Flavour
//    Discount
//     Vanilla
//   3
//     Chocolate
//   5
//     Red Velvet
//   10
    double discount;
    double totalPrice,discountPrice;

    public double CalculatePrice()
    {
        switch (Flavour)
        {
            case "Vanilla":{
            discount=3;
            break;
            }
            case "Chocolate":{
            discount=5;
            break;
            }

            case "Red Velvet":{
            discount=10;
            break;
            }
        }
        totalPrice=QuantityInKg*PricePerKg;
        discountPrice=totalPrice - (totalPrice * discount /100);

        return discountPrice;

    }

}

