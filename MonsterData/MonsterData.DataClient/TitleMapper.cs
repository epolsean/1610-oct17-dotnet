using MonsterData.DataAccess.Models;
using MonsterData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterData.DataClient
{
    public class TitleMapper
    {
        public static TitleDAO MapToTitleDAO(Title title)
        {
            var t = new TitleDAO();
            t.Id = title.TitleId;
            t.Name = title.Name;

            return t;
        }

        public static Title MapToTitle(TitleDAO title)
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