using IVR.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR
{
    class Helper
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
    }
}
