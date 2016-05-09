namespace EquationСalculationCoursework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHord = new System.Windows.Forms.TabPage();
            this.gridHord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDichotomy = new System.Windows.Forms.TabPage();
            this.tabNewthon = new System.Windows.Forms.TabPage();
            this.bInt = new System.Windows.Forms.TextBox();
            this.aInt = new System.Windows.Forms.TextBox();
            this.dCoeff = new System.Windows.Forms.TextBox();
            this.cCoeff = new System.Windows.Forms.TextBox();
            this.bCoeff = new System.Windows.Forms.TextBox();
            this.aCoeff = new System.Windows.Forms.TextBox();
            this.eps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.степіньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ийСтепіньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ийСтепіньToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ийСтепіньToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabHord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHord);
            this.tabControl1.Controls.Add(this.tabDichotomy);
            this.tabControl1.Controls.Add(this.tabNewthon);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(82, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 281);
            this.tabControl1.TabIndex = 2;
            // 
            // tabHord
            // 
            this.tabHord.Controls.Add(this.gridHord);
            this.tabHord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabHord.Location = new System.Drawing.Point(4, 25);
            this.tabHord.Name = "tabHord";
            this.tabHord.Padding = new System.Windows.Forms.Padding(3);
            this.tabHord.Size = new System.Drawing.Size(321, 252);
            this.tabHord.TabIndex = 2;
            this.tabHord.Text = "Метод хорд";
            this.tabHord.UseVisualStyleBackColor = true;
            // 
            // gridHord
            // 
            this.gridHord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridHord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridHord.Location = new System.Drawing.Point(-1, -1);
            this.gridHord.Name = "gridHord";
            this.gridHord.Size = new System.Drawing.Size(644, 316);
            this.gridHord.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "k";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Xk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 48;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "∆";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 42;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "f(Xk)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 59;
            // 
            // tabDichotomy
            // 
            this.tabDichotomy.Location = new System.Drawing.Point(4, 25);
            this.tabDichotomy.Name = "tabDichotomy";
            this.tabDichotomy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichotomy.Size = new System.Drawing.Size(321, 252);
            this.tabDichotomy.TabIndex = 0;
            this.tabDichotomy.Text = "Метод дихотомії";
            this.tabDichotomy.UseVisualStyleBackColor = true;
            // 
            // tabNewthon
            // 
            this.tabNewthon.Location = new System.Drawing.Point(4, 25);
            this.tabNewthon.Name = "tabNewthon";
            this.tabNewthon.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewthon.Size = new System.Drawing.Size(321, 252);
            this.tabNewthon.TabIndex = 1;
            this.tabNewthon.Text = "Метод ньютона";
            this.tabNewthon.UseVisualStyleBackColor = true;
            // 
            // bInt
            // 
            this.bInt.Location = new System.Drawing.Point(774, 153);
            this.bInt.Name = "bInt";
            this.bInt.Size = new System.Drawing.Size(26, 20);
            this.bInt.TabIndex = 12;
            this.bInt.Text = "-2,2";
            // 
            // aInt
            // 
            this.aInt.Location = new System.Drawing.Point(703, 153);
            this.aInt.Name = "aInt";
            this.aInt.Size = new System.Drawing.Size(26, 20);
            this.aInt.TabIndex = 11;
            this.aInt.Text = "-3";
            // 
            // dCoeff
            // 
            this.dCoeff.Location = new System.Drawing.Point(290, 66);
            this.dCoeff.Name = "dCoeff";
            this.dCoeff.Size = new System.Drawing.Size(26, 20);
            this.dCoeff.TabIndex = 10;
            this.dCoeff.Text = "0,9";
            // 
            // cCoeff
            // 
            this.cCoeff.Location = new System.Drawing.Point(227, 66);
            this.cCoeff.Name = "cCoeff";
            this.cCoeff.Size = new System.Drawing.Size(26, 20);
            this.cCoeff.TabIndex = 9;
            this.cCoeff.Text = "-2,6";
            // 
            // bCoeff
            // 
            this.bCoeff.Location = new System.Drawing.Point(164, 66);
            this.bCoeff.Name = "bCoeff";
            this.bCoeff.Size = new System.Drawing.Size(27, 20);
            this.bCoeff.TabIndex = 8;
            this.bCoeff.Text = "-3,8";
            // 
            // aCoeff
            // 
            this.aCoeff.Location = new System.Drawing.Point(98, 66);
            this.aCoeff.Name = "aCoeff";
            this.aCoeff.Size = new System.Drawing.Size(26, 20);
            this.aCoeff.TabIndex = 7;
            this.aCoeff.Text = "-1";
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(735, 231);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(49, 20);
            this.eps.TabIndex = 13;
            this.eps.Text = "0,001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(192, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "· x²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "· x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "· x³";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "= 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 40);
            this.dataGridView1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.степіньToolStripMenuItem,
            this.очиститиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // степіньToolStripMenuItem
            // 
            this.степіньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ийСтепіньToolStripMenuItem,
            this.ийСтепіньToolStripMenuItem1,
            this.ийСтепіньToolStripMenuItem2});
            this.степіньToolStripMenuItem.Name = "степіньToolStripMenuItem";
            this.степіньToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.степіньToolStripMenuItem.Text = "Степінь рівняння";
            // 
            // ийСтепіньToolStripMenuItem
            // 
            this.ийСтепіньToolStripMenuItem.Name = "ийСтепіньToolStripMenuItem";
            this.ийСтепіньToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ийСтепіньToolStripMenuItem.Text = "4-ий степінь";
            // 
            // ийСтепіньToolStripMenuItem1
            // 
            this.ийСтепіньToolStripMenuItem1.Name = "ийСтепіньToolStripMenuItem1";
            this.ийСтепіньToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ийСтепіньToolStripMenuItem1.Text = "3-ий степінь";
            // 
            // ийСтепіньToolStripMenuItem2
            // 
            this.ийСтепіньToolStripMenuItem2.Name = "ийСтепіньToolStripMenuItem2";
            this.ийСтепіньToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ийСтепіньToolStripMenuItem2.Text = "2-ий степінь";
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.bInt);
            this.Controls.Add(this.aInt);
            this.Controls.Add(this.dCoeff);
            this.Controls.Add(this.cCoeff);
            this.Controls.Add(this.bCoeff);
            this.Controls.Add(this.aCoeff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EquationСalculation";
            this.tabControl1.ResumeLayout(false);
            this.tabHord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDichotomy;
        private System.Windows.Forms.TabPage tabNewthon;
        private System.Windows.Forms.TextBox bInt;
        private System.Windows.Forms.TextBox aInt;
        private System.Windows.Forms.TextBox dCoeff;
        private System.Windows.Forms.TextBox cCoeff;
        private System.Windows.Forms.TextBox bCoeff;
        private System.Windows.Forms.TextBox aCoeff;
        private System.Windows.Forms.TabPage tabHord;
        private System.Windows.Forms.DataGridView gridHord;
        private System.Windows.Forms.TextBox eps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem степіньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ийСтепіньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ийСтепіньToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ийСтепіньToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}

