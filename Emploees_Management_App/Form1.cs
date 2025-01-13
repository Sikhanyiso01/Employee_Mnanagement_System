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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if(passwordTxt.Text == "" && adminTxt.Text == "")
            {
                MessageBox.Show("Please enter infromation in the empty fields.");
            }
            else if(passwordTxt.Text == "password" && adminTxt.Text == "admin")
            {
               
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter correct information");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            adminTxt.Clear();
            passwordTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
