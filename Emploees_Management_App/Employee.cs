using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emploees_Management_App
{
    internal class Employee
    {
        private int empID;
        private string fullName;
        private string gender;
        private string adress;
        private string position;
        private string DOB;
        private string phone;
        private string education;

        public Employee(int empID, string fullName, string gender, string adress, string position, string dOB, string phone, string education)
        {
            this.empID = empID;
            this.fullName = fullName;
            this.gender = gender;
            this.adress = adress;
            this.position = position;
            this.DOB = dOB;
            this.phone = phone;
            this.education = education;
        }

        public int EmpID { get => empID; set => empID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Position { get => position; set => position = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Education { get => education; set => education = value; }
    }
}
