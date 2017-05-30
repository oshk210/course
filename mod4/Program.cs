using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    public struct studentsInfo
    {
        public string stName { get; set; }
        public string stSurname { get; set; }
    }
    enum daysOfWeek {Sun, Mon, Tue, Wed, Thu, Fri, Sat};

    class Program
    {
        static void Main(string[] args)
        {
        studentsInfo student1 = new studentsInfo();
        student1.stName = Console.ReadLine();
        Console.WriteLine("Students Name is: {0}", student1.stName);
        student1.stSurname = Console.ReadLine();
        Console.WriteLine("Student's Surname is: {0}", student1.stName);
        
        DateTime today1 = DateTime.Today;
        Console.WriteLine("Today is {0}", today1.DayOfWeek );

        string [] firstArray = new string[5];
        for (int i = 0; i < firstArray.Length; i++)
        {
           firstArray[i]="ArrValue"+i.ToString();
           Console.WriteLine("My array is {0}:", firstArray[i]);
        }
        string[] weekArray = {"Sun", "Mon", "Tue", "We", "Thu", "Fru", "Sat"};
        for (int i = 0; i < weekArray.Length; i++)
        {
           
            Console.WriteLine("My array is: {0}", weekArray[i]);
        }
        
        Console.ReadKey();
        }
   
}
}
