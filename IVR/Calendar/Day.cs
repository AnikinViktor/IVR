using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.Calendar
{
    class Day
    {
        private DateTime _Date;

        public DateTime GetDay
        {
            get { return _Date;  }
        }

        public Day(DateTime date)
        {
            this._Date = date;
        }
    }
}
