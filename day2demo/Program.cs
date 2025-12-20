// See https://aka.ms/new-console-template for more information
using System.Net.Security;
using day2demo;
static void Menu()
{
    System.Console.WriteLine("1.Add student details");
    System.Console.WriteLine("2. Update student details");
    System.Console.WriteLine("3.Drop student details");
}

Console.WriteLine("Hello, World!");
Student sobj=new Student(123,"Alok","Delhi");
//System.Console.WriteLine("RollNo : {0}\n Name :{1}\n Address :{2}",sobj);
sobj.DisplayDetails(sobj);
sobj=new Student(123,"Alok","Chennai");
sobj.DisplayDetails(sobj);

string[] cities={"Pune","Chennai","Amritsar","Mumbai"};
int i=0;
//for loops gives the content foreach give the details of every item
//foreach
foreach(var item in cities)
{
    System.Console.WriteLine(item);
}
//while
while (i < cities.Length)
{
    System.Console.WriteLine(cities[i]);
    i++;
}

//switch case
int choice=0;
do{
Menu();
System.Console.WriteLine("Enter your choice: ");
choice=Int32.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        {
           break; 
        }
        case 2:
        {
           break; 
        }
        case 3:
        {
            break;
        }
}
}while(true);