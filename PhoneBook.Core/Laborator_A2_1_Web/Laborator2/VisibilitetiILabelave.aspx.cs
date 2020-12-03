using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator2
{
    public partial class VisibilitetiILabelave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FshehOseAfisho_Click(object sender, EventArgs e)
        {
            if (Label1.Visible == true) // if(Label1.Visible)
            {
                Label1.Visible = false;
            }

            else if (Label1.Visible == false) // if(!Label1.Visible)
            {
                Label1.Visible = true;
                Label1.ForeColor = Color.Green;

            }

            if (Label2.Visible) //  if(Label2.Visible == true)
            {
                Label2.Visible = false;
            }

            else if (!Label2.Visible) //if(Label2.Visible == false)
            {
                Label2.Visible = true;
                Label2.ForeColor = System.Drawing.Color.Green;
            }

        }
    }
}