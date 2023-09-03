//41179196
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
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

        //Update 
        int updateBookingID;
        int updateTreatmentID;
        bool selectedUpdateRecord;

        //Delete
        int deleteBookingID;
        bool selectedDeleteRecord;

        public frmMaintainBookings()
        {
            InitializeComponent();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayViewAllBookings();
        }

        private void txtSearchDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Bookings.Date_Of_Booking Like '%{txtSearchDate.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridViewAllBookings.DataSource = dt;

                // add data to datagrid
                constructDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearchStartTime_TextChanged(object sender, EventArgs e)             //Now used to search for client name
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Clients.Name Like '%{txtSearchStartTime.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridViewAllBookings.DataSource = dt;

                // add data to datagrid
                constructDataGridHeaders(dt);

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

            if (selectedInformation == true)
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

                if (chbTreatmentProv.Checked)
                {
                    treatmentProvided = true;
                }
                else
                {
                    treatmentProvided = false;
                }

                if (chbPayed.Checked)
                {
                    bookingPayed = true;
                }
                else
                {
                    bookingPayed = false;
                }

                if (chbCancelled.Checked)
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
            displayViewAllBookings();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bookingDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void BookingsTabControl_Selected(object sender, TabControlEventArgs e)
        {
            displayDeleteDataGrid();
        }

        private void BookingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookingsTabControl.SelectedIndex == 0)
            {
                displayViewAllBookings();
            }
            else if (BookingsTabControl.SelectedIndex == 2)
            {
                displayBookings();
            }
            else if(BookingsTabControl.SelectedIndex == 3)
            {
                
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
                    selectedUpdateRecord = false;               //Ensures that the user does not crash program due to clicking on the record after the valid record was entered
                }
                else
                {
                    updateBookingID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    selectedUpdateRecord = true;                            //Set bool value to true so that update is allowed

                    try
                    {
                        conn.Open();

                        string sqlQuery = $"SELECT * FROM Bookings WHERE Booking_ID = {updateBookingID}";

                        command = new SqlCommand(sqlQuery, conn);
                        SqlDataReader reader;
                        reader = command.ExecuteReader();

                        while (reader.Read())        // read through eemployee table, and find the employee with given primary key
                        {
                            if (updateBookingID == (int)reader.GetValue(0))
                            {

                                if (reader.GetBoolean(9) == true)
                                {
                                    chbUpBookingPayed.Checked = true;
                                }
                                else
                                {
                                    chbUpBookingPayed.Checked = false;
                                }

                                if (reader.GetBoolean(10) == true)
                                {
                                    chbUpTreatmentProv.Checked = true;
                                }
                                else
                                {
                                    chbUpTreatmentProv.Checked = false;
                                }

                                if (reader.GetBoolean(11) == true)
                                {
                                    chbUpBookingCancelled.Checked = true;
                                }
                                else
                                {
                                    chbUpBookingCancelled.Checked = false;
                                }

                                updateTreatmentID = (int)reader.GetValue(3);            //Set the treatmentID

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

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Employees.Employee_Name Like '%{txtSearchEmployee.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridViewAllBookings.DataSource = dt;

                // add data to datagrid
                constructDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void constructDataGridHeaders(DataTable dt)
        {
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
        }

        private void txtSearchClientName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Clients.Name Like '%{txtSearchClientName.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridViewAllBookings.DataSource = dt;

                // add data to datagrid
                constructDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            txtSearchClientName.Clear();
            txtSearchEmployee.Clear();
        }

        private void btnUpTreatment_Click(object sender, EventArgs e)
        {
            if (selectedUpdateRecord == true)
            {
                frmUpdateTreatmentInfo myfrmUpdateTreatmentInfo = new frmUpdateTreatmentInfo();
                myfrmUpdateTreatmentInfo.ShowDialog();

                fTreatmentId = myfrmUpdateTreatmentInfo.treatmentID;

                if (myfrmUpdateTreatmentInfo.bTreatmentClick == true)
                {
                    updateTreatmentID = myfrmUpdateTreatmentInfo.treatmentID;
                }
            }
            else
            {
                MessageBox.Show("Select A Booking first before selecting a treatment to be updated");
            }


        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            decimal treatmentPrice, amountDue;  //All variables declared are used for validation purposes

            if (selectedUpdateRecord == true)
            {
                errorProvider1.SetError(txtUpTreatmentPrice, "");
                errorProvider1.SetError(txtUpAmountDue, "");
                errorProvider1.SetError(txtUpStartTime, "");
                errorProvider1.SetError(txtUpEndTime, "");

                bookingDate = dateTimePickerUpdate.Value.ToString("dd-MM-yyyy");

                if (decimal.TryParse(txtUpTreatmentPrice.Text, out treatmentPrice) == true)
                {
                    if (txtUpStartTime.Text != "")
                    {
                        if (txtUpEndTime.Text == "")
                        {
                            errorProvider1.SetError(txtEndTime, "Invalid end time");
                        }
                        else
                        {
                            if (decimal.TryParse(txtUpAmountDue.Text, out amountDue))
                            {
                                //If all Inputs are correct 

                                updateBookings();                  //Add bookings then make every value default again


                                //reset controls
                                updateBookingID = 0;
                                selectedUpdateRecord = false;
                                txtUpAmountDue.Clear();
                                txtUpEndTime.Clear();
                                txtUpStartTime.Clear();
                                txtUpTreatmentPrice.Clear();
                                dateTimePickerUpdate.Value = DateTime.Now;

                                displayBookings();          //Display The dbGrid with the updated value
                            }
                            else
                            {
                                errorProvider1.SetError(txtAmountDue, "Invalid treatment price entered");
                            }
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtUpStartTime, "Invalid Start time");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUpTreatmentPrice, "Invalid treatment price entered");
                }
            }
            else
            {
                MessageBox.Show("Please first select the information");
            }
        }

        private void updateBookings()
        {
            bool bookingPayed;
            bool treatmentProvided;
            bool bookingCanceled;

            try
            {
                conn.Open();

                if (chbUpBookingPayed.Checked)
                {
                    bookingPayed = true;
                }
                else
                {
                    bookingPayed = false;
                }

                if (chbUpTreatmentProv.Checked)
                {
                    treatmentProvided = true;
                }
                else
                {
                    treatmentProvided = false;
                }

                if (chbUpBookingCancelled.Checked)
                {
                    bookingCanceled = true;
                }
                else
                {
                    bookingCanceled = false;
                }

                string sqlUpdate = $"UPDATE Bookings SET Treatment_ID = {updateTreatmentID}, Date_Of_Booking = '{dateTimePickerUpdate.Value}', Time_Start = '{txtUpStartTime.Text}'" +
                   $", Time_End = '{txtUpEndTime.Text}', Treatment_price = {txtUpTreatmentPrice.Text}, Amount_Due = {txtUpAmountDue.Text}, Booking_Payes = '{bookingPayed}', Treatment_Provided = '{treatmentProvided}', Booking_Canceled = '{bookingCanceled}'" +
                   $" WHERE Booking_ID = {updateBookingID}";

                command = new SqlCommand(sqlUpdate, conn);
                adapter = new SqlDataAdapter();

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Booking Sucessfully updated");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void displayBookings()
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
                adapter.SelectCommand = command;                                               // set command for adapter
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                // add data to datagrid
                dbGridUpdateBooking.DataSource = dt;
                constructDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUpClear_Click(object sender, EventArgs e)
        {
            txtUpAmountDue.Clear();
            txtUpEndTime.Clear();
            txtUpStartTime.Clear();
            txtUpTreatmentPrice.Clear();
            dateTimePickerUpdate.Value = DateTime.Now;
        }

        private void displayViewAllBookings()
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
                adapter.SelectCommand = command;                                               // set command for adapter
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                // add data to datagrid
                dataGridViewAllBookings.DataSource = dt;
                constructViewAllDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void constructViewAllDataGridHeaders(DataTable dt)
        {
            dataGridViewAllBookings.DataSource = dt;
            dataGridViewAllBookings.Columns[0].HeaderText = "BookingID";
            dataGridViewAllBookings.Columns[1].HeaderText = "Client Name";
            dataGridViewAllBookings.Columns[2].HeaderText = "Treatment Name";
            dataGridViewAllBookings.Columns[3].HeaderText = "Employee Name";
            dataGridViewAllBookings.Columns[4].HeaderText = "Date of Booking";
            dataGridViewAllBookings.Columns[5].HeaderText = "Start Time";
            dataGridViewAllBookings.Columns[6].HeaderText = "End Time";
            dataGridViewAllBookings.Columns[7].HeaderText = "Treatment Price";
            dataGridViewAllBookings.Columns[8].HeaderText = "Amount Due";
            dataGridViewAllBookings.Columns[9].HeaderText = "Booking Payed";
            dataGridViewAllBookings.Columns[10].HeaderText = "TreatmentProvided";
            dataGridViewAllBookings.Columns[11].HeaderText = "Booking Cancelled";
        }

        private void button1_Click(object sender, EventArgs e)      //Delete Bookings button
        {
            if(selectedDeleteRecord == true)
            {
                try
                {
                    conn.Open();

                    string sqlDelete = $"Delete FROM Bookings WHERE  Booking_ID = {deleteBookingID}";

                    command = new SqlCommand(sqlDelete, conn);
                    adapter = new SqlDataAdapter();

                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Successfully deleted Booking with ID : " + deleteBookingID.ToString());

                    txtSearchBookingDate.Clear();
                    txtSearchBookingName.Clear();

                    displayDeleteDataGrid();
                    selectedDeleteRecord = false;

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record before deleting");
            }
        }

        private void dataGridDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dataGridDelete.RowCount;  //use total Rows to ensure that the user does not click on empty field

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dataGridDelete.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                    selectedDeleteRecord = false;
                }
                else
                {
                    deleteBookingID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    selectedDeleteRecord = true;
                }
            }
        }

        private void constructDeleteDataGridHeaders(DataTable dt)
        {
            dataGridDelete.DataSource = dt;
            dataGridDelete.Columns[0].HeaderText = "BookingID";
            dataGridDelete.Columns[1].HeaderText = "Client Name";
            dataGridDelete.Columns[2].HeaderText = "Treatment Name";
            dataGridDelete.Columns[3].HeaderText = "Employee Name";
            dataGridDelete.Columns[4].HeaderText = "Date of Booking";
            dataGridDelete.Columns[5].HeaderText = "Start Time";
            dataGridDelete.Columns[6].HeaderText = "End Time";
            dataGridDelete.Columns[7].HeaderText = "Treatment Price";
            dataGridDelete.Columns[8].HeaderText = "Amount Due";
            dataGridDelete.Columns[9].HeaderText = "Booking Payed";
            dataGridDelete.Columns[10].HeaderText = "TreatmentProvided";
            dataGridDelete.Columns[11].HeaderText = "Booking Cancelled";
        }

        private void txtSearchBookingName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Clients.Name Like '%{txtSearchBookingName.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridDelete.DataSource = dt;

                // add data to datagrid
                constructDeleteDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearchBookingDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT Bookings.Booking_ID, Clients.Name, Treatments.Name, Employees.Employee_Name, " +
                 $"Bookings.Date_Of_Booking, Bookings.Time_Start, Bookings.Time_End, Bookings.Treatment_Price, Bookings.Amount_Due, Bookings.Booking_Payes, Bookings.Treatment_Provided, Bookings.Booking_Canceled" +
                 $" FROM Bookings inner join Clients on Bookings.Client_ID  = Clients.Client_ID" +
                 $" inner join Treatments on Bookings.Treatment_ID = Treatments.Treatment_ID" +
                 $" inner join Employees on Bookings.Employee_ID = Employees.Employee_ID WHERE Bookings.Date_Of_Booking Like '%{txtSearchBookingDate.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // fill datagrid
                dataGridDelete.DataSource = dt;

                // add data to datagrid
                constructDeleteDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void displayDeleteDataGrid()
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
                adapter.SelectCommand = command;                                               // set command for adapter
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                // add data to datagrid
                dataGridDelete.DataSource = dt;
                constructDeleteDataGridHeaders(dt);

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearchBookingDate.Clear();
            txtSearchBookingName.Clear();
        }
    }
}
