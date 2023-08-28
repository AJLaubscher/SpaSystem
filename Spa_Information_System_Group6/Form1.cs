using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spa_Information_System_Group6
{
    public partial class LogIn : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;

        // variables
        public Boolean fPremium;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT * FROM Employees WHERE Username LIKE '%{txbxUsername.Text}%' AND Password LIKE '%{txbxPassword.Text}%'";

                command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                Boolean valid = false;

                while(reader.Read())
                {
                    if(txbxUsername.Text == reader.GetValue(6).ToString() && txbxPassword.Text == reader.GetValue(7).ToString() )//&& reader.GetValue(5).ToString() == "True")
                    {

                        fPremium = true;
                        valid = true;

                        break;
                    }
                    else if(txbxUsername.Text == reader.GetValue(6).ToString() && txbxPassword.Text == reader.GetValue(7).ToString() )//&& reader.GetValue(5).ToString() == "False")
                    {
                        fPremium = false;
                        valid = true;

                        break;
                    }
                   
                }

                conn.Close();

                if (!valid)
                {
                    MessageBox.Show("Incorrect username or password/ please try again");
                    txbxUsername.Text = "";
                    txbxUsername.Focus();
                    txbxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Log in Success");
                    Main newLog = new Main();

                    this.Hide();
                    newLog.ShowDialog();

                }
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
