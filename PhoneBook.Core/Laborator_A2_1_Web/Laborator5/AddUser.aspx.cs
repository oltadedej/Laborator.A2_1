using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator5
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (University1Entities dbcontext = new University1Entities())
                {
                    User userToAdd = new User();
                    if (!String.IsNullOrEmpty(txtName.Text)) userToAdd.Name = txtName.Text;
                    if (!String.IsNullOrEmpty(txtSurname.Text)) userToAdd.Surname = txtSurname.Text;
                    if (!String.IsNullOrEmpty(txtEmail.Text)) userToAdd.Email = txtEmail.Text;
                    if (!String.IsNullOrEmpty(txtBirthday.Text)) userToAdd.Birthday = DateTime.ParseExact(txtBirthday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (!String.IsNullOrEmpty(txtPassword.Text))
                    {
                        userToAdd.Password = Extensions.Encryptdata(txtPassword.Text);
                    }
                    dbcontext.Users.Add(userToAdd);
                    dbcontext.SaveChanges();
                    txtCOnfirm.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtSurname.Text = string.Empty;
                    txtBirthday.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
        }




    }
}