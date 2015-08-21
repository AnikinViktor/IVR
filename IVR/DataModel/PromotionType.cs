using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class PromotionType
    {
        public PromotionType(PromotionTypeContract promotionType)
        {
            this.ID = promotionType.ID;
            this.Name = promotionType.Name;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public static List<PromotionType> Convert(PromotionTypeContract[] promotionTypes)
        {
            List<PromotionType> result = new List<PromotionType>();
            for (int i = 0; i <= promotionTypes.Length - 1; ++i)
            {
                result.Add(new PromotionType(promotionTypes[i]));
            }
            return result;
        }
    }
}
