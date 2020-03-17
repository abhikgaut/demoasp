using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace demoasp
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@u", txtuser.Text);
            adp.SelectCommand.Parameters.AddWithValue("@p", txtpass.Text);
            SqlParameter P = new SqlParameter("@c", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet d = new DataSet();
            adp.Fill(d, "l");
            if (P.Value.ToString() == "1")
            {
                Response.Cookies["username"].Value = txtuser.Text;
                Response.Redirect("addemp.aspx");
            }
            else
                Label1.Text = "invalid credential";
                txtuser.Text = "";
                txtuser.Focus();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@u", txtuser.Text);
            adp.SelectCommand.Parameters.AddWithValue("@p", txtpass.Text);
            SqlParameter P = new SqlParameter("@c", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet d = new DataSet();
            adp.Fill(d, "l");
            if (P.Value.ToString() == "1")
            {
                Session["user"] = txtuser.Text;
                Response.Redirect("addemp.aspx");
            }
            else
                Label1.Text = "invalid credential";
            txtuser.Text = "";
            txtuser.Focus();
        }
    }
}