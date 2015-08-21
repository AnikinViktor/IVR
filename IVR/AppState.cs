using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient
{
    class AppState : INotifyPropertyChanged
    {
        private AppState() { }

        public static AppState I = new AppState();

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

        #region Идентификатор учреждения
        public int IDOrganization
        {
            get { return 2; }
        }

        public int IDDepartment
        {
            get { return 1; }
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
