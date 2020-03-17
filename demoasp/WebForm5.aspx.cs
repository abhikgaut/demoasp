using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        db4Entities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new db4Entities();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            try
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
                D.EMPDATAs.Add(E);
                D.SaveChanges();
            }
            catch (DbUpdateException EX)
            {
                SqlException ex = EX.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    Label1.Text = "no duplicate empno";
                else if (ex.Message.Contains("FK__Empdept"))
                    Label1.Text = "no dept no";
                else
                    Label1.Text = ex.Message;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("result",typeof(string));
            D.sp_validateLogin(int.Parse(txteno.Text), txtname.Text, txtjob.Text,int.Parse(txtmid.Text),DateTime.Parse(txtdate.Text), int.Parse(txtsal.Text), int.Parse(txtcom.Text), int.Parse(txtdno.Text),ob);
            Label1.Text = ob.Value.ToString();
        }
    }
}