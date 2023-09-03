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
        // Global sql connection
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLSERVER;Initial Catalog=SpaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;

        // variables 
        public Boolean fPremium;        // is this user an administrator? 

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

                while(reader.Read())        // read through eemployee table, compare username, password and check if user is an administrator
                {
                    if(txbxUsername.Text == reader.GetValue(6).ToString() && txbxPassword.Text == reader.GetValue(7).ToString()  && reader.GetValue(5).ToString() == "True")
                    {

                        fPremium = true;        // assign admin privilages if true
                        valid = true;           // username and password valid

                        break;
                    }
                    else if(txbxUsername.Text == reader.GetValue(6).ToString() && txbxPassword.Text == reader.GetValue(7).ToString() && reader.GetValue(5).ToString() == "False")
                    {
                        fPremium = false;       // ignore admin privilages
                        valid = true;           // username and password valid

                        break;
                    }
                   
                }

                conn.Close();

                if (!valid)     // check if validation was successful
                {
                    MessageBox.Show("Incorrect username or password/ please try again");    // if not valid clear fields and display message
                    txbxUsername.Text = "";
                    txbxUsername.Focus();
                    txbxPassword.Text = "";
                }
                else
                {
                   // MessageBox.Show("Log in Success");    
                   // open main form if validation is successful
                    Main newLog = new Main();
                    newLog.fAdministrator = fPremium;
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
