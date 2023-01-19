using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectName
{
    internal class Teacher
    {
        public string TeacherName;
        public int TeacherAge;
        //private int TeacherId = 0;
        private int _id;

        public int TeacherId
        {
            get { return _id; }
            set { _id = value++; }
        }


        //public int AssignTeacherId()
        //{
        //    TeacherId++;
        //    return TeacherId;
        //}

        public string TeacherDetails()
        {
            string Teacher = $"Teacher name: {TeacherName}, \r\nTeacher Age: {TeacherAge}\r\nTeacherId: {TeacherId}";
            return Teacher;
        }
    }
}
