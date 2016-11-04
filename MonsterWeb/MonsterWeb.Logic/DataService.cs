using MonsterWeb.Logic.Models;
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
        private FactoryThing<GenderDTO> genderFactory = new FactoryThing<GenderDTO>();
        private FactoryThing<TypeDTO> monsterTypeFactory = new FactoryThing<TypeDTO>();
        private FactoryThing<TitleDTO> titleFactory = new FactoryThing<TitleDTO>();

        public List<GenderDTO> GetGenders()
        {
            var genders = new List<GenderDTO>();

            foreach (var item in msc.GetGenders())
            {
                var g = genderFactory.Create();

                g.AppId = item.Id;
                g.Name = item.Name;

                genders.Add(g);
            }

            return genders;
        }

        public List<TypeDTO> GetMonsterTypes()
        {
            var monsterTypes = new List<TypeDTO>();

            foreach (var item in msc.GetMonsterTypes())
            {
                var mt = monsterTypeFactory.Create();

                mt.AppId = item.Id;
                mt.Name = item.Name;

                monsterTypes.Add(mt);
            }

            return monsterTypes;
        }

        public List<TitleDTO> GetTitles()
        {
            var titles = new List<TitleDTO>();

            foreach (var item in msc.GetTitles())
            {
                var t = titleFactory.Create();

                t.AppId = item.Id;
                t.Name = item.Name;

                titles.Add(t);
            }

            return titles;
        }

        public bool InsertMonster(string name, GenderDTO gender, TypeDTO monsterType, TitleDTO title)
        {
            var gen = msc.GetGenders().FirstOrDefault(g => g.Id == gender.AppId);
            var typ = msc.GetMonsterTypes().FirstOrDefault(t => t.Id == monsterType.AppId);
            var tit = msc.GetTitles().FirstOrDefault(t => t.Id == title.AppId);
            var mon = new MonsterDAO() { Name = name, Gender = gen, MonsterType = typ, Title = tit };

            return msc.InsertMonster(mon);
        }
    }
}
