using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PenaltyTypeContract
    {
        public PenaltyTypeContract(PenaltyType penalty)
        {
            this.ID = penalty.ID;
            this.Name = penalty.Name;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}