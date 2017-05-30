using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct studentsInfo
    {
        public string stName { get; set; }
        public string stSurname { get; set; }

    }
    public struct teachersInfo
    {
        public string teachName { get; set; }
        public string teachSurname { get; set; }
    }
    public struct courseInfo
    {
        public string courseName { get; set; }
        public DateTime courseStartDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studentsInfo[] students = new studentsInfo[5];
            for (int i = 1; i < students.Length; i++)
            {
                students[i].stName = Console.ReadLine();
                Console.WriteLine("My {0} student Name is: {1}", i, students[i].stName);
                students[i].stSurname = Console.ReadLine();
                Console.WriteLine("My {0} student Surname is: {0}", i, students[i].stSurname);
            }
            Console.ReadKey();
        }




    }
}

