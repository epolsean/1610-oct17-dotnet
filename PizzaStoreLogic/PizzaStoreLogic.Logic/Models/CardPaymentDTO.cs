using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class CardPaymentDTO
    {
        public int Id { get; set; }
        
        public CustomerDTO Customer { get; set; }
        
        public string CardNumber { get; set; }
        
        public string CardHolderName { get; set; }
        
        public int ExpirationDate { get; set; }
        
        public int CVC { get; set; }
        
        public bool Active { get; set; }
    }
}
