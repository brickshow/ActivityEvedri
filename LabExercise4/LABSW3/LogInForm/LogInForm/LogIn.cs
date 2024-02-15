using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            //Error Indicator
            lblIndicator.Hide();
            lblEmptyPass.Hide();
            lblEmptyUser.Hide();

            //Code by using lambda expressions directly as event handlers
            txtboxUsername.Enter += (sender, e) => {
                if (txtboxUsername.Text == "Username")
                {
                    txtboxUsername.Clear();
                    txtboxUsername.ForeColor = SystemColors.ControlText;
                }
            };
            txtboxUsername.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(txtboxUsername.Text))
                {
                    txtboxUsername.Text = "Username";
                    txtboxUsername.ForeColor = SystemColors.GrayText;
                }
            };
            txtboxPassword.Enter += (sender, e) => {
                if (txtboxPassword.Text == "Password")
                {
                    txtboxPassword.Clear();
                    txtboxPassword.ForeColor = SystemColors.ControlText;
                }
            };
            txtboxPassword.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
                {
                    txtboxPassword.Text = "Password";
                    txtboxPassword.ForeColor = SystemColors.GrayText;
                }
            };

            //Lambda expression for show and hide password
            pboxPassworShow.MouseDown += (sender, e) =>
            {
                txtboxPassword.PasswordChar = '\0';
                pboxHidePassword.BringToFront();
            };
            pboxPassworShow.MouseUp += (sender, e) =>
            {
                pboxPassworShow.BringToFront();
                txtboxPassword.PasswordChar = '•';
            };

            this.KeyPreview = true;//Enable the key preview for the form
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter) 
            {
                Control actCtr = ActiveControl;
                if (actCtr == txtboxPassword) logIn();
                SelectNextControl(actCtr, true, true, true, true);
            } 
        }

        //Log In method
        public void logIn()
        {
            if (txtboxUsername.Text == "admin" && txtboxPassword.Text == "admin")
                MessageBox.Show("Successfully Logged In");
            else if (txtboxUsername.Text == "") lblEmptyUser.Show();
            else if (txtboxPassword.Text == "") lblEmptyPass.Show();
            else lblIndicator.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Do the log in Using button
            logIn();
        }

        private void LogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the user used escape keys
            if (e.KeyChar == (char)Keys.Escape)
            {
                //Show a confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                //Check if the user confirm using OK button
                if (result == DialogResult.OK) this.Close(); 
            }
        }
    }
}
