using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class _4_show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("4_Insert.aspx"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("4_Update.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("4_Delete.aspx");
        }
    }
}