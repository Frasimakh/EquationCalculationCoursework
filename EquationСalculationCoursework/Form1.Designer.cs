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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHord = new System.Windows.Forms.TabPage();
            this.gridHord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDichotomy = new System.Windows.Forms.TabPage();
            this.gridBisec = new System.Windows.Forms.DataGridView();
            this.kColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNewthon = new System.Windows.Forms.TabPage();
            this.gridNewthon = new System.Windows.Forms.DataGridView();
            this.bInt = new System.Windows.Forms.TextBox();
            this.aInt = new System.Windows.Forms.TextBox();
            this.eps = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.степіньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FourthdegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirddegreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SeconddegreeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bCoeff = new System.Windows.Forms.TextBox();
            this.cCoeff = new System.Windows.Forms.TextBox();
            this.dCoeff = new System.Windows.Forms.TextBox();
            this.eCoeff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aCoeff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fXkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsXkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabHord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHord)).BeginInit();
            this.tabDichotomy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBisec)).BeginInit();
            this.tabNewthon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNewthon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(387, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHord);
            this.tabControl1.Controls.Add(this.tabDichotomy);
            this.tabControl1.Controls.Add(this.tabNewthon);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(25, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 281);
            this.tabControl1.TabIndex = 2;
            // 
            // tabHord
            // 
            this.tabHord.Controls.Add(this.gridHord);
            this.tabHord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabHord.Location = new System.Drawing.Point(4, 25);
            this.tabHord.Name = "tabHord";
            this.tabHord.Padding = new System.Windows.Forms.Padding(3);
            this.tabHord.Size = new System.Drawing.Size(407, 252);
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
            this.gridHord.Size = new System.Drawing.Size(408, 253);
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
            this.tabDichotomy.Controls.Add(this.gridBisec);
            this.tabDichotomy.Location = new System.Drawing.Point(4, 25);
            this.tabDichotomy.Name = "tabDichotomy";
            this.tabDichotomy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichotomy.Size = new System.Drawing.Size(407, 252);
            this.tabDichotomy.TabIndex = 0;
            this.tabDichotomy.Text = "Метод дихотомії";
            this.tabDichotomy.UseVisualStyleBackColor = true;
            // 
            // gridBisec
            // 
            this.gridBisec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridBisec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridBisec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBisec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kColumn,
            this.aColumn,
            this.bColumn,
            this.cColumn,
            this.faColumn,
            this.fb,
            this.fcColumn,
            this.delta});
            this.gridBisec.Location = new System.Drawing.Point(0, 0);
            this.gridBisec.Name = "gridBisec";
            this.gridBisec.Size = new System.Drawing.Size(407, 252);
            this.gridBisec.TabIndex = 1;
            // 
            // kColumn
            // 
            this.kColumn.HeaderText = "k";
            this.kColumn.Name = "kColumn";
            this.kColumn.Width = 40;
            // 
            // aColumn
            // 
            this.aColumn.HeaderText = "a";
            this.aColumn.Name = "aColumn";
            this.aColumn.ReadOnly = true;
            this.aColumn.Width = 41;
            // 
            // bColumn
            // 
            this.bColumn.HeaderText = "b";
            this.bColumn.Name = "bColumn";
            this.bColumn.ReadOnly = true;
            this.bColumn.Width = 41;
            // 
            // cColumn
            // 
            this.cColumn.HeaderText = "c";
            this.cColumn.Name = "cColumn";
            this.cColumn.ReadOnly = true;
            this.cColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cColumn.Width = 40;
            // 
            // faColumn
            // 
            this.faColumn.HeaderText = "f(a)";
            this.faColumn.Name = "faColumn";
            this.faColumn.ReadOnly = true;
            this.faColumn.Width = 52;
            // 
            // fb
            // 
            this.fb.HeaderText = "f(b)";
            this.fb.Name = "fb";
            this.fb.ReadOnly = true;
            this.fb.Width = 52;
            // 
            // fcColumn
            // 
            this.fcColumn.HeaderText = "f(c)";
            this.fcColumn.Name = "fcColumn";
            this.fcColumn.ReadOnly = true;
            this.fcColumn.Width = 51;
            // 
            // delta
            // 
            this.delta.HeaderText = "∆";
            this.delta.Name = "delta";
            this.delta.ReadOnly = true;
            this.delta.Width = 42;
            // 
            // tabNewthon
            // 
            this.tabNewthon.Controls.Add(this.gridNewthon);
            this.tabNewthon.Location = new System.Drawing.Point(4, 25);
            this.tabNewthon.Name = "tabNewthon";
            this.tabNewthon.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewthon.Size = new System.Drawing.Size(407, 252);
            this.tabNewthon.TabIndex = 1;
            this.tabNewthon.Text = "Метод ньютона";
            this.tabNewthon.UseVisualStyleBackColor = true;
            // 
            // gridNewthon
            // 
            this.gridNewthon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridNewthon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridNewthon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNewthon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.xkColumn,
            this.deltaColumn,
            this.fXkColumn,
            this.fsXkColumn});
            this.gridNewthon.Location = new System.Drawing.Point(0, 0);
            this.gridNewthon.Name = "gridNewthon";
            this.gridNewthon.Size = new System.Drawing.Size(407, 256);
            this.gridNewthon.TabIndex = 2;
            // 
            // bInt
            // 
            this.bInt.Location = new System.Drawing.Point(503, 172);
            this.bInt.Name = "bInt";
            this.bInt.Size = new System.Drawing.Size(26, 20);
            this.bInt.TabIndex = 12;
            this.bInt.Text = "5";
            this.bInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aInt_KeyPress);
            // 
            // aInt
            // 
            this.aInt.Location = new System.Drawing.Point(503, 143);
            this.aInt.Name = "aInt";
            this.aInt.Size = new System.Drawing.Size(26, 20);
            this.aInt.TabIndex = 11;
            this.aInt.Text = "-5";
            this.aInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aInt_KeyPress);
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(503, 198);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(43, 20);
            this.eps.TabIndex = 13;
            this.eps.Text = "0,001";
            this.eps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.степіньToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // степіньToolStripMenuItem
            // 
            this.степіньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FourthdegreeToolStripMenuItem,
            this.ThirddegreeToolStripMenuItem1,
            this.SeconddegreeToolStripMenuItem2});
            this.степіньToolStripMenuItem.Name = "степіньToolStripMenuItem";
            this.степіньToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.степіньToolStripMenuItem.Text = "Degree of the equation";
            // 
            // FourthdegreeToolStripMenuItem
            // 
            this.FourthdegreeToolStripMenuItem.Checked = true;
            this.FourthdegreeToolStripMenuItem.CheckOnClick = true;
            this.FourthdegreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FourthdegreeToolStripMenuItem.Name = "FourthdegreeToolStripMenuItem";
            this.FourthdegreeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FourthdegreeToolStripMenuItem.Text = "Fourth degree";
            this.FourthdegreeToolStripMenuItem.Click += new System.EventHandler(this.FourthdegreeToolStripMenuItem_Click);
            // 
            // ThirddegreeToolStripMenuItem1
            // 
            this.ThirddegreeToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ThirddegreeToolStripMenuItem1.CheckOnClick = true;
            this.ThirddegreeToolStripMenuItem1.Name = "ThirddegreeToolStripMenuItem1";
            this.ThirddegreeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ThirddegreeToolStripMenuItem1.Text = "Third degree";
            this.ThirddegreeToolStripMenuItem1.Click += new System.EventHandler(this.ThirddegreeToolStripMenuItem1_Click);
            // 
            // SeconddegreeToolStripMenuItem2
            // 
            this.SeconddegreeToolStripMenuItem2.CheckOnClick = true;
            this.SeconddegreeToolStripMenuItem2.Name = "SeconddegreeToolStripMenuItem2";
            this.SeconddegreeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.SeconddegreeToolStripMenuItem2.Text = "Second degree";
            this.SeconddegreeToolStripMenuItem2.Click += new System.EventHandler(this.SeconddegreeToolStripMenuItem2_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.вихідToolStripMenuItem.Text = "Exit";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(24, 45);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(338, 42);
            this.dataGridView3.TabIndex = 25;
            // 
            // bCoeff
            // 
            this.bCoeff.Location = new System.Drawing.Point(103, 56);
            this.bCoeff.Name = "bCoeff";
            this.bCoeff.Size = new System.Drawing.Size(26, 20);
            this.bCoeff.TabIndex = 17;
            this.bCoeff.Text = "-1";
            this.bCoeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // cCoeff
            // 
            this.cCoeff.Location = new System.Drawing.Point(169, 56);
            this.cCoeff.Name = "cCoeff";
            this.cCoeff.Size = new System.Drawing.Size(27, 20);
            this.cCoeff.TabIndex = 18;
            this.cCoeff.Text = "-3,8";
            this.cCoeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // dCoeff
            // 
            this.dCoeff.Location = new System.Drawing.Point(232, 56);
            this.dCoeff.Name = "dCoeff";
            this.dCoeff.Size = new System.Drawing.Size(26, 20);
            this.dCoeff.TabIndex = 19;
            this.dCoeff.Text = "-2,6";
            this.dCoeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // eCoeff
            // 
            this.eCoeff.Location = new System.Drawing.Point(295, 56);
            this.eCoeff.Name = "eCoeff";
            this.eCoeff.Size = new System.Drawing.Size(26, 20);
            this.eCoeff.TabIndex = 20;
            this.eCoeff.Text = "0,9";
            this.eCoeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(264, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "· x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(324, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "= 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(135, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "· x³";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(69, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "· x⁴";
            // 
            // aCoeff
            // 
            this.aCoeff.Location = new System.Drawing.Point(38, 56);
            this.aCoeff.Name = "aCoeff";
            this.aCoeff.Size = new System.Drawing.Size(26, 20);
            this.aCoeff.TabIndex = 27;
            this.aCoeff.Text = "-5";
            this.aCoeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCoeff_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(198, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "· x²";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(468, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(468, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(457, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "eps = ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(452, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(102, 97);
            this.dataGridView1.TabIndex = 32;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(565, 45);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(491, 346);
            this.chart1.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "k";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // xkColumn
            // 
            this.xkColumn.HeaderText = "Xk";
            this.xkColumn.Name = "xkColumn";
            this.xkColumn.ReadOnly = true;
            this.xkColumn.Width = 48;
            // 
            // deltaColumn
            // 
            this.deltaColumn.HeaderText = "∆";
            this.deltaColumn.Name = "deltaColumn";
            this.deltaColumn.ReadOnly = true;
            this.deltaColumn.Width = 42;
            // 
            // fXkColumn
            // 
            this.fXkColumn.HeaderText = "f(Xk)";
            this.fXkColumn.Name = "fXkColumn";
            this.fXkColumn.ReadOnly = true;
            this.fXkColumn.Width = 59;
            // 
            // fsXkColumn
            // 
            this.fsXkColumn.HeaderText = "fs(Xk)";
            this.fsXkColumn.Name = "fsXkColumn";
            this.fsXkColumn.ReadOnly = true;
            this.fsXkColumn.Width = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 438);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aCoeff);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.eCoeff);
            this.Controls.Add(this.dCoeff);
            this.Controls.Add(this.cCoeff);
            this.Controls.Add(this.bCoeff);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.bInt);
            this.Controls.Add(this.aInt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EquationСalculation";
            this.tabControl1.ResumeLayout(false);
            this.tabHord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHord)).EndInit();
            this.tabDichotomy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBisec)).EndInit();
            this.tabNewthon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNewthon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDichotomy;
        private System.Windows.Forms.TabPage tabNewthon;
        private System.Windows.Forms.TextBox bInt;
        private System.Windows.Forms.TextBox aInt;
        private System.Windows.Forms.TabPage tabHord;
        private System.Windows.Forms.DataGridView gridHord;
        private System.Windows.Forms.TextBox eps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem степіньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FourthdegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThirddegreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SeconddegreeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox bCoeff;
        private System.Windows.Forms.TextBox cCoeff;
        private System.Windows.Forms.TextBox dCoeff;
        private System.Windows.Forms.TextBox eCoeff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox aCoeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gridBisec;
        private System.Windows.Forms.DataGridViewTextBoxColumn kColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delta;
        private System.Windows.Forms.DataGridView gridNewthon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fXkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsXkColumn;
    }
}

