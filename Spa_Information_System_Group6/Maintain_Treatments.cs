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

        // variables
        public double price;
        public int duration;
        public int treat_update_ID;


        public Maintain_Treatments()
        {
            InitializeComponent();
        }

        public void displayAll()        // Method to display all data in datagrid
        {
            try
            {
                conn.Open();                                        // open connection
                string sqlQuery = $"SELECT * FROM Treatments";      // compile select query 
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                      // set command for adapter
                adapt.Fill(ds, "Treatments");                       // fill dataset

                // add data to datagrid
                dataGridViewAllTreatments.DataSource = ds;
                dataGridViewAllTreatments.DataMember = "Treatments";

                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }

        public void displayAllUpdate()        // Method to display all data in datagrid
        {
            try
            {
                conn.Open();                                        // open connection
                string sqlQuery = $"SELECT * FROM Treatments";      // compile select query 
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                      // set command for adapter
                adapt.Fill(ds, "Treatments");                       // fill dataset

                // add data to datagrid
                dGrdViewUptTreat.DataSource = ds;
                dGrdViewUptTreat.DataMember = "Treatments";

                conn.Close();                                       // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                      // catch error and display message
            }
        }
            public void populateComboBox()
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

        public void populateComboBoxUpd()
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

        private void Maintain_Treatments_Load(object sender, EventArgs e)
        {
            displayAll();
            populateComboBox();
            displayAllUpdate();
            populateComboBoxUpd();
        }

        private void tabControlTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAll();   // call when index of tab changes
            populateComboBox();

        }

        private void textBoxSearchTreatments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txbxSearchTreatments.Text}%'";
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

        private void cmboBoxTeatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{cmboBoxTeatments.SelectedItem.ToString()}%'";
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
            displayAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txbxName.Text != "")
            {
                if(double.TryParse(txbxPrice.Text, out price))
                {
                    if(int.TryParse(txbxDuration.Text, out duration))
                    {
                        try
                        {
                            conn.Open();        // open connection

                            // compile query string by retieving values from instance
                            string sqlUpdate = $"UPDATE Treatments SET Name = '{txbxName.Text}', Cost_Price = '{price}', Duration = {duration} WHERE Treatment_ID LIKE {treat_update_ID}";

                            command = new SqlCommand(sqlUpdate, conn);          //execute sql statement 
                            adapt = new SqlDataAdapter();

                            adapt.UpdateCommand = command;                      // set command for adapter
                            adapt.UpdateCommand.ExecuteNonQuery();              // execute command

                            conn.Close();                                       // close connection
                            MessageBox.Show("Succesfully updated record");      // notify user if update was successful
                            displayAllUpdate();                                       // refresh datagrid to display updated record
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

        private void txbxSrchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txbxSrchName.Text}%'";
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{cmbType.SelectedItem.ToString()}%'";
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
}
