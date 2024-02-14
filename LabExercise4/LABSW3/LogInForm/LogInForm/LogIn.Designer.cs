namespace LogInForm
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.picboxDesignbottom = new System.Windows.Forms.PictureBox();
            this.picboxDesignTop = new System.Windows.Forms.PictureBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.lblIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignbottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtboxUsername.Location = new System.Drawing.Point(52, 262);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(323, 29);
            this.txtboxUsername.TabIndex = 1;
            this.txtboxUsername.Text = "Username";
            this.txtboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsername_KeyPress);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtboxPassword.Location = new System.Drawing.Point(52, 328);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '•';
            this.txtboxPassword.Size = new System.Drawing.Size(323, 29);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsername_KeyPress);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Aqua;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(142, 417);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(148, 44);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // picboxDesignbottom
            // 
            this.picboxDesignbottom.BackColor = System.Drawing.Color.Transparent;
            this.picboxDesignbottom.Image = ((System.Drawing.Image)(resources.GetObject("picboxDesignbottom.Image")));
            this.picboxDesignbottom.Location = new System.Drawing.Point(-58, 341);
            this.picboxDesignbottom.Name = "picboxDesignbottom";
            this.picboxDesignbottom.Size = new System.Drawing.Size(553, 408);
            this.picboxDesignbottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDesignbottom.TabIndex = 5;
            this.picboxDesignbottom.TabStop = false;
            // 
            // picboxDesignTop
            // 
            this.picboxDesignTop.BackColor = System.Drawing.Color.Transparent;
            this.picboxDesignTop.Image = ((System.Drawing.Image)(resources.GetObject("picboxDesignTop.Image")));
            this.picboxDesignTop.Location = new System.Drawing.Point(-58, -257);
            this.picboxDesignTop.Name = "picboxDesignTop";
            this.picboxDesignTop.Size = new System.Drawing.Size(553, 408);
            this.picboxDesignTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDesignTop.TabIndex = 5;
            this.picboxDesignTop.TabStop = false;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(142, 67);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(148, 144);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 7;
            this.picboxLogo.TabStop = false;
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblIndicator.Location = new System.Drawing.Point(110, 363);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(215, 15);
            this.lblIndicator.TabIndex = 8;
            this.lblIndicator.Text = "Username and password don\'t match!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 617);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.picboxDesignTop);
            this.Controls.Add(this.picboxDesignbottom);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignbottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox picboxDesignbottom;
        private System.Windows.Forms.PictureBox picboxDesignTop;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Label lblIndicator;
    }
}

