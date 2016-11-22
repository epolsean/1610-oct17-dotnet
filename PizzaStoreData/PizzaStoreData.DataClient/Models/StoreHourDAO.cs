using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class StoreHourDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int OpeningTime { get; set; }
        [DataMember]
        public int ClosingTime { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}