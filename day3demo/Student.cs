using System;
using System.Net.NetworkInformation;

namespace sms;

public class Student
{
    
    int rollNo; // this is camelCasing
    int phy,chem,maths,total;
    float perc;

    // CLR properties
    public int RollNo // this is PascalCasing
    {
        set
        {
            rollNo = value; // value is a reserved keyword 
            // camelCasing again
        }
        get
        {
            return rollNo;
        }
    }

    // Auto Implicit Property
    public string Name{get;set;}
    
    // "Name" is property name

    /// the above two methods are same in terms of get, set
    /// when there is a limit, e.g., 0 to 100, in that scenario we use the first one
    /// 
    public string Address{get;set;}
    public int Total 
    {
        get
        {
            return total;
        }
        set // if set is protected then these kind of properties are known as DEFAULT PROPERTIES
        {
            total=value;
        }
    }
    public float Perc{get;set;}


    public int Phy
    {
        get
        {
            return phy;
        }
        set
        {
            // CLR properties are created to validate the data
            if(value>=0 && value <= 100)
            {
                phy = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }


    public int Chem
    {
        get
        {
            return chem;
        }
        set
        {
            // CLR properties are created to validate the data
            if(value>=0 && value <= 100)
            {
                chem = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
                // without try catch method, clr takes care of the exception
            }
        }
    }
    
    public int Maths
    {
        get
        {
            return maths;
        }
        set
        {
            // CLR properties are created to validate the data
            if(value>=0 && value <= 100)
            {
                maths = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }

}

[Serializable]
internal class InvalidMarksException : Exception 
{
    // this should have been in a different cs file because this is a bad practice
    public InvalidMarksException()
    {
    }

    public InvalidMarksException(string? message) : base(message) 
    /// base keyword invokes immediate base class
    /// in case you don't remember the name of the base class
    {
        // one child can have only one parent
    }

    public InvalidMarksException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}