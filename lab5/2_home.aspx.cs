using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Server.Transfer("2_login.aspx");
            }
            userlabel.ForeColor = System.Drawing.Color.Red;
            userlabel.Text = (Session["username"]).ToString();
            Dictionary<string, float> dic = new Dictionary<string, float>();
            dic.Clear();
            dic.Add("Laptop", 55000);
            dic.Add("Mobile", 25000);
            dic.Add("Handsfree", 500);
            dic.Add("PenDrive", 700);
            dic.Add("Speaker", 1500);
            dic.Add("Tv", 47000);
            dic.Add("JavaScript",500);
            dic.Add("c++",450);
            dic.Add("Java",630);
            dic.Add("Python",230);
            dic.Add("Story_Book",90);
            dic.Add("T-Shirt",450);
            dic.Add("Jeans",520);
            dic.Add("Shirt",500);
            dic.Add("Skirt",490);
            Session["data"] = dic;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Label1.Text = (RadioButtonList1.SelectedItem.Text);
                
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Laptop (Rs: 55000)");
                ListBox1.Items.Add("Mobile (Rs: 25000)");
                ListBox1.Items.Add("Handsfree (Rs: 500)");
                ListBox1.Items.Add("PenDrive (Rs: 700)");
                ListBox1.Items.Add("Speaker (Rs: 1500)");
                ListBox1.Items.Add("Tv (Rs: 47000)");
            }
            else if(RadioButtonList1.SelectedIndex == 1)
            {
                Label1.Text = (RadioButtonList1.SelectedItem.Text);
                ListBox1.Items.Clear();
                ListBox1.Items.Add("JavaScript (Rs: 500)");
                ListBox1.Items.Add("c++ (Rs: 450)");
                ListBox1.Items.Add("Java (Rs: 630)");
                ListBox1.Items.Add("Python (Rs: 230)");
                ListBox1.Items.Add("Story_Book (Rs: 90)");

            }
            else if(RadioButtonList1.SelectedIndex == 2)
            {
                Label1.Text = (RadioButtonList1.SelectedItem.Text);
                ListBox1.Items.Clear();
                ListBox1.Items.Add("T-Shirt (Rs: 450)");
                ListBox1.Items.Add("Jeans (Rs: 520)");
                ListBox1.Items.Add("Shirt (Rs: 500)");
                ListBox1.Items.Add("Skirt (Rs: 490)");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = ListBox1.SelectedItem.Text;
            string[] words = str.Split(' ');
            ListBox2.Items.Add(words[0].ToString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string str = ListBox2.SelectedItem.Text;
            ListBox2.Items.Remove(str);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> yours = new List<string>();
            foreach (ListItem item in ListBox2.Items)
            {
                yours.Add(item.Text.ToString());
            }
            Session["yours"] = yours;
            Server.Transfer("2_order.aspx");
        }
    }
}