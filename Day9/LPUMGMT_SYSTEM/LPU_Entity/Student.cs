namespace LPU_Entity
{
    public enum CourseType{
        Mechanical=10,
        Electrical=20,
        Civil=30,
        CSE=40,
        IT=50
    }
    public class Student
        //If class name is Student means yes it is Entity Class
    {
        #region
        public int StudentID { get; set; }
        public string Name { get; set; }
        public CourseType Course { get; set; } //Prop of Type Enum //U can have property of primitive type custome type
        //public string Course{ get; set; }
        //if it is string student can pass inferior data
        //so we need to do validation check;
        //enum : Name Integer Constant
        //So where Student can register for those course only not others
        //So here enum is a better option
        //Enums can be defined as namespace level & Deligate also ;In whole C# these two only 
        //defined AS namespace level
        public string Address { get; set; }

        #endregion
    }
}
