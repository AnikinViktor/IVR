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

namespace IVR.DataModel
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
    
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private object _lock = new object();

        public void ValidateProperty(object value, [CallerMemberName] string propertyName = null)
        {
            lock (_lock)
            {
                var validationContext = new ValidationContext(this, null, null);
                validationContext.MemberName = propertyName;
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateProperty(value, validationContext, validationResults);

                //clear previous _errors from tested property  
                if (modelErrors.ContainsKey(propertyName))
                {
                    modelErrors.Remove(propertyName);
                }
                RaiseErrorsChanged(propertyName);
                HandleValidationResults(validationResults);
            }
        }

        public void Validate()
        {
            lock (_lock)
            {
                var validationContext = new ValidationContext(this, null, null);
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateObject(this, validationContext, validationResults, true);

                //clear all previous _errors  
                var propNames = modelErrors.Keys.ToList();
                modelErrors.Clear();
                propNames.ForEach(pn => RaiseErrorsChanged(pn));
                HandleValidationResults(validationResults);
            }
        }

        private void HandleValidationResults(List<ValidationResult> validationResults)
        {
            //Group validation results by property names  
            var resultsByPropNames = from res in validationResults
                                     from mname in res.MemberNames
                                     group res by mname into g
                                     select g;
            //add _errors to dictionary and inform binding engine about _errors  
            foreach (var prop in resultsByPropNames)
            {
                var messages = prop.Select(r => r.ErrorMessage).ToList();
                modelErrors.Add(prop.Key, messages);
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
