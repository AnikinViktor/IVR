using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class PenaltyType
    {
        public PenaltyType(PenaltyTypeContract penaltyType)
        {
            this.ID = penaltyType.ID;
            this.Name = penaltyType.Name;
        }

        public static List<PenaltyType> Convert(PenaltyTypeContract[] penaltyTypes)
        {
            List<PenaltyType> result = new List<PenaltyType>();
            for (int i = 0; i <= penaltyTypes.Length - 1; ++i)
            {
                result.Add(new PenaltyType(penaltyTypes[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            PenaltyType penalty = obj as PenaltyType;

            if (penalty == null || this.ID != penalty.ID)
                return false;
            else
                return true;
        }
    }
}
