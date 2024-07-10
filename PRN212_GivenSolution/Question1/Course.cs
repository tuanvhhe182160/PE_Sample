using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Course
    {
        public int CourseID { get; private set; }
        public string CourseTitle { get; private set; }
        private Dictionary<Student, double> Students;
        public delegate void NumberOfStudentChangeHandler(int oldNumber, int newNumber);
        public event NumberOfStudentChangeHandler OnNumberOfStudentChange;

        public Course(int courseID, string courseTitle)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
            Students = new Dictionary<Student, double>();
        }
        public Course() { }
        public void AddStudent(Student p, double g)
        {
            int oldCount = Students.Count;
            Students[p] = g;
            int newCount = Students.Count;  
            OnNumberOfStudentChange?.Invoke(oldCount, newCount);
        }
        public void RemoveStudent(int StudentID)
        {
            int oldCount = Students.Count;
            foreach (var p in Students.Keys)
            {
                if(p.StudentID == StudentID)
                {
                    Students.Remove(p);
                }
            }
            int newCount = Students.Count;
            OnNumberOfStudentChange?.Invoke(oldCount, newCount);
        }
        public override string ToString()
        {
            string result = $"Course: {CourseID} {CourseTitle}\n";
            foreach (var p in Students)
            {
                result += $"Course: - {p.Key} - Mark: {p.Value}\n";
            }
            return result;
        }
    }
}
