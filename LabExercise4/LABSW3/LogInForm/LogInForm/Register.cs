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
            string birthDate = txtBirthdate.Text;
            string nationality = txtNationality.Text;
            string gender = txtGender.Text;
            int employeeID = 0;
            string userName = txtFirstName.Text;
            string password = txtMidInitial.Text;


          // Add employee
           //    AddEmployee(firstName, middleName, lastName, birthDate, nationality, gender);

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
        private void btnNext_Click(object sender, EventArgs e)
        {
            addData();
        }
    }
}
