using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        
        public NameDTO Name { get; set; }
        
        public AddressDTO Address { get; set; }
        
        public EmailDTO Email { get; set; }
        
        public PhoneDTO Phone { get; set; }
        
        public bool Active { get; set; }
    }
}
