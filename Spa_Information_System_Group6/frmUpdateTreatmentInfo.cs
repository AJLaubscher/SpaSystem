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
    public partial class frmUpdateTreatmentInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2999I1K;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public bool bTreatmentClick = false;       //
        int treatmentRowIndex;
        int fTotalRows;
        public int treatmentID;
        public frmUpdateTreatmentInfo()
        {
            InitializeComponent();
        }

        private void frmUpdateTreatmentInfo_Load(object sender, EventArgs e)
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
                dbGridTreatmentInfo.DataSource = dataSet;
                dbGridTreatmentInfo.DataMember = "Treatments";

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
                dbGridTreatmentInfo.DataSource = dataSet;
                dbGridTreatmentInfo.DataMember = "Treatments";

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
                dbGridTreatmentInfo.DataSource = dataSet;
                dbGridTreatmentInfo.DataMember = "Treatments";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClearTreatmentInfo_Click(object sender, EventArgs e)
        {
            txtTreatmentName.Clear();
            txtTreatmentType.Clear();
        }

        private void dbGridTreatmentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         }

        private void btnChangeTreatment_Click(object sender, EventArgs e)
        {
            if(bTreatmentClick == true)
            {
                MessageBox.Show("Sucessfully Selected TreatmentID : " + treatmentID.ToString());
            }    
            else
            {
                MessageBox.Show("No treatment Selected");
            }
            this.Close();
        }

        private void dbGridTreatmentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRows = dbGridTreatmentInfo.RowCount;

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;         // get the selected row index

                treatmentRowIndex = index;

                DataGridViewRow row = this.dbGridTreatmentInfo.Rows[index];  // cast collum values of row to variable
                fTotalRows = totalRows;

                if (index == totalRows - 1)
                {
                    MessageBox.Show("Please select a filled record");
                    bTreatmentClick = false;
                }
                else
                {
                    treatmentID = int.Parse(row.Cells[0].Value.ToString());   // retrieve primary key value
                    bTreatmentClick = true;
                }
            }
        }
    }
}
