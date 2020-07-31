using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4Validation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string uName = username.Text;
            string pswd = password.Text;

            if(uName.ToLower().Equals("admin") && pswd.ToLower().Equals("admin"))
            {
                Response.Redirect("Home.aspx");
            }else
            {
                error.Text = "Invalid Credentials";
            }
        }
    }
}