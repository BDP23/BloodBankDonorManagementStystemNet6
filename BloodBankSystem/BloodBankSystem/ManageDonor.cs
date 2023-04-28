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
    public partial class ManageDonor : Form
    {
        protected readonly BloodBank2Entities BloodOBJ;
        public ManageDonor()
        {
            InitializeComponent();
            BloodOBJ = new BloodBank2Entities();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageDonor_Load(object sender, EventArgs e)
        {

            try 
            {
                TheFreshGrid();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            

        }

        private void TheFreshGrid()
        {
            //adding data in datagridView
            //var donors = BloodOBJ.NewDonors.ToList();
            var donors = BloodOBJ.NewDonors
                .Select(q => new
                {
                    ID = q.ID,
                    First_Name = q.fname,
                    Lastst_Name = q.lname,
                    Date_of_Birth = q.DOB,
                    Telephone = q.telephone,
                    Gender = q.gender,
                    Email = q.email,
                    Blood_Group = q.bloodgroup,
                    Blood_Quantity = q.bloodQuantity,
                    City = q.city,
                    Address = q.bAddress
                }).ToList();

            dvgridDon.DataSource = donors;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                var DonerDELETE = new DEditing();
                DonerDELETE.MdiParent = this.MdiParent;
                //DonerDELETE.Show();


                //get Id of selected row
                var id = (int)dvgridDon.SelectedRows[0].Cells["ID"].Value;




                //query database for record
                var donorr = BloodOBJ.NewDonors.FirstOrDefault(q => q.ID == id);



                //delete donor from table            
                 BloodOBJ.NewDonors.Remove(donorr);
                 BloodOBJ.SaveChanges();

                dvgridDon.Refresh();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            
             
        }

        private void btnSave_Click(object sender, EventArgs e)   //THE UPDATE BUTTON
        {
            try
            {

                var Donedt = new DEditing();
                Donedt.MdiParent = this.MdiParent;
                Donedt.Show();


                //get Id of selected row
                var id = (int)dvgridDon.SelectedRows[0].Cells["ID"].Value;




                //query database for record
                var donorr = BloodOBJ.NewDonors.FirstOrDefault(q => q.ID == id);



                //launch edit window with data
                var Doned = new DEditing(donorr);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
           


        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TheFreshGrid();
        }
    }
}
