using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class _4_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            int id = Int32.Parse(TextBox1.Text);
            Student s = db.Students.SingleOrDefault(stu => stu.sid == id);
            s.name = TextBox2.Text;
            s.sem = Int32.Parse(TextBox3.Text);
            s.cpi = float.Parse(TextBox6.Text);
            s.contactno = TextBox4.Text;
            s.emailid = TextBox5.Text;
            db.SubmitChanges();
            Response.Redirect("4_Show.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int id = Int32.Parse(TextBox1.Text);
                Student s = db.Students.SingleOrDefault(stu => stu.sid == id);
                TextBox2.Text = s.name;
                TextBox3.Text = s.sem.ToString();
                TextBox6.Text = s.cpi.ToString();
                TextBox4.Text = s.contactno;
                TextBox5.Text = s.emailid;
                Panel1.Visible = true;
            }
        }
    }
}