<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TxtChanged.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator3.TxtChanged" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
            <asp:Label runat="server" ID="Label1"></asp:Label>
        </div>
    </form>
</body>
</html>
