using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietPhieuBanHangs = new HashSet<ChiTietPhieuBanHang>();
            ChiTietPhieuNhapKhos = new HashSet<ChiTietPhieuNhapKho>();
            DonViTinhSanPhams = new HashSet<DonViTinhSanPham>();
            KhoHangSanPhams = new HashSet<KhoHangSanPham>();
        }

        public long Id { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string MoTa { get; set; }
        public double? GiaNhap { get; set; }
        public double? GiaLe { get; set; }
        public long? DonViTinh { get; set; }
        public double? ThueVat { get; set; }
        public bool? KichHoat { get; set; }
        public byte[] HinhAnh { get; set; }
        public long? QuanLyTonKho { get; set; }
        public DateTime? NgaySanXuat { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public double? GiaSi { get; set; }

        public virtual DonViTinh DonViTinhNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }
        public virtual ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhos { get; set; }
        public virtual ICollection<DonViTinhSanPham> DonViTinhSanPhams { get; set; }
        public virtual ICollection<KhoHangSanPham> KhoHangSanPhams { get; set; }
    }
}
