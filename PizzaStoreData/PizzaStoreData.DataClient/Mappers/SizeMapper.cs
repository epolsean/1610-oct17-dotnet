using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class SizeMapper
    {
        public static SizeDAO MapToSizeDAO(Size size)
        {
            var s = new SizeDAO();
            s.Id = size.SizeID;
            s.Name = size.SizeType;
            s.Active = size.Active;

            return s;
        }

        public static Size MapToSize(SizeDAO size)
        {
            var s = new Size();
            s.SizeID = size.Id;
            s.SizeType = size.Name;
            s.Active = size.Active;

            return s;
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