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
        /// <summary>
        /// Возвращает перечень групп
        /// </summary>
        /// <param name="IDDepartment">Идентификатор отдела</param>
        /// <returns></returns>
        [OperationContract]
        List<GroupContract> GetGroupsWithPersons(int IDDepartment);

        /// <summary>
        /// Возвращает перечень проведенной работы
        /// </summary>
        /// <param name="IDPerson">Идентификатор сотрудника</param>
        /// <param name="year">Год</param>
        /// <returns></returns>
        [OperationContract]
        List<WorkContract> GetWorks(int IDPerson, int year);

        /// <summary>
        /// Возвращает взыскания
        /// </summary>
        /// <param name="IDPerson">Идентификатор сотрудника</param>
        /// <param name="year">Год</param>
        /// <returns></returns>
        [OperationContract]
        List<PenaltyContract> GetPenalties(int IDPerson, int year);

        /// <summary>
        /// Возвращает поощрения
        /// </summary>
        /// <param name="IDPerson">Идентификатор сотрудника</param>
        /// <param name="year">Год</param>
        /// <returns></returns>
        [OperationContract]
        List<PromotionContract> GetPromotions(int IDPerson, int year);

        /// <summary>
        /// Возвращает виды поощрений
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<PromotionTypeContract> GetPromotionTypes();

        /// <summary>
        /// Возвращает виды взысканий
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<PenaltyTypeContract> GetPenaltyTypes();

        /// <summary>
        /// Возвращает список званий сотрудника
        /// </summary>
        /// <param name="IDPerson">Идентификатор сотрудника</param>
        /// <returns></returns>
        [OperationContract]
        List<PersonRankContract> GetPersonRanks(int IDPerson);

        /// <summary>
        /// Возвращает справочник званий
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<RankContract> GetRanks();

        /// <summary>
        /// Возвращает список организаций, которые могут наложить поощрения или взыскания на сотрудников данной организации
        /// </summary>
        /// <param name="IDOrganization"></param>
        /// <returns></returns>
        [OperationContract]
        List<OrganizationContract> GetOrganizationInitiators(int IDOrganization);
    }
}
