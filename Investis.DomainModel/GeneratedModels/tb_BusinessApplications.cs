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
    
    public partial class tb_BusinessApplications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BusinessApplications()
        {
            this.tb_Disbursements = new HashSet<tb_Disbursements>();
            this.tb_Guarantors = new HashSet<tb_Guarantors>();
            this.tb_Repayments = new HashSet<tb_Repayments>();
        }
    
        public int AppID { get; set; }
        public Nullable<int> BusinessID { get; set; }
        public string ExpectedAmount { get; set; }
        public string RepaymentPlan { get; set; }
        public string DefiniteFund { get; set; }
        public string MinFund { get; set; }
        public string MaxFund { get; set; }
        public string RepaymentDuration { get; set; }
        public string MonthlyRepayment { get; set; }
        public string AccountNo { get; set; }
        public Nullable<int> BankID { get; set; }
        public string SortCode { get; set; }
        public string AccountName { get; set; }
        public string Status { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<int> VerifierUserID { get; set; }
        public string VerificationDetails { get; set; }
        public Nullable<System.DateTime> VerificationDate { get; set; }
        public Nullable<bool> IsDisbursed { get; set; }
        public Nullable<int> DisburserUserID { get; set; }
        public string DisbursementDetails { get; set; }
        public Nullable<System.DateTime> DisbursementDate { get; set; }
        public Nullable<bool> IsFullyRecovered { get; set; }
        public Nullable<System.DateTime> RepaymentStartDate { get; set; }
        public Nullable<System.DateTime> ExpectedRepaymentEndDate { get; set; }
        public Nullable<System.DateTime> GraceDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual tb_Banks tb_Banks { get; set; }
        public virtual tb_BusinessOwners tb_BusinessOwners { get; set; }
        public virtual tb_Users tb_Users { get; set; }
        public virtual tb_Users tb_Users1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Disbursements> tb_Disbursements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Guarantors> tb_Guarantors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Repayments> tb_Repayments { get; set; }
    }
}
