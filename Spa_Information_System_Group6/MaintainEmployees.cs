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
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adap;
        DataSet ds;

        public bool administrator;
        public int employee_UpdatePK;
        public MaintainEmployees()
        {
            InitializeComponent();
        }
        private void showAll()
        {
            conn.Open();       //Open the connection
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = $"SELECT * FROM Employees WHERE Deleted = '{0}'";         //Display all of the Employee data in the datagridview

            command = new SqlCommand(sql, conn);
            adap.SelectCommand = command;
            adap.Fill(ds, "SourceTable");

            dbEmployees.DataSource = ds;
            dbEmployees.DataMember = "SourceTable";

            conn.Close();      //Close the connection
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

        private void showAllDel()
        {
            conn.Open();       //Open the connection
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = $"SELECT * FROM Employees WHERE Deleted = '{0}'";         //Display all of the Employee data in the datagridview

            command = new SqlCommand(sql, conn);
            adap.SelectCommand = command;
            adap.Fill(ds, "SourceTable");

            dbDelete.DataSource = ds;
            dbDelete.DataMember = "SourceTable";

            conn.Close();      //Close the connection
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (txtSurname.Text != "")
                {
                    if (txtCell.Text != "")
                    {
                        if (txtUsername.Text != "")
                        {
                            if (cmbGender.SelectedIndex != -1)
                            {
                                if (txtPassword.Text != "")
                                {
                                    if (txtConfirm.Text != "")
                                    {
                                        if (txtConfirm.Text == txtPassword.Text)
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

                                                if (password == confirmPassword)
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
                                        else
                                        {
                                            errorProviderEmployees.SetError(txtConfirm, "Password do not match");
                                            txtConfirm.Text = "";
                                            txtConfirm.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderEmployees.SetError(txtConfirm, "confirm password");
                                        txtConfirm.Text = "";
                                        txtConfirm.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderEmployees.SetError(txtPassword, "Enter a password");
                                    txtPassword.Text = "";
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                errorProviderEmployees.SetError(cmbGender, "Select Gender");
                            }
                        }
                        else
                        {
                            errorProviderEmployees.SetError(txtUsername, "Enter username");
                            txtUsername.Text = "";
                            txtUsername.Focus();
                        }

                    }
                    else
                    {
                        errorProviderEmployees.SetError(txtCell, "Enter a cell number");
                        txtCell.Text = "";
                        txtCell.Focus();
                    }
                }
                else
                {
                    errorProviderEmployees.SetError(txtSurname, "Enter a surname");
                    txtSurname.Text = "";
                    txtSurname.Focus();
                }
            }
            else
            {
                errorProviderEmployees.SetError(txtName, "Enter a name");
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (txtSurname.Text != "")
                {
                    if (txtCell.Text != "")
                    {
                        if (txtUsername.Text != "")
                        {
                            if (cmbGender.SelectedIndex != -1)
                            {
                                if (txtPassword.Text != "")
                                {
                                    if (txtConfirm.Text != "")
                                    {
                                        if (txtConfirm.Text == txtPassword.Text)
                                        {
                                            try
                                            {

                                                string empName = txtName.Text;
                                                string empSurname = txtSurname.Text;
                                                string empGender = cmbGender.SelectedItem.ToString();
                                                string cellNum = txtCell.Text;
                                                //bool administrator;// = cbAdministrator.Checked;
                                                string username = txtUsername.Text;
                                                string password = txtPassword.Text;
                                                string confirmPass = txtConfirm.Text;
                                                int selectedRowIndex = dbEmp.SelectedCells[0].RowIndex + 1;

                                                if (password == confirmPass)
                                                {
                                                    conn.Open();

                                                    string sql = $"UPDATE Employees SET Employee_Name = '{empName}', Employee_Surname = '{empSurname}', Employee_Gender = '{empGender}', " +
                                                        $"Cell_Phone_Number = '{cellNum}', Administrator = '{administrator}', Username = '{username}'" +
                                                        $" WHERE Employee_ID LIKE '{employee_UpdatePK}'";

                                                    SqlCommand updateCommand = new SqlCommand(sql, conn);

                                                    updateCommand.ExecuteNonQuery();

                                                    conn.Close();

                                                    MessageBox.Show("Employee Updated Successfully!");

                                                    //Display Updated Employee in dbEmployees
                                                    gbShowAll.Visible = true;
                                                    gbDelete.Visible = false;
                                                    gbAdd.Visible = false;
                                                    gbShowAll.BringToFront();
                                                    dbEmp.Visible = false;

                                                    showAll();
                                                }
                                            }
                                            catch (SqlException error)
                                            {
                                                MessageBox.Show(error.Message); //Display error message
                                            }

                                        }
                                        else
                                        {
                                            errorProviderEmployees.SetError(txtConfirm, "Password do not match");
                                            txtConfirm.Text = "";
                                            txtConfirm.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderEmployees.SetError(txtConfirm, "confirm password");
                                        txtConfirm.Text = "";
                                        txtConfirm.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderEmployees.SetError(txtPassword, "Enter a password");
                                    txtPassword.Text = "";
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                errorProviderEmployees.SetError(cmbGender, "Select Gender");
                            }
                        }
                        else
                        {
                            errorProviderEmployees.SetError(txtUsername, "Enter username");
                            txtUsername.Text = "";
                            txtUsername.Focus();
                        }

                    }
                    else
                    {
                        errorProviderEmployees.SetError(txtCell, "Enter a cell number");
                        txtCell.Text = "";
                        txtCell.Focus();
                    }
                }
                else
                {
                    errorProviderEmployees.SetError(txtSurname, "Enter a surname");
                    txtSurname.Text = "";
                    txtSurname.Focus();
                }
            }
            else
            {
                errorProviderEmployees.SetError(txtName, "Enter a name");
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdministrator.Checked == true)
            {
                administrator = true;
            }
            else
            {
                administrator = false;
            }
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

            string sql = $"SELECT * FROM Employees WHERE Deleted = '{0}'";         //Display all of the Employee data in the datagridview

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

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void dbEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int totalRows = dbEmp.RowCount;
                int index = e.RowIndex;

                DataGridViewRow row = this.dbEmp.Rows[index];

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please selecte a filled record");
                }
                else
                {
                    employee_UpdatePK = int.Parse(row.Cells[0].Value.ToString());

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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
