//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odev3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rating_tbl()
        {
            this.Reviews_tbl = new HashSet<Reviews_tbl>();
        }
    
        public int RatingID { get; set; }
        public Nullable<double> Rating { get; set; }
        public int MovieID { get; set; }
        public string UserName { get; set; }
    
        public virtual Movies_tbl Movies_tbl { get; set; }
        public virtual Users_tbl Users_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews_tbl> Reviews_tbl { get; set; }
    }
}
