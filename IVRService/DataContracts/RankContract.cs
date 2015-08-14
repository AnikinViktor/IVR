using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class RankContract
    {
        public RankContract(Rank rank)
        {
            this.ID = rank.ID;
            this.Name = rank.Name;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}