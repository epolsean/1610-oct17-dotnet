using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class CardPaymentDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public CustomerDAO Customer { get; set; }
        [DataMember]
        public string CardNumber { get; set; }
        [DataMember]
        public string CardHolderName { get; set; }
        [DataMember]
        public int ExpirationDate { get; set; }
        [DataMember]
        public int CVC { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}