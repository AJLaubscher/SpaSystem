using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa_Information_System_Group6
{
    public partial class Main : Form
    {

        public Boolean fAdministrator;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;    //remove controls to exit form, user to use exit button created in the form

            if (fAdministrator == true)
            {
                btnTreatments.Visible = true;
                btnEmployees.Visible = true;
            }
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            Maintain_Treatments newTreatment = new Maintain_Treatments();
            //this.Hide();
            newTreatment.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close application
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Maintain_Clients newClient = new Maintain_Clients();
            //this.Hide();
            newClient.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Request_Reports newReport = new Request_Reports();
            //this.Hide();
            newReport.ShowDialog();
        }
    }
}
