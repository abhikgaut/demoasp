using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        db4Entities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new db4Entities();
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddldeptno.Enabled = false;
                D = new db4Entities();
                var E = from E1 in D.DEPTDATAs
                        select new { E1.DEPTNO, E1.DNAME };
                //List<DEPTDATA> DP = E.ToList();
                ddldeptno.DataValueField = "DEPTNO";
                ddldeptno.DataTextField = "DNAME";
                ddldeptno.DataSource = E.ToList();
                DataBind();
            }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbHire.Checked)
            {
                DateTime start = DateTime.Parse(txtStart.Text);
                DateTime end = DateTime.Parse(txtEnd.Text);
                var E = from E1 in D.EMPDATAs
                        where E1.HIREDATE >= start && E1.HIREDATE >= end
                        select E1;
                List<EMPDATA> emp = E.ToList();
                dgvdetail.DataSource = emp;
                dgvdetail.DataBind();
                if (dgvdetail.Rows.Count == 0)
                    Label1.Text = "no data found";


            }
            else if (rdbdno.Checked)
            {
                int dno = int.Parse(ddldeptno.SelectedValue);
                var E = from E1 in D.EMPDATAs
                        where E1.DEPTNO==dno
                        select E1;
                List<EMPDATA> emp = E.ToList();
                dgvdetail.DataSource = emp;
                dgvdetail.DataBind();
                if (dgvdetail.Rows.Count == 0)
                    Label1.Text = "no data found";

            }
        }

        protected void ddldeptno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}