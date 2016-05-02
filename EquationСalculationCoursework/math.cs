using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationСalculationCoursework
{
    class math
    {
        public static string culc()
        {
            double a = -10;
            double b = 100;
            double eps = 0.0001;
            double x = method_chord(a, b, eps);
            return x.ToString();
        }
        public static double f(double x)
        {
            return x * x - 5 * x + 2;
        }

        public static double method_chord(double a, double b, double eps)
        {
            double x_next = 0;
            double temp;

            while (Math.Abs(x_next - b) > eps)
            {
                temp = x_next;
                x_next = b - f(b) * (a - b) / (f(a) - f(b));
                a = b;
                b = temp;
            }
            return x_next;
        }



    }
}