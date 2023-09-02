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
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
                lstDisplay.Items.Add("====================================================================");
                lstDisplay.Items.Add("");

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

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Today;

                conn.Open();
                string sqlQuery = $"SELECT Employees.Employee_Name, Clients.Name, Treatments.Name, Bookings.Time_Start FROM Employees, Clients, Treatments, Bookings WHERE Bookings.Employee_ID = Employees.Employee_ID AND Bookings.Client_ID = Clients.Client_ID AND Bookings.Treatment_ID = Treatments.Treatment_ID AND Bookings.Date_Of_Booking = '{date}' AND Bookings.Booking_Canceled = '{0}' ORDER BY Bookings.Time_Start";
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();

                listBoxSchedule.Items.Clear(); //Clear listbox
                listBoxSchedule.Items.Add("Schedule for today: " + date.ToString("dd-MM-yyyy"));
                listBoxSchedule.Items.Add("");
                listBoxSchedule.Items.Add("\nEmployee_Name\t\tClients Name\t\tTreatment Name\t\tTime");
                listBoxSchedule.Items.Add("=================================================================================");
                listBoxSchedule.Items.Add("");

                while (reader.Read()) //Use while loop
                {
                    listBoxSchedule.Items.Add(reader.GetValue(0) + "\t\t\t" +reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t\t" + reader.GetValue(3)); //Display database table values in listbox
                }

                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnGenerateTop10_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("dd-MM-yyyy");

            try
            {
                conn.Open();
                string sqlQuery = $" SELECT Treatments.Name, Treatments._Type, COUNT(Bookings.Treatment_ID) AS Booking_Count FROM Treatments LEFT JOIN Bookings ON Treatments.Treatment_ID = Bookings.Treatment_ID WHERE Bookings.Date_Of_Booking BETWEEN '{top10_dateTime_start.Value}' AND '{top10_dateTime_end.Value}' AND Bookings.Booking_Canceled = '{0}' GROUP BY Treatments.Name, Treatments._Type ORDER BY Booking_Count DESC";


                command = new SqlCommand(sqlQuery, conn);

                reader = command.ExecuteReader();

                lstTop10.Items.Clear(); //Clear listbox
                lstTop10.Items.Add("Top 10 treatments between: ");
                lstTop10.Items.Add("");
                lstTop10.Items.Add("Start Date:" +  dtStartDate.Value.ToString("dd-MM-yyyy"));
                lstTop10.Items.Add("Start Date:" + dtEndDate.Value.ToString("dd-MM-yyyy"));
                lstTop10.Items.Add("");
                lstTop10.Items.Add("Report Generated on:" + DateTime.Now.ToString("dd-MM-yyyy"));
                lstTop10.Items.Add("");
                lstTop10.Items.Add("\nTreatment Name\t\t\tType of Treatment\t");
                lstTop10.Items.Add("=====================================================================================");
                lstTop10.Items.Add("");

                while (reader.Read()) //Use while loop
                {
                    lstTop10.Items.Add(reader.GetValue(0) + "\t\t\t\t" + reader.GetValue(1)); //Display database table values in listbox
                }


                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchClientReport newSearch = new SearchClientReport();
            newSearch.ShowDialog();

            lblName.Text = newSearch.Fname;
            lblSurname.Text = newSearch.fsurname;
            lblCell.Text = newSearch.fCell;



        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string sqlQuery = $" SELECT Treatments.Name, Treatments._Type, Bookings.Date_Of_Booking FROM Treatments, Bookings WHERE Bookings.Treatment_ID = Treatments.Treatment_ID AND Bookings.Booking_Canceled = '{0}' ORDER BY Bookings.Date_Of_Booking DESC";

                command = new SqlCommand(sqlQuery, conn);

                reader = command.ExecuteReader();

                listClients.Items.Clear(); //Clear listbox
                listClients.Items.Add("Client History Report: ");
                listClients.Items.Add("");
                listClients.Items.Add("Client Name:" + lblName.Text);
                listClients.Items.Add("Client Surname:" + lblSurname.Text);
                listClients.Items.Add("Client Contact Number:" + lblCell.Text);
                listClients.Items.Add("");
                listClients.Items.Add("Report Generated on:" + DateTime.Now.ToString("dd-MM-yyyy"));
                listClients.Items.Add("");
                listClients.Items.Add("\nTreatment Name\t\t\tType of Treatment\t\t\tBooking Date");
                listClients.Items.Add("=====================================================================================");
                listClients.Items.Add("");

                while (reader.Read()) //Use while loop
                {
                    DateTime date = reader.GetDateTime(2);
                    listClients.Items.Add(reader.GetValue(0) + "\t\t\t\t" + reader.GetValue(1) + "\t\t\t\t" + date.ToString("dd-MM-yyyy")); //Display database table values in listbox
                }
                lblCell.Text = "";
                lblName.Text = "";
                lblSurname.Text = "";

                conn.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstTop10.Items.Clear();
            listBoxSchedule.Items.Clear();
            listClients.Items.Clear();
            lblCell.Text = "";
            lblName.Text = "";
            lblSurname.Text = "";
        }
    }
}
