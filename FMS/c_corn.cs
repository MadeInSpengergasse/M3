//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class c_corn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public c_corn()
        {
            this.p_property = new HashSet<p_property>();
            this.f_farmer = new HashSet<f_farmer>();
        }
    
        public int c_id { get; set; }
        public string c_type { get; set; }
        public Nullable<int> c_class { get; set; }
        public int c_dour { get; set; }
        public Nullable<int> c_pr_product { get; set; }
    
        public virtual pr_product pr_product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_property> p_property { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<f_farmer> f_farmer { get; set; }
    }
}