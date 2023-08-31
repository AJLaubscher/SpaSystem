using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spa_Information_System_Group6
{
    public partial class MaintainEmployees : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H0O7SRK\SQLEXPRESS02;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataReader reader;
        SqlCommand command;
        SqlDataAdapter adap;
        DataSet ds;

        public MaintainEmployees()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaintainEmployees_Load(object sender, EventArgs e)
        {
            dbEmp.Visible = false;
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            gbShowAll.Visible = true;
            gbDelete.Visible = false;
            gbAdd.Visible = false;
            gbShowAll.BringToFront();
            showAll();
        }

        private void showAll()
        {
            conn.Open();       //Open the connection
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Employees";         //Display all of the Employee data in the datagridview

            command = new SqlCommand(sql, conn);
            adap.SelectCommand = command;
            adap.Fill(ds, "SourceTable");

            dbEmployees.DataSource = ds;
            dbEmployees.DataMember = "SourceTable";

            conn.Close();      //Close the connection
        }

        private void showAllDel()
        {
            conn.Open();       //Open the connection
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Employees";         //Display all of the Employee data in the datagridview

            command = new SqlCommand(sql, conn);
            adap.SelectCommand = command;
            adap.Fill(ds, "SourceTable");

            dbDelete.DataSource = ds;
            dbDelete.DataMember = "SourceTable";

            conn.Close();      //Close the connection
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDelete_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            try
            {
                dbEmp.Visible = false;
                gbShowAll.Visible = true;
                gbDelete.Visible = false;
                gbAdd.Visible = false;
                gbShowAll.BringToFront();

                conn.Open();     //Open the connection
                conn.Close();      //Close the connection

                MessageBox.Show("Connected Successfully");            //Show connected successfully message

                showAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);          //Display error message
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagement manage = new frmManagement();
            manage.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String empName = txtName.Text;
                String empSurname = txtSurname.Text;
                //String empGender = cmbGender.SelectedItem.ToString();
                String empGender = "";

                if (cmbGender.SelectedItem != null)
                {
                    empGender = cmbGender.SelectedItem.ToString();
                }
                String cellNum = txtCell.Text;
                Boolean administrator = cbAdministrator.Checked;
                String username = txtUsername.Text;
                String password = txtPassword.Text;
                String confirmPassword = txtConfirm.Text;

                if(password == confirmPassword)
                {
                    conn.Open();

                    String sql = $"INSERT INTO Employees(Employee_Name,Employee_Surname,Employee_Gender,Cell_Phone_Number,Administrator,Username,Password,Deleted) VALUES(@Employee_Name,@Employee_Surname,@Employee_Gender,@Cell_Phone_Number,@Administrator,@Username,@Password,@Deleted)";
                    command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Employee_Name", empName);
                    command.Parameters.AddWithValue("@Employee_Surname", empSurname);
                    command.Parameters.AddWithValue("@Employee_Gender", empGender);
                    command.Parameters.AddWithValue("@Cell_Phone_Number", cellNum);
                    command.Parameters.AddWithValue("@Administrator", administrator);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Deleted", false);

                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Employee Added Successfully!");

                    //Show Inserted Employee in dbEmployees
                    gbShowAll.Visible = true;
                    gbDelete.Visible = false;
                    gbAdd.Visible = false;
                    gbShowAll.BringToFront();

                    showAll();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);          //Display error message
            }
        }

        private void clearDetails()     //Clear the update and add form textboxes
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtCell.Text = "";
            txtConfirm.Text = "";
            txtSurname.Text = "";
            txtUsername.Text = "";
            cbAdministrator.Checked = false;
            cmbGender.SelectedIndex = -1;

            txtName.Focus();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            clearDetails();
            dbEmp.Visible = false;
            txtName.Focus();
            btnAdd.BringToFront();
            btnUpdate.SendToBack();
            gbShowAll.Visible = false;
            gbDelete.Visible = false;
            gbAdd.Visible = true;
            gbAdd.BringToFront();
            gbAdd.Text = "Add Employee";
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            clearDetails();
            dbEmp.Visible = true;
            txtName.Focus();
            btnAdd.SendToBack();
            btnUpdate.BringToFront();
            gbShowAll.Visible = false;
            gbDelete.Visible = false;
            gbAdd.Visible = true;
            gbAdd.BringToFront();
            gbAdd.Text = "Update Employees";
            btnAdd.Visible = false;
            btnUpdate.Visible = true;

            conn.Open();       //Open the connection
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Employees";         //Display all of the Employee data in the datagridview

            command = new SqlCommand(sql, conn);
            adap.SelectCommand = command;
            adap.Fill(ds, "SourceTable");

            dbEmp.DataSource = ds;
            dbEmp.DataMember = "SourceTable";

            conn.Close();      //Close the connection
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbEmp.Visible = false;
            gbShowAll.Visible = false;
            gbDelete.Visible = true;
            gbAdd.Visible = false;
            gbDelete.BringToFront();
            txtDelUsername.Text = "";
            txtDelUsername.Focus();
            showAllDel();
        }

        private void dbEmp_SelectionChanged(object sender, EventArgs e)
        {
            if(dbEmp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dbEmp.SelectedRows[0];

                string empName = selectedRow.Cells[0].Value.ToString();
                string empSurname = selectedRow.Cells[1].Value.ToString();
                string empGender = selectedRow.Cells[2].Value.ToString();
                string cellNum = selectedRow.Cells[3].Value.ToString();
                bool administrator = Convert.ToBoolean(selectedRow.Cells[4].Value);
                string username = selectedRow.Cells[5].Value.ToString();
                string password = selectedRow.Cells[6].Value.ToString();

                txtName.Text = empName;
                txtSurname.Text = empSurname;
                cmbGender.SelectedItem = empGender; 
                txtCell.Text = cellNum;
                cbAdministrator.Checked = administrator;
                txtUsername.Text = username;
                txtPassword.Text = password;
                txtConfirm.Text = password;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                string empName = txtName.Text;
                string empSurname = txtSurname.Text;
                string empGender = cmbGender.SelectedItem.ToString(); 
                string cellNum = txtCell.Text;
                bool administrator = cbAdministrator.Checked;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPass = txtConfirm.Text;
                int selectedRowIndex = dbEmp.SelectedCells[0].RowIndex + 1;
                
                if(password == confirmPass)
                {
                    conn.Open();

                    string sql = "UPDATE Employees SET Employee_Name = @Employee_Name, Employee_Surname = @Employee_Surname, " +
                                 "Employee_Gender = @Employee_Gender, Cell_Phone_Number = @Cell_Phone_Number, " +
                                 "Administrator = @Administrator, Username = @Username " +
                                 "WHERE Employee_ID = @EmployeeId";

                    SqlCommand updateCommand = new SqlCommand(sql, conn);
                    updateCommand.Parameters.AddWithValue("@EmployeeId", selectedRowIndex);
                    updateCommand.Parameters.AddWithValue("@Employee_Name", empName);
                    updateCommand.Parameters.AddWithValue("@Employee_Surname", empSurname);
                    updateCommand.Parameters.AddWithValue("@Employee_Gender", empGender);
                    updateCommand.Parameters.AddWithValue("@Cell_Phone_Number", cellNum);
                    updateCommand.Parameters.AddWithValue("@Administrator", administrator);
                    updateCommand.Parameters.AddWithValue("@Username", username);
                    updateCommand.Parameters.AddWithValue("@Password", password);

                    updateCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Employee Updated Successfully!");

                    //Display Updated Employee in dbEmployees
                    gbShowAll.Visible = true;
                    gbDelete.Visible = false;
                    gbAdd.Visible = false;
                    gbShowAll.BringToFront();

                    showAll();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); //Display error message
            }
        }

        private void dbEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int index = e.RowIndex;

                DataGridViewRow row = this.dbEmp.Rows[index];

                string empName = row.Cells[1].Value.ToString();
                string empSurname = row.Cells[2].Value.ToString();
                string empGender = row.Cells[3].Value.ToString();
                string cellNum = row.Cells[4].Value.ToString();
                Boolean administrator = Convert.ToBoolean(row.Cells[5].Value);
                string username = row.Cells[6].Value.ToString();
                string password = row.Cells[7].Value.ToString();

                txtName.Text = empName;
                txtSurname.Text = empSurname;
                cmbGender.SelectedItem = empGender;
                txtCell.Text = cellNum;
                cbAdministrator.Checked = administrator;
                txtUsername.Text = username;
                txtPassword.Text = password;
                txtConfirm.Text = password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            try
                        {
                            string deleteUsername = txtDelUsername.Text;

                            DialogResult result = MessageBox.Show($"Are you sure you want to delete the employee with the username '{deleteUsername}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                conn.Open();

                                string sql = "DELETE FROM Employees WHERE Username = @Username";

                                SqlCommand deleteCommand = new SqlCommand(sql, conn);
                                deleteCommand.Parameters.AddWithValue("@Username", deleteUsername);

                                int rowsAffected = deleteCommand.ExecuteNonQuery();

                                conn.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee Deleted Successfully!");
                                    gbShowAll.Visible = true;
                                    gbDelete.Visible = false;
                                    gbAdd.Visible = false;
                                    gbShowAll.BringToFront();
                                    showAll();
                                }
                                else
                                {
                                    MessageBox.Show("No employee found with the specified username.");
                                }
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message); // Display error message
                        }*/

            try
            {
                string deleteUsername = txtDelUsername.Text;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the employee with the username '{deleteUsername}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    conn.Open();

                    string sql = "UPDATE Employees SET Deleted = 1 WHERE Username = @Username";

                    SqlCommand updateCommand = new SqlCommand(sql, conn);
                    updateCommand.Parameters.AddWithValue("@Username", deleteUsername);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee Deleted Successfully!");
                        gbShowAll.Visible = true;
                        gbDelete.Visible = false;
                        gbAdd.Visible = false;
                        gbShowAll.BringToFront();
                        showAll();
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the specified username.");
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); // Display error message
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*            try
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to delete all employees?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                conn.Open();

                                string sql = "DELETE FROM Employees";

                                SqlCommand deleteAllCommand = new SqlCommand(sql, conn);

                                int rowsAffected = deleteAllCommand.ExecuteNonQuery();

                                conn.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("All Employees Deleted Successfully!");
                                    gbShowAll.Visible = true;
                                    gbDelete.Visible = false;
                                    gbAdd.Visible = false;
                                    gbShowAll.BringToFront();
                                    showAll();
                                }
                                else
                                {
                                    MessageBox.Show("No employees found to delete.");
                                }
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message); // Display error message
                        }*/

            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete all employees?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    conn.Open();

                    string sql = "UPDATE Employees SET Deleted = 1";

                    SqlCommand updateCommand = new SqlCommand(sql, conn);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("All Employees Deleted Successfully!");
                        gbShowAll.Visible = true;
                        gbDelete.Visible = false;
                        gbAdd.Visible = false;
                        gbShowAll.BringToFront();
                        showAll();
                    }
                    else
                    {
                        MessageBox.Show("No employees found.");
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); // Display error message
            }
        }

    }
}
