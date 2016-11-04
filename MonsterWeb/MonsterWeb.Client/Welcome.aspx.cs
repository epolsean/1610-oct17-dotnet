using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {
                if (Request.Cookies["monstercookie"] != null)
                {
                    Response.Redirect("~/entryform.aspx");
                }

                var cookie = new HttpCookie("monstercookie", DateTime.Now.Ticks.ToString());

                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);

                Response.Redirect("~/entryform.aspx");
            }
        }
    }
}