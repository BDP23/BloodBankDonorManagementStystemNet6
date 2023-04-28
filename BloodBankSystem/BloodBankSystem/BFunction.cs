using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem
{
    internal class BFunction
    {
        // all button functions will be palced here '1st version added to github "ONLY PUBLIC WAS WRITTIEN HERE"'
       
        //INSTANCE OF A CONCTION
        protected readonly BloodBank2Entities BloodOBJ;   //  <----- this object might need to be moved in a private global setting


    }

    /*
     public DataSet getData(String query)
    {
        SqlConnection con = BloodBank2Entities();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = query;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    */

   




}
