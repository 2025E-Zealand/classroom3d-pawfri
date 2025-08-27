using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Classroom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public Classroom()
        {
            StudentList = new List<Student>();
            SemesterStart = new DateTime();
        }

        //public void SeasonSort()
        //{
        //    int spring = 

        //    StudentList
        //        .Where(s => s.BirthMonth == )
        //        .OrderBy(s => s.Title)
        //        .Select(s => new { m.Title, m.Year });

        //}

    }
}
