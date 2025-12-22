// See https://aka.ms/new-console-template for more information
using System.Numerics;
using InterfaceDemo;

Console.WriteLine("Hello, World!");

// Mathclass m1=new Mathclass(); //Alok Add 
// //Alok only want to use add function

// Mathclass m2=new Mathclass();
// //Riya is Looking for addme and subme

// Mathclass m3=new Mathclass();
// //Rajat wants all 4 add sub prod div

// m1.

//one person want 1 pay for 1 but getting all facilities like alok
//so problem comes the solution is interface

// IAdd m1=new Mathclass(); //only ADD

// IAddSub m2=new Mathclass(); //AddSub

// IAll m3=new Mathclass(); //ALL

//Approach 1

Product pObj=new Product(); //declaration
pObj.ProdID=101;  //Initilaztion with values
pObj.Name="Borosil Flask";
pObj.Price=850;

//Approach 2
//Object initializer

Product pObj1=new Product(){ProdID=102,Name="Luxor Marker",Price=25};


//Approach 3
//Collection Initializer
//ArrayList non generic Collection
//List Generic collection 


List<Product> prodList=new List<Product>()
{
    new Product(){ProdID=101,Name="Lotion",Price=250},
    new Product(){ProdID=102,Name="Bellavita Perfume",Price=999},
    new Product(){ProdID=103,Name="Hotwheel Toy",Price=500},
    new Product(){ProdID=104,Name="Ballons",Price=50},
    new Product(){ProdID=105,Name="Chocolates",Price=200},
    new Product(){ProdID=106,Name="Axcer 90mg",Price=2450},
};

foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}


