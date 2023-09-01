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

namespace Spa_Information_System_Group6
{
    public partial class Maintain_Bookings : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-2999I1K;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        int fEmpID;
        int fTreatmentId;
        int fClientID;

        bool selectedInformation = false;

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
            bool invalidDate = false;           //Test whether date is valid or not 
            bool invalidStartTime = false;
            bool invalidEndTime = false ;

            if(selectedInformation == true)
            {
                errorProvider1.SetError(txtDate, "");
                errorProvider1.SetError(txtTreatmentPrice, "");
                errorProvider1.SetError(txtAmountDue, "");
                errorProvider1.SetError(txtStartTime, "");
                errorProvider1.SetError(txtEndTime, "");

                if (txtDate.TextLength == 10)       //Date must be 10 characters
                {
                    for (int i = 0; i < txtDate.TextLength; i++)        //Loop through textbox and make sure that only g
                    {
                        if (!(Char.IsDigit(txtDate.Text[i])) && !(txtDate.Text[i] == '-') && !(txtDate.Text[i] == '/'))
                        {
                            invalidDate = true;
                            break;
                        }

                    }


                    if (invalidDate == false && invalidStartTime == false && invalidEndTime == false)
                    {
                        if (decimal.TryParse(txtTreatmentPrice.Text, out treatmentPrice) == true && invalidDate == false)
                        {
                            if (txtStartTime.Text != "")
                            {
                                if (txtEndTime.Text == "")
                                {
                                    invalidEndTime = true;
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
                                invalidStartTime = true;
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtTreatmentPrice, "Invalid treatment price entered");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtDate, "Invalid Date entered");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDate, "Invalid Date entered");
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

                string sqlInsert = $"INSERT INTO Bookings Values({fClientID}, {fEmpID}, {fTreatmentId}, '{txtDate.Text}', '{txtStartTime.Text}', '{txtEndTime.Text}', {txtTreatmentPrice.Text}, {txtAmountDue.Text}, '{bookingPayed}', '{treatmentProvided}', '{bookingCancelled}')";

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
            txtDate.Clear();
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

        }
    }
}
