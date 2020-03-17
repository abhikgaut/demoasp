using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace demoasp
{
    public partial class addemp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse( txteno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtname.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse( txtmid.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hdate", DateTime.Parse( txtdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse( txtsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse( txtcom.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse( txtdno.Text));
            SqlParameter message=new SqlParameter("@result", SqlDbType.NVarChar, 50);
            message.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(message);
            DataSet d = new DataSet();
            adp.Fill(d);
            Label1.Text = message.Value.ToString();
            //DataSet Ds = new DataSet();
            //adp.Fill(Ds, "E");
            //DataRow R = Ds.Tables["E"].NewRow();
            //R[0] = int.Parse(txteno.Text);
            //R[1] = txtname.Text;
            //R[2] = txtjob.Text;
            //R[3] = int.Parse(txtmid.Text);
            //R[4] = DateTime.Parse(txtdate.Text);
            //R[5] = int.Parse(txtsal.Text);
            //R[6] = int.Parse(txtcom.Text);
            //R[7] = int.Parse(txtdno.Text);
            //Ds.Tables["E"].Rows.Add(R);
            //SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            //adp.InsertCommand = cmd.GetInsertCommand();
            //adp.Update(Ds, "E");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}