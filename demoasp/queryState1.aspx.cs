﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class queryState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("queryState2.aspx?A=10&B=20&C="+TextBox1.Text);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}