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
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            adp = new SqlDataAdapter("sp_extractdept", con);
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddldeptno.Enabled = false;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet d = new DataSet();
                adp.Fill(d, "P");
                ddldeptno.DataSource = d.Tables["P"];
                ddldeptno.DataTextField = "dname";
                ddldeptno.DataValueField = "deptno";
                ddldeptno.DataBind();
            }
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rdbHire_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHire.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                ddldeptno.Enabled = false;
            }
        }

        protected void rdbdno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdno.Checked)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }

        protected void ddldeptno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbHire.Checked)
            {
                
                    adp = new SqlDataAdapter("sp_search1", con);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@start", DateTime.Parse(txtStart.Text));
                    adp.SelectCommand.Parameters.AddWithValue("@end", DateTime.Parse(txtEnd.Text));
                    DataSet d = new DataSet();
                    adp.Fill(d, "E");
                    dgvdetail.DataSource = d.Tables["E"];
                    dgvdetail.DataBind();
                
            }
            else if (rdbdno.Checked)
            {
                
                    adp = new SqlDataAdapter("sp_getdeptDetail", con);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@deptno", ddldeptno.SelectedValue);
                    DataSet d = new DataSet();
                    adp.Fill(d, "E");
                    dgvdetail.DataSource = d.Tables["E"];
                    dgvdetail.DataBind();
                
            }
        }
    }
}