namespace LogInForm
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlGroupButton = new System.Windows.Forms.Panel();
            this.btnInvMan = new System.Windows.Forms.Button();
            this.btnProdMan = new System.Windows.Forms.Button();
            this.btnEmpMan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblComparts = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlGroupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.pnlGroupButton);
            this.pnlHeader.Controls.Add(this.lblComparts);
            this.pnlHeader.Controls.Add(this.lblLB);
            this.pnlHeader.Location = new System.Drawing.Point(8, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(244, 719);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlGroupButton
            // 
            this.pnlGroupButton.BackColor = System.Drawing.Color.LightBlue;
            this.pnlGroupButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGroupButton.Controls.Add(this.btnInvMan);
            this.pnlGroupButton.Controls.Add(this.btnProdMan);
            this.pnlGroupButton.Controls.Add(this.btnEmpMan);
            this.pnlGroupButton.Controls.Add(this.btnHome);
            this.pnlGroupButton.Controls.Add(this.btnProfile);
            this.pnlGroupButton.Controls.Add(this.btnLogout);
            this.pnlGroupButton.Controls.Add(this.lblProfile);
            this.pnlGroupButton.Location = new System.Drawing.Point(4, 111);
            this.pnlGroupButton.Name = "pnlGroupButton";
            this.pnlGroupButton.Size = new System.Drawing.Size(230, 598);
            this.pnlGroupButton.TabIndex = 7;
            // 
            // btnInvMan
            // 
            this.btnInvMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInvMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvMan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvMan.ForeColor = System.Drawing.Color.White;
            this.btnInvMan.Image = ((System.Drawing.Image)(resources.GetObject("btnInvMan.Image")));
            this.btnInvMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvMan.Location = new System.Drawing.Point(7, 289);
            this.btnInvMan.Name = "btnInvMan";
            this.btnInvMan.Size = new System.Drawing.Size(204, 47);
            this.btnInvMan.TabIndex = 10;
            this.btnInvMan.Text = "INVENTORY \r\nMANAGEMENT";
            this.btnInvMan.UseVisualStyleBackColor = false;
            // 
            // btnProdMan
            // 
            this.btnProdMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProdMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdMan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdMan.ForeColor = System.Drawing.Color.White;
            this.btnProdMan.Image = ((System.Drawing.Image)(resources.GetObject("btnProdMan.Image")));
            this.btnProdMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdMan.Location = new System.Drawing.Point(7, 225);
            this.btnProdMan.Name = "btnProdMan";
            this.btnProdMan.Size = new System.Drawing.Size(204, 47);
            this.btnProdMan.TabIndex = 9;
            this.btnProdMan.Text = "PRODUCT \r\nMANAGEMENT";
            this.btnProdMan.UseVisualStyleBackColor = false;
            // 
            // btnEmpMan
            // 
            this.btnEmpMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpMan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpMan.ForeColor = System.Drawing.Color.White;
            this.btnEmpMan.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpMan.Image")));
            this.btnEmpMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpMan.Location = new System.Drawing.Point(7, 159);
            this.btnEmpMan.Name = "btnEmpMan";
            this.btnEmpMan.Size = new System.Drawing.Size(204, 47);
            this.btnEmpMan.TabIndex = 8;
            this.btnEmpMan.Text = "EMPLOYEE\r\nMANAGEMENT";
            this.btnEmpMan.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(7, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(204, 47);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Location = new System.Drawing.Point(86, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(46, 50);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(67, 534);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Black;
            this.lblProfile.Location = new System.Drawing.Point(83, 56);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(53, 20);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "Profile";
            // 
            // lblComparts
            // 
            this.lblComparts.AutoSize = true;
            this.lblComparts.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparts.ForeColor = System.Drawing.Color.White;
            this.lblComparts.Location = new System.Drawing.Point(17, 68);
            this.lblComparts.Name = "lblComparts";
            this.lblComparts.Size = new System.Drawing.Size(216, 24);
            this.lblComparts.TabIndex = 7;
            this.lblComparts.Text = "COMPUTER PART STORE";
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Font = new System.Drawing.Font("Arial Black", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLB.Location = new System.Drawing.Point(52, -18);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(147, 101);
            this.lblLB.TabIndex = 7;
            this.lblLB.Text = "LB";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(1207, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Location = new System.Drawing.Point(265, 54);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(985, 673);
            this.pnlMain.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Black;
            this.lblCategory.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(259, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(226, 42);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "DASHBOARD";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 735);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGroupButton.ResumeLayout(false);
            this.pnlGroupButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblComparts;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Panel pnlGroupButton;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmpMan;
        private System.Windows.Forms.Button btnInvMan;
        private System.Windows.Forms.Button btnProdMan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCategory;
    }
}