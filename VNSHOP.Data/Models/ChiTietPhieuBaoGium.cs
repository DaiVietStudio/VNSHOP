using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class ChiTietPhieuBaoGium
    {
        public long Id { get; set; }
        public long? Phieu { get; set; }
        public int? SanPham { get; set; }
        public double? Gia { get; set; }
        public string SoLuong { get; set; }

        public virtual PhieuBaoGium PhieuNavigation { get; set; }
    }
}
