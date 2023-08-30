using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa_Information_System_Group6
{
    public partial class Maintain_Clients : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NSKM73HE\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;

        public int client_update_ID;             // to store Treatment_ID Primary Key - used for updating a record
        public int client_delete_ID;
        public bool medical_condition;
        public Maintain_Clients()
        {
            InitializeComponent();
        }

        public void displayAll()        // Method to display all data in datagrid on View All tab
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Clients WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                                               // set command for adapter
                adapt.Fill(ds, "Clients");                                               // fill dataset

                // add data to datagrid
                dgvAllClients.DataSource = ds;
                dgvAllClients.DataMember = "Clients";

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }

        public void displayAllUpdate()        // Method to display all data in datagrid on update tab
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Clients WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                                              // set command for adapter
                adapt.Fill(ds, "Clients");                                               // fill dataset

                // add data to datagrid
                dgvUpdateClients.DataSource = ds;
                dgvUpdateClients.DataMember = "Clients";

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }

        public void displayAllDelete()          // Method to display all data in datagrid on update tab
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Clients WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted 
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                      // set command for adapter
                adapt.Fill(ds, "Clients");                       // fill dataset

                // add data to datagrid
                dgvDeleteClients.DataSource = ds;
                dgvDeleteClients.DataMember = "Clients";

                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }

        private void btnDisplayAllClients_Click(object sender, EventArgs e)
        {
            displayAll();       // method to display datagrid in view all tab, refresh the datagrid after a search

            // reset search box
            edtSearchClientName.Text = "";
            edtSearchClientSurname.Text = "";
            edtSearchClientCellNumber.Text = "";
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProviderClients = new ErrorProvider();

            if (edtAddClientName.Text != "")                       // validate input and error providers
            {
                if (edtAddClientSurname.Text != "")
                {
                    if (lblDateOfBirth.Text != "")
                    {
                        if (edtAddClientCellNumber.Text != "")
                        {
                            try
                            {
                                conn.Open();                                                 // open connection

                                // compile query string by retieving values from instance
                                string sqlInsert = $"INSERT INTO Clients Values('{edtAddClientName.Text}', '{edtAddClientSurname.Text}', '{dateTimePicker1.Value}', '{edtAddClientCellNumber.Text}', '{cbxAddClientMedicalCondition.Checked}', '{false}')";

                                command = new SqlCommand(sqlInsert, conn);                   //execute sql statement 
                                adapt = new SqlDataAdapter();

                                adapt.InsertCommand = command;                              // set command for adapter
                                adapt.InsertCommand.ExecuteNonQuery();                      // execute command

                                conn.Close();                                               // close connection
                                MessageBox.Show("New client successfully added");            // notify user if insert was successful 

                                // Clear textboxes
                                edtAddClientName.Text = "";
                                edtAddClientSurname.Text = "";
                                lblDateOfBirth.Text = "";
                                edtAddClientCellNumber.Text = "";
                                cbxAddClientMedicalCondition.Checked = false;
                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show(error.Message);                 // catch error and display message
                            }
                        }
                        else
                        {
                            errorProviderClients.SetError(edtAddClientCellNumber, "Enter the cell number for the client");
                            edtAddClientCellNumber.Text = "";
                            edtAddClientCellNumber.Focus();
                        }
                    }
                    else
                    {
                        errorProviderClients.SetError(lblDateOfBirth, "Select a date of birth for the client");
                        lblDateOfBirth.Text = "";
                    }
                }
                else
                {
                    errorProviderClients.SetError(edtAddClientSurname, "Enter the surname for the client");
                    edtAddClientSurname.Text = "";
                    edtAddClientSurname.Focus();
                }
            }
            else
            {
                errorProviderClients.SetError(edtAddClientName, "Enter the name for the client");
                edtAddClientName.Text = "";
                edtAddClientName.Focus();
            }
        }

        private void btnResetUpdate_Click(object sender, EventArgs e)
        {
            displayAllUpdate();

            edtClientNameSearch.Text = "";
            edtClientSurnameSearch.Text = "";
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProviderClients = new ErrorProvider();

            if (edtNameClient.Text != "")                                         // validate on all text boxes and error providers is textbox is empty
            {
                if (edtCellNumberClient.Text != "")
                {
                    
                    try
                    {
                        conn.Open();        // open connection

                        // compile query string by retieving values from instance
                        string sqlUpdate = $"UPDATE Clients SET Name = '{edtNameClient.Text}', Surname = '{edtSurnameClient.Text}', Cell_Number = '{edtCellNumberClient.Text}', Medical_Condition = '{medical_condition}' WHERE Client_ID LIKE {client_update_ID}"; // compile select query, update the selected record based on the treatment_ID PK

                        command = new SqlCommand(sqlUpdate, conn);          //execute sql statement 
                        adapt = new SqlDataAdapter();

                        adapt.UpdateCommand = command;                      // set command for adapter
                        adapt.UpdateCommand.ExecuteNonQuery();              // execute command

                        conn.Close();                                       // close connection
                        MessageBox.Show("Succesfully updated record");      // notify user if update was successful
                        displayAllUpdate();                                       // refresh datagrid to display updated record

                        // set values to empty string after an update
                        edtNameClient.Text = "";
                        edtSurnameClient.Text = "";
                        lblDateOfBirthClient.Text = "";
                        edtCellNumberClient.Text = "";
                        cbxMedicalCondition.Checked = false;
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);                     // catch error and display message
                    }
                }
                else
                {
                    errorProviderClients.SetError(edtCellNumberClient, "Enter updated cell number for the client");
                    edtCellNumberClient.Text = "";
                    edtCellNumberClient.Focus();
                }
            }
            else
            {
                errorProviderClients.SetError(edtNameClient, "Enter new client name");
                edtNameClient.Text = "";
                edtNameClient.Focus();
            }
        }

        private void btnResetDelete_Click(object sender, EventArgs e)
        {
            displayAllDelete();     // reset searches

            // clear the search box 
            edtSearchClientName.Text = "";
            edtSearchClientSurname.Text = "";
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();        // open connection

                // compile query string by retieving values from instance
                string sqlUpdate = $"UPDATE Clients SET Deleted = '{true}' WHERE Client_ID LIKE {client_delete_ID}"; // update the selected record based on the treatment_ID PK, sets the bit value to true meaning record is deleted (hides record in select statements)

                command = new SqlCommand(sqlUpdate, conn);          //execute sql statement 
                adapt = new SqlDataAdapter();

                adapt.UpdateCommand = command;                      // set command for adapter
                adapt.UpdateCommand.ExecuteNonQuery();              // execute command

                conn.Close();                                       // close connection
                MessageBox.Show("Succesfully deleted record");      // notify user if update was successful
                displayAllDelete();                                       // refresh datagrid to display updated record

                // set labels to empty strings when a record was deleted
                lblClientNameDelete.Text = "";
                lblClientSurnameDelete.Text = "";
                lblClientDateOfBirthDelete.Text = "";
                lblClientCellNumberDelete.Text = "";
                lblClientMedicalConditionDelete.Text = "";
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                     // catch error and display message
            }
        }

        private void dgvDeleteClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dgvDeleteClients.Rows[index];  // cast collum values of row to variable


                client_delete_ID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value from the datagrid selected record

                // retieve values from selected row by specifying the cell index and display in textboxes to be edited
                lblClientNameDelete.Text = row.Cells[1].Value.ToString();
                lblClientSurnameDelete.Text = row.Cells[2].Value.ToString();
                lblClientDateOfBirthDelete.Text = row.Cells[3].Value.ToString();
                lblClientCellNumberDelete.Text = row.Cells[4].Value.ToString();
                lblClientMedicalConditionDelete.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dgvUpdateClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dgvUpdateClients.Rows[index];  // cast collum values of row to variable


                client_update_ID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value from the datagrid selected record

                // retieve values from selected row by specifying the cell index and display in textboxes to be edited
                edtNameClient.Text = row.Cells[1].Value.ToString();
                edtSurnameClient.Text = row.Cells[2].Value.ToString();
                lblDateOfBirthClient.Text = row.Cells[3].Value.ToString();
                edtCellNumberClient.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "True")
                {
                    cbxMedicalCondition.Checked = true;
                }
                else
                {
                    cbxMedicalCondition.Checked = false;
                }
            }
        }

        private void edtSearchClientName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Name LIKE '%{edtSearchClientName.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvAllClients.DataSource = ds;
                dgvAllClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtSearchClientSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Surname LIKE '%{edtSearchClientSurname.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvAllClients.DataSource = ds;
                dgvAllClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtSearchClientCellNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Cell_Number LIKE '%{edtSearchClientCellNumber.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvAllClients.DataSource = ds;
                dgvAllClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtClientNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Name LIKE '%{edtClientNameSearch.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvUpdateClients.DataSource = ds;
                dgvUpdateClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtClientSurnameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Surname LIKE '%{edtClientSurnameSearch.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvUpdateClients.DataSource = ds;
                dgvUpdateClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtClientSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Name LIKE '%{edtClientSearchName.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvDeleteClients.DataSource = ds;
                dgvDeleteClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void edtClientSearchSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Surname LIKE '%{edtClientSearchSurname.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgvDeleteClients.DataSource = ds;
                dgvDeleteClients.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void tabControlTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAll();                       // datagrid on viewAll tab
            displayAllUpdate();                 // datagrid on update tab
            displayAllDelete();                 // datagrid delete tab
        }

        private void Maintain_Clients_Load(object sender, EventArgs e)
        {
            displayAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDateOfBirth.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void cbxMedicalCondition_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMedicalCondition.Checked)
            {
                medical_condition = true;
            }
            else
            {
                medical_condition = false;
            }
        }
    }
}
