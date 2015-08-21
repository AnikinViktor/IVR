using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class PersonRank
    {
        public PersonRank(PersonRankContract personRank)
        {
            this.ID = personRank.ID;
            this.Date = personRank.Date;
            this.IDRank = personRank.IDRank;
        }

        public static List<PersonRank> Convert(PersonRankContract[] personRanks)
        {
            List<PersonRank> result = new List<PersonRank>();

            for(int i = 0; i <= personRanks.Length - 1; ++i)
            {
                result.Add(new PersonRank(personRanks[i]));
            }

            return result;
        }

        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int IDRank { get; set; }
    }
}
