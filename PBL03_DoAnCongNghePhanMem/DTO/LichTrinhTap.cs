//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichTrinhTap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichTrinhTap()
        {
            this.BaiTaps = new HashSet<BaiTap>();
        }
    
        public int IDLT { get; set; }
        public Nullable<int> IDGT { get; set; }
        public string HuongDanTap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiTap> BaiTaps { get; set; }
        public virtual GoiTap GoiTap { get; set; }
    }
}
