using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator3
{
    public partial class Ddl_Selected_Red_Color : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlNgjyrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            NrElementsh.Text = "";
            
            if (ddlNgjyrat.SelectedItem != null)
            {
                if (!String.IsNullOrEmpty(ddlNgjyrat.SelectedItem.Text))
                {
                    if (ddlNgjyrat.SelectedItem.Text.Contains("kuqe"))
                    {
                        NrElementsh.Text = "Numri i elementeve te dropdownlistes eshte:" + ddlNgjyrat.Items.Count;
                    }
                    else
                    {
                        TextBox txt = new TextBox();
                        txt.Text = "Ngjyra e zgjedhur eshte: " + ddlNgjyrat.SelectedItem.Text;
                        form1.Controls.Add(txt);
                    }
                }
            }
        }
    }
}