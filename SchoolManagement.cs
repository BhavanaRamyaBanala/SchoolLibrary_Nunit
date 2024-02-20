using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class SchoolManagement
    {
        static List<Students> students = new List<Students>()
        {
            new Students(){ StudentId=1,FirstName="Henry",LastName="San",DOB=new DateTime(day:02,month:10,year:2003)},
            new Students(){ StudentId=2,FirstName="John",LastName="park",DOB=new DateTime(day:17,month:06,year:1999)},
            new Students(){ StudentId=3,FirstName="Sona",LastName="Lim",DOB=new DateTime(day:05,month:10,year:2001)},
            new Students(){ StudentId=4,FirstName="Pranav",LastName="Reddy",DOB=new DateTime(day:28,month:09,year:2000)}
        };
        static List<Teachers> teachers = new List<Teachers>()
        {
            new Teachers(){ TeacherId=1,TeacherName="Swapna"},
            new Teachers(){ TeacherId=2,TeacherName="Rakesh"}
        };
        static List<Subjects> subjects = new List<Subjects>()
        {
            new Subjects(){ SubjectId=1,SubjectName="Swapna"},
            new Subjects(){ SubjectId=2,SubjectName="Rakesh"}
        };
        public static List<Students> AllStudents() { 
            return students;
        }
        public static List<Students> StudentById(int id) {
            List<Students> stu = students.FindAll(e=>e.StudentId==id);
            return stu;
        }
        public static List<Teachers> AllTeachers() {
            return teachers;
        }
        public static List<Subjects> AllSubjects() { 
            return subjects; 
        }
    }
}
