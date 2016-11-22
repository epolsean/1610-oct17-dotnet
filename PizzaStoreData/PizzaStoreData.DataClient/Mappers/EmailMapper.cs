using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class EmailMapper
    {
        public static EmailDAO MapToEmailDAO(Email email)
        {
            var e = new EmailDAO();
            e.Id = email.EmailID;
            e.Address = email.EmailAddress;
            e.Active = email.Active;

            return e;
        }

        public static Email MapToEmail(EmailDAO email)
        {
            var e = new Email();
            e.EmailID = email.Id;
            e.EmailAddress = email.Address;
            e.Active = email.Active;

            return e;
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