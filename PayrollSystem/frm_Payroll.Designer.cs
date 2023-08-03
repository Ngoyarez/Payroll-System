namespace PayrollSytem
{
    partial class frm_Payroll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Payroll));
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtRateWage = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtRatePerDay = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtNumDays = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPayMethod = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txttranscode = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.DomainUpDown();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage9 = new System.Windows.Forms.TabPage();
            this.txtpsearch = new System.Windows.Forms.TextBox();
            this.dtgParollList = new System.Windows.Forms.DataGridView();
            this.Label15 = new System.Windows.Forms.Label();
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage8 = new System.Windows.Forms.TabPage();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotalDeduction = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtNHIF = new System.Windows.Forms.TextBox();
            this.txtNSSF = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParollList)).BeginInit();
            this.TabControl3.SuspendLayout();
            this.TabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(107, 89);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(133, 20);
            this.txtLoan.TabIndex = 8;
            this.txtLoan.Text = "0";
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoan.TextChanged += new System.EventHandler(this.txtLoan_TextChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Controls.Add(this.txtRateWage);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.txtRatePerDay);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.txtNumDays);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.txtPayMethod);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Location = new System.Drawing.Point(10, 19);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(510, 255);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Income";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtNetIncome);
            this.GroupBox4.Controls.Add(this.txtGrossIncome);
            this.GroupBox4.Controls.Add(this.Label12);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Location = new System.Drawing.Point(8, 73);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(480, 130);
            this.GroupBox4.TabIndex = 19;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Income Details: ";
            // 
            // txtNetIncome
            // 
            this.txtNetIncome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNetIncome.Enabled = false;
            this.txtNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetIncome.Location = new System.Drawing.Point(102, 51);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.Size = new System.Drawing.Size(175, 53);
            this.txtNetIncome.TabIndex = 21;
            this.txtNetIncome.Text = "0";
            this.txtNetIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrossIncome
            // 
            this.txtGrossIncome.Enabled = false;
            this.txtGrossIncome.Location = new System.Drawing.Point(102, 19);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.Size = new System.Drawing.Size(175, 20);
            this.txtGrossIncome.TabIndex = 20;
            this.txtGrossIncome.Text = "0";
            this.txtGrossIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(9, 67);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(65, 13);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "Net Income:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 22);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(75, 13);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "Gross Income:";
            // 
            // txtRateWage
            // 
            this.txtRateWage.Enabled = false;
            this.txtRateWage.Location = new System.Drawing.Point(342, 45);
            this.txtRateWage.Name = "txtRateWage";
            this.txtRateWage.Size = new System.Drawing.Size(133, 20);
            this.txtRateWage.TabIndex = 14;
            this.txtRateWage.Text = "0";
            this.txtRateWage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(261, 47);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(65, 13);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "Rate Wage:";
            // 
            // txtRatePerDay
            // 
            this.txtRatePerDay.Enabled = false;
            this.txtRatePerDay.Location = new System.Drawing.Point(342, 19);
            this.txtRatePerDay.Name = "txtRatePerDay";
            this.txtRatePerDay.Size = new System.Drawing.Size(133, 20);
            this.txtRatePerDay.TabIndex = 12;
            this.txtRatePerDay.Text = "0";
            this.txtRatePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(255, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(71, 13);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Rate per day:";
            // 
            // txtNumDays
            // 
            this.txtNumDays.Location = new System.Drawing.Point(110, 45);
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Size = new System.Drawing.Size(133, 20);
            this.txtNumDays.TabIndex = 2;
            this.txtNumDays.TextChanged += new System.EventHandler(this.txtNumDays_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "No. of Days:";
            // 
            // txtPayMethod
            // 
            this.txtPayMethod.Enabled = false;
            this.txtPayMethod.Location = new System.Drawing.Point(110, 19);
            this.txtPayMethod.Name = "txtPayMethod";
            this.txtPayMethod.Size = new System.Drawing.Size(133, 20);
            this.txtPayMethod.TabIndex = 8;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 20);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(73, 13);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Pay Method  :";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(599, 61);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(44, 13);
            this.Label19.TabIndex = 1;
            this.Label19.Text = "Search:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txttranscode);
            this.GroupBox1.Controls.Add(this.txtEmployeeCode);
            this.GroupBox1.Controls.Add(this.txtEmployeeName);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(15, 19);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(520, 81);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employee Details";
            // 
            // txttranscode
            // 
            this.txttranscode.Location = new System.Drawing.Point(390, 13);
            this.txttranscode.Name = "txttranscode";
            this.txttranscode.Size = new System.Drawing.Size(100, 20);
            this.txttranscode.TabIndex = 6;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(183, 20);
            this.txtEmployeeCode.TabIndex = 5;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged_1);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Location = new System.Drawing.Point(99, 47);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(286, 20);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Employee Code:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee Name:";
            // 
            // TabPage9
            // 
            this.TabPage9.Controls.Add(this.txtpsearch);
            this.TabPage9.Controls.Add(this.Label19);
            this.TabPage9.Controls.Add(this.dtgParollList);
            this.TabPage9.Location = new System.Drawing.Point(4, 22);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage9.Size = new System.Drawing.Size(849, 497);
            this.TabPage9.TabIndex = 1;
            this.TabPage9.Text = "List";
            this.TabPage9.UseVisualStyleBackColor = true;
            // 
            // txtpsearch
            // 
            this.txtpsearch.Location = new System.Drawing.Point(649, 58);
            this.txtpsearch.Name = "txtpsearch";
            this.txtpsearch.Size = new System.Drawing.Size(193, 20);
            this.txtpsearch.TabIndex = 2;
            this.txtpsearch.TextChanged += new System.EventHandler(this.txtpsearch_TextChanged);
            // 
            // dtgParollList
            // 
            this.dtgParollList.AllowUserToAddRows = false;
            this.dtgParollList.AllowUserToDeleteRows = false;
            this.dtgParollList.AllowUserToResizeColumns = false;
            this.dtgParollList.AllowUserToResizeRows = false;
            this.dtgParollList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgParollList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParollList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgParollList.Location = new System.Drawing.Point(4, 84);
            this.dtgParollList.Name = "dtgParollList";
            this.dtgParollList.RowHeadersVisible = false;
            this.dtgParollList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParollList.Size = new System.Drawing.Size(838, 373);
            this.dtgParollList.TabIndex = 0;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(14, 92);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(86, 13);
            this.Label15.TabIndex = 24;
            this.Label15.Text = "Loan Deduction:";
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage8);
            this.TabControl3.Controls.Add(this.TabPage9);
            this.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl3.Location = new System.Drawing.Point(0, 0);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(857, 523);
            this.TabControl3.TabIndex = 2;
            // 
            // TabPage8
            // 
            this.TabPage8.Controls.Add(this.PictureBox3);
            this.TabPage8.Controls.Add(this.btnNew);
            this.TabPage8.Controls.Add(this.btnSave);
            this.TabPage8.Controls.Add(this.GroupBox2);
            this.TabPage8.Controls.Add(this.GroupBox1);
            this.TabPage8.Location = new System.Drawing.Point(4, 22);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage8.Size = new System.Drawing.Size(849, 497);
            this.TabPage8.TabIndex = 0;
            this.TabPage8.Text = "Create Payroll";
            this.TabPage8.UseVisualStyleBackColor = true;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(541, 0);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(279, 144);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox3.TabIndex = 32;
            this.PictureBox3.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(692, 450);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 29);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(555, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 29);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.GroupBox7);
            this.GroupBox2.Controls.Add(this.GroupBox5);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Location = new System.Drawing.Point(15, 105);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(805, 386);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Payroll Details";
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.txtRemarks);
            this.GroupBox7.Location = new System.Drawing.Point(7, 283);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(491, 88);
            this.GroupBox7.TabIndex = 4;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(9, 20);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(474, 53);
            this.txtRemarks.TabIndex = 17;
            this.txtRemarks.Text = "";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.txtTotalDeduction);
            this.GroupBox5.Controls.Add(this.Label17);
            this.GroupBox5.Controls.Add(this.txtNHIF);
            this.GroupBox5.Controls.Add(this.txtNSSF);
            this.GroupBox5.Controls.Add(this.Label16);
            this.GroupBox5.Controls.Add(this.Label14);
            this.GroupBox5.Controls.Add(this.txtLoan);
            this.GroupBox5.Controls.Add(this.Label15);
            this.GroupBox5.Location = new System.Drawing.Point(526, 45);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(290, 281);
            this.GroupBox5.TabIndex = 3;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Deductions:";
            // 
            // txtTotalDeduction
            // 
            this.txtTotalDeduction.Enabled = false;
            this.txtTotalDeduction.Location = new System.Drawing.Point(107, 158);
            this.txtTotalDeduction.Name = "txtTotalDeduction";
            this.txtTotalDeduction.Size = new System.Drawing.Size(133, 20);
            this.txtTotalDeduction.TabIndex = 23;
            this.txtTotalDeduction.Text = "0";
            this.txtTotalDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(14, 161);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(34, 13);
            this.Label17.TabIndex = 22;
            this.Label17.Text = "Total:";
            // 
            // txtNHIF
            // 
            this.txtNHIF.Location = new System.Drawing.Point(107, 35);
            this.txtNHIF.Name = "txtNHIF";
            this.txtNHIF.Size = new System.Drawing.Size(133, 20);
            this.txtNHIF.TabIndex = 5;
            this.txtNHIF.Text = "0";
            this.txtNHIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNHIF.TextChanged += new System.EventHandler(this.txtNHIF_TextChanged);
            // 
            // txtNSSF
            // 
            this.txtNSSF.Location = new System.Drawing.Point(107, 63);
            this.txtNSSF.Name = "txtNSSF";
            this.txtNSSF.Size = new System.Drawing.Size(133, 20);
            this.txtNSSF.TabIndex = 7;
            this.txtNSSF.Text = "0";
            this.txtNSSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNSSF.TextChanged += new System.EventHandler(this.txtNSSF_TextChanged);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(14, 65);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(90, 13);
            this.Label16.TabIndex = 22;
            this.Label16.Text = "NSSF Deduction:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(14, 35);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(84, 13);
            this.Label14.TabIndex = 26;
            this.Label14.Text = "NHIF Deduction";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code:";
            // 
            // frm_Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 523);
            this.Controls.Add(this.TabControl3);
            this.Name = "frm_Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.frm_Payroll_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.TabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParollList)).EndInit();
            this.TabControl3.ResumeLayout(false);
            this.TabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtLoan;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtNetIncome;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox txtGrossIncome;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtRateWage;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtRatePerDay;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtNumDays;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtPayMethod;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtEmployeeName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage TabPage9;
        internal System.Windows.Forms.TextBox txtpsearch;
        internal System.Windows.Forms.DataGridView dtgParollList;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TabControl TabControl3;
        internal System.Windows.Forms.TabPage TabPage8;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.RichTextBox txtRemarks;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.TextBox txtTotalDeduction;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox txtNHIF;
        internal System.Windows.Forms.TextBox txtNSSF;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.DomainUpDown txtEmployeeCode;
        private System.Windows.Forms.TextBox txttranscode;
        private System.Windows.Forms.Label label3;
    }
}