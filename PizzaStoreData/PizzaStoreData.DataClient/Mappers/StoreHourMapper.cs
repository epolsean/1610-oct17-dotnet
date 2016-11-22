using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class StoreHourMapper
    {
        public static StoreHourDAO MapToStoreHourDAO(StoreHour storeHour)
        {
            var sh = new StoreHourDAO();
            sh.Id = storeHour.HoursID;
            sh.OpeningTime = storeHour.StartTime;
            sh.ClosingTime = storeHour.EndTime;
            sh.Active = storeHour.Active;

            return sh;
        }

        public static StoreHour MapToStoreHour(StoreHourDAO storeHour)
        {
            var sh = new StoreHour();
            sh.HoursID = storeHour.Id;
            sh.StartTime = storeHour.OpeningTime;
            sh.EndTime = storeHour.ClosingTime;
            sh.Active = storeHour.Active;

            return sh;
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