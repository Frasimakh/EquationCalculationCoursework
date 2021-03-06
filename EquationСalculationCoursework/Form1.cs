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
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.a = Convert.ToInt32(aInt.Text);
                Data.b = Convert.ToInt32(bInt.Text);
                Data.c = (Data.a + Data.b) / 2;
                Data.eps = Convert.ToDouble(eps.Text);
                if (SeconddegreeToolStripMenuItem2.Checked == true)
                {
                    Data.A = Convert.ToDouble(cCoeff.Text);
                    Data.B = Convert.ToDouble(dCoeff.Text);
                    Data.C = Convert.ToDouble(eCoeff.Text);
                }
                else if (ThirddegreeToolStripMenuItem1.Checked == true)
                {
                    Data.A = Convert.ToDouble(bCoeff.Text);
                    Data.B = Convert.ToDouble(cCoeff.Text);
                    Data.C = Convert.ToDouble(dCoeff.Text);
                    Data.D = Convert.ToDouble(eCoeff.Text);
                }
                else
                {
                    Data.A = Convert.ToDouble(aCoeff.Text);
                    Data.B = Convert.ToDouble(bCoeff.Text);
                    Data.C = Convert.ToDouble(cCoeff.Text);
                    Data.D = Convert.ToDouble(dCoeff.Text);
                    Data.E = Convert.ToDouble(eCoeff.Text);


                }
                Base obj = new Base();
                if (SeconddegreeToolStripMenuItem2.Checked == true) obj = new Derivative2();
                if (ThirddegreeToolStripMenuItem1.Checked == true) obj = new Derivative3();
                if (FourthdegreeToolStripMenuItem.Checked == true) obj = new Derivative4();
                Data.f_a = obj.f(Data.a);
                Data.f_b = obj.f(Data.b);
                Data.f_c = obj.f(Data.c);
                Data.fs_a = obj.fs(Data.a);
                Data.fs_b = obj.fs(Data.b);
                Data.fss_a = obj.fss(Data.a);
                Data.fss_b = obj.fss(Data.b);

                Hord();
                Bisec();
                Newthon();
                Graph();
            }
            catch
            {
                MessageBox.Show("Помилка вводу");
            }
        }



        private void Hord()
        {
            Base obj = new Base();
            if (SeconddegreeToolStripMenuItem2.Checked == true) obj = new Derivative2();
            if (ThirddegreeToolStripMenuItem1.Checked == true) obj = new Derivative3();
            if (FourthdegreeToolStripMenuItem.Checked == true) obj = new Derivative4();
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
        private void Bisec()
        {
            Base obj = new Base();
            if (SeconddegreeToolStripMenuItem2.Checked == true) obj = new Derivative2();
            if (ThirddegreeToolStripMenuItem1.Checked == true) obj = new Derivative3();
            if (FourthdegreeToolStripMenuItem.Checked == true) obj = new Derivative4();
            gridBisec.Rows.Clear();
            a = Data.a;
            b = Data.b;
            c = (b + a) / 2;
            int i = 0;
            bool end = true;
            while (end)
            {
                double fa = obj.f(a);
                double fb = obj.f(b);
                double fc = obj.f(c);
                double delta;
                i++;
                delta = Math.Abs(a - b);
                string[] row = { i.ToString(), Math.Round(a, 3).ToString(), Math.Round(b, 3).ToString(), Math.Round(c, 4).ToString(), 
                                 Math.Round(fa, 2).ToString(), Math.Round(fb, 2).ToString(), Math.Round(fc, 2).ToString(), Math.Round(delta, 4).ToString() };
                gridBisec.Rows.Add(row);
                if (Math.Abs(a - b) < Data.eps) end = false;
                if (obj.f(a) * obj.f(c) < 0)
                {
                    b = c;
                    c = (a + b) / 2;
                    continue;
                }
                if (obj.f(a) * obj.f(c) > 0)
                {
                    a = c;
                    c = (a + b) / 2;
                    continue;
                }
                if (obj.f(a) * obj.f(b) == 0) break;
            }
            if ((Math.Round(c, 2) == Data.a) || (Math.Round(c, 2) == Data.b))
            {
                gridBisec.Rows.Clear();
                gridBisec.Rows.Add("Змініть проміжок");
            }
        }
        private void Newthon()
        {
            double Xk;
            double Xknew = 0;
            double Xkold = 0;
            gridNewthon.Rows.Clear();
            Base obj = new Base();
            if (SeconddegreeToolStripMenuItem2.Checked == true) obj = new Derivative2();
            if (ThirddegreeToolStripMenuItem1.Checked == true) obj = new Derivative3();
            if (FourthdegreeToolStripMenuItem.Checked == true) obj = new Derivative4();
            Xk = Data.b;
            int i = 0;
            bool end = true;
            double delta;
            while (end)
            {

                double fXk = obj.f(Xk);
                double fsXk = obj.fs(Xk);

                Xknew = Xk - fXk / fsXk;
                if (i != 0) delta = Math.Abs(Xk - Xkold);
                else delta = 0;
                string[] row = { i.ToString(), Math.Round(Xk, 4).ToString(), Math.Round(delta, 4).ToString(), Math.Round(fXk, 4).ToString(), 
                                 Math.Round(fsXk, 4).ToString() };
                gridNewthon.Rows.Add(row);
                Xkold = Xk;
                Xk = Xknew;
                if (i != 0) if (delta < 0.000001) end = false;
                i++;
            }
        }

        private void Graph()
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisX.LineWidth = 1;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.ChartAreas[0].AxisY.LineWidth = 1;

            double[] x = new double[Math.Abs(Data.b) + Math.Abs(Data.a) + 1];
            double[] y = new double[Math.Abs(Data.b) + Math.Abs(Data.a) + 1];
            int step = Data.a;
            int i = 0; ;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].BorderWidth = 2;
            while (step <= Data.b)
            {
                x[i] = step;
                if (SeconddegreeToolStripMenuItem2.Checked == true) y[i] = Data.A * step * step + Data.B * step + Data.C;
                if (ThirddegreeToolStripMenuItem1.Checked == true) y[i] = Data.A * step * step * step + Data.B * step * step + Data.C * step + Data.D;
                if (FourthdegreeToolStripMenuItem.Checked == true) y[i] = Data.A * step * step * step * step + Data.B * step * step * step + Data.C * step * step + Data.D * step + Data.E;
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                step++;
                i++;
            }
        }
        private void SeconddegreeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FourthdegreeToolStripMenuItem.Checked = false;
            ThirddegreeToolStripMenuItem1.Checked = false;
            aCoeff.Visible = false;
            label13.Visible = false;
            bCoeff.Visible = false;
            label12.Visible = false;
            this.dataGridView3.Location = new System.Drawing.Point(154, 45);
            this.dataGridView3.Size = new System.Drawing.Size(208, 42);
        }

        private void ThirddegreeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FourthdegreeToolStripMenuItem.Checked = false;
            SeconddegreeToolStripMenuItem2.Checked = false;
            aCoeff.Visible = false;
            label13.Visible = false;
            bCoeff.Visible = true;
            label12.Visible = true;
            this.dataGridView3.Location = new System.Drawing.Point(89, 45);
            this.dataGridView3.Size = new System.Drawing.Size(273, 42);

        }

        private void FourthdegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThirddegreeToolStripMenuItem1.Checked = false;
            SeconddegreeToolStripMenuItem2.Checked = false;
            aCoeff.Visible = true;
            label13.Visible = true;
            bCoeff.Visible = true;
            label12.Visible = true;
            this.dataGridView3.Location = new System.Drawing.Point(24, 45);
            this.dataGridView3.Size = new System.Drawing.Size(338, 42);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            gridBisec.Rows.Clear();
            gridNewthon.Rows.Clear();
            gridHord.Rows.Clear();
            aCoeff.Text = "";
            bCoeff.Text = "";
            cCoeff.Text = "";
            dCoeff.Text = "";
            eCoeff.Text = "";
            aInt.Text = "";
            bInt.Text = "";
            eps.Text = "";
        }
        private void aCoeff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 45)
            {
                e.Handled = true;
            }
        }
        private void aInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }
    }
}