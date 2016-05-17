using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationСalculationCoursework
{
    class Derivative
    {
        public double f(double x) 
        {
            return Data.A * x * x * x + Data.B * x * x + Data.C * x + Data.D;
        }

        public double fs(double x)
        {
            return 3 * Data.A * x * x + 2 * Data.B * x + Data.C;
        }
        public double fss(double x)
        {
            return 6 * Data.A * x + 2 * Data.B;
        }
    }
}
