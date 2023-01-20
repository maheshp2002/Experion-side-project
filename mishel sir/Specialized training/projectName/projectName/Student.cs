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

        public int Mark1 { get; set; }

        public int Mark2 { get; set; }

        private int _age;



        public int Age
        {
            get { return _age; }
            set {
                if (value >= 0 && value <= 100)
                {
                    _age= value;
                }
                else
                {
                    Console.WriteLine("Age limit is between 0 & 100");
                }
            }
        }

        public string StudentDetails { 
            get
            {
                int Total = Mark1 + Mark2;
                return Name + " " + Email + " " + Dob + " " + Address + " " + Total;
            } 
        }

        public override string ToString()
        {
            return $"mac is cool";
        }

        //public string studentDetails()
        //{
        //    string details = Name + " " + Email + " " + Dob + " " + Address;
        //    return details;
        //}
    }
}
