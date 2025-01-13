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
    public partial class DeleteFrm : Form
    {
        public DeleteFrm()
        {
            InitializeComponent();
        }
        Datahandler dataHandler = new Datahandler();
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dataHandler.DeleteEmployee(int.Parse(deletetxt.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
