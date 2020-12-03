using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator2
{
    public partial class Ushtrimi2_Web_Forms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmerMbiemr.Text = "Emri i ri";
            Femer.Checked = true;
            AfishimMesazhi.Text = "Pershendetje " + EmerMbiemr.Text + " Gjinia juaj eshte: " + Femer.Text + " Data sot eshte:" + DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}