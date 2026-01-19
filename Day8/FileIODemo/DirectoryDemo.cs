using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileIODemo;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            Console.WriteLine("Folder already exists");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            Console.WriteLine("Folder Created...");
        }
    }

    public void DriveInfoFunc(string driveName) {
        DriveInfo dInfo = new DriveInfo(driveName);
        Console.WriteLine($"Drive Name : {dInfo.Name}");
        Console.WriteLine($"Drive FileSystem : {dInfo.DriveType}");
        Console.WriteLine($"Drive Size : {dInfo.TotalSize}");
        Console.WriteLine($"Drive Free Space : {dInfo.AvailableFreeSpace}");
    }

    public void PathDemoFunc()
    {
        string s = @"C:\Users\hp\OneDrive\Desktop\.NET.docx";
        Console.WriteLine(Path.GetFullPath(s));
        //Console.WriteLine(Path.GetTempPath(s));

    }
}