using System;

namespace AccessModifier;

class DummyClass
{
  void DummyClassDisplay()
    {
         Product PObj=new Product();
         Toys toyObj=new Toys();
         toyObj.Components="Pencil Cell";

         
    }
   
}
class Toys : Product
{
    //If You make something public in base class it will be Available on Child class
    //if you define something protected in base class
    //It can be accessed by the members of the base class
    //Or by the members of the child class
    //Members means methods properties constructor
    //Components is a member of child class
    //So we are able to acces the protected ingridents in this
   
    //Components is actually Encapsulating the Ingridents

    //when we are in same proj we are ABLE To access all(public,protected,protected_internal,internal)
    //BUt when we are in two different proj
    //Only the public is available to access
    //



    public string Components {

        get
        {
            return Ingridents;
        }
        set
        {
            Ingridents=value;
        }

}
}



//Suppose this is in another project 
//And we are making monitor which is derived from the another project's Product class
//we should use :- using proj_Name
//Product is a concrete class so we can make child class from it
//If it is sealed we cant make child of it


class Monitor : Product
{
    //there is something in base which is private
   //chaining of constructor 
   public Monitor(string str) : base(str) 
   
    {
        
    }//throwing exception because constructor is not present in Base class
    //

    public string Parts //read only property
    //here comes the concept of parameterized constructor
    {
        get
        {
            return Ingridents;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product p1=new Monitor();

        //
    }
}

