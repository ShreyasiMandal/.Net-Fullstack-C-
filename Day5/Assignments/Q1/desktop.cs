using System;

namespace Q1Practice;

public class desktop :Computer
{
//    Data Type
//    Property Name
//     int
//   MonitorSize
//     int
//   PowerSupplyVolt

    public int MonitorSize { get; set; }

    public int PowerSupplyVolt { get; set; }

    public  double DesktopPriceCalculation()
    {
//          Processor
//    Processor Cost
//     i3
//   1500
//     i5
//   3000
//     i7
//   4500
double price=0;
        switch (Processor)
        {
            case "i3":
            price=1500;
            break;

            case "i5":
            price=3000;
            break;

            case "i7":
            price=4500;
            break;

            default:
            System.Console.WriteLine("Invalid Processor Selected");
          break;

// Ram price (per GB)
//   Hard disk (per TB)
//   Graphic Card (per GB)
//   Power supply (per Volt)
//   Monitor (per inch)
//     200
//    1500
//    2500
//    20
//  250
        }
price=(price+RamSize*200+HardDiskSize*1500+
GraphicCard*2500+
PowerSupplyVolt*20+
MonitorSize*250);

return price;

        
         
    }
}
