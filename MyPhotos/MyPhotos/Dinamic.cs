//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace MyPhotos
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class Dinamic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dinamic()
        {
            this.MyItems = new HashSet<MyItems>();
        }
        [DataMember]
        public int DId { get; set; }
        [DataMember]
        public string DDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<MyItems> MyItems { get; set; }
    }
}
