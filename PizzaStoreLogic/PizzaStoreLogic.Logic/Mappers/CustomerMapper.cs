using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class CustomerMapper
    {
        public static CustomerDAO MapToDAO(CustomerDTO customer)
        {
            var c = new CustomerDAO();
            c.Id = customer.Id;
            c.Name = NameMapper.MapToDAO(customer.Name);
            c.Address = AddressMapper.MapToDAO(customer.Address);
            c.Email = EmailMapper.MapToDAO(customer.Email);
            c.Phone = PhoneMapper.MapToDAO(customer.Phone);
            c.Active = customer.Active;

            return c;
        }

        public static CustomerDTO MapToDTO(CustomerDAO customer)
        {
            var c = new CustomerDTO();
            c.Id = customer.Id;
            c.Name = NameMapper.MapToDTO(customer.Name);
            c.Address = AddressMapper.MapToDTO(customer.Address);
            c.Email = EmailMapper.MapToDTO(customer.Email);
            c.Phone = PhoneMapper.MapToDTO(customer.Phone);
            c.Active = customer.Active;

            return c;
        }
    }
}
