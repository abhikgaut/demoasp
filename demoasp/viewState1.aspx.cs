using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    
    public partial class WebForm10 : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["V"] == null)
                ViewState["V"] = 10;
            else
                ViewState["V"] = (int)ViewState["V"] + 1;
            i =10;
            TextBox1.Text = (++i).ToString();
            TextBox2.Text = ViewState["V"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewState2.aspx");


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}