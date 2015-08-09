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
            this.Promotions = new HashSet<Promotion>();
            this.Works = new HashSet<Work>();
            this.Works1 = new HashSet<Work>();
        }
    
        public int ID { get; set; }
        public string FIO { get; set; }
        public int IDOrganization { get; set; }
        public int IDPosition { get; set; }
        public int IDRank { get; set; }
        public string BirthdayInfo { get; set; }
        public string Education { get; set; }
        public Nullable<byte> YearStart { get; set; }
        public Nullable<System.DateTime> DatePosition { get; set; }
        public Nullable<System.DateTime> DateRank { get; set; }
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
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Penalty> Penalties { get; set; }
        public virtual Position Position { get; set; }
        public virtual Rank Rank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work> Works { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work> Works1 { get; set; }
    }
}
