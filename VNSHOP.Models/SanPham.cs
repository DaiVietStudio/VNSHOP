namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietPhieuBanHangs = new HashSet<ChiTietPhieuBanHang>();
            ChiTietPhieuNhapKhoes = new HashSet<ChiTietPhieuNhapKho>();
            DonViTinh_SanPham = new HashSet<DonViTinh_SanPham>();
            KhoHang_SanPham = new HashSet<KhoHang_SanPham>();
        }

        public long id { get; set; }

        [StringLength(1000)]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        public string MaSanPham { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }

        public double? GiaNhap { get; set; }

        public double? GiaLe { get; set; }

        public long? DonViTinh { get; set; }

        public double? ThueVAT { get; set; }

        public bool? KichHoat { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public long? QuanLyTonKho { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySanXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public double? GiaSi { get; set; }

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
