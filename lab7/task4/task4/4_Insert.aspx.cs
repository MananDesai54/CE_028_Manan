using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class _4_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Student stu = new Student
                {
                    sid = Int32.Parse(TextBox6.Text),
                    name = TextBox1.Text.ToString(),
                    sem = Int32.Parse(TextBox2.Text),
                    cpi = float.Parse(TextBox5.Text),
                    contactno = TextBox3.Text.ToString(),
                    emailid = TextBox4.Text.ToString()
                };
                db.Students.InsertOnSubmit(stu);
                db.SubmitChanges();
                Response.Redirect("4_Show.aspx");
            }
        }
    }
}