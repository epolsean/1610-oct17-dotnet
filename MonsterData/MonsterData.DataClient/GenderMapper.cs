using M = MonsterData.DataAccess.Models;
using MonsterData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterData.DataClient
{
    public class GenderMapper
    {
        public static GenderDAO MapToGenderDAO(M.Gender gender)
        {
            var g = new GenderDAO();
            g.Id = gender.GenderId;
            g.Name = gender.Name;

            return g;
        }

        public static M.Gender MapToGender(GenderDAO gender)
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