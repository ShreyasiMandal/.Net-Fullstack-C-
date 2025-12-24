// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Reflection;
namespace Q1Practice;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("1.Desktop");
        System.Console.WriteLine("2.Laptop");
        int choice=int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            desktop d=new desktop();

            System.Console.WriteLine("Enter the Processor Name: ");
            d.Processor=Console.ReadLine();

            System.Console.WriteLine("Enter the ram size");
            d.RamSize=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the hard disk size");
            d.HardDiskSize=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the graphic card size");
            d.GraphicCard=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monitor size");
                d.MonitorSize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the power supply volt");
                d.PowerSupplyVolt = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Desktop Price is: "+d.DesktopPriceCalculation());
            

        }
        else if (choice == 2)
        {
            Laptop l=new Laptop();

            System.Console.WriteLine("Enter the Processor Name: ");
            l.Processor=Console.ReadLine();

            System.Console.WriteLine("Enter the ram size");
            l.RamSize=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the hard disk size");
            l.HardDiskSize=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the graphic card size");
            l.GraphicCard=int.Parse(Console.ReadLine());

            

                Console.WriteLine("Enter the DisplaySize");
                l.DisplaySize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Battery Volt");
                l.BatteryVolt = int.Parse(Console.ReadLine());

            System.
            Console.WriteLine("Laptop Price is: "+l.LaptopPriceCalculation());

        }
    }
}
