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
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.rbtnSup = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.lblPosition = new System.Windows.Forms.Label();
            this.rbtnEmployee = new System.Windows.Forms.RadioButton();
            this.rtbManager = new System.Windows.Forms.RadioButton();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.lblSex = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtConNumber = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtMidInitial = new System.Windows.Forms.TextBox();
            this.txtCurrentAdd = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlDisplayEmployee = new System.Windows.Forms.Panel();
            this.rbtnSupervisorList = new System.Windows.Forms.RadioButton();
            this.rbtnAdminList = new System.Windows.Forms.RadioButton();
            this.gboxList = new System.Windows.Forms.GroupBox();
            this.rbtnEmployeeList = new System.Windows.Forms.RadioButton();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.rbtnManagerList = new System.Windows.Forms.RadioButton();
            this.pnlAddEmployee.SuspendLayout();
            this.pnlPosition.SuspendLayout();
            this.pnlSex.SuspendLayout();
            this.pnlDisplayEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddEmployee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddEmployee.Location = new System.Drawing.Point(68, 10);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(232, 34);
            this.lblAddEmployee.TabIndex = 1;
            this.lblAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddEmployee.Controls.Add(this.btnRegister);
            this.pnlAddEmployee.Controls.Add(this.pnlPosition);
            this.pnlAddEmployee.Controls.Add(this.pnlSex);
            this.pnlAddEmployee.Controls.Add(this.dtpBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtConNumber);
            this.pnlAddEmployee.Controls.Add(this.txtBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtEmailAdd);
            this.pnlAddEmployee.Controls.Add(this.txtMidInitial);
            this.pnlAddEmployee.Controls.Add(this.txtCurrentAdd);
            this.pnlAddEmployee.Controls.Add(this.txtLastName);
            this.pnlAddEmployee.Controls.Add(this.lblInstruction);
            this.pnlAddEmployee.Controls.Add(this.txtFirstName);
            this.pnlAddEmployee.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmployee.Location = new System.Drawing.Point(6, 6);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(371, 651);
            this.pnlAddEmployee.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(101, 587);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(165, 35);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlPosition
            // 
            this.pnlPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPosition.Controls.Add(this.rbtnSup);
            this.pnlPosition.Controls.Add(this.rbtnAdmin);
            this.pnlPosition.Controls.Add(this.lblPosition);
            this.pnlPosition.Controls.Add(this.rbtnEmployee);
            this.pnlPosition.Controls.Add(this.rtbManager);
            this.pnlPosition.Location = new System.Drawing.Point(47, 421);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(270, 62);
            this.pnlPosition.TabIndex = 12;
            // 
            // rbtnSup
            // 
            this.rbtnSup.AutoSize = true;
            this.rbtnSup.Location = new System.Drawing.Point(192, 31);
            this.rbtnSup.Name = "rbtnSup";
            this.rbtnSup.Size = new System.Drawing.Size(75, 17);
            this.rbtnSup.TabIndex = 12;
            this.rbtnSup.TabStop = true;
            this.rbtnSup.Text = "Supervisor";
            this.rbtnSup.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(102, 8);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbtnAdmin.TabIndex = 11;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(3, 4);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(75, 21);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position:";
            // 
            // rbtnEmployee
            // 
            this.rbtnEmployee.AutoSize = true;
            this.rbtnEmployee.Location = new System.Drawing.Point(192, 6);
            this.rbtnEmployee.Name = "rbtnEmployee";
            this.rbtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rbtnEmployee.TabIndex = 10;
            this.rbtnEmployee.TabStop = true;
            this.rbtnEmployee.Text = "Employee";
            this.rbtnEmployee.UseVisualStyleBackColor = true;
            // 
            // rtbManager
            // 
            this.rtbManager.AutoSize = true;
            this.rtbManager.Location = new System.Drawing.Point(102, 31);
            this.rtbManager.Name = "rtbManager";
            this.rtbManager.Size = new System.Drawing.Size(67, 17);
            this.rtbManager.TabIndex = 8;
            this.rtbManager.TabStop = true;
            this.rtbManager.Text = "Manager";
            this.rtbManager.UseVisualStyleBackColor = true;
            // 
            // pnlSex
            // 
            this.pnlSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSex.Controls.Add(this.lblSex);
            this.pnlSex.Controls.Add(this.rbtnFemale);
            this.pnlSex.Controls.Add(this.rbtnMale);
            this.pnlSex.Location = new System.Drawing.Point(47, 380);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(270, 29);
            this.pnlSex.TabIndex = 11;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(3, 4);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(42, 21);
            this.lblSex.TabIndex = 9;
            this.lblSex.Text = "Sex:";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(192, 6);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 10;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(102, 6);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 8;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(293, 207);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(20, 20);
            this.dtpBirthdate.TabIndex = 7;
            // 
            // txtConNumber
            // 
            this.txtConNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtConNumber.Location = new System.Drawing.Point(47, 337);
            this.txtConNumber.Name = "txtConNumber";
            this.txtConNumber.Size = new System.Drawing.Size(270, 29);
            this.txtConNumber.TabIndex = 6;
            this.txtConNumber.Text = "Contact Number";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.ForeColor = System.Drawing.Color.Gray;
            this.txtBirthdate.Location = new System.Drawing.Point(47, 203);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(270, 29);
            this.txtBirthdate.TabIndex = 7;
            this.txtBirthdate.Text = "Birthdate";
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailAdd.Location = new System.Drawing.Point(47, 292);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(270, 29);
            this.txtEmailAdd.TabIndex = 5;
            this.txtEmailAdd.Text = "Email Address";
            // 
            // txtMidInitial
            // 
            this.txtMidInitial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidInitial.ForeColor = System.Drawing.Color.Gray;
            this.txtMidInitial.Location = new System.Drawing.Point(277, 115);
            this.txtMidInitial.Name = "txtMidInitial";
            this.txtMidInitial.Size = new System.Drawing.Size(40, 29);
            this.txtMidInitial.TabIndex = 4;
            this.txtMidInitial.Text = "MI";
            this.txtMidInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentAdd
            // 
            this.txtCurrentAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAdd.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrentAdd.Location = new System.Drawing.Point(47, 247);
            this.txtCurrentAdd.Name = "txtCurrentAdd";
            this.txtCurrentAdd.Size = new System.Drawing.Size(270, 29);
            this.txtCurrentAdd.TabIndex = 3;
            this.txtCurrentAdd.Text = "Current Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(47, 159);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 29);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(98, 66);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(168, 13);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Please fill in the information below ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(47, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(222, 29);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlDisplayEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayEmployee.Controls.Add(this.rbtnSupervisorList);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnAdminList);
            this.pnlDisplayEmployee.Controls.Add(this.gboxList);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnEmployeeList);
            this.pnlDisplayEmployee.Controls.Add(this.lblEmployeeList);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnManagerList);
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(383, 6);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(596, 651);
            this.pnlDisplayEmployee.TabIndex = 3;
            // 
            // rbtnSupervisorList
            // 
            this.rbtnSupervisorList.AutoSize = true;
            this.rbtnSupervisorList.Location = new System.Drawing.Point(469, 43);
            this.rbtnSupervisorList.Name = "rbtnSupervisorList";
            this.rbtnSupervisorList.Size = new System.Drawing.Size(75, 17);
            this.rbtnSupervisorList.TabIndex = 16;
            this.rbtnSupervisorList.TabStop = true;
            this.rbtnSupervisorList.Text = "Supervisor";
            this.rbtnSupervisorList.UseVisualStyleBackColor = true;
            // 
            // rbtnAdminList
            // 
            this.rbtnAdminList.AutoSize = true;
            this.rbtnAdminList.Location = new System.Drawing.Point(318, 10);
            this.rbtnAdminList.Name = "rbtnAdminList";
            this.rbtnAdminList.Size = new System.Drawing.Size(54, 17);
            this.rbtnAdminList.TabIndex = 15;
            this.rbtnAdminList.TabStop = true;
            this.rbtnAdminList.Text = "Admin";
            this.rbtnAdminList.UseVisualStyleBackColor = true;
            // 
            // gboxList
            // 
            this.gboxList.BackColor = System.Drawing.Color.Black;
            this.gboxList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxList.ForeColor = System.Drawing.Color.White;
            this.gboxList.Location = new System.Drawing.Point(17, 66);
            this.gboxList.Name = "gboxList";
            this.gboxList.Size = new System.Drawing.Size(559, 566);
            this.gboxList.TabIndex = 14;
            this.gboxList.TabStop = false;
            this.gboxList.Text = "Employee";
            // 
            // rbtnEmployeeList
            // 
            this.rbtnEmployeeList.AutoSize = true;
            this.rbtnEmployeeList.Location = new System.Drawing.Point(469, 8);
            this.rbtnEmployeeList.Name = "rbtnEmployeeList";
            this.rbtnEmployeeList.Size = new System.Drawing.Size(71, 17);
            this.rbtnEmployeeList.TabIndex = 14;
            this.rbtnEmployeeList.TabStop = true;
            this.rbtnEmployeeList.Text = "Employee";
            this.rbtnEmployeeList.UseVisualStyleBackColor = true;
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
            // rbtnManagerList
            // 
            this.rbtnManagerList.AutoSize = true;
            this.rbtnManagerList.Location = new System.Drawing.Point(318, 43);
            this.rbtnManagerList.Name = "rbtnManagerList";
            this.rbtnManagerList.Size = new System.Drawing.Size(67, 17);
            this.rbtnManagerList.TabIndex = 13;
            this.rbtnManagerList.TabStop = true;
            this.rbtnManagerList.Text = "Manager";
            this.rbtnManagerList.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(985, 664);
            this.Controls.Add(this.pnlDisplayEmployee);
            this.Controls.Add(this.pnlAddEmployee);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.pnlDisplayEmployee.ResumeLayout(false);
            this.pnlDisplayEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Panel pnlDisplayEmployee;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtCurrentAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMidInitial;
        private System.Windows.Forms.TextBox txtConNumber;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.RadioButton rbtnEmployee;
        private System.Windows.Forms.RadioButton rtbManager;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.RadioButton rbtnSup;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.GroupBox gboxList;
        private System.Windows.Forms.RadioButton rbtnSupervisorList;
        private System.Windows.Forms.RadioButton rbtnAdminList;
        private System.Windows.Forms.RadioButton rbtnEmployeeList;
        private System.Windows.Forms.RadioButton rbtnManagerList;
    }
}