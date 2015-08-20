using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class Penalty
    {
        public Penalty(PenaltyContract penalty)
        {
            this.ID = penalty.ID;
            this.Date = penalty.Date;
            this.InputDateTime = penalty.InputDateTime;
            this.Document = penalty.Document;
            this.IDDocumentInitiator = penalty.IDDocumentInitiator;
            this.IDPenaltyType = penalty.IDPenaltyType;
            this.Description = penalty.Description;
            this.DocumentDestroy = penalty.DocumentDestroy;
            this.IDPerson = penalty.IDPerson;
        }

        public static List<Penalty> Convert(PenaltyContract[] penalties)
        {
            List<Penalty> result = new List<Penalty>();
            for(int i = 0; i <= penalties.Length - 1; ++i)
            {
                result.Add(new Penalty(penalties[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime InputDateTime { get; set; }

        public string Document { get; set; }

        public int IDDocumentInitiator { get; set; }

        public int IDPenaltyType { get; set; }

        public string Description { get; set; }

        public string DocumentDestroy { get; set; }

        public int IDPerson { get; set; }

        public override bool Equals(object obj)
        {
            Penalty penalty = obj as Penalty;

            if (penalty == null || this.ID != penalty.ID)
                return false;
            else
                return true;
        }
    }
}
