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
    
    public partial class DanhGiaHLV
    {
        public int IDDG { get; set; }
        public int IDTTLVHLV { get; set; }
        public Nullable<int> SoNgayNghiCoPhep { get; set; }
        public Nullable<int> SoNguoiDaDay { get; set; }
        public Nullable<int> SoNgayNghi { get; set; }
        public Nullable<int> SoBuoiDay { get; set; }
        public Nullable<double> Luong { get; set; }
    
        public virtual TinhTrangLamViecHLV TinhTrangLamViecHLV { get; set; }
    }
}