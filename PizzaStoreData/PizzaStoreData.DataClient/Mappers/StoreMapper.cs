using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class StoreMapper
    {
        public static StoreDAO MapToStoreDAO(Store store)
        {
            var s = new StoreDAO();
            s.Id = store.StoreID;
            s.Address = AddressDetailMapper.MapToAddressDetailDAO(store.AddressDetail);
            s.PhoneNumber = PhoneMapper.MapToPhoneDAO(store.Phone);
            s.Hours = StoreHourMapper.MapToStoreHourDAO(store.StoreHour);
            s.Active = store.Active;

            return s;
        }

        public static Store MapToStore(StoreDAO store)
        {
            var s = new Store();
            s.StoreID = store.Id;
            s.AddressID = AddressDetailMapper.MapToAddressDetail(store.Address).AddressID;
            s.PhoneID = PhoneMapper.MapToPhone(store.PhoneNumber).PhoneID;
            s.HoursID = StoreHourMapper.MapToStoreHour(store.Hours).HoursID;
            s.Active = store.Active;

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