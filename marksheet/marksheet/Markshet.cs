using System;
using System.Collections.Generic;
using System.Text;

namespace marksheet
{
    public class Markshet : IMarkshet, IGrade
    {
        public double GetMarkAvg(double math, double english, double hindi, double science)
        {
            return GetMarkTotal(math, english, hindi, science) / 4;
        }

        public string GetMarkGrade(double math, double english, double hindi, double science)
        {
            var avg = GetMarkAvg(math, english, hindi, science);
            if (avg > 85)
            {
                return "A+";
            }
            if (avg > 75)
            {
                return "A";
            }
            if (avg > 60)
            {
                return "B";
            }
            return "C";
        }

        public double GetMarkTotal(double math, double english, double hindi, double science)
        {
            return math + english + hindi + science;
        }
    }
}
