using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IVRService.DataContracts
{
    [DataContract]
    public class PersonContract
    {
        public PersonContract(Person person, PersonRank lastRank)
        {
            FillProperties(person);
        }

        public PersonContract(Person person)
        {
            FillProperties(person);
        }

        private void FillProperties(Person person)
        {
            this.ID = person.ID;
            this.FIO = person.FIO;
            this.BirthdayDate = person.BirthdayDate;
            this.BirthdayInfo = person.BirthdayInfo;
            this.Education = person.Education;
            this.YearStart = person.YearStart;
            this.Address = person.Address;
            this.Family = person.Family;
            this.JobFamily = person.JobFamily;
            this.CommunityInfo = person.CommunityInfo;
            this.Sport = person.Sport;
            this.War = person.War;
            this.Presents = person.Presents;
            this.Hobby = person.Hobby;
            this.ReflectionInJob = person.ReflectionInJob;
            this.ReflectionInFamily = person.ReflectionInFamily;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string FIO { get; set; }

        [DataMember]
        public DateTime BirthdayDate { get; set; }

        [DataMember]
        public string BirthdayInfo { get; set; }

        [DataMember]
        public string Education { get; set; }

        [DataMember]
        public int? YearStart { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Family { get; set; }

        [DataMember]
        public string JobFamily { get; set; }

        [DataMember]
        public string CommunityInfo { get; set; }

        [DataMember]
        public string Sport { get; set; }

        [DataMember]
        public string War { get; set; }

        [DataMember]
        public string Presents { get; set; }

        [DataMember]
        public string Hobby { get; set; }

        [DataMember]
        public string ReflectionInJob { get; set; }

        [DataMember]
        public string ReflectionInFamily { get; set; }
    }
}