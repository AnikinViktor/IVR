using IVRClient.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IVRClient.ViewModels
{
    class CalendarViewModel : BaseViewModel
    {
        public CalendarViewModel()
        {
            
            DateTime startDate = new DateTime(2015, 1, 1);
            DateTime stopDate = new DateTime(2015, 12, 31);

            //if(startDate.DayOfWeek != DayOfWeek.Monday)
            //    _Weeks.Add(new Week());

            for (DateTime date = startDate; date <= stopDate; date = date.AddDays(1))
            {
                if(date.DayOfWeek == DayOfWeek.Monday || date.Day == 1)
                    _Weeks.Add(new Week());

                _Weeks.Last().AddDay(date);
            }
        }

        private List<Week> _Weeks = new List<Week>();

        public List<Week> Weeks
        {
            get
            {
                return this._Weeks;
            }
            set
            {
                this._Weeks = value;
                RaisePropertyChanged("Weeks");
            }
        }

        protected override object LoadData()
        {
            throw new NotImplementedException();
        }

        protected override void SetLoadingResult(RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
