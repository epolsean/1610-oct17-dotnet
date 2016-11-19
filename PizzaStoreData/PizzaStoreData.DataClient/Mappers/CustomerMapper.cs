using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class CustomerMapper
    {
        public static CustomerDAO MapToCustomerDAO(Customer customer)
        {
            var c = new CustomerDAO();
            c.Id = customer.CustomerID;
            c.Name = NameMapper.MapToNameDAO(customer.Name);
            c.Address = AddressDetailMapper.MapToAddressDetailDAO(customer.AddressDetail);
            c.Email = EmailMapper.MapToEmailDAO(customer.Email);
            c.Phone = PhoneMapper.MapToPhoneDAO(customer.Phone);
            c.Active = customer.Active;

            return c;
        }

        public static Customer MapToCustomer(CustomerDAO customer)
        {
            var c = new Customer();
            c.CustomerID = customer.Id;
            c.NameID = NameMapper.MapToName(customer.Name).NameID;
            c.AddressID = AddressDetailMapper.MapToAddressDetail(customer.Address).AddressID;
            c.EmailID = EmailMapper.MapToEmail(customer.Email).EmailID;
            c.PhoneID = PhoneMapper.MapToPhone(customer.Phone).PhoneID;
            c.Active = customer.Active;

            return c;
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