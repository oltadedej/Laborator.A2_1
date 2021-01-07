using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator3
{
    public partial class TxtChanged : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
                if (TextBox1.Text.Contains(" "))
                {
                    string [] array = TextBox1.Text.Split(' ');
                Label1.Text = $"Gjatesia e elementeve qe permban array eshte: {array.Length}" ;
                }
                else
                {
                    Label1.Text = string.Empty;
                }
            }

        }
    }
}