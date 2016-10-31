using MonsterData.DataAccess.Models;
using MonsterData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterData.DataClient
{
    public class MonsterTypeMapper
    {
        public static MonsterTypeDAO MapToMonsterTypeDAO(MonsterType monsterType)
        {
            var mt = new MonsterTypeDAO();
            mt.Id = monsterType.MonsterTypeId;
            mt.Name = monsterType.Name;

            return mt;
        }

        public static MonsterType MapToMonsterType(MonsterTypeDAO monsterType)
        {

            throw new NotImplementedException();
        }

        public static object MapTo(object o)
        {
            var properties = 0.GetType().GetProperties();
            var ob = new object();

            foreach (var item in properties.ToList())
            {
                ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
            }

            return ob;
        }
    }
}