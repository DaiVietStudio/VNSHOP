using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class ChiTietPhieuBanHang
    {
        public long Id { get; set; }
        public long? Phieu { get; set; }
        public long? SanPham { get; set; }
        public double? SoLuong { get; set; }
        public double? GiaBan { get; set; }
        public double? GiamGia { get; set; }
        public string DonViTinh { get; set; }

        public virtual PhieuBanHang PhieuNavigation { get; set; }
        public virtual SanPham SanPhamNavigation { get; set; }
    }
}
