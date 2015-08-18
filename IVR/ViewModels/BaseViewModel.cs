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
        /// <summary>
        /// Фоновый поток загрузки данных модели представления
        /// </summary>
        private readonly BackgroundWorker worker = new BackgroundWorker();

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
        /// Конструктор класса
        /// </summary>
        public BaseViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        /// <summary>
        /// Инициирует асинхронную загрузку данных
        /// </summary>
        public void LoadDataAsync()
        {
            Loading = true;
            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Фоновый поток загрузки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = LoadData();
        }

        /// <summary>
        /// Событие завершения загрузки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Вызываем метод присваивания результата загрузки
            SetLoadingResult(e);
            Loading = false;
        }

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
        /// Абстрактый класс асинхронной загрузки данных.
        /// </summary>
        /// <returns>Результат загрузки данных</returns>
        abstract protected object LoadData();

        /// <summary>
        /// Присваивает результат загрузки данных в модель представления
        /// </summary>
        /// <param name="e">Результат загрузки данных</param>
        abstract protected void SetLoadingResult(RunWorkerCompletedEventArgs e);
    }
}
