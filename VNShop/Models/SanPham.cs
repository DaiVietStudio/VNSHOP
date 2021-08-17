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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietPhieuBanHangs = new HashSet<ChiTietPhieuBanHang>();
            this.ChiTietPhieuNhapKhoes = new HashSet<ChiTietPhieuNhapKho>();
            this.DonViTinh_SanPham = new HashSet<DonViTinh_SanPham>();
            this.KhoHang_SanPham = new HashSet<KhoHang_SanPham>();
        }
    
        public long id { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string MoTa { get; set; }
        public Nullable<double> GiaNhap { get; set; }
        public Nullable<double> GiaLe { get; set; }
        public Nullable<long> DonViTinh { get; set; }
        public Nullable<double> ThueVAT { get; set; }
        public Nullable<bool> KichHoat { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<long> QuanLyTonKho { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public Nullable<double> GiaSi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhoes { get; set; }
        public virtual DonViTinh DonViTinh1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonViTinh_SanPham> DonViTinh_SanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoHang_SanPham> KhoHang_SanPham { get; set; }
    }
}
