using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Students
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB {  get; set; }
    }
    public class Teachers { 
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
    public class Subjects
    {
        public int SubjectId {  get; set; }
        public string SubjectName { get; set; }
    }
}
