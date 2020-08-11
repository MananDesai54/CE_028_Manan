using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            if ((pass == "admin") && (user != null))
            {
                Session["username"] = username.Text;
                Session["password"] = password.Text;
                Server.Transfer("2_home.aspx");
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Red;
                label.Text = "incorrect password";
            }
        }
    }
}