using System;

namespace LibrarymanagementSystem;

public class Book
{
    #region Fields
    string title;
    string author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;
    #endregion

    #region Constructors
    // Default Constructor
    public Book()
    {
        title = string.Empty;
        author = string.Empty;
        numPages = 0;
        dueDate = DateTime.MinValue;
        returnedDate = DateTime.MinValue;
    }

    // Parameterized Constructor to assign values
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;    
    }
    #endregion


    #region Methods
    public double AveragePagesReadPerDay(int daysToRead)
    {
        // Average Pages Read Per Day = numPages / daysToRead
        return (double)numPages/daysToRead;
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        // Late Fee = Number of days late * dailyLateFeeRate
        // Number of days late = returnedDate - dueDate
        int daysLate = (returnedDate - dueDate).Days;
        return (double)daysLate*dailyLateFeeRate;

    }

    #endregion

}
