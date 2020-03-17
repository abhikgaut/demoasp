using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        db4Entities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new db4Entities();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(Texteno.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            D.EMPDATAs.Remove(emp);
            D.SaveChanges();
        }

        protected void Texteno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}