using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class ChiTietPhieuNhapKho
    {
        public long Id { get; set; }
        public long? Phieu { get; set; }
        public long? SanPham { get; set; }
        public double? SoLuong { get; set; }
        public double? DonGia { get; set; }

        public virtual PhieuNhapKho PhieuNavigation { get; set; }
        public virtual SanPham SanPhamNavigation { get; set; }
    }
}
