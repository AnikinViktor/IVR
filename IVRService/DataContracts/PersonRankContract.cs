using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PersonRankContract
    {
        public PersonRankContract(PersonRank personRank)
        {
            this.ID = personRank.ID;
            this.IDRank = personRank.IDRank;
            this.Date = personRank.Date;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int IDRank { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}