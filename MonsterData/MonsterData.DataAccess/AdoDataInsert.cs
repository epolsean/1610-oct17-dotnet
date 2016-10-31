using Models = MonsterData.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterData.DataAccess
{
    public partial class AdoData
    {
        public bool InsertGender(Models.Gender gender)
        {
            var n = new SqlParameter("name", gender.Name);
            var query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";

            return InsertData(query, n) == 1;
        }

        public bool InsertMonsterType(Models.MonsterType monsterType)
        {
            var n = new SqlParameter("name", monsterType.Name);
            var query = "insert into Monster.MonsterType(TypeName, Active) values (@name, 1)";

            return InsertData(query, n) == 1;
        }

        public bool InsertTitle(Models.Title title)
        {
            var n = new SqlParameter("name", title.Name);
            var query = "insert into Monster.Title(TitleName, Active) values (@name, 1)";

            return InsertData(query, n) == 1;
        }

        public bool InsertMonster(Models.Monster monster)
        {
            var genderid = new SqlParameter("genderid", monster.GenderId);
            var titleid = new SqlParameter("titleid", monster.TitleId);
            var typeid = new SqlParameter("typeid", monster.TypeId);
            var name = new SqlParameter("name", monster.Name);
            var picturepath = new SqlParameter("picturepath", monster.PicturePath);
            var query = "insert into Monster.Monster(GenderId, TitleId, TypeId, Name, PicturePath, Active) values (@genderid, @titleid, @typeid, @name, @picturepath, 1)";

            return InsertData(query, genderid, titleid, typeid, name, picturepath) == 1;
        }

        public int InsertData(string query, params SqlParameter[] parameters)
        {
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
