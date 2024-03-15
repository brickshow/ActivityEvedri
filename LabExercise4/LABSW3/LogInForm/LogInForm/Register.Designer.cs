namespace LogInForm
{
    partial class Register
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
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlCivilStatus = new System.Windows.Forms.Panel();
            this.rbtnWidowed = new System.Windows.Forms.RadioButton();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnSeparated = new System.Windows.Forms.RadioButton();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbtnHr = new System.Windows.Forms.RadioButton();
            this.rtbStaff = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtMidInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.pnlDisplayEmployee = new System.Windows.Forms.Panel();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmViewDet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnStaffList = new System.Windows.Forms.RadioButton();
            this.rbtnHumanRes = new System.Windows.Forms.RadioButton();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.lblViewList = new System.Windows.Forms.Label();
            this.pnlAddEmployee.SuspendLayout();
            this.pnlCivilStatus.SuspendLayout();
            this.pnlPosition.SuspendLayout();
            this.pnlDisplayEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddEmployee.Controls.Add(this.label1);
            this.pnlAddEmployee.Controls.Add(this.lblGender);
            this.pnlAddEmployee.Controls.Add(this.label2);
            this.pnlAddEmployee.Controls.Add(this.lblBdate);
            this.pnlAddEmployee.Controls.Add(this.lblLName);
            this.pnlAddEmployee.Controls.Add(this.lblMName);
            this.pnlAddEmployee.Controls.Add(this.lblFName);
            this.pnlAddEmployee.Controls.Add(this.txtAge);
            this.pnlAddEmployee.Controls.Add(this.txtGender);
            this.pnlAddEmployee.Controls.Add(this.btnNext);
            this.pnlAddEmployee.Controls.Add(this.pnlCivilStatus);
            this.pnlAddEmployee.Controls.Add(this.pnlPosition);
            this.pnlAddEmployee.Controls.Add(this.dtpBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtNationality);
            this.pnlAddEmployee.Controls.Add(this.txtBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtMidInitial);
            this.pnlAddEmployee.Controls.Add(this.txtLastName);
            this.pnlAddEmployee.Controls.Add(this.lblInstruction);
            this.pnlAddEmployee.Controls.Add(this.txtFirstName);
            this.pnlAddEmployee.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmployee.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddEmployee.Location = new System.Drawing.Point(6, 6);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(300, 651);
            this.pnlAddEmployee.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Age*";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 362);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nationality*";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(13, 246);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(58, 15);
            this.lblBdate.TabIndex = 28;
            this.lblBdate.Text = "Birthdate*";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(11, 190);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(65, 15);
            this.lblLName.TabIndex = 56;
            this.lblLName.Text = "Last Name*";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(11, 132);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(73, 15);
            this.lblMName.TabIndex = 25;
            this.lblMName.Text = "Middle Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(11, 73);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 23;
            this.lblFName.Text = "First Name*";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(160, 380);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(123, 29);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Location = new System.Drawing.Point(13, 380);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(123, 29);
            this.txtGender.TabIndex = 5;
            this.txtGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(68, 587);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 35);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlCivilStatus
            // 
            this.pnlCivilStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCivilStatus.Controls.Add(this.rbtnWidowed);
            this.pnlCivilStatus.Controls.Add(this.rbtnMarried);
            this.pnlCivilStatus.Controls.Add(this.lblCivilStatus);
            this.pnlCivilStatus.Controls.Add(this.rbtnSingle);
            this.pnlCivilStatus.Controls.Add(this.rbtnSeparated);
            this.pnlCivilStatus.Location = new System.Drawing.Point(13, 426);
            this.pnlCivilStatus.Name = "pnlCivilStatus";
            this.pnlCivilStatus.Size = new System.Drawing.Size(270, 62);
            this.pnlCivilStatus.TabIndex = 12;
            // 
            // rbtnWidowed
            // 
            this.rbtnWidowed.AutoSize = true;
            this.rbtnWidowed.Location = new System.Drawing.Point(192, 31);
            this.rbtnWidowed.Name = "rbtnWidowed";
            this.rbtnWidowed.Size = new System.Drawing.Size(71, 19);
            this.rbtnWidowed.TabIndex = 10;
            this.rbtnWidowed.TabStop = true;
            this.rbtnWidowed.Text = "Widowed";
            this.rbtnWidowed.UseVisualStyleBackColor = true;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(102, 8);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(64, 19);
            this.rbtnMarried.TabIndex = 7;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Married";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivilStatus.Location = new System.Drawing.Point(3, 4);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(99, 21);
            this.lblCivilStatus.TabIndex = 9;
            this.lblCivilStatus.Text = "Civil Status:";
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(192, 6);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(53, 19);
            this.rbtnSingle.TabIndex = 8;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnSeparated
            // 
            this.rbtnSeparated.AutoSize = true;
            this.rbtnSeparated.Location = new System.Drawing.Point(102, 31);
            this.rbtnSeparated.Name = "rbtnSeparated";
            this.rbtnSeparated.Size = new System.Drawing.Size(72, 19);
            this.rbtnSeparated.TabIndex = 9;
            this.rbtnSeparated.TabStop = true;
            this.rbtnSeparated.Text = "Separated";
            this.rbtnSeparated.UseVisualStyleBackColor = true;
            // 
            // pnlPosition
            // 
            this.pnlPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPosition.Controls.Add(this.lblRole);
            this.pnlPosition.Controls.Add(this.rbtnHr);
            this.pnlPosition.Controls.Add(this.rtbStaff);
            this.pnlPosition.Location = new System.Drawing.Point(14, 496);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(270, 36);
            this.pnlPosition.TabIndex = 12;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(3, 4);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(49, 21);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role:";
            // 
            // rbtnHr
            // 
            this.rbtnHr.AutoSize = true;
            this.rbtnHr.Location = new System.Drawing.Point(101, 6);
            this.rbtnHr.Name = "rbtnHr";
            this.rbtnHr.Size = new System.Drawing.Size(42, 19);
            this.rbtnHr.TabIndex = 12;
            this.rbtnHr.TabStop = true;
            this.rbtnHr.Text = "HR";
            this.rbtnHr.UseVisualStyleBackColor = true;
            // 
            // rtbStaff
            // 
            this.rtbStaff.AutoSize = true;
            this.rtbStaff.Location = new System.Drawing.Point(191, 6);
            this.rtbStaff.Name = "rtbStaff";
            this.rtbStaff.Size = new System.Drawing.Size(48, 19);
            this.rtbStaff.TabIndex = 13;
            this.rtbStaff.TabStop = true;
            this.rtbStaff.Text = "Staff";
            this.rtbStaff.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(259, 268);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(20, 21);
            this.dtpBirthdate.TabIndex = 20;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.Location = new System.Drawing.Point(13, 322);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(270, 29);
            this.txtNationality.TabIndex = 4;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.ForeColor = System.Drawing.Color.Black;
            this.txtBirthdate.Location = new System.Drawing.Point(13, 264);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(270, 29);
            this.txtBirthdate.TabIndex = 3;
            this.txtBirthdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtMidInitial
            // 
            this.txtMidInitial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidInitial.ForeColor = System.Drawing.Color.Black;
            this.txtMidInitial.Location = new System.Drawing.Point(13, 150);
            this.txtMidInitial.Name = "txtMidInitial";
            this.txtMidInitial.Size = new System.Drawing.Size(270, 29);
            this.txtMidInitial.TabIndex = 1;
            this.txtMidInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(13, 208);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 29);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(65, 47);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(177, 15);
            this.lblInstruction.TabIndex = 22;
            this.lblInstruction.Text = "Please fill in the information below ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(14, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(269, 29);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddEmployee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddEmployee.Location = new System.Drawing.Point(35, 10);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(232, 34);
            this.lblAddEmployee.TabIndex = 20;
            this.lblAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlDisplayEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayEmployee.Controls.Add(this.dgvEmployeeList);
            this.pnlDisplayEmployee.Controls.Add(this.button1);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnStaffList);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnHumanRes);
            this.pnlDisplayEmployee.Controls.Add(this.lblEmployeeList);
            this.pnlDisplayEmployee.Controls.Add(this.lblViewList);
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(313, 6);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(527, 651);
            this.pnlDisplayEmployee.TabIndex = 3;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmRole,
            this.clmViewDet});
            this.dgvEmployeeList.Location = new System.Drawing.Point(6, 73);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(508, 531);
            this.dgvEmployeeList.TabIndex = 58;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellContentClick);
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmRole
            // 
            this.clmRole.HeaderText = "Role";
            this.clmRole.Name = "clmRole";
            this.clmRole.ReadOnly = true;
            // 
            // clmViewDet
            // 
            this.clmViewDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clmViewDet.HeaderText = "Details";
            this.clmViewDet.Name = "clmViewDet";
            this.clmViewDet.ReadOnly = true;
            this.clmViewDet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmViewDet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmViewDet.Text = "View?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(360, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 57;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rbtnStaffList
            // 
            this.rbtnStaffList.AutoSize = true;
            this.rbtnStaffList.Location = new System.Drawing.Point(401, 49);
            this.rbtnStaffList.Name = "rbtnStaffList";
            this.rbtnStaffList.Size = new System.Drawing.Size(47, 17);
            this.rbtnStaffList.TabIndex = 13;
            this.rbtnStaffList.TabStop = true;
            this.rbtnStaffList.Text = "Staff";
            this.rbtnStaffList.UseVisualStyleBackColor = true;
            // 
            // rbtnHumanRes
            // 
            this.rbtnHumanRes.AutoSize = true;
            this.rbtnHumanRes.Location = new System.Drawing.Point(468, 49);
            this.rbtnHumanRes.Name = "rbtnHumanRes";
            this.rbtnHumanRes.Size = new System.Drawing.Size(41, 17);
            this.rbtnHumanRes.TabIndex = 14;
            this.rbtnHumanRes.TabStop = true;
            this.rbtnHumanRes.Text = "HR";
            this.rbtnHumanRes.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeList.Location = new System.Drawing.Point(17, 10);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(234, 34);
            this.lblEmployeeList.TabIndex = 13;
            this.lblEmployeeList.Text = "EMPLOYEE LIST";
            // 
            // lblViewList
            // 
            this.lblViewList.AutoSize = true;
            this.lblViewList.Location = new System.Drawing.Point(398, 31);
            this.lblViewList.Name = "lblViewList";
            this.lblViewList.Size = new System.Drawing.Size(55, 13);
            this.lblViewList.TabIndex = 0;
            this.lblViewList.Text = "View List?";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 664);
            this.Controls.Add(this.pnlDisplayEmployee);
            this.Controls.Add(this.pnlAddEmployee);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.pnlCivilStatus.ResumeLayout(false);
            this.pnlCivilStatus.PerformLayout();
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            this.pnlDisplayEmployee.ResumeLayout(false);
            this.pnlDisplayEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Panel pnlDisplayEmployee;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.RadioButton rbtnHumanRes;
        private System.Windows.Forms.RadioButton rbtnStaffList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlCivilStatus;
        private System.Windows.Forms.RadioButton rbtnWidowed;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.RadioButton rbtnSeparated;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbtnHr;
        private System.Windows.Forms.RadioButton rtbStaff;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtMidInitial;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblViewList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRole;
        private System.Windows.Forms.DataGridViewButtonColumn clmViewDet;
    }
}