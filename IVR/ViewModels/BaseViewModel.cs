using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.ViewModels
{
    /// <summary>
    /// Базовый класс модели представления
    /// </summary>
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        private bool _Loading = false;

        /// <summary>
        /// Сообщает о загрузке данных в модель представления
        /// </summary>
        public bool Loading
        {
            get { return this._Loading;  }
            set
            {
                this._Loading = value;
                RaisePropertyChanged("Loading");
            }
        }

        /// <summary>
        /// Событие изменения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие изменения свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Абстрактый класс загрузки данных
        /// </summary>
        abstract public void LoadData();
    }
}
