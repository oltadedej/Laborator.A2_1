<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfishoStudent.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator4.AfishoStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> Emri studentit</asp:Label>
            <asp:Label runat="server" ID="lblName"></asp:Label>
            <br />
            <asp:Label runat="server"> Mbiemri i studentit</asp:Label>
            <asp:Label runat="server" ID="lblSurname"></asp:Label>
            <br />
            <asp:Label runat="server"> Data e regjistrimit te studentit</asp:Label>
            <asp:Label runat="server" MaxLength="10" ID="lblEnrollmentDate"></asp:Label>
            <br />

               <fieldset>
                    <legend>Student Courses</legend>
                    <asp:GridView ID="gdvCourse" EmptyDataText="Ky student nuk eshte regjistruar ne asnje kurs" 
                        DataKeyNames="CourseId"
                        DataMember="Course"
                        AutoGenerateColumns="false"
                        runat="server">
                        <Columns>
                            <asp:BoundField DataField="CourseTitle" HeaderText="Titulli i kursit" />
                            <asp:BoundField DataField="Credits" HeaderText="Kreditet e kursit" />
                        </Columns>


                    </asp:GridView>
                </fieldset>

        </div>
    </form>
</body>
</html>
