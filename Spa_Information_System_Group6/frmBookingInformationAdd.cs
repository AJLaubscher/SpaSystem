//41179196
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
    public partial class frmBookingInformationAdd : Form
    {
        public int empID;           //public variables holding the primary key of the selected records in the datagridView
        public int treatmentID;
        public int clientID;
        public double fTreatmentPrice;

        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        bool bTreatmentClick = false;       //
        bool bClientClick = false;
        bool bEmployeeClick = false;

        int fTotalRows;
        int treatmentRowIndex;

        public frmBookingInformationAdd()
        {
            InitializeComponent();
        }

        private void frmBookingInformationAdd_Load(object sender, EventArgs e)
        {
            displayAllClient();
            displayAllTreatment();
            displayAllEmployees();
        }

        private void displayAllClient()
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Clients WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Clients");

                // add data to datagrid
                dbGridClient.DataSource = dataSet;
                dbGridClient.DataMember = "Clients";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             // catch error and display message
            }
        }

        private void displayAllTreatment()
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Treatments WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Treatments");

                // add data to datagrid
                dbGridTreatment.DataSource = dataSet;
                dbGridTreatment.DataMember = "Treatments";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void displayAllEmployees()
        {
            try
            {
                // open connection
                conn.Open();
                string sqlQuery = $"SELECT * FROM Employees WHERE Deleted LIKE '{0}'";      // compile select query, Deleted Like '{0}' to only show records that have not been deleted
                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Employees");

                // add data to datagrid
                dbGridEmployee.DataSource = dataSet;
                dbGridEmployee.DataMember = "Employees";

                conn.Close();                                                               
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);                                             
            }
        }

        private void dbGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dbGridClient.RowCount;  //use total Rows to ensure that the user does not click on empty field

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dbGridClient.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                    bClientClick = false;
                }
                else
                {
                    clientID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    bClientClick = true;
                }
            }
        }

        private void dbGridTreatment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dbGridTreatment.RowCount;

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                treatmentRowIndex = index;

                DataGridViewRow row = this.dbGridTreatment.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                    bTreatmentClick = false;
                }
                else
                {
                    fTreatmentPrice = double.Parse(row.Cells[3].Value.ToString());
                    treatmentID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    bTreatmentClick = true;
                }
            }
        }

        private void dbGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dbGridEmployee.RowCount;

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                DataGridViewRow row = this.dbGridEmployee.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                    bEmployeeClick = false;
                }
                else
                {
                    empID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    bEmployeeClick = true;
                }

            }
        }

        private void btnClearClientInfo_Click(object sender, EventArgs e)
        {
            txtClientName.Clear();
            txtClientCell.Clear();
        }

        private void btnClearTreatmentInfo_Click(object sender, EventArgs e)
        {
            txtTreatmentName.Clear();
            txtTreatmentType.Clear();
        }

        private void btnClearEmployeeInfo_Click(object sender, EventArgs e)
        {
            txtEmployeeCell.Clear();
            txtEmployeeName.Clear();
        }

        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            if (bTreatmentClick == true && bEmployeeClick == true && bClientClick == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select all datagrids records");
            }
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Clients WHERE Name LIKE '%{txtClientName.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Clients");

                // fill datagrid
                dbGridClient.DataSource = dataSet;
                dbGridClient.DataMember = "Clients";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtClientCell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Clients WHERE Cell_Number LIKE '%{txtClientCell.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Clients");

                // fill datagrid
                dbGridClient.DataSource = dataSet;
                dbGridClient.DataMember = "Clients";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtTreatmentName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Treatments WHERE Name LIKE '%{txtTreatmentName.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Treatments");

                // fill datagrid
                dbGridTreatment.DataSource = dataSet;
                dbGridTreatment.DataMember = "Treatments";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtTreatmentType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Treatments WHERE _Type LIKE '%{txtTreatmentType.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Treatments");

                // fill datagrid
                dbGridTreatment.DataSource = dataSet;
                dbGridTreatment.DataMember = "Treatments";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Employees WHERE Employee_Name LIKE '%{txtEmployeeName.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Employees");

                // fill datagrid
                dbGridEmployee.DataSource = dataSet;
                dbGridEmployee.DataMember = "Employees";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtEmployeeCell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlSearch = $"SELECT * FROM Employees WHERE Cell_Phone_Number LIKE '%{txtEmployeeCell.Text}%'";
                command = new SqlCommand(sqlSearch, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Employees");

                // fill datagrid
                dbGridEmployee.DataSource = dataSet;
                dbGridEmployee.DataMember = "Employees";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
