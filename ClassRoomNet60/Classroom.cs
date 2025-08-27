﻿using System;
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

        public Classroom(string className, DateTime datetime)
        {
            ClassName = className;
            StudentList = new List<Student>();
            SemesterStart = datetime;
        }
    }
}
