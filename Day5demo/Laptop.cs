using System;

namespace Q1Practice;

public class Laptop: Computer{

//  Data Type
//    Property Name
//     int
//   DisplaySize
//     int
//   BatteryVolt
// {


  public int DisplaySize { get; set; }

  public int BatteryVolt{ get; set; }

  public  double LaptopPriceCalculation()
    {

 double price = 0;

    switch (Processor)
    {
        case "i3":
            price = 2500;
            break;

        case "i5":
            price = 5000;
            break;

        case "i7":
            price = 6500;
            break;

        default:
            Console.WriteLine("Invalid Processor Selected");
            break;
    }
    price=(price+RamSize*200+HardDiskSize*1500+
GraphicCard*2500+
DisplaySize*250+
BatteryVolt*20);
return price;

   
  
    
    }     
        }

