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
    public partial class SearchClientReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;

        public int fClient_ID;
        public string Fname, fsurname, fCell;

        public SearchClientReport()
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
                dgClientSearch.DataSource = ds;
                dgClientSearch.DataMember = "Clients";

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // sql select statment
                string sqlSearch = $"SELECT * FROM Clients WHERE Name LIKE '%{textBox1.Text}%' AND Deleted LIKE '{0}'";  // sql query, the Deleted 0 indicated if a record should be shown or hidden in the query
                command = new SqlCommand(sqlSearch, conn);              // execute statement against given datasource
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                           // set command to adapter
                adapt.Fill(ds, "Clients");                            //fill dataset

                // fill datagrid
                dgClientSearch.DataSource = ds;
                dgClientSearch.DataMember = "Clients";

                conn.Close();                                   // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 // catch error and display message
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Fname = lblName.Text;
            fsurname = lblSurname.Text;
            fCell = lblCell.Text;

            this.Close();
        }

        private void SearchClientReport_Load_1(object sender, EventArgs e)
        {
            displayAll();
        }

        private void dgClientSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dgClientSearch.RowCount;

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dgClientSearch.Rows[index];  // cast collum values of row to variable

                if(index == totalRows - 1)
                {
                    MessageBox.Show("Please selecte a filled record");
                }
                else
                {
                    fClient_ID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value from the datagrid selected record

                    // retieve values from selected row by specifying the cell index and display in textboxes to be edited
                    lblName.Text = row.Cells[1].Value.ToString();
                    lblSurname.Text = row.Cells[2].Value.ToString();
                    lblCell.Text = row.Cells[4].Value.ToString();

                }

            }
        }

        private void SearchClientReport_Load(object sender, EventArgs e)
        {
            displayAll();
        }
    }
}
