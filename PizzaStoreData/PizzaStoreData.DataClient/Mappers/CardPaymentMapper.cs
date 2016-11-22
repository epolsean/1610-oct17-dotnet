using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class CardPaymentMapper
    {
        public static CardPaymentDAO MapToCardPaymentDAO(CardPayment cardPayment)
        {
            var cp = new CardPaymentDAO();
            cp.Id = cardPayment.CardPaymentID;
            cp.Customer = CustomerMapper.MapToCustomerDAO(cardPayment.Customer);
            cp.CardNumber = cardPayment.CardNumber;
            cp.CardHolderName = cardPayment.CardHolderName;
            cp.ExpirationDate = cardPayment.ExpirationDate;
            cp.CVC = cardPayment.CVC;
            cp.Active = cardPayment.Active;

            return cp;
        }

        public static CardPayment MapToCardPayment(CardPaymentDAO cardPayment)
        {
            var cp = new CardPayment();
            cp.CardPaymentID = cardPayment.Id;
            cp.CustomerID = CustomerMapper.MapToCustomer(cardPayment.Customer).CustomerID;
            cp.CardNumber = cardPayment.CardNumber;
            cp.CardHolderName = cardPayment.CardHolderName;
            cp.ExpirationDate = cardPayment.ExpirationDate;
            cp.CVC = cardPayment.CVC;
            cp.Active = cardPayment.Active;

            return cp;
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