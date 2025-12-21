// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using sms; // the namespace of classes

StudentBL sBLObj = new StudentBL();

sBLObj.AcceptStudentDetails();
//sBLObj.CalcTotal();
//sBLObj.CalcAvg();

int t1; // Total
float p1; // Percentage

sBLObj.CalcResult(out t1, out p1); // even though the func is void, it'll return t1 and p1

System.Console.WriteLine($"Total: {t1}");
System.Console.WriteLine($"Percentage: {p1}");