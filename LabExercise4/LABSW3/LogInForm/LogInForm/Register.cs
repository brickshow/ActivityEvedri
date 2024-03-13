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
    public partial class Register : Form
    {
        clsEmpInfo employeeInfo;
        public Register()
        {
            InitializeComponent();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control actCtr = ActiveControl;
                if ((TextBox)sender != txtNationality)
                {
                    SelectNextControl(actCtr, true, true, true, true);
                }
                
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }
    }
}
