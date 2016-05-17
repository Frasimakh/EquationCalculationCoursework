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
            Derivative obj = new Derivative();
            Data.f_a = obj.f(Data.a);
            Data.f_b = obj.f(Data.b);
            Data.fs_a = obj.fs(Data.a);
            Data.fs_b = obj.fs(Data.b);
            Data.fss_a = obj.fss(Data.a);
            Data.fss_b = obj.fss(Data.b);
            Hord();
        }

        private void Hord()
        {
            Derivative obj = new Derivative();
            double Xk = 0;
            double XkNew = 0;
            double XkOld = 0;
            int i = 0;
            double delta;
            gridHord.Rows.Clear();
            bool formula;
            if (Data.f_a * Data.fss_a > 0) formula = true;
            else formula = false;
            if (formula) Xk = Data.b;
            else Xk = Data.a;
            bool end = true;
            while (end)
            {
                double fXk = obj.f(Xk);
                if (i != 0) delta = Math.Abs(Xk - XkOld);
                else delta = 0;
                string[] row = { i.ToString(), Math.Round(Xk, 4).ToString(), Math.Round(delta, 4).ToString(), Math.Round(fXk, 4).ToString() };
                gridHord.Rows.Add(row);
                if (!formula) XkNew = Xk - fXk * (Data.b - Xk) / (Data.f_b - fXk);
                else XkNew = Data.a - Data.f_a * (Xk - Data.a) / (fXk - Data.f_a);
                XkOld = Xk;
                Xk = XkNew;
                if (i != 0) if (delta < Data.eps) end = false;
                i++;

            }
        }

        private void степіньРіняToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}