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
    public partial class UpdateDonorDetails : Form
    {
        protected readonly BloodBank2Entities BloodOBJ;
        public UpdateDonorDetails()
        {
            InitializeComponent();
            BloodOBJ = new BloodBank2Entities();
            //loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
        
        /*void loadData()
        {
            var st = from s in BloodOBJ.NewDonors select s;
            dataGridView1.DataSource = st;
        }*/

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            //adding data in datagridView
            //var donors = BloodOBJ.NewDonors.ToList();
           /* var donors = BloodOBJ.NewDonors
                .Select(q => new 
                { ID = q.ID, First_Name = q.fname, Lastst_Name = q.lname,
                Date_of_Birth = q.DOB, Telephone = q.telephone, Gender = q.gender, 
                Email = q.email,
                Blood_Group = q.bloodgroup,
                Blood_Quantity = q.bloodQuantity, City = q.city,
                Address = q.bAddress}).ToList();

            dataGridView1.DataSource = donors;*/
          


        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*
            int d_id = int.Parse(txtdonorID.Text);
            //.NewDonors.ID = d_id;
            var st = (from s in BloodOBJ.NewDonors where s.ID == int.Parse(txtdonorID.Text) select s).First();
            st.fname = txtfname.Text;
            st.lname = txtlname.Text;
            st.email = txtemail.Text;
            st.DOB = txtDOB.Text;
            st.telephone = int.Parse(txtphone.Text);
            st.bloodgroup = txtBloodGroup.Text;
            st.gender = txtgender.Text;
            st.bAddress = txtAddress.Text;
            st.bloodQuantity = int.Parse(txtBloodLitres.Text);
            st.city = txtCity.Text;
            MessageBox.Show("Successfully Updated");*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manDB = new ManageDonor();
            manDB.MdiParent = this;
            manDB.Show();
        }
    }

    
}
