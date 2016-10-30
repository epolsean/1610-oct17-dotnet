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
        public bool UpdateGender(Models.Gender gender)
        {
            var query = "update Monster.Gender set GenderName = @name, Active = @active where GenderId = @id";
            var name = new SqlParameter("name", gender.Name);
            var active = new SqlParameter("active", gender.Active ? 1 : 0);
            var id = new SqlParameter("id", gender.GenderId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { id, name, active});
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool UpdateMonsterType(Models.MonsterType monsterType)
        {
            var query = "update Monster.MonsterType set TypeName = @name, Active = @active where MonsterTypeId = @id";
            var name = new SqlParameter("name", monsterType.Name);
            var active = new SqlParameter("active", monsterType.Active ? 1 : 0);
            var id = new SqlParameter("id", monsterType.MonsterTypeId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { id, name, active });
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool UpdateTitle(Models.Title title)
        {
            var query = "update Monster.Title set TitleName = @name, Active = @active where TitleId = @id";
            var name = new SqlParameter("name", title.Name);
            var active = new SqlParameter("active", title.Active ? 1 : 0);
            var id = new SqlParameter("id", title.TitleId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { id, name, active });
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool UpdateMonster(Models.Monster monster)
        {
            var query = "update Monster.Monster set GenderId = @genderid, TitleId = @titleid, TypeId = @typeid, Name = @name, PicturePath = @picturepath, Active = @active where MonsterId = @id";
            var genderid = new SqlParameter("genderid", monster.GenderId);
            var titleid = new SqlParameter("titleid", monster.TitleId);
            var typeid = new SqlParameter("typeid", monster.TypeId);
            var name = new SqlParameter("name", monster.Name);
            var picturepath = new SqlParameter("picturepath", monster.PicturePath);
            var active = new SqlParameter("active", monster.Active ? 1 : 0);
            var id = new SqlParameter("id", monster.MonsterId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { id, genderid, titleid, typeid, name, picturepath, active });
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }
    }
}
