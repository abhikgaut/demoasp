using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace demoasp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           con=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet Ds = new DataSet();
            adp.Fill(Ds,"E");
            DataRow R = Ds.Tables["E"].NewRow();
            R[0] = int.Parse(txteno.Text);
            R[1] = txtname.Text;
            R[2] = txtjob.Text;
            R[3] = int.Parse(txtmid.Text);
            R[4] = DateTime.Parse(txtdate.Text);
            R[5] = int.Parse(txtsal.Text);
            R[6] = int.Parse(txtcom.Text);
            R[7] = int.Parse(txtdno.Text);
            Ds.Tables["E"].Rows.Add(R);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            adp.InsertCommand = cmd.GetInsertCommand();
            adp.Update(Ds, "E");
            Response.Write(@"<script lang='Javascript'> alert('1 row inserted')</script>");
        }
    }
}