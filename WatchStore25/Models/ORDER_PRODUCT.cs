//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchStore25.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_PRODUCT()
        {
            this.DETAIL_ORDER = new HashSet<DETAIL_ORDER>();
        }
    
        public int idOrderProduct { get; set; }
        public Nullable<int> idCustomer { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string noteOrder { get; set; }
        public Nullable<bool> idStatusOrder { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAIL_ORDER> DETAIL_ORDER { get; set; }
        public virtual STATUS_ORDER STATUS_ORDER { get; set; }
    }
}
