using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class CardPaymentMapper
    {
        public static CardPaymentDAO MapToDAO(CardPaymentDTO cardPayment)
        {
            var cp = new CardPaymentDAO();
            cp.Id = cardPayment.Id;
            cp.Customer = CustomerMapper.MapToDAO(cardPayment.Customer);
            cp.CardNumber = cardPayment.CardNumber;
            cp.CardHolderName = cardPayment.CardHolderName;
            cp.ExpirationDate = cardPayment.ExpirationDate;
            cp.CVC = cardPayment.CVC;
            cp.Active = cardPayment.Active;

            return cp;
        }

        public static CardPaymentDTO MapToDTO(CardPaymentDAO cardPayment)
        {
            var cp = new CardPaymentDTO();
            cp.Id = cardPayment.Id;
            cp.Customer = CustomerMapper.MapToDTO(cardPayment.Customer);
            cp.CardNumber = cardPayment.CardNumber;
            cp.CardHolderName = cardPayment.CardHolderName;
            cp.ExpirationDate = cardPayment.ExpirationDate;
            cp.CVC = cardPayment.CVC;
            cp.Active = cardPayment.Active;

            return cp;
        }
    }
}
