using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["username"] == null)
            //    Response.Redirect("login.aspx");
            //else
            //    Label1.Text = "welcome " + Request.Cookies["username"].Value;
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
                Label1.Text = "welcome " + Session["user"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (Request.Cookies["username"]!= null)
            //{
            //    HttpCookie acookie = HttpContext.Current.Request.Cookies["username"];
            //    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
            //   //  HttpContext.Current.Response.Cookies.Add(acookie);
            //    Response.Redirect("login.aspx");

            //}
            Session.Abandon();
            Session.Clear();
            Response.Redirect("login.aspx");
        }
    }
}