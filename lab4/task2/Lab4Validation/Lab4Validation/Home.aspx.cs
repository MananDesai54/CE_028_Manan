using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4Validation
{
    public partial class Home : System.Web.UI.Page
    {
        public string[] cityArray = { };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            nameL.Text = name.Text;
            ageL.Text = age.Text;
            genderL.Text = gender.SelectedValue;
            for(int i=0;i<hobbies.Items.Count;i++)
            {
                hobbiesL.Text += hobbies.Items[i]+" ";
            }
            mobileL.Text = mobile.Text;
            cityL.Text = city.Text;
            stateL.Text = state.SelectedValue;
            panL.Text = panL.Text;
        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(state.SelectedValue == "-1")
            {
                city.Enabled = false;
                city.Items.Clear();
            }else if(state.SelectedValue == "gj")
            {
                city.Enabled = true;
                city.Items.Add(new ListItem("Ahmedabad", "Ahmedabad"));
                city.Items.Add(new ListItem("Surat", "Surat"));
            }else if (state.SelectedValue == "mh")
            {
                city.Enabled = true;
                city.Items.Add(new ListItem("Mumbai", "Mumbai"));
                city.Items.Add(new ListItem("Pune", "Pune"));
            }
        }

        protected void mobile_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}