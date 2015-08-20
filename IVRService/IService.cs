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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<GroupContract> GetGroupsWithPersons();

        [OperationContract]
        List<WorkContract> GetWorks(int IDPerson, int year);

        [OperationContract]
        List<PenaltyContract> GetPenalties(int IDPerson, int year);

        [OperationContract]
        List<PromotionContract> GetPromotions(int IDPerson, int year);

        [OperationContract]
        List<PromotionTypeContract> GetPromotionsType();

        [OperationContract]
        List<PenaltyTypeContract> GetPenaltiesType();
    }
}
