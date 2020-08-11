<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color: #000000; background-color: #FFFFFF">
            Welcome
            <asp:Label ID="userlabel" runat="server" Text="Label"></asp:Label>
&nbsp;to Home Page Of Shoping Application<br />
            <br />
           
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Electronics</asp:ListItem>
                <asp:ListItem>Books</asp:ListItem>
                <asp:ListItem>Cloths</asp:ListItem>
            </asp:RadioButtonList>
             Items of <asp:Label ID="Label1" runat="server"></asp:Label>:
            <br />
            <br />
           <table border="0">
               <tr>
                   <td>
                        Avilable items:<br />
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="120px" Width="160px"></asp:ListBox>
            
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
                   </td>
                   <td>
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;
                        <asp:Button ID="add" runat="server" OnClick="Button2_Click" Text="Add" /><br /> <br />
                   <asp:Button ID="remove" runat="server" OnClick="Button3_Click" Text="Remove" />   
                   &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   </td>
                   <td>
                        Your items:<br />
            <asp:ListBox ID="ListBox2" runat="server" Height="120px" Width="160px"></asp:ListBox>
                   </td>
               </tr>
           </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <br />
            <br />
              <asp:Button ID="Button1" runat="server" Text="Place Order" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
