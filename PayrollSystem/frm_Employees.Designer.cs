namespace PayrollSytem
{
    partial class frm_Employees
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
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.txtBirthPlace = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.txtEmergeContact = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtPayMethod = new System.Windows.Forms.ComboBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.dtDateHired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(707, 369);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 23);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Location = new System.Drawing.Point(625, 58);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(47, 13);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Search :";
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(3, 80);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(836, 283);
            this.dtgemplist.TabIndex = 0;
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.btn_edit);
            this.TabPage7.Controls.Add(this.btndelete);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(839, 436);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "Employee\'s List";
            this.TabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(572, 369);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 23);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Location = new System.Drawing.Point(673, 54);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(163, 20);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // btnempnew
            // 
            this.btnempnew.Location = new System.Drawing.Point(487, 370);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(75, 32);
            this.btnempnew.TabIndex = 15;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(325, 370);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(75, 32);
            this.btnempsave.TabIndex = 16;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(85, 127);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(172, 34);
            this.txtBirthPlace.TabIndex = 17;
            this.txtBirthPlace.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 39);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(3, 130);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(70, 13);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Place of Birth";
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "yyyy-MM-dd";
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirth.Location = new System.Drawing.Point(626, 95);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(121, 20);
            this.dtBirth.TabIndex = 12;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(551, 100);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(66, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(353, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Controls.Add(this.txtBirthPlace);
            this.GroupBox9.Controls.Add(this.txtAddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtBirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtLastName);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtContact);
            this.GroupBox9.Controls.Add(this.txtAge);
            this.GroupBox9.Controls.Add(this.txtFirstName);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtMiddleName);
            this.GroupBox9.Controls.Add(this.radioFemale);
            this.GroupBox9.Controls.Add(this.txtEmergeContact);
            this.GroupBox9.Controls.Add(this.radioMale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtStatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Location = new System.Drawing.Point(31, 47);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(791, 189);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Personal Information";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(321, 135);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(26, 13);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(353, 59);
            this.txtContact.MaxLength = 11;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(178, 20);
            this.txtContact.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(353, 131);
            this.txtAge.MaxLength = 2;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(170, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(321, 100);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(25, 13);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sex";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(626, 32);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(156, 20);
            this.txtMiddleName.TabIndex = 0;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(406, 98);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 6;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // txtEmergeContact
            // 
            this.txtEmergeContact.Location = new System.Drawing.Point(626, 131);
            this.txtEmergeContact.MaxLength = 11;
            this.txtEmergeContact.Name = "txtEmergeContact";
            this.txtEmergeContact.Size = new System.Drawing.Size(155, 20);
            this.txtEmergeContact.TabIndex = 0;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(352, 98);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(263, 61);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(84, 13);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Contact Number";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(22, 35);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(57, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "First Name";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(583, 61);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(37, 13);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Widow"});
            this.txtStatus.Location = new System.Drawing.Point(626, 58);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 21);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "Single";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(289, 35);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(58, 13);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Last Name";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(34, 61);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(45, 13);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Address";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(514, 135);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(103, 13);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "Emergency Contact:";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(551, 35);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(69, 13);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Middle Name";
            // 
            // txtPayMethod
            // 
            this.txtPayMethod.FormattingEnabled = true;
            this.txtPayMethod.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.txtPayMethod.Location = new System.Drawing.Point(90, 48);
            this.txtPayMethod.Name = "txtPayMethod";
            this.txtPayMethod.Size = new System.Drawing.Size(154, 21);
            this.txtPayMethod.TabIndex = 0;
            this.txtPayMethod.Text = "Weekly";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(847, 462);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtEmployeeCode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnew);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(839, 436);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Information";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(406, 370);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 32);
            this.btnempupdate.TabIndex = 21;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(121, 21);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeCode.TabIndex = 15;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(28, 24);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(87, 13);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Employee Code :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtPosition);
            this.GroupBox10.Controls.Add(this.txtDailyRate);
            this.GroupBox10.Controls.Add(this.dtDateHired);
            this.GroupBox10.Controls.Add(this.txtPayMethod);
            this.GroupBox10.Location = new System.Drawing.Point(31, 242);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(785, 111);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Work Information";
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "Active",
            "Resigned",
            "Retired"});
            this.txtworkstatus.Location = new System.Drawing.Point(349, 45);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(154, 21);
            this.txtworkstatus.TabIndex = 8;
            this.txtworkstatus.Text = "Active";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(22, 22);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(62, 13);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "Daily Rate :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(293, 22);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(50, 13);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Position :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(300, 48);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(43, 13);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "Status :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(14, 50);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(70, 13);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Pay Method :";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(531, 21);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(64, 13);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date Hired :";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(347, 19);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(156, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Location = new System.Drawing.Point(90, 19);
            this.txtDailyRate.MaxLength = 3;
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(154, 20);
            this.txtDailyRate.TabIndex = 2;
            // 
            // dtDateHired
            // 
            this.dtDateHired.CustomFormat = "yyyy-MM-dd";
            this.dtDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateHired.Location = new System.Drawing.Point(601, 19);
            this.dtDateHired.Name = "dtDateHired";
            this.dtDateHired.Size = new System.Drawing.Size(154, 20);
            this.dtDateHired.TabIndex = 1;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 462);
            this.Controls.Add(this.TabControl2);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TabPage TabPage7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.RichTextBox txtBirthPlace;
        internal System.Windows.Forms.RichTextBox txtAddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtBirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtAge;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtMiddleName;
        internal System.Windows.Forms.RadioButton radioFemale;
        internal System.Windows.Forms.TextBox txtEmergeContact;
        internal System.Windows.Forms.RadioButton radioMale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtStatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox txtPayMethod;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtEmployeeCode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtPosition;
        internal System.Windows.Forms.TextBox txtDailyRate;
        internal System.Windows.Forms.DateTimePicker dtDateHired;
        internal System.Windows.Forms.Button btn_edit;
    }
}