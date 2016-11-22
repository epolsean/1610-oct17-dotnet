using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class StoreDTO
    {
        public int Id { get; set; }
        
        public AddressDTO Address { get; set; }
        
        public PhoneDTO PhoneNumber { get; set; }
        
        public HoursDTO Hours { get; set; }
        
        public bool Active { get; set; }
    }
}
