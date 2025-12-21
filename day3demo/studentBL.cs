using System;
using System.Security.Cryptography.X509Certificates;

namespace sms;

public class StudentBL
{
    Student sObj = null;
    public StudentBL() // ctor is shortcut to create constructor
    {
        sObj = new Student();
        // better prcatice to initialise objects
    }
    public void AcceptStudentDetails()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        // console class is a prebuilt class
        // ConsoleColor is an enumerator


        System.Console.WriteLine("Student Managemnet System");
        System.Console.WriteLine("================================");
        // cw is shortcut for System.Console.WriteLine();
        try{
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine("Enter your roll number: "); 
            sObj.RollNo = Int32.Parse(Console.ReadLine()); // leave one line after code (coding standard)

            System.Console.WriteLine("Enter your Name: ");
            sObj.Name = Console.ReadLine();
        
            System.Console.WriteLine("Enter your Address: ");
            sObj.Address = Console.ReadLine();

            System.Console.WriteLine("Enter your Physics marks: ");
            sObj.Phy = Int32.Parse(Console.ReadLine()); // Phy has been used, not phy

            System.Console.WriteLine("Enter your Chemistry marks: ");
            sObj.Chem = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths marks: ");
            sObj.Maths = Int32.Parse(Console.ReadLine());    
        }

        catch (InvalidMarksException e)
        {
            // custom exception
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(e.Message); 
            // it will always be object.Message for whichever class you use
            // this message was inherited from Exception class
        }
        catch(Exception e)
        {
            // built in exception
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(e.Message);
        }

        Console.ForegroundColor = ConsoleColor.White;

        
    }
    public int CalcTotal()
    {
        sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
        return sObj.Total;
        // when Total is default property, this won't work because StudentBL is not a child of student
    }

    public float CalcAvg()
    {
        sObj.Perc=sObj.Total/3;
        return sObj.Perc;
    }

    public void CalcResult(out int myTotal, out float myPerc)
    {
        myTotal =sObj.Phy + sObj.Chem + sObj.Maths;
        myPerc = myTotal/3;
    }
    
}