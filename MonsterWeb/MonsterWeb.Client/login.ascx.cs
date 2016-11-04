using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Message.Text = string.Empty;
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                Message.Text = "Denied";
                return;
            }

            Response.Redirect("~/entryform.aspx");
        }
    }
}