using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w05
{
    class Section
    {
        private string sectionDate;
        private string sectionStart;
        private string sectionEnd;
        private Room sectionRoom;
        private Subject sectionSubject;
        private Lecturer sectionLecturer;

        public string SectionDate
        {
            get { return this.sectionDate; }
            set { this.sectionDate = value; }
        }

        public string SectionStart
        {
            get { return this.sectionStart; }
            set { this.sectionStart = value; }
        }
        public string SectionEnd
        {
            get { return this.sectionEnd; }
            set { this.sectionEnd = value; }
        }
        public Room SectionRoom
        {
            get { return this.sectionRoom; }
            set { this.sectionRoom = value; }
        }
        public Subject SectionSubject
        {
            get { return this.sectionSubject; }
            set { this.sectionSubject = value; }
        }
        public Lecturer SectionLecturer
        {
            get { return this.sectionLecturer; }
            set { this.sectionLecturer = value; }
        }
        public Section() { }
        public Section(string sd, string ss, string se, Room sr, Subject sj, Lecturer sl)
        {
            this.SectionDate = sd;
            this.SectionStart = ss;
            this.SectionEnd = se;
            this.SectionRoom = sr;
            this.SectionSubject = sj;
            this.SectionLecturer = sl;
        }
        public override string ToString()
        {
            return " Date " + this.SectionDate
                 + " Start " + this.SectionStart 
                 + " End " + this.SectionEnd
                 + " Room " + this.SectionRoom.RoomCode
                 + " Subject " + this.SectionSubject.SubjectName
                 + " Lecturer " + this.SectionLecturer.LecturerFname
                 + " " + this.SectionLecturer.LecturerLname;
                
        }
    }
}