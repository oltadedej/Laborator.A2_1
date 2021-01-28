using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator5
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User user = null;
                using (University1Entities dbcontext = new University1Entities())
                {
                    if (!String.IsNullOrEmpty(txtEmail.Text))
                    {
                        if (!dbcontext.Users.ToList().Any(i => i.Email.Equals(txtEmail.Text)))
                        {
                            lblMessazhe.Text = "Emaili nuk ekziston ne db";
                            return;
                        }

                        user = dbcontext.Users.ToList().Find(i => i.Email.Equals(txtEmail.Text));
                        if (user != null)
                        {
                            string hashPassword = Extensions.Encryptdata(txtPassword.Text);
                            if (!hashPassword.Equals(user.Password))
                            {
                                lblMessazhe.Text = "Password i gabuar";
                                return;
                            }
                        }

                    }
                    //save in session all the needed information about user
                    Session["User"] = user;
                    Response.Redirect("~/Laborator4/Students.aspx");
                }
            }
        }
    }
}