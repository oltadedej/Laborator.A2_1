<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="ModifikoStudent.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator4.ModifikoStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> Emri studentit</asp:Label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <br />
            <asp:Label runat="server"> Mbiemri i studentit</asp:Label>
            <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
            <br />
            <asp:Label runat="server"> Data e regjistrimit te studentit</asp:Label>
            <asp:TextBox runat="server" MaxLength="10" ID="txtEnrollmentDate"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" ErrorMessage="Data ne formatin dd/MM/yyyy"
                ID="reg1"
                 ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[/.](0[1-9]|1[012])[/.](19|20)\d\d$"
                ControlToValidate="txtEnrollmentDate">

            </asp:RegularExpressionValidator>
            <br />
            <asp:Button runat="server" ID="btnModifikoStudent" Text="Perditeso rekord" OnClick="btnModifikoStudent_Click" />
            <br />
            <asp:Label runat="server" ID="lblError"></asp:Label>


            <asp:Button runat="server" ID="LogOut" Text="Log Out" OnClick="LogOut_Click" />
            <br />
        </div>
    </form>
</body>
</html>
