using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w05
{
    class Lecturer
    {
        private string lecturerFname;
        private string lecturerLname;
        private string lecturerPosition;

        public string LecturerFname
        {
            get { return lecturerFname; }
            set { lecturerFname = value; }
        }

        public string LecturerLname
        {
            get { return lecturerLname; }
            set { lecturerLname = value; }
        }

        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }
        public Lecturer(string sc, string ln, string lp)
        {
            this.LecturerFname = sc;
            this.LecturerLname = ln;
            this.LecturerPosition = lp;

        }
        public override string ToString()
        {
            return this.LecturerFname + this.LecturerLname + this.LecturerPosition;
        }
    }
}