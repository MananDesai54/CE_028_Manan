using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumWebApp
{
    public partial class Addition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            result.Text = (Int32.Parse(num1.Text) + Int32.Parse(num2.Text)).ToString();
        }

        protected void num2_TextChanged(object sender, EventArgs e)
        {
            result.Text = (Int32.Parse(num1.Text) + Int32.Parse(num2.Text)).ToString();
        }
    }
}