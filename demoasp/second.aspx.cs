using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class second : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            if (Session["E"] != null)
            {
                EMPDATA E = (EMPDATA)Session["E"];
                Label1.Text = E.EMPNO.ToString();
                Labelname.Text = E.ENAME.ToString();
                LabelJob.Text = E.JOB.ToString();
                LabelMgr.Text = E.MGR.ToString();
                LabelHire.Text = E.HIREDATE.ToString();
                LabelSal.Text = E.SAL.ToString();
                LabelComm.Text = E.COMM.ToString();
                LabelDno.Text = E.DEPTNO.ToString();
                Session.Remove("E");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(Label1.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", Labelname.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", LabelJob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(LabelMgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hdate", DateTime.Parse(LabelHire.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(LabelSal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse(LabelComm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(LabelDno.Text));
            SqlParameter message = new SqlParameter("@result", SqlDbType.NVarChar, 50);
            message.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(message);
            DataSet d = new DataSet();
            adp.Fill(d);
            Label1.Text = message.Value.ToString();
        }
    }
}