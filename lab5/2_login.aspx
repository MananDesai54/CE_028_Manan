<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:&nbsp;
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;
             <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox><br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
