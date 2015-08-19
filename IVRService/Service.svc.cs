using DataProvider;
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
        public List<GroupContract> GetGroupsWithPersons()
        {
            List<GroupContract> result = new List<GroupContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach(Group gr in ctx.Groups.OrderBy(s => s.Name))
                {
                    GroupContract group = new GroupContract(gr);
                    foreach (Person pr in gr.People.OrderBy(s => s.FIO))
                    {

                        PersonRank rank = pr.PersonRanks.OrderByDescending(s => s.Date).First();
                        group.Persons.Add(new PersonContract(pr, rank));
                    }
                    result.Add(group);
                }
            }

            return result;
        }

        public List<PenaltyContract> GetPenalties(int IDPerson, int year)
        {
            DateTime startYear = new DateTime(year, 1, 1);
            DateTime stopYear = new DateTime(year, 12, 31);

            List<PenaltyContract> result = new List<PenaltyContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach (Penalty p in ctx.Penalties.Where(x => x.IDPerson == IDPerson).OrderBy(x => x.Date))
                {
                    result.Add(new PenaltyContract(p));
                }
            }

            return result;
        }

        public List<PromotionContract> GetPromotions(int IDPerson, int year)
        {
            List<PromotionContract> result = new List<PromotionContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach (Promotion p in ctx.Promotions.Where(x => x.IDPerson == IDPerson).OrderBy(x => x.Date))
                {
                    result.Add(new PromotionContract(p));
                }
            }

            return result;
        }

        public List<WorkContract> GetWorks(int IDPerson, int year)
        {
            List<WorkContract> result = new List<WorkContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach (Work w in ctx.Works.Where(x => x.IDPerson == IDPerson).OrderBy(x => x.Date))
                {
                    result.Add(new WorkContract(w));
                }
            }

            return result;
        }
    }
}
