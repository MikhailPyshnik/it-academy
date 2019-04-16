using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_10
{
    interface IСountArea
    {
        double AreaFigure(double EnteredRadius, double SemiPerimeter);  //  Calculate the area of ​​figure.
        void PrintAreaFigure(double FigureArea);
    }
}
