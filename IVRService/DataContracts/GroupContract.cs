﻿using DataProvider;
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
        public GroupContract(Group group)
        {
            this.ID = group.ID;
            this.Name = group.Name;
            this.Persons = new List<PersonContract>();
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<PersonContract> Persons { get; set; }
    }
}