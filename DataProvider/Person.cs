//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.Penalties = new HashSet<Penalty>();
            this.PersonPositions = new HashSet<PersonPosition>();
            this.PersonRanks = new HashSet<PersonRank>();
            this.Promotions = new HashSet<Promotion>();
            this.Works = new HashSet<Work>();
            this.Groups = new HashSet<Group>();
        }
    
        public int ID { get; set; }
        public string FIO { get; set; }
        public System.DateTime BirthdayDate { get; set; }
        public string BirthdayInfo { get; set; }
        public string Education { get; set; }
        public Nullable<int> YearStart { get; set; }
        public string Address { get; set; }
        public string Family { get; set; }
        public string JobFamily { get; set; }
        public string CommunityInfo { get; set; }
        public string Sport { get; set; }
        public string War { get; set; }
        public string Presents { get; set; }
        public string Hobby { get; set; }
        public string ReflectionInJob { get; set; }
        public string ReflectionInFamily { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Penalty> Penalties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPosition> PersonPositions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonRank> PersonRanks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work> Works { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
