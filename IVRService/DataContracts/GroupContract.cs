using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class GroupContract
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int StartYear { get; set; }

        [DataMember]
        public int StopYear { get; set; }

        [DataMember]
        public List<PersonContract> Persons { get; set; }
    }
}