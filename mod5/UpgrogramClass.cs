using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    class Upgrogram
    {
        string programName;
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
        string departmentHead;
        public string DepartmentHead
        {
            get { return departmentHead; }
            set { departmentHead = value; }
        }
        string degree;

        public Degree programDegree;
        private string p;

        public Upgrogram(string p)
        {
            this.ProgramName = p;
        }
        
    }
}
