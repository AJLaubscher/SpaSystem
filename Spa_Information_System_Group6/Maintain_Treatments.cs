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
                dataGridViewAllTreatments.DataSource = ds;
                dataGridViewAllTreatments.DataMember = "Treatments";

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
                string sqlQuery = $"SELECT Venue FROM Treatments";      // compile select query 
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

        private void Maintain_Treatments_Load(object sender, EventArgs e)
        {
            displayAll();
            populateComboBox();
            displayAllUpdate();
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
                string sqlSearch = $"SELECT * FROM Treatments WHERE Venue LIKE '%{cmboBoxTeatments.SelectedItem.ToString()}%'";
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

            }
            else
            {
                errorProviderTreatments.SetError(txbxName, "Enter new treatment name");
                txbxName.Text = "";
                txbxName.Focus();
            }
        }
    }
}
