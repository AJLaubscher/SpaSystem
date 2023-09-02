using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Spa_Information_System_Group6
{
    public partial class frmMaintainBookings : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-2999I1K;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        int fEmpID;
        int fTreatmentId;
        int fClientID;

        string bookingDate;
        bool selectedInformation = false;

        int fTotalRows;
        int fBookingID;
        public frmMaintainBookings()
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

        private void txtSearchDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Bookings WHERE Date_of_Booking LIKE '%{txtSearchDate.Text}%'"; 
                command = new SqlCommand(sqlSearch, conn);              
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;                           
                adapter.Fill(dataSet, "Bookings");                            

                // fill datagrid
                dataGridViewAllBookings.DataSource = dataSet;
                dataGridViewAllBookings.DataMember = "Bookings";

                conn.Close();                                   
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                 
            }
        }

        private void txtSearchStartTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Bookings WHERE Time_Start LIKE '%{txtSearchStartTime.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Bookings");

                // fill datagrid
                dataGridViewAllBookings.DataSource = dataSet;
                dataGridViewAllBookings.DataMember = "Bookings";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchDate.Clear();
            txtSearchStartTime.Clear();
        }

        private void btnSelectInformation_Click(object sender, EventArgs e)
        {
            frmBookingInformationAdd myFrmBookingAdd = new frmBookingInformationAdd();
            myFrmBookingAdd.ShowDialog();

            //Receive selected primary keys from the frmBookingInformationAdd form
            fClientID = myFrmBookingAdd.clientID;
            fEmpID = myFrmBookingAdd.empID;
            fTreatmentId = myFrmBookingAdd.treatmentID;

            displayEmployeeInformation(fEmpID);
            displayClientInformation(fClientID);
            displayTreatmentInformation(fTreatmentId);

            selectedInformation = true;
        }

        private void displayEmployeeInformation(int empID)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT * FROM Employees WHERE Employee_ID = {empID}";

                command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())        // read through eemployee table, and find the employee with given primary key
                {
                    if (empID == (int)reader.GetValue(0))
                    {
                        txtAddEmpName.Text = reader.GetString(1);
                        txtAddEmpSurname.Text = reader.GetString(2);
                    }
                    else
                    {
                        MessageBox.Show("ID not found");
                    }

                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void displayClientInformation(int clientID)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT * FROM Clients WHERE Client_ID = {clientID}";

                command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())        // read through client table, and find the client with given primary key
                {
                    if (clientID == (int)reader.GetValue(0))
                    {
                        txtAddClientName.Text = reader.GetString(1);
                        txtAddClientSurname.Text = reader.GetString(2);
                    }
                    else
                    {
                        MessageBox.Show("ID not found");
                    }

                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void displayTreatmentInformation(int treatmentID)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT * FROM Treatments WHERE Treatment_ID = {treatmentID}";

                command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())        // read through client table, and find the client with given primary key
                {
                    if (treatmentID == (int)reader.GetValue(0))
                    {
                        txtAddTreatmentName.Text = reader.GetString(2);
                        txtTreatmentType.Text = reader.GetString(1);
                    }
                    else
                    {
                        MessageBox.Show("ID not found");
                    }

                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            decimal treatmentPrice, amountDue;  //All variables declared are used for validation purposes

            if(selectedInformation == true)
            {
                errorProvider1.SetError(txtTreatmentPrice, "");
                errorProvider1.SetError(txtAmountDue, "");
                errorProvider1.SetError(txtStartTime, "");
                errorProvider1.SetError(txtEndTime, "");

                bookingDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                if (decimal.TryParse(txtTreatmentPrice.Text, out treatmentPrice) == true)
                    {
                        if (txtStartTime.Text != "")
                        {
                            if (txtEndTime.Text == "")
                            {
                                errorProvider1.SetError(txtEndTime, "Invalid end time");
                            }
                            else
                            {
                                if (decimal.TryParse(txtAmountDue.Text, out amountDue))
                                {
                                    //If all Inputs are correct 

                                    addBookings();                  //Add bookings then make every value default again
                                    resetToDefault();

                                }
                                else
                                {
                                    errorProvider1.SetError(txtAmountDue, "Invalid treatment price entered");
                                }
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtStartTime, "Invalid Start time");
                        }
                }
                else
                {
                    errorProvider1.SetError(txtTreatmentPrice, "Invalid treatment price entered");
                }
            }
            else
            {
                MessageBox.Show("Please first select the information");
            }
           
        }

        private void addBookings()
        {
            bool treatmentProvided, bookingPayed, bookingCancelled;

            try
            {
                conn.Open();                                                 

                if(chbTreatmentProv.Checked)
                {
                    treatmentProvided = true;
                }
                else
                {
                    treatmentProvided = false;
                }

                if(chbPayed.Checked)
                {
                    bookingPayed = true;
                }
                else
                {
                    bookingPayed = false;
                }

                if(chbCancelled.Checked)
                {
                    bookingCancelled = true;
                }
                else
                {
                    bookingCancelled = false;
                }

                string sqlInsert = $"INSERT INTO Bookings Values({fClientID}, {fEmpID}, {fTreatmentId}, '{bookingDate}', '{txtStartTime.Text}', '{txtEndTime.Text}', {txtTreatmentPrice.Text}, {txtAmountDue.Text}, '{bookingPayed}', '{treatmentProvided}', '{bookingCancelled}')";

                command = new SqlCommand(sqlInsert, conn);                  
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;                              
                adapter.InsertCommand.ExecuteNonQuery();                     

                conn.Close();                                               
                MessageBox.Show("New Booking successfully added");            
 
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                
            }
        }

        private void resetToDefault()
        {
            selectedInformation = false;
            fEmpID = 0;
            fClientID = 0;
            fTreatmentId = 0;
            dateTimePicker1.Value = DateTime.Now;
            txtEndTime.Clear();
            txtStartTime.Clear();
            txtAmountDue.Clear();
            chbCancelled.Checked = false;
            chbPayed.Checked = false;
            chbTreatmentProv.Checked = false;
            txtTreatmentPrice.Clear();

            txtAddClientSurname.Clear();
            txtAddClientName.Clear();
            txtAddEmpName.Clear();
            txtAddEmpSurname.Clear();
            txtAddTreatmentName.Clear();
            txtTreatmentType.Clear();
        }

        private void Maintain_Bookings_Load(object sender, EventArgs e)
        {
            displayAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bookingDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void BookingsTabControl_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void BookingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BookingsTabControl.SelectedIndex == 0)
            {
                displayAll();
            }
            else if(BookingsTabControl.SelectedIndex == 2)
            {
                try
                {
                    // open connection
                    conn.Open();
                    string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                        $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                        $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                        $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                        $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID";

                    command = new SqlCommand(sqlQuery, conn);
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();
                    // inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID -- needed
                    adapter.SelectCommand = command;                                               // set command for adapter
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);                                               // fill dataset


                    // add data to datagrid
                    dbGridUpdateBooking.DataSource = dt;
                    dbGridUpdateBooking.Columns[0].HeaderText = "BookingID";
                    dbGridUpdateBooking.Columns[1].HeaderText = "Client Name";
                    dbGridUpdateBooking.Columns[2].HeaderText = "Treatment Name";
                    dbGridUpdateBooking.Columns[3].HeaderText = "Employee Name";
                    dbGridUpdateBooking.Columns[4].HeaderText = "Date of Booking";
                    dbGridUpdateBooking.Columns[5].HeaderText = "Start Time";
                    dbGridUpdateBooking.Columns[6].HeaderText = "End Time";
                    dbGridUpdateBooking.Columns[7].HeaderText = "Treatment Price";
                    dbGridUpdateBooking.Columns[8].HeaderText = "Amount Due";
                    dbGridUpdateBooking.Columns[9].HeaderText = "Booking Payed";
                    dbGridUpdateBooking.Columns[10].HeaderText = "TreatmentProvided";
                    dbGridUpdateBooking.Columns[11].HeaderText = "Booking Cancelled";

                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);                                            
                }

            }
        }

        private void dbGridUpdateBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dbGridUpdateBooking.RowCount;  //use total Rows to ensure that the user does not click on empty field

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dbGridUpdateBooking.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                }
                else
                {
                    fBookingID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value

                    try
                    {
                        conn.Open();

                        string sqlQuery = $"SELECT * FROM Bookings WHERE Booking_ID = {fBookingID}";

                        command = new SqlCommand(sqlQuery, conn);
                        SqlDataReader reader;
                        reader = command.ExecuteReader();

                        while (reader.Read())        // read through eemployee table, and find the employee with given primary key
                        {
                            if (fBookingID == (int)reader.GetValue(0))
                            {

                                if(reader.GetBoolean(9) == true)
                                {
                                    chbUpBookingPayed.Checked = true;
                                }
                                else
                                {
                                    chbUpBookingPayed.Checked= false;
                                }

                                if(reader.GetBoolean(10) == true)
                                {
                                    chbUpTreatmentProv.Checked = true;
                                }
                                else
                                {
                                    chbUpTreatmentProv.Checked= false;
                                }

                                if(reader.GetBoolean(11) == true)
                                {
                                    chbUpBookingCancelled.Checked = true;
                                }
                                else
                                {
                                    chbUpBookingCancelled.Checked= false;
                                }


                                dateTimePickerUpdate.Value = (DateTime)reader.GetValue(4);
                                txtUpStartTime.Text = reader.GetString(5);
                                txtUpEndTime.Text = reader.GetString(6);
                                txtUpTreatmentPrice.Text = reader.GetDecimal(7).ToString();
                                txtUpAmountDue.Text = reader.GetDecimal(8).ToString();
                            }
                            else
                            {
                                MessageBox.Show("ID not found");
                            }

                        }

                        conn.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }

                }
            }
        }
    }
}
