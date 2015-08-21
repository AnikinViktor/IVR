using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class Promotion
    {
        public Promotion(PromotionContract promotion)
        {
            this.ID = promotion.ID;
            this.Date = promotion.Date;
            this.InputDateTime = promotion.InputDateTime;
            this.Document = promotion.Document;
            this.IDDocumentInitiator = promotion.IDDocumentInitiator;
            this.IDPromotionType = promotion.IDPromotionType;
            this.Description = promotion.Description;
        }

        public static List<Promotion> Convert(PromotionContract[] promotions)
        {
            List<Promotion> result = new List<Promotion>();
            for (int i = 0; i <= promotions.Length - 1; ++i)
            {
                result.Add(new Promotion(promotions[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime InputDateTime { get; set; }

        public string Document { get; set; }

        public int IDDocumentInitiator { get; set; }

        public int IDPromotionType { get; set; }

        public string Description { get; set; }
    }
}
