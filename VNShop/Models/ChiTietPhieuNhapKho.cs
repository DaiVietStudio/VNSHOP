//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VNShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhapKho
    {
        public long id { get; set; }
        public Nullable<long> Phieu { get; set; }
        public Nullable<long> SanPham { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
    
        public virtual PhieuNhapKho PhieuNhapKho { get; set; }
        public virtual SanPham SanPham1 { get; set; }
    }
}
