<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ddl_Selected_Red_Color.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator3.Ddl_Selected_Red_Color" %>

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

            <asp:DropDownList ID="ddlNgjyrat" AutoPostBack="true"  OnSelectedIndexChanged="ddlNgjyrat_SelectedIndexChanged"   runat="server">

                <asp:ListItem> Zgjidhni ngjyren</asp:ListItem>
                <asp:ListItem> E kuqe</asp:ListItem>
                <asp:ListItem> Jeshile</asp:ListItem>
                <asp:ListItem> Blu</asp:ListItem>
            </asp:DropDownList>

              <asp:Label runat ="server" ID="NrElementsh" ></asp:Label>
        </div>
    </form>
</body>
</html>
