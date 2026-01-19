// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using LPU_BL;
using LPU_Entity;
using LPU_Exception;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LPU_UI;

class Program
{
    static void Menu()
    {
        Console.WriteLine("------------Student Management System-------------");
        Console.WriteLine("=====================================================================");
        Console.WriteLine("1. Search Student By ID ");
        Console.WriteLine("2. Show ALL Students");
        Console.WriteLine("3. Add Students Details");
        Console.WriteLine("4. Update Student Details");
        Console.WriteLine("5. Drop Student Details");
        Console.WriteLine("6. Exit");
    }
    //Encapsulation is coming feom DAL 
    //Menu Driven
    public static void Main()
        {
        StudentBL sblObj = null;
        sblObj=new StudentBL();
        do
        {
            Menu();
            int choice = 0;
            Console.WriteLine("Please Enter your Choice: ");
            choice=Int32.Parse(Console.ReadLine());
            switch (choice)
                   {
                case 1: {   //always a good choice to use the curly Braces
                           //UI can not directly talk to DAL UI will call the BL layer then it will call the DAL layer then it wull get daya from database
                    int id = 0;
                        try
                        {
                            Console.WriteLine("\tEnter Student ID for Search : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Student sObj = sblObj.SearchStudentByID(id);
                            if (sObj != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ID\t | Name\t | Course \t | Address");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("=================================================");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t |{sObj.Course}\t | {sObj.Address}");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        catch (LPUException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    break;

                        }
                    
                    case 2: //Show ALL Students
                    {
                        try
                        {
                            Console.WriteLine("\t Enter The Student Name For Search: ");
                            string name = Console.ReadLine();
                            List<Student> studList = sblObj.SearchStudentByName(name);
                            if (studList != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ID\t | Name\t | Course \t | Address");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("=================================================");

                                foreach (var sObj in studList)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t |{sObj.Course}\t | {sObj.Address}");


                                }

                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }catch(LPUException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine("We are Coming Soon....");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sorry For the incovenience...");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break ;
                    }
                    case 3:   //ADD Student Details
                    {
                        break;
                    }
                    case 4:   //Update Student Details
                    {
                        break;
                    }
                    case 5:   //Drop Student Details
                    {
                        break;
                    }
                    case 6:     //Exit From Application
                    {
                        break;
                    }


                default:
                    break;
            }

        }while (true);

    }
}

