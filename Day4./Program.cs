// See https://aka.ms/new-console-template for more information
using System;
namespace Day4OOpdemo;


    class Program
{
    static void main(String[] args)
    {
        classdemo demoObj=new classdemo("Pankaj");
        //classdemo d1=new classdemo();
    }
    class Manager : Employee
    {
        public int ManagerId { get; set; }
        public int incentive { get; set; }

         public int CalculateSalary(int sal)
    {
        int mysal=0;
        //NEtsalary=Salary+HRA+TA+DA-PF
        //we need to make virtual in base class then 
        // we can override the method in child class
        //We have to provide new keyword in child class (it shows it is a shadow of parent class)
        //from function shadowing
        TestApp.shadowMain();
        mysal=sal+35000+12000+4500-8500;
        return mysal;

        //calculate salary same name the value is different
        //

        //child class method is a shadow of base class
        //Function shadowing

        //Employee ba=new Manager();
        //then it will call the child  class obj
    }
    }

    class clerk : Employee
    {
        public int clerkId { get; set; }
        public int bonus { get; set; }
    }
}



