using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emploees_Management_App
{
    public partial class employeeFrm : Form
    {
        public employeeFrm()
        {
            InitializeComponent();
        }
        Datahandler datahandler = new Datahandler();
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Employee em = new Employee(
                int.Parse(empIdTxt.Text),
                nameTxt.Text,
                gender.SelectedItem.ToString(),
                addressTxt.Text,
                pos.SelectedItem.ToString(),
                dob.Value.ToString("yyyy-MM-dd"),
                phonetxt.Text,
                edu.SelectedItem.ToString()
                );

            datahandler.RegisterEmployee(
                em.EmpID,
                em.FullName,
                em.Gender,
                em.Adress,
                em.Position,
                em.DOB1,
                em.Phone,
                em.Education
                );

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            datahandler.UpdateEmployee(
                int.Parse(empIdTxt.Text),
                nameTxt.Text,
                gender.SelectedItem.ToString(),
                addressTxt.Text,
                pos.SelectedItem.ToString(),
                dob.Value.ToString("yyyy-MM-dd"),
                phonetxt.Text,
                edu.SelectedItem.ToString()
                                       );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteFrm deleteFrm = new DeleteFrm();
            deleteFrm.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
