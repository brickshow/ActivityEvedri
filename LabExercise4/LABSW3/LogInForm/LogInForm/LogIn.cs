using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lblIndicator.Hide();
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter) 
            {
                Control ctrNext = ActiveControl;
                if (ctrNext == txtboxPassword) logIn();
                SelectNextControl(ctrNext,true, false, true, true);
            } 
        }

        //Log In method
        public void logIn()
        {
            if (txtboxUsername.Text == "admin" && txtboxPassword.Text == "admin") MessageBox.Show("Successfully Logged In");
            else lblIndicator.Show(); txtboxUsername.Focus();
        }
    }
}
