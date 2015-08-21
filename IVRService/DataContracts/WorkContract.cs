using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class WorkContract
    {
        public WorkContract(Work work)
        {
            this.ID = work.ID;
            this.Date = work.Date;
            this.InputDateTime = work.InputDateTime;
            //this.IDPerson = work.IDPerson;
            this.WorkDescription = work.WorkDescription;
            this.Resolution = work.Resolution;
            this.PersonInitiator = work.PersonInitiator;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime InputDateTime { get; set; }

        //[DataMember]
        //public int IDPerson { get; set; }

        [DataMember]
        public string WorkDescription { get; set; }

        [DataMember]
        public string Resolution { get; set; }

        [DataMember]
        public string PersonInitiator { get; set; }
    }
}