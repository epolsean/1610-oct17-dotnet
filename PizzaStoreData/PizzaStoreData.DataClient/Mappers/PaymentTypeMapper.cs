using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class PaymentTypeMapper
    {
        public static PaymentTypeDAO MapToPaymentTypeDAO(PaymentType paymentType)
        {
            var pt = new PaymentTypeDAO();
            pt.Id = paymentType.PaymentTypeID;
            pt.Type = paymentType.PaymentTypeName;
            pt.Active = paymentType.Active;

            return pt;
        }

        public static PaymentType MapToPaymentType(PaymentTypeDAO paymentType)
        {
            var pt = new PaymentType();
            pt.PaymentTypeID = paymentType.Id;
            pt.PaymentTypeName = paymentType.Type;
            pt.Active = paymentType.Active;

            return pt;
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