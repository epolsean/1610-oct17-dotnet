using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class StoreMapper
    {
        public static StoreDAO MapToDAO(StoreDTO store)
        {
            var s = new StoreDAO();
            s.Id = store.Id;
            s.Address = AddressMapper.MapToDAO(store.Address);
            s.PhoneNumber = PhoneMapper.MapToDAO(store.PhoneNumber);
            s.Hours = HoursMapper.MapToDAO(store.Hours);
            s.Active = store.Active;

            return s;
        }

        public static StoreDTO MapToDTO(StoreDAO store)
        {
            var s = new StoreDTO();
            s.Id = store.Id;
            s.Address = AddressMapper.MapToDTO(store.Address);
            s.PhoneNumber = PhoneMapper.MapToDTO(store.PhoneNumber);
            s.Hours = HoursMapper.MapToDTO(store.Hours);
            s.Active = store.Active;

            return s;
        }
    }
}
