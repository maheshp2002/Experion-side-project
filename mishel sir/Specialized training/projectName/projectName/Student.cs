using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectName
{
    internal class Student
    {
        //public string Name;
        //public string Email;
        //public DateOnly Dob;
        //public string Address;

        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly Dob { get; set; }
        public string Address { get; set; }




        public string studentDetails()
        {
            string details = Name + " " + Email + " " + Dob + " " + Address;
            return details;
        }
    }
}
