using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class CustomerDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public NameDAO Name { get; set; }
        [DataMember]
        public AddressDetailDAO Address { get; set; }
        [DataMember]
        public EmailDAO Email { get; set; }
        [DataMember]
        public PhoneDAO Phone { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}