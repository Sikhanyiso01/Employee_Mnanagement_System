using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Emploees_Management_App
{
    internal class Datahandler
    {
        public Datahandler()
        {

        }

        string con = "Data Source= DESKTOP-QR3A0UT\\SQLEXPRESS01; Initial Catalog= EmployeesManagementSystem; Integrated Security= SSPI;";

    
        SqlConnection connect;
        SqlCommand sqlCommand;
        SqlDataAdapter adt;

        public void RegisterEmployee(int empID, string fullName, string gender, string adress, string position, string dOB, string phone, string education)
        {
            string query = $"INSERT INTO Employee VALUES ('{empID}','{fullName}','{gender}','{adress}','{position}','{dOB}','{phone}','{education}')";
            connect = new SqlConnection(con);
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Not Succesful  " + ex.Message);
            }
            finally 
            {
                connect.Close();
            }
        }

        public void UpdateEmployee(int empID, string fullName, string gender, string adress, string position, string dOB, string phone, string education)
        {
            string query = $"UPDATE Employee SET FullName = '{fullName}', Gender = '{gender}', Address = '{adress}', Position = '{position}', DateOfBirth = '{dOB}', Phone = '{phone}', Education = '{education}' WHERE EmployeeID = {empID}";
            connect = new SqlConnection(con);
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updating Succesfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating Not Succesful  " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        public void DeleteEmployee(int empID)
        {
            string query = $"DELETE FROM Employee WHERE EmployeeID = {empID}";
            connect = new SqlConnection(con);
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Not Succesful  " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        public DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Employee";
            connect = new SqlConnection(con);
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            adt = new SqlDataAdapter(sqlCommand);
            adt.Fill(dt);
            connect.Close();
            return dt;
        }
        public DataTable SearchEmployee( int empID)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Employee WHERE EmployeeID = {empID} ";
            connect = new SqlConnection(con);
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            adt = new SqlDataAdapter(sqlCommand);
            adt.Fill(dt);
            connect.Close();
            return dt;
        }
    }
}
