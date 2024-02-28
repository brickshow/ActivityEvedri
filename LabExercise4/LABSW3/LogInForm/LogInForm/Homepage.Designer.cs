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
            this.picboxDesignTop = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControlDashBoard = new System.Windows.Forms.TabControl();
            this.tabConBodyDashboard = new System.Windows.Forms.TabPage();
            this.tabPageEmployeeManagement = new System.Windows.Forms.TabPage();
            this.ProdManagement = new System.Windows.Forms.TabPage();
            this.tabPageInvmanagement = new System.Windows.Forms.TabPage();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).BeginInit();
            this.tabControlDashBoard.SuspendLayout();
            this.tabConBodyDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.lblProfile);
            this.pnlHeader.Controls.Add(this.btnProfile);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1392, 116);
            this.pnlHeader.TabIndex = 2;
            // 
            // picboxDesignTop
            // 
            this.picboxDesignTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxDesignTop.BackColor = System.Drawing.Color.Black;
            this.picboxDesignTop.Image = ((System.Drawing.Image)(resources.GetObject("picboxDesignTop.Image")));
            this.picboxDesignTop.Location = new System.Drawing.Point(-14, 454);
            this.picboxDesignTop.Name = "picboxDesignTop";
            this.picboxDesignTop.Size = new System.Drawing.Size(1797, 546);
            this.picboxDesignTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDesignTop.TabIndex = 6;
            this.picboxDesignTop.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1297, 86);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tabControlDashBoard
            // 
            this.tabControlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDashBoard.Controls.Add(this.tabConBodyDashboard);
            this.tabControlDashBoard.Controls.Add(this.tabPageEmployeeManagement);
            this.tabControlDashBoard.Controls.Add(this.ProdManagement);
            this.tabControlDashBoard.Controls.Add(this.tabPageInvmanagement);
            this.tabControlDashBoard.Location = new System.Drawing.Point(12, 122);
            this.tabControlDashBoard.Name = "tabControlDashBoard";
            this.tabControlDashBoard.SelectedIndex = 0;
            this.tabControlDashBoard.Size = new System.Drawing.Size(1368, 664);
            this.tabControlDashBoard.TabIndex = 7;
            // 
            // tabConBodyDashboard
            // 
            this.tabConBodyDashboard.BackColor = System.Drawing.Color.Black;
            this.tabConBodyDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabConBodyDashboard.Controls.Add(this.lblDashboard);
            this.tabConBodyDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabConBodyDashboard.Name = "tabConBodyDashboard";
            this.tabConBodyDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabConBodyDashboard.Size = new System.Drawing.Size(1360, 638);
            this.tabConBodyDashboard.TabIndex = 0;
            this.tabConBodyDashboard.Text = "Dashboard";
            // 
            // tabPageEmployeeManagement
            // 
            this.tabPageEmployeeManagement.BackColor = System.Drawing.Color.Black;
            this.tabPageEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEmployeeManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployeeManagement.Name = "tabPageEmployeeManagement";
            this.tabPageEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployeeManagement.Size = new System.Drawing.Size(1360, 638);
            this.tabPageEmployeeManagement.TabIndex = 1;
            this.tabPageEmployeeManagement.Text = "Employee Management";
            // 
            // ProdManagement
            // 
            this.ProdManagement.BackColor = System.Drawing.Color.Black;
            this.ProdManagement.Location = new System.Drawing.Point(4, 22);
            this.ProdManagement.Name = "ProdManagement";
            this.ProdManagement.Size = new System.Drawing.Size(1360, 638);
            this.ProdManagement.TabIndex = 2;
            this.ProdManagement.Text = "Product Management";
            // 
            // tabPageInvmanagement
            // 
            this.tabPageInvmanagement.BackColor = System.Drawing.Color.Black;
            this.tabPageInvmanagement.Location = new System.Drawing.Point(4, 22);
            this.tabPageInvmanagement.Name = "tabPageInvmanagement";
            this.tabPageInvmanagement.Size = new System.Drawing.Size(1360, 638);
            this.tabPageInvmanagement.TabIndex = 3;
            this.tabPageInvmanagement.Text = "Inventory Management";
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Location = new System.Drawing.Point(1319, 10);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(30, 29);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(1308, 42);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(53, 20);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "Profile";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(2, 3);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(131, 29);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(9, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(571, 78);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Welcome to IMS!";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1392, 798);
            this.Controls.Add(this.tabControlDashBoard);
            this.Controls.Add(this.picboxDesignTop);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).EndInit();
            this.tabControlDashBoard.ResumeLayout(false);
            this.tabConBodyDashboard.ResumeLayout(false);
            this.tabConBodyDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picboxDesignTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControlDashBoard;
        private System.Windows.Forms.TabPage tabConBodyDashboard;
        private System.Windows.Forms.TabPage tabPageEmployeeManagement;
        private System.Windows.Forms.TabPage ProdManagement;
        private System.Windows.Forms.TabPage tabPageInvmanagement;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDashboard;
    }
}