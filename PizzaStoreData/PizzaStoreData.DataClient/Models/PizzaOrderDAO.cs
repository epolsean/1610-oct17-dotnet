using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class PizzaOrderDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public CustomerDAO Customer { get; set; }
        [DataMember]
        public StoreDAO Store { get; set; }
        [DataMember]
        public PaymentTypeDAO Payment { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}