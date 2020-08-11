using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["UserInfo"];
                if (cookie != null)
                {
                    username.Text = Request.Cookies["UserInfo"]["username"];
                    password.Text = Request.Cookies["UserInfo"]["password"];
                    email.Text = Request.Cookies["UserInfo"]["email"];
                    if (Request.Cookies["UserInfo"]["gender"] == "male")
                    {
                        RadioButtonList1.SelectedIndex = 0;
                    }
                    else
                    {
                        RadioButtonList1.SelectedIndex = 1;
                    }
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie == null)
            {
                HttpCookie cookie1 = new HttpCookie("UserInfo");
                cookie1["username"] = username.Text;
                cookie1["password"] = password.Text;
                cookie1["email"] = email.Text;
                if(RadioButtonList1.SelectedItem.Text == "Male")
                {
                    cookie1["gender"] = "male";
                }
                else
                {
                    cookie1["gender"] = "female";
                }
                cookie1.Expires.AddYears(1);
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "New Record Save Sucsessfully.";
                Response.Cookies.Add(cookie1);

            }
            else
            {
                cookie["username"] = username.Text;
                cookie["password"] = password.Text;
                cookie["email"] = email.Text;
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    cookie["gender"] = "male";
                }
                else
                {
                    cookie["gender"] = "female";
                }
                cookie.Expires.AddYears(1);
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Record Save Sucsessfully.";
                Response.Cookies.Add(cookie);
            }
            
        }

        protected void remove_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if(cookie != null)
            {
                Response.Cookies["UserInfo"].Expires = DateTime.Now.AddDays(-1);
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Record Delete Sucsessfully.";
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Please Insert Record";
            }
            username.Text = "";
            password.Text = "";
            email.Text = "";
            RadioButtonList1.SelectedIndex = -1;
            
        }
    }
}