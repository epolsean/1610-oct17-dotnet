using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterData.DataAccess;
using Models = MonsterData.DataAccess.Models;
using MonsterData.DataClient.Models;

namespace MonsterData.DataClient
{
    public class MonsterService : IMonsterService
    {
        private AdoData data = new AdoData();
        private EFData ef = new EFData();

        public List<GenderDAO> GetGenders()
        {
            var g = new List<GenderDAO>();

            foreach (var gender in data.GetGenders())
            {
                g.Add(GenderMapper.MapToGenderDAO(gender));
            }

            return g;
        }

        public List<MonsterTypeDAO> GetMonsterTypes()
        {
            var mt = new List<MonsterTypeDAO>();

            foreach (var monsterType in data.GetMonsterTypes())
            {
                mt.Add(MonsterTypeMapper.MapToMonsterTypeDAO(monsterType));
            }

            return mt;
        }

        public List<TitleDAO> GetTitles()
        {
            var t = new List<TitleDAO>();

            foreach (var title in data.GetTitles())
            {
                t.Add(TitleMapper.MapToTitleDAO(title));
            }

            return t;
        }

        public bool InsertMonster(MonsterDAO monster)
        {
            var m = new Monster();

            m.Name = monster.Name;
            m.GenderId = monster.Gender.Id;

            return ef.InsertMonster(m);
        }
    }
}
