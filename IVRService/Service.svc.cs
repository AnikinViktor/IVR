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
        public List<GroupContract> GetGroupsWithPersons(int IDDepartment)
        {
            List<GroupContract> result = new List<GroupContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach(Group gr in ctx.Groups.Where(x => x.IDDepartment == IDDepartment).OrderBy(s => s.Name))
                {
                    GroupContract group = new GroupContract(gr);
                    foreach (Person pr in gr.People.OrderBy(s => s.FIO))
                    {
                        PersonRank rank = pr.PersonRanks.OrderByDescending(s => s.Date).FirstOrDefault();
                        group.Persons.Add(new PersonContract(pr, rank));
                    }
                    result.Add(group);
                }
            }

            return result;
        }

        public List<PenaltyTypeContract> GetPenaltyTypes()
        {
            List<PenaltyTypeContract> result = new List<PenaltyTypeContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach (PenaltyType penalty in ctx.PenaltyTypes.OrderBy(x => x.Order))
                {
                    result.Add(new PenaltyTypeContract(penalty));
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

        public List<PromotionTypeContract> GetPromotionTypes()
        {
            List<PromotionTypeContract> result = new List<PromotionTypeContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach (PromotionType promotion in ctx.PromotionTypes.OrderBy(x => x.Order))
                {
                    result.Add(new PromotionTypeContract(promotion));
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

        public List<PersonRankContract> GetPersonRanks(int IDPerson)
        {
            List<PersonRankContract> result = new List<PersonRankContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach(PersonRank pr in ctx.PersonRanks.Where(x => x.IDPerson == IDPerson).OrderByDescending(x => x.Date))
                {
                    result.Add(new PersonRankContract(pr));
                }
            }

            return result;
        }

        public List<RankContract> GetRanks()
        {
            List<RankContract> result = new List<RankContract>();

            using (IVREntities ctx = new IVREntities())
            {
                foreach(Rank r in ctx.Ranks.OrderBy(x => x.Order))
                {
                    result.Add(new RankContract(r));
                }
            }

            return result;
        }

        public List<OrganizationContract> GetOrganizationInitiators(int IDOrganization)
        {
            List<OrganizationContract> result = new List<OrganizationContract>();

            using (IVREntities ctx = new IVREntities())
            {
                Organization currentOrganization = ctx.Organizations.Single(x => x.ID == IDOrganization);
                foreach(Organization org in ctx.Organizations.Where(x => x.ID == IDOrganization || x.Level < currentOrganization.Level).OrderByDescending(x => x.Level))
                {
                    result.Add(new OrganizationContract(org));
                }
            }

            return result;
        }
    }
}
