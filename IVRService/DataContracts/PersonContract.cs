using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PersonContract
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string FIO { get; set; }
    }
}