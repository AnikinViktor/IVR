using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    public class Rank : BaseDataModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            Rank rank = obj as Rank;

            if (rank == null || this.ID != rank.ID)
                return false;
            else
                return true;
        }
    }
}
