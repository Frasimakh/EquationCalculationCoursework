﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.a = Convert.ToDouble(aInt.Text);
            Data.b = Convert.ToDouble(bInt.Text);
            Data.c = (Data.a + Data.b) / 2;
            Data.A = Convert.ToDouble(aCoeff.Text);
            Data.B = Convert.ToDouble(bCoeff.Text);
            Data.C = Convert.ToDouble(cCoeff.Text);
            Data.D = Convert.ToDouble(dCoeff.Text);
            Data.eps = Convert.ToDouble(eps.Text);
            Hord();

            /*Data.Value=textBox1.Text;
           MessageBox.Show(math.culc());
            MessageBox.Show(Data.Value);
           string str = Parser.Eval(Data.Value.Replace("x", "55").ToCharArray()).ToString();
            MessageBox.Show(str); */

        }
        private double f(double x)
        {
            return Data.A * x * x * x + Data.B * x * x + Data.C * x + Data.D;
        }

        private double fs(double x)
        {
            return 3 * Data.A * x * x + 2 * Data.B * x + Data.C;
        }
        private double fss(double x)
        {
            return 6 * Data.A * x + 2 * Data.B;
        }

        private void Hord()
        {
            double Xk = 0;
            double XkNew = 0;
            double XkOld = 0;
            gridHord.Rows.Clear();
            bool formula;
            if (f(Data.a) * fss(Data.a) > 0) formula = true;
            else formula = false;
            int i = 0;
            if (formula) Xk = Data.b;
            else Xk = Data.a;
            bool end = true;
            double delta;
            while (end)
            {
                double fXk = f(Xk);
                if (i != 0) delta = Math.Abs(Xk - XkOld);
                else delta = 0;
                string[] row = { i.ToString(), Math.Round(Xk, 4).ToString(), Math.Round(delta, 4).ToString(), Math.Round(fXk, 4).ToString() };
                gridHord.Rows.Add(row);
                if (!formula) XkNew = Xk - fXk * (Data.b - Xk) / (f(Data.b) - fXk);
                else XkNew = Data.a - f(Data.a) * (Xk - Data.a) / (fXk - f(Data.a));
                XkOld = Xk;
                Xk = XkNew;
                if (i != 0) if (delta < Data.eps) end = false;
                i++;

            }
        }




    }
}