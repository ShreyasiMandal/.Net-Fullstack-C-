using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSerializeDemo
{//attribute based development
    [Serializable] // opt out model
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //[NonSerialized] : this doesn't work with properties
        //public int Salary { get; set; }
        [NonSerialized]
        int sal;
        public int Salary
        {
            get 
            { 
                return sal;
            }
            set 
            {  
                sal = value; 
            }
        }
    }

}
