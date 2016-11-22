using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class PhoneMapper
    {
        public static PhoneDAO MapToPhoneDAO(Phone phone)
        {
            var p = new PhoneDAO();
            p.Id = phone.PhoneID;
            p.Number = phone.PhoneNumber;
            p.Active = phone.Active;

            return p;
        }

        public static Phone MapToPhone(PhoneDAO phone)
        {
            var p = new Phone();
            p.PhoneID = phone.Id;
            p.PhoneNumber = phone.Number;
            p.Active = phone.Active;

            return p;
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