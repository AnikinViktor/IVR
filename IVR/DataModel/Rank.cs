using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    public class Rank : BaseDataModel
    {
        public Rank(RankContract rank)
        {
            this.ID = rank.ID;
            this.Name = rank.Name;
        }

        public static List<Rank> Convert(RankContract[] ranks)
        {
            List<Rank> result = new List<Rank>();

            for (int i = 0; i <= ranks.Length - 1; ++i)
            {
                result.Add(new Rank(ranks[i]));
            }

            return result;
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
