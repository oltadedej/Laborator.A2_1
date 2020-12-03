<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ushtrimi3_Web_Forms.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator2.Ushtrimi3_Web_Forms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Ngjyrat"></asp:Label>
            <br />

            <asp:DropDownList ID="ddlNgjyrat" runat="server">

                <asp:ListItem> E kuqe</asp:ListItem>
                <asp:ListItem> Jeshile</asp:ListItem>
                <asp:ListItem> Blu</asp:ListItem>
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
