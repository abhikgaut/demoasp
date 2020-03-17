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
    public partial class extract : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            adp = new SqlDataAdapter("sp_extractdept", con);
            if (!IsPostBack)
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet d = new DataSet();
                adp.Fill(d, "P");
                ddDeptno.DataSource = d.Tables["P"];
                ddDeptno.DataTextField = "dname";
                ddDeptno.DataValueField = "deptno";
                ddDeptno.DataBind();
            }

        }     

        protected void ddDeptno1(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_getdeptDetail", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@deptno", ddDeptno.SelectedValue);
            DataSet d = new DataSet();
            adp.Fill(d, "E");
            gvdata.DataSource = d.Tables["E"];
            gvdata.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void gvdata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}