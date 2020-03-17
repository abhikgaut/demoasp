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
    public partial class delete : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_delete", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(Texteno.Text));
            SqlParameter message = new SqlParameter("@status", SqlDbType.NVarChar,200);
            message.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(message);
            DataSet d = new DataSet();
            adp.Fill(d);
            Label1.Text = message.Value.ToString();
        }
    }
}