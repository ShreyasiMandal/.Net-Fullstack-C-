using System;

namespace HasinaCabs;

public class CabDetails:cab
{
     public bool ValidateBookingID()
    {
        /*1. Booking id Length should be 6.
        2. The id should have AC before the character @
        3. There should be 3 digits after the character @.
        For Example : AC@123*/

        if(BookingID.Length == 6)
        {
            if (BookingID.StartsWith("AC@", StringComparison.Ordinal))
            {
                return true;
            }
            else
            {
                 return false;
            }
           

        }
        else
        {   
            return false;
        }
    }
    double pricePerKm;
    double fare;
    double waitingCharge;
    public double CalculateFareAmount()
    {
        switch (CabType)
        {
            case "Hatchback":
                {
                    pricePerKm = 10;
                    break;

                }
            
            case "Sedan":
                {
                    pricePerKm=20;
                    break;
                }

            case "SUV":
                {
                    pricePerKm = 30;
                    break;
                }

            default:
                {
                    System.Console.WriteLine("Invalid Cab Type");
                    break;
                }
        }
        // Fare = Distance * Price per km + Waiting Charge
        // Waiting Charge = Square root of Waiting Time

        waitingCharge = Math.Sqrt(WaitingTime);
        fare = (double)Distance *pricePerKm+waitingCharge;

        return fare;

    }

}
