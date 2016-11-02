using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
    public partial class entryform : System.Web.UI.Page
    {
        private DataService data = new DataService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool InsertValidated()
        {
            if(string.IsNullOrWhiteSpace(MonsterName_Text.Text) && string.IsNullOrWhiteSpace(MonsterGender_List.SelectedValue))
            {
                return false;
            }

            return data.InsertMonster(MonsterName_Text.Text, MonsterGender_List.SelectedValue);
        }

        protected void MonsterSubmit_Click(object sender, EventArgs e)
        {
            //if (InsertValidated())
            //{
            //    MonsterName_Text.Text = string.Empty;
            //    MonsterGender_List.SelectedIndex = 0;
            //}
            MonsterName_Text.Text = "Server Found";

        }
    }
}