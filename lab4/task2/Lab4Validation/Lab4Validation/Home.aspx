<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab4Validation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Home<br />
            <br />
            Full name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:Label ID="nameE" runat="server"></asp:Label>
            <br />
            <br />
            Age :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:Label ID="ageE" runat="server"></asp:Label>
            <br />
            <br />
            password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            Re-Password :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="repassword" runat="server"></asp:TextBox>
            <asp:Label ID="passwordE" runat="server"></asp:Label>
            <br />
            <br />
            Gender :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="gender" runat="server" Height="16px" Width="173px">
                <asp:ListItem Value="female">Female</asp:ListItem>
                <asp:ListItem Value="male">Male</asp:ListItem>
                <asp:ListItem Value="not">Prefer No To Say</asp:ListItem>
            </asp:RadioButtonList>
&nbsp;<br />
            Mobile NO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="mobile" runat="server" AutoPostBack="True" OnTextChanged="mobile_TextChanged"></asp:TextBox>
            <br />
            
            <br />
            Hobbies :&nbsp;&nbsp;
            <asp:CheckBoxList ID="hobbies" runat="server">
                <asp:ListItem Value="coding">Coding</asp:ListItem>
                <asp:ListItem Value="development">Development</asp:ListItem>
                <asp:ListItem Value="cp">CP</asp:ListItem>
                <asp:ListItem Value="youtube">YouTube</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            State :&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="state" runat="server" AutoPostBack="True" OnSelectedIndexChanged="state_SelectedIndexChanged">
                <asp:ListItem Value="-1">select</asp:ListItem>
                <asp:ListItem Value="gj">Gujarat</asp:ListItem>
                <asp:ListItem Value="mh">Maharastra</asp:ListItem>
            </asp:DropDownList>
            <br />
            City&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="city" runat="server" Enabled="False">
            </asp:DropDownList>
            <br />
            <br />
            Pan :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pan" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="validate" runat="server" OnClick="submit_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="nameL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="ageL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="genderL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="hobbiesL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="mobileL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="cityL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="stateL" runat="server"></asp:Label>
            <br />
            <asp:Label ID="panL" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
