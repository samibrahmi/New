using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    public class Student
    {
        private string v1;
        private int v2;

       

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public double Grade { get; set; }
        public double AdjustedGrade { get; set; }
        public double AdjustedGradeByPercentage()
        {
            double curve = ((Grade * 4) / 5) + 20;
            AdjustedGrade = curve;
            return curve;
        }
        public void LogClassAverage()
        {
            Console.WriteLine(this.FirstName);
        }

    }
}
