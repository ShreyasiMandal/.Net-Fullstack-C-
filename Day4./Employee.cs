using System;

namespace Day4OOpdemo;

public class Employee
{
    #region Properties
    // type prop it will autogenerate property
    public int MyProperty { get; set; }
    public string Name { get; set; }

    public int BasicSalary { get; set; }

    #endregion
//we need to virtual in base class then we can override the method in child class
    public virtual int CalculateSalary(int sal)
    {
        int mysal=0;
        //NEtsalary=Salary+HRA+TA+DA-PF
        mysal=sal+15000+3000+1500-2500;
        return mysal;
    }

}
