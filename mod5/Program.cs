using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    class Program
    {
        static void Main(string[] args)
        {
            Course courseVar = new Course();  //instantinate class Course
            courseVar.students = new Student[3];//inst property students of Course class to array with Student type
            courseVar.CourseName = "Programming with C#"; //assign value to CourseNmae property
            courseVar.students[0] = new Student("NewStudent");//assign value to contruct of Students class
            courseVar.teachers = new Teacher[1]; //inst property students of Course class to array with Teacher type
            courseVar.teachers[0] = new Teacher("NewTeacher"); //assign value to contruct of Teacher class
            Degree degreeVar = new Degree();
            degreeVar.DegreeName = "Bachelor";   //instantinate class Degree and assign value
            degreeVar.degreeCourse = courseVar;//Add Course object to the Degree object.
            Upgrogram varUpgrogam = new Upgrogram("Information Technology");
            varUpgrogam.programDegree = degreeVar; //add degree object to uprogram
            Console.WriteLine("The {0} program contains the {1} Science Degree", varUpgrogam.ProgramName, degreeVar.DegreeName);
            Console.WriteLine("Course {0} is taught for {1} degree", courseVar.CourseName, degreeVar.DegreeName);
            Console.WriteLine("Course {0} has {1} student(s) enrolled", courseVar.CourseName, courseVar.students.Length);
            Console.ReadKey();

        }
    }
}
