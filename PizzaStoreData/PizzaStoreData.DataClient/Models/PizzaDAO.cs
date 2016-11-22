using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class PizzaDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public SizeDAO Size { get; set; }
        [DataMember]
        public CrustDAO Crust { get; set; }
        [DataMember]
        public SauceDAO Sauce { get; set; }
        [DataMember]
        public CheeseDAO Cheese { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}