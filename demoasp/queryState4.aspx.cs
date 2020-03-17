using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class queryState4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1 = Request.QueryString["a"];
            string s2 = Request.QueryString["b"];
            string s3 = Request.QueryString["c"];
            Response.Write(s1 + "   " + s2 + "   " + s3);

        }
    }
}