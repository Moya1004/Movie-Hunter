//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odev3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movies_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movies_tbl()
        {
            this.Cast_tbl = new HashSet<Cast_tbl>();
            this.News_tbl = new HashSet<News_tbl>();
            this.Rating_tbl = new HashSet<Rating_tbl>();
            this.Reviews_tbl = new HashSet<Reviews_tbl>();
        }
    
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string MovieGenre { get; set; }
        public string MoviePoster { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Trailer { get; set; }
        public string Country { get; set; }
        public Nullable<double> Rating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cast_tbl> Cast_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News_tbl> News_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating_tbl> Rating_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews_tbl> Reviews_tbl { get; set; }
    }
}
