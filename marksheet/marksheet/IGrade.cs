using System;
using System.Collections.Generic;
using System.Text;

namespace marksheet
{
    public interface IGrade
    {
        string GetMarkGrade(double math, double english, double hindi, double science);
    }
}
