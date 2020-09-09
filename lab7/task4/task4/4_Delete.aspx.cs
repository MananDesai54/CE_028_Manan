using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class _4_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            int id =Int32.Parse(TextBox1.Text);
            Student s = db.Students.SingleOrDefault(stu => stu.sid == id);
            db.Students.DeleteOnSubmit(s);
            db.SubmitChanges();
            Response.Redirect("4_Show.aspx");
        }
    }
}