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
    public partial class Request_Reports : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NSKM73HE\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;
        SqlDataReader reader;
        public Request_Reports()
        {
            InitializeComponent();
        }

        private void btnDisplayIncome_Click(object sender, EventArgs e)
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT SUM(Amount_Due) FROM Bookings WHERE Date_Of_Booking BETWEEN '{dtStartDate.Value}' AND '{dtEndDate.Value}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;                                               // set command for adapter
                adapt.Fill(ds, "Bookings");                                               // fill dataset

                reader = command.ExecuteReader();

                lstDisplay.Items.Clear(); //Clear listbox
                while (reader.Read()) //Use while loop
                {
                    lstDisplay.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(5) + "\t" + reader.GetValue(6) + "\t" + reader.GetValue(7)); //Display database table values in listbox
                }

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }
    }
}
