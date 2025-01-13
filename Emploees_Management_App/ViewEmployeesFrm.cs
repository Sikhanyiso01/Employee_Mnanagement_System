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
    public partial class ViewEmployeesFrm : Form
    {
        public ViewEmployeesFrm()
        {
            InitializeComponent();
        }
        Datahandler dataHandler = new Datahandler();
        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataHandler.SearchEmployee(int.Parse(searchtxt.Text));
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataHandler.GetEmployees();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
