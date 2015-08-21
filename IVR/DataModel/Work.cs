using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class Work
    {
        public Work(WorkContract work)
        {
            this.ID = work.ID;
            this.Date = work.Date;
            this.InputDateTime = work.InputDateTime;
            //this.IDPerson = work.IDPerson;
            this.WorkDescription = work.WorkDescription;
            this.Resolution = work.Resolution;
            this.PersonInitiator = work.PersonInitiator;
        }

        public static List<Work> Convert(WorkContract[] works)
        {
            List<Work> result = new List<Work>();
            for (int i = 0; i <= works.Length - 1; ++i)
            {
                result.Add(new Work(works[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime InputDateTime { get; set; }

        public string WorkDescription { get; set; }

        public string Resolution { get; set; }

        public string PersonInitiator { get; set; }
    }
}
