using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    public class Program

    {
        
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };

            string[] nameArray = { "Alok", "Rajat", "Sunil", "Priya", "Ayush", "Harshita", "Himanshu", "Mahi", "Mandabi", "Gaurav", "Yash", "Mahesh", "Teja", "Sai" };

            //foreach (var item in numArray)
            //{   // Legacy approach
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //LINQ query

            
            var result = from data in numArray // source
                         where data % 2 == 0 && data > 20
                         select data;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            int dataToSearch = 12;
            var result1 = from data in numArray // source
                         where data == 12 // for comparison in LINQ Queries, unlike SQL, we use "==" instead of "="
                          select data;
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            var result2 = from data in nameArray // source
                          where data.StartsWith("M") || data.Contains("M") || data.Contains("m")
                          select data;

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter name to search: ");
            string dataToSearch1 = Console.ReadLine();

            var result3 = from data in nameArray // source
                          where data == dataToSearch1
                          select data;

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            // Same as above
            var result4 = nameArray.Where(n => n == dataToSearch1);
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }


            var result5 = from data in nameArray // source
                          orderby data descending
                          select data;
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }


        }


        public static void LinqToObjectDemoOnCustomerType()
        {
            List<Customer> cusList = new List<Customer>()
            {
                new Customer{ CustomerId = 101, Name = "Alok", City = "Pune" },
                new Customer() { CustomerId = 102, Name = "Aliya", City = "Mumbai" },
                new Customer() { CustomerId = 103, Name = "Dheeraj", City = "Delhi" },
                new Customer() { CustomerId = 104, Name = "Danish", City = "Mumbai" },
                new Customer() { CustomerId = 105, Name = "Smita", City = "Pune" },
                new Customer() { CustomerId = 106, Name = "Naveen", City = "Delhi" },
                new Customer() { CustomerId = 107, Name = "Prachi", City = "Pune" },
                new Customer() { CustomerId = 108, Name = "Megha", City = "Delhi" },
            };

            // method syntax
            var result = cusList.Where(cust => cust.City == "Delhi");


            // query syntax
            var result1 = from cust in cusList
                          where cust.City == "Delhi"
                          select new { cust.Name, cust.City };
            // With this customer ID will not be revealed.
            // Only the name and city will be revealed

            var data = new { OrderID = 110, OrderDate = "12/04/2025", TotalAmount = 14000 };
            // Anonymous object

            var result2 = cusList.FindAll(cust => cust.City == "Delhi");
            // returns the first occurence, unlike "Where"

            foreach (var item in result2)
            {
                Console.WriteLine($"{item.CustomerId}\t{item.Name}\t{item.City}");
            }
            


        }

        public static void LambdaLookup()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var query = tempList.ToLookup(s=>s.Gender=="Male"); 
            // this answer will be in boolean
            // is the person Male? "Yes" or "No"
            foreach (IGrouping<bool, Student> group in query) // <key, type>
            {
                int totFees = 0;
                //Console.WriteLine("Key: {0}", group.Key);
                if (group.Key == true)
                {
                    Console.WriteLine("Male Students details below");
                }
                else
                {
                    Console.WriteLine("Female Students details below");
                }
                    foreach (Student std in group)
                    {
                        Console.WriteLine($"\t{std.Name}");
                        totFees += std.Fees;
                    }
                Console.WriteLine("Total Fees paid");
                Console.WriteLine(totFees);
            }

            // var maleFeesPaid = 
        }

        public static void TotalCostOfProducts()
        {
            List<Product> prodList = new List<Product>()
            {
                new Product(){ID=1,Name="Maza",Cost=50,Quantity=2000},
                  new Product(){ID=2,Name="RedBull",Cost=50,Quantity=4000},
                    new Product(){ID=3,Name="Sprite",Cost=150,Quantity=2000},
                      new Product(){ID=4,Name="Coke",Cost=200,Quantity=2000},
                       new Product(){ID=5,Name="Fanta",Cost=30,Quantity=4000}
            };
            Dictionary<string, int> demoDict = new Dictionary<string, int>();
            var itemsList = prodList.GroupBy(item => item.Name == "RedBull")
                .Select(group => new
                {
                    Qty = group.Key,
                    items = group.ToList()
                });
            foreach (var item in itemsList)
            {
                Console.WriteLine("Quantity :{0}", item.Qty);
                demoDict.Add(item.Qty.ToString(), item.items.Count());
                Console.WriteLine($"Items Count {item.items.Count()}");
                int total = 0;
                foreach (var data in item.items)
                {
                    Console.WriteLine(data.Name);
                    total += data.Cost;
                }
                Console.WriteLine($"Total Cost of Products :{total}");
            }
        }


        static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LinqToObjectDemoOnCustomerType();
            //LambdaLookup();
            
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();

            // total fees
            var total = tempList.Select(s => s.Fees).Sum();
            Console.WriteLine(total);

            var total1 = tempList.Select(s => s.Fees).Max();

            tempList.Sum(s => s.Fees);


            TotalCostOfProducts();
        }
    }
}
