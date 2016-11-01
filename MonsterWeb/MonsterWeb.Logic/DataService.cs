using MonsterData.DataClient.Models;
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
        /*
        public List<MonsterTypeDAO> GetMonsterTypes()
        {
            return msc.GetMonsterTypes().ToList();
        }

        public List<TitleDAO> GetTitles()
        {
            return msc.GetTitles().ToList();
        }*/
    }
}
