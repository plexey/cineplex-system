//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineplexSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders30028452
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders30028452()
        {
            this.MovieOrders30028452 = new HashSet<MovieOrders30028452>();
        }
    
        public int OrderId { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer30028452 Customer30028452 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieOrders30028452> MovieOrders30028452 { get; set; }
    }
}
