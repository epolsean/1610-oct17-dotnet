using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class CheeseToppingDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public PizzaDAO Pizza { get; set; }
        [DataMember]
        public CheeseDAO Cheese { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}