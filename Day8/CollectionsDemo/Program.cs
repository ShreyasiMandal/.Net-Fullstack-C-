using System;
using System.Linq;
namespace CollectionDemo;
class Program
{

    public void ArrayDemoFunc()
    {
        // Simple Array of primitive types
        int[] numArray = new int[10];   //Traditional and conventional way
        // Product[] prodArray = new Product[5];
        // int arr[5];   Used in C++

        int[] arrNum1 = { 10, 20, 30 }; // Method 2
        int[] arrNum2 = new int[3] { 10, 20, 30 }; // Method 3


        string[] cities = { "Delhi", 
                            "Pune",
                            "Kolkata",
                            "Shimla",
                            "Kedarnath",
                            "Srinagar",
                            "Pathankot" }; // The layout is a coding standard

        Customer[] custArray;
        custArray = new Customer[1];
        // Init the object otherwise null reference excption occurs
        custArray[0] = new Customer(); // This is the initialization of the object
        custArray[0].ID = 101;
        custArray[0].Name = "Alok";
        // Address is a class so it also has to be initializsed otherwise exception occurs
        // init the adress class
        custArray[0].BillingAddress = new Address(); // all classes have to be initialized.
        // Init the ShippingAdress too
        custArray[0].BillingAddress.FlatNo = "1802";
        custArray[0].BillingAddress.BuildingName = "Sky Tower";
        custArray[0].BillingAddress.Street = "Bhumar Chowk Wakkad";
        custArray[0].BillingAddress.City = "Pune";


        custArray[0].ShippingAddress = new Address(); // Init the ShippingAdress 
        // if the BillingAddress and ShippingAddress is same
        custArray[0].ShippingAddress = custArray[0].BillingAddress;
        // Both are reference type. Therefore, they will point to the same memory allocation

        /*
        Ideal way to declare Skill class object which has a HAS-A relationship with Employee
        Skill mySkill = null; //declare
        Public Employee(){
            mySkill = new Skill(); // This is inside the Employee constructor
            // But this gives only one skill per employee
        }

        // multiple skills: Skill[] mySkill = null;
        Public Employee(){
            mySkill = new Skill[5]; // but this gives only 5 skills
        }
        */


        /* NonGeneric
         ArrayList mySkill = null;
        public Employee(){
            mySkill = new ArrayList();
        }
        */


        /* Generic
         List<Skill> mySkill = null;
        public Employee(){
            mySkill = new List<Skill>;
        }


        To add skills, create a method (mySkill is a private member of the class,
        so can't access it directly

        in class Employee:
        public bool AddSkill(Skill obj){
            bool flag = false;
            if(obj!=null){
                mySkill.Add(obj);
                flag = true;
            }
            return flag;
        }
        */






        Console.ForegroundColor = ConsoleColor.White;

    }
    static void Main(string[] Args) // concrete class: Allow inheritance
    // all classes except abstract and sealed classes
    {
        Program probObj = new Program();
        probObj.ArrayDemoFunc(); 
        // you can call non static functions into static functions but not vice versa
    }
}




// Printing each item in cities
//foreach(var item in cities)
//{
//    if (item.Length > 4)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(item);
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(item);
//    }

//}