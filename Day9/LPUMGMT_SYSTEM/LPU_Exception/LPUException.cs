namespace LPU_Exception
{
    //This class can be accessed anywhere without object

    /// <summary>
    /// Custom Exception Class Created For LPU Project
    /// By Shreyasi on Day 29/12/2025 at 11:34 AM
    /// </summary>
    public class LPUException:Exception
    {
        ////ctor :Creating Constructor
        public LPUException() :base()//default Constructor //base class is built in class 
            //default constructor is invoking base class constructor
        {
            
        }
        /// <summary>
        /// Constructor Chaining
        /// </summary>
        /// <param name="errorMsg"></param>
        public LPUException(string errorMsg):base(errorMsg) //Parameterized constructor
            //here happening same with the parameterized Constructor

        {
            
        }
    }
}
