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
    public partial class DEditing : Form
    {
        //private bool isEditMode;
        protected readonly BloodBank2Entities BloodOBJ;
        public DEditing()
        {
            InitializeComponent();
            //lblTitle.Text = "Edit/Update Donor";
            //isEditMode = false;
            BloodOBJ = new BloodBank2Entities();
        }

        public DEditing(NewDonor editDonor)
        {
            InitializeComponent();
            //lblTitle.Text = "Edit/Update Donor";
            //isEditMode = true;
            LoadData(editDonor);
            BloodOBJ = new BloodBank2Entities();

        }

        private void LoadData(NewDonor Dono)
        {
            //lblTitle.Text = Dono.ID.ToString();
            txtfname.Text = Dono.fname;
            txtlname.Text = Dono.lname;
            txtCity.Text = Dono.city;
            txtemail.Text = Dono.email;
            txtgender.Text = Dono.gender;
            txtBloodGroup.Text = Dono.bloodgroup;
            txtAddress.Text = Dono.bAddress;
            //txtDOB.Text = DateTime.Parse(Dono.DOB);                      //txtDOB.Text = Dono.DOB;  
            txtBloodLitres.Text = Dono.bloodQuantity.ToString();
            txtphone.Text = Dono.telephone.ToString();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                 //Editing/Updating codes
                //var id = int.Parse(lblTitle.Text);
                var Dono = BloodOBJ.NewDonors.FirstOrDefault();      //q => q.ID == id)
                Dono.fname = txtfname.Text;
                Dono.lname = txtlname.Text;
                Dono.email = txtemail.Text;
                Dono.telephone = int.Parse(txtphone.Text);
                Dono.gender = txtgender.Text;
                Dono.bloodgroup = txtBloodGroup.Text;
                Dono.city = txtCity.Text;
                Dono.bAddress = txtAddress.Text;
                Dono.bloodQuantity = int.Parse(txtBloodLitres.Text);
                //Dono.DOB = txtDOB.Text;                                 //might cause issues when updating

                BloodOBJ.SaveChanges();
                MessageBox.Show("Successfullt Saved...");
            
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
           
               
            /*if(isEditMode)
            {

            }
            else
            {

            }*/


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)        //does not have this button
        {

        }
    }
}
