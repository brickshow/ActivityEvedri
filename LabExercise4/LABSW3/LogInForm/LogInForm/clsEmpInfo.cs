using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm 
{
    
    internal class clsEmpInfo
    {
        //Initialize variable
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        private string birthDate { get; set; }
        private string Nationality { get; set; }
        private string gender { get; set; }
        private int age { get; set; }
        private string civilStatus { get; set; }


        //Account Info
        private string role { get; set;}
        private int empID { get; set;}
        private string userName { get; set; }
        private string password { get; set; }
        private string status { get; set; }
        //Method to store data

        // Method to store data
        public static List<clsEmpInfo> listEmployeeData = new List<clsEmpInfo>();

        public clsEmpInfo(string _fname, string _mname, string _lname, string _birthdate, string _nationality, string _gender
            , string _role, int _empID, string _userName, string _password, string _status)
        {
            fName = _fname;
            mName = _mname;
            lName = _lname;
            birthDate = _birthdate;
            Nationality = _nationality;
            gender = _gender;
            role = _role;
            empID = _empID;
            userName = _userName;
            password = _password;
            status = _status;
            
        }

        public static void AddEmployee(string _fname, string _mname, string _lname, string _birthdate, string _nationality, string _gender
            , string _role, int _empID, string _userName, string _password, string _status)
        {
            listEmployeeData.Add(new clsEmpInfo(_fname, _mname, _lname, _birthdate, _nationality, _gender, _role, _empID, _userName, _password,_status));
        }

    }
}