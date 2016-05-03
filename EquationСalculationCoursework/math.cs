using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationСalculationCoursework
{
/* class math
    {
        public static string culc()
        {
            double a = 10;
            double b = 100;
            double eps = 0.0001;
            double x = method_chord(a, b, eps);
            return x.ToString();
        }
        public static double f(double x)
        {

           
            string str = Data.Value.Replace("x", x.ToString());
            str = str.Replace("+-", "-");
            str = str.Replace("-+", "-");
            double z = Math.Round(Parser.Eval(Data.Value.ToCharArray()));
            return z;
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



    }*/
    class Data
    {
        public static double a { get; set; }
        public static double b { get; set; }
        public static double c { get; set; }
        public static double eps { get; set; }
        public static double A { get; set; }
        public static double B { get; set; }
        public static double C { get; set; }
        public static double D { get; set; }
        }
}