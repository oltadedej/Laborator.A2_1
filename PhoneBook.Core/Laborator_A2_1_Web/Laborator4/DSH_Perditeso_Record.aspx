<%@ Page Language="C#" AutoEventWireup="true"  UnobtrusiveValidationMode="None" CodeBehind="DSH_Perditeso_Record.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator4.DSH_Perditeso_Record" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
      <div>
            <asp:Label runat="server" ID="lbl1">
                PhoneBook Records
            </asp:Label>
            <br />
            <asp:DropDownList runat="server" ID="ddl1"></asp:DropDownList>

            <asp:Panel runat="server" ID="panel1">
                <fieldset>
                    <legend>Shto Record Panel</legend>
                    <asp:Label runat="server" ID="lbl2">
                        PhoneBookPersonName
                    </asp:Label>

                    <asp:TextBox runat="server" ID="txtPhoneBookPersonName"></asp:TextBox>
                    <asp:RequiredFieldValidator ValidationGroup="modifikoRecord" runat="server" ID="rfl1" ControlToValidate="txtPhoneBookPersonName" ErrorMessage="Ju lutem plotesoni emrin" ForeColor="Red"> </asp:RequiredFieldValidator>
                    <br />
                    <asp:Label runat="server" ID="Label1">
                        PhoneBookNumber
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtPhoneNumber"></asp:TextBox>
                    <asp:RequiredFieldValidator ValidationGroup="modifikoRecord" runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtPhoneNumber"
                        ErrorMessage="Ju lutem plotesoni numrin e telefonit" ForeColor="Red"> </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationGroup="modifikoRecord" runat="server" ID="rex1" ControlToValidate="txtPhoneNumber"
                         ErrorMessage="Ju lutem vendosni nr ne formatin e duhur"  ValidationExpression="^[+]{1}[0-9]{10}$" />
                    <br />
                    <%-- ^ --> tregon fillimin e Shprehjes se rregullt
                        [] tregojne perkatesisht nje element
                        [0-9] kllapat katrore te ndara me vize ne mes tregojne nje bashkesi karakteresh (0,1,2,3,4,5,6,7,8,9)
                        {} //tregojne numrin e hereve qe perseritet shprehja ne kllapa katrore
                        $ // tregon fundin e shprehjes se rregullt
                        --%>
                     <asp:Label runat="server" ID="Label2">
                        PhoneBookType
                    </asp:Label>
                    <asp:RadioButtonList ID="rdlPhoneBookType" runat="server">
                        <asp:ListItem Value=""> Zgjidhni tipin e nr te telefonit</asp:ListItem>
                        <asp:ListItem Value="1">Cellular</asp:ListItem>
                        <asp:ListItem Value="2">Work</asp:ListItem>
                        <asp:ListItem Value="3">Home</asp:ListItem>
                    </asp:RadioButtonList>

                      <asp:RequiredFieldValidator ValidationGroup="modifikoRecord" runat="server" ID="RequiredFieldValidator2" ControlToValidate="rdlPhoneBookType"
                        ErrorMessage="Ju lutem plotesoni tipin e nr e telefonit" ForeColor="Red"
                           InitialValue=""></asp:RequiredFieldValidator>
                  
                    <br />
                    <asp:Button ID="btnModifiko" runat="server"  OnClick="btnModifiko_Click"  ValidationGroup="modifikoRecord" Text="Modifiko record" />


                
                </fieldset>


            </asp:Panel>
        </div>
    </form>
</body>
</html>
