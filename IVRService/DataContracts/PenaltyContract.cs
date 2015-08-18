using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PenaltyContract
    {
        public PenaltyContract(Penalty penalty)
        {
            this.ID = penalty.ID;
            this.Date = penalty.Date;
            this.InputDateTime = penalty.Date;
            this.Document = penalty.Document;
            this.IDDocumentInitiator = penalty.IDDocumentInitiator;
            this.IDPenaltyType = penalty.IDPenaltyType;
            this.Description = penalty.Description;
            this.DocumentDestroy = penalty.DocumentDestroy;
            this.IDPerson = penalty.IDPerson;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime InputDateTime { get; set; }

        [DataMember]
        public string Document { get; set; }

        [DataMember]
        public int IDDocumentInitiator { get; set; }

        [DataMember]
        public int IDPenaltyType { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string DocumentDestroy { get; set; }

        [DataMember]
        public int IDPerson { get; set; }
    }
}