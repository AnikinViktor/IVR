using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PromotionContract
    {
        public PromotionContract(Promotion promotion)
        {
            this.ID = promotion.ID;
            this.Date = promotion.Date;
            this.InputDateTime = promotion.InputDateTime;
            this.IDPerson = promotion.IDPerson;
            this.Document = promotion.Document;
            this.IDDocumentInitiator = promotion.IDDocumentInitiator;
            this.IDPromotionType = promotion.IDPromotionType;
            this.Description = promotion.Description;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime InputDateTime { get; set; }

        [DataMember]
        public int IDPerson { get; set; }

        [DataMember]
        public string Document { get; set; }

        [DataMember]
        public int IDDocumentInitiator { get; set; }

        [DataMember]
        public int IDPromotionType { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}