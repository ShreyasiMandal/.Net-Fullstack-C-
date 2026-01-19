using System;
namespace FileIODemo;

class Program
{
    static void Main()
    {
        DirectoryDemo dObj = new DirectoryDemo();
        dObj.DirectoryDemoFunc("LPU");

        //dObj.DriveInfoFunc("D:\\"); // "\\" : Path seperator because "\" is escape sequence

        FileStreamDemo fsDemoObj = new FileStreamDemo();
        fsDemoObj.CreateFile(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\SampleData.txt");

        fsDemoObj.ReadFile(@"C:\Users\hp\Training\Day5\CakeWorld\Cake.cs");
    }
}