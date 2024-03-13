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
        private string fName { get; set; }
        private string mName { get; set; }
        private string lName { get; set; }
        private string birthDate { get; set; }
        private string Nationality { get; set; }
        private string gender { get; set; }
        private int age { get; set; }
        private string civilStatus { get; set; }
        private string role { get; set;}
        private int empID { get; set;}
        private string userName { get; set; }
        private string password { get; set; }
        private string status { get; set; }

        public List<clsEmpInfo> listEmployeeInformation = new List<clsEmpInfo>();

        //Method to store data
        public void storeData(string _fname, string _mname, string _lname, string _birthdate ,string _nationality,
            string _gender, int _age, string _civilStat, string _role, int _empID, string _username, string _password, 
            string _status)
        {
            listEmployeeInformation.Add(fName = _fname, mName = _mname, lName = _lname, birthDate = _birthdate, 
                Nationality = _nationality, gender = _password, age = _age, civilStatus = _civilStat, role = _role
                , empID = _empID, userName = _username, password = password)
        }
    }
}
