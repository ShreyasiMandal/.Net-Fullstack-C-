namespace Day4OOpdemo;

    public class Base
    {
        public void Display()
        {
            Console.WriteLine("In base Class");
        }
    }

    public class Derived : Base
    {
        public new void Display()
//if we don't make virtual in base class then we cant override it in child class
//But we still want to override it in the child class
//We have to provide new keyword in child class (it shows it is a shadow of parent class)

//if we use virtual in base class
//And override in base class
//Base ba =new Derived();
//It will call the derived class value
//for this the code will be
//  public class Base
//     {
//         public virtual void Display()
//         {
//             Console.WriteLine("In Base Class");
//         }
//     }

// public class Derived : Base
// {
//     public override void Display()
//     {
//         Console.WriteLine("In Derived Class");
//     }
// }


        {
            Console.WriteLine("In Derived Class");
        }
    }

    public class TestApp
    {
        public static void shadowMain()
        {
            Base bas =new Base();  //call the base class value
          Derived der= new Derived(); //call the derived class value
      Base ba =new Derived(); //It will call the base class object 
//it will call from base class cause it is the main

//

            bas.Display();
            der.Display();
            ba.Display();
        }
    }

//Once we  write Abstract in base class
//then we can create multiple child but 
//not create object of the child class
//Abstract class have atleast one abstract method

