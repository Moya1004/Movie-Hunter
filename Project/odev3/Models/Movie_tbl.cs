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
    
    public partial class Movie_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie_tbl()
        {
            this.Casts = new HashSet<Cast>();
            this.Comments_tbl = new HashSet<Comments_tbl>();
            this.News = new HashSet<News>();
        }
    
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string MovieGenre { get; set; }
        public string MoviePoster { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> NumberOfRatings { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Trailer { get; set; }
        public Nullable<int> NumberOfComments { get; set; }
        public string Country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cast> Casts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_tbl> Comments_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }
    }
}
