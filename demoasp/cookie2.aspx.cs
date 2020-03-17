using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Cookies["u"].Value;
            Response.Write(s);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cookie3.aspx");
        }
    }
}