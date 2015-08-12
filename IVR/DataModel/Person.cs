using IVR.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.DataModel
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
            this.FIO = person.FIO;
        }

        public int ID { get; set; }

        public string FIO { get; set; }
    }
}
