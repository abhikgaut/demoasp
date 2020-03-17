using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class newaddemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txteno.Text);
            E.ENAME = txtname.Text;
            E.JOB = txtjob.Text;
            E.MGR = int.Parse(txtmid.Text);
            E.HIREDATE = DateTime.Parse(txtdate.Text);
            E.SAL = int.Parse(txtsal.Text);
            E.COMM = int.Parse(txtcom.Text);
            E.DEPTNO = int.Parse(txtdno.Text);
            Session["E"] = E;
            Response.Redirect("second.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}