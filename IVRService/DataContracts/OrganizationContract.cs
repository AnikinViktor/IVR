using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class OrganizationContract
    {
        public OrganizationContract(Organization organization)
        {
            this.ID = organization.ID;
            this.Name = organization.Name;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}