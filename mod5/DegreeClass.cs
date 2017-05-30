
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    class Degree
    {
        string degreeName;
        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
        int credits;
        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        public Course degreeCourse;
    }
}
