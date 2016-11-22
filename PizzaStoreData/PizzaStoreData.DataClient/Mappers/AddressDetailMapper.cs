using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class AddressDetailMapper
    {
        public static AddressDetailDAO MapToAddressDetailDAO(AddressDetail addressDetail)
        {
            var ad = new AddressDetailDAO();
            ad.Id = addressDetail.AddressID;
            ad.Address1 = addressDetail.Address1;
            ad.Address2 = addressDetail.Address2;
            ad.City = addressDetail.CityName;
            ad.State = addressDetail.StateName;
            ad.Zipcode = addressDetail.Zipcode;
            ad.Active = addressDetail.Active;

            return ad;
        }

        public static AddressDetail MapToAddressDetail(AddressDetailDAO addressDetail)
        {
            var ad = new AddressDetail();
            ad.AddressID = addressDetail.Id;
            ad.Address1 = addressDetail.Address1;
            ad.Address2 = addressDetail.Address2;
            ad.CityName = addressDetail.City;
            ad.StateName = addressDetail.State;
            ad.Zipcode = addressDetail.Zipcode;
            ad.Active = addressDetail.Active;

            return ad;
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