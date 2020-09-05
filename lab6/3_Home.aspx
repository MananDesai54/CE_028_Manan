<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Home.aspx.cs" Inherits="Lab7_Task3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:lightgreen;
        }
        .auto-style1 {
            margin-left: 600px;
        }
        .auto-style3 {
            margin-left: 640px;
        }
    </style>
</head>
<body>
    <h1 align="center">Home Page</h1>
    <form id="form1" runat="server">
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;ENTER PRODUCT-ID</p>
        <p class="auto-style1">
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="180px" align ="center"></asp:TextBox>
        </p>
        <p class="auto-style3">
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Submit" Width="99px" OnClick="Button1_Click" align ="center"/>
        &nbsp;</p>
    </form>
</body>
</html>
