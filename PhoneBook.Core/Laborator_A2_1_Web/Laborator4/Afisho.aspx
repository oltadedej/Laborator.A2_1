<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Afisho.aspx.cs" Inherits="Laborator_A2_1_Web.Laborator4.Afisho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel runat="server" ID="pnlDetail">
                <fieldset>
                    <legend>Student Detail</legend>
                    <asp:Label runat="server">Student Name:</asp:Label>
                    <asp:Label runat="server" ID="lblName"></asp:Label>
                    <br />
                    <asp:Label runat="server">Student Surname:</asp:Label>
                    <asp:Label runat="server" ID="lblSurname"></asp:Label>
                    <br />
                    <asp:Label runat="server">Student Enrollment Date:</asp:Label>
                    <asp:Label runat="server" ID="lblEnrollmentDate"></asp:Label>
                    <br />
                </fieldset>

                <br />
                <fieldset>
                    <legend>Student Courses</legend>
                    <asp:GridView ID="gdvCourse" EmptyDataText="Ky student nuk eshte regjistruar ne asnje kurs" DataKeyNames="CourseId"
                        DataMember="Course"
                        AutoGenerateColumns="false"
                        runat="server">
                        <Columns>
                            <asp:BoundField DataField="CourseTitle" HeaderText="Titulli i kursit" />
                            <asp:BoundField DataField="Credits" HeaderText="Kreditet e kursit" />
                        </Columns>


                    </asp:GridView>
                </fieldset>

            </asp:Panel>
        </div>
    </form>
</body>
</html>
