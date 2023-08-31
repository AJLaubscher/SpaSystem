using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa_Information_System_Group6
{
    public partial class Maintain_Bookings : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-2999I1K;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public Maintain_Bookings()
        {
            InitializeComponent();
        }

        public void displayAll()
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Bookings";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;                                               // set command for adapter
                adapter.Fill(dataSet, "Bookings");                                               // fill dataset

                // add data to datagrid
                dataGridViewAllBookings.DataSource = dataSet;
                dataGridViewAllBookings.DataMember = "Bookings";

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayAll();
        }
    }
}
