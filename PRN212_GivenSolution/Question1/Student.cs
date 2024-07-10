using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Student
    {
        public int StudentID { get; private set; }
        public string StudentName { get; private set; }

        public Student(int StudentID, string StudentName)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
        }
        public Student() { }
        public override string ToString()
        {
            return $"{StudentID} : {StudentName}";
        }
    }
}
