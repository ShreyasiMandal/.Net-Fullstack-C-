using System;

namespace Q3Practice;

public class Candy
{
//      Data Type
//    Property Name
//     string
//   Flavour
//     int
//   Quantity
//     int
//   PricePerPiece
//     double
//   TotalPrice
//     double
//   Discount

public String? Flavour { get; set; }

public int Quantity { get; set; }

public int PricePerPiece { get; set; }

public double TotalPrice { get; set; }

public double Discount { get; set; }

public bool ValidateCandyFlavour()
    {
        // If the flavour is Strawberry or Lemon or Mint,
        //  then return true. Otherwise, return false.
        if(Flavour=="Strawberry" || Flavour=="Lemon" || Flavour == "Mint")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
