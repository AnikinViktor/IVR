using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient
{
    class Helper : INotifyPropertyChanged
    {
        private Helper() { }

        public static Helper I = new Helper();

        #region Service
        private ServiceClient srv = new ServiceClient();

        public ServiceClient Srv
        {
            get { return this.srv;  }
        }
        #endregion

        #region Год
        private int _Year = DateTime.Now.Year;

        public int Year
        {
            get
            {
                return this._Year;
            }
            set
            {
                this._Year = value;
                RaisePropertyChanged("Year");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
