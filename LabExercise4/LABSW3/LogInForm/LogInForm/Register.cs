using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Register : Form
    {
        private List<clsEmpInfo> listEmployeeData = new List<clsEmpInfo>();
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
                else addData();
            }
        }

        //Add data
        public void addData()
        {
            // Retrieve user input from text boxes
            string firstName = txtFirstName.Text;
            string middleName = txtMidInitial.Text;
            string lastName = txtLastName.Text;
            string birthDate = dtpBirthdate.Value.ToString("MMMM dd, yyyy");
            string nationality = txtNationality.Text;
            string gender = txtGender.Text;
            int age = DateTime.Today.Year - dtpBirthdate.Value.Year;
            int employeeID = 0;
            

            //Display the user choices
            string civilStat;
            if (rbtnMarried.Checked) civilStat = rbtnMarried.Text;
            else if (rbtnSeparated.Checked) civilStat = rbtnSeparated.Text;
            else if (rbtnSingle.Checked) civilStat = rbtnSingle.Text;
            else if (rbtnWidowed.Checked) civilStat = rbtnWidowed.Text;

            //Display the role
            string role;
            if (rtbStaff.Checked) role = rtbStaff.Text;
            else role = rbtnHr.Text;



            //Add employee
              //  AddEmployee(firstName, middleName, lastName, birthDate, nationality, gender, role,employeeID,);

            //
            var namesList = listEmployeeData.Select(person => person.fName + " " + person.mName + " " + person.lName);

            lboxNames.DataSource = namesList.ToList();
            // dgvEmployeeList.DataSource = listEmployeeData;

            //Display the name of the employee



        }

        //Method to add data
        private void AddEmployee(string _fname, string _mname, string _lname, string _birthdate, string _nationality, string _gender
             , string _role, int _empID, string _userName, string _password, string _status)
        {
            listEmployeeData.Add(new clsEmpInfo(_fname, _mname, _lname, _birthdate, _nationality, _gender, _role, _empID, _userName, _password, _status));
        }
        private void Register_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        //Next Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            addData();
        }


        //Display the date
        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            txtBirthdate.Text = dtpBirthdate.Value.ToString("MMMM dd, yyyy");
        

            if (dtpBirthdate.Value > DateTime.Today)
            {
                lblBdate.Text = "Date must be less than the current date";
                lblBdate.ForeColor = Color.Red;
            }
            else
            {
                var tempAge = (DateTime.Today.Year - dtpBirthdate.Value.Year) - 1;
                lblBdate.Text = "Brithdate*";
                lblBdate.ForeColor = Color.White;
                txtAge.Text = tempAge.ToString();
            }
            
        }

        private void pnlAddEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

