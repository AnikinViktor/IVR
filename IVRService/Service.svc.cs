using IVRService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IVRService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service.svc или Service.svc.cs в обозревателе решений и начните отладку.
    public class Service : IService
    {
        public List<GroupContract> GetGroups()
        {
            List<GroupContract> result = new List<GroupContract>();

            PersonContract person = new PersonContract
            {
                FIO = "Аникин Виктор Геннадьевич"
            };

            GroupContract group = new GroupContract
            {
                Name = "Группа ИТО, С и В",
                Persons = new List<PersonContract> { person }
            };

            result.Add(group);

            return result;
        }
    }
}
