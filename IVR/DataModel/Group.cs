using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    public class Group : BaseDataModel
    {
        /// <summary>
        /// Конструктор.
        /// Преобразует контракт данных в модель данных приложения
        /// </summary>
        /// <param name="group"></param>
        public Group(GroupContract group)
        {
            this.ID = group.ID;
            this.Name = group.Name;
            //this.StartYear = group.StartYear;
            //this.StopYear = group.StopYear;

            this.Persons = new ObservableCollection<Person>();
            for (int i = 0; i < group.Persons.Length; ++i)
            {
                this.Persons.Add(new Person(group.Persons[i]));
            }
        }

        public static List<Group> Convert(GroupContract[] groups)
        {
            List<Group> result = new List<Group>();
            for (int i = 0; i <= groups.Length - 1; ++i)
            {
                result.Add(new Group(groups[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int StartYear { get; set; }

        public int StopYear { get; set; }

        public ObservableCollection<Person> Persons { get; set; }
    }
}
