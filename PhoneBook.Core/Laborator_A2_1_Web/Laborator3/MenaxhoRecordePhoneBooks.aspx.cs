using Laborator_A2_1_Web.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator3
{
    public partial class MenaxhoRecordePhoneBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Configurations configuration = new Configurations();

                ddl1.DataSource = configuration.phoneBooks; // si burimi i te dhenave
                ddl1.DataTextField = "PhoneBookPersonName";  // eshte specifikimi i tekstit qe ka itemi i dropdown listes
                ddl1.DataValueField = "IdPhoneBook"; // eshte specifikimi i vleres per ddl
                ddl1.DataBind(); // mundeson qe burimi i te dhenave te shfaqet ne web
            }

        }

        protected void btnShto_Click(object sender, EventArgs e)
        {
                PhoneBook phoneBook = new PhoneBook();
                phoneBook.PhoneBookPersonName = txtPhoneBookPersonName.Text.Trim();
                phoneBook.PhoneNumber = txtPhoneNumber.Text.Trim();
                phoneBook.PhoneType = Convert.ToInt32(rdlPhoneBookType.SelectedValue); // converton string ne int
                Configurations configurations = new Configurations();
                configurations.phoneBooks.Add(phoneBook);
                ddl1.DataSource = configurations.phoneBooks;
                ddl1.DataTextField = "PhoneBookPersonName";  // eshte specifikimi i tekstit qe ka itemi i dropdown listes
                ddl1.DataValueField = "IdPhoneBook"; // eshte specifikimi i vleres per ddl
                ddl1.DataBind(); // mundeson qe burimi i te dhenave te shfaqet ne web
           
        }

        protected void fshirecord_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddl1.SelectedValue))
            {

                int idToDelete = Convert.ToInt32(ddl1.SelectedValue.Trim());
                Configurations configurations = new Configurations();

                // kontrollojme nese ekziston elementi ne liste.
                //1. foreach
                //foreach(var item in configurations.phoneBooks)
                //{
                //    if (item.IdPhoneBook == idToDelete)
                //    {
                //        configurations.phoneBooks.Remove(item);
                //    }
                //}

                //2 -->Linq
               // bool exist = configurations.phoneBooks.Select(i => i.IdPhoneBook == idToDelete).FirstOrDefault();
                bool exist = configurations.phoneBooks.Any(i => i.IdPhoneBook == idToDelete);

                if (exist)
                {
                    PhoneBook itemToDelete = configurations.phoneBooks.Where(i => i.IdPhoneBook == idToDelete).Select(i => i).FirstOrDefault();
                    configurations.phoneBooks.Remove(itemToDelete);
                    ddl1.DataSource = configurations.phoneBooks;
                    ddl1.DataTextField = "PhoneBookPersonName";  // eshte specifikimi i tekstit qe ka itemi i dropdown listes
                    ddl1.DataValueField = "IdPhoneBook"; // eshte specifikimi i vleres per ddl
                    ddl1.DataBind();
                }
            
            
            }



        }
    }
}