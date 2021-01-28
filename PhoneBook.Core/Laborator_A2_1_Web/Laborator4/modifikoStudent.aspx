<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None"  CodeBehind="modifikoStudent.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator4.modifikoStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> Emri i studentit:</asp:Label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqfName" runat="server" ControlToValidate="txtName"
                ErrorMessage="Plotesoni emrin"></asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server"> Mbiemri i studentit:</asp:Label>
            <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSurname"
                ErrorMessage="Plotesoni mbiemrin"></asp:RequiredFieldValidator>

            <asp:TextBox runat="server" ID="txtEnrollmentDate" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEnrollmentDate"
                ErrorMessage="Plotesoni daten e regjistrimi"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regular" runat="server"
                ControlToValidate="txtEnrollmentDate" 
                 ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[/.](0[1-9]|1[012])[/.](19|20)\d\d$"
                ErrorMessage="Data ne formatin dd/MM/yyyy" >
            </asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="btnModiko" Text="Modifiko Student" runat="server" OnClick="btnModiko_Click" />
             <asp:Label ID="error" runat="server"></asp:Label>
            

        </div>
    </form>
</body>
</html>
