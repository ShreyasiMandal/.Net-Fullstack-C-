using System;

namespace day2demo
{
    public class Student
    {
        #region Fields
        /// <summary>
        /// These are class-level fields
        /// </summary>
        int rollNo;
        string name;
        string addr;
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public Student()
        {
            // Optional: initialize default values
            rollNo = 0;
            name = string.Empty;
            addr = string.Empty;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        public Student(int id, string name, string city)
        {
            rollNo = id;
            this.name = name;
            addr = city;
        }
       public void DisplayDetails(Student s1)
        {
            System.Console.WriteLine("RollNo : {0}\n Name :{1}\n Address :{2}",s1.rollNo,s1.name,s1.addr);
        }
    }
}


