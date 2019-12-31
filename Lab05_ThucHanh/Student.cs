using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_ThucHanh
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public Student()
        { }
        public Student(string id, string name, DateTime dtBirthday, string add)
        {
            StudentID = id;
            FullName = name;
            BirthDay = dtBirthday;
            Address = add;
        }

        
    }

}
