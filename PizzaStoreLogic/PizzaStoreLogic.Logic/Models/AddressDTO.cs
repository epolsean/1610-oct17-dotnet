using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class AddressDTO
    {
        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }
        
        public int Zipcode { get; set; }
        
        public bool Active { get; set; }
    }
}
