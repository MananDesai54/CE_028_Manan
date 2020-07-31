<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addition.aspx.cs" Inherits="SumWebApp.Addition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Numbers<br />
            <br />
            Num1 :
            <asp:TextBox ID="num1" runat="server"></asp:TextBox>
            <br />
            <br />
            Num2 :
            <asp:TextBox ID="num2" runat="server" AutoPostBack="True" OnTextChanged="num2_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="result" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
