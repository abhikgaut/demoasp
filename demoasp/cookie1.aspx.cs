using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class cookie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                Response.Cookies["u"].Value = TextBox1.Text;

                HttpCookie H = new HttpCookie("u");
                H.Value = TextBox1.Text;
                Response.Cookies.Add(H);

                Response.Cookies["u"].Expires = DateTime.Now.AddSeconds(15);
                Response.Redirect("cookie2.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}