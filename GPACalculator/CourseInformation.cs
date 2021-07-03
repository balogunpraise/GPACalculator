using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculator
{
    class CourseInformation
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public double Score { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public string Remark { get; set; }

        public CourseInformation(string code, int unit, double score, string grade, int GradeUnit, string Remark )
        {
            this.CourseCode = code;
            this.CourseUnit = unit;
            this.Score = score;
            this.Grade = grade;
            this.GradeUnit = GradeUnit;
            this.Remark = Remark;
        }
    }
    
}
