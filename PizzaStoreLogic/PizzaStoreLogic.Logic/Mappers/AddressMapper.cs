using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class AddressMapper
    {
        public static AddressDetailDAO MapToDAO(AddressDTO address)
        {
            var ad = new AddressDetailDAO();
            ad.Id = address.Id;
            ad.Address1 = address.Address1;
            ad.Address2 = address.Address2;
            ad.City = address.City;
            ad.State = address.State;
            ad.Zipcode = address.Zipcode;
            ad.Active = address.Active;

            return ad;
        }

        public static AddressDTO MapToDTO(AddressDetailDAO address)
        {
            var a = new AddressDTO();
            a.Id = address.Id;
            a.Address1 = address.Address1;
            a.Address2 = address.Address2;
            a.City = address.City;
            a.State = address.State;
            a.Zipcode = address.Zipcode;
            a.Active = address.Active;

            return a;
        }
    }
}
