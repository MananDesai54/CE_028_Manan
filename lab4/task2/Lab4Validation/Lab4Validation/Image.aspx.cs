using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            Image1.Visible = !Image1.Visible;
            if (Image1.Visible)
            {
                view.Text = "hide";
            }
            else
            {
                view.Text = "view";
            }
        }
    }
}