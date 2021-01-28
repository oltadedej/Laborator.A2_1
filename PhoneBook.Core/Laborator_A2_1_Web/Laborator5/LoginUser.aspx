<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="LoginUser.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator5.LoginUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel" runat="server">
                <fieldset>
                    <legend>Log in into University System</legend>
                    <asp:Label runat="server"> Emaili juaj:</asp:Label>
                    <asp:TextBox    ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
                        ErrorMessage="Plotesoni Emailin"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ID="rex1" ControlToValidate="txtEmail"
                        ErrorMessage="Ju lutem vendosni emailin ne formatin e duhur"
                        ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />
                    <br />
                    <asp:Label runat="server" ID="Label4">
                      Password
                    </asp:Label>
                    <asp:TextBox TextMode="Password" runat="server" ID="txtPassword"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Plotesoni passwordin"></asp:RequiredFieldValidator>

                    <br />

                    <asp:Button ID="btn" runat="server" Text="Log In" OnClick="btn_Click" />

                    <asp:Label runat="server" ID="lblMessazhe" ForeColor="Red"></asp:Label>
                </fieldset>

            </asp:Panel>
        </div>
    </form>
</body>
</html>
