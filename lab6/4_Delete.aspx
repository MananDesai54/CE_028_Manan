<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Delete.aspx.cs" Inherits="Lab7_Task4.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body bgcolor="lightgreen">
    <h1 align="center">Delete Page</h1>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            Id :-&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Submit" runat="server" Text="Delete" OnClick="Submit_Click" style="height: 28px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Update_data"><a href="Update.aspx">Update_Data</a></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Delete_data"><a href="Insert.aspx">Insert_Data</a></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Show_data"><a href="Show.aspx">Show_Data</a></asp:Label>
        </div>
    </form>
</body>
</html>
