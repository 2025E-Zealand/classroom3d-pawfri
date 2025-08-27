﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Winter";
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Autum";
            }
            else
            {
                return "The month is an invalid";
            }
        }
    }
}
