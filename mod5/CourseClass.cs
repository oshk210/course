
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    class Course
    {
        string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        int credit;
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        int durationWeeks;
        public int DurationWeeks
        {
            get { return durationWeeks; }
            set { durationWeeks = value; }
        }
        public Student[] students;
        public Teacher[] teachers;
        
       
    }
}
