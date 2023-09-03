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
                string sqlDisplayQuery = $"SELECT Booking_ID, Date_Of_Booking, Amount_Due, Booking_Payes FROM Bookings WHERE Date_Of_Booking BETWEEN '{dtStartDate.Value}' AND '{dtEndDate.Value}' AND Booking_Canceled = {0}";

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

                string sqlQuery = $"SELECT SUM(Amount_Due) AS TotalIncome FROM Bookings WHERE Date_Of_Booking BETWEEN '{dtStartDate.Value}' AND '{dtEndDate.Value}' AND Booking_Canceled = {0} AND Booking_Payes = '{1}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted

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
                    string value1 = reader.GetValue(0).ToString();
                    string value2 = reader.GetValue(1).ToString();
                    string value3 = reader.GetValue(2).ToString();
                    string value4 = reader.GetValue(3).ToString();

                    // Set the maximum widths for each column
                    int maxColumn1Width = 30;
                    int maxColumn2Width = 30;
                    int maxColumn3Width = 30;
                    int maxColumn4Width = 15;

                    // Truncate or pad values to ensure they fit within their respective maximum widths
                    value1 = value1.Length <= maxColumn1Width ? value1.PadRight(maxColumn1Width) : value1.Substring(0, maxColumn1Width);
                    value2 = value2.Length <= maxColumn2Width ? value2.PadRight(maxColumn2Width) : value2.Substring(0, maxColumn2Width);
                    value3 = value3.Length <= maxColumn3Width ? value3.PadRight(maxColumn3Width) : value3.Substring(0, maxColumn3Width);
                    value4 = value4.Length <= maxColumn4Width ? value4.PadRight(maxColumn4Width) : value4.Substring(0, maxColumn4Width);

                    listBoxSchedule.Items.Add($"{value1}\t{value2}\t{value3}\t{value4}");

                    //listBoxSchedule.Items.Add(reader.GetValue(0) + "\t\t\t" +reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t\t" + reader.GetValue(3)); //Display database table values in listbox
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
                //lstTop10.Font = new Font("Courier New", 10);
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
                    string value1 = reader.GetValue(0).ToString();
                    string value2 = reader.GetValue(1).ToString();

                    // Truncate or pad value1 to ensure it has a maximum length of 25 characters
                    value1 = value1.Length <= 25 ? value1.PadRight(25) : value1.Substring(0, 25);

                    lstTop10.Items.Add($"{value1}\t{value2}");

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
                listClients.Items.Add("\nTreatment Name\t\t\tType of Treatment\t\tBooking Date");
                listClients.Items.Add("=====================================================================================");
                listClients.Items.Add("");

                while (reader.Read()) //Use while loop
                {
                    DateTime date = reader.GetDateTime(2);

                    string value1 = reader.GetValue(0).ToString();
                    string value2 = reader.GetValue(1).ToString();
                    string value3 = date.ToString("dd-MM-yyyy");
  

                    // Set the maximum widths for each column
                    int maxColumn1Width = 40;
                    int maxColumn2Width = 30;
                    int maxColumn3Width = 30;

                    // Truncate or pad values to ensure they fit within their respective maximum widths
                    value1 = value1.Length <= maxColumn1Width ? value1.PadRight(maxColumn1Width) : value1.Substring(0, maxColumn1Width);
                    value2 = value2.Length <= maxColumn2Width ? value2.PadRight(maxColumn2Width) : value2.Substring(0, maxColumn2Width);
                    value3 = value3.Length <= maxColumn3Width ? value3.PadRight(maxColumn3Width) : value3.Substring(0, maxColumn3Width);


                    listClients.Items.Add($"{value1}\t{value2}\t{value3}");

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

        private void Request_Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpMe = new Help();
            helpMe.Show();
        }
    }
}
