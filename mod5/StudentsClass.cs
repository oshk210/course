using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    public class Student
    {
        private string firstNameSt;
        public string FirstNameSt
        {
            get { return firstNameSt; }
            set { firstNameSt = value;}
        }
        string lastNameSt;
        public string LastNameSt
        {
            get { return lastNameSt; }
            set { lastNameSt = value; }
        }
        DateTime birtDateSt;
        public DateTime BirtDateSt
        {
            get { return birtDateSt; }
            set { birtDateSt = value; }
        }
        string citySt;
        public string CitySt
        {
            get { return citySt; }
            set { citySt = value; }
        }
        int zipCodeSt;
        public int ZipCode
        {
            get { return zipCodeSt; }
            set { zipCodeSt = value; }
        }
        public Student(string firtsN)
    {
        this.FirstNameSt = firtsN;
    }
    }
    
    
}
