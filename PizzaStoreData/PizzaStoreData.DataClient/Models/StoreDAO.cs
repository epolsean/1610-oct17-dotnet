using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class StoreDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public AddressDetailDAO Address { get; set; }
        [DataMember]
        public PhoneDAO PhoneNumber { get; set; }
        [DataMember]
        public StoreHourDAO Hours { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}