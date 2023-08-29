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
            if(fAdministrator == true)
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
    }
}
