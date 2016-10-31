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
        public bool DeleteGender(Models.Gender gender)
        {
            var query = "delete Monster.Gender where GenderId = @id";
            var id = new SqlParameter("id", gender.GenderId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.Add(id);
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool DeleteMonsterType(Models.MonsterType monsterType)
        {
            var query = "delete Monster.MonsterType where MonsterTypeId = @id";
            var id = new SqlParameter("id", monsterType.MonsterTypeId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.Add(id);
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool DeleteTitle(Models.Title title)
        {
            var query = "delete Monster.Title where TitleId = @id";
            var id = new SqlParameter("id", title.TitleId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.Add(id);
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }

        public bool DeleteMonster(Models.Monster monster)
        {
            var query = "delete Monster.Monster where MonsterId = @id";
            var id = new SqlParameter("id", monster.MonsterId);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.Add(id);
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }
    }
}
