using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    
    public partial class update : System.Web.UI.Page
    {
        db4Entities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new db4Entities();
        }

        protected void txteno_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txteno.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;
            EMPDATA emp = E.First();
            string hd= DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txtname.Text = emp.ENAME;
            txtjob.Text = emp.JOB;
            txtmid.Text = emp.MGR.ToString();
            txtsal.Text = emp.SAL.ToString();
            txtcom.Text = emp.COMM.ToString();
            txtdno.Text = emp.DEPTNO.ToString();
            txtdate.Text = hd;
        }

        protected void Button2_Click(object sender, EventArgs e) 
        {
            int c = 0;
            int eno = int.Parse(txteno.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            bool b = int.TryParse(txtcom.Text,out c);
            emp.ENAME = txtname.Text;
            emp.JOB = txtjob.Text;
            emp.MGR = int.Parse(txtmid.Text);
            emp.HIREDATE = DateTime.Parse(txtdate.Text);
            emp.SAL = int.Parse(txtsal.Text);
            if(c!=0)
            emp.COMM = c;
            emp.DEPTNO = int.Parse(txtdno.Text);
            D.SaveChanges();
        }
    }
}