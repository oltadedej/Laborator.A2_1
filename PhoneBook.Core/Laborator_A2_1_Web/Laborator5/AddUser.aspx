<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="AddUser.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator5.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:Panel runat="server" ID="panel1">
                <fieldset>
                    <legend>Shto Perdorues Panel</legend>
                    <asp:Label runat="server" ID="lbl2">
                        Name
                    </asp:Label>

                    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfl1" ControlToValidate="txtName" ErrorMessage="Ju lutem plotesoni emrin" ForeColor="Red"> </asp:RequiredFieldValidator>
                    <br />
                    <asp:Label runat="server" ID="Label1">
                        Surname
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtSurname"
                        ErrorMessage="Ju lutem plotesoni mbiemrin" ForeColor="Red"> </asp:RequiredFieldValidator>
                    <br />
                    <asp:Label runat="server" ID="Label3">
                        Email
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtEmail"
                        ErrorMessage="Ju lutem plotesoni emailin" ForeColor="Red"> </asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator runat="server" ID="rex1" ControlToValidate="txtEmail"
                        ErrorMessage="Ju lutem vendosni emailin ne formatin e duhur"
                        ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />
                    <br />
                    <asp:Label runat="server" ID="Label2">
                      Birthday
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtBirthday" MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBirthday"
                        ErrorMessage="Plotesoni ditelindjen"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regular" runat="server"
                        ControlToValidate="txtBirthday"
                        ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[/.](0[1-9]|1[012])[/.](19|20)\d\d$"
                        ErrorMessage="Data ne formatin dd/MM/yyyy">
                    </asp:RegularExpressionValidator>

                    <br />
                    <asp:Label runat="server" ID="Label4">
                      Password
                    </asp:Label>
                    <asp:TextBox runat="server"  TextMode="Password" ID="txtPassword"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Plotesoni passowrdin"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label runat="server" ID="Label5">
                     Confirm Password
                    </asp:Label>
                    <asp:TextBox runat="server" TextMode="Password" ID="txtCOnfirm"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCOnfirm"
                        ErrorMessage="Plotesoni Confirm Passwor"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cmpValidator" runat="server" ErrorMessage="Passwordet nuk perputhen"
                        ControlToCompare="txtPassword" ControlToValidate="txtCOnfirm"></asp:CompareValidator>


                    <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Add perdorues" />



                </fieldset>


            </asp:Panel>
        </div>
    </form>
</body>
</html>
