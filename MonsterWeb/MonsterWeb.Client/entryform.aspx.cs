using MonsterWeb.Logic;
using MonsterWeb.Logic.Models;
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
        private FactoryThing<GenderDTO> genderFactory = new FactoryThing<GenderDTO>();
        private FactoryThing<TypeDTO> typeFactory = new FactoryThing<TypeDTO>();
        private FactoryThing<TitleDTO> titleFactory = new FactoryThing<TitleDTO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (this.Request.UrlReferrer == null || this.Request.UrlReferrer.AbsolutePath.ToString() != "/Welcome.aspx")
            {
                Response.Redirect("~/Welcome.aspx");
            }*/
            if (!IsPostBack)
            {
                LoadGenders();
                LoadMonsterTypes();
                LoadTitles();
            }
        }

        private void LoadGenders()
        {
            MonsterGender_List.Items.Clear();

            foreach (var item in data.GetGenders())
            {
                MonsterGender_List.Items.Add(new ListItem() { Text = item.Name, Value = item.AppId.ToString() });
            }
        }

        private void LoadMonsterTypes()
        {
            MonsterType_List.Items.Clear();

            foreach (var item in data.GetMonsterTypes())
            {
                MonsterType_List.Items.Add(new ListItem() { Text = item.Name, Value = item.AppId.ToString() });
            }
        }

        private void LoadTitles()
        {
            MonsterTitle_List.Items.Clear();

            foreach (var item in data.GetTitles())
            {
                MonsterTitle_List.Items.Add(new ListItem() { Text = item.Name, Value = item.AppId.ToString() });
            }
        }

        private bool InsertValidated()
        {
            if (string.IsNullOrWhiteSpace(MonsterName_Text.Text) && string.IsNullOrWhiteSpace(MonsterGender_List.SelectedItem.Value))
            {
                return false;
            }

            var gender = genderFactory.Create();
            var monsterType = typeFactory.Create();
            var title = titleFactory.Create();

            gender.AppId = int.Parse(MonsterGender_List.SelectedItem.Value);
            gender.Name = MonsterGender_List.SelectedItem.Text;

            monsterType.AppId = int.Parse(MonsterType_List.SelectedItem.Value);
            monsterType.Name = MonsterType_List.SelectedItem.Text;

            title.AppId = int.Parse(MonsterTitle_List.SelectedItem.Value);
            title.Name = MonsterTitle_List.SelectedItem.Text;

            return data.InsertMonster(MonsterName_Text.Text, gender, monsterType, title);
        }

        protected void MonsterSubmit_Click(object sender, EventArgs e)
        {
            if (InsertValidated())
            {
                MonsterName_Text.Text = string.Empty;
                MonsterGender_List.SelectedIndex = 0;
                MonsterType_List.SelectedIndex = 0;
                MonsterTitle_List.SelectedIndex = 0;
            }
        }
    }
}