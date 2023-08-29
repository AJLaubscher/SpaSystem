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
    public partial class Maintain_Treatments : Form
    {
        // Global sql connection
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;

        // variables used in statements
        public double price;                    // store price of treatment
        public int duration;                    // store duration of treatment
        public int treat_update_ID;             // to store Treatment_ID Primary Key - used for updating a record
        public int treat_delete_ID;             // to store Treatment_ID Primary Key - used for "deleting"/ updating a record


        public Maintain_Treatments()
        {
            InitializeComponent();
        }

        public void displayAll()        // Method to display all data in datagrid on View All tab
        {
            try
            {
                // open connection
                conn.Open();                                        
                string sqlQuery = $"SELECT * FROM Treatments WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                                               // set command for adapter
                adapt.Fill(ds, "Treatments");                                               // fill dataset

                // add data to datagrid
                dataGridViewAllTreatments.DataSource = ds;
                dataGridViewAllTreatments.DataMember = "Treatments";

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
                string sqlQuery = $"SELECT * FROM Treatments WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                                              // set command for adapter
                adapt.Fill(ds, "Treatments");                                               // fill dataset

                // add data to datagrid
                dGrdViewUptTreat.DataSource = ds;
                dGrdViewUptTreat.DataMember = "Treatments";

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
                string sqlQuery = $"SELECT * FROM Treatments WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted 
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                      // set command for adapter
                adapt.Fill(ds, "Treatments");                       // fill dataset

                // add data to datagrid
                dataGridViewDelete.DataSource = ds;
                dataGridViewDelete.DataMember = "Treatments";

                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }

        public void populateComboBox()      // populates combobox used for searching on view all tab
        {
            try
            {
                conn.Open();                                        // open connection
                string sqlQuery = $"SELECT _Type FROM Treatments";      // compile select query 
                command = new SqlCommand(sqlQuery, conn);               // execute statement against given datasource
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!cmboBoxTeatments.Items.Contains(reader.GetValue(0)))       // ignore if item is allready in combobox (no duplication)
                    {
                        cmboBoxTeatments.Items.Add(reader.GetValue(0));
                    }
                }
                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }

        public void populateComboBoxUpd()           // populates combobox used for searching on update tab
        {
            try
            {
                conn.Open();                                        // open connection
                string sqlQuery = $"SELECT _Type FROM Treatments";      // compile select query 
                command = new SqlCommand(sqlQuery, conn);               // execute statement against given datasource
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!cmbType.Items.Contains(reader.GetValue(0)))       // ignore if item is allready in combobox (no duplication)
                    {
                        cmbType.Items.Add(reader.GetValue(0));
                    }
                }
                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }
        public void populateComboBoxDlT()           // populates combobox used for searching on delete tab
        {
            try
            {
                conn.Open();                                        // open connection
                string sqlQuery = $"SELECT _Type FROM Treatments";      // compile select query 
                command = new SqlCommand(sqlQuery, conn);               // execute statement against given datasource
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!cmboDelete.Items.Contains(reader.GetValue(0)))       // ignore if item is allready in combobox (no duplication)
                    {
                        cmboDelete.Items.Add(reader.GetValue(0));
                    }
                }
                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }

        private void Maintain_Treatments_Load(object sender, EventArgs e)
        {   // call when loading form
            displayAll();
            populateComboBox();
        }

        private void tabControlTreatments_SelectedIndexChanged(object sender, EventArgs e)  // call when index of tab changes
        {
            displayAll();                       // datagrid on viewAll tab
            populateComboBox();                 // combobox on view all tab
            displayAllUpdate();                 // datagrid on update tab
            populateComboBoxUpd();              // combobox update tab
            displayAllDelete();                 // datagrid delete tab
            populateComboBoxDlT();              // combobox delete tab
        }

        private void textBoxSearchTreatments_TextChanged(object sender, EventArgs e)   // search according to treatment name on view all tab
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txbxSearchTreatments.Text}%' AND Deleted LIKE '{0}'"; // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Treatments");                            //fill dataset

                // fill datagrid
                dataGridViewAllTreatments.DataSource = ds;
                dataGridViewAllTreatments.DataMember = "Treatments";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void cmboBoxTeatments_SelectedIndexChanged(object sender, EventArgs e) // Search treatments on view All tab
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{cmboBoxTeatments.SelectedItem.ToString()}%' AND Deleted LIKE '{0}'"; // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlSearch, conn);   // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;              // set command to adapter
                adapt.Fill(ds, "Treatments");               //fill dataset

                // fill datagrid
                dataGridViewAllTreatments.DataSource = ds;
                dataGridViewAllTreatments.DataMember = "Treatments";

                conn.Close();                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);             // catch error and display message
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayAll();       // method to display datagrid in view all tab, refresh the datagrid after a search
        }

        private void btnUpdate_Click(object sender, EventArgs e)            // update Treatment record on button click
        {
            if(txbxName.Text != "")                                         // validate on all text boxes and error providers is textbox is empty
            {
                if(double.TryParse(txbxPrice.Text, out price))
                {
                    if(int.TryParse(txbxDuration.Text, out duration))
                    {
                        try
                        {
                            conn.Open();        // open connection

                            // compile query string by retieving values from instance
                            string sqlUpdate = $"UPDATE Treatments SET Name = '{txbxName.Text}', Cost_Price = '{price}', Duration = {duration} WHERE Treatment_ID LIKE {treat_update_ID}"; // compile select query, update the selected record based on the treatment_ID PK

                            command = new SqlCommand(sqlUpdate, conn);          //execute sql statement 
                            adapt = new SqlDataAdapter();

                            adapt.UpdateCommand = command;                      // set command for adapter
                            adapt.UpdateCommand.ExecuteNonQuery();              // execute command

                            conn.Close();                                       // close connection
                            MessageBox.Show("Succesfully updated record");      // notify user if update was successful
                            displayAllUpdate();                                       // refresh datagrid to display updated record

                            // set values to empty string after an update
                            lblType.Text = "";
                            txbxName.Text = "";
                            txbxPrice.Text = "";
                            txbxDuration.Text = "";
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message);                     // catch error and display message
                        }
                    }
                    else
                    {
                        errorProviderTreatments.SetError(txbxDuration, "Enter the duration for the treatment");
                    }
                }
                else
                {
                    errorProviderTreatments.SetError(txbxPrice, "Enter updated price for the treatment");
                    txbxPrice.Text = "";
                    txbxPrice.Focus();
                }
            }
            else
            {
                errorProviderTreatments.SetError(txbxName, "Enter new treatment name");
                txbxName.Text = "";
                txbxName.Focus();
            }
        }

        private void dGrdViewUptTreat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dGrdViewUptTreat.Rows[index];  // cast collum values of row to variable


                treat_update_ID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value

                // retieve values from selected row by specifying the cell index and display in textboxes to be edited
                lblType.Text = row.Cells[1].Value.ToString();
                txbxName.Text = row.Cells[2].Value.ToString();
                txbxPrice.Text = row.Cells[3].Value.ToString();
                txbxDuration.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txbxSrchName_TextChanged(object sender, EventArgs e)       // search treatment name on update tab
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txbxSrchName.Text}%' AND Deleted LIKE '{0}'";
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Treatments");                            //fill dataset

                // fill datagrid
                dGrdViewUptTreat.DataSource = ds;
                dGrdViewUptTreat.DataMember = "Treatments";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)   // search combobox on update tab
        {
            if(cmbType.SelectedIndex != -1)
            {
                try
                {
                    conn.Open();
                    // sql select statment
                    string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{cmbType.SelectedItem.ToString()}%' AND Deleted LIKE '{0}'";
                    command = new SqlCommand(sqlSearch, conn);   // execute statement against given datasource
                    adapt = new SqlDataAdapter();
                    ds = new DataSet();

                    adapt.SelectCommand = command;              // set command to adapter
                    adapt.Fill(ds, "Treatments");               //fill dataset

                    // fill datagrid
                    dGrdViewUptTreat.DataSource = ds;
                    dGrdViewUptTreat.DataMember = "Treatments";

                    conn.Close();                               // close connection
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);             // catch error and display message
                }
            }
        }

        private void cmbx_Type_SelectedIndexChanged(object sender, EventArgs e)     // selects item in add treatment tab
        {
            if(cmbx_Type.SelectedIndex != -1)
            {
                cmbx_Type.SelectedItem.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)       // adding a new record on add client tab
        {
            if(cmbx_Type.SelectedIndex != -1)                       // validate input and error providers
            {
                if(txbxNameAdd.Text != "")
                {
                    if(double.TryParse(txbxPriceAdd.Text, out price))
                    {
                        if(int.TryParse(txbxDurationAdd.Text, out duration))
                        {
                            try
                            {
                                conn.Open();                                                 // open connection

                                // compile query string by retieving values from instance
                                string sqlInsert = $"INSERT INTO Treatments Values('{cmbx_Type.SelectedItem.ToString()}', '{txbxNameAdd.Text}', {txbxPriceAdd.Text}, {txbxDurationAdd.Text}, '{false}')";

                                command = new SqlCommand(sqlInsert, conn);                   //execute sql statement 
                                adapt = new SqlDataAdapter();

                                adapt.InsertCommand = command;                              // set command for adapter
                                adapt.InsertCommand.ExecuteNonQuery();                      // execute command

                                conn.Close();                                               // close connection
                                MessageBox.Show("New treatment successfully added");            // notify user if insert was successful 

                                // Clear textboxes
                                txbxNameAdd.Text = "";
                                txbxPriceAdd.Text = "";
                                txbxDurationAdd.Text = "";

                                cmbx_Type.SelectedIndex = -1;   // return to default


                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show(error.Message);                 // catch error and display message
                            }
                        }
                        else
                        {
                            errorProviderTreatments.SetError(txbxDurationAdd, "Enter the duration for the treatment");
                            txbxDurationAdd.Text = "";
                            txbxDurationAdd.Focus();
                        }

                    }
                    else
                    {
                        errorProviderTreatments.SetError(txbxPriceAdd, "Enter a price for the treatment");
                        txbxPriceAdd.Text = "";
                        txbxPriceAdd.Focus();
                    }
                }
                else
                {
                    errorProviderTreatments.SetError(txbxNameAdd, "Enter the treatment name");
                    txbxNameAdd.Text = "";
                    txbxNameAdd.Focus();
                }
            }
            else
            {
                errorProviderTreatments.SetError(cmbx_Type, "Select the type of Treatment");
            }
        }



        // selects record, populate labels to indicate selected field and pass Primary key ID to the variable used to update the record
        private void dataGridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dataGridViewDelete.Rows[index];  // cast collum values of row to variable


                treat_delete_ID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value from the datagrid selected record

                // retieve values from selected row by specifying the cell index and display in textboxes to be edited
                lblType_Del.Text = row.Cells[1].Value.ToString();
                lblName_Del.Text = row.Cells[2].Value.ToString();
                lblPrice_Del.Text = row.Cells[3].Value.ToString();
                lblDur_Del.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)       // Deleting a record
        {
            try
            {
                conn.Open();        // open connection

                // compile query string by retieving values from instance
                string sqlUpdate = $"UPDATE Treatments SET Deleted = '{true}' WHERE Treatment_ID LIKE {treat_delete_ID}"; // update the selected record based on the treatment_ID PK, sets the bit value to true meaning record is deleted (hides record in select statements)

                command = new SqlCommand(sqlUpdate, conn);          //execute sql statement 
                adapt = new SqlDataAdapter();

                adapt.UpdateCommand = command;                      // set command for adapter
                adapt.UpdateCommand.ExecuteNonQuery();              // execute command

                conn.Close();                                       // close connection
                MessageBox.Show("Succesfully deleted record");      // notify user if update was successful
                displayAllDelete();                                       // refresh datagrid to display updated record

                // set labels to empty strings when a record was deleted
                lblType.Text = "";
                lblName_Del.Text = "";
                lblPrice_Del.Text = "";
                lblDur_Del.Text = "";
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                     // catch error and display message
            }
        }

        private void txbxSrchDelete_TextChanged(object sender, EventArgs e) // search on deleted tab, according to name textbox
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txbxSrchDelete.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Treatments");                            //fill dataset

                // fill datagrid
                dataGridViewDelete.DataSource = ds;
                dataGridViewDelete.DataMember = "Treatments";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void cmboDelete_SelectedIndexChanged(object sender, EventArgs e)        // search combobox on delete tab
        {
            if (cmboDelete.SelectedIndex != -1)
            {
                try
                {
                    conn.Open();
                    // sql select statment
                    string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{cmboDelete.SelectedItem.ToString()}%' AND Deleted LIKE '{0}'";
                    command = new SqlCommand(sqlSearch, conn);   // execute statement against given datasource
                    adapt = new SqlDataAdapter();
                    ds = new DataSet();

                    adapt.SelectCommand = command;              // set command to adapter
                    adapt.Fill(ds, "Treatments");               //fill dataset

                    // fill datagrid
                    dataGridViewDelete.DataSource = ds;
                    dataGridViewDelete.DataMember = "Treatments";

                    conn.Close();                               // close connection
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);             // catch error and display message
                }
            }
        }

        private void btnResetDelete_Click(object sender, EventArgs e)
        {
            displayAllDelete();     // reset searches

            // clear the search box and combobox
            txbxSrchDelete.Text = "";
            cmboDelete.SelectedIndex = -1;

        }
    }
}
