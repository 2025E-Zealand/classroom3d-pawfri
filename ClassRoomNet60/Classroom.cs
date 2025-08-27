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

        //Opgave 6 - Metode til at sortere og gruppere baseret på sæson
        public void SeasonSort()
        {
            var groups = StudentList
                .Where(s => s.BirthMonth > 0)
                .GroupBy(s => s.Season())
                .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Count()} birthdays in {group.Key}");
            }

        }

    }
}
