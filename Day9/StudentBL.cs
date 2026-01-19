using System;
using LPU_Common;
using System.Collections.Generic;
using LPU_Entity;
using LPU_DAL;
using LPU_Exception;
namespace LPU_BL
{
    public class StudentBL : IStudentCRUD
    {
        //if we make the object direct here 
        //Student s1 = new Student();
        //It is not a good practise cause the object is created before creating the constructor
        //Like it is invoked before writing the constructor

        StudentDAO sDao = null;  //declare the object and give null value 
        //And initialize it in the constructor
        //this is the right way
        //The object is created at class level because theis can be used by the class members
        //we need DAO (student_DAL) class objects
        //IN the DAL classes all methods are instances method
        public StudentBL()
        {
           sDao = new StudentDAO();

        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            return sDao.EnrollStudent(sObj);
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 = null;
            try
            {
                s1 = sDao.SearchStudentByID(rollNo);
            }catch(LPUException e)
            {
                throw e;
                //Exception from DAL Layer
                //Catch in BL 
                //Throw in UI Layer
            }
            return s1;
        }

        public List<Student> SearchStudentByName(string name)
        {
            return sDao.SearchStudentByName(name);
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
