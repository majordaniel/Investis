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
    
    public partial class tb_BusinessCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BusinessCategory()
        {
            this.tb_BusinessOwners = new HashSet<tb_BusinessOwners>();
        }
    
        public int BusinessCatID { get; set; }
        public string BusinessCategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BusinessOwners> tb_BusinessOwners { get; set; }
    }
}
