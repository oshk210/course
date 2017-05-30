using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    class Teacher
    {
        private string firstNameTeach;
        public string FirstNameTeach
        {
            get
            {
                return firstNameTeach;
            }
            set
            {
                firstNameTeach = value;
            }
        }
        string lastNameTeach;
        public string LastNameSt
        {
            get { return lastNameTeach; }
            set { lastNameTeach = value; }
        }
        DateTime birtDateTeach;
        public DateTime BirtDateSt
        {
            get { return birtDateTeach; }
            set { birtDateTeach = value; }
        }
        string cityTeach;
        public string CitySt
        {
            get { return cityTeach; }
            set { cityTeach = value; }
        }
        int zipCodeTeach;
        public int ZipCode
        {
            get { return zipCodeTeach; }
            set { zipCodeTeach = value; }
        }
          public Teacher(string firtsN)
    {
        this.FirstNameTeach = firtsN;
    }
    }
}
