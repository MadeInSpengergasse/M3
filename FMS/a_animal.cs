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
    
    public partial class a_animal
    {
        public int a_id { get; set; }
        public string a_species { get; set; }
        public float a_age { get; set; }
        public float a_weight { get; set; }
        public int a_classification { get; set; }
        public Nullable<int> f_farmer_f_id { get; set; }
        public Nullable<int> a_pr_product { get; set; }
    
        public virtual f_farmer f_farmer { get; set; }
        public virtual pr_product pr_product { get; set; }
    }
}
