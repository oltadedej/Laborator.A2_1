
using Laborator_A2_1_Web;
using Laborator_A2_1_Web.Laborator5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator4
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Tokens.LoggedUser != null)
                {

                    // krijimi i lidhjes me bazen e te dhenave
                    using (University1Entities dbcontext = new University1Entities())
                    {

                        gdvstudents.DataSource = dbcontext.Students.ToList();
                        gdvstudents.DataBind();


                    }
                }
                else
                {
                    Response.Redirect("~/Laborator5/LoginUser.aspx");
                }

            }

        }

        protected void gdvstudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idStudentToDelete = (int)gdvstudents.DataKeys[e.RowIndex].Value;

            using (University1Entities dbcontext = new University1Entities())
            {
                Student std = dbcontext.Students.ToList().FirstOrDefault(i => i.StudentId == idStudentToDelete);

                dbcontext.Students.Remove(std);
                dbcontext.SaveChanges();

                gdvstudents.DataSource = dbcontext.Students.ToList();
                gdvstudents.DataBind();

            }
        }

        protected void gdvstudents_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // specifikon nese jemi duke bredhur rreshtat e gridvies -- i behet skip headerit te gridviews
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Student std = e.Row.DataItem as Student;
                Label lbl = new Label();
                lbl = e.Row.FindControl("lblMessage") as Label; //ruhet referenca e labelit ne front-end
                if (lbl != null)
                {
                    DateTime dtToCompare = new DateTime(2020, 10, 1); //"2020-10-01 --01/10/2020"
                    if (std.EnrollmentDate > dtToCompare)
                    {
                        lbl.Text = "Regjistrimi me vonese";
                        lbl.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lbl.Text = "Regjistrimi ne kohe";
                        lbl.ForeColor = System.Drawing.Color.Green;
                    }

                    //menyra e pare-- ruaj referencen per butonin
                    //Button btn = new Button();
                    //btn = e.Row.FindControl("Btmodifiko") as Button;
                    //btn.PostBackUrl = "ModifikoStudent.aspx?idstudent=" + std.StudentId;
                }



            }

        }

        protected void gdvButtons_Command(object sender, CommandEventArgs e)
        {
            //menyra e dyte nepermjet komandes
            switch (e.CommandName)
            {
                case "ModifikoStudent":
                    Response.Redirect("ModifikoStudent.aspx?idStudent=" + e.CommandArgument.ToString());
                    break;

                case "DetailStudent":
                    Response.Redirect("AfishoStudent.aspx?idStudent=" + e.CommandArgument.ToString());
                    break;
                default:
                    break;


            }

        }

        public bool Visibility_Edit_Button()
        {
            if (Tokens.IsAdmin)
            {
                return true;

            }

            else return false;

        }


        public bool CanViewStudentDetail()
        {
            if (Tokens.UserAuthorization.Any(i => i.Equals("DetailStudent")))
            {
                return true;
            }
            else return false;
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            //nxjerr perdoruesin nga sistemi

            Session["User"] = null;
            Session["IsAdmin"] = null;
            HttpContext.Current.Session["UserAuthorization"] = null;
            Response.Redirect("~/Laborator5/LoginUser.aspx");



        }
    }
}