﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Pluralsight_Classes_and_Objects
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}