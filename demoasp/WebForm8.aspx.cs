using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    
    public partial class WebForm8 : System.Web.UI.Page
    {
        DB5Entities D = null;
        private void bind()
        {
            D = new DB5Entities();
            var v = from o in D.totalnews
                    select o;
            FormView1.DataSource = v.ToList();
            FormView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            bind();
        
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
        }
    }
}