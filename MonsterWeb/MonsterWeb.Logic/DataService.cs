using MonsterWeb.Logic.MonsterServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
    public class DataService
    {
        private MonsterServiceClient msc = new MonsterServiceClient();

        public List<GenderDAO> GetGenders()
        {
            return msc.GetGenders().ToList();
        }

        public List<MonsterTypeDAO> GetMonsterTypes()
        {
            return msc.GetMonsterTypes().ToList();
        }

        public List<TitleDAO> GetTitles()
        {
            return msc.GetTitles().ToList();
        }

        public bool InsertMonster(string name, string gender)
        {
            var gen = msc.GetGenders().FirstOrDefault(g => g.Name == gender);
            var mon = new MonsterDAO() { Name = name, Gender = gen };

            return msc.InsertMonster(mon);
        }
    }
}
