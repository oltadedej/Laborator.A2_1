using Laborator_A2_1_Web;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator4
{
    public partial class ModifikoStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int std = Convert.ToInt32(Request.QueryString["idStudent"]);

                using (University1Entities dbcontext = new University1Entities())
                {
                    Student stdudent_ = dbcontext.Students.ToList().Where(i => i.StudentId == std).FirstOrDefault();
                    txtName.Text = stdudent_.Emer;
                    txtSurname.Text = stdudent_.Mbiemer;
                    txtEnrollmentDate.Text = stdudent_.EnrollmentDate.ToString("dd/MM/yyyy");



                }


            }

        }

        protected void btnModifikoStudent_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            try
            {
                using (University1Entities dbcontext = new University1Entities())
                {
                    //gjejme indexin e elementit per modifikim
                    int itemIndexToModify = dbcontext.Students.ToList().FindIndex(i => i.StudentId == Convert.ToInt32(Request.QueryString["idStudent"].ToString()));

                    if (!String.IsNullOrEmpty(txtName.Text))
                    {
                        dbcontext.Students.ToList()[itemIndexToModify].Emer = txtName.Text;
                    }
                    if (!String.IsNullOrEmpty(txtSurname.Text))
                    {
                        dbcontext.Students.ToList()[itemIndexToModify].Mbiemer = txtSurname.Text;
                    }


                    if (!String.IsNullOrEmpty(txtEnrollmentDate.Text))
                    {
                        // dbcontext.Students.ToList()[itemIndexToModify].EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);

                        //zgjidhja e problematikes me daten ne formatin dd/MM/yyyy qe marrim nga webi, dmth konvertimi i tekstit ne date

                        dbcontext.Students.ToList()[itemIndexToModify].EnrollmentDate = DateTime.ParseExact(txtEnrollmentDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    }

                    //ruan ndryshimnet ne baze te dhenash
                    dbcontext.SaveChanges();


                }

            }

            catch (Exception ex)
            {
                //  throw ex;
                isOk = false;

            }
            if (isOk) Response.Redirect("Students.aspx");
            else lblError.Text = "Gabime gjate perditesimit te studentit";
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["Password"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}