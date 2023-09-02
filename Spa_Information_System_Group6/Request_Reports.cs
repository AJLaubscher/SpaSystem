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
                string sqlDisplayQuery = $"SELECT Booking_ID, Date_Of_Booking, Amount_Due, Booking_Payes FROM Bookings";

                command = new SqlCommand(sqlDisplayQuery, conn);

                reader = command.ExecuteReader();

                lstDisplay.Items.Clear(); //Clear listbox
                lstDisplay.Items.Add("Income between " + dtStartDate.Value.ToString("dd-MM-yyyy") + " and " + dtEndDate.Value.ToString("dd-MM-yyyy"));
                lstDisplay.Items.Add("");
                lstDisplay.Items.Add("\nBooking ID\tDate of Booking\tAmount Due\tBooking Payed");

                while (reader.Read()) //Use while loop
                {
                    DateTime date = reader.GetDateTime(1);
                    lstDisplay.Items.Add(reader.GetValue(0) + "\t\t" + date.ToString("dd-MM-yyyy") + "\t" + Math.Round(reader.GetDecimal(2),2) + "\t\t" + reader.GetValue(3)); //Display database table values in listbox
                }

                conn.Close();                                                               // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }

            try
            {
                conn.Open();

                string sqlQuery = $"SELECT SUM(Amount_Due) AS TotalIncome FROM Bookings WHERE Date_Of_Booking BETWEEN '{dtStartDate.Value}' AND '{dtEndDate.Value}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted

                command = new SqlCommand(sqlQuery, conn);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TotalIncome")))
                    {
                        decimal totalIncome = reader.GetDecimal(reader.GetOrdinal("TotalIncome"));
                        // Now, 'totalIncome' contains the total income within the selected date range.
                        lstDisplay.Items.Add("");
                        lstDisplay.Items.Add("Total Income: " + totalIncome.ToString("C"));
                    }
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }
    }
}
