<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ushtrimi1_Web_Forms.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator2.Ushtrimi1_Web_Forms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <div>

            <asp:Label ID="EmerMbiemer" runat="server" Text="Olta Dedej"></asp:Label>
            <br />
            <asp:TextBox ID="Mosha" runat="server" TextMode="Number" Text="20"></asp:TextBox>
            <br />
            <asp:TextBox ID="Datelindja" TextMode="Date" Text="2020-10-10" runat="server"></asp:TextBox>
       
            <br />

            <asp:Panel ID="Panel1" runat="server">
                <asp:Image ID="Image1" runat="server" AlternateText="Imazh kundrejt Asp.Net" ImageUrl="~/Img/download.jpg" />
            </asp:Panel>

            <br />
            <asp:CheckBox ID="Femer" Text="Femer"   runat="server" />
            <br />
            <asp:CheckBox ID="Mashkull" runat="server" Text-="Mashkull" />


        </div>
    </form>
</body>
</html>
