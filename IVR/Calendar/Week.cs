using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.Calendar
{
    class Week
    {
        private Day[] _Days = new Day[7];
        private Dictionary<DayOfWeek, int> _DaysOfWeek = new Dictionary<DayOfWeek, int>();

        public Day this [int index]
        {
            get { return this._Days[index];  }
        }

        public Week()
        {
            _DaysOfWeek.Add(DayOfWeek.Monday, 0);
            _DaysOfWeek.Add(DayOfWeek.Tuesday, 1);
            _DaysOfWeek.Add(DayOfWeek.Wednesday, 2);
            _DaysOfWeek.Add(DayOfWeek.Thursday, 3);
            _DaysOfWeek.Add(DayOfWeek.Friday, 4);
            _DaysOfWeek.Add(DayOfWeek.Saturday, 5);
            _DaysOfWeek.Add(DayOfWeek.Sunday, 6);
        }

        public void AddDay(DateTime date)
        {
            int i = (int)date.DayOfWeek;
            _Days[_DaysOfWeek[date.DayOfWeek]] = new Day(date);
        }
    }
}
