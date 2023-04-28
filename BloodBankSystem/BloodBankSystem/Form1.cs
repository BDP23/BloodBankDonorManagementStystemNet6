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
    public partial class LoginFormPage : Form
    {
        public LoginFormPage()
        {
            InitializeComponent();
        }

        private void BtnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(BtnHideShow.Text== "Show")
            {
                BtnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';   //displays stars in pasword texbox

            }
            else 
            {
                BtnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "hokipoki" && txtPassword.Text =="pass")
            {
                DashBoard dash = new DashBoard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void xuibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
