using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace IVRClient.DataModel
{
    public class Person : BaseDataModel
    {
        /// <summary>
        /// Конструктор.
        /// Преобразует контракт данных в модель данных приложения
        /// </summary>
        /// <param name="person"></param>
        public Person(PersonContract person)
        {
            this.ID = person.ID;
            this._FIO = person.FIO;
        }

        
        public int ID { get; set; }

        private string _FIO = string.Empty;
        [Required]
        [MinLength(10, ErrorMessage = "Длина Ф.И.О. должна быть не менее 10 символов")]
        public string FIO
        {
            get
            {
                return this._FIO;
            }
            set
            {
                _FIO = value;
                ValidateProperty(value);
                RaisePropertyChanged("FIO");
            }
        }
    }
}
