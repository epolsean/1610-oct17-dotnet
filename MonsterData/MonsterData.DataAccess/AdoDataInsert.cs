using MonsterData.DataAccess.Models;
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
        public bool InsertGender(Gender gender)
        {
            var n = new SqlParameter("name", gender.Name);
            var query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";

            return InsertData(query, n) == 1;
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
        /*
        public bool InsertData(string query, params SqlParameter[] parameters)
        {
            int result;
            SqlCommand cmd;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                cmd = new SqlCommand(query, connection);
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                result = cmd.ExecuteNonQuery();
            }

            return result == 1;
        }*/
    }
}
