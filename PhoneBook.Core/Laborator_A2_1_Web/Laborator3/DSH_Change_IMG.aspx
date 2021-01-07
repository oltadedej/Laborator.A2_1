<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DSH_Change_IMG.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator3.DSH_Change_IMG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="EmerMbiemr" runat="server" Text="Olta Dedej"></asp:Label>
            <br />
            <asp:TextBox ID="Mosha" TextMode="Number" Text="10" runat="server"></asp:TextBox>
            <br />
            <%-- dd/MM/yyyy --%>
            <asp:TextBox ID="Ditelindja" TextMode="Date" Text="2000-10-10" runat="server"></asp:TextBox>
            <br />

            <asp:Panel ID="Panel1" runat="server">
                <asp:Image ID="Image1" runat="server" AlternateText="Imazhi Asp.NET"  ImageUrl="~/Img/download.jpg" />
            </asp:Panel>
            <br />

            <asp:CheckBox ID="Femer" Text="Femer" runat="server" />
            <br />
            <asp:CheckBox ID="Mashkull" Text="Mashkull" runat="server" />
            <asp:Label ID="AfishimMesazhi" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ndrysho Imazh" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
