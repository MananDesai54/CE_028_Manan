using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Server.Transfer("2_login.aspx");
            }
            object yours = Session["yours"];
            List<string> str = (List<string>)yours;
            object data = Session["data"];
            Dictionary<string, float> dic = (Dictionary<string, float>)data;
            HtmlTable table1 = new HtmlTable();
            table1.Border = 0;
            table1.CellPadding = 5;
            table1.CellSpacing = 5;
            int i = 1,payment=0;
            HtmlTableRow row;
            HtmlTableCell cell;
            row = new HtmlTableRow();
            cell = new HtmlTableCell();
            cell.InnerHtml ="Index";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "Name";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "Prices";
            row.Cells.Add(cell);
            table1.Rows.Add(row);
            foreach (string name in str)
            {
                row = new HtmlTableRow();
                cell = new HtmlTableCell();
                cell.InnerHtml = i.ToString();
                row.Cells.Add(cell);
                cell = new HtmlTableCell();
                cell.InnerHtml = name.ToString();
                row.Cells.Add(cell);
                cell = new HtmlTableCell();
                string price = dic[name.ToString()].ToString();
                cell.InnerHtml = price;
                row.Cells.Add(cell);
                table1.Rows.Add(row);
                payment = payment + Int32.Parse(price);
                i++;
            }
            row = new HtmlTableRow();
            cell = new HtmlTableCell();
            cell.InnerHtml = "Total Payment: " + payment+"/-";
            row.Cells.Add(cell);
            table1.Rows.Add(row);
            this.Controls.Add(table1);

        }
    }
}