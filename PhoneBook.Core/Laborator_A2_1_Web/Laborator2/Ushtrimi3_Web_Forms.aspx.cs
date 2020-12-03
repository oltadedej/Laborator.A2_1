using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator2
{
    public partial class Ushtrimi3_Web_Forms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem newItem = new ListItem();
            newItem.Text = "E verdhe";
            ddlNgjyrat.Items.Add(newItem);
            newItem = new ListItem();
            newItem.Text = "Gri";
            ddlNgjyrat.Items.Add(newItem);

            //
            List<ListItem> lst = new List<ListItem>();
            lst.Add(newItem);
            ListItem item2 = new ListItem();
            item2.Text = "E zeze";
            lst.Add(item2);

            ddlNgjyrat.Items.AddRange(lst.ToArray());

        }
    }
}