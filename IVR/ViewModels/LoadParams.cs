using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.ViewModels
{
    /// <summary>
    /// Параметры загрузки данных в модель представления
    /// </summary>
    class LoadParams
    {
        public LoadParams(object argument)
        {
            this._Argument = argument;
        }

        public LoadParams(bool cancel)
        {
            this._Cancel = cancel;
        }

        public LoadParams(object argument, bool cancel)
        {
            this._Argument = argument;
            this._Cancel = cancel;
        }

        private object _Argument = null;

        /// <summary>
        /// Параметры загрузки данных
        /// </summary>
        public object Argument
        {
            get { return this._Argument; }
        }

        private bool _Cancel = false;

        /// <summary>
        /// Флаг того, что загрузка данных не требуется
        /// </summary>
        public bool Cancel
        {
            get { return this._Cancel; }
        }
    }
}
