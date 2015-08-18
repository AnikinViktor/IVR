using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PromotionTypeContract
    {
        public PromotionTypeContract(PromotionType promotion)
        {
            this.ID = promotion.ID;
            this.Name = promotion.Name;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}