using System;
using LPU_Common;
using LPU_Entity;
using LPU_Exception;

namespace LPU_DAL
// data can be stored in files, in memory, database
// but we don't have files at this moment, so we can use collections for now
{
    /// <summary>
    /// Student DAO class is used for CRUD operations
    /// Data goes to DAL, then BL, then UI. This will be the path of reference too
    /// </summary>
    public class StudentDAO : IStudentCRUD // Interface
                                           // DAO : Data Access Objects
    {
        static List<Student> studentList = null;
        //static List: stores in one place only, even if I make multiple objects
        GenericClass<float> genObj = null;//object creation of generic class

        public StudentDAO()
        {
            genObj = new GenericClass<float>();
           
            studentList = new List<Student>() //Collection init
            {
                new Student() { StudentID = 101, Name = "Alok", Course = CourseType.CSE, Address = "Chandigarh" },
                new Student() { StudentID = 102, Name = "Aliya", Course = CourseType.CSE, Address = "Jalandhar" },
                new Student() { StudentID = 103, Name = "Aman", Course = CourseType.CSE, Address = "Delhi" },
                new Student() { StudentID = 104, Name = "Riya", Course = CourseType.CSE, Address = "Pune" },
                new Student() { StudentID = 105, Name = "Rajat", Course = CourseType.CSE, Address = "Phagwara" },
                new Student() { StudentID = 106, Name = "Alok", Course = CourseType.CSE, Address = "Chennai" },
                new Student() { StudentID = 107, Name = "Aliya", Course = CourseType.CSE, Address = "Kolkata" },
                new Student() { StudentID = 108, Name = "Aman", Course = CourseType.CSE, Address = "Agartala" },
                new Student() { StudentID = 109, Name = "Riya", Course = CourseType.CSE, Address = "Kochi" },
                new Student() { StudentID = 110, Name = "Rajat", Course = CourseType.CSE, Address = "Pathankot" },
                new Student() { StudentID = 111, Name = "Alok", Course = CourseType.CSE, Address = "Himachal" },
                new Student() { StudentID = 112, Name = "Aliya", Course = CourseType.CSE, Address = "Shimla" },
                new Student() { StudentID = 113, Name = "Aman", Course = CourseType.CSE, Address = "Haridwar" },
                new Student() { StudentID = 114, Name = "Riya", Course = CourseType.CSE, Address = "Kerala" },
                new Student() { StudentID = 115, Name = "Rajat", Course = CourseType.CSE, Address = "Mysore" },
                new Student() { StudentID = 116, Name = "Alok", Course = CourseType.CSE, Address = "Chandigarh" },
                new Student() { StudentID = 117, Name = "Aliya", Course = CourseType.CSE, Address = "Jalandhar" },
                new Student() { StudentID = 118, Name = "Aman", Course = CourseType.CSE, Address = "Delhi" },
                new Student() { StudentID = 119, Name = "Riya", Course = CourseType.CSE, Address = "Pune" },
                new Student() { StudentID = 120, Name = "Rajat", Course = CourseType.CSE, Address = "Phagwara" }
            };
        }







        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if (rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if (myStud == null)
                {
                    throw new LPUException("Student Record Not Found");
                }
            }
            else
            {
                throw new LPUException("Error Generated....");
            }
            return myStud;

        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            // we are not checking the casing here and if the user gives an empty string 
            return data;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}