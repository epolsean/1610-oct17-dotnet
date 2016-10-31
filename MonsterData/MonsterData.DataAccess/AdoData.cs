using Models = MonsterData.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterData.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AdoData
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Models.Gender> GetGenders()
        {

            try
            {
                var ds = GetDataDisconnected("SELECT * FROM Monster.Gender;");
                var genders = new List<Models.Gender>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    genders.Add(new Models.Gender()
                    {
                        GenderId = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }

                return genders;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public Models.Gender GetLatestGender()
        {

            try
            {
                var ds = GetDataDisconnected("SELECT TOP 1 * FROM Monster.Gender AS mg ORDER BY mg.GenderId DESC;");
                DataRow row = ds.Tables[0].Rows[0];
                Models.Gender latestGender = new Models.Gender()
                {
                    GenderId = int.Parse(row[0].ToString()),
                    Name = row[1].ToString(),
                    Active = bool.Parse(row[2].ToString())
                };

                return latestGender;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Models.MonsterType> GetMonsterTypes()
        {
            try
            {
                var ds = GetDataDisconnected("SELECT * FROM Monster.MonsterType;");
                var monsterTypes = new List<Models.MonsterType>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    monsterTypes.Add(new Models.MonsterType()
                    {
                        MonsterTypeId = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }

                return monsterTypes;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Models.Title> GetTitles()
        {
            try
            {
                var ds = GetDataDisconnected("SELECT * FROM Monster.Title;");
                var titles = new List<Models.Title>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    titles.Add(new Models.Title()
                    {
                        TitleId = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }

                return titles;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private DataSet GetDataDisconnected(string query)
        {
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd;

            using (var connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds);
            }

            return ds;
        }
    }
}
