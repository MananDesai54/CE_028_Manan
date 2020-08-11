<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="1_WebForm1.aspx">
        <div style="margin-left: 40px">
            UserName:
            <asp:TextBox ID="username"  runat="server"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            Email-ID:&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            Gender:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="61px" Width="122px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="remove" runat="server" Text="Delete Cookie" OnClick="remove_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
