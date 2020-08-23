using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w05
{
    class Programs
    {
        private string programsName;
        private string programsRank;


        public string ProgramsName
        {
            get { return programsName; }
            set { programsName = value; }
        }

        public string ProgramsRank
        {
            get { return programsRank; }
            set { programsRank = value; }
        }

        public Programs(string pn, string pr)
        {
            this.programsName = pn;
            this.programsRank = pr;


        }
        public override string ToString()
        {
            return this.programsName + this.programsRank;
        }
    }
}