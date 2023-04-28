using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class DashBoard : Form
    {
        protected readonly BloodBank2Entities BloodOBJ;
        public DashBoard()
        {
            InitializeComponent();
            BloodOBJ = new BloodBank2Entities();

        }

        private void xuibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFormPage fm = new LoginFormPage();     //log out of dashboard and return to logingpage
            fm.Show();
            this.Hide();       // close/hide dashboard after showing logout page 


        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e) // Manage Donor
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            //udd.MdiParent = this;                 showing error when used
            udd.Show();
            
        }
    }
}
