using System;
using System.Collections.Generic;
using System.Text;

namespace marksheet
{
    public interface IMarkshet
    {
        double GetMarkAvg(double math, double english, double hindi, double science);
        double GetMarkTotal(double math, double english, double hindi, double science);
    }
}
