//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPhongGym.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaLamViec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaLamViec()
        {
            this.LichLamViecTrongTuans = new HashSet<LichLamViecTrongTuan>();
        }
    
        public int IDCa { get; set; }
        public string Name { get; set; }
        public Nullable<System.TimeSpan> GioBatDau { get; set; }
        public Nullable<System.TimeSpan> GioKetThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViecTrongTuan> LichLamViecTrongTuans { get; set; }
    }
}
