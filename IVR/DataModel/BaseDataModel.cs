using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    public abstract class BaseDataModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region Обработка ошибок
        /// <summary>
        /// Перечень ошибок валидации
        /// </summary>
        protected Dictionary<string, List<string>> modelErrors = new Dictionary<string, List<string>>();

        /// <summary>
        /// Проверяет есть ли ошибки валидации
        /// </summary>
        public bool HasErrors
        {
            get { return modelErrors.Count > 0; }
        }
        
        /// <summary>
        /// Событие, указывающее что изменен перечень ошибок
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        /// <summary>
        /// Вызывает событие изменения перечня ошибок
        /// </summary>
        /// <param name="propertyName"></param>
        private void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Блокировка при асинхронной проверке данных
        /// </summary>
        private object _lock = new object();

        public void ValidateProperty(object value, [CallerMemberName] string propertyName = null)
        {
            lock (_lock)
            {
                // Выполняется проверка посредством атрибутов свойств
                var validationContext = new ValidationContext(this, null, null);
                validationContext.MemberName = propertyName;
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateProperty(value, validationContext, validationResults);

                // Очищаем перечень ошибок  
                if (modelErrors.ContainsKey(propertyName))
                {
                    modelErrors.Remove(propertyName);
                }
                // Сообщаем что перечень ошибок изменен
                RaiseErrorsChanged(propertyName);
                // Обрабатываем результаты валидации
                HandleValidationResults(validationResults);
            }
        }

        /// <summary>
        /// Валидация всех свойств объекта
        /// </summary>
        public void Validate()
        {
            lock (_lock)
            {
                var validationContext = new ValidationContext(this, null, null);
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateObject(this, validationContext, validationResults, true);

                // Очищаем перечень ошибок   
                var propNames = modelErrors.Keys.ToList();
                modelErrors.Clear();
                propNames.ForEach(pn => RaiseErrorsChanged(pn));
                HandleValidationResults(validationResults);
            }
        }

        /// <summary>
        /// Обработчик результатов валидации
        /// </summary>
        /// <param name="validationResults"></param>
        private void HandleValidationResults(List<ValidationResult> validationResults)
        {
            // Группировка списка по имени свойства
            var resultsByPropNames = from res in validationResults
                                     from mname in res.MemberNames
                                     group res by mname into g
                                     select g;

            // Обходим результаты валидации 
            foreach (var prop in resultsByPropNames)
            {
                // Извлекаем сообщения об ошибке
                var messages = prop.Select(r => r.ErrorMessage).ToList();
                // Добавляем сообщения с ошибками в список
                modelErrors.Add(prop.Key, messages);
                // Сообщаем об измененях свойств
                RaiseErrorsChanged(prop.Key);
            }
        }
        #endregion

        /// <summary>
        /// Событие изменения свойств
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName))
            {
                if (modelErrors.ContainsKey(propertyName) && (modelErrors[propertyName] != null) && modelErrors[propertyName].Count > 0)
                    return modelErrors[propertyName].ToList();
                else
                    return null;
            }
            else
                return modelErrors.SelectMany(err => err.Value.ToList());
        }


        /// <summary>
        /// Вызывает событие изменения свойста
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
