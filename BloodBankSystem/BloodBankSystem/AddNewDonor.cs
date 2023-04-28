using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class AddNewDonor : Form
    {
        protected readonly BloodBank2Entities BloodOBJ;
        BFunction bfn = new BFunction();
        public AddNewDonor()
        {
            InitializeComponent();
            BloodOBJ= new BloodBank2Entities();
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            /* String query = "select max(ID) from NewDonor";  //this command is suppose to show the highest number on thw form when program runs
             DataSet ds = new DataSet(); */

            var bld = BloodOBJ.NewDonors.OrderByDescending(q => q.ID).FirstOrDefault();
            //labelNewID.Text = bld.ToString();
           // labelNewID.


            //int count = int.Parse();
            //labelNewID.Text = (bld + 1).ToString();   //CODES FOR LABEL COUNT ON FORM




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string dfname = txtfname.Text;
                string dlname = txtlname.Text;
                DateTime dDOB = Convert.ToDateTime(txtDOB.Text);                  //DateTime dDOB = txtDOB.Value;    ToString("yyyy-MM-dd")           DateTime dDOB = Convert.ToDateTime(txtDOB);
                string dphone = txtphone.Text;
                //var dgen = txtgender.SelectedItem.ToString();         //these were throwing some exception thingy's
                var dgen = txtgender.Text;

                string dema = txtemail.Text;
                string dgroup = txtBloodGroup.Text;
                //string dgroup = txtBloodGroup.SelectedItem.ToString();
                int dquan = Convert.ToInt32(txtBloodLitres.Text);
                string dcity = txtCity.Text;
                string dadd = txtAddress.Text;

                bool isValid = true;
                var errMessage = "";

                if (string.IsNullOrWhiteSpace(dfname) || string.IsNullOrWhiteSpace(dlname)
                    )
                {
                    isValid = false;
                    errMessage += "Error: Please enter missing data. \n\r";
                }


               if (dDOB > DateTime.Now)
                {
                    isValid = false;
                    errMessage += "Error: Illegal Date Selection. \n\r";
                }


                if (isValid)
                {
                    // saving data to database
                    var blb = new NewDonor();     //creating new record
                    blb.fname = dfname;             //database field name = winforms name
                    blb.lname = dlname;
                    blb.DOB = Convert.ToString(dDOB);           //if issues arise with these two fields, the conversion style nee changing
                    blb.telephone = Convert.ToInt64(dphone);
                    //blb.telephone = int.Parse(dphone.Text);
                    blb.gender = dgen;
                    blb.email = dema;
                    blb.bloodgroup = dgroup;
                    blb.bloodQuantity = dquan;
                    blb.city = dcity;
                    blb.bAddress = dadd;

                    BloodOBJ.NewDonors.Add(blb);        //adding data to table
                    BloodOBJ.SaveChanges();



                    MessageBox.Show($"Successfully Inserted" +                                    
                                    $"YOUR BLOOD WILL SAVE A LIFE");

                }
                else
                {
                    MessageBox.Show(errMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


            



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtDOB.ResetText();
            txtphone.ResetText();
            txtgender.ResetText();
            txtemail.Clear();
            txtBloodGroup.ResetText();
            txtBloodLitres.Clear();
            txtCity.Clear();            
            txtAddress.ResetText();

        }
    }
}
