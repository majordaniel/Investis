//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Investis.DomainModel.GeneratedModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Banks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Banks()
        {
            this.tb_Beneficiaries = new HashSet<tb_Beneficiaries>();
            this.tb_BusinessApplications = new HashSet<tb_BusinessApplications>();
            this.tb_BusinessOwners = new HashSet<tb_BusinessOwners>();
            this.tb_Investors = new HashSet<tb_Investors>();
        }
    
        public int BankID { get; set; }
        public string BankName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Beneficiaries> tb_Beneficiaries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BusinessApplications> tb_BusinessApplications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BusinessOwners> tb_BusinessOwners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Investors> tb_Investors { get; set; }
    }
}
