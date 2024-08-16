using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GateAccessSystem
{
    public partial class Dashboard : Form
    {
        
        
        public Dashboard()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            regManagement regManagement = new regManagement();
            regManagement.TopLevel = false;
            regManagement.FormBorderStyle = FormBorderStyle.None;
            regManagement.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(regManagement);
            regManagement.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_licensePlate licensePlate = new frm_licensePlate();
            licensePlate.TopLevel = false;
            licensePlate.FormBorderStyle = FormBorderStyle.None;
            licensePlate.Dock = DockStyle.Fill;
            panel2.Controls.Clear(); 
            panel2.Controls.Add(licensePlate);
            licensePlate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_driversLicense driversLicense = new frm_driversLicense();
            driversLicense.TopLevel = false;
            driversLicense.FormBorderStyle = FormBorderStyle.None;
            driversLicense.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(driversLicense);
            driversLicense.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_rfidTag rfidTag = new frm_rfidTag();
            rfidTag.TopLevel = false;
            rfidTag.FormBorderStyle = FormBorderStyle.None;
            rfidTag.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(rfidTag);
            rfidTag.Show(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
