<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab4Validation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login<br />
            <br />
            Username :
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Login" />
            <br />
        </div>
    </form>
</body>
</html>
